namespace SudskiRegistar
{
    partial class SudskiRegistarForm
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
            this.txtOib = new System.Windows.Forms.TextBox();
            this.lblOib = new System.Windows.Forms.Label();
            this.btnOib = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.rtbDetalji = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(93, 12);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(409, 22);
            this.txtOib.TabIndex = 0;
            // 
            // lblOib
            // 
            this.lblOib.AutoSize = true;
            this.lblOib.Location = new System.Drawing.Point(10, 15);
            this.lblOib.Name = "lblOib";
            this.lblOib.Size = new System.Drawing.Size(77, 16);
            this.lblOib.TabIndex = 1;
            this.lblOib.Text = "Upišite OIB:";
            // 
            // btnOib
            // 
            this.btnOib.Location = new System.Drawing.Point(508, 12);
            this.btnOib.Name = "btnOib";
            this.btnOib.Size = new System.Drawing.Size(75, 23);
            this.btnOib.TabIndex = 2;
            this.btnOib.Text = "Pretraži";
            this.btnOib.UseVisualStyleBackColor = true;
            this.btnOib.Click += new System.EventHandler(this.btnOib_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.ForeColor = System.Drawing.Color.Red;
            this.lblResponse.Location = new System.Drawing.Point(589, 15);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(70, 16);
            this.lblResponse.TabIndex = 3;
            this.lblResponse.Text = "Response";
            // 
            // rtbDetalji
            // 
            this.rtbDetalji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDetalji.Location = new System.Drawing.Point(13, 52);
            this.rtbDetalji.Name = "rtbDetalji";
            this.rtbDetalji.ReadOnly = true;
            this.rtbDetalji.Size = new System.Drawing.Size(775, 716);
            this.rtbDetalji.TabIndex = 4;
            this.rtbDetalji.Text = "Dobrodošli!";
            // 
            // SudskiRegistarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 780);
            this.Controls.Add(this.rtbDetalji);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnOib);
            this.Controls.Add(this.lblOib);
            this.Controls.Add(this.txtOib);
            this.Name = "SudskiRegistarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.Label lblOib;
        private System.Windows.Forms.Button btnOib;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.RichTextBox rtbDetalji;
    }
}

