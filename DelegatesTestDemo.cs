using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing;

namespace TesterApp
{
    public delegate void Handler();
    class DelegatesTestDemo
    { 


        public static void PayIncomeTax()
        {
            Console.WriteLine(" 15%  income tax is deducted from your account");
        }
        public static void PayServiceTax()
        {
            Console.WriteLine(" 25%  service tax is deducted from your account");
        }
        public static void PayProfessionalTax()
        {
            Console.WriteLine(" 10%  Professional tax is deducted from your account");
        }


        static void Main(string[] arg)
              {
            Handler operation1 = new Handler(PayIncomeTax);
            operation1();
            Handler operation2 = new Handler(PayServiceTax);
            operation2(); 
            Handler operation3 = new Handler(PayProfessionalTax);
            operation3();


            Handler MultiOperation = null;
            MultiOperation += operation1;
            MultiOperation -= operation2;
            MultiOperation += operation3;
            MultiOperation();

        }
    }
}
