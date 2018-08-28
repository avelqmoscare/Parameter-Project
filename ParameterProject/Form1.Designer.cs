namespace ParameterProject
{
    partial class frmParameter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.txtSecondValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnValueParameter = new System.Windows.Forms.RadioButton();
            this.rbnRefParameter = new System.Windows.Forms.RadioButton();
            this.rbnOutParameter = new System.Windows.Forms.RadioButton();
            this.btnSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Value:";
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Location = new System.Drawing.Point(93, 36);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(100, 20);
            this.txtFirstValue.TabIndex = 2;
            // 
            // txtSecondValue
            // 
            this.txtSecondValue.Location = new System.Drawing.Point(93, 70);
            this.txtSecondValue.Name = "txtSecondValue";
            this.txtSecondValue.Size = new System.Drawing.Size(100, 20);
            this.txtSecondValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type of Parameter:";
            // 
            // rbnValueParameter
            // 
            this.rbnValueParameter.AutoSize = true;
            this.rbnValueParameter.Location = new System.Drawing.Point(93, 151);
            this.rbnValueParameter.Name = "rbnValueParameter";
            this.rbnValueParameter.Size = new System.Drawing.Size(103, 17);
            this.rbnValueParameter.TabIndex = 5;
            this.rbnValueParameter.TabStop = true;
            this.rbnValueParameter.Text = "Value Parameter";
            this.rbnValueParameter.UseVisualStyleBackColor = true;
            // 
            // rbnRefParameter
            // 
            this.rbnRefParameter.AutoSize = true;
            this.rbnRefParameter.Location = new System.Drawing.Point(93, 174);
            this.rbnRefParameter.Name = "rbnRefParameter";
            this.rbnRefParameter.Size = new System.Drawing.Size(126, 17);
            this.rbnRefParameter.TabIndex = 6;
            this.rbnRefParameter.TabStop = true;
            this.rbnRefParameter.Text = "Reference Parameter";
            this.rbnRefParameter.UseVisualStyleBackColor = true;
            // 
            // rbnOutParameter
            // 
            this.rbnOutParameter.AutoSize = true;
            this.rbnOutParameter.Location = new System.Drawing.Point(93, 197);
            this.rbnOutParameter.Name = "rbnOutParameter";
            this.rbnOutParameter.Size = new System.Drawing.Size(108, 17);
            this.rbnOutParameter.TabIndex = 7;
            this.rbnOutParameter.TabStop = true;
            this.rbnOutParameter.Text = "Output Parameter";
            this.rbnOutParameter.UseVisualStyleBackColor = true;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(93, 237);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 8;
            this.btnSwap.Text = "Swap Now";
            this.btnSwap.UseVisualStyleBackColor = true;
            // 
            // frmParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 262);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.rbnOutParameter);
            this.Controls.Add(this.rbnRefParameter);
            this.Controls.Add(this.rbnValueParameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecondValue);
            this.Controls.Add(this.txtFirstValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParameter";
            this.Text = "Parameter Project";
            //this.Load += new System.EventHandler(this.frmParameter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.TextBox txtSecondValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbnValueParameter;
        private System.Windows.Forms.RadioButton rbnRefParameter;
        private System.Windows.Forms.RadioButton rbnOutParameter;
        private System.Windows.Forms.Button btnSwap;
    }
}

