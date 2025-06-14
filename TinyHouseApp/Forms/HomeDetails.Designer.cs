﻿namespace TinyHouseApp.Forms
{
    partial class HomeDetails
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDetails));
            dgwReservations = new DataGridView();
            reservationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            houseIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            renterIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationBindingSource = new BindingSource(components);
            dgwComments = new DataGridView();
            commentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            renterIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentTextDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            btnAccept = new Button();
            btnDecline = new Button();
            btnComments = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgwReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwComments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgwReservations
            // 
            dgwReservations.AutoGenerateColumns = false;
            dgwReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwReservations.Columns.AddRange(new DataGridViewColumn[] { reservationIDDataGridViewTextBoxColumn, houseIDDataGridViewTextBoxColumn, renterIDDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, paymentStatusDataGridViewTextBoxColumn });
            dgwReservations.DataSource = reservationBindingSource;
            dgwReservations.Location = new Point(10, 34);
            dgwReservations.Margin = new Padding(2, 2, 2, 2);
            dgwReservations.Name = "dgwReservations";
            dgwReservations.RowHeadersWidth = 62;
            dgwReservations.Size = new Size(892, 289);
            dgwReservations.TabIndex = 0;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            reservationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            reservationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // houseIDDataGridViewTextBoxColumn
            // 
            houseIDDataGridViewTextBoxColumn.DataPropertyName = "HouseID";
            houseIDDataGridViewTextBoxColumn.HeaderText = "HouseID";
            houseIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            houseIDDataGridViewTextBoxColumn.Name = "houseIDDataGridViewTextBoxColumn";
            houseIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // renterIDDataGridViewTextBoxColumn
            // 
            renterIDDataGridViewTextBoxColumn.DataPropertyName = "RenterID";
            renterIDDataGridViewTextBoxColumn.HeaderText = "RenterID";
            renterIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            renterIDDataGridViewTextBoxColumn.Name = "renterIDDataGridViewTextBoxColumn";
            renterIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            paymentStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(Models.Reservation);
            // 
            // dgwComments
            // 
            dgwComments.AutoGenerateColumns = false;
            dgwComments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwComments.Columns.AddRange(new DataGridViewColumn[] { commentIDDataGridViewTextBoxColumn, reservationIDDataGridViewTextBoxColumn1, renterIDDataGridViewTextBoxColumn1, ratingDataGridViewTextBoxColumn, commentTextDataGridViewTextBoxColumn, commentDateDataGridViewTextBoxColumn });
            dgwComments.DataSource = commentBindingSource;
            dgwComments.Location = new Point(10, 363);
            dgwComments.Margin = new Padding(2, 2, 2, 2);
            dgwComments.Name = "dgwComments";
            dgwComments.RowHeadersWidth = 62;
            dgwComments.Size = new Size(772, 242);
            dgwComments.TabIndex = 1;
            // 
            // commentIDDataGridViewTextBoxColumn
            // 
            commentIDDataGridViewTextBoxColumn.DataPropertyName = "CommentID";
            commentIDDataGridViewTextBoxColumn.HeaderText = "CommentID";
            commentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            commentIDDataGridViewTextBoxColumn.Name = "commentIDDataGridViewTextBoxColumn";
            commentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // reservationIDDataGridViewTextBoxColumn1
            // 
            reservationIDDataGridViewTextBoxColumn1.DataPropertyName = "ReservationID";
            reservationIDDataGridViewTextBoxColumn1.HeaderText = "ReservationID";
            reservationIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            reservationIDDataGridViewTextBoxColumn1.Name = "reservationIDDataGridViewTextBoxColumn1";
            reservationIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // renterIDDataGridViewTextBoxColumn1
            // 
            renterIDDataGridViewTextBoxColumn1.DataPropertyName = "RenterID";
            renterIDDataGridViewTextBoxColumn1.HeaderText = "RenterID";
            renterIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            renterIDDataGridViewTextBoxColumn1.Name = "renterIDDataGridViewTextBoxColumn1";
            renterIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn.MinimumWidth = 8;
            ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            ratingDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentTextDataGridViewTextBoxColumn
            // 
            commentTextDataGridViewTextBoxColumn.DataPropertyName = "CommentText";
            commentTextDataGridViewTextBoxColumn.HeaderText = "CommentText";
            commentTextDataGridViewTextBoxColumn.MinimumWidth = 8;
            commentTextDataGridViewTextBoxColumn.Name = "commentTextDataGridViewTextBoxColumn";
            commentTextDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentDateDataGridViewTextBoxColumn
            // 
            commentDateDataGridViewTextBoxColumn.DataPropertyName = "CommentDate";
            commentDateDataGridViewTextBoxColumn.HeaderText = "CommentDate";
            commentDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            commentDateDataGridViewTextBoxColumn.Name = "commentDateDataGridViewTextBoxColumn";
            commentDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentBindingSource
            // 
            commentBindingSource.DataSource = typeof(Models.Comment);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(288, -7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(358, 41);
            label1.TabIndex = 2;
            label1.Text = "REZARVASYON LİSTESİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(362, 325);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 37);
            label2.TabIndex = 3;
            label2.Text = "Yorumlar";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.LimeGreen;
            btnAccept.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAccept.ForeColor = SystemColors.ActiveCaptionText;
            btnAccept.Location = new Point(942, 52);
            btnAccept.Margin = new Padding(2, 2, 2, 2);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(100, 42);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Onayla";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnDecline
            // 
            btnDecline.BackColor = Color.DarkRed;
            btnDecline.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDecline.ForeColor = SystemColors.ActiveCaptionText;
            btnDecline.Location = new Point(942, 99);
            btnDecline.Margin = new Padding(2, 2, 2, 2);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(100, 38);
            btnDecline.TabIndex = 5;
            btnDecline.Text = "Reddet";
            btnDecline.UseVisualStyleBackColor = false;
            btnDecline.Click += btnDecline_Click;
            // 
            // btnComments
            // 
            btnComments.BackColor = SystemColors.Highlight;
            btnComments.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnComments.Location = new Point(942, 142);
            btnComments.Margin = new Padding(2, 2, 2, 2);
            btnComments.Name = "btnComments";
            btnComments.Size = new Size(100, 38);
            btnComments.TabIndex = 6;
            btnComments.Text = "Yorumlar";
            btnComments.UseVisualStyleBackColor = false;
            btnComments.Click += btnComments_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, -77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1274, 748);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-11, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 632);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // HomeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 620);
            Controls.Add(btnComments);
            Controls.Add(btnDecline);
            Controls.Add(btnAccept);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgwComments);
            Controls.Add(dgwReservations);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HomeDetails";
            Text = "HomeDetails";
            ((System.ComponentModel.ISupportInitialize)dgwReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwComments).EndInit();
            ((System.ComponentModel.ISupportInitialize)commentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwReservations;
        private DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn houseIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn renterIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private BindingSource reservationBindingSource;
        private DataGridView dgwComments;
        private DataGridViewTextBoxColumn commentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn renterIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentTextDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDateDataGridViewTextBoxColumn;
        private BindingSource commentBindingSource;
        private Label label1;
        private Label label2;
        private Button btnAccept;
        private Button btnDecline;
        private Button btnComments;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}