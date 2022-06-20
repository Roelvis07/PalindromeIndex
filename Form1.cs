using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalindromeIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Console.WriteLine(palindromeIndex("bcbc"));
        }
       
        public int palindromeIndex(string s)
        {
            string stringAux = "";
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[s.Length - 1 - i])
                    continue;

                stringAux = s.Remove(i, 1);
                if (stringAux.SequenceEqual(stringAux.Reverse()))
                    return i;

                stringAux = s.Remove(s.Length - 1 - i, 1);
                if (stringAux.SequenceEqual(stringAux.Reverse()))
                    return s.Length - 1 - i;
            }

            return -1;
        }
    }
}
