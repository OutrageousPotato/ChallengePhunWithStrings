using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Bob Tabor";
            // In my case, the result would be:
            // robaT boB
            for (int i = name.Length - 1; i >= 0 ; i--)
            {
                resultLabel1.Text += name[i];
            }


            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            string[] starWarsPeeps = names.Split(',');
            string reverseNames = "";
            for (int i = starWarsPeeps.Length - 1; i >= 0; i--)
            {
                reverseNames += starWarsPeeps[i] + ", ";
            }
            reverseNames = reverseNames.TrimEnd(' ');
            resultLabel2.Text = names.TrimEnd(',');

            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string result = "";

            for (int i = 0; i < starWarsPeeps.Length; i++)
            {
                int spaces = 14 - starWarsPeeps[i].Length;
                int padLeft = spaces / 2 + starWarsPeeps[i].Length;
                result += starWarsPeeps[i].PadLeft(padLeft,'*').PadRight(14, '*') + "<br />";
            }
            resultLabel3.Text = result;


            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            resultLabel4.Text = puzzle.Replace("remove-me", "").Replace('Z','T').ToLower().Replace("now","Now");


        }
    }
}