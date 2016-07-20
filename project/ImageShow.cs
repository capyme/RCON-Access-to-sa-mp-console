using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class ImageShow : Form
    {
        public ImageShow()
        {
            InitializeComponent();
        }

        private void FECHAR(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageShow_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
