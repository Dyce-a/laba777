using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// класс Пара
    /// Круглов Александр
    /// 7 вариант
    /// </summary>
    internal class Pair
    {
        private DateTime startPair;
        private DateTime endPair;
        private DateTime startBreak;
        private DateTime endBreak;
        //private Smena smena;

        public Pair(DateTime startPair, DateTime endPair, DateTime startBreak, DateTime endBreak/*, Smena smena*/)
        {
            this.startPair = startPair;
            this.endPair = endPair;
            this.startBreak = startBreak;
            this.endBreak = endBreak;
            //this.smena = smena;
        }

        //public Pair(Smena smena) : this(DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, smena)
        //{

        //}
    }
}
