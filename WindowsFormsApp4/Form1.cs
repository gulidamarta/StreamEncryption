using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Windows;


namespace WindowsFormsApp4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxInitialKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInitialKey_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D1 || e.Shift || e.Alt || 
                 e.KeyCode == Keys.Home || e.KeyCode == Keys.End)
             {
                 e.SuppressKeyPress = true;
             }

             if (e.KeyCode == Keys.Back)
             {
                 e.SuppressKeyPress = false;
             } 
        }

        private void textBoxInitialKey_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private string Binary(byte[] data, ref int count)
        {
            string res = "";
            const int COUNT = 2048;
            int temp;
            for (int i = 0; i < data.Length; i++)
                for (int j = 7; j >= 0; j--)
                    count++;
            temp = data.Length > COUNT ? COUNT: data.Length;

            for (int i = 0; i < temp; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    if ((data[i] & (1 << j)) > 0)
                    {
                        res += '1';
                    }
                    else
                        res += '0';
                }
            }
            return res;
        }

        private byte[] ConvertBitsToByte(byte[] BitsKey)
        {
            byte[] temp = new byte[BitsKey.Length / 8];

            int point = 0;
            int i = 0;
            for(i = 0; i < BitsKey.Length; i++)
            {
                if(BitsKey[i] == 1)
                {
                    temp[point] += (byte)(1 << (7 - (i % 8))); 
                }
                if (((i + 1) % 8) == 0)
                   point++;
            }

            
            return temp;
        }

        private void swap(ref byte param1, ref byte param2)
        {
            byte temp = param1;
            param1 = param2;
            param2 = temp;
        }

        const byte MAX_BYTE = 255;

        private byte[] SetValueOf_S(byte[] RC4Key)
        {
            byte[] S = new byte[MAX_BYTE + 1];
            for (int i = 0; i <= MAX_BYTE; i++)
            {
                S[i] = (byte)i;
            }

            int j = 0;
            for (int i = 0; i <= MAX_BYTE; i++)
            {
                j = (j + S[i] + RC4Key[i % RC4Key.Length]) % (MAX_BYTE + 1);
                swap(ref S[i], ref S[j]);
            }
            return S;
        }

        private void RPGA(ref byte[] S, ref byte[] NewRC4Key, int count)
        {
            const int MAX_BYTE = 255;
            int i = 0, j = 0, t = 0, m = 0;
            while (count > 0)
            {
                i = (i + 1) % (MAX_BYTE + 1);
                j = (j + (int)S[i]) % (MAX_BYTE + 1);
                swap(ref S[i], ref S[j]);
                t = (S[i] + S[j]) % (MAX_BYTE + 1);
                NewRC4Key[m] = S[t];
                m++;
                count--;
            }
        }

        private void ShowRC4REsult(ref byte[] data, byte[] MyEdtKey, int count)
        {
            for (int i = 0; i < count; i++)
            {
                data[i] = (byte)(MyEdtKey[i] ^ data[i]);
            }

        }

        byte[] RC4Bytes;

        private string displayBinary(byte[] data)
        {
            const int DISP_AMT = 2048;
            if (data.Length > DISP_AMT)
            {
                char[] ret = new char[DISP_AMT * 16];
                // display only 2048 * 16 symbols in rich boxes
                int pos = 0;
                for (int i = 0; i < DISP_AMT; i++)
                {
                    for (int j = 7; j >= 0; j--)
                    {
                        if ((data[i] & (1 << j)) > 0)
                            ret[pos++] = '1';
                        else
                            ret[pos++] = '0';
                    }
                    ret[pos++] = ' ';
                }
                return new string(ret, 0, pos);
            }
            else
            {
                char[] ret = new char[DISP_AMT * 16];
                int pos = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = 7; j >= 0; j--)
                    {
                        if ((data[i] & (1 << j)) > 0)
                            ret[pos++] = '1';
                        else
                            ret[pos++] = '0';
                    }
                    ret[pos++] = ' ';
                }
                return new string(ret, 0, pos);
            } 
        }

        private void displayKey(byte[] key, int DataLength)
        {
            //display key
            int i;
            textBoxGeneratedKey.Clear();
            const int KEY_DISPLAY_AMT = 128;
            if ((DataLength * 8 - 1) > KEY_DISPLAY_AMT)
            {
                // display only 128 symbols of the key
                char[] buf = new char[KEY_DISPLAY_AMT];
                for (i = 0; i < KEY_DISPLAY_AMT; i++)
                {
                    buf[i] = (char)(key[KEY_DISPLAY_AMT - i - 1] + '0');
                }
                char[] temparr = new char[KEY_DISPLAY_AMT];
                for (i = 0; i < KEY_DISPLAY_AMT; i++)
                    temparr[i] = buf[KEY_DISPLAY_AMT - i - 1];
                textBoxGeneratedKey.Text = new string(temparr);
            }
            else
            {
                char[] buf = new char[DataLength * 8];
                for (i = DataLength * 8 - 1; i >= 0; i--)
                {
                    buf[i] = (char)(key[i] + '0');
                }
                textBoxGeneratedKey.MaxLength = DataLength * 8;
                textBoxGeneratedKey.Text = new string(buf);
            }
        }

        private void displayResultKey(byte[] key, int DataLength)
        {
            //display key
            int i;
            textBoxResultKey.Clear();
            const int KEY_DISPLAY_AMT = 128;
            if ((DataLength * 8 - 1) > KEY_DISPLAY_AMT)
            {
                // display only 128 symbols of the key
                char[] buf = new char[KEY_DISPLAY_AMT];
                for (i = 0; i < KEY_DISPLAY_AMT; i++)
                {
                    buf[i] = (char)(key[KEY_DISPLAY_AMT - i - 1] + '0');
                }
                char[] temparr = new char[KEY_DISPLAY_AMT];
                for (i = 0; i < KEY_DISPLAY_AMT; i++)
                    temparr[i] = buf[KEY_DISPLAY_AMT - i - 1];
                textBoxResultKey.Text = new string(temparr);
            }
            else
            {
                char[] buf = new char[DataLength * 8];
                for (i = DataLength * 8 - 1; i >= 0; i--)
                {
                    buf[i] = (char)(key[i] + '0');
                }
                textBoxResultKey.MaxLength = DataLength * 8;
                textBoxResultKey.Text = new string(buf);
            }
        }

        private void displayKeyLFSR2(byte[] key, int DataLength)
        {
            //display key
            int i;
            textBoxLFSR2.Clear();
            const int KEY_DISPLAY_AMT = 128;
            if ((DataLength * 8 - 1) > KEY_DISPLAY_AMT)
            {
                // display only 128 symbols of the key
                char[] buf = new char[KEY_DISPLAY_AMT];
                for (i = 0; i < KEY_DISPLAY_AMT; i++)
                {
                    buf[i] = (char)(key[KEY_DISPLAY_AMT - i - 1] + '0');
                }
                char[] temparr = new char[KEY_DISPLAY_AMT];
                for (i = 0; i < KEY_DISPLAY_AMT; i++)
                    temparr[i] = buf[KEY_DISPLAY_AMT - i - 1];
                textBoxLFSR2.Text = new string(temparr);
            }
            else
            {
                char[] buf = new char[DataLength * 8];
                for (i = DataLength * 8 - 1; i >= 0; i--)
                {
                    buf[i] = (char)(key[i] + '0');
                }
                textBoxLFSR2.MaxLength = DataLength * 8;
                textBoxLFSR2.Text = new string(buf);
            }
        }

        private void displayKeyLFSR3(byte[] key, int DataLength)
        {
            //display key
            int i;
            textBoxLFSR3.Clear();
            const int KEY_DISPLAY_AMT = 128;
            if ((DataLength * 8 - 1) > KEY_DISPLAY_AMT)
            {
                // display only 128 symbols of the key
                char[] buf = new char[KEY_DISPLAY_AMT];
                for (i = 0; i < KEY_DISPLAY_AMT; i++)
                {
                    buf[i] = (char)(key[KEY_DISPLAY_AMT - i - 1] + '0');
                }
                char[] temparr = new char[KEY_DISPLAY_AMT];
                for (i = 0; i < KEY_DISPLAY_AMT; i++)
                    temparr[i] = buf[KEY_DISPLAY_AMT - i - 1];
                textBoxLFSR3.Text = new string(temparr);
            }
            else
            {
                char[] buf = new char[DataLength * 8];
                for (i = DataLength * 8 - 1; i >= 0; i--)
                {
                    buf[i] = (char)(key[i] + '0');
                }
                textBoxLFSR3.MaxLength = DataLength * 8;
                textBoxLFSR3.Text = new string(buf);
            }
        }

        const int BIT_CAPACITY = 25;

        // LFSR1
        // x25 + x3 + 1 - BIT_CAPACITY = 25
        private void SHFL(ref byte[] register, byte POS_FIRST, byte POS_SECOND, byte MAX_LENGTH)
        {
            // calculate xor for bits 24 and 2
            byte calc = (byte)(register[POS_FIRST] ^ register[POS_SECOND]);
            for (int i = MAX_LENGTH - 2; i >= 0; i--)
            {
                // shift all meanings left from 24 to 1
                register[i + 1] = register[i];
            }
            // at zero position write our xor element
            register[0] = calc;
        }

        //LFSR3 polynom P(x) = x^23 + x^5 + 1
        const byte POS_FIRST_LFSR3 = 22;
        const byte POS_SECOND_LFSR3 = 4;
        const byte MAX_LENGTH = 23;

        private byte[] GenerateKey_LFSR3(byte[] data, string initReg)
        {
            string reverseStr = "";
            for (int j = 0; j < initReg.Length; j++)
            {
                reverseStr += initReg[initReg.Length - j - 1];
            }
            initReg = reverseStr;

            byte[] register = new byte[MAX_LENGTH];
            byte[] key = new byte[data.Length * 8];
            int i;
            if (data.Length * 8 > MAX_LENGTH)
            {
                for (i = 0; i < MAX_LENGTH; i++)
                {
                    register[i] = (byte)(initReg[MAX_LENGTH - i - 1] - '0');
                    // записываем в ключ значения регистра по его длину (т.е. key[0] = register[0])
                    // так как мы все равно их сдвинем 
                    key[i] = register[i];
                }
            }
            else
            {
                for (i = 0; i < data.Length * 8; i++)
                {
                    register[i] = (byte)(initReg[MAX_LENGTH - i - 1] - '0');
                    // записываем в ключ значения регистра по его длину (т.е. key[0] = register[0])
                    // так как мы все равно их сдвинем 
                    key[i] = register[i];
                }
            }
            byte[] temp = new byte[MAX_LENGTH];
            for (int q = 0; q < MAX_LENGTH; q++)
            {
                temp[q] = register[MAX_LENGTH - q - 1];
            }
            for (int q = 0; q < MAX_LENGTH; q++)
            {
                register[q] = temp[q];
            }
            for (; i < data.Length * 8; i++)
            {
                SHFL(ref register, POS_FIRST_LFSR3, POS_SECOND_LFSR3, MAX_LENGTH);
                key[i] = register[0];
            }

            return key;
        }
    
        //LFSR2 polynom P(x) = x^33 + x^13 + 1
        const byte POS_FIRST_LFSR2 = 32;
        const byte POS_SECOND_LFSR2 = 12;
        const byte MAX_LENGTH_LFSR2 = 33;

        private byte[] GenerateKey_LFSR2(byte[] data, string initReg)
        {
            string reverseStr = "";
            for (int j = 0; j < initReg.Length; j++)
            {
                reverseStr += initReg[initReg.Length - j - 1];
            }
            initReg = reverseStr;

            byte[] register = new byte[MAX_LENGTH_LFSR2];
            byte[] key = new byte[data.Length * 8];
            int i;
            if (data.Length * 8 > MAX_LENGTH_LFSR2)
            {
                for (i = 0; i < MAX_LENGTH_LFSR2; i++)
                {
                    register[i] = (byte)(initReg[MAX_LENGTH_LFSR2 - i - 1] - '0');
                    // записываем в ключ значения регистра по его длину (т.е. key[0] = register[0])
                    // так как мы все равно их сдвинем 
                    key[i] = register[i];
                }
            }
            else
            {
                for (i = 0; i < data.Length * 8; i++)
                {
                    register[i] = (byte)(initReg[MAX_LENGTH_LFSR2 - i - 1] - '0');
                    // записываем в ключ значения регистра по его длину (т.е. key[0] = register[0])
                    // так как мы все равно их сдвинем 
                    key[i] = register[i];
                }
            }

            byte[] temp = new byte[MAX_LENGTH_LFSR2];
            for (int q = 0; q < MAX_LENGTH_LFSR2; q++)
            {
                temp[q] = register[MAX_LENGTH_LFSR2 - q - 1];
            }
            for (int q = 0; q < MAX_LENGTH_LFSR2; q++)
            {
                register[q] = temp[q];
            }

            // was: for(; i < data.Length * 8 - BIT_CAPACITY; i++)
            for (; i < data.Length * 8; i++)
            {
                SHFL(ref register, POS_FIRST_LFSR2, POS_SECOND_LFSR2, MAX_LENGTH_LFSR2);
                key[i] = register[0];
            }

            return key;
        }

        //LFSR1 polynom: x^25 + x^3 + 1 
        const byte POS_FIRST_LFSR1 = 2;
        const byte POS_SECOND_LFSR1 = 24;

        private byte[] GenerateKey_LFSR1(byte[] data, string initReg)
        {
            string reverseStr = "";
            for(int j = 0; j < initReg.Length; j++)
            {
                reverseStr += initReg[initReg.Length - j - 1];
            }
            initReg = reverseStr;

            byte[] register = new byte[BIT_CAPACITY];
            byte[] key = new byte[data.Length * 8];
            int i;
            if (data.Length * 8 > BIT_CAPACITY)
            {
                for (i = 0; i < BIT_CAPACITY; i++)
                {
                    register[i] = (byte)(initReg[BIT_CAPACITY - i - 1] - '0');
                    // записываем в ключ значения регистра по его длину (т.е. key[0] = register[0])
                    // так как мы все равно их сдвинем 
                    key[i] = register[i];
                }
            }
            else
            {
                for (i = 0; i < data.Length * 8; i++)
                {
                    register[i] = (byte)(initReg[BIT_CAPACITY - i - 1] - '0');
                    // записываем в ключ значения регистра по его длину (т.е. key[0] = register[0])
                    // так как мы все равно их сдвинем 
                    key[i] = register[i];
                }
            }

            byte[] temp = new byte[BIT_CAPACITY];
            for (int q = 0; q < BIT_CAPACITY; q++)
            {
                temp[q] = register[BIT_CAPACITY - q - 1];
            }
            for (int q = 0; q < BIT_CAPACITY; q++)
            {
                register[q] = temp[q];
            }

            // was: for(; i < data.Length * 8 - BIT_CAPACITY; i++)
            for (; i < data.Length * 8; i++)
            {
                SHFL(ref register, POS_FIRST_LFSR1, POS_SECOND_LFSR1, BIT_CAPACITY);
                key[i] = register[0];
            }

            return key;
        }

        private byte[] GeffeGenerator(ref byte[] data, string initRegLFSR1, 
            string initRegLFSR2, string initRegLFSR3)
        {
            byte[] Key_LFSR1 = new byte[data.Length * 8];
            byte[] Key_LFSR2 = new byte[data.Length * 8];
            byte[] Key_LFSR3 = new byte[data.Length * 8];

            Key_LFSR1 = GenerateKey_LFSR1(data, initRegLFSR1);
            Key_LFSR2 = GenerateKey_LFSR2(data, initRegLFSR2);
            Key_LFSR3 = GenerateKey_LFSR3(data, initRegLFSR3);

            displayKey(Key_LFSR1, data.Length);
            displayKeyLFSR2(Key_LFSR2, data.Length);
            displayKeyLFSR3(Key_LFSR3, data.Length);

            byte[] Res_Key = new byte[data.Length * 8];
            for(int i = 0; i < data.Length * 8; i++)
            {
                Res_Key[i] = (byte)((Key_LFSR1[i] & Key_LFSR2[i]) |
                    ((~Key_LFSR1[i]) & Key_LFSR3[i])); 
            }

            displayResultKey(Res_Key, data.Length);
            /*for(int i = 0; i < Res_Key.Length; i++)
            {
                string str = "";
                str += "res[ " + Convert.ToString(i) +
                    "] = " + Convert.ToString(Res_Key[i]);
                MessageBox.Show(str);
            } */

            int p = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    data[i] = (byte)(data[i] ^ (Res_Key[p] << j));
                    p++;
                }
            }
            return data;
        }

        private byte[] LFSR1Encode(ref byte[] data, string initReg)
        {
            byte[] key = new byte[data.Length * 8];
            key = GenerateKey_LFSR1(data, initReg);
            /*for(int j = 0; j < key.Length; j++)
            {
                string str = "key[" + Convert.ToString(j) +
                    "] = " + Convert.ToString(key[j]);
                MessageBox.Show(str);
            } */
            displayKey(key, data.Length);

            //key index
            int p = 0;
            int i;
            for (i = 0; i < data.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    data[i] = (byte)(data[i] ^ (key[p] << j));
                    p++;
                }
            }
            return data;
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        const string EMPTY_KEY_MSG = "Key field must be filled!";
        const string EMPTY_FILE_MSG = "File is empty.Try another one.";
        const string FILE_NOT_CHOOSED = "You don't choose any file. Try again.";
        // we encrypt our message in encrypt.txt
        const byte BYTE_LENCTH = 8;
        private void btnEncrDecr_Click(object sender, EventArgs e)
        {
            const int KEY_LENGTH_BITS_RC4 = 16;
            if(richTextBoxInitialKey.Text.Length == 0)
                MessageBox.Show(EMPTY_KEY_MSG);
            else
            {
                if (openFileDialogFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var fi = new FileInfo(openFileDialogFile.FileName);
                    if (fi.Length != 0)
                    {
                        byte[] data = File.ReadAllBytes(openFileDialogFile.FileName);
                        if (radioButtonLFSR1.Checked)
                        {
                            richTextBoxInitialKey.MaxLength = BIT_CAPACITY;
                            richTextBoxInitialKey.Text = richTextBoxInitialKey.Text.PadLeft(BIT_CAPACITY, '0');
                            rbPlainText.Text = displayBinary(data);
                            data = LFSR1Encode(ref data, richTextBoxInitialKey.Text);
                            rbCypherText.Text = displayBinary(data);
                            File.WriteAllBytes("Encrypted.txt", data);
                        }
                        if (radioButtonGeffeGenerator.Checked)
                        {
                            richTextBoxLFSR2.Text = richTextBoxLFSR2.Text.PadLeft(33, '0');
                            richTextBoxLFSR3.Text = richTextBoxLFSR3.Text.PadLeft(23, '0');
                            richTextBoxInitialKey.Text = richTextBoxInitialKey.Text.PadLeft(BIT_CAPACITY, '0');
                            rbPlainText.Text = displayBinary(data);
                            data = GeffeGenerator(ref data, richTextBoxInitialKey.Text,
                                richTextBoxLFSR2.Text, richTextBoxLFSR3.Text);
                            rbCypherText.Text = displayBinary(data);
                            File.WriteAllBytes("Encrypted.txt", data);
                        }
                        if (radioButtonRC4.Checked)
                        {
                            if ((richTextBoxInitialKey.Text.Length % 8) == 0)
                            {
                                //richTextBoxInitialKey.Text =
                                  //  richTextBoxInitialKey.Text.PadLeft(KEY_LENGTH_BITS_RC4, '0');
                                int countMMO = 0;
                                string resMMO = Binary(data, ref countMMO);
                                byte[] RC4Key = new byte[richTextBoxInitialKey.Text.Length];

                                for (int i = 0; i < richTextBoxInitialKey.Text.Length; i++)
                                {
                                    RC4Key[i] =
                                        Convert.ToByte(richTextBoxInitialKey.Text[i] - '0');
                                }

                                RC4Key = ConvertBitsToByte(RC4Key);

                                byte[] S = SetValueOf_S(RC4Key);
                                byte[] NewRC4Key = new byte[data.Length];
                                RPGA(ref S, ref NewRC4Key, data.Length);
                                string RC4 = "";

                                const int MAX_LENGTH_GENERATED_KEY = 128;

                                //form key for representation in text box
                                if (resMMO.Length > MAX_LENGTH_GENERATED_KEY)
                                {
                                    for (int i = 0; i < MAX_LENGTH_GENERATED_KEY; i++)
                                        RC4 += " " + NewRC4Key[i];
                                }
                                else
                                {
                                    for (int i = 0; i < data.Length; i++)
                                    {
                                        RC4 += " " + NewRC4Key[i];
                                    }
                                }

                                textBoxGeneratedKey.Text = RC4;
                                rbPlainText.Text = resMMO;
                                ShowRC4REsult(ref data, NewRC4Key, NewRC4Key.Length);
                                string resRes = Binary(data, ref countMMO);
                                rbCypherText.Text = resRes;
                                RC4Bytes = new byte[data.Length];
                                RC4Bytes = NewRC4Key;
                                File.WriteAllBytes("Encrypted.txt", data);
                            }
                            else
                                MessageBox.Show("The number of bits should devide on 8.");
                        }
                    }
                    else
                        MessageBox.Show(EMPTY_FILE_MSG);
                }
                else
                    MessageBox.Show(FILE_NOT_CHOOSED);
            }
        }

        const string ENCRYPTED_FILE_EMPTY_MSG = "You don't encrypt anything." + 
            "Encrypt and then try to decrypt.";
        const string FILE_SAVING_NOT_CHOOSEN = "File for saving results in not choosen.";
        // decryption
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxGeneratedKey.Text.Length == 0) || (richTextBoxInitialKey.Text.Length == 0))
            {
                MessageBox.Show(EMPTY_KEY_MSG);
            }
            else
            {
                var fi = new FileInfo("Encrypted.txt");
                if (fi.Length != 0)
                {
                    if (radioButtonLFSR1.Checked)
                    {
                        richTextBoxInitialKey.MaxLength = BIT_CAPACITY;
                        byte[] data = File.ReadAllBytes("Encrypted.txt");
                        richTextBoxInitialKey.Text = richTextBoxInitialKey.Text.PadLeft(BIT_CAPACITY, '0');
                        LFSR1Encode(ref data, richTextBoxInitialKey.Text);
                        rbPlainText.Text = displayBinary(data);
                        //SPECIAL BINARY WRITE
                        if (saveFileDialogFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            File.WriteAllBytes(saveFileDialogFile.FileName, data);
                        else
                            MessageBox.Show(FILE_SAVING_NOT_CHOOSEN);
                    }
                    if (radioButtonGeffeGenerator.Checked)
                    {
                        byte[] data = File.ReadAllBytes("Encrypted.txt");
                        richTextBoxLFSR2.Text = richTextBoxLFSR2.Text.PadLeft(33, '0');
                        richTextBoxLFSR3.Text = richTextBoxLFSR3.Text.PadLeft(23, '0');
                        richTextBoxInitialKey.Text = richTextBoxInitialKey.Text.PadLeft(BIT_CAPACITY, '0');
                        data = GeffeGenerator(ref data, richTextBoxInitialKey.Text,
                            richTextBoxLFSR2.Text, richTextBoxLFSR3.Text);
                        rbPlainText.Text = displayBinary(data);
                        if (saveFileDialogFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            File.WriteAllBytes(saveFileDialogFile.FileName, data);
                        else
                            MessageBox.Show(FILE_SAVING_NOT_CHOOSEN);
                    }
                    if (radioButtonRC4.Checked)
                    {
                        byte[] data = File.ReadAllBytes("Encrypted.txt");
                        richTextBoxInitialKey.Text = 
                            richTextBoxInitialKey.Text.PadLeft(BYTE_LENCTH, '0');
                        ShowRC4REsult(ref data, RC4Bytes, RC4Bytes.Length);
                        if (saveFileDialogFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            File.WriteAllBytes(saveFileDialogFile.FileName, data);
                        }
                        else
                            MessageBox.Show(FILE_SAVING_NOT_CHOOSEN);
                    }
                }
                else
                    MessageBox.Show(ENCRYPTED_FILE_EMPTY_MSG);
            }
        }

        private void richTextBoxInitialKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D1 || e.Shift || e.Alt ||
                e.KeyCode == Keys.Home || e.KeyCode == Keys.End)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGeffeGenerator_Enter(object sender, EventArgs e)
        {
            lblTitleLFSR1.Visible = true;
            lblTitleLFSR3.Visible = true;
            lblTitleResKey.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            textBoxLFSR2.Visible = true;
            textBoxLFSR3.Visible = true;
            richTextBoxLFSR2.Visible = true;
            richTextBoxLFSR3.Visible = true;
            textBoxResultKey.Visible = true;
        }

        private void label5_Enter(object sender, EventArgs e)
        {
        }

        private void radioButtonLFSR1_Enter(object sender, EventArgs e)
        {
            lblTitleLFSR1.Visible = false;
            lblTitleLFSR3.Visible = false;
            lblTitleResKey.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            textBoxLFSR2.Visible = false;
            textBoxLFSR3.Visible = false;
            richTextBoxLFSR2.Visible = false;
            richTextBoxLFSR3.Visible = false;
            textBoxResultKey.Visible = false;
        }

        private void richTextBoxLFSR2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D1 || e.Shift || e.Alt ||
                e.KeyCode == Keys.Home || e.KeyCode == Keys.End)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void richTextBoxLFSR3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D1 || e.Shift || e.Alt ||
                e.KeyCode == Keys.Home || e.KeyCode == Keys.End)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void radioButtonRC4_Enter_1(object sender, EventArgs e)
        {
            lblTitleLFSR1.Visible = false;
            lblTitleLFSR3.Visible = false;
            lblTitleResKey.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            textBoxLFSR2.Visible = false;
            textBoxLFSR3.Visible = false;
            richTextBoxLFSR2.Visible = false;
            richTextBoxLFSR3.Visible = false;
            textBoxResultKey.Visible = false;
            richTextBoxInitialKey.MaxLength = 128;
        }
    }
}
