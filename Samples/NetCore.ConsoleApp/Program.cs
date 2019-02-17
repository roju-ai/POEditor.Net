using Newtonsoft.Json;
using POEditor;
using POEditor.Body;
using Refit;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace POEditor.Net.Samples.NetCore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello POEditor!");
            ShowAllProjects().Wait();
            Console.WriteLine("Press enter to end ...");
            Console.ReadLine();
        }

        public static async Task ShowAllProjects()
        {
            var client = RestService.For<IPOEditorClientV2>("https://api.poeditor.com");
            var resp = await client.ProjectsList(new ProjectsListRequest
            {
                ApiToken = "YOUR API KEY HERE",
            }, CancellationToken.None);
            if (resp?.Response?.Code == 200) //OK
            {
                Console.WriteLine($"All your projects:\n{JsonConvert.SerializeObject(resp.Result?.Projects, Formatting.Indented)}");
            }
            else
            {
                Console.WriteLine($"Request failed:\n{resp?.Response?.Message}");
            }
        }
    }
}
