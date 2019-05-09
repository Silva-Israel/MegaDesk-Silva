using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Silva
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.ShowDialog();
        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.ShowDialog();
        }

        private void Button3_MouseClick(object sender, MouseEventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.ShowDialog();
        }

        private void Button4_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
            // this.Close();
        }
    }
}
