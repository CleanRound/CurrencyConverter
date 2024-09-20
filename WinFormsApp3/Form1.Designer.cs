namespace CurrencyConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(130, 30);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 0;
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);

            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "UAH"});
            this.comboBoxFrom.Location = new System.Drawing.Point(130, 70);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFrom.TabIndex = 1;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);

            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "UAH"});
            this.comboBoxTo.Location = new System.Drawing.Point(130, 110);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTo.TabIndex = 2;
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);

            // 
            // buttonConvert
            // 
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Location = new System.Drawing.Point(130, 150);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);

            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(50, 33);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount";

            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(50, 73);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 13);
            this.labelFrom.TabIndex = 5;
            this.labelFrom.Text = "From";

            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(50, 113);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "To";

            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(130, 190);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 7;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.textBoxAmount);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}
