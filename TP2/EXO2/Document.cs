using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO2
{
    internal abstract class Document
    {
        private static int count = 0;

        protected int numEnregistrement;
        protected string titre;

        public Document(string titre)
        {
            this.numEnregistrement = count++;
            this.titre = titre;
        }

        public abstract string Description();


    }
}
