
namespace HMS
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.panel_upper = new System.Windows.Forms.Panel();
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_Laboratorian = new System.Windows.Forms.Button();
            this.button_Pharmacist = new System.Windows.Forms.Button();
            this.button_Receptionist = new System.Windows.Forms.Button();
            this.button_Nurse = new System.Windows.Forms.Button();
            this.button_Doctor = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_find = new System.Windows.Forms.Button();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_upper.SuspendLayout();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_upper
            // 
            this.panel_upper.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel_upper.Controls.Add(this.label_welcome);
            this.panel_upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_upper.Location = new System.Drawing.Point(0, 0);
            this.panel_upper.Name = "panel_upper";
            this.panel_upper.Size = new System.Drawing.Size(1562, 78);
            this.panel_upper.TabIndex = 0;
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_welcome.Location = new System.Drawing.Point(642, 9);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(296, 43);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome Admin";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Laboratorian
            // 
            this.button_Laboratorian.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Laboratorian.Image = global::HMS.Properties.Resources.laboratory;
            this.button_Laboratorian.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Laboratorian.Location = new System.Drawing.Point(941, 17);
            this.button_Laboratorian.Name = "button_Laboratorian";
            this.button_Laboratorian.Size = new System.Drawing.Size(217, 59);
            this.button_Laboratorian.TabIndex = 17;
            this.button_Laboratorian.Text = "Laboratorian";
            this.button_Laboratorian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Laboratorian.UseVisualStyleBackColor = true;
            // 
            // button_Pharmacist
            // 
            this.button_Pharmacist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Pharmacist.Image = global::HMS.Properties.Resources.pharmacist;
            this.button_Pharmacist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Pharmacist.Location = new System.Drawing.Point(706, 17);
            this.button_Pharmacist.Name = "button_Pharmacist";
            this.button_Pharmacist.Size = new System.Drawing.Size(217, 58);
            this.button_Pharmacist.TabIndex = 16;
            this.button_Pharmacist.Text = "Pharmacist";
            this.button_Pharmacist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pharmacist.UseVisualStyleBackColor = true;
            // 
            // button_Receptionist
            // 
            this.button_Receptionist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Receptionist.Image = global::HMS.Properties.Resources.receptionist;
            this.button_Receptionist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Receptionist.Location = new System.Drawing.Point(467, 17);
            this.button_Receptionist.Name = "button_Receptionist";
            this.button_Receptionist.Size = new System.Drawing.Size(217, 59);
            this.button_Receptionist.TabIndex = 15;
            this.button_Receptionist.Text = "Receptionist";
            this.button_Receptionist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Receptionist.UseVisualStyleBackColor = true;
            // 
            // button_Nurse
            // 
            this.button_Nurse.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Nurse.Image = global::HMS.Properties.Resources.nurse;
            this.button_Nurse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Nurse.Location = new System.Drawing.Point(232, 17);
            this.button_Nurse.Name = "button_Nurse";
            this.button_Nurse.Size = new System.Drawing.Size(217, 59);
            this.button_Nurse.TabIndex = 14;
            this.button_Nurse.Text = "Nurse";
            this.button_Nurse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Nurse.UseVisualStyleBackColor = true;
            // 
            // button_Doctor
            // 
            this.button_Doctor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Doctor.Image = global::HMS.Properties.Resources.doctor;
            this.button_Doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Doctor.Location = new System.Drawing.Point(3, 17);
            this.button_Doctor.Name = "button_Doctor";
            this.button_Doctor.Size = new System.Drawing.Size(217, 59);
            this.button_Doctor.TabIndex = 13;
            this.button_Doctor.Text = "Doctor";
            this.button_Doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Doctor.UseVisualStyleBackColor = true;
            this.button_Doctor.Click += new System.EventHandler(this.button_Doctor_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Image = global::HMS.Properties.Resources.update;
            this.button_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_update.Location = new System.Drawing.Point(12, 214);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(217, 59);
            this.button_update.TabIndex = 18;
            this.button_update.Text = "Update";
            this.button_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Image = global::HMS.Properties.Resources.addImage;
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.Location = new System.Drawing.Point(12, 84);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(217, 59);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "Add";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Delete.Image = global::HMS.Properties.Resources.delete;
            this.button_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Delete.Location = new System.Drawing.Point(12, 149);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(217, 59);
            this.button_Delete.TabIndex = 20;
            this.button_Delete.Text = "Delete";
            this.button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_find
            // 
            this.button_find.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_find.Image = global::HMS.Properties.Resources.find;
            this.button_find.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_find.Location = new System.Drawing.Point(12, 279);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(217, 59);
            this.button_find.TabIndex = 21;
            this.button_find.Text = "Find";
            this.button_find.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_find.UseVisualStyleBackColor = true;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel_Top.Controls.Add(this.button_Doctor);
            this.panel_Top.Controls.Add(this.button_Nurse);
            this.panel_Top.Controls.Add(this.button_Receptionist);
            this.panel_Top.Controls.Add(this.button_Pharmacist);
            this.panel_Top.Controls.Add(this.button_Laboratorian);
            this.panel_Top.Location = new System.Drawing.Point(282, 84);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1163, 91);
            this.panel_Top.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 436);
            this.dataGridView1.TabIndex = 23;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 732);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.panel_upper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.panel_upper.ResumeLayout(false);
            this.panel_upper.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_upper;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_Laboratorian;
        private System.Windows.Forms.Button button_Pharmacist;
        private System.Windows.Forms.Button button_Receptionist;
        private System.Windows.Forms.Button button_Nurse;
        private System.Windows.Forms.Button button_Doctor;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}