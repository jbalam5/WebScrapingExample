using DevExpress.XtraGrid.Views.Grid;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WebScraping_Examples.Example1
{
    public partial class Selenium_Search : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Selenium_Search()
        {
            InitializeComponent();
        }

        enum SearchType
        {
            offers,
            Specific
        }

        private void Selenium_Search_Load(object sender, EventArgs e)
        {
            TextSearchLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Por favor, espere");

            if ((SearchType)TypeSearchComboBoxEdit.SelectedIndex == SearchType.offers)
            {
                SearchOffers();
            }
            else
            {
                SearchSpecific();
            }
        }

        private void SearchSpecific()
        {
            try
            {
                var chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                chromeDriverService.SuppressInitialDiagnosticInformation = true;

                ChromeOptions options = new ChromeOptions();
                options.AddArgument("incognito");

                if (!ShowProcessCheckEdit.Checked)
                    options.AddArgument("--headless=new");

                using (OpenQA.Selenium.IWebDriver driver = new ChromeDriver(chromeDriverService, options))
                {
                    splashScreenManager1.SetWaitFormDescription("Iniciando Navegador");
                    SearchType type = (SearchType)TypeSearchComboBoxEdit.SelectedIndex;
                    var window = driver.Manage().Window;
                    window.Maximize();

                    var Navigate = driver.Navigate();
                    Navigate.GoToUrl("https://www.mercadolibre.com.mx");

                    splashScreenManager1.SetWaitFormDescription("Buscando");
                    var SearchBox = driver.FindElement(OpenQA.Selenium.By.Id(Control.ctrl_SearchBox));
                    SearchBox.SendKeys(TextToSearchTextEdit.Text);
                    SearchBox.Submit();

                    var result = driver.FindElement(OpenQA.Selenium.By.ClassName(Control.ctrl_result));

                    DataTable dt = CreateDataTable();

                    if (result != null)
                    {
                        IList<OpenQA.Selenium.IWebElement> ListOfElements = result.FindElements(OpenQA.Selenium.By.TagName("li"));

                        if (ListOfElements.Count <= 0)
                        {
                            MessageBox.Show("Búsqueda Finalizada, no se encontró resultados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        var pagination = driver.FindElement(OpenQA.Selenium.By.ClassName(Control.ctrl_Pagination));
                        IList<OpenQA.Selenium.IWebElement> Pages = pagination.FindElements(OpenQA.Selenium.By.TagName("li"));

                        if (Pages.Count > 0)
                        {
                            splashScreenManager1.SetWaitFormDescription("Recuperando Información");
                            GetResult(1, ListOfElements, ref dt);
                        }

                        ReportGridControl.DataSource = dt;
                    }
                }

                splashScreenManager1.CloseWaitForm();
                
                MessageBox.Show("Búsqueda Finalizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                splashScreenManager1.CloseWaitForm();
                MessageBox.Show(ex.Message, "Se encontró un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchOffers()
        {
            try
            {
                var chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                chromeDriverService.SuppressInitialDiagnosticInformation = true;

                ChromeOptions options = new ChromeOptions();
                options.AddArgument("incognito");

                if (!ShowProcessCheckEdit.Checked)
                    options.AddArgument("--headless=new");

                using (OpenQA.Selenium.IWebDriver driver = new ChromeDriver(chromeDriverService, options))
                {

                    SearchType type = (SearchType)TypeSearchComboBoxEdit.SelectedIndex;
                    var window = driver.Manage().Window;

                    splashScreenManager1.SetWaitFormDescription("Buscando");
                    var Navigate = driver.Navigate();
                    Navigate.GoToUrl("https://www.mercadolibre.com.mx/ofertas");

                    var result = driver.FindElement(OpenQA.Selenium.By.ClassName(Control.ctrl_PromotionResult));

                    DataTable dt = CreateDataTable();

                    if (result != null)
                    {
                        IList<OpenQA.Selenium.IWebElement> ListOfElements = result.FindElements(OpenQA.Selenium.By.TagName("li"));

                        if (ListOfElements.Count <= 0)
                            return;

                        var pagination = driver.FindElement(OpenQA.Selenium.By.ClassName(Control.ctrl_Pagination));
                        IList<OpenQA.Selenium.IWebElement> Pages = pagination.FindElements(OpenQA.Selenium.By.TagName("li"));

                        if (Pages.Count > 0)
                        {
                            int lastPage = Convert.ToInt32(Pages[Pages.Count - 2].Text);
                            string LinkPage = "";

                            LinkPage = Pages.First().FindElement(OpenQA.Selenium.By.TagName("a")).GetAttribute("href").Replace("page=0", "page=");

                            for (int i = 1; i <= lastPage; i++)
                            {
                                string url = $"{LinkPage}{i}";
                                splashScreenManager1.SetWaitFormDescription($"Recuperando Información [{i} de {lastPage}]");
                                GetResult(i, ListOfElements, ref dt);

                                Navigate.GoToUrl(url);

                                result = driver.FindElement(OpenQA.Selenium.By.ClassName(type == SearchType.offers ? Control.ctrl_PromotionResult : Control.ctrl_result));
                                ListOfElements = result.FindElements(OpenQA.Selenium.By.TagName("li"));
                            }
                        }

                        ReportGridControl.DataSource = dt;
                    }
                }

                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Busqueda Finalizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show(ex.Message, "Se encontró un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GetResult(int NoPage, IList<OpenQA.Selenium.IWebElement> ListOfElements, ref DataTable dt)
        {
            foreach (var item in ListOfElements)
            {
                try
                {
                    if ((SearchType)TypeSearchComboBoxEdit.SelectedIndex == SearchType.Specific)
                    {

                        string title = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_title))?.Text;
                        string score = "0";

                        if(item.FindElements(OpenQA.Selenium.By.ClassName("ui-search-reviews__ratings")).Count > 0)
                        {
                            score = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_score))?.Text;
                        }

                        string link = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_link))?.GetAttribute("href");
                        string price = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_Price))?.Text;
                        string image = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_Image))?.GetAttribute("src");

                        dt.Rows.Add(NoPage, title, score, price, image, link);

                    }
                    else
                    {
                        string title = item.FindElement(OpenQA.Selenium.By.ClassName(Control.PromotionResult.ctrl_title))?.Text;
                        string link = item.FindElement(OpenQA.Selenium.By.ClassName(Control.PromotionResult.ctrl_link))?.GetAttribute("href");
                        string price = item.FindElement(OpenQA.Selenium.By.ClassName(Control.PromotionResult.ctrl_Price))?.Text;
                        string image = item.FindElement(OpenQA.Selenium.By.ClassName(Control.PromotionResult.ctrl_Image))?.GetAttribute("src");

                        dt.Rows.Add(NoPage, title, 0, price, image, link);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Page", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Score", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Image", typeof(string));
            dt.Columns.Add("Link", typeof(string));

            return dt;
        }

        private void TypeSearchComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TypeSearchComboBoxEdit.SelectedIndex == 0)
            {
                TextSearchLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                TextSearchLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        Dictionary<string, Image> imageCache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

        private void ReportGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //if (e.Column.FieldName == "Image" && e.IsGetData)
            //{
            //    GridView view = sender as GridView;
            //    string fileName = view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), "Image") as string ?? string.Empty;
            //    if (!imageCache.ContainsKey(fileName))
            //    {
            //        Image img = DownloadImage(fileName);
            //        imageCache.Add(fileName, img);
            //    }
            //    e.Value = imageCache[fileName];
            //}
        }

        private byte[] DownloadImage(string fromUrl)
        {
            try
            {
                var webClient = new System.Net.WebClient();
                byte[] imageBytes = webClient.DownloadData(fromUrl);

                return imageBytes;
            }
            catch
            {
                return null;
            }
            //using (System.Net.WebClient webClient = new System.Net.WebClient())
            //{
            //    using (Stream stream = webClient.OpenRead(fromUrl))
            //    {
            //        return Image.FromStream(stream);
            //    }
            //}
        }
    }

    public class Control
    {
        public const string ctrl_PromotionResult = "items_container";
        public const string ctrl_SearchBox = "cb1-edit";
        public const string ctrl_result = "ui-search-layout";
        public const string ctrl_Pagination = "andes-pagination";

        public class Result
        {
            public const string ctrl_title = "ui-search-item__title";
            public const string ctrl_score = "ui-search-reviews__rating-number";
            public const string ctrl_link = "ui-search-link__title-card";
            public const string ctrl_Price = "andes-money-amount__fraction";
            public const string ctrl_Image = "ui-search-result-image__element";
        }

        public class PromotionResult
        {
            public const string ctrl_title = "promotion-item__title";
            public const string ctrl_link = "promotion-item__link-container";
            public const string ctrl_Price = "andes-money-amount__fraction";
            public const string ctrl_Image = "promotion-item__img";
        }
    }
}
