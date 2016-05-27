namespace Serialize_Lab
{
    partial class Settings
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
            this.checkSumComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameTextEdit = new System.Windows.Forms.TextBox();
            this.setSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkSumComboBox
            // 
            this.checkSumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkSumComboBox.FormattingEnabled = true;
            this.checkSumComboBox.Items.AddRange(new object[] {
            "Default"});
            this.checkSumComboBox.Location = new System.Drawing.Point(13, 62);
            this.checkSumComboBox.Name = "checkSumComboBox";
            this.checkSumComboBox.Size = new System.Drawing.Size(121, 21);
            this.checkSumComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите алгоритм просчета контрольной суммы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите путь для сохранения контрольной суммы";
            // 
            // fileNameTextEdit
            // 
            this.fileNameTextEdit.Location = new System.Drawing.Point(19, 146);
            this.fileNameTextEdit.Name = "fileNameTextEdit";
            this.fileNameTextEdit.Size = new System.Drawing.Size(115, 20);
            this.fileNameTextEdit.TabIndex = 3;
            // 
            // setSettingsButton
            // 
            this.setSettingsButton.Location = new System.Drawing.Point(235, 190);
            this.setSettingsButton.Name = "setSettingsButton";
            this.setSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.setSettingsButton.TabIndex = 4;
            this.setSettingsButton.Text = "Настроить";
            this.setSettingsButton.UseVisualStyleBackColor = true;
            this.setSettingsButton.Click += new System.EventHandler(this.setSettingsButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 241);
            this.Controls.Add(this.setSettingsButton);
            this.Controls.Add(this.fileNameTextEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkSumComboBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox checkSumComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNameTextEdit;
        private System.Windows.Forms.Button setSettingsButton;
    }
}