using IPSCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrologueDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0 || args[0] == "help" || args[0] == "?")
            {
                help();
            }
            Console.WriteLine(((IEngine)new Engine()).decrypt("~{(#@&TORY<>?:[", args[0]));
        }

        private static void help()
        {
            Console.WriteLine();
            Console.WriteLine("How to use Prologue Decrypt");
            Console.WriteLine("======================");
            Console.WriteLine(@"c:\> PrologueDecrypt.exe <encrypted string excluding the @ symbol>");
            Console.WriteLine();

        }
    }
}
