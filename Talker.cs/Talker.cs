using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talker.cs
{
    public partial class Talker : Form
    {
        public Talker()
        {
            InitializeComponent();

            nupdtimes.Minimum = 1;
            nupdtimes.Maximum = 10;
            nupdtimes.Value = 3;
        }   

        private void btnspeak_Click(object sender, EventArgs e)
        {
            int len = BlahBlahBlah(txtinsira.Text, (int)nupdtimes.Value);
            MessageBox.Show("The message length is " + len);
        }

        private int BlahBlahBlah(string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTimes; count++)
            {
                finalString += thingToSay + "\n";
            }
            MessageBox.Show(finalString, "!");
            return finalString.Length;
        }

    }
}
