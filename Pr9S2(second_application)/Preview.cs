using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr9S2_second_application_
{
  public partial class Preview : Form
  {
    Image ToView;
    public Preview(Image View)
    {
      ToView = View;
      InitializeComponent();
    }

        private void Preview_Load(object sender, EventArgs e)
        {
           if (ToView != null)
            {
              pictureBox1.Size = new Size(ToView.Width, ToView.Height);
              pictureBox1.Image = ToView;
            }
        }
  }
}
