using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Invoice
    {


        public string Article { get; set; }
        public int Quantity { get; set; }

        int account;
        string customer;
        string provider;

        bool needEdv = false;



        public Invoice()
        {

        }

        public string CostColculation(bool needEdv)
        {
            //this.needEdv = needEdv;
            //decimal sum = 0;
            //decimal edv = account * 18 / 100;

            if (Article == "Laptop")
            {
               if(needEdv)
                {
                    double costOfProduct = (Quantity * 1400) + 1400 * 0.18;
                    return $"Article:{Article}, Quantity:{Quantity},Price:{1400}, Product Cost: {costOfProduct}";
                }
                else
                {
                    double costOfProduct = Quantity * 1400;
                    return $"Article:{Article}, Quantity:{Quantity},Price:{1400}";
                }

                    
             
            }return String .Empty;
           
        }

        public Invoice(int account, string customer, string provider) : this()
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;


        }




    }
}
