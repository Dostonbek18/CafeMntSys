namespace CafeMgmtTuto
{
    partial class ItemForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zeroitLollipopMaskedTextBox1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopMaskedTextBox();
            this.zeroitLollipopMaskedTextBox2 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopMaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.zeroitLollipopMaskedTextBox2);
            this.panel1.Controls.Add(this.zeroitLollipopMaskedTextBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(155, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 505);
            this.panel1.TabIndex = 0;
            // 
            // ItemsGV
            // 
            this.ItemsGV.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.Location = new System.Drawing.Point(221, 79);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowTemplate.Height = 25;
            this.ItemsGV.Size = new System.Drawing.Size(483, 150);
            this.ItemsGV.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.comboBox1.Location = new System.Drawing.Point(45, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 31);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(358, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Place Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "LogOut";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(915, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // zeroitLollipopMaskedTextBox1
            // 
            this.zeroitLollipopMaskedTextBox1.AllowPromptAsInput = true;
            this.zeroitLollipopMaskedTextBox1.AsciiOnly = false;
            this.zeroitLollipopMaskedTextBox1.BeepOnError = false;
            this.zeroitLollipopMaskedTextBox1.Culture = new System.Globalization.CultureInfo("en-US");
            this.zeroitLollipopMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.zeroitLollipopMaskedTextBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.zeroitLollipopMaskedTextBox1.ForeColor = System.Drawing.Color.Black;
            this.zeroitLollipopMaskedTextBox1.HidePromptOnLeave = false;
            this.zeroitLollipopMaskedTextBox1.HideSelection = true;
            this.zeroitLollipopMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.zeroitLollipopMaskedTextBox1.IsEnabled = true;
            this.zeroitLollipopMaskedTextBox1.Location = new System.Drawing.Point(45, 120);
            this.zeroitLollipopMaskedTextBox1.Mask = "";
            this.zeroitLollipopMaskedTextBox1.MaxLength = 32767;
            this.zeroitLollipopMaskedTextBox1.Multiline = false;
            this.zeroitLollipopMaskedTextBox1.Name = "zeroitLollipopMaskedTextBox1";
            this.zeroitLollipopMaskedTextBox1.PasswordChar = '\0';
            this.zeroitLollipopMaskedTextBox1.PromptChar = '_';
            this.zeroitLollipopMaskedTextBox1.ReadOnly = false;
            this.zeroitLollipopMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.zeroitLollipopMaskedTextBox1.ResetOnPrompt = true;
            this.zeroitLollipopMaskedTextBox1.ResetOnSpace = true;
            this.zeroitLollipopMaskedTextBox1.ShortCutsEnabled = true;
            this.zeroitLollipopMaskedTextBox1.Size = new System.Drawing.Size(139, 24);
            this.zeroitLollipopMaskedTextBox1.SkipLiterals = true;
            this.zeroitLollipopMaskedTextBox1.TabIndex = 8;
            this.zeroitLollipopMaskedTextBox1.Text = "OrderNum";
            this.zeroitLollipopMaskedTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.zeroitLollipopMaskedTextBox1.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.zeroitLollipopMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.zeroitLollipopMaskedTextBox1.UseSystemPasswordChar = false;
            // 
            // zeroitLollipopMaskedTextBox2
            // 
            this.zeroitLollipopMaskedTextBox2.AllowPromptAsInput = true;
            this.zeroitLollipopMaskedTextBox2.AsciiOnly = false;
            this.zeroitLollipopMaskedTextBox2.BeepOnError = false;
            this.zeroitLollipopMaskedTextBox2.Culture = new System.Globalization.CultureInfo("en-US");
            this.zeroitLollipopMaskedTextBox2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.zeroitLollipopMaskedTextBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.zeroitLollipopMaskedTextBox2.ForeColor = System.Drawing.Color.Black;
            this.zeroitLollipopMaskedTextBox2.HidePromptOnLeave = false;
            this.zeroitLollipopMaskedTextBox2.HideSelection = true;
            this.zeroitLollipopMaskedTextBox2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.zeroitLollipopMaskedTextBox2.IsEnabled = true;
            this.zeroitLollipopMaskedTextBox2.Location = new System.Drawing.Point(45, 152);
            this.zeroitLollipopMaskedTextBox2.Mask = "";
            this.zeroitLollipopMaskedTextBox2.MaxLength = 32767;
            this.zeroitLollipopMaskedTextBox2.Multiline = false;
            this.zeroitLollipopMaskedTextBox2.Name = "zeroitLollipopMaskedTextBox2";
            this.zeroitLollipopMaskedTextBox2.PasswordChar = '\0';
            this.zeroitLollipopMaskedTextBox2.PromptChar = '_';
            this.zeroitLollipopMaskedTextBox2.ReadOnly = false;
            this.zeroitLollipopMaskedTextBox2.RejectInputOnFirstFailure = false;
            this.zeroitLollipopMaskedTextBox2.ResetOnPrompt = true;
            this.zeroitLollipopMaskedTextBox2.ResetOnSpace = true;
            this.zeroitLollipopMaskedTextBox2.ShortCutsEnabled = true;
            this.zeroitLollipopMaskedTextBox2.Size = new System.Drawing.Size(139, 24);
            this.zeroitLollipopMaskedTextBox2.SkipLiterals = true;
            this.zeroitLollipopMaskedTextBox2.TabIndex = 8;
            this.zeroitLollipopMaskedTextBox2.Text = "SellerName";
            this.zeroitLollipopMaskedTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.zeroitLollipopMaskedTextBox2.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.zeroitLollipopMaskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.zeroitLollipopMaskedTextBox2.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(581, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "OrderAmount";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(60, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(950, 544);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label6;
        private DataGridView ItemsGV;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopMaskedTextBox zeroitLollipopMaskedTextBox2;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopMaskedTextBox zeroitLollipopMaskedTextBox1;
        private Label label2;
    }
}