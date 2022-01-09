using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator.Classes
{
    internal class ClassTip
    {
        //<------------Calculate Tip amount for each person------------>
        public static float Tip_PerPerson(float total, float tip, int number_person)
        {
            float bill_per_person = total / number_person;
            float total_tip = tip / 100;
            float tip_per_person = bill_per_person * total_tip;
            return tip_per_person;
        }
        //<--------------<Calculate Total amount for each person------------> 
        public static float Bill_PerPerson(float total, float tip, int number_person)
        {
            float bill_per_person = total / number_person;
            float tip_per_person = Tip_PerPerson(total, tip, number_person);
            return bill_per_person + tip_per_person;
        }

        //<------------Validate different test cases------------------------->
        public static bool Validate(string Total_bill,string Tip,string number_person)
        {
            bool Flag=true;
    
            if(Total_bill=="" && Tip=="" && number_person=="")
            {
                Flag = false;
            }
            return Flag;
        }

    }
}
