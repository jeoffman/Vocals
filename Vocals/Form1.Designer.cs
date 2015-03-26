namespace Vocals
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox_processes = new System.Windows.Forms.ComboBox();
            this.btn_add_cmd = new System.Windows.Forms.Button();
            this.comboBox_profiles = new System.Windows.Forms.ComboBox();
            this.btn_add_profile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_del_profile = new System.Windows.Forms.Button();
            this.btn_del_cmd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_edit_cmd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_refreshProcesses = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.advancedSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBox_processes
            // 
            this.comboBox_processes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_processes.FormattingEnabled = true;
            this.comboBox_processes.Location = new System.Drawing.Point(29, 38);
            this.comboBox_processes.Name = "comboBox_processes";
            this.comboBox_processes.Size = new System.Drawing.Size(187, 21);
            this.comboBox_processes.TabIndex = 1;
            this.comboBox_processes.SelectedIndexChanged += new System.EventHandler(this.comboBox_processes_SelectedIndexChanged);
            // 
            // btn_add_cmd
            // 
            this.btn_add_cmd.Location = new System.Drawing.Point(29, 19);
            this.btn_add_cmd.Name = "btn_add_cmd";
            this.btn_add_cmd.Size = new System.Drawing.Size(70, 23);
            this.btn_add_cmd.TabIndex = 4;
            this.btn_add_cmd.Text = "Add";
            this.btn_add_cmd.UseVisualStyleBackColor = true;
            this.btn_add_cmd.Click += new System.EventHandler(this.btn_add_cmd_Click);
            // 
            // comboBox_profiles
            // 
            this.comboBox_profiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_profiles.FormattingEnabled = true;
            this.comboBox_profiles.Location = new System.Drawing.Point(29, 52);
            this.comboBox_profiles.Name = "comboBox_profiles";
            this.comboBox_profiles.Size = new System.Drawing.Size(226, 21);
            this.comboBox_profiles.TabIndex = 5;
            this.comboBox_profiles.SelectedIndexChanged += new System.EventHandler(this.comboBox_profiles_SelectedIndexChanged);
            // 
            // btn_add_profile
            // 
            this.btn_add_profile.Location = new System.Drawing.Point(29, 23);
            this.btn_add_profile.Name = "btn_add_profile";
            this.btn_add_profile.Size = new System.Drawing.Size(98, 23);
            this.btn_add_profile.TabIndex = 7;
            this.btn_add_profile.Text = "Add profile";
            this.btn_add_profile.UseVisualStyleBackColor = true;
            this.btn_add_profile.Click += new System.EventHandler(this.btn_add_profile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 134);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_del_profile
            // 
            this.btn_del_profile.Location = new System.Drawing.Point(151, 23);
            this.btn_del_profile.Name = "btn_del_profile";
            this.btn_del_profile.Size = new System.Drawing.Size(104, 23);
            this.btn_del_profile.TabIndex = 10;
            this.btn_del_profile.Text = "Delete profile";
            this.btn_del_profile.UseVisualStyleBackColor = true;
            this.btn_del_profile.Click += new System.EventHandler(this.btn_del_profile_Click);
            // 
            // btn_del_cmd
            // 
            this.btn_del_cmd.Location = new System.Drawing.Point(185, 19);
            this.btn_del_cmd.Name = "btn_del_cmd";
            this.btn_del_cmd.Size = new System.Drawing.Size(70, 23);
            this.btn_del_cmd.TabIndex = 11;
            this.btn_del_cmd.Text = "Delete";
            this.btn_del_cmd.UseVisualStyleBackColor = true;
            this.btn_del_cmd.Click += new System.EventHandler(this.btn_del_cmd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add_profile);
            this.groupBox1.Controls.Add(this.btn_del_profile);
            this.groupBox1.Controls.Add(this.comboBox_profiles);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 83);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profiles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_edit_cmd);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.btn_del_cmd);
            this.groupBox2.Controls.Add(this.btn_add_cmd);
            this.groupBox2.Location = new System.Drawing.Point(307, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 190);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_edit_cmd
            // 
            this.btn_edit_cmd.Location = new System.Drawing.Point(107, 19);
            this.btn_edit_cmd.Name = "btn_edit_cmd";
            this.btn_edit_cmd.Size = new System.Drawing.Size(70, 23);
            this.btn_edit_cmd.TabIndex = 12;
            this.btn_edit_cmd.Text = "Edit";
            this.btn_edit_cmd.UseVisualStyleBackColor = true;
            this.btn_edit_cmd.Click += new System.EventHandler(this.btn_edit_cmd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_refreshProcesses);
            this.groupBox4.Controls.Add(this.comboBox_processes);
            this.groupBox4.Location = new System.Drawing.Point(12, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 94);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Application";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btn_refreshProcesses
            // 
            this.btn_refreshProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreshProcesses.Location = new System.Drawing.Point(222, 38);
            this.btn_refreshProcesses.Name = "btn_refreshProcesses";
            this.btn_refreshProcesses.Size = new System.Drawing.Size(33, 23);
            this.btn_refreshProcesses.TabIndex = 2;
            this.btn_refreshProcesses.Text = "↺";
            this.btn_refreshProcesses.UseVisualStyleBackColor = true;
            this.btn_refreshProcesses.Click += new System.EventHandler(this.btn_refreshProcesses_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 217);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "logs";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(543, 11);
            this.progressBar1.Step = 11;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(544, 175);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // advancedSettingsToolStripMenuItem
            // 
            this.advancedSettingsToolStripMenuItem.Name = "advancedSettingsToolStripMenuItem";
            this.advancedSettingsToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.advancedSettingsToolStripMenuItem.Text = "Advanced Settings";
            this.advancedSettingsToolStripMenuItem.Click += new System.EventHandler(this.advancedSettingsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedSettingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vocals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBox_processes;
        private System.Windows.Forms.Button btn_add_cmd;
        private System.Windows.Forms.ComboBox comboBox_profiles;
        private System.Windows.Forms.Button btn_add_profile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_del_profile;
        private System.Windows.Forms.Button btn_del_cmd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_edit_cmd;
        private System.Windows.Forms.ToolStripMenuItem advancedSettingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_refreshProcesses;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

