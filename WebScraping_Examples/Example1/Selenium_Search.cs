using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WebScraping_Examples.Example1
{
    public partial class Selenium_Search : Form
    {
        public Selenium_Search()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                ChromeDriver driver = new ChromeDriver();
                var window = driver.Manage().Window;
                //window.Minimize();

                var Navigate = driver.Navigate();
                Navigate.GoToUrl("https://www.mercadolibre.com.mx/ofertas");



                var SearchBox = driver.FindElement(OpenQA.Selenium.By.Id(Control.ctrl_SearchBox));
                SearchBox.SendKeys(TextToSearchTextBox.Text);
                SearchBox.Submit();

                var result = driver.FindElement(OpenQA.Selenium.By.CssSelector(Control.ctrl_result));

                DataTable dt = CreateDataTable();

                if(result != null)
                {
                    IList<OpenQA.Selenium.IWebElement> ListOfElements = result.FindElements(OpenQA.Selenium.By.TagName("li"));

                    foreach (var item in ListOfElements)
                    {
                        try
                        {
                            var title = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_title))?.Text;
                            var score = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_score))?.Text;
                            var link = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_link))?.GetAttribute("href");
                            var price = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_Price))?.Text;
                            var image = item.FindElement(OpenQA.Selenium.By.ClassName(Control.Result.ctrl_Image))?.GetAttribute("src");

                            dt.Rows.Add(title, score, price, image, link);

                            Console.WriteLine(title);

                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    ReportDataGridView.DataSource = dt;
                }

                MessageBox.Show("Busqueda Finalizada", "Información",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Se encontró un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Score", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Image", typeof(string));
            dt.Columns.Add("Link", typeof(string));

            return dt;
        }
    }

    public class Control
    {
        public const string ctrl_SearchBox = "cb1-edit";
        public const string ctrl_result = "#root-app > div > div.ui-search-main.ui-search-main--only-products.ui-search-main--with-topkeywords > section > ol";

        public class Result
        {
            public const string ctrl_title = "ui-search-item__title";
            public const string ctrl_score = "ui-search-reviews__rating-number";

            public const string ctrl_link = "ui-search-link__title-card";
            public const string ctrl_Price = "andes-money-amount__fraction";
            public const string ctrl_Image = "ui-search-result-image__element";
        }
    }
}
