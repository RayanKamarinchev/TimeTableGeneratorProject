namespace TimeTableProj
{
    partial class NewTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTeacher));
            this.AddClass = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassChoice = new System.Windows.Forms.CheckedListBox();
            this.subject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddClass
            // 
            this.AddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddClass.Location = new System.Drawing.Point(169, 344);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(103, 30);
            this.AddClass.TabIndex = 8;
            this.AddClass.Text = "Добави";
            this.AddClass.UseVisualStyleBackColor = false;
            this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(112, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 23);
            this.name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Класове:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Предмет:";
            // 
            // ClassChoice
            // 
            this.ClassChoice.CheckOnClick = true;
            this.ClassChoice.FormattingEnabled = true;
            this.ClassChoice.Location = new System.Drawing.Point(112, 95);
            this.ClassChoice.Name = "ClassChoice";
            this.ClassChoice.Size = new System.Drawing.Size(120, 220);
            this.ClassChoice.TabIndex = 14;
            // 
            // subject
            // 
            this.subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subject.FormattingEnabled = true;
            this.subject.Location = new System.Drawing.Point(112, 54);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(120, 23);
            this.subject.TabIndex = 15;
            // 
            // NewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 386);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.ClassChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddClass);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTeacher";
            this.Text = "Нов учител";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewTeacher_FormClosing);
            this.Load += new System.EventHandler(this.NewTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddClass;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ClassChoice;
        private System.Windows.Forms.ComboBox subject;
    }
}