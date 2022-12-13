namespace ce205_hw3_form_app
{
    partial class AVL
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InOrder = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Linen;
            this.pictureBox1.Location = new System.Drawing.Point(159, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1098, 581);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // InOrder
            // 
            this.InOrder.BackColor = System.Drawing.Color.LightCoral;
            this.InOrder.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InOrder.Location = new System.Drawing.Point(30, 391);
            this.InOrder.Margin = new System.Windows.Forms.Padding(4);
            this.InOrder.Name = "InOrder";
            this.InOrder.Size = new System.Drawing.Size(100, 30);
            this.InOrder.TabIndex = 10;
            this.InOrder.Text = "InOrder";
            this.InOrder.UseVisualStyleBackColor = false;
            this.InOrder.Click += new System.EventHandler(this.InOrder_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.LightCoral;
            this.Find.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.Location = new System.Drawing.Point(30, 308);
            this.Find.Margin = new System.Windows.Forms.Padding(4);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(100, 30);
            this.Find.TabIndex = 9;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.deleteBtn.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(30, 230);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 30);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.LightCoral;
            this.InsertBtn.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(30, 153);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(100, 30);
            this.InsertBtn.TabIndex = 7;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // valueBox
            // 
            this.valueBox.BackColor = System.Drawing.Color.Linen;
            this.valueBox.Location = new System.Drawing.Point(30, 80);
            this.valueBox.Margin = new System.Windows.Forms.Padding(4);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(100, 22);
            this.valueBox.TabIndex = 6;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(759, 625);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(85, 29);
            this.Status.TabIndex = 12;
            this.Status.Text = "Status";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1275, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InOrder);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.valueBox);
            this.Name = "AVL";
            this.Text = "AVL";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button InOrder;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox valueBox;
        public System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button button1;
    }
}

