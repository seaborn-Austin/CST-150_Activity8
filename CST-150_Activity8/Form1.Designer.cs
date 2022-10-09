namespace CST_150_Activity8
{
    partial class calorieCalculatorFrm
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
            this.fatGramLbl = new System.Windows.Forms.Label();
            this.carbGramsLbl = new System.Windows.Forms.Label();
            this.fatGramTxt = new System.Windows.Forms.TextBox();
            this.carbGramsTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.totalCalTxt = new System.Windows.Forms.TextBox();
            this.totalCalLbl = new System.Windows.Forms.Label();
            this.totalFatCalLbl = new System.Windows.Forms.Label();
            this.totalCarbCalLbl = new System.Windows.Forms.Label();
            this.totalFatCalTxt = new System.Windows.Forms.TextBox();
            this.totalCarbCalTxt = new System.Windows.Forms.TextBox();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.breakdownLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fatGramLbl
            // 
            this.fatGramLbl.AutoSize = true;
            this.fatGramLbl.Location = new System.Drawing.Point(64, 89);
            this.fatGramLbl.Name = "fatGramLbl";
            this.fatGramLbl.Size = new System.Drawing.Size(74, 13);
            this.fatGramLbl.TabIndex = 0;
            this.fatGramLbl.Text = "Fat (In grams):";
            // 
            // carbGramsLbl
            // 
            this.carbGramsLbl.AutoSize = true;
            this.carbGramsLbl.Location = new System.Drawing.Point(12, 115);
            this.carbGramsLbl.Name = "carbGramsLbl";
            this.carbGramsLbl.Size = new System.Drawing.Size(127, 13);
            this.carbGramsLbl.TabIndex = 1;
            this.carbGramsLbl.Text = "Carbohydrates (In grams):";
            this.carbGramsLbl.Click += new System.EventHandler(this.carbGramsLbl_Click);
            // 
            // fatGramTxt
            // 
            this.fatGramTxt.Location = new System.Drawing.Point(144, 82);
            this.fatGramTxt.Name = "fatGramTxt";
            this.fatGramTxt.Size = new System.Drawing.Size(100, 20);
            this.fatGramTxt.TabIndex = 2;
            // 
            // carbGramsTxt
            // 
            this.carbGramsTxt.Location = new System.Drawing.Point(146, 108);
            this.carbGramsTxt.Name = "carbGramsTxt";
            this.carbGramsTxt.Size = new System.Drawing.Size(100, 20);
            this.carbGramsTxt.TabIndex = 3;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(117, 350);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(224, 350);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // totalCalTxt
            // 
            this.totalCalTxt.Location = new System.Drawing.Point(146, 143);
            this.totalCalTxt.Name = "totalCalTxt";
            this.totalCalTxt.Size = new System.Drawing.Size(100, 20);
            this.totalCalTxt.TabIndex = 6;
            // 
            // totalCalLbl
            // 
            this.totalCalLbl.AutoSize = true;
            this.totalCalLbl.Location = new System.Drawing.Point(36, 150);
            this.totalCalLbl.Name = "totalCalLbl";
            this.totalCalLbl.Size = new System.Drawing.Size(102, 13);
            this.totalCalLbl.TabIndex = 7;
            this.totalCalLbl.Text = "Total Caloric Intake:";
            // 
            // totalFatCalLbl
            // 
            this.totalFatCalLbl.AutoSize = true;
            this.totalFatCalLbl.Location = new System.Drawing.Point(12, 271);
            this.totalFatCalLbl.Name = "totalFatCalLbl";
            this.totalFatCalLbl.Size = new System.Drawing.Size(115, 13);
            this.totalFatCalLbl.TabIndex = 8;
            this.totalFatCalLbl.Text = "Total Calories from Fat:";
            // 
            // totalCarbCalLbl
            // 
            this.totalCarbCalLbl.AutoSize = true;
            this.totalCarbCalLbl.Location = new System.Drawing.Point(12, 295);
            this.totalCarbCalLbl.Name = "totalCarbCalLbl";
            this.totalCarbCalLbl.Size = new System.Drawing.Size(126, 13);
            this.totalCarbCalLbl.TabIndex = 9;
            this.totalCarbCalLbl.Text = "Total calories from Carbs:";
            // 
            // totalFatCalTxt
            // 
            this.totalFatCalTxt.Location = new System.Drawing.Point(145, 262);
            this.totalFatCalTxt.Name = "totalFatCalTxt";
            this.totalFatCalTxt.Size = new System.Drawing.Size(100, 20);
            this.totalFatCalTxt.TabIndex = 10;
            // 
            // totalCarbCalTxt
            // 
            this.totalCarbCalTxt.Location = new System.Drawing.Point(144, 288);
            this.totalCarbCalTxt.Name = "totalCarbCalTxt";
            this.totalCarbCalTxt.Size = new System.Drawing.Size(100, 20);
            this.totalCarbCalTxt.TabIndex = 11;
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLbl.Location = new System.Drawing.Point(12, 29);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(382, 36);
            this.instructionLbl.TabIndex = 12;
            this.instructionLbl.Text = "Please enter the amount of Fat and Carbohydrates in the \r\ntwo fields below:";
            // 
            // breakdownLbl
            // 
            this.breakdownLbl.AutoSize = true;
            this.breakdownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdownLbl.Location = new System.Drawing.Point(89, 231);
            this.breakdownLbl.Name = "breakdownLbl";
            this.breakdownLbl.Size = new System.Drawing.Size(157, 18);
            this.breakdownLbl.TabIndex = 13;
            this.breakdownLbl.Text = "Calories broken down:";
            // 
            // calorieCalculatorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 395);
            this.Controls.Add(this.breakdownLbl);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.totalCarbCalTxt);
            this.Controls.Add(this.totalFatCalTxt);
            this.Controls.Add(this.totalCarbCalLbl);
            this.Controls.Add(this.totalFatCalLbl);
            this.Controls.Add(this.totalCalLbl);
            this.Controls.Add(this.totalCalTxt);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.carbGramsTxt);
            this.Controls.Add(this.fatGramTxt);
            this.Controls.Add(this.carbGramsLbl);
            this.Controls.Add(this.fatGramLbl);
            this.Name = "calorieCalculatorFrm";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatGramLbl;
        private System.Windows.Forms.Label carbGramsLbl;
        private System.Windows.Forms.TextBox fatGramTxt;
        private System.Windows.Forms.TextBox carbGramsTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox totalCalTxt;
        private System.Windows.Forms.Label totalCalLbl;
        private System.Windows.Forms.Label totalFatCalLbl;
        private System.Windows.Forms.Label totalCarbCalLbl;
        private System.Windows.Forms.TextBox totalFatCalTxt;
        private System.Windows.Forms.TextBox totalCarbCalTxt;
        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.Label breakdownLbl;
    }
}

