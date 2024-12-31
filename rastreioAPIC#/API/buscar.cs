using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;


namespace rastreioAPIC_.API {
    public class buscar {
        public async Task<dynamic> buscarProdutos() {
            //acessa o arquivo config.env
            string envPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "config", "config.env");

            if (File.Exists(envPath)) {
                try {
                    Env.Load(envPath);
                    string apiKey = Env.GetString("API_KEY");
                    string urlAPI = Env.GetString("URL_API");

                    string url = urlAPI + "/public/v1/trackers";

                    using (var client = new HttpClient()) {
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

                        var response = await client.GetAsync(url);
                        if (response.IsSuccessStatusCode) {
                            Console.WriteLine("buscou");
                            string responseContent = await response.Content.ReadAsStringAsync();
                            dynamic produtosArray = JsonConvert.DeserializeObject(responseContent);
                            int numProdutos = produtosArray.data.trackers.Count;

                            return produtosArray.data.trackers;
                        } else {
                            Console.WriteLine("Erro ao buscar");
                            return null;
                        }
                    }
                } catch (Exception erro) {
                    Console.WriteLine(erro);
                    return null;
                }
            } else {
                return null;
            }
        }
    }
}
