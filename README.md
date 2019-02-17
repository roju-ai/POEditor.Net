# POEditor.Net
This is for now a shared C# project containing models (in Body and Model folder) to use for POEditor API v2.  
Good thing is that you can use this in almost any type of C# projects :)

# Requirements
Your main project type can be of any type of .Net projects using C# supported by following nuget package(s)  
You will need to add these nuget packages:
+ [Refit](https://github.com/reactiveui/refit)

# How to use
1. Add the 'POEditor.Net.Shared' to your solution (project file inside POEditor.Net.Shared folder)
2. Add a reference to 'POEditor.Net.Shared' to your project
3. Install required nuget package(s) (Above section)
4. Create an instance of IPOEditorClientV2
5. Use the async methods of the instance to call and receive responses (you need to use you own API key from [POEditor profile page](https://poeditor.com/account/api))   

# Hello World Sample
Full solution file: 'POEditor.Net.Samples.sln' 
```C#
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
```

# Contribution and Future development
Contributions are welcome from everyone!
+ Cover all API v2 methods and features
+ Ready to use Nuget packages for .Net Core and .Net Framework

# About Us
Roju is the future of consumption.  
[more](https://roju.ai)