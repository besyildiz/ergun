using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mermer_mezar_stok_takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        string kullanicadi, sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kullanicadi && textBox2.Text == sifre)
            {
                Ateşoğlu_Mermer_Ana f = new Ateşoğlu_Mermer_Ana();
                f.Show();
                this.Visible = false;
            }
            else
            {
                if (textBox1.Text != kullanicadi && textBox2.Text != sifre)
                    MessageBox.Show("kullanıcı adı ve şifreniz yalış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (textBox1.Text != kullanicadi)
                        MessageBox.Show("kullanıcı adı yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                    else
                    {
                        if (textBox2.Text != sifre)
                            MessageBox.Show("şifreniz yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            {
                try
                {
                    
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }

        }
        private void EnableYap()
        {
            if (textBox1.Text != null && textBox1.Text != "" && textBox2.Text != null && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }



        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }  
}
