namespace applicants_information
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.MajorLabel = new System.Windows.Forms.Label();
            this.MajorTB = new System.Windows.Forms.TextBox();
            this.StudentNumberLabel = new System.Windows.Forms.Label();
            this.StudentNumberTB = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.ContentGB = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddParticipantsButton = new System.Windows.Forms.Button();
            this.SequentialNumberLabel = new System.Windows.Forms.Label();
            this.WhatsAppNumberTB = new System.Windows.Forms.TextBox();
            this.WhatsAppNumberCB = new System.Windows.Forms.ComboBox();
            this.WhatsAppNumberLabel = new System.Windows.Forms.Label();
            this.LevelCB = new System.Windows.Forms.ComboBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.ContentGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TitleLabel.Location = new System.Drawing.Point(117, 62);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(228, 42);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.Text = "  Participants information";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(61, 136);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(164, 40);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(231, 144);
            this.NameTB.Multiline = true;
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(204, 27);
            this.NameTB.TabIndex = 1;
            // 
            // MajorLabel
            // 
            this.MajorLabel.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorLabel.Location = new System.Drawing.Point(61, 264);
            this.MajorLabel.Name = "MajorLabel";
            this.MajorLabel.Size = new System.Drawing.Size(154, 40);
            this.MajorLabel.TabIndex = 6;
            this.MajorLabel.Text = "major";
            this.MajorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MajorTB
            // 
            this.MajorTB.Location = new System.Drawing.Point(231, 272);
            this.MajorTB.Multiline = true;
            this.MajorTB.Name = "MajorTB";
            this.MajorTB.Size = new System.Drawing.Size(204, 27);
            this.MajorTB.TabIndex = 7;
            // 
            // StudentNumberLabel
            // 
            this.StudentNumberLabel.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNumberLabel.Location = new System.Drawing.Point(22, 184);
            this.StudentNumberLabel.Name = "StudentNumberLabel";
            this.StudentNumberLabel.Size = new System.Drawing.Size(175, 40);
            this.StudentNumberLabel.TabIndex = 2;
            this.StudentNumberLabel.Text = "Student Number";
            this.StudentNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentNumberTB
            // 
            this.StudentNumberTB.Location = new System.Drawing.Point(231, 192);
            this.StudentNumberTB.Multiline = true;
            this.StudentNumberTB.Name = "StudentNumberTB";
            this.StudentNumberTB.Size = new System.Drawing.Size(204, 27);
            this.StudentNumberTB.TabIndex = 3;
            // 
            // GenderLabel
            // 
            this.GenderLabel.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(61, 224);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(160, 40);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "Gender";
            this.GenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContentGB
            // 
            this.ContentGB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContentGB.Controls.Add(this.ClearButton);
            this.ContentGB.Controls.Add(this.AddParticipantsButton);
            this.ContentGB.Controls.Add(this.SequentialNumberLabel);
            this.ContentGB.Controls.Add(this.WhatsAppNumberTB);
            this.ContentGB.Controls.Add(this.WhatsAppNumberCB);
            this.ContentGB.Controls.Add(this.WhatsAppNumberLabel);
            this.ContentGB.Controls.Add(this.LevelCB);
            this.ContentGB.Controls.Add(this.LevelLabel);
            this.ContentGB.Controls.Add(this.GenderCB);
            this.ContentGB.Controls.Add(this.GenderLabel);
            this.ContentGB.Controls.Add(this.StudentNumberTB);
            this.ContentGB.Controls.Add(this.StudentNumberLabel);
            this.ContentGB.Controls.Add(this.MajorTB);
            this.ContentGB.Controls.Add(this.MajorLabel);
            this.ContentGB.Controls.Add(this.NameTB);
            this.ContentGB.Controls.Add(this.NameLabel);
            this.ContentGB.Controls.Add(this.TitleLabel);
            this.ContentGB.Location = new System.Drawing.Point(226, 26);
            this.ContentGB.Name = "ContentGB";
            this.ContentGB.Size = new System.Drawing.Size(471, 556);
            this.ContentGB.TabIndex = 17;
            this.ContentGB.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClearButton.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearButton.Location = new System.Drawing.Point(235, 446);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(200, 46);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddParticipantsButton
            // 
            this.AddParticipantsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddParticipantsButton.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddParticipantsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddParticipantsButton.Location = new System.Drawing.Point(26, 446);
            this.AddParticipantsButton.Name = "AddParticipantsButton";
            this.AddParticipantsButton.Size = new System.Drawing.Size(200, 46);
            this.AddParticipantsButton.TabIndex = 13;
            this.AddParticipantsButton.Text = "Add Participants";
            this.AddParticipantsButton.UseVisualStyleBackColor = false;
            this.AddParticipantsButton.Click += new System.EventHandler(this.AddParticipantsButton_Click);
            // 
            // SequentialNumberLabel
            // 
            this.SequentialNumberLabel.AutoSize = true;
            this.SequentialNumberLabel.Location = new System.Drawing.Point(55, 85);
            this.SequentialNumberLabel.Name = "SequentialNumberLabel";
            this.SequentialNumberLabel.Size = new System.Drawing.Size(0, 19);
            this.SequentialNumberLabel.TabIndex = 15;
            // 
            // WhatsAppNumberTB
            // 
            this.WhatsAppNumberTB.Location = new System.Drawing.Point(315, 352);
            this.WhatsAppNumberTB.Multiline = true;
            this.WhatsAppNumberTB.Name = "WhatsAppNumberTB";
            this.WhatsAppNumberTB.Size = new System.Drawing.Size(120, 27);
            this.WhatsAppNumberTB.TabIndex = 12;
            // 
            // WhatsAppNumberCB
            // 
            this.WhatsAppNumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WhatsAppNumberCB.FormattingEnabled = true;
            this.WhatsAppNumberCB.Items.AddRange(new object[] {
            "+970",
            "+972"});
            this.WhatsAppNumberCB.Location = new System.Drawing.Point(235, 352);
            this.WhatsAppNumberCB.Name = "WhatsAppNumberCB";
            this.WhatsAppNumberCB.Size = new System.Drawing.Size(74, 27);
            this.WhatsAppNumberCB.TabIndex = 11;
            // 
            // WhatsAppNumberLabel
            // 
            this.WhatsAppNumberLabel.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhatsAppNumberLabel.Location = new System.Drawing.Point(22, 344);
            this.WhatsAppNumberLabel.Name = "WhatsAppNumberLabel";
            this.WhatsAppNumberLabel.Size = new System.Drawing.Size(193, 40);
            this.WhatsAppNumberLabel.TabIndex = 10;
            this.WhatsAppNumberLabel.Text = "WhatsApp Number";
            this.WhatsAppNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelCB
            // 
            this.LevelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelCB.FormattingEnabled = true;
            this.LevelCB.Items.AddRange(new object[] {
            "year1",
            "year2",
            "year3",
            "year4",
            "others"});
            this.LevelCB.Location = new System.Drawing.Point(235, 312);
            this.LevelCB.Name = "LevelCB";
            this.LevelCB.Size = new System.Drawing.Size(200, 27);
            this.LevelCB.TabIndex = 9;
            // 
            // LevelLabel
            // 
            this.LevelLabel.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(65, 304);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(160, 40);
            this.LevelLabel.TabIndex = 8;
            this.LevelLabel.Text = "Level";
            this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenderCB
            // 
            this.GenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "male",
            "female"});
            this.GenderCB.Location = new System.Drawing.Point(231, 232);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(204, 27);
            this.GenderCB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::applicants_information.Properties.Resources._127557007_programmers_during_coding_debugging_maintenance_and_software_testing_isometric_flowchart_on_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 616);
            this.Controls.Add(this.ContentGB);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ContentGB.ResumeLayout(false);
            this.ContentGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label MajorLabel;
        private System.Windows.Forms.TextBox MajorTB;
        private System.Windows.Forms.Label StudentNumberLabel;
        private System.Windows.Forms.TextBox StudentNumberTB;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.GroupBox ContentGB;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.TextBox WhatsAppNumberTB;
        private System.Windows.Forms.ComboBox WhatsAppNumberCB;
        private System.Windows.Forms.Label WhatsAppNumberLabel;
        private System.Windows.Forms.ComboBox LevelCB;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Button AddParticipantsButton;
        private System.Windows.Forms.Label SequentialNumberLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

