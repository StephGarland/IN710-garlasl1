using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_4._0_Encryption_Tool
{
    public partial class Form1 : Form
    {
        Encryptor encryptor;

        public Form1()
        {
            InitializeComponent();
            encryptor = new Encryptor();
            SetEncryptionAlgorithm();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            string input = tb_Input.Text;
            tb_Output.Text = encryptor.Encrypt(input);
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            string input = tb_Input.Text;
            tb_Output.Text = encryptor.Decrypt(input);
        }

        string GetCheckedRadioText(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio.Text;
                }
            }
            return null;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            SetEncryptionAlgorithm();
        }

        private void SetEncryptionAlgorithm()
        {
            string czeched = GetCheckedRadioText(gb_EncryptionAlg);
            switch (czeched)
            {
                case "String Reverse":
                    encryptor.SetAlgorithm(Algorithm.StringReverse);
                    break;
                case "ROT13":
                    encryptor.SetAlgorithm(Algorithm.ROT13);
                    break;
            }
        }
    }
}
