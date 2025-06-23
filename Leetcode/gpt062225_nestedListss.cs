using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt062225_nestedListss
    {
        public static int MaximumWealth(List<List<int>> accounts)
        {
            int amountOfWealthiestPerson = 0;


            for (int i = 0; i < accounts.Count; i++)
            {
                int currentWealthiestAccount = 0;

                for (int j = 0; j < accounts[i].Count; j++) 
                {
                    currentWealthiestAccount += accounts[i][j];
                }

                if (currentWealthiestAccount > amountOfWealthiestPerson)
                {
                    amountOfWealthiestPerson = currentWealthiestAccount;
                }

            }

            return amountOfWealthiestPerson;
        }
    }
}
