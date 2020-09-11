using Newtonsoft.Json;

using NT.Entities.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace NT.Services
{
    // Class for product services
    public class ProductService
    {
        /// <summary>
        /// Calls a given endpoint and returns a string with the retrieved json data
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        protected virtual async Task<string> CallWebApi(string url)
        {
            try
            {
                // Create a HttpWebRequest
                HttpWebRequest httpWebRequest = WebRequest.CreateHttp(url);
                // Set method to get
                httpWebRequest.Method = WebRequestMethods.Http.Get;
                // Set accept headers
                httpWebRequest.Accept = "application/json";

                // String for storing the json data retrieved from the endpoint
                string result;

                // Get response from the website
                using(HttpWebResponse response = (HttpWebResponse)await httpWebRequest.GetResponseAsync())
                {
                    // Read the response
                    using StreamReader sr = new StreamReader(response.GetResponseStream());
                    // Assign the response data to the result variable
                    result = await sr.ReadToEndAsync();
                };

                // Return the retrieved JSON data.
                return result;
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns a list of all product objects.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<List<Products>> GetAllProductsAsync()
        {
            try
            {
                // Call the web API
                string json = await CallWebApi("http://10.143.74.234:5000/product/all");

                // Deserialize the JSON data into an object list
                List<Products> orderData = JsonConvert.DeserializeObject<List<Products>>(json);

                // Return the object list
                return orderData;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}