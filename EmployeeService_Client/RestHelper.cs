using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService_Client
{
    public static class RestHelper
    {
        // Ulaşacağım API kaynağının adresi belirmem lazım.
        private static readonly string baseURL = "https://localhost:7275/api/";

        public static async Task<string> GetAll()
        {
            using(HttpClient client=new HttpClient())
            {
                string path = baseURL + "Employee"; // Emp tablosundan verileri getirecek olan pathi oluşturuyorum.

                using (HttpResponseMessage res = await client.GetAsync(path))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync(); // eğer API tarafından herhangi bir şekilde veri geldiyse bunu data değişgenine al

                        if (data != null) 
                        {
                            return data;
                        }
                    }
                }
            }

            return string.Empty;
        }

        public static string FormatterJson(string jsonStr)
        {
            // API tarafından gelen JSON formatındaki bilgileri düzenleyen bir metot
            try
            {
                JToken parseJson = JToken.Parse(jsonStr);
                return parseJson.ToString(Formatting.Indented);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public static async Task<string> GetOne(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string path = baseURL + "Employee/" + id ; // Emp tablosundan verileri getirecek olan pathi oluşturuyorum.

                using (HttpResponseMessage res = await client.GetAsync(path))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync(); // eğer API tarafından herhangi bir şekilde veri geldiyse bunu data değişgenine al

                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }

            return string.Empty;
        }

        public static async Task<string> Post(string name,string position,string age,string salary)
        {
            // Post işlemine girecek ekrandan alacağım verileri gönderilecek hale sokuyorum.

            var inputData = new Dictionary<string, string>()
            {
                {"name",name },
                {"position",position},
                {"age", age },
                {"salary",salary }
            };

            string v = JsonConvert.SerializeObject(inputData);
            inputData = v;

            var input= new FormUrlEncodedContent(inputData);

            using (HttpClient client = new HttpClient())
            {
                string path = baseURL + "Employee"; // Emp tablosundan verileri getirecek olan pathi oluşturuyorum.

                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                using (HttpResponseMessage res = await client.PostAsync(path,input)) // gönderilecek veri bloğunu ayarlamışım ve gönderiyorum.
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync(); // eğer API tarafından herhangi bir şekilde veri geldiyse bunu data değişgenine al

                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }

            return string.Empty;
        }
    }

}
