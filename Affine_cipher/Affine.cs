using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affine_cipher
{
    public partial class Affine : Form
    {
        public Affine()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check whether the plain text input is empty or not
            if (ptext_1.Text == "")
            {
                msg_1.Text = "Please Insert the Plain Text";
            }
            else
            {
                string p_1 = ptext_1.Text;
                if (combo_k1.Text == "" || combo_k1.Text == "")
                {
                    msg_1.Text = "Please Select The Key Values";
                }
                else
                {
                    int k1 = Int32.Parse(combo_k1.Text);
                    int k2 = Int32.Parse(combo_k2.Text);
                    string cipherText = "";

                    // Put Plain Text (all capitals) into Character Array
                    char[] chars = p_1.ToUpper().ToCharArray();

                    // Compute e(x) = (ax + b)(mod m) for every character in the Plain Text
                    foreach (char c in chars)
                    {
                        int x = Convert.ToInt32(c - 65);
                        cipherText += Convert.ToChar(((k1 * x + k2) % 26) + 65);
                    }

                    ctext_1.Text = cipherText.ToString();
                }
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c_2 = ctext_2.Text;
            int k1_2 = Int32.Parse(combo_k1_2.Text);
            int k2_2 = Int32.Parse(combo_k2_2.Text);

            string plainText = "";

            // Get Multiplicative Inverse of a
            int k_1_2Inverse = MultiplicativeInverse(k1_2);

            // Put Cipher Text (all capitals) into Character Array
            char[] chars = c_2.ToUpper().ToCharArray();

            // Computer d(x) = aInverse * (e(x)  b)(mod m)
            foreach (char c in chars)
            {
                int x = Convert.ToInt32(c - 65);
                if (x - k2_2 < 0) x = Convert.ToInt32(x) + 26;
                plainText += Convert.ToChar(((k_1_2Inverse * (x - k2_2)) % 26) + 65);
            }
            ptext_2.Text = plainText.ToString();
        }
        public static int MultiplicativeInverse(int k_1_2)
        {
            for (int x = 1; x < 27; x++)
            {
                if ((k_1_2 * x) % 26 == 1)
                    return x;
            }

            throw new Exception("No multiplicative inverse found for key 1!");
        }
    }
}
