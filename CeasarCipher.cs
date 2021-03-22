using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Educator
{
    class CeasarCipher
    {
        public string Encrypt(int key, string pt)
        {
            int size = pt.Length;
            char[] value = new char[size];
            char[] cipher = new char[size];
            for (int r = 0; r < size; r++)
            {
                value[r] = Convert.ToChar(pt.Substring(r, 1));
            }

            for (int re = 0; re < size; re++)
            {
                int count = 0;
                int a = Convert.ToInt32(value[re]);
                for (int y = 1; y <= key; y++)
                {
                    if (count == 0)
                    {
                        if (a == 90)
                        {
                            a = 64;
                        }
                        else if (a == 122)
                        {
                            a = 96;
                        }
                        cipher[re] = Convert.ToChar(a + y);
                        count++;
                    }
                    else
                    {
                        int b = Convert.ToInt32(cipher[re]);
                        if (b == 90)
                        {
                            b = 64;
                        }
                        else if (b == 122)
                        {
                            b = 96;
                        }
                        cipher[re] = Convert.ToChar(b + 1);
                    }
                }
            }
            string ciphertext = "";

            //turned into Cipher text
            for (int p = 0; p < size; p++)
            {
                ciphertext = ciphertext + cipher[p].ToString();
            }
            return ciphertext;
        }

        //Cipher text
        public string Decrypt(int key, string ct)
        {
            int size = ct.Length;
            char[] value = new char[size];
            char[] cipher = new char[size];
            for (int r = 0; r < size; r++)
            {
                cipher[r] = Convert.ToChar(ct.Substring(r, 1));
            }

            for (int re = 0; re < size; re++)
            {
                int count = 0;
                int a = Convert.ToInt32(cipher[re]);
                for (int y = 1; y <= key; y++)
                {
                    if (count == 0)
                    {
                        if (a == 65)
                        {
                            a = 91;
                        }
                        else if (a == 97)
                        {
                            a = 123;
                        }
                        value[re] = Convert.ToChar(a - y);
                        count++;
                    }
                    else
                    {
                        int b = Convert.ToInt32(value[re]);
                        if (b == 65)
                        {
                            b = 91;
                        }
                        else if (b == 97)
                        {
                            b = 123;
                        }
                        value[re] = Convert.ToChar(b - 1);
                    }
                }
            }
            string plaintext = "";

            //returned to plain text
            for (int p = 0; p < size; p++)
            {
                plaintext = plaintext + value[p].ToString();
            }
            return plaintext;
        }
    }
}
