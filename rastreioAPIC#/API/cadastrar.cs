using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static rastreioAPIC_.telaCadastro;
using DotNetEnv;
using System.Security.AccessControl;
using System.IO;
using System.Net.Http;
using static System.Windows.Forms.LinkLabel;
using Newtonsoft.Json.Serialization;

namespace rastreioAPIC_.API
{
    public class cadastrar
    {
        public async Task cadastrarProduto(Object produto){
            string dadosJson = JsonConvert.SerializeObject(produto);

            //acessa o arquivo config.env
            string envPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "config", "config.env");

            // Verifica se o arquivo .env existe
            if (File.Exists(envPath)) {
                try {
                    Env.Load(envPath);
                    string apiKey = Env.GetString("API_KEY");
                    string urlAPI = Env.GetString("URL_API");
                    string url = urlAPI + "/public/v1/trackers";

                    using (var client = new HttpClient()) {
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

                        // Cria o conteúdo da requisição com o JSON serializado
                        var content = new StringContent(dadosJson, Encoding.UTF8, "application/json");


                        // Faz a requisição POST para a API
                        var response = await client.PostAsync(url, content);
                        if (response.IsSuccessStatusCode) {
                            Console.WriteLine("Produto cadastrado com sucesso!");
                            string responseContent = await response.Content.ReadAsStringAsync();
                            Console.WriteLine("Resposta: " + responseContent);
                        } else {
                            // Captura o conteúdo da resposta em caso de erro
                            string errorContent = await response.Content.ReadAsStringAsync();

                            // Deserializa o conteúdo JSON para um objeto anônimo
                            dynamic errorResponse = JsonConvert.DeserializeObject(errorContent);

                            // Exibe a mensagem de erro
                            if (errorResponse.errors != null && errorResponse.errors.Count > 0) {
                                Console.WriteLine("Erro ao cadastrar: " + errorResponse.errors[0].message);

                            } else {
                                Console.WriteLine("Falha desconhecida na requisição.");
                            }


                        }
                    }

                } catch (Exception erro) {
                    Console.WriteLine(erro);
                }
            } else {
                Console.WriteLine("Arquivo .env não encontrado.");
            }



        }
    }
}
