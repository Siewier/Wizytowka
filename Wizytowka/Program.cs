using System;

namespace Wizytowka
{
    class Program
    {
        static void Main(string[] args)
        {
            PrzemekSiewierski ps 
                = new PrzemekSiewierski();
            Console.WriteLine(ps.ToString() 
                + "\n" + ps.telefon().ToString() 
                + "\n" + ps.eMail() 
                + "\n" + ps.webPage());
            Console.ReadLine();
        }
    }
    class PrzemekSiewierski
    {
        public int telefon()
        {
            return 510105908;
        }
        public string eMail()
        {
            return 
                "przemeksiewierski@gmail.com";
        }
        public string webPage()
        {
            return 
                "przemeksiewierski.eu";
        }
    }
}

