using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TipCalculator.Classes;
namespace TipCalculator
{
    public partial class Form1 : Form
    {   //<-------------------Round shape of window form------------------->
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidhtEllipse,
        int nHidhtEllipse
        );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle= FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));            
        }


        //<-------------------Tip percentage text area changed field--------------------->
        private void TipPer_TextChanged(object sender, EventArgs e)
        {
            try
            {   
                if (ClassTip.Validate(Total_Bill.Text, Tip.Text, No_of_people.Text))
                    Complete_Bill(float.Parse(Total_Bill.Text), float.Parse(Tip.Text), int.Parse(No_of_people.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Field cant't be empty");
            }

        }
       
        //<--------------------------------No of people increment button--------------->
        private void No_of_people_increment_Click(object sender, EventArgs e)
        {
            if (No_of_people.Text != "" && No_of_people.Text != "0")
            {
                No_of_people.Text = Convert.ToString(int.Parse(No_of_people.Text) + 1);

                try
                {
                    if (ClassTip.Validate(Total_Bill.Text, Tip.Text, No_of_people.Text))
                        Complete_Bill(float.Parse(Total_Bill.Text), float.Parse(Tip.Text), int.Parse(No_of_people.Text));
                }
                catch (Exception)
                {

                    Console.WriteLine("Exception Block");
                }
            }
        }

        //<--------------------------------No of people decrement button--------------->
        private void No_of_people_decrement_Clic(object sender, EventArgs e)
        {
            if (No_of_people.Text != "" && int.Parse(No_of_people.Text) >= 1 && No_of_people.Text != "0")
            {
                No_of_people.Text = Convert.ToString(int.Parse(No_of_people.Text) - 1);
                try
                {
                    if (ClassTip.Validate(Total_Bill.Text, Tip.Text, No_of_people.Text))
                        Complete_Bill(float.Parse(Total_Bill.Text), float.Parse(Tip.Text), int.Parse(No_of_people.Text));
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception area!!");
                }
            }

        }

        //<--------------------------Tip Decrement button--------------->
        private void Tip_decrement_Click(object sender, EventArgs e)
        {
            if (Tip.Text != "" && int.Parse(Tip.Text) >0)
            {
                Tip.Text = Convert.ToString(int.Parse(Tip.Text) - 1);

                try
                {
                    if (ClassTip.Validate(Total_Bill.Text, Tip.Text, No_of_people.Text))
                        Complete_Bill(float.Parse(Total_Bill.Text), float.Parse(Tip.Text), int.Parse(No_of_people.Text));
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception Block");
                }
            }
        }


    //<---------------------------Calculate no of people Text field changes------------------->
      private void No_of_people_TextChanged(object sender, EventArgs e)
        {
            if (No_of_people.Text == "0")
            {
                MessageBox.Show("Area can't be less than 1");
                No_of_people.Text = "1";
            }
            if (No_of_people.Text == "")
            {
                MessageBox.Show("Please fill input field..");
             
            }

            if (No_of_people.Text != "" && int.Parse(No_of_people.Text) >= 1 )
            {
                try
                {
                    if (ClassTip.Validate(Total_Bill.Text, Tip.Text, No_of_people.Text))
                        Complete_Bill(float.Parse(Total_Bill.Text), float.Parse(Tip.Text), int.Parse(No_of_people.Text));

                }
                catch (Exception)
                {
                    MessageBox.Show("Field can't be empty");
                }
            }

           

        }
        //<-----------------Tip increment button----------------->
        private void Tip_Increment_Click(object sender, EventArgs e)
        {
            if (Tip.Text != "")
            {
                Tip.Text = Convert.ToString(int.Parse(Tip.Text) + 1);

                try
                {
                    if (ClassTip.Validate(Total_Bill.Text, Tip.Text, No_of_people.Text))
                        Complete_Bill(float.Parse(Total_Bill.Text), float.Parse(Tip.Text), int.Parse(No_of_people.Text));
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception Block");
                }
            }
        }
        //<----------------------Bill amount -------->
        private void Totalbill_changed(object sender, EventArgs e)
        {
            try
            {
                if (ClassTip.Validate(Total_Bill.Text, Tip.Text, No_of_people.Text))
                    Complete_Bill(float.Parse(Total_Bill.Text), float.Parse(Tip.Text), int.Parse(No_of_people.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Field cant't be empty");
            }


        }

        //<------------Calling both methods at same time for code reusability-------->
        public void Complete_Bill(float total, float tip, int number_person)
        {
            Tip_Count.Text = ClassTip.Tip_PerPerson(total, tip, number_person).ToString("0.00");

            Bill_per_person.Text = ClassTip.Bill_PerPerson(total, tip, number_person).ToString("0.00");

        }

        //<------------Only for int value--------------------->
        private void OnlyDigitPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //<----------------For Close the form---------------->
        private void Close_btn_event(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
