using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperSimple
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }

        protected void okButton_Click(object sender, EventArgs e)
        {
            Names Cnames = new Names();
            Numbers Cnumbers = new Numbers();
            Cnames.CatName = "Senge";
            Cnumbers.CatAge = 8;
            int kittyAge = Procedures.CalcCatYears(Cnumbers.CatAge);

            Names Dnames = new Names();
            Numbers Dnumbers = new Numbers();
            Dnames.DogName = "The Dog";
            Dnumbers.DogAge = 8;
            int puppyAge = Procedures.CalcDogYears(Dnumbers.DogAge);


            resultLabel.Text += string.Format("{0} is {1}<br/>", Cnames.CatName, kittyAge);
            resultLabel.Text += string.Format("{0} is {1}<br/>", Dnames.DogName, puppyAge);
        }
    }



    public class Names
    {
        public string CatName { get; set; }
        public string DogName { get; set; }
    }

    public class Numbers
    {
        public int CatAge { get; set; }
        public int DogAge { get; set; }



    }

    public static class Procedures
    {
        public static int CalcCatYears(int ageC)
        {   ageC = ageC * 5;      return ageC;     }

        public static int CalcDogYears(int ageD)
        {   ageD = ageD * 9;      return ageD; }
    }
}
    
 