using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Голубов Фёдор Олегович
    /// </summary>
    public class Group
    {
        private string name;
        private string sokrasch;
        private int amount;
        private int year;
        private string link;
        private string boss;

        public Group(string name, string sokrasch, int amount, int year, string link, string boss)
        {
            this.name = name;
            this.sokrasch = sokrasch;
            this.amount = amount;
            if (year == null)
            {
                this.year = year;
            }
            else
            {
                this.year = DateTime.Now.Year;
            }
            this.link = link;
            this.boss = boss;
        }
    }
}
