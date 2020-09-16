using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BoletimEscolaFormsVisual
{
    class listar
    {
        public string MeuGet(string Url)
        {
            var httpClient = new HttpClient();

            var resultRequest = httpClient.GetAsync(Url);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            return result.Result;

        }
    }
}
