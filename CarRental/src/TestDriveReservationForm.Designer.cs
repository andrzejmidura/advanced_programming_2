
namespace CarRental
{
    partial class TestDriveReservationForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.returnButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.reservationsDataGrid = new System.Windows.Forms.DataGridView();
            this.orderedCarsGridView = new System.Windows.Forms.DataGridView();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.orderedCarsLabel = new System.Windows.Forms.Label();
            this.reservationsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedCarsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar1.Location = new System.Drawing.Point(81, 88);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnButton.Location = new System.Drawing.Point(208, 568);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(180, 40);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return to menu";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bookButton.Location = new System.Drawing.Point(394, 568);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(180, 40);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(580, 568);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(180, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel reservation";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // reservationsDataGrid
            // 
            this.reservationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsDataGrid.Location = new System.Drawing.Point(336, 345);
            this.reservationsDataGrid.Name = "reservationsDataGrid";
            this.reservationsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationsDataGrid.Size = new System.Drawing.Size(558, 166);
            this.reservationsDataGrid.TabIndex = 4;
            // 
            // orderedCarsGridView
            // 
            this.orderedCarsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderedCarsGridView.Location = new System.Drawing.Point(336, 88);
            this.orderedCarsGridView.Name = "orderedCarsGridView";
            this.orderedCarsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderedCarsGridView.Size = new System.Drawing.Size(558, 162);
            this.orderedCarsGridView.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Enabled = false;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneTextBox.Location = new System.Drawing.Point(137, 479);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(171, 23);
            this.phoneTextBox.TabIndex = 20;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressTextBox.Location = new System.Drawing.Point(137, 438);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(171, 23);
            this.addressTextBox.TabIndex = 19;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Enabled = false;
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameTextBox.Location = new System.Drawing.Point(137, 394);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(171, 23);
            this.surnameTextBox.TabIndex = 18;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(137, 353);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 23);
            this.nameTextBox.TabIndex = 17;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneLabel.Location = new System.Drawing.Point(78, 479);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(53, 17);
            this.phoneLabel.TabIndex = 16;
            this.phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressLabel.Location = new System.Drawing.Point(65, 438);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 15;
            this.addressLabel.Text = "Address:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameLabel.Location = new System.Drawing.Point(59, 396);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(69, 17);
            this.surnameLabel.TabIndex = 14;
            this.surnameLabel.Text = "Surname:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(82, 355);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name:";
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calendarLabel.Location = new System.Drawing.Point(134, 60);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(117, 20);
            this.calendarLabel.TabIndex = 21;
            this.calendarLabel.Text = "Choose a date:";
            // 
            // orderedCarsLabel
            // 
            this.orderedCarsLabel.AutoSize = true;
            this.orderedCarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderedCarsLabel.Location = new System.Drawing.Point(525, 60);
            this.orderedCarsLabel.Name = "orderedCarsLabel";
            this.orderedCarsLabel.Size = new System.Drawing.Size(154, 20);
            this.orderedCarsLabel.TabIndex = 22;
            this.orderedCarsLabel.Text = "Cars ordered by you:";
            // 
            // reservationsLabel
            // 
            this.reservationsLabel.AutoSize = true;
            this.reservationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservationsLabel.Location = new System.Drawing.Point(503, 319);
            this.reservationsLabel.Name = "reservationsLabel";
            this.reservationsLabel.Size = new System.Drawing.Size(195, 20);
            this.reservationsLabel.TabIndex = 23;
            this.reservationsLabel.Text = "Test drives booked by you:";
            // 
            // TestDriveReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 645);
            this.Controls.Add(this.reservationsLabel);
            this.Controls.Add(this.orderedCarsLabel);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.orderedCarsGridView);
            this.Controls.Add(this.reservationsDataGrid);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "TestDriveReservationForm";
            this.Text = "TestDriveReservation";
            this.Load += new System.EventHandler(this.TestDriveReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedCarsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView reservationsDataGrid;
        private System.Windows.Forms.DataGridView orderedCarsGridView;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.Label orderedCarsLabel;
        private System.Windows.Forms.Label reservationsLabel;
    }
}