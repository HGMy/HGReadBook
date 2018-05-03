using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSeeker
{
    public class Book
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string Group { get; set; }

        public string Author { get; set; }

        public BookSeeker Seeker { get; set; }

        private BookChapter[] Chapters { get; set; }

        private int currentChapterIndex = -1;

        public uint GetChaptersCount()
        {
            return 0;
        }

        public string[] GetChapterName()
        {
            return null;
        }

        public string GetChapterText(string chapterName)
        {
            return null;
        }

        public string GetChapterText(uint chapterIndex)
        {
            return null;
        }

        public string DownloadChapter(uint chapterIndex, BookSeeker seeker = null)
        {
            if (seeker == null)
            {
                seeker = this.Seeker;
            }


            return null;
        }

        public string DownloadChapter(string chapterName, BookSeeker seeker = null)
        {
            if (seeker == null)
            {
                seeker = this.Seeker;
            }

            return null;
        }

        public bool DownLoadBook(BookSeeker seeker = null)
        {
            if (seeker == null)
            {
                seeker = this.Seeker;
            }

            return true;
        }
    }

    public class BookChapter
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string Text { get; set; }
    }
}
