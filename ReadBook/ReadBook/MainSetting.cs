using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadBook
{
    internal static class MainSetting
    {
        private const string MainString = "Main";
        private const string MainFormWidthString = "MainFormWidth";
        private const string MainFormHeightString = "MainFormHeight";
        private const string MainFormStartTopString = "MainFormStartTop";
        private const string MainFormStartLeftString = "MainFormStartLeft";
        private const string MainFormStartStateString = "MainFormStartState";
        private const string BookWidthString = "BookWidth";
        private const string ChapterWidthString = "ChapterWidth";

        private static string iniFileName = "";

        public static uint MainFormWidth { get; set; }

        public static uint MainFormHeight { get; set; }


        public static int MainFormStartTop { get; set; }


        public static int MainFormStartLeft { get; set; }

        public static MainFormStartState MainFormStartState { get; set; }

        public static int BookWidth { get; set; }

        public static int ChapterWidth { get; set; }

        public static void Read()
        {
            if (iniFileName == "")
            {
                InitIniFile();
            }

            MainFormWidth = 1024;
            MainFormHeight = 768;
            MainFormStartState = MainFormStartState.Normal;
            MainFormStartLeft = 0;
            MainFormStartTop = 0;
            BookWidth = 200;
            ChapterWidth = 200;
        }

        private static void InitIniFile()
        {
            string fileName = System.Windows.Forms.Application.ExecutablePath;
            var fi = new FileInfo(fileName);
            var di = fi.Directory;
            iniFileName = di.FullName + "\\ini\\";

            if (!Directory.Exists(iniFileName))
            {
                Directory.CreateDirectory(iniFileName);
            }

            iniFileName += "main.ini";
            if (!File.Exists(iniFileName))
            {
                File.Create(iniFileName);
            }
        }

        public static void Write()
        {
            if (iniFileName == "")
            {
                InitIniFile();
            }
        }
    }

    internal enum MainFormStartState:byte 
    {
        Normal,
        Min,
        Max
    }
}
