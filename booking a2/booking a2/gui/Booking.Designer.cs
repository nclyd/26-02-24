
namespace booking_a2.gui
{
    partial class Booking
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
            this.txtbForename = new System.Windows.Forms.TextBox();
            this.txtbSurname = new System.Windows.Forms.TextBox();
            this.txtbTelNo = new System.Windows.Forms.TextBox();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.calEnd = new System.Windows.Forms.MonthCalendar();
            this.calStart = new System.Windows.Forms.MonthCalendar();
            this.dgvAvaillablePods = new System.Windows.Forms.DataGridView();
            this.dgvBookingPods = new System.Windows.Forms.DataGridView();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaillablePods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingPods)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbForename
            // 
            this.txtbForename.Location = new System.Drawing.Point(624, 160);
            this.txtbForename.Name = "txtbForename";
            this.txtbForename.Size = new System.Drawing.Size(100, 20);
            this.txtbForename.TabIndex = 0;
            // 
            // txtbSurname
            // 
            this.txtbSurname.Location = new System.Drawing.Point(624, 225);
            this.txtbSurname.Name = "txtbSurname";
            this.txtbSurname.Size = new System.Drawing.Size(100, 20);
            this.txtbSurname.TabIndex = 1;
            // 
            // txtbTelNo
            // 
            this.txtbTelNo.Location = new System.Drawing.Point(624, 290);
            this.txtbTelNo.Name = "txtbTelNo";
            this.txtbTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtbTelNo.TabIndex = 2;
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(624, 356);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(100, 20);
            this.txtbAddress.TabIndex = 3;
            // 
            // calEnd
            // 
            this.calEnd.Location = new System.Drawing.Point(286, 41);
            this.calEnd.Name = "calEnd";
            this.calEnd.TabIndex = 15;
            // 
            // calStart
            // 
            this.calStart.Location = new System.Drawing.Point(18, 41);
            this.calStart.Name = "calStart";
            this.calStart.ShowToday = false;
            this.calStart.TabIndex = 14;
            // 
            // dgvAvaillablePods
            // 
            this.dgvAvaillablePods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvaillablePods.Location = new System.Drawing.Point(18, 225);
            this.dgvAvaillablePods.Name = "dgvAvaillablePods";
            this.dgvAvaillablePods.Size = new System.Drawing.Size(495, 195);
            this.dgvAvaillablePods.TabIndex = 16;
            // 
            // dgvBookingPods
            // 
            this.dgvBookingPods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingPods.Location = new System.Drawing.Point(295, 430);
            this.dgvBookingPods.Name = "dgvBookingPods";
            this.dgvBookingPods.Size = new System.Drawing.Size(190, 150);
            this.dgvBookingPods.TabIndex = 17;
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(677, 541);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmBooking.TabIndex = 18;
            this.btnConfirmBooking.Text = "Confirm";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(568, 541);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(75, 23);
            this.btnCancelBooking.TabIndex = 19;
            this.btnCancelBooking.Text = "Cancel";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(550, 163);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 20;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(550, 232);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Text = "Surname:";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(550, 297);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(39, 13);
            this.lblTelNo.TabIndex = 22;
            this.lblTelNo.Text = "TelNo:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(550, 356);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Address:";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.dgvBookingPods);
            this.Controls.Add(this.dgvAvaillablePods);
            this.Controls.Add(this.calEnd);
            this.Controls.Add(this.calStart);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.txtbTelNo);
            this.Controls.Add(this.txtbSurname);
            this.Controls.Add(this.txtbForename);
            this.Name = "Booking";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaillablePods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingPods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbForename;
        private System.Windows.Forms.TextBox txtbSurname;
        private System.Windows.Forms.TextBox txtbTelNo;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.MonthCalendar calEnd;
        private System.Windows.Forms.MonthCalendar calStart;
        private System.Windows.Forms.DataGridView dgvAvaillablePods;
        private System.Windows.Forms.DataGridView dgvBookingPods;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblAddress;
    }
}