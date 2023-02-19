using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.Amaretto;



            }
            else
            {
                pictureBox1.Visible = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.LatteMachiato;


            }
            else
            {
                pictureBox1.Visible = false;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int input1;
            string coffeename;

          input1 = Convert.ToInt32(textBox1.Text);
            coffeename = Convert.ToString(textBox2.Text);



            if (button1.Enabled)
            {


                OrderLAbel.Text = Convert.ToString("The amount to be paid is PHP " + input1.ToString());
                label10.Text = Convert.ToString("You ordered " + coffeename.ToString());
            }

















        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.CoffeeCockTail;


            }
            else
            {
                pictureBox1.Visible = false;

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.Iced_Coffee;


            }
            else
            {
                pictureBox1.Visible = false;

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton5.Checked)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.Mocha;


            }
            else
            {
                pictureBox1.Visible = false;

            }
        }
    }

}
    
