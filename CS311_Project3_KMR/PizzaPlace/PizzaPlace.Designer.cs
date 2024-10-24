namespace PizzaPlace
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRizzaPizza = new System.Windows.Forms.Label();
            this.picPizzaGuy = new System.Windows.Forms.PictureBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rtbOrderSummary = new System.Windows.Forms.RichTextBox();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.ckbMushrooms = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbJalapeno = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaGuy)).BeginInit();
            this.grpCrust.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRizzaPizza
            // 
            this.lblRizzaPizza.AutoSize = true;
            this.lblRizzaPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRizzaPizza.Location = new System.Drawing.Point(267, 27);
            this.lblRizzaPizza.Name = "lblRizzaPizza";
            this.lblRizzaPizza.Size = new System.Drawing.Size(214, 42);
            this.lblRizzaPizza.TabIndex = 0;
            this.lblRizzaPizza.Text = "Rizza Pizza";
            // 
            // picPizzaGuy
            // 
            this.picPizzaGuy.Image = global::PizzaPlace.Properties.Resources.images;
            this.picPizzaGuy.Location = new System.Drawing.Point(24, 12);
            this.picPizzaGuy.Name = "picPizzaGuy";
            this.picPizzaGuy.Size = new System.Drawing.Size(225, 223);
            this.picPizzaGuy.TabIndex = 1;
            this.picPizzaGuy.TabStop = false;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(286, 86);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 20);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // cboSize
            // 
            this.cboSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(345, 83);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 28);
            this.cboSize.TabIndex = 3;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdoThick);
            this.grpCrust.Controls.Add(this.rdoRegular);
            this.grpCrust.Controls.Add(this.rdoThin);
            this.grpCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.Location = new System.Drawing.Point(274, 135);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(420, 29);
            this.grpCrust.TabIndex = 5;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            this.grpCrust.Enter += new System.EventHandler(this.grpCrust_Enter);
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(273, 0);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(69, 24);
            this.rdoThick.TabIndex = 2;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(164, 0);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(90, 24);
            this.rdoRegular.TabIndex = 1;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(76, 0);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(61, 24);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // rtbOrderSummary
            // 
            this.rtbOrderSummary.Location = new System.Drawing.Point(114, 449);
            this.rtbOrderSummary.Name = "rtbOrderSummary";
            this.rtbOrderSummary.Size = new System.Drawing.Size(367, 179);
            this.rtbOrderSummary.TabIndex = 6;
            this.rtbOrderSummary.Text = "";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.ckbMushrooms);
            this.grpToppings.Controls.Add(this.ckbExtraCheese);
            this.grpToppings.Controls.Add(this.ckbJalapeno);
            this.grpToppings.Controls.Add(this.ckbBananaPeppers);
            this.grpToppings.Controls.Add(this.ckbOnion);
            this.grpToppings.Controls.Add(this.ckbGreenPepper);
            this.grpToppings.Controls.Add(this.ckbBlackOlives);
            this.grpToppings.Controls.Add(this.ckbGreenOlives);
            this.grpToppings.Controls.Add(this.ckbSpicyItalianSausage);
            this.grpToppings.Controls.Add(this.ckbCanadianBacon);
            this.grpToppings.Controls.Add(this.ckbSausage);
            this.grpToppings.Controls.Add(this.ckbPepperoni);
            this.grpToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(59, 270);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(585, 149);
            this.grpToppings.TabIndex = 7;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings:";
            // 
            // ckbMushrooms
            // 
            this.ckbMushrooms.AutoSize = true;
            this.ckbMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMushrooms.Location = new System.Drawing.Point(411, 119);
            this.ckbMushrooms.Name = "ckbMushrooms";
            this.ckbMushrooms.Size = new System.Drawing.Size(120, 24);
            this.ckbMushrooms.TabIndex = 11;
            this.ckbMushrooms.Text = "Mushrooms";
            this.ckbMushrooms.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbExtraCheese.Location = new System.Drawing.Point(411, 89);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(136, 24);
            this.ckbExtraCheese.TabIndex = 10;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            this.ckbJalapeno.AutoSize = true;
            this.ckbJalapeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbJalapeno.Location = new System.Drawing.Point(411, 59);
            this.ckbJalapeno.Name = "ckbJalapeno";
            this.ckbJalapeno.Size = new System.Drawing.Size(101, 24);
            this.ckbJalapeno.TabIndex = 9;
            this.ckbJalapeno.Text = "Jalapeno";
            this.ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBananaPeppers.Location = new System.Drawing.Point(411, 29);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(161, 24);
            this.ckbBananaPeppers.TabIndex = 8;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOnion.Location = new System.Drawing.Point(263, 29);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(75, 24);
            this.ckbOnion.TabIndex = 7;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGreenPepper.Location = new System.Drawing.Point(263, 59);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(140, 24);
            this.ckbGreenPepper.TabIndex = 6;
            this.ckbGreenPepper.Text = "Green Pepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBlackOlives.Location = new System.Drawing.Point(263, 89);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(125, 24);
            this.ckbBlackOlives.TabIndex = 5;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGreenOlives.Location = new System.Drawing.Point(263, 119);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(131, 24);
            this.ckbGreenOlives.TabIndex = 4;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(55, 119);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(202, 24);
            this.ckbSpicyItalianSausage.TabIndex = 3;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCanadianBacon.Location = new System.Drawing.Point(55, 89);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(160, 24);
            this.ckbCanadianBacon.TabIndex = 2;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSausage.Location = new System.Drawing.Point(55, 59);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(99, 24);
            this.ckbSausage.TabIndex = 1;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPepperoni.Location = new System.Drawing.Point(55, 29);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(109, 24);
            this.ckbPepperoni.TabIndex = 0;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.Location = new System.Drawing.Point(60, 422);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(163, 24);
            this.lblOrderSummary.TabIndex = 8;
            this.lblOrderSummary.Text = "Order Summary:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(488, 449);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(86, 20);
            this.lblSubTotal.TabIndex = 9;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(517, 512);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(529, 479);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(42, 20);
            this.lblTax.TabIndex = 11;
            this.lblTax.Text = "Tax:";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(581, 444);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(138, 26);
            this.txtSubTotal.TabIndex = 12;
            this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(581, 476);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(138, 26);
            this.txtTax.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(581, 509);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(138, 26);
            this.txtTotal.TabIndex = 14;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(521, 558);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(198, 69);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 639);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.rtbOrderSummary);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.picPizzaGuy);
            this.Controls.Add(this.lblRizzaPizza);
            this.Name = "frmMain";
            this.Text = "Rizza Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaGuy)).EndInit();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRizzaPizza;
        private System.Windows.Forms.PictureBox picPizzaGuy;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.RichTextBox rtbOrderSummary;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox ckbMushrooms;
        private System.Windows.Forms.CheckBox ckbExtraCheese;
        private System.Windows.Forms.CheckBox ckbJalapeno;
        private System.Windows.Forms.CheckBox ckbBananaPeppers;
        private System.Windows.Forms.CheckBox ckbOnion;
        private System.Windows.Forms.CheckBox ckbGreenPepper;
        private System.Windows.Forms.CheckBox ckbBlackOlives;
        private System.Windows.Forms.CheckBox ckbGreenOlives;
        private System.Windows.Forms.CheckBox ckbSpicyItalianSausage;
        private System.Windows.Forms.CheckBox ckbCanadianBacon;
        private System.Windows.Forms.CheckBox ckbSausage;
        private System.Windows.Forms.CheckBox ckbPepperoni;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
    }
}

