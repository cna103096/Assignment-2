﻿namespace Assignment_2

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
            this.TextBox_Output = new System.Windows.Forms.RichTextBox();
            this.GroupBox_Management = new System.Windows.Forms.GroupBox();
            this.Label_Search_Guild = new System.Windows.Forms.Label();
            this.Label_Search_Player = new System.Windows.Forms.Label();
            this.Textbox_Search_Guild = new System.Windows.Forms.TextBox();
            this.Textbox_Search_Player = new System.Windows.Forms.TextBox();
            this.Button_Apply_Search = new System.Windows.Forms.Button();
            this.Button_Leave_Guild = new System.Windows.Forms.Button();
            this.Button_Join_Guild = new System.Windows.Forms.Button();
            this.Button_Disband_Guild = new System.Windows.Forms.Button();
            this.Button_Print_Guild = new System.Windows.Forms.Button();
            this.Label_Title = new System.Windows.Forms.Label();
            this.GroupBox_Create_Player = new System.Windows.Forms.GroupBox();
            this.Label_Race = new System.Windows.Forms.Label();
            this.Label_Role = new System.Windows.Forms.Label();
            this.ComboBox_Player_Race = new System.Windows.Forms.ComboBox();
            this.ComboBox_Player_Role = new System.Windows.Forms.ComboBox();
            this.Label_Player_Name = new System.Windows.Forms.Label();
            this.Label_Class = new System.Windows.Forms.Label();
            this.Button_Add_Player = new System.Windows.Forms.Button();
            this.ComboBox_Player_Class = new System.Windows.Forms.ComboBox();
            this.Textbox_Player_Name = new System.Windows.Forms.TextBox();
            this.GroupBox_Create_Guild = new System.Windows.Forms.GroupBox();
            this.Button_Add_Guild = new System.Windows.Forms.Button();
            this.Label_Guild_Server = new System.Windows.Forms.Label();
            this.Label_Guild_Type = new System.Windows.Forms.Label();
            this.ComboBox_Guild_Server = new System.Windows.Forms.ComboBox();
            this.ComboBox_Guild_Type = new System.Windows.Forms.ComboBox();
            this.Label_Guild_Box = new System.Windows.Forms.Label();
            this.Textbox_Guild_Name = new System.Windows.Forms.TextBox();
            this.Label_Output = new System.Windows.Forms.Label();
            this.Label_Player_Textbox = new System.Windows.Forms.Label();
            this.Label_Guild_Textbox = new System.Windows.Forms.Label();
            this.ListBox_Players = new System.Windows.Forms.ListBox();
            this.ListBox_Guilds = new System.Windows.Forms.ListBox();
            this.GroupBox_Management.SuspendLayout();
            this.GroupBox_Create_Player.SuspendLayout();
            this.GroupBox_Create_Guild.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Output
            // 
            this.TextBox_Output.AccessibleName = "";
            this.TextBox_Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Output.Location = new System.Drawing.Point(12, 558);
            this.TextBox_Output.Name = "TextBox_Output";
            this.TextBox_Output.ReadOnly = true;
            this.TextBox_Output.Size = new System.Drawing.Size(1014, 96);
            this.TextBox_Output.TabIndex = 0;
            this.TextBox_Output.Text = "";
            // 
            // GroupBox_Management
            // 
            this.GroupBox_Management.Controls.Add(this.Label_Search_Guild);
            this.GroupBox_Management.Controls.Add(this.Label_Search_Player);
            this.GroupBox_Management.Controls.Add(this.Textbox_Search_Guild);
            this.GroupBox_Management.Controls.Add(this.Textbox_Search_Player);
            this.GroupBox_Management.Controls.Add(this.Button_Apply_Search);
            this.GroupBox_Management.Controls.Add(this.Button_Leave_Guild);
            this.GroupBox_Management.Controls.Add(this.Button_Join_Guild);
            this.GroupBox_Management.Controls.Add(this.Button_Disband_Guild);
            this.GroupBox_Management.Controls.Add(this.Button_Print_Guild);
            this.GroupBox_Management.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox_Management.Location = new System.Drawing.Point(12, 43);
            this.GroupBox_Management.Name = "GroupBox_Management";
            this.GroupBox_Management.Size = new System.Drawing.Size(394, 170);
            this.GroupBox_Management.TabIndex = 2;
            this.GroupBox_Management.TabStop = false;
            this.GroupBox_Management.Text = "Management Functions";
            // 
            // Label_Search_Guild
            // 
            this.Label_Search_Guild.AutoSize = true;
            this.Label_Search_Guild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Search_Guild.Location = new System.Drawing.Point(134, 61);
            this.Label_Search_Guild.Name = "Label_Search_Guild";
            this.Label_Search_Guild.Size = new System.Drawing.Size(122, 13);
            this.Label_Search_Guild.TabIndex = 7;
            this.Label_Search_Guild.Text = "Search Guild (by Server)";
            // 
            // Label_Search_Player
            // 
            this.Label_Search_Player.AutoSize = true;
            this.Label_Search_Player.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Search_Player.Location = new System.Drawing.Point(134, 16);
            this.Label_Search_Player.Name = "Label_Search_Player";
            this.Label_Search_Player.Size = new System.Drawing.Size(124, 13);
            this.Label_Search_Player.TabIndex = 4;
            this.Label_Search_Player.Text = "Search Player (by Name)";
            // 
            // Textbox_Search_Guild
            // 
            this.Textbox_Search_Guild.Location = new System.Drawing.Point(137, 77);
            this.Textbox_Search_Guild.Name = "Textbox_Search_Guild";
            this.Textbox_Search_Guild.Size = new System.Drawing.Size(144, 20);
            this.Textbox_Search_Guild.TabIndex = 6;
            // 
            // Textbox_Search_Player
            // 
            this.Textbox_Search_Player.Location = new System.Drawing.Point(137, 32);
            this.Textbox_Search_Player.Name = "Textbox_Search_Player";
            this.Textbox_Search_Player.Size = new System.Drawing.Size(144, 20);
            this.Textbox_Search_Player.TabIndex = 5;
            // 
            // Button_Apply_Search
            // 
            this.Button_Apply_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Apply_Search.Location = new System.Drawing.Point(11, 132);
            this.Button_Apply_Search.Name = "Button_Apply_Search";
            this.Button_Apply_Search.Size = new System.Drawing.Size(117, 23);
            this.Button_Apply_Search.TabIndex = 4;
            this.Button_Apply_Search.Text = "Apply Search Criteria";
            this.Button_Apply_Search.UseVisualStyleBackColor = true;
            this.Button_Apply_Search.Click += new System.EventHandler(this.Button_Apply_Search_Click);
            // 
            // Button_Leave_Guild
            // 
            this.Button_Leave_Guild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Leave_Guild.Location = new System.Drawing.Point(11, 103);
            this.Button_Leave_Guild.Name = "Button_Leave_Guild";
            this.Button_Leave_Guild.Size = new System.Drawing.Size(117, 23);
            this.Button_Leave_Guild.TabIndex = 3;
            this.Button_Leave_Guild.Text = "Leave Guild";
            this.Button_Leave_Guild.UseVisualStyleBackColor = true;
            // 
            // Button_Join_Guild
            // 
            this.Button_Join_Guild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Join_Guild.Location = new System.Drawing.Point(11, 74);
            this.Button_Join_Guild.Name = "Button_Join_Guild";
            this.Button_Join_Guild.Size = new System.Drawing.Size(117, 23);
            this.Button_Join_Guild.TabIndex = 2;
            this.Button_Join_Guild.Text = "Join Guild";
            this.Button_Join_Guild.UseVisualStyleBackColor = true;
            // 
            // Button_Disband_Guild
            // 
            this.Button_Disband_Guild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Disband_Guild.Location = new System.Drawing.Point(11, 45);
            this.Button_Disband_Guild.Name = "Button_Disband_Guild";
            this.Button_Disband_Guild.Size = new System.Drawing.Size(117, 23);
            this.Button_Disband_Guild.TabIndex = 1;
            this.Button_Disband_Guild.Text = "Disband Guild";
            this.Button_Disband_Guild.UseVisualStyleBackColor = true;
            // 
            // Button_Print_Guild
            // 
            this.Button_Print_Guild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Print_Guild.Location = new System.Drawing.Point(11, 16);
            this.Button_Print_Guild.Name = "Button_Print_Guild";
            this.Button_Print_Guild.Size = new System.Drawing.Size(117, 23);
            this.Button_Print_Guild.TabIndex = 0;
            this.Button_Print_Guild.Text = "Print Guild Roster";
            this.Button_Print_Guild.UseVisualStyleBackColor = true;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Title.Location = new System.Drawing.Point(266, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(424, 31);
            this.Label_Title.TabIndex = 3;
            this.Label_Title.Text = "Player/Guild Management System";
            // 
            // GroupBox_Create_Player
            // 
            this.GroupBox_Create_Player.Controls.Add(this.Label_Race);
            this.GroupBox_Create_Player.Controls.Add(this.Label_Role);
            this.GroupBox_Create_Player.Controls.Add(this.ComboBox_Player_Race);
            this.GroupBox_Create_Player.Controls.Add(this.ComboBox_Player_Role);
            this.GroupBox_Create_Player.Controls.Add(this.Label_Player_Name);
            this.GroupBox_Create_Player.Controls.Add(this.Label_Class);
            this.GroupBox_Create_Player.Controls.Add(this.Button_Add_Player);
            this.GroupBox_Create_Player.Controls.Add(this.ComboBox_Player_Class);
            this.GroupBox_Create_Player.Controls.Add(this.Textbox_Player_Name);
            this.GroupBox_Create_Player.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox_Create_Player.Location = new System.Drawing.Point(12, 230);
            this.GroupBox_Create_Player.Name = "GroupBox_Create_Player";
            this.GroupBox_Create_Player.Size = new System.Drawing.Size(394, 141);
            this.GroupBox_Create_Player.TabIndex = 4;
            this.GroupBox_Create_Player.TabStop = false;
            this.GroupBox_Create_Player.Text = "Create New Player";
            // 
            // Label_Race
            // 
            this.Label_Race.AutoSize = true;
            this.Label_Race.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Race.Location = new System.Drawing.Point(136, 24);
            this.Label_Race.Name = "Label_Race";
            this.Label_Race.Size = new System.Drawing.Size(33, 13);
            this.Label_Race.TabIndex = 13;
            this.Label_Race.Text = "Race";
            // 
            // Label_Role
            // 
            this.Label_Role.AutoSize = true;
            this.Label_Role.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Role.Location = new System.Drawing.Point(136, 72);
            this.Label_Role.Name = "Label_Role";
            this.Label_Role.Size = new System.Drawing.Size(29, 13);
            this.Label_Role.TabIndex = 12;
            this.Label_Role.Text = "Role";
            // 
            // ComboBox_Player_Race
            // 
            this.ComboBox_Player_Race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Player_Race.FormattingEnabled = true;
            this.ComboBox_Player_Race.Location = new System.Drawing.Point(137, 39);
            this.ComboBox_Player_Race.Name = "ComboBox_Player_Race";
            this.ComboBox_Player_Race.Size = new System.Drawing.Size(144, 21);
            this.ComboBox_Player_Race.TabIndex = 11;
            // 
            // ComboBox_Player_Role
            // 
            this.ComboBox_Player_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Player_Role.FormattingEnabled = true;
            this.ComboBox_Player_Role.Location = new System.Drawing.Point(137, 88);
            this.ComboBox_Player_Role.Name = "ComboBox_Player_Role";
            this.ComboBox_Player_Role.Size = new System.Drawing.Size(144, 21);
            this.ComboBox_Player_Role.TabIndex = 10;
            // 
            // Label_Player_Name
            // 
            this.Label_Player_Name.AutoSize = true;
            this.Label_Player_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Player_Name.Location = new System.Drawing.Point(8, 24);
            this.Label_Player_Name.Name = "Label_Player_Name";
            this.Label_Player_Name.Size = new System.Drawing.Size(67, 13);
            this.Label_Player_Name.TabIndex = 9;
            this.Label_Player_Name.Text = "Player Name";
            // 
            // Label_Class
            // 
            this.Label_Class.AutoSize = true;
            this.Label_Class.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Class.Location = new System.Drawing.Point(8, 72);
            this.Label_Class.Name = "Label_Class";
            this.Label_Class.Size = new System.Drawing.Size(32, 13);
            this.Label_Class.TabIndex = 8;
            this.Label_Class.Text = "Class";
            // 
            // Button_Add_Player
            // 
            this.Button_Add_Player.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Add_Player.Location = new System.Drawing.Point(303, 37);
            this.Button_Add_Player.Name = "Button_Add_Player";
            this.Button_Add_Player.Size = new System.Drawing.Size(71, 23);
            this.Button_Add_Player.TabIndex = 8;
            this.Button_Add_Player.Text = "Add Player";
            this.Button_Add_Player.UseVisualStyleBackColor = true;
            this.Button_Add_Player.Click += new System.EventHandler(this.Button_Add_Player_Click);
            // 
            // ComboBox_Player_Class
            // 
            this.ComboBox_Player_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Player_Class.FormattingEnabled = true;
            this.ComboBox_Player_Class.Location = new System.Drawing.Point(7, 88);
            this.ComboBox_Player_Class.Name = "ComboBox_Player_Class";
            this.ComboBox_Player_Class.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Player_Class.TabIndex = 1;
            this.ComboBox_Player_Class.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Player_Class_SelectedIndexChanged);
            // 
            // Textbox_Player_Name
            // 
            this.Textbox_Player_Name.Location = new System.Drawing.Point(7, 40);
            this.Textbox_Player_Name.Name = "Textbox_Player_Name";
            this.Textbox_Player_Name.Size = new System.Drawing.Size(121, 20);
            this.Textbox_Player_Name.TabIndex = 0;
            // 
            // GroupBox_Create_Guild
            // 
            this.GroupBox_Create_Guild.Controls.Add(this.Button_Add_Guild);
            this.GroupBox_Create_Guild.Controls.Add(this.Label_Guild_Server);
            this.GroupBox_Create_Guild.Controls.Add(this.Label_Guild_Type);
            this.GroupBox_Create_Guild.Controls.Add(this.ComboBox_Guild_Server);
            this.GroupBox_Create_Guild.Controls.Add(this.ComboBox_Guild_Type);
            this.GroupBox_Create_Guild.Controls.Add(this.Label_Guild_Box);
            this.GroupBox_Create_Guild.Controls.Add(this.Textbox_Guild_Name);
            this.GroupBox_Create_Guild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox_Create_Guild.Location = new System.Drawing.Point(12, 386);
            this.GroupBox_Create_Guild.Name = "GroupBox_Create_Guild";
            this.GroupBox_Create_Guild.Size = new System.Drawing.Size(394, 141);
            this.GroupBox_Create_Guild.TabIndex = 14;
            this.GroupBox_Create_Guild.TabStop = false;
            this.GroupBox_Create_Guild.Text = "Create New Guild";
            // 
            // Button_Add_Guild
            // 
            this.Button_Add_Guild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Add_Guild.Location = new System.Drawing.Point(303, 37);
            this.Button_Add_Guild.Name = "Button_Add_Guild";
            this.Button_Add_Guild.Size = new System.Drawing.Size(71, 23);
            this.Button_Add_Guild.TabIndex = 15;
            this.Button_Add_Guild.Text = "Add Guild";
            this.Button_Add_Guild.UseVisualStyleBackColor = true;
            this.Button_Add_Guild.Click += new System.EventHandler(this.Button_Add_Guild_Click);
            // 
            // Label_Guild_Server
            // 
            this.Label_Guild_Server.AutoSize = true;
            this.Label_Guild_Server.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Guild_Server.Location = new System.Drawing.Point(136, 24);
            this.Label_Guild_Server.Name = "Label_Guild_Server";
            this.Label_Guild_Server.Size = new System.Drawing.Size(38, 13);
            this.Label_Guild_Server.TabIndex = 13;
            this.Label_Guild_Server.Text = "Server";
            // 
            // Label_Guild_Type
            // 
            this.Label_Guild_Type.AutoSize = true;
            this.Label_Guild_Type.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Guild_Type.Location = new System.Drawing.Point(136, 72);
            this.Label_Guild_Type.Name = "Label_Guild_Type";
            this.Label_Guild_Type.Size = new System.Drawing.Size(31, 13);
            this.Label_Guild_Type.TabIndex = 12;
            this.Label_Guild_Type.Text = "Type";
            // 
            // ComboBox_Guild_Server
            // 
            this.ComboBox_Guild_Server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Guild_Server.FormattingEnabled = true;
            this.ComboBox_Guild_Server.Location = new System.Drawing.Point(137, 39);
            this.ComboBox_Guild_Server.Name = "ComboBox_Guild_Server";
            this.ComboBox_Guild_Server.Size = new System.Drawing.Size(144, 21);
            this.ComboBox_Guild_Server.TabIndex = 11;
            // 
            // ComboBox_Guild_Type
            // 
            this.ComboBox_Guild_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Guild_Type.FormattingEnabled = true;
            this.ComboBox_Guild_Type.Location = new System.Drawing.Point(137, 88);
            this.ComboBox_Guild_Type.Name = "ComboBox_Guild_Type";
            this.ComboBox_Guild_Type.Size = new System.Drawing.Size(144, 21);
            this.ComboBox_Guild_Type.TabIndex = 10;
            // 
            // Label_Guild_Box
            // 
            this.Label_Guild_Box.AutoSize = true;
            this.Label_Guild_Box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Guild_Box.Location = new System.Drawing.Point(8, 24);
            this.Label_Guild_Box.Name = "Label_Guild_Box";
            this.Label_Guild_Box.Size = new System.Drawing.Size(62, 13);
            this.Label_Guild_Box.TabIndex = 9;
            this.Label_Guild_Box.Text = "Guild Name";
            // 
            // Textbox_Guild_Name
            // 
            this.Textbox_Guild_Name.Location = new System.Drawing.Point(7, 40);
            this.Textbox_Guild_Name.Name = "Textbox_Guild_Name";
            this.Textbox_Guild_Name.Size = new System.Drawing.Size(121, 20);
            this.Textbox_Guild_Name.TabIndex = 0;
            // 
            // Label_Output
            // 
            this.Label_Output.AutoSize = true;
            this.Label_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Output.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Output.Location = new System.Drawing.Point(14, 530);
            this.Label_Output.Name = "Label_Output";
            this.Label_Output.Size = new System.Drawing.Size(71, 25);
            this.Label_Output.TabIndex = 15;
            this.Label_Output.Text = "Output";
            // 
            // Label_Player_Textbox
            // 
            this.Label_Player_Textbox.AutoSize = true;
            this.Label_Player_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Player_Textbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Player_Textbox.Location = new System.Drawing.Point(449, 43);
            this.Label_Player_Textbox.Name = "Label_Player_Textbox";
            this.Label_Player_Textbox.Size = new System.Drawing.Size(60, 20);
            this.Label_Player_Textbox.TabIndex = 17;
            this.Label_Player_Textbox.Text = "Players";
            // 
            // Label_Guild_Textbox
            // 
            this.Label_Guild_Textbox.AutoSize = true;
            this.Label_Guild_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Guild_Textbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Guild_Textbox.Location = new System.Drawing.Point(730, 43);
            this.Label_Guild_Textbox.Name = "Label_Guild_Textbox";
            this.Label_Guild_Textbox.Size = new System.Drawing.Size(54, 20);
            this.Label_Guild_Textbox.TabIndex = 19;
            this.Label_Guild_Textbox.Text = "Guilds";
            // 
            // ListBox_Players
            // 
            this.ListBox_Players.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Players.FormattingEnabled = true;
            this.ListBox_Players.ItemHeight = 14;
            this.ListBox_Players.Location = new System.Drawing.Point(453, 67);
            this.ListBox_Players.Name = "ListBox_Players";
            this.ListBox_Players.Size = new System.Drawing.Size(237, 452);
            this.ListBox_Players.TabIndex = 20;
            // 
            // ListBox_Guilds
            // 
            this.ListBox_Guilds.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Guilds.FormattingEnabled = true;
            this.ListBox_Guilds.ItemHeight = 14;
            this.ListBox_Guilds.Location = new System.Drawing.Point(734, 66);
            this.ListBox_Guilds.Name = "ListBox_Guilds";
            this.ListBox_Guilds.Size = new System.Drawing.Size(281, 452);
            this.ListBox_Guilds.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1038, 670);
            this.Controls.Add(this.ListBox_Guilds);
            this.Controls.Add(this.ListBox_Players);
            this.Controls.Add(this.Label_Guild_Textbox);
            this.Controls.Add(this.Label_Player_Textbox);
            this.Controls.Add(this.Label_Output);
            this.Controls.Add(this.GroupBox_Create_Guild);
            this.Controls.Add(this.GroupBox_Create_Player);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.GroupBox_Management);
            this.Controls.Add(this.TextBox_Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox_Management.ResumeLayout(false);
            this.GroupBox_Management.PerformLayout();
            this.GroupBox_Create_Player.ResumeLayout(false);
            this.GroupBox_Create_Player.PerformLayout();
            this.GroupBox_Create_Guild.ResumeLayout(false);
            this.GroupBox_Create_Guild.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.RichTextBox TextBox_Output;
        private System.Windows.Forms.GroupBox GroupBox_Management;
        private System.Windows.Forms.Label Label_Search_Guild;
        private System.Windows.Forms.Label Label_Search_Player;
        private System.Windows.Forms.TextBox Textbox_Search_Guild;
        private System.Windows.Forms.TextBox Textbox_Search_Player;
        private System.Windows.Forms.Button Button_Apply_Search;
        private System.Windows.Forms.Button Button_Leave_Guild;
        private System.Windows.Forms.Button Button_Join_Guild;
        private System.Windows.Forms.Button Button_Disband_Guild;
        private System.Windows.Forms.Button Button_Print_Guild;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.GroupBox GroupBox_Create_Player;
        private System.Windows.Forms.Label Label_Race;
        private System.Windows.Forms.Label Label_Role;
        private System.Windows.Forms.ComboBox ComboBox_Player_Race;
        private System.Windows.Forms.ComboBox ComboBox_Player_Role;
        private System.Windows.Forms.Label Label_Player_Name;
        private System.Windows.Forms.Label Label_Class;
        private System.Windows.Forms.ComboBox ComboBox_Player_Class;
        private System.Windows.Forms.TextBox Textbox_Player_Name;
        private System.Windows.Forms.Button Button_Add_Player;
        private System.Windows.Forms.GroupBox GroupBox_Create_Guild;
        private System.Windows.Forms.Button Button_Add_Guild;
        private System.Windows.Forms.Label Label_Guild_Server;
        private System.Windows.Forms.Label Label_Guild_Type;
        private System.Windows.Forms.ComboBox ComboBox_Guild_Server;
        private System.Windows.Forms.ComboBox ComboBox_Guild_Type;
        private System.Windows.Forms.Label Label_Guild_Box;
        private System.Windows.Forms.TextBox Textbox_Guild_Name;
        private System.Windows.Forms.Label Label_Output;
        private System.Windows.Forms.Label Label_Player_Textbox;
        private System.Windows.Forms.Label Label_Guild_Textbox;
        private System.Windows.Forms.ListBox ListBox_Players;
        private System.Windows.Forms.ListBox ListBox_Guilds;
    }
}