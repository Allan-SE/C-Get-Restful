using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace GetRestTest
{
    class Program
    {
        HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetTodoItems();
        }
        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync(
                "https://api.spacexdata.com/v3/launches");

            Console.Write(response);
        }
        
    }      
}