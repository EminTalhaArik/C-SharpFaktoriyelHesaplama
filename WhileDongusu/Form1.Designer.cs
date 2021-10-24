
namespace WhileDongusu
{
    partial class Form1
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
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.tbx_enteredNumber = new System.Windows.Forms.TextBox();
            this.lbl_enteredNumber = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_factText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(82, 57);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(140, 45);
            this.btn_hesapla.TabIndex = 0;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // tbx_enteredNumber
            // 
            this.tbx_enteredNumber.Location = new System.Drawing.Point(63, 14);
            this.tbx_enteredNumber.Name = "tbx_enteredNumber";
            this.tbx_enteredNumber.Size = new System.Drawing.Size(160, 22);
            this.tbx_enteredNumber.TabIndex = 1;
            // 
            // lbl_enteredNumber
            // 
            this.lbl_enteredNumber.AutoSize = true;
            this.lbl_enteredNumber.Location = new System.Drawing.Point(13, 14);
            this.lbl_enteredNumber.Name = "lbl_enteredNumber";
            this.lbl_enteredNumber.Size = new System.Drawing.Size(47, 17);
            this.lbl_enteredNumber.TabIndex = 2;
            this.lbl_enteredNumber.Text = "Sayı : ";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(20, 166);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 17);
            this.lbl_result.TabIndex = 5;
            // 
            // lbl_factText
            // 
            this.lbl_factText.AutoSize = true;
            this.lbl_factText.Location = new System.Drawing.Point(20, 127);
            this.lbl_factText.Name = "lbl_factText";
            this.lbl_factText.Size = new System.Drawing.Size(0, 17);
            this.lbl_factText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 208);
            this.Controls.Add(this.lbl_factText);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_enteredNumber);
            this.Controls.Add(this.tbx_enteredNumber);
            this.Controls.Add(this.btn_hesapla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Faktöriyel Hesapla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox tbx_enteredNumber;
        private System.Windows.Forms.Label lbl_enteredNumber;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_factText;
    }
}

