
namespace WaiteringSystem.Presentation
{
    partial class EmployeeListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListingForm));
            this.listLabel = new System.Windows.Forms.Label();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.empIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.shiftsTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.shiftsLabel = new System.Windows.Forms.Label();
            this.empIdlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(22, 9);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(179, 17);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "Listing of all employees";
            this.listLabel.Click += new System.EventHandler(this.listLabel_Click);
            // 
            // employeeListView
            // 
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(41, 38);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(742, 254);
            this.employeeListView.TabIndex = 1;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(231, 300);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(64, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.Location = new System.Drawing.Point(451, 299);
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.Size = new System.Drawing.Size(84, 20);
            this.empIdTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(231, 339);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(304, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(231, 378);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(124, 20);
            this.phoneTextBox.TabIndex = 5;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Location = new System.Drawing.Point(231, 410);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(124, 20);
            this.paymentTextBox.TabIndex = 6;
            // 
            // shiftsTextBox
            // 
            this.shiftsTextBox.Location = new System.Drawing.Point(231, 450);
            this.shiftsTextBox.Name = "shiftsTextBox";
            this.shiftsTextBox.Size = new System.Drawing.Size(124, 20);
            this.shiftsTextBox.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(567, 448);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(698, 448);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(684, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 41);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(589, 298);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(53, 41);
            this.editButton.TabIndex = 11;
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.idLabel.Location = new System.Drawing.Point(87, 301);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 13;
            this.idLabel.Text = "ID";
            this.idLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(87, 342);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 15);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.Location = new System.Drawing.Point(87, 379);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(48, 15);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Phone";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.paymentLabel.Location = new System.Drawing.Point(87, 415);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(62, 15);
            this.paymentLabel.TabIndex = 16;
            this.paymentLabel.Text = "Payment";
            // 
            // shiftsLabel
            // 
            this.shiftsLabel.AutoSize = true;
            this.shiftsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.shiftsLabel.Location = new System.Drawing.Point(87, 454);
            this.shiftsLabel.Name = "shiftsLabel";
            this.shiftsLabel.Size = new System.Drawing.Size(114, 15);
            this.shiftsLabel.TabIndex = 17;
            this.shiftsLabel.Text = "Number of Shifts";
            // 
            // empIdlabel
            // 
            this.empIdlabel.AutoSize = true;
            this.empIdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.empIdlabel.Location = new System.Drawing.Point(346, 301);
            this.empIdlabel.Name = "empIdlabel";
            this.empIdlabel.Size = new System.Drawing.Size(88, 15);
            this.empIdlabel.TabIndex = 18;
            this.empIdlabel.Text = "Employee ID";
            this.empIdlabel.Click += new System.EventHandler(this.empIdlabel_Click);
            // 
            // EmployeeListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 492);
            this.Controls.Add(this.empIdlabel);
            this.Controls.Add(this.shiftsLabel);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.shiftsTextBox);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.empIdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.listLabel);
            this.Name = "EmployeeListingForm";
            this.Text = "Employee Listing";
            this.Activated += new System.EventHandler(this.EmployeeListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeListingForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox empIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.TextBox shiftsTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label shiftsLabel;
        private System.Windows.Forms.Label empIdlabel;
    }
}