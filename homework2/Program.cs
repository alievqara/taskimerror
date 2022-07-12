using System;


namespace homework2
{
    public class Program
    {


        public static void Main()
        {

            //Invoice mehsul1 = new Invoice(13, "Faig", "Aliyev")
            //{
            //    Article = "USB Hub",
            //    Quantity = 6

            //}; mehsul1.CostColculation(false);


            //Invoice mehsul2 = new Invoice(13, "Faig", "Aliyev")
            //{
            //    Article = "Laptop",
            //    Quantity = 1400

            //}; mehsul2.CostColculation(false);


            //Invoice mehsul3 = new Invoice(13, "Faig", "Aliyev")
            //{
            //    Article = "SD-Card",
            //    Quantity = 30

            //}; mehsul3.CostColculation(true);

            Invoice invoice = new Invoice(13, "Faig", "Aliyev");


               invoice.Article = "Laptop";
               invoice.Quantity = 12;

            Console.WriteLine(invoice.CostColculation(true));











        }

    }

}
