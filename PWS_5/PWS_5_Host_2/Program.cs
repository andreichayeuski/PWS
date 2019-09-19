using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace PWS_5_Host_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Simplex.Service1Client service1Client = new Simplex.Service1Client("NetTcpBinding_IService1");

            var sumResult = service1Client.Sum(new PWS_5_WCF.A { f = 1.3f, k = 2, s = "111" }, new PWS_5_WCF.A { f = 5.3f, k = 2, s = "333" });
            Console.WriteLine($"Sum\nf = {sumResult.f}\nk = {sumResult.k}\ns = {sumResult.s}");


            Console.WriteLine($"\n\nConcat\nresult = " + service1Client.Concat(sumResult.s, sumResult.f));


            Console.WriteLine($"\n\nAdd\nresult = " + service1Client.Add(sumResult.k, 8));

            service1Client.Close();
            
            Console.ReadKey();
        }
    }
}
