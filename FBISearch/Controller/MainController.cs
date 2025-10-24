using FBISearch.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;


namespace FBISearch.Controller
{
    public class MainController
    {

        Form1 f;


        Color backgroundColor = ColorTranslator.FromHtml("#00042c");
        Color yellowTextColor = ColorTranslator.FromHtml("#fab636");
        Color whiteTextColor = ColorTranslator.FromHtml("#edeff9");
     

        public MainController()
        {

            Repository.CreateHttpClient();
            f = new Form1();
            f.Hide();
            LoadData();
            SetViewStyle();


            SetListeners();

            f.Show();
            System.Windows.Forms.Application.Run(f);

        }


        private async void LoadData()
        {

            f.wantedList.DataSource = await Repository.GetTopWantedCriminals();
            f.wantedList.ClearSelection();
            f.wantedList.CurrentCell = null;
            f.wantedList.Rows[0].Selected = false;
            Console.WriteLine(f.wantedList.SelectedRows.Count);
            f.downloadPDF.Enabled = false;
            


            f.Publication.Visible = false;
            f.infoContainer.Visible = false;
            

        }



        private void SetViewStyle()
        {
            f.BackColor = backgroundColor;
            f.ForeColor = yellowTextColor;
            foreach (TabPage item in f.tabCtrl.TabPages)
            {
                item.BackColor = backgroundColor;
                item.ForeColor = yellowTextColor;
                
            }

            f.wantedList.BackgroundColor = backgroundColor;
            f.wantedList.ForeColor = whiteTextColor;

            f.searchBtn.BackColor = ColorTranslator.FromHtml("#1e4a81");
            f.searchBtn.ForeColor = whiteTextColor;

            f.downloadPDF.BackColor = ColorTranslator.FromHtml("#1e4a81"); ;
            f.downloadPDF.ForeColor = whiteTextColor;

            
            f.tabCtrl.Dock = DockStyle.Fill;
            f.tabCtrl.DrawMode = TabDrawMode.OwnerDrawFixed;
            f.tabCtrl.DrawItem += TabControl_DrawItem;

            f.wantedList.ForeColor = Color.Black;

            
        }


        // Used ChatGPT to draw tabcontrol colors because its a "follon"
        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;

            // 1. Dibujar el fondo general del TabControl (el área sin pestañas)
            Rectangle tabControlBackground = f.tabCtrl.ClientRectangle;
            using (Brush controlBackgroundBrush = new SolidBrush(yellowTextColor)) // Fondo amarillo para el área sin pestañas
            {
                g.FillRectangle(controlBackgroundBrush, tabControlBackground);
            }

            // 2. Recorrer todas las pestañas y dibujarlas, activas e inactivas
            for (int i = 0; i < f.tabCtrl.TabPages.Count; i++)
            {
                TabPage tabPage = f.tabCtrl.TabPages[i];
                Rectangle tabBounds = f.tabCtrl.GetTabRect(i); // Obtén el área de la pestaña

                // 3. Dibujar el fondo de cada pestaña
                
                using (Brush tabBackgroundBrush = new SolidBrush(backgroundColor))
                {
                    g.FillRectangle(tabBackgroundBrush, tabBounds);
                }

                // 4. Dibujar el texto de la pestaña
                TextRenderer.DrawText(
                    g,
                    tabPage.Text, // Texto de la pestaña
                    f.tabCtrl.Font, // Fuente del texto
                    tabBounds, // Área de la pestaña
                    whiteTextColor, // Color del texto amarillo
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter // Centrado del texto
                );

                // 5. Dibujar un borde amarillo (opcional)
                using (Pen borderPen = new Pen(yellowTextColor, 2))
                {
                    g.DrawRectangle(borderPen, tabBounds); // Borde amarillo alrededor de la pestaña
                }
            }
        }




        private void SetListeners()
        {
            f.searchBtn.Click += ButtonClick;
            f.downloadPDF.Click += ButtonClick;
            f.personsFound.SelectedIndexChanged += PersonsFound_SelectedIndexChanged;
            f.tabCtrl.SelectedIndexChanged += TabCtrl_SelectedIndexChanged;
           
        }

        private void TabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {

            f.wantedList.Rows[0].Selected = false;
            f.wantedList.ClearSelection();
            f.wantedList.CurrentCell = null;
            f.wantedList.SelectionChanged += WantedList_SelectionChanged;



        }

        private void WantedList_SelectionChanged(object sender, EventArgs e)
        {
            Console.WriteLine(f.wantedList.SelectedRows.Count);
            if(f.wantedList.SelectedRows.Count > 0)
            {
                
                Person person = f.wantedList.SelectedRows[0].DataBoundItem as Person;
                LoadPersonData(person);
                f.personsFound.Visible = false;
                f.total.Visible = false;
                f.Publication.Visible = false;
                MessageBox.Show("You can see the full information in the Search tab");
                    
            }

        }

        private  void PersonsFound_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (f.personsFound.SelectedItem as Person);
            LoadPersonData(selectedPerson);
           
            
        }

        private void SetWaiting(bool waiting)
        {
            if (waiting)
            {
                f.Cursor = Cursors.WaitCursor;
            }
            else
            {
                f.Cursor= Cursors.Default;
            }
        }

     
        private async void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


          
                switch (btn.Name)
                {
                    case "searchBtn":
                    SetWaiting(true);

                    if (!f.fullName.Text.Equals(" ") && !f.fullName.Equals(""))
                    {
                        List<Person> personsMatch = await Repository.GetPersonsWanted(f.fullName.Text);

                        f.searchBtn.Enabled = false;
                        f.personPic.Image = f.personPic.InitialImage;


                        if (personsMatch.Count > 0)
                        {
                            f.personsFound.DataSource = personsMatch;
                            f.personsFound.DisplayMember = "Title";
                            f.total.Text = "Total: " + personsMatch.Count;
                            

                            
                        
                          
                        }
                        else
                        {
                            MessageBox.Show("No data found for that name.");
                            f.personsFound.DataSource = null;
                            f.total.Text = "Total: ";


                        }
                       
                        f.total.Visible = true;
                        f.personsFound.Visible = true;
                        f.searchBtn.Enabled = true;
                        f.Publication.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a name to search.");
                        f.personsFound.DataSource = null;
                        f.total.Text = "Total: ";
                    }
                    SetWaiting(false);

                    break;
                    case "downloadPDF":

                            Person person = f.personsFound.SelectedItem as Person;
                            string pdfPath =  Repository.DownloadPDF(person.Files.First().Url, person.Title + person.Uid);
                 
                             Process.Start(pdfPath);
                           
                      
                        break;




                

            }



        }



        private async void LoadPersonData(Person person)
        {

            
            if ( person != null && person.Images.Count > 0)
            {
                SetWaiting(true);
                f.personPic.Image = f.personPic.InitialImage;
                await LoadPersonImage(person.Images.First().Large);
                SetWaiting(false);
            }
            if(person != null) { 
            f.height.Text = person.Height;
            f.weight.Text = person.Weight;
            f.eyes.Text = person.Eyes;
            f.race.Text = person.Race;
            f.hair.Text = person.Hair;
            f.sex.Text = person.Sex;
            f.Publication.Text = "Publication: " + person.Publication;
                

            string description = "";

            f.formatInfo.Navigate("about:blank");
             f.formatInfo.Document.Write("");


                if (person.Description != null)
                {
                    description += "<h1>Description </h1><br> " + person.Description;
                }
                if (person.Caution != null)
            {
                description += "<h1 style='color:red'> Caution </h1> <br>" + person.Caution;
            }
                if (person.Warning_message != null)
                {
                    description += "<h1 style='color:red'><strong> WARNING </strong></h1><br> " + person.Warning_message;
                }
                 if(person.Reward_text != null)
            {
                description += "<h1 style='color:orange'> Reward </h1> <br>" + person.Reward_text;
            }
            if (person.Details != null)
            {
                description += "<h1><strong> Details </strong></h1><br> " + person.Details;
            }

  

                f.formatInfo.DocumentText = description;
            

            f.infoContainer.Visible = true;
            f.downloadPDF.Enabled = true;
            }
        }



        // Using Selenium and Chrome Driver, opens a browsers, goes to the image, and takes an screenshot
        // Why the API would provide an image that is not in the same host and with cloudfare protection? No sense but this is the only way
        // to make it work
        // (Used ChatGPT to get help with this)
        public async Task LoadPersonImage(string imageUrl)
        {
            string screenshotDirectory = @"C:\Users\cv\Downloads";

            string hash = ComputeMD5Hash(imageUrl);


            string screenshotFilePath = Path.Combine(screenshotDirectory, hash + ".png");

            if (File.Exists(screenshotFilePath))
            {
                f.personPic.Image = System.Drawing.Image.FromFile(screenshotFilePath);
                return;
            }


           
            
            ChromeOptions options = new ChromeOptions();
            var chromeService = ChromeDriverService.CreateDefaultService();
            chromeService.HideCommandPromptWindow = true;
            options.AddUserProfilePreference("download.default_directory", screenshotDirectory);
            options.AddArgument("--headless");

            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--disable-gpu");
            options.AddArgument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/107.0.0.0 Safari/537.36");

            IWebDriver driver = new ChromeDriver(chromeService,options);
            try
            {



                driver.Navigate().GoToUrl(imageUrl);

                System.Threading.Thread.Sleep(3000);


                ITakesScreenshot screenshotDriver = (ITakesScreenshot)driver;
                Screenshot screenshot = screenshotDriver.GetScreenshot();


                screenshot.SaveAsFile(screenshotFilePath);

                Console.WriteLine("Screenshot saved to: " + screenshotFilePath);
                f.personPic.Image = System.Drawing.Image.FromFile(screenshotFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                driver.Quit();
            }
        }


        public string ComputeMD5Hash(string input)
        {
            // Create an MD5 hash object
            using (MD5 md5 = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a StringBuilder to convert the byte array to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in data)
                {
                    sb.Append(b.ToString("x2"));  // Convert byte to hex
                }

                // Return the resulting hash as a string
                return sb.ToString();
            }

        }

    }
}
