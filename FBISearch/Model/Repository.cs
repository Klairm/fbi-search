using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBISearch.Model
{
    public static class Repository
    {
        static HttpClient httpClient;

        static readonly string ErrorMessage = "Error en l'API.";
        static readonly string contentType = "application/json";

        public static void CreateHttpClient()  // Cal executar aquest mètode en el constructor del Controller
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.fbi.gov/wanted/v1/list")
            };
            httpClient.DefaultRequestHeaders.Add("Accept", contentType);
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

        }



        public async static Task<List<Person>> GetTopWantedCriminals()
        {
             List<Person> criminals = new List<Person>();

            try
            {

                // Asynchronously call MakeRequest
                ResponseDTO body = await MakeRequest("?pageSize=10&sort_on=_score&poster_classification=default", typeof(ResponseDTO)) as ResponseDTO;

                if (body.Items.Count > 0)
                {

                    criminals = body.Items;

                }
                   
               

               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

         
            }

            return criminals;

        }



        public static async Task<List<Person>> GetPersonsWanted(string fullName)
        {
            ResponseDTO body = null;
            List<Person> persons = new List<Person>();

            try
            {
               
                body = await MakeRequest("?title="+fullName , typeof(ResponseDTO)) as ResponseDTO;

                if(body.Items.Count > 0)
                {
                    persons = body.Items;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

             
            }

            return persons;
        }



        // Old function to search on all pages, turns out the api has docs (not mentioned anywhere (found it by accidentaly going to the base url) ) and you can make searches with parameters
        /*   public static async Task<Person> GetPersonWanted(string fullName)
           {
               ResponseDTO body = null;
               Person person = null;

               try
               {
                   bool found = false;
                   int page = 1;

                   body = await MakeRequest("?page=" + page, typeof(ResponseDTO)) as ResponseDTO;

                   int totalPages = (int)Math.Ceiling((double)body.total / 20);
                   while (page <= totalPages && !found)
                   {
                       // Asynchronously call MakeRequest
                       body = await MakeRequest("?page=" + page, typeof(ResponseDTO)) as ResponseDTO;

                       if (body != null)
                       {
                           foreach (var i in body.Items)
                           {
                               if (i.Title != null)
                               {
                                   if (i.Title.Contains(fullName))
                                   {
                                       person = i;
                                       found = true;
                                       break;
                                   }
                               }
                           }

                           if (found)
                           {
                               Console.WriteLine(person);
                               break;
                           }
                       }
                       Console.WriteLine("Delay...");
                       await Task.Delay(5000);
                       page++;
                       Console.WriteLine("Page..");

                   }


               }
               catch (Exception e)
               {
                   Console.WriteLine(e.Message);

                   CreateHttpClient();
               }

               return person;
           }*/



        public static  string  DownloadPDF(string url,string fileName)
        {

            fileName += ".pdf";
            WebClient webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36";
            try
            {
                webClient.DownloadFile(url, fileName );
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(fileName);
            Console.WriteLine(Environment.CurrentDirectory);
            return Environment.CurrentDirectory + "\\" + fileName;

        }




        public static async Task<object> MakeRequest(string url, Type responseType)
        {
            try
            {
             
                HttpResponseMessage response = await httpClient.GetAsync(url);

              

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject(json, responseType);
                    return data;
                }
                else
                {
                    MessageBox
                    .Show("Error retrieving data: Error" +  response.StatusCode);
                    throw new Exception(ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error making request: {ex.Message}");
                throw;
            }
        }


    }
}
