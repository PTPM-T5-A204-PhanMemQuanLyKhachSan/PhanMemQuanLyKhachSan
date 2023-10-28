using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace API.ClassAPI
{
    public class PhongAPI : XuLyAPI
    {
        public static readonly string linkClass = "Phong";
        public object getAllPhong()
        {
            return base.getAllProduct(linkClass);
        }
        public object getPhongById(int id)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(PhongModel));
            return base.getProductById(linkClass + "/" + id, js);
        }
        public bool addProduct(PhongModel phongModel)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(phongModel);
            return base.addProduct(linkClass , json);
            //+"/post"
        }
        public bool updateProduct(PhongModel phongModel)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(phongModel);
            return base.updateProduct(linkClass ,json);
            //+"/put"
        }
        public bool deleteProduct(int id)
        {
            return base.deleteProduct(linkClass,id);
            //"/delete"
        }
    }
}
