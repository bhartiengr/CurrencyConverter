namespace CurrencyConverter1
{
    partial class CurrencyConverter
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.lbConvertCurrency = new System.Windows.Forms.Label();
            this.lbConvertFrom = new System.Windows.Forms.Label();
            this.lbConvertTo = new System.Windows.Forms.Label();
            this.cmboxFrom = new System.Windows.Forms.ComboBox();
            this.cmboxTo = new System.Windows.Forms.ComboBox();
            this.txtboxCurrencyAmount = new System.Windows.Forms.TextBox();
            this.btConvert = new System.Windows.Forms.Button();
            this.txtboxResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbConvertCurrency
            // 
            this.lbConvertCurrency.AutoSize = true;
            this.lbConvertCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConvertCurrency.Location = new System.Drawing.Point(48, 22);
            this.lbConvertCurrency.Name = "lbConvertCurrency";
            this.lbConvertCurrency.Size = new System.Drawing.Size(132, 18);
            this.lbConvertCurrency.TabIndex = 0;
            this.lbConvertCurrency.Text = "Convert Currency :";
            // 
            // lbConvertFrom
            // 
            this.lbConvertFrom.AutoSize = true;
            this.lbConvertFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConvertFrom.Location = new System.Drawing.Point(48, 64);
            this.lbConvertFrom.Name = "lbConvertFrom";
            this.lbConvertFrom.Size = new System.Drawing.Size(44, 18);
            this.lbConvertFrom.TabIndex = 1;
            this.lbConvertFrom.Text = "From";
            // 
            // lbConvertTo
            // 
            this.lbConvertTo.AutoSize = true;
            this.lbConvertTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConvertTo.Location = new System.Drawing.Point(48, 102);
            this.lbConvertTo.Name = "lbConvertTo";
            this.lbConvertTo.Size = new System.Drawing.Size(26, 18);
            this.lbConvertTo.TabIndex = 2;
            this.lbConvertTo.Text = "To";
            // 
            // cmboxFrom
            // 
            this.cmboxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxFrom.Items.AddRange(new object[] {
            "POUND",
            "RUPPEE",
            "USD"});
            this.cmboxFrom.Location = new System.Drawing.Point(211, 62);
            this.cmboxFrom.Name = "cmboxFrom";
            this.cmboxFrom.Size = new System.Drawing.Size(121, 21);
            this.cmboxFrom.TabIndex = 3;
            // 
            // cmboxTo
            // 
            this.cmboxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTo.FormattingEnabled = true;
            this.cmboxTo.Items.AddRange(new object[] {
            "USD",
            "RUPPEE",
            "POUND"});
            this.cmboxTo.Location = new System.Drawing.Point(211, 102);
            this.cmboxTo.Name = "cmboxTo";
            this.cmboxTo.Size = new System.Drawing.Size(121, 21);
            this.cmboxTo.TabIndex = 4;
            // 
            // txtboxCurrencyAmount
            // 
            this.txtboxCurrencyAmount.Location = new System.Drawing.Point(211, 20);
            this.txtboxCurrencyAmount.Name = "txtboxCurrencyAmount";
            this.txtboxCurrencyAmount.Size = new System.Drawing.Size(121, 20);
            this.txtboxCurrencyAmount.TabIndex = 5;
            this.txtboxCurrencyAmount.TextChanged += new System.EventHandler(this.txtboxCurrencyAmount_TextChanged);
            this.txtboxCurrencyAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCurrencyAmount_KeyPress);
            // 
            // btConvert
            // 
            this.btConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConvert.Location = new System.Drawing.Point(211, 144);
            this.btConvert.Name = "btConvert";
            this.btConvert.Size = new System.Drawing.Size(100, 26);
            this.btConvert.TabIndex = 6;
            this.btConvert.Text = "CONVERT";
            this.btConvert.UseVisualStyleBackColor = true;
            this.btConvert.Click += new System.EventHandler(this.btConvert_Click);
            // 
            // txtboxResult
            // 
            this.txtboxResult.Location = new System.Drawing.Point(211, 196);
            this.txtboxResult.Name = "txtboxResult";
            this.txtboxResult.Size = new System.Drawing.Size(202, 20);
            this.txtboxResult.TabIndex = 7;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(48, 195);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(50, 18);
            this.lbResult.TabIndex = 8;
            this.lbResult.Text = "Result";
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtboxResult);
            this.Controls.Add(this.btConvert);
            this.Controls.Add(this.txtboxCurrencyAmount);
            this.Controls.Add(this.cmboxTo);
            this.Controls.Add(this.cmboxFrom);
            this.Controls.Add(this.lbConvertTo);
            this.Controls.Add(this.lbConvertFrom);
            this.Controls.Add(this.lbConvertCurrency);
            this.Name = "CurrencyConverter";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label lbConvertCurrency;
        private System.Windows.Forms.Label lbConvertFrom;
        private System.Windows.Forms.Label lbConvertTo;
        private System.Windows.Forms.ComboBox cmboxFrom;
        private System.Windows.Forms.ComboBox cmboxTo;
        private System.Windows.Forms.TextBox txtboxCurrencyAmount;
        private System.Windows.Forms.Button btConvert;
        private System.Windows.Forms.TextBox txtboxResult;
        private System.Windows.Forms.Label lbResult;
    }
}

