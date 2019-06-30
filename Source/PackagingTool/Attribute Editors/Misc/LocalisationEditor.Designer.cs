﻿namespace Alien_Isolation_Mod_Tools.Attribute_Editors.Misc
{
    partial class LocalisationEditor
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
            this.stringOut = new System.Windows.Forms.TextBox();
            this.selectedLanguage = new System.Windows.Forms.ComboBox();
            this.localisationTree = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringOut
            // 
            this.stringOut.Location = new System.Drawing.Point(528, 121);
            this.stringOut.Multiline = true;
            this.stringOut.Name = "stringOut";
            this.stringOut.Size = new System.Drawing.Size(442, 334);
            this.stringOut.TabIndex = 2;
            // 
            // selectedLanguage
            // 
            this.selectedLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedLanguage.FormattingEnabled = true;
            this.selectedLanguage.Location = new System.Drawing.Point(528, 69);
            this.selectedLanguage.Name = "selectedLanguage";
            this.selectedLanguage.Size = new System.Drawing.Size(442, 21);
            this.selectedLanguage.TabIndex = 5;
            this.selectedLanguage.SelectedIndexChanged += new System.EventHandler(this.selectedLanguage_SelectedIndexChanged);
            // 
            // localisationTree
            // 
            this.localisationTree.Location = new System.Drawing.Point(12, 53);
            this.localisationTree.Name = "localisationTree";
            this.localisationTree.Size = new System.Drawing.Size(510, 435);
            this.localisationTree.TabIndex = 6;
            this.localisationTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.localisationTree_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(442, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Language";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(299, 11);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(390, 29);
            this.label78.TabIndex = 414;
            this.label78.Text = "Alien: Isolation In-Game Text Editor";
            // 
            // LocalisationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 498);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.localisationTree);
            this.Controls.Add(this.selectedLanguage);
            this.Controls.Add(this.stringOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalisationEditor";
            this.Text = "Alien: Isolation In-Game Text Editor";
            this.Load += new System.EventHandler(this.LocalisationEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox stringOut;
        private System.Windows.Forms.ComboBox selectedLanguage;
        private System.Windows.Forms.TreeView localisationTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label78;
    }
}