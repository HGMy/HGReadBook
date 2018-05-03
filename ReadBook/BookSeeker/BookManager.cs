using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSeeker
{
    public sealed class BookManager
    {
        private string initBookPath = "";

        public void Init()
        {
            ReadIni();

        }

        private void ReadIni()
        {
            
        }

        private List<Tuple<Book, string>> books = new List<Tuple<Book, string>>();


    }
}
