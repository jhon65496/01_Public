using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using WpfUserControlLibrary01;
 using WpfUserControlLibrary00;
// using WpfFrmApp1;

namespace StartAppWinFormFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            // WpfUserControlLibrary00
              AppManager appManager = new AppManager();

            // WpfUserControlLibrary01;
            // AppManager appManager = new AppManager();


            // WpfFrmApp1;
            // AppManager appManager = new AppManager();
        }
    }
}
