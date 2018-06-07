using RestSharp;
using Newtonsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU
{
    class Reqshowlist
    {

        // 물품 리스트 보기
        static void CallPuductList()
        {
            var client = new RestClient($"http://106.10.42.112:8000/product/list");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            var productList = Cson<Product>.ArrParse(response.Content);
        }

        class Product
        {
            public string name, category, sub_category;
            public int id, price;
        }
    }
}
