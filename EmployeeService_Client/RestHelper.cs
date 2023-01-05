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



    }
}
