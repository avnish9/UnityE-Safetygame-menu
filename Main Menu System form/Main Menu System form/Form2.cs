using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Main_Menu_System_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        int count { get; set; }
        String Player1 { get;set; }
        String Player2 { get; set; }
        String Player3 { get; set; }
        String Player4 { get; set; }
        String Player5 { get; set; }
        String Player6 { get; set; }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            if (count < 3)
            {
                textBox2.BackColor = Color.LightGray;
                textBox2.Enabled = false;
            }
            else if (count >= 3)
            {
                textBox2.BackColor = Color.White;
                textBox2.Enabled = true;
            }
            if (count < 4)
            {
                textBox5.BackColor = Color.LightGray;
                textBox5.Enabled = false;
            }
            else if (count >= 4)
            {
                textBox5.BackColor = Color.White;
                textBox5.Enabled = true;
            }
            if (count < 5)
            {
                textBox4.BackColor = Color.LightGray;
                textBox4.Enabled = false;
            }
            else if (count >= 5)
            {
                textBox4.BackColor = Color.White;
                textBox4.Enabled = true;
            }
            if (count < 6)
            {
                textBox6.BackColor = Color.LightGray;
                textBox6.Enabled = false;
            }
            else if (count >= 6)
            {
                textBox6.BackColor = Color.White;
                textBox6.Enabled = true;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String Player1 = textBox1.Text; String Player2 = textBox3.Text; String Player3 = textBox2.Text; String Player4 = textBox5.Text; String Player5 = textBox4.Text; String Player6 = textBox6.Text;
            int count = Convert.ToInt32(numericUpDown1.Value);
            File.WriteAllText(@"C:\temp\Players.txt", "");
            using (StreamWriter writer = new StreamWriter(@"C:\temp\Players.txt"))
            {
                writer.WriteLine(count);
                writer.WriteLine(Player1);
                writer.WriteLine(Player2);
                writer.WriteLine(Player3);
                writer.WriteLine(Player4);
                writer.WriteLine(Player5);
                writer.WriteLine(Player6);
            }

            /*Process.Start(@"C:\Users\avmis\Documents\unity e safety game\UnityE-safetyGame\BoardgamePrototype\BoardGame\test build\BoardGame.exe");   KEEP REMOVED*/
            Process.Start(@"C:\temp\Players.txt");
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
            
        }
    }
}
