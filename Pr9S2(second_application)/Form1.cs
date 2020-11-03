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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
         DialogResult rsl = MessageBox.Show("Уверены, что надо выходить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (rsl == DialogResult.Yes)
           {
             Application.Exit();
           }
        }
    Image Meme;
    private void LoadImage(bool jpg)
    {
      openFileDialog1.InitialDirectory = "c:";
      if (jpg)
      {
        openFileDialog1.Filter = "image (JPEG) files (*.jpg)|*.jpg| All files (*.*)|*.*";
      }
      else
      {
        openFileDialog1.Filter = "image (PNG) files (*.png)|*.png| All files (*.*)|*.*";
      }

      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        try
        {
          Meme = Image.FromFile(openFileDialog1.FileName);
          pictureBox1.Image = Meme;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Не вышло: " + ex.Message);
        }
      }
    }
    private void вФорматеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LoadImage(true);
    }

    private void вФорматеPNGToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LoadImage(false);
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {//загружаем жипег
      LoadImage(true);
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      LoadImage(false);
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      Form Preview = new Preview(Meme);
      Preview.ShowDialog();
      Close();
    }
  }
}
