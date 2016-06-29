using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var warrior1 = new Samurai(new Shuriken());
            var warrior2 = new Samurai(new Sword());
            LBWar.Items.Add(warrior1.Attack("the evildoers"));
            LBWar.Items.Add(warrior2.Attack("the evildoers"));

            //You can create an instance of the derived class
            absDerived calculate = new absDerived();
            absDerived calculate2 = new absDerived();
            int added = calculate.AddTwoNumbers(10, 20);
            int added2 = calculate2.AddTwoNumbers(5,5);
            int multiplied = calculate.MultiplyTwoNumbers(10, 20);
            ListBox1.Items.Add(string.Format("Added : {0},Multiplied : {1}", added, multiplied));
        }

    }
}