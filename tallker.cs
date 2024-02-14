using System;
using System.Windows.Forms;

public class Class1
{
    public int BlahBlahBlah(string thingToSay, int numberOfTimes)
    {
        string finalString = "";
        for (int count = 1; count <= numberOfTimes; count++)
        {
            finalString += thingToSay + "\n";
        }
        MessageBox.Show(finalString);
        return finalString.Length;
    }
}
