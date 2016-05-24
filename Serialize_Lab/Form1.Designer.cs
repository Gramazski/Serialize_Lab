namespace Serialize_Lab
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
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.classesGroupBox = new System.Windows.Forms.GroupBox();
            this.steamboatButton = new System.Windows.Forms.Button();
            this.sailingButton = new System.Windows.Forms.Button();
            this.autoButton = new System.Windows.Forms.Button();
            this.railButton = new System.Windows.Forms.Button();
            this.planeButton = new System.Windows.Forms.Button();
            this.helicopterButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.describeGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.classesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(12, 12);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(136, 95);
            this.itemsListBox.TabIndex = 0;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // classesGroupBox
            // 
            this.classesGroupBox.Controls.Add(this.steamboatButton);
            this.classesGroupBox.Controls.Add(this.sailingButton);
            this.classesGroupBox.Controls.Add(this.autoButton);
            this.classesGroupBox.Controls.Add(this.railButton);
            this.classesGroupBox.Controls.Add(this.planeButton);
            this.classesGroupBox.Controls.Add(this.helicopterButton);
            this.classesGroupBox.Location = new System.Drawing.Point(532, 12);
            this.classesGroupBox.Name = "classesGroupBox";
            this.classesGroupBox.Size = new System.Drawing.Size(200, 231);
            this.classesGroupBox.TabIndex = 1;
            this.classesGroupBox.TabStop = false;
            this.classesGroupBox.Text = "Реализуемые классы";
            // 
            // steamboatButton
            // 
            this.steamboatButton.Location = new System.Drawing.Point(6, 183);
            this.steamboatButton.Name = "steamboatButton";
            this.steamboatButton.Size = new System.Drawing.Size(188, 23);
            this.steamboatButton.TabIndex = 5;
            this.steamboatButton.Text = "Пароход";
            this.steamboatButton.UseVisualStyleBackColor = true;
            this.steamboatButton.Click += new System.EventHandler(this.steamboatButton_Click);
            // 
            // sailingButton
            // 
            this.sailingButton.Location = new System.Drawing.Point(6, 154);
            this.sailingButton.Name = "sailingButton";
            this.sailingButton.Size = new System.Drawing.Size(188, 23);
            this.sailingButton.TabIndex = 4;
            this.sailingButton.Text = "Парусники";
            this.sailingButton.UseVisualStyleBackColor = true;
            this.sailingButton.Click += new System.EventHandler(this.sailingButton_Click);
            // 
            // autoButton
            // 
            this.autoButton.Location = new System.Drawing.Point(6, 125);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(188, 23);
            this.autoButton.TabIndex = 3;
            this.autoButton.Text = "Автомобиль";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // railButton
            // 
            this.railButton.Location = new System.Drawing.Point(6, 96);
            this.railButton.Name = "railButton";
            this.railButton.Size = new System.Drawing.Size(188, 23);
            this.railButton.TabIndex = 2;
            this.railButton.Text = "Поезд";
            this.railButton.UseVisualStyleBackColor = true;
            this.railButton.Click += new System.EventHandler(this.railButton_Click);
            // 
            // planeButton
            // 
            this.planeButton.Location = new System.Drawing.Point(6, 67);
            this.planeButton.Name = "planeButton";
            this.planeButton.Size = new System.Drawing.Size(188, 23);
            this.planeButton.TabIndex = 1;
            this.planeButton.Text = "Самолет";
            this.planeButton.UseVisualStyleBackColor = true;
            this.planeButton.Click += new System.EventHandler(this.planeButton_Click);
            // 
            // helicopterButton
            // 
            this.helicopterButton.Location = new System.Drawing.Point(6, 38);
            this.helicopterButton.Name = "helicopterButton";
            this.helicopterButton.Size = new System.Drawing.Size(188, 23);
            this.helicopterButton.TabIndex = 0;
            this.helicopterButton.Text = "Вертолет";
            this.helicopterButton.UseVisualStyleBackColor = true;
            this.helicopterButton.Click += new System.EventHandler(this.helicopterButton_Click);
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(538, 288);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(188, 23);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(538, 317);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(188, 23);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // describeGroupBox
            // 
            this.describeGroupBox.Location = new System.Drawing.Point(154, 12);
            this.describeGroupBox.Name = "describeGroupBox";
            this.describeGroupBox.Size = new System.Drawing.Size(372, 325);
            this.describeGroupBox.TabIndex = 2;
            this.describeGroupBox.TabStop = false;
            this.describeGroupBox.Text = "Описание элемента класса";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(539, 257);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Имя экземпляра";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(632, 254);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 349);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.describeGroupBox);
            this.Controls.Add(this.classesGroupBox);
            this.Controls.Add(this.itemsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.classesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.GroupBox classesGroupBox;
        private System.Windows.Forms.Button steamboatButton;
        private System.Windows.Forms.Button sailingButton;
        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Button railButton;
        private System.Windows.Forms.Button planeButton;
        private System.Windows.Forms.Button helicopterButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.GroupBox describeGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

