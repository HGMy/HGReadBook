using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookSeeker;

namespace ReadBook
{
    public partial class MainForm : Form
    {

        private readonly BookManager bookMng = new BookManager();

        private readonly BookSeekerManager seekerManager = new BookSeekerManager();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bookMng.Init();
        }
    }
}
