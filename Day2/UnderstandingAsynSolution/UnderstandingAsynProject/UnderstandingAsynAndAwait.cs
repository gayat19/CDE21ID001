using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAsynProject
{
    class DevOpsEngg
    {
        public string Tool { get; set; }
    }
    class WebDeveloper
    {
        public int LanguageCount { get; set; }
    }
    class Progammer
    {
        public string Language { get; set; }
    }
    class SoftwareEngg
    {
        public int Level { get; set; }
    }
    class UnderstandingAsynAndAwait
    {
        static async Task<Progammer> CompleteStage1()
        {
            Console.WriteLine("Go to Udemy and learn C#");
            await Task.Delay(2000);
            Console.WriteLine("C# ok now");
            return new Progammer() { Language = "C#" };
        }
        static async Task<WebDeveloper> CompleteStage2()
        {
            Console.WriteLine("HTML CSS");
            await Task.Delay(500);
            Console.WriteLine("JavaScript"); 
            return new WebDeveloper() { LanguageCount=3 };
        }
        static async Task<DevOpsEngg> CompleteStage3()
        {
            SoftwareEngg engg = await Behav();
            Console.WriteLine("Behavioral session complete------------");
            Console.WriteLine("Azure is the god now");
            await Task.Delay(1000);
            Console.WriteLine("Docker done right");
            Task.Delay(1000).Wait();
            Console.WriteLine("Kubernetes for orch");
            return new DevOpsEngg() { Tool = "Azure" };
        }
        static async  Task<SoftwareEngg> Behav()
        {
            Console.WriteLine("Email etq..");
            await Task.Delay(1000);
            //Task.Delay(1000).Wait();
            Console.WriteLine("English grammer");
            await Task.Delay(1000);
            Task.Delay(1000).Wait();
            for (int i = 0; i < 3; i++)
            {
                await Task.Delay(500);
                //Task.Delay(1000).Wait();
                Console.WriteLine("Public Speaking");
            }
            return new SoftwareEngg() { Level=2 };
        }
       static async void CompleteTraining()
        {
           
            Progammer progammer = await CompleteStage1();
            Console.WriteLine("Stage1 Done---------------");
            WebDeveloper webDeveloper = await CompleteStage2();
            Console.WriteLine("Stage2 Done----------------");
            DevOpsEngg devOpsEngg = await CompleteStage3();
            Console.WriteLine("Stage3 Done-----------------");
           
        }
        static void Main(string[] args)
        {
            CompleteTraining();
            Console.ReadKey();
        }
     }
}
