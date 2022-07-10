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

        public void CostColculation(bool needEdv)
        {
            this.needEdv = needEdv;
            decimal sum = 0;
            decimal edv = account * 18 / 100;

            if (needEdv == true)
            {
                sum = account * Quantity + edv;
                Console.WriteLine(sum);
            }
            else
            {
                sum = account * Quantity;
                Console.WriteLine(sum);
            }
        }

        public Invoice(int account, string customer, string provider) : this()
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;


        }




    }
}
