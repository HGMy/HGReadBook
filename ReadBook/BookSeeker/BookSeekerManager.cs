using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSeeker
{

    public sealed class BookSeekerManager
    {
        public BookSeeker[] Seekers { get; set; }

        public bool LoadSeeker(string seekerFileName)
        {
            return true;
        }

        public string[] GetSeekersInformation()
        {
            List<BookSeeker> list = new List<BookSeeker>(Seekers);
            List<string> ret = new List<string>();
            list.ForEach(a => { ret.Add(a.GetInfomation()); });
            return ret.ToArray();
        }
    }

    public abstract class BookSeeker
    {
        public abstract string GetInfomation();

        public abstract string GetSeekerUrl();
    }

    
}
