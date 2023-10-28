using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using System.Text.Json;
using API.Model;

namespace API
{
    public class XuLyAPI
    {
        public virtual Object getAllProduct(string link)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(LinkAPI.localHost + link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(PhongModel[]));
            object data = js.ReadObject(response.GetResponseStream());
            return data;
        }
        public virtual Object getProductById(string link,DataContractJsonSerializer js)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(LinkAPI.localHost + link);
            WebResponse response = request.GetResponse();
            //DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc));
            object data = js.ReadObject(response.GetResponseStream());
            return data;
        }
        public virtual bool addProduct(string link, string json)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(LinkAPI.localHost);

                //var json = System.Text.Json.JsonSerializer.Serialize(p);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync(link, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    //var responseContent = response.Content.ReadAsStringAsync().Result;

                    //var options = new JsonSerializerOptions
                    //{
                    //    PropertyNameCaseInsensitive = true
                    //};

                    //var postResponse = System.Text.Json.JsonSerializer.Deserialize<PhongModel>(responseContent, options);
                    //return postResponse.maPhong;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public virtual bool updateProduct(string link, string json)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(LinkAPI.localHost);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = client.PutAsync(link, content).Result;
                    if (response.IsSuccessStatusCode)
                        return true;
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public virtual bool deleteProduct(string link, int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(LinkAPI.localHost);
                    var response = client.DeleteAsync(link + "/" + id).Result;
                    if (response.IsSuccessStatusCode)
                        return true;
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
