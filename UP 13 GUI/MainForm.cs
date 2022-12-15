using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_13_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BookGroupBox.Enabled = false;
            ArticleGroupBox.Enabled = false;
            EResourceGroupBox.Enabled = false;
        }
    }
}
