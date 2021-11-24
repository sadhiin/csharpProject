
namespace HospitalMgnt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.AdmindataGridView1 = new System.Windows.Forms.DataGridView();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonPostNotice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Add = new System.Windows.Forms.Panel();
            this.button_Account = new System.Windows.Forms.Button();
            this.button_Pharmacist = new System.Windows.Forms.Button();
            this.button_Recptionist = new System.Windows.Forms.Button();
            this.button_Nurse = new System.Windows.Forms.Button();
            this.button_Doctor = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.timer_AddPanel = new System.Windows.Forms.Timer(this.components);
            this.panel_Update = new System.Windows.Forms.Panel();
            this.buttonUpdate_Account = new System.Windows.Forms.Button();
            this.buttonUpdate_Pharmacist = new System.Windows.Forms.Button();
            this.buttonUpdate_Receptionist = new System.Windows.Forms.Button();
            this.buttonUpdate_Nurse = new System.Windows.Forms.Button();
            this.buttonUpdat_Doctor = new System.Windows.Forms.Button();
            this.panel_Delete = new System.Windows.Forms.Panel();
            this.buttonDelete_Account = new System.Windows.Forms.Button();
            this.buttonDelete_Phamacist = new System.Windows.Forms.Button();
            this.buttonDelete_Receptionist = new System.Windows.Forms.Button();
            this.buttonDelete_Nurse = new System.Windows.Forms.Button();
            this.buttonDelete_Doctor = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel_Find = new System.Windows.Forms.Panel();
            this.buttonFind_Account = new System.Windows.Forms.Button();
            this.buttonFind_Pharmacist = new System.Windows.Forms.Button();
            this.buttonFind_Receptionosist = new System.Windows.Forms.Button();
            this.buttonFind_Nurse = new System.Windows.Forms.Button();
            this.buttonFind_Doctor = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.timer_UpdatePanel = new System.Windows.Forms.Timer(this.components);
            this.timer_DeletePanel = new System.Windows.Forms.Timer(this.components);
            this.timer_FindPanel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AdmindataGridView1)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Add.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel_Update.SuspendLayout();
            this.panel_Delete.SuspendLayout();
            this.panel_Find.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdmindataGridView1
            // 
            this.AdmindataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdmindataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AdmindataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AdmindataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdmindataGridView1.GridColor = System.Drawing.Color.Gray;
            this.AdmindataGridView1.Location = new System.Drawing.Point(962, 215);
            this.AdmindataGridView1.Name = "AdmindataGridView1";
            this.AdmindataGridView1.RowHeadersWidth = 51;
            this.AdmindataGridView1.RowTemplate.Height = 29;
            this.AdmindataGridView1.Size = new System.Drawing.Size(300, 188);
            this.AdmindataGridView1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SidePanel.BackColor = System.Drawing.Color.MediumPurple;
            this.SidePanel.Controls.Add(this.buttonPostNotice);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Location = new System.Drawing.Point(1, 3);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(213, 619);
            this.SidePanel.TabIndex = 1;
            // 
            // buttonPostNotice
            // 
            this.buttonPostNotice.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPostNotice.Image = global::HospitalMgnt.Properties.Resources.addImage;
            this.buttonPostNotice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPostNotice.Location = new System.Drawing.Point(0, 464);
            this.buttonPostNotice.Name = "buttonPostNotice";
            this.buttonPostNotice.Size = new System.Drawing.Size(213, 58);
            this.buttonPostNotice.TabIndex = 3;
            this.buttonPostNotice.Text = "Post Notice";
            this.buttonPostNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPostNotice.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::HospitalMgnt.Properties.Resources.AdminPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 182);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Add
            // 
            this.panel_Add.Controls.Add(this.button_Account);
            this.panel_Add.Controls.Add(this.button_Pharmacist);
            this.panel_Add.Controls.Add(this.button_Recptionist);
            this.panel_Add.Controls.Add(this.button_Nurse);
            this.panel_Add.Controls.Add(this.button_Doctor);
            this.panel_Add.Controls.Add(this.buttonAdd);
            this.panel_Add.Location = new System.Drawing.Point(1077, 118);
            this.panel_Add.MaximumSize = new System.Drawing.Size(217, 348);
            this.panel_Add.MinimumSize = new System.Drawing.Size(217, 61);
            this.panel_Add.Name = "panel_Add";
            this.panel_Add.Size = new System.Drawing.Size(217, 61);
            this.panel_Add.TabIndex = 4;
            // 
            // button_Account
            // 
            this.button_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Account.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Account.Image = global::HospitalMgnt.Properties.Resources.account;
            this.button_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Account.Location = new System.Drawing.Point(0, 289);
            this.button_Account.Name = "button_Account";
            this.button_Account.Size = new System.Drawing.Size(217, 59);
            this.button_Account.TabIndex = 6;
            this.button_Account.Text = "Account";
            this.button_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Account.UseVisualStyleBackColor = true;
            // 
            // button_Pharmacist
            // 
            this.button_Pharmacist.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Pharmacist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Pharmacist.Image = global::HospitalMgnt.Properties.Resources.pharmacist;
            this.button_Pharmacist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Pharmacist.Location = new System.Drawing.Point(0, 231);
            this.button_Pharmacist.Name = "button_Pharmacist";
            this.button_Pharmacist.Size = new System.Drawing.Size(217, 58);
            this.button_Pharmacist.TabIndex = 5;
            this.button_Pharmacist.Text = "Pharmacist";
            this.button_Pharmacist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pharmacist.UseVisualStyleBackColor = true;
            // 
            // button_Recptionist
            // 
            this.button_Recptionist.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Recptionist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Recptionist.Image = global::HospitalMgnt.Properties.Resources.receptionist;
            this.button_Recptionist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Recptionist.Location = new System.Drawing.Point(0, 173);
            this.button_Recptionist.Name = "button_Recptionist";
            this.button_Recptionist.Size = new System.Drawing.Size(217, 58);
            this.button_Recptionist.TabIndex = 4;
            this.button_Recptionist.Text = "Receptionist";
            this.button_Recptionist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Recptionist.UseVisualStyleBackColor = true;
            // 
            // button_Nurse
            // 
            this.button_Nurse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Nurse.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Nurse.Image = global::HospitalMgnt.Properties.Resources.nurse;
            this.button_Nurse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Nurse.Location = new System.Drawing.Point(0, 119);
            this.button_Nurse.Name = "button_Nurse";
            this.button_Nurse.Size = new System.Drawing.Size(217, 54);
            this.button_Nurse.TabIndex = 3;
            this.button_Nurse.Text = "Nurse";
            this.button_Nurse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Nurse.UseVisualStyleBackColor = true;
            // 
            // button_Doctor
            // 
            this.button_Doctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Doctor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Doctor.Image = global::HospitalMgnt.Properties.Resources.doctor;
            this.button_Doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Doctor.Location = new System.Drawing.Point(0, 59);
            this.button_Doctor.Name = "button_Doctor";
            this.button_Doctor.Size = new System.Drawing.Size(217, 60);
            this.button_Doctor.TabIndex = 3;
            this.button_Doctor.Text = "Doctor";
            this.button_Doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Doctor.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Image = global::HospitalMgnt.Properties.Resources.addImage;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(217, 59);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseEnter += new System.EventHandler(this.buttonAdd_MouseEnter);
            this.buttonAdd.MouseLeave += new System.EventHandler(this.buttonAdd_MouseLeave);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdate.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.Image = global::HospitalMgnt.Properties.Resources.update;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.Location = new System.Drawing.Point(0, 0);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(214, 64);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            this.buttonUpdate.MouseEnter += new System.EventHandler(this.buttonUpdate_MouseEnter);
            this.buttonUpdate.MouseLeave += new System.EventHandler(this.buttonUpdate_MouseLeave);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TopPanel.Controls.Add(this.WelcomeLabel);
            this.TopPanel.Location = new System.Drawing.Point(214, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1080, 88);
            this.TopPanel.TabIndex = 2;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(229, 6);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(541, 69);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome Admin";
            // 
            // timer_AddPanel
            // 
            this.timer_AddPanel.Interval = 15;
            this.timer_AddPanel.Tick += new System.EventHandler(this.timer_AddPanel_Tick);
            // 
            // panel_Update
            // 
            this.panel_Update.Controls.Add(this.buttonUpdate_Account);
            this.panel_Update.Controls.Add(this.buttonUpdate_Pharmacist);
            this.panel_Update.Controls.Add(this.buttonUpdate_Receptionist);
            this.panel_Update.Controls.Add(this.buttonUpdate_Nurse);
            this.panel_Update.Controls.Add(this.buttonUpdat_Doctor);
            this.panel_Update.Controls.Add(this.buttonUpdate);
            this.panel_Update.Location = new System.Drawing.Point(721, 133);
            this.panel_Update.MaximumSize = new System.Drawing.Size(214, 384);
            this.panel_Update.MinimumSize = new System.Drawing.Size(214, 64);
            this.panel_Update.Name = "panel_Update";
            this.panel_Update.Size = new System.Drawing.Size(214, 64);
            this.panel_Update.TabIndex = 5;
            // 
            // buttonUpdate_Account
            // 
            this.buttonUpdate_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdate_Account.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate_Account.Image = global::HospitalMgnt.Properties.Resources.account;
            this.buttonUpdate_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate_Account.Location = new System.Drawing.Point(0, 320);
            this.buttonUpdate_Account.Name = "buttonUpdate_Account";
            this.buttonUpdate_Account.Size = new System.Drawing.Size(214, 61);
            this.buttonUpdate_Account.TabIndex = 8;
            this.buttonUpdate_Account.Text = "Account";
            this.buttonUpdate_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate_Account.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate_Pharmacist
            // 
            this.buttonUpdate_Pharmacist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdate_Pharmacist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate_Pharmacist.Image = global::HospitalMgnt.Properties.Resources.pharmacist;
            this.buttonUpdate_Pharmacist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate_Pharmacist.Location = new System.Drawing.Point(0, 256);
            this.buttonUpdate_Pharmacist.Name = "buttonUpdate_Pharmacist";
            this.buttonUpdate_Pharmacist.Size = new System.Drawing.Size(214, 64);
            this.buttonUpdate_Pharmacist.TabIndex = 7;
            this.buttonUpdate_Pharmacist.Text = "Pharmacist";
            this.buttonUpdate_Pharmacist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate_Pharmacist.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate_Receptionist
            // 
            this.buttonUpdate_Receptionist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdate_Receptionist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate_Receptionist.Image = global::HospitalMgnt.Properties.Resources.receptionist;
            this.buttonUpdate_Receptionist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate_Receptionist.Location = new System.Drawing.Point(0, 192);
            this.buttonUpdate_Receptionist.Name = "buttonUpdate_Receptionist";
            this.buttonUpdate_Receptionist.Size = new System.Drawing.Size(214, 64);
            this.buttonUpdate_Receptionist.TabIndex = 6;
            this.buttonUpdate_Receptionist.Text = "Receptionist";
            this.buttonUpdate_Receptionist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate_Receptionist.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate_Nurse
            // 
            this.buttonUpdate_Nurse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdate_Nurse.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate_Nurse.Image = global::HospitalMgnt.Properties.Resources.nurse;
            this.buttonUpdate_Nurse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate_Nurse.Location = new System.Drawing.Point(0, 128);
            this.buttonUpdate_Nurse.Name = "buttonUpdate_Nurse";
            this.buttonUpdate_Nurse.Size = new System.Drawing.Size(214, 64);
            this.buttonUpdate_Nurse.TabIndex = 5;
            this.buttonUpdate_Nurse.Text = "Nurse";
            this.buttonUpdate_Nurse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate_Nurse.UseVisualStyleBackColor = true;
            // 
            // buttonUpdat_Doctor
            // 
            this.buttonUpdat_Doctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdat_Doctor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdat_Doctor.Image = global::HospitalMgnt.Properties.Resources.doctor;
            this.buttonUpdat_Doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdat_Doctor.Location = new System.Drawing.Point(0, 64);
            this.buttonUpdat_Doctor.Name = "buttonUpdat_Doctor";
            this.buttonUpdat_Doctor.Size = new System.Drawing.Size(214, 64);
            this.buttonUpdat_Doctor.TabIndex = 4;
            this.buttonUpdat_Doctor.Text = "Doctor";
            this.buttonUpdat_Doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdat_Doctor.UseVisualStyleBackColor = true;
            // 
            // panel_Delete
            // 
            this.panel_Delete.Controls.Add(this.buttonDelete_Account);
            this.panel_Delete.Controls.Add(this.buttonDelete_Phamacist);
            this.panel_Delete.Controls.Add(this.buttonDelete_Receptionist);
            this.panel_Delete.Controls.Add(this.buttonDelete_Nurse);
            this.panel_Delete.Controls.Add(this.buttonDelete_Doctor);
            this.panel_Delete.Controls.Add(this.buttonDelete);
            this.panel_Delete.Location = new System.Drawing.Point(475, 118);
            this.panel_Delete.MaximumSize = new System.Drawing.Size(214, 384);
            this.panel_Delete.MinimumSize = new System.Drawing.Size(214, 64);
            this.panel_Delete.Name = "panel_Delete";
            this.panel_Delete.Size = new System.Drawing.Size(214, 67);
            this.panel_Delete.TabIndex = 6;
            // 
            // buttonDelete_Account
            // 
            this.buttonDelete_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete_Account.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete_Account.Image = global::HospitalMgnt.Properties.Resources.account;
            this.buttonDelete_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete_Account.Location = new System.Drawing.Point(0, 320);
            this.buttonDelete_Account.Name = "buttonDelete_Account";
            this.buttonDelete_Account.Size = new System.Drawing.Size(214, 64);
            this.buttonDelete_Account.TabIndex = 8;
            this.buttonDelete_Account.Text = "Account";
            this.buttonDelete_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete_Account.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_Phamacist
            // 
            this.buttonDelete_Phamacist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete_Phamacist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete_Phamacist.Image = global::HospitalMgnt.Properties.Resources.pharmacist;
            this.buttonDelete_Phamacist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete_Phamacist.Location = new System.Drawing.Point(0, 256);
            this.buttonDelete_Phamacist.Name = "buttonDelete_Phamacist";
            this.buttonDelete_Phamacist.Size = new System.Drawing.Size(214, 64);
            this.buttonDelete_Phamacist.TabIndex = 7;
            this.buttonDelete_Phamacist.Text = "Pharmacist";
            this.buttonDelete_Phamacist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete_Phamacist.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_Receptionist
            // 
            this.buttonDelete_Receptionist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete_Receptionist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete_Receptionist.Image = global::HospitalMgnt.Properties.Resources.receptionist;
            this.buttonDelete_Receptionist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete_Receptionist.Location = new System.Drawing.Point(0, 192);
            this.buttonDelete_Receptionist.Name = "buttonDelete_Receptionist";
            this.buttonDelete_Receptionist.Size = new System.Drawing.Size(214, 64);
            this.buttonDelete_Receptionist.TabIndex = 6;
            this.buttonDelete_Receptionist.Text = "Receptionist";
            this.buttonDelete_Receptionist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete_Receptionist.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_Nurse
            // 
            this.buttonDelete_Nurse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete_Nurse.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete_Nurse.Image = global::HospitalMgnt.Properties.Resources.nurse;
            this.buttonDelete_Nurse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete_Nurse.Location = new System.Drawing.Point(0, 128);
            this.buttonDelete_Nurse.Name = "buttonDelete_Nurse";
            this.buttonDelete_Nurse.Size = new System.Drawing.Size(214, 64);
            this.buttonDelete_Nurse.TabIndex = 5;
            this.buttonDelete_Nurse.Text = "Nurse";
            this.buttonDelete_Nurse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete_Nurse.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_Doctor
            // 
            this.buttonDelete_Doctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete_Doctor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete_Doctor.Image = global::HospitalMgnt.Properties.Resources.doctor;
            this.buttonDelete_Doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete_Doctor.Location = new System.Drawing.Point(0, 64);
            this.buttonDelete_Doctor.Name = "buttonDelete_Doctor";
            this.buttonDelete_Doctor.Size = new System.Drawing.Size(214, 64);
            this.buttonDelete_Doctor.TabIndex = 4;
            this.buttonDelete_Doctor.Text = "Doctor";
            this.buttonDelete_Doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete_Doctor.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Image = global::HospitalMgnt.Properties.Resources.delete;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.Location = new System.Drawing.Point(0, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(214, 64);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.buttonDelete_MouseEnter);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.buttonDelete_MouseLeave);
            // 
            // panel_Find
            // 
            this.panel_Find.Controls.Add(this.buttonFind_Account);
            this.panel_Find.Controls.Add(this.buttonFind_Pharmacist);
            this.panel_Find.Controls.Add(this.buttonFind_Receptionosist);
            this.panel_Find.Controls.Add(this.buttonFind_Nurse);
            this.panel_Find.Controls.Add(this.buttonFind_Doctor);
            this.panel_Find.Controls.Add(this.buttonFind);
            this.panel_Find.Location = new System.Drawing.Point(244, 173);
            this.panel_Find.MaximumSize = new System.Drawing.Size(214, 384);
            this.panel_Find.MinimumSize = new System.Drawing.Size(214, 64);
            this.panel_Find.Name = "panel_Find";
            this.panel_Find.Size = new System.Drawing.Size(214, 64);
            this.panel_Find.TabIndex = 7;
            // 
            // buttonFind_Account
            // 
            this.buttonFind_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFind_Account.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind_Account.Image = global::HospitalMgnt.Properties.Resources.account;
            this.buttonFind_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFind_Account.Location = new System.Drawing.Point(0, 320);
            this.buttonFind_Account.Name = "buttonFind_Account";
            this.buttonFind_Account.Size = new System.Drawing.Size(214, 61);
            this.buttonFind_Account.TabIndex = 8;
            this.buttonFind_Account.Text = "Account";
            this.buttonFind_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFind_Account.UseVisualStyleBackColor = true;
            // 
            // buttonFind_Pharmacist
            // 
            this.buttonFind_Pharmacist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFind_Pharmacist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind_Pharmacist.Image = global::HospitalMgnt.Properties.Resources.pharmacist;
            this.buttonFind_Pharmacist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFind_Pharmacist.Location = new System.Drawing.Point(0, 256);
            this.buttonFind_Pharmacist.Name = "buttonFind_Pharmacist";
            this.buttonFind_Pharmacist.Size = new System.Drawing.Size(214, 64);
            this.buttonFind_Pharmacist.TabIndex = 7;
            this.buttonFind_Pharmacist.Text = "Pharmacist";
            this.buttonFind_Pharmacist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFind_Pharmacist.UseVisualStyleBackColor = true;
            // 
            // buttonFind_Receptionosist
            // 
            this.buttonFind_Receptionosist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFind_Receptionosist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind_Receptionosist.Image = global::HospitalMgnt.Properties.Resources.receptionist;
            this.buttonFind_Receptionosist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFind_Receptionosist.Location = new System.Drawing.Point(0, 192);
            this.buttonFind_Receptionosist.Name = "buttonFind_Receptionosist";
            this.buttonFind_Receptionosist.Size = new System.Drawing.Size(214, 64);
            this.buttonFind_Receptionosist.TabIndex = 6;
            this.buttonFind_Receptionosist.Text = "Receptionist";
            this.buttonFind_Receptionosist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFind_Receptionosist.UseVisualStyleBackColor = true;
            // 
            // buttonFind_Nurse
            // 
            this.buttonFind_Nurse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFind_Nurse.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind_Nurse.Image = global::HospitalMgnt.Properties.Resources.nurse;
            this.buttonFind_Nurse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFind_Nurse.Location = new System.Drawing.Point(0, 128);
            this.buttonFind_Nurse.Name = "buttonFind_Nurse";
            this.buttonFind_Nurse.Size = new System.Drawing.Size(214, 64);
            this.buttonFind_Nurse.TabIndex = 5;
            this.buttonFind_Nurse.Text = "Nurse";
            this.buttonFind_Nurse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFind_Nurse.UseVisualStyleBackColor = true;
            // 
            // buttonFind_Doctor
            // 
            this.buttonFind_Doctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFind_Doctor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind_Doctor.Image = global::HospitalMgnt.Properties.Resources.doctor;
            this.buttonFind_Doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFind_Doctor.Location = new System.Drawing.Point(0, 64);
            this.buttonFind_Doctor.Name = "buttonFind_Doctor";
            this.buttonFind_Doctor.Size = new System.Drawing.Size(214, 64);
            this.buttonFind_Doctor.TabIndex = 4;
            this.buttonFind_Doctor.Text = "Doctor";
            this.buttonFind_Doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFind_Doctor.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFind.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind.Image = global::HospitalMgnt.Properties.Resources.find;
            this.buttonFind.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFind.Location = new System.Drawing.Point(0, 0);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(214, 64);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Find";
            this.buttonFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            this.buttonFind.MouseEnter += new System.EventHandler(this.buttonFind_MouseEnter);
            this.buttonFind.MouseLeave += new System.EventHandler(this.buttonFind_MouseLeave);
            // 
            // timer_UpdatePanel
            // 
            this.timer_UpdatePanel.Interval = 15;
            this.timer_UpdatePanel.Tick += new System.EventHandler(this.timer_UpdatePanel_Tick);
            // 
            // timer_DeletePanel
            // 
            this.timer_DeletePanel.Interval = 15;
            this.timer_DeletePanel.Tick += new System.EventHandler(this.timer_DeletePanel_Tick);
            // 
            // timer_FindPanel
            // 
            this.timer_FindPanel.Interval = 15;
            this.timer_FindPanel.Tick += new System.EventHandler(this.timer_FindPanel_Tick);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 621);
            this.Controls.Add(this.panel_Find);
            this.Controls.Add(this.panel_Delete);
            this.Controls.Add(this.panel_Update);
            this.Controls.Add(this.panel_Add);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.AdmindataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdmindataGridView1)).EndInit();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Add.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel_Update.ResumeLayout(false);
            this.panel_Delete.ResumeLayout(false);
            this.panel_Find.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AdmindataGridView1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPostNotice;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button_Doctor;
        private System.Windows.Forms.Panel panel_Add;
        private System.Windows.Forms.Button button_Account;
        private System.Windows.Forms.Button button_Pharmacist;
        private System.Windows.Forms.Button button_Recptionist;
        private System.Windows.Forms.Button button_Nurse;
        private System.Windows.Forms.Timer timer_AddPanel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel_Update;
        private System.Windows.Forms.Button buttonUpdate_Receptionist;
        private System.Windows.Forms.Button buttonUpdate_Nurse;
        private System.Windows.Forms.Button buttonUpdat_Doctor;
        private System.Windows.Forms.Button buttonUpdate_Pharmacist;
        private System.Windows.Forms.Button buttonUpdate_Account;
        private System.Windows.Forms.Panel panel_Delete;
        private System.Windows.Forms.Button buttonDelete_Account;
        private System.Windows.Forms.Button buttonDelete_Phamacist;
        private System.Windows.Forms.Button buttonDelete_Receptionist;
        private System.Windows.Forms.Button buttonDelete_Nurse;
        private System.Windows.Forms.Button buttonDelete_Doctor;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panel_Find;
        private System.Windows.Forms.Button buttonFind_Account;
        private System.Windows.Forms.Button buttonFind_Pharmacist;
        private System.Windows.Forms.Button buttonFind_Receptionosist;
        private System.Windows.Forms.Button buttonFind_Nurse;
        private System.Windows.Forms.Button buttonFind_Doctor;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Timer timer_UpdatePanel;
        private System.Windows.Forms.Timer timer_DeletePanel;
        private System.Windows.Forms.Timer timer_FindPanel;
    }
}