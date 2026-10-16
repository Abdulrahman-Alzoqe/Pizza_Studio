using PizzaStudioProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStudioProject
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (small.Checked)

                return Convert.ToSingle(small.Tag);

            else if (Medium.Checked)

                return Convert.ToSingle(Medium.Tag);

            else

                return Convert.ToSingle(Large.Tag);
        }

        float CalculateToppingsPrice()
        {
            float ToppingsPrice = 0;

            if (chkExtraChease.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkExtraChease.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOnion.Tag);
            }
           
            if (chkTomatoes.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkGreenPappers.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkGreenPappers.Tag);
            }

            return ToppingsPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (ThinCrust.Checked)

                return Convert.ToSingle(ThinCrust.Tag);

            else
                return Convert.ToSingle(ThickCrust.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedCrustPrice() + CalculateToppingsPrice() + GetSelectedSizePrice();
        }

        void UpdateTotalPrice()
        {
            labTotalPrice.Text = CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (small.Checked)
            {
                labSize.Text = "Small";
                return;
            }

            if (Medium.Checked)
            {
                labSize.Text = "Medium";
                return;
            }

            if (Large.Checked)
            {
                labSize.Text = "Large";
                return;
            }

        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (ThinCrust.Checked)
            {
                laCrust.Text = "Thin";
                return;
            }

            if (ThickCrust.Checked)
            {
                laCrust.Text = "Thick";
                return;
            }
                    
        }

        private void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if (chkExtraChease.Checked)
            {
                sToppings = "Extra Cheese";
            }

            if (chkGreenPappers.Checked)
            {
                sToppings += ", Green Pappers";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if(sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            labTopping.Text = sToppings;
        }

        void UpdateService()
        {
            labService.Text = TakeAway.Checked ? "Take Out" : "Eat In";
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

            imgTomatoes.Visible = chkTomatoes.Checked;
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

            imgOlive.Visible = chkOlives.Checked;
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

            imgOnion.Visible = chkOnion.Checked;
        }

        private void chkGreenPapers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

            imgPaper.Visible = chkGreenPappers.Checked;
        }

        private void chkExtraChease_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkMushrooms_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateToppings();

            imgMushroom.Visible = chkMushrooms.Checked;
        }

        private void ThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

            imgPizza.Visible = false;

            imgPizza.Image = Properties.Resources.pizza_base_thick;

            imgPizza.Visible = true;
        }

        private void ThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

            imgPizza.Visible = false;

            imgPizza.Image = Properties.Resources.pizza_base_thin;

            imgPizza.Visible = true;
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void small_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Large_Click(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void TakeAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateService();
        }

        private void EatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateService();
        }

        private void Reset()
        {
            btnOrderPizza.Enabled = true;

            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            grbTroppings.Enabled = true;

            small.Checked = true;
            ThinCrust.Checked = true;
            EatIn.Checked = true;

            chkExtraChease.Checked = false;
            chkGreenPappers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;

        }
        private void label7_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm", MessageBoxButtons.OKCancel
                ,MessageBoxIcon.Question) == DialogResult.OK )
            {
                MessageBox.Show("Order Placed Successfuly", "Success"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                grbTroppings.Enabled = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateTotalPrice();
            UpdateService();
        }
    }
}
