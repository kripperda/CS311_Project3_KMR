using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPlace
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        }//end Summarize method for btnCalculate_Click

        private void Summarize()
        {
            String orderSummary, pizzaSize, crustType, toppings = "";
            int noToppings = 0;
            
            double totalCost = 0.0;
            double toppingsCost = 0.0; 
            double pizzaCost = 0.0;
            double basePizzaCost;
            double tax = 0.0;
            pizzaSize = cboSize.SelectedText;

            orderSummary = rtbOrderSummary.Text;

            
                
            
            if (cboSize.SelectedItem == "Small")
            {
                pizzaSize = "Small";
                pizzaCost += 2.00;
            }
            else if (cboSize.SelectedItem == "Medium")
            {
                pizzaSize = "Medium";
                pizzaCost += 5.00;
            }
            else if (cboSize.SelectedItem == "Large")
            {
                pizzaSize = "Large";
                pizzaCost += 10.00;
            }
            else if (cboSize.SelectedItem == "ExtraLarge")
            {
                pizzaSize = "Extra Large";
                pizzaCost += 15.00;
            }
            else if (cboSize.SelectedItem == "Ginormous")
            {
                pizzaSize = "Ginormous";
                pizzaCost += 20.00;
            }
            
            {
            if (rdoThin.Checked)
            {
                crustType = "Thin"; 
            }
            else if (rdoRegular.Checked)
            {
                crustType = "Regular";
            }
            else //(rdoThick.Checked)
            {
                crustType = "Thick";
            }
            

            if(ckbPepperoni.Checked == true)
            {
                noToppings++;
                toppingsCost += 2.00;
                toppings += "Pepperoni\n";
            }
            if(ckbSausage.Checked == true)
            {
                noToppings++;
                toppingsCost += 2.00;
                toppings += "Sausage\n";
            }
            if (ckbCanadianBacon.Checked == true)
            {
                noToppings++;
                toppingsCost += 2.00;
                toppings += "Canadian Bacon\n";
            }
            if (ckbSpicyItalianSausage.Checked == true)
            {
                noToppings++;
                toppingsCost += 2.00;
                toppings += "SpicyItalianSausage\n";
            }
            if (ckbOnion.Checked == true)
            {
                noToppings++;
                toppingsCost += 1.00;
                toppings += "Onion\n";
            }
            if (ckbGreenPepper.Checked == true)
            {
                noToppings++;
                toppingsCost += 1.00;
                toppings += "Green Pepper\n";
            }
            if (ckbBlackOlives.Checked == true)
            {
                noToppings++;
                toppingsCost += 1.00;
                toppings += "BlackOlives\n";
            }
            if (ckbGreenOlives.Checked == true)
            {
                noToppings++;
                toppingsCost += 1.00;
                toppings += "Green Olives\n";
            }
            if (ckbBananaPeppers.Checked == true)
            {
                noToppings++;
                toppingsCost += 1.00;
                toppings += "Banana Peppers\n";
            }
            if (ckbJalapeno.Checked == true)
            {
                noToppings++;
                toppingsCost += 1.00;
                toppings += "Jalapeno\n";
            }
            if (ckbExtraCheese.Checked == true)
            {
                noToppings++;
                toppingsCost += 1.00;
                toppings += "Extra Cheese\n";
            }
            if (ckbMushrooms.Checked == true)
            {
                noToppings++;
                toppingsCost += 1.00;
                toppings += "Mushrooms\n";
            } 

            

            rtbOrderSummary.Text = "You ordered a " +pizzaSize+ "pizza  with " +crustType+ "crust and the following toppings:\n" +toppings+ "\n";

            basePizzaCost = pizzaCost + toppingsCost;
            txtSubTotal.Text = basePizzaCost.ToString("C");
            tax = basePizzaCost * 0.10;
            txtTax.Text = tax.ToString("C");
            totalCost = basePizzaCost + tax;
            txtTotal.Text = totalCost.ToString("C");
        }
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String size = cboSize.GetItemText(cboSize.SelectedItem);
           
            
            
            //rtbOrderSummary.Text = ("You ordered a " + size + " with " + crust + "crust and the following toppings:\n");
        }
         
            
            
        private void grpCrust_Enter(object sender, EventArgs e)
        { 
        
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

       
           
          
        


    }//end class
}//end namespace
