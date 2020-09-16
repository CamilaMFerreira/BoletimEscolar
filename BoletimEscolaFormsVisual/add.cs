using BoletimEscolar.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BoletimEscolaFormsVisual
{
    public  class add
    {
        public  string Add(object obj,string caminho )
        {
            
            var httpClient = new HttpClient();
            var serializedProduto = JsonConvert.SerializeObject(obj);
            var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(caminho,content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            return result.Result;
        }

    }

}
