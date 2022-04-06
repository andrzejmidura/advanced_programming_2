
namespace CarRental
{
    partial class MainForm
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
            this.configureCarButton = new System.Windows.Forms.Button();
            this.orderCarButton = new System.Windows.Forms.Button();
            this.reservationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // configureCarButton
            // 
            this.configureCarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.configureCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.configureCarButton.Location = new System.Drawing.Point(212, 104);
            this.configureCarButton.Name = "configureCarButton";
            this.configureCarButton.Size = new System.Drawing.Size(374, 46);
            this.configureCarButton.TabIndex = 0;
            this.configureCarButton.Text = "Configure your car";
            this.configureCarButton.UseVisualStyleBackColor = true;
            this.configureCarButton.Click += new System.EventHandler(this.configureCarButton_Click);
            // 
            // orderCarButton
            // 
            this.orderCarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderCarButton.Location = new System.Drawing.Point(212, 197);
            this.orderCarButton.Name = "orderCarButton";
            this.orderCarButton.Size = new System.Drawing.Size(374, 46);
            this.orderCarButton.TabIndex = 1;
            this.orderCarButton.Text = "Order the car";
            this.orderCarButton.UseVisualStyleBackColor = true;
            this.orderCarButton.Click += new System.EventHandler(this.orderCarButton_Click);
            // 
            // reservationButton
            // 
            this.reservationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservationButton.Location = new System.Drawing.Point(212, 293);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(374, 46);
            this.reservationButton.TabIndex = 2;
            this.reservationButton.Text = "Make reservation for test drive";
            this.reservationButton.UseVisualStyleBackColor = true;
            this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reservationButton);
            this.Controls.Add(this.orderCarButton);
            this.Controls.Add(this.configureCarButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button configureCarButton;
        private System.Windows.Forms.Button orderCarButton;
        private System.Windows.Forms.Button reservationButton;
    }
}