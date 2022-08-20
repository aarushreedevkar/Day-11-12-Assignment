using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInventoryManagement1
{
    public class CompanyShares
    {
        public static void ListOfCompanyShares()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("ordinary shares");
            list.AddLast("Nonvoting shares");
            list.AddLast("Preferance shares");
            list.AddLast("Redeemable Shares");

            foreach (string shares in list)
            {
                Console.WriteLine(shares);
            }
        }
    }
}
