namespace ce205_hw3_form_app
{
    partial class Main
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
            this.RB = new System.Windows.Forms.Button();
            this.AVL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RB
            // 
            this.RB.BackColor = System.Drawing.Color.LightCoral;
            this.RB.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB.Location = new System.Drawing.Point(116, 204);
            this.RB.Margin = new System.Windows.Forms.Padding(4);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(152, 50);
            this.RB.TabIndex = 11;
            this.RB.Text = "Red-Black";
            this.RB.UseVisualStyleBackColor = false;
            this.RB.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AVL
            // 
            this.AVL.BackColor = System.Drawing.Color.LightCoral;
            this.AVL.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVL.Location = new System.Drawing.Point(116, 90);
            this.AVL.Margin = new System.Windows.Forms.Padding(4);
            this.AVL.Name = "AVL";
            this.AVL.Size = new System.Drawing.Size(152, 50);
            this.AVL.TabIndex = 10;
            this.AVL.Text = "AVL";
            this.AVL.UseVisualStyleBackColor = false;
            this.AVL.Click += new System.EventHandler(this.AVL_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(401, 385);
            this.Controls.Add(this.RB);
            this.Controls.Add(this.AVL);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RB;
        private System.Windows.Forms.Button AVL;
    }
}