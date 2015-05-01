using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace blue
{
    public partial class text2image : Form
    {
        public text2image()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                MessageBox.Show(path);
                Image img = Image.FromFile(path);
                PictureBox PictureBox1 = new PictureBox();

                PictureBox1.Image = img;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                MessageBox.Show(path);
                Image img = Image.FromFile(path);
                PictureBox PictureBox1 = new PictureBox();

                PictureBox1.Image = img;


            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview2 = new ListView();
            listview2.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                MessageBox.Show(path);
                Image img = Image.FromFile(path);


                PictureBox PictureBox = new PictureBox();


                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureBox.Size = new System.Drawing.Size(40, 40);
                pictureup.Image = img;
                pictureup.Height = img.Height;
                pictureup.Width = img.Width;


               

                pictureup.Size = new System.Drawing.Size(400, 400);
                Graphics G = Graphics.FromImage(img);
                G.DrawString(WRITE.Text, new Font("Tahoma", 40), Brushes.Black, new Point(20,20));




            }






        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


            pictureup.PerformLayout();
            WRITE.MaxLength = 500;



            WRITE.Text.Substring(0,0);  //="anything you wanna see" ;
            WRITE.GetLineFromCharIndex(0);
           int size = WRITE.TextLength;




            
        }







        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void text2image_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureup.PerformLayout();
            WRITE.PerformLayout();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Height1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fontsiz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       


    }
}



        

    
