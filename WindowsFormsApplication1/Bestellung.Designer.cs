namespace WindowsFormsApplication1
{
    partial class Bestellung
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(769, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 133);
            this.button1.TabIndex = 2;
            this.button1.Text = "add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(769, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 133);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_click);
            // 
            // Order
            // 
            this.Order.CheckOnClick = true;
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Order.FormattingEnabled = true;
            this.Order.Items.AddRange(new object[] {
            "Hamburger\t   \t\t\t\t\t6€",
            "Hamburger\t   \t\t\t\t\t6€",
            "Hamburger\t   \t\t\t\t\t6€"});
            this.Order.Location = new System.Drawing.Point(12, 16);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(750, 400);
            this.Order.TabIndex = 4;
            this.Order.Tag = "puste";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(769, 378);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(133, 38);
            this.textBox1.TabIndex = 5;
            // 
            // Bestellung
            // 
            this.ClientSize = new System.Drawing.Size(914, 456);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Bestellung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Button button1;
        private global::System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox Order;
    }
}

