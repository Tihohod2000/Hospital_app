namespace Project_of_store
{
    partial class Mouse
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mouse));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_doctor = new System.Windows.Forms.Button();
            this.show_list = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_doctor = new System.Windows.Forms.TextBox();
            this.disease = new System.Windows.Forms.TextBox();
            this.father = new System.Windows.Forms.TextBox();
            this.old = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.delete_info = new System.Windows.Forms.Button();
            this.id_patient = new System.Windows.Forms.TextBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.dataGridView1);
            this.bunifuPanel1.Controls.Add(this.add_doctor);
            this.bunifuPanel1.Controls.Add(this.delete_info);
            this.bunifuPanel1.Controls.Add(this.show_list);
            this.bunifuPanel1.Controls.Add(this.label7);
            this.bunifuPanel1.Controls.Add(this.label6);
            this.bunifuPanel1.Controls.Add(this.label5);
            this.bunifuPanel1.Controls.Add(this.label3);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.id_patient);
            this.bunifuPanel1.Controls.Add(this.id_doctor);
            this.bunifuPanel1.Controls.Add(this.disease);
            this.bunifuPanel1.Controls.Add(this.father);
            this.bunifuPanel1.Controls.Add(this.old);
            this.bunifuPanel1.Controls.Add(this.city);
            this.bunifuPanel1.Controls.Add(this.name);
            this.bunifuPanel1.Controls.Add(this.lastName);
            this.bunifuPanel1.Controls.Add(this.gunaControlBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1141, 615);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 208);
            this.dataGridView1.TabIndex = 27;
            // 
            // add_doctor
            // 
            this.add_doctor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.add_doctor.Location = new System.Drawing.Point(128, 276);
            this.add_doctor.Name = "add_doctor";
            this.add_doctor.Size = new System.Drawing.Size(274, 55);
            this.add_doctor.TabIndex = 25;
            this.add_doctor.Text = "Добавить пациента";
            this.add_doctor.UseVisualStyleBackColor = true;
            this.add_doctor.Click += new System.EventHandler(this.add_patient_Click);
            // 
            // show_list
            // 
            this.show_list.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.show_list.Location = new System.Drawing.Point(408, 276);
            this.show_list.Name = "show_list";
            this.show_list.Size = new System.Drawing.Size(297, 55);
            this.show_list.TabIndex = 26;
            this.show_list.Text = "Показать список пациентов";
            this.show_list.UseVisualStyleBackColor = true;
            this.show_list.Click += new System.EventHandler(this.show_list_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(856, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Id Доктора";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(630, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Заболевание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(370, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(856, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(128, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Фамилия";
            // 
            // id_doctor
            // 
            this.id_doctor.Location = new System.Drawing.Point(861, 192);
            this.id_doctor.Multiline = true;
            this.id_doctor.Name = "id_doctor";
            this.id_doctor.Size = new System.Drawing.Size(143, 43);
            this.id_doctor.TabIndex = 13;
            // 
            // disease
            // 
            this.disease.Location = new System.Drawing.Point(635, 192);
            this.disease.Multiline = true;
            this.disease.Name = "disease";
            this.disease.Size = new System.Drawing.Size(143, 43);
            this.disease.TabIndex = 13;
            // 
            // father
            // 
            this.father.Location = new System.Drawing.Point(861, 82);
            this.father.Multiline = true;
            this.father.Name = "father";
            this.father.Size = new System.Drawing.Size(143, 43);
            this.father.TabIndex = 14;
            // 
            // old
            // 
            this.old.Location = new System.Drawing.Point(375, 192);
            this.old.Multiline = true;
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(143, 43);
            this.old.TabIndex = 15;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(128, 192);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(143, 43);
            this.city.TabIndex = 16;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(497, 82);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(143, 43);
            this.name.TabIndex = 17;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(128, 82);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(143, 43);
            this.lastName.TabIndex = 18;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1084, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 8;
            // 
            // delete_info
            // 
            this.delete_info.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.delete_info.Location = new System.Drawing.Point(711, 276);
            this.delete_info.Name = "delete_info";
            this.delete_info.Size = new System.Drawing.Size(235, 55);
            this.delete_info.TabIndex = 26;
            this.delete_info.Text = "Удалить пациента с ID";
            this.delete_info.UseVisualStyleBackColor = true;
            this.delete_info.Click += new System.EventHandler(this.delete_patient);
            // 
            // id_patient
            // 
            this.id_patient.Location = new System.Drawing.Point(964, 276);
            this.id_patient.Multiline = true;
            this.id_patient.Name = "id_patient";
            this.id_patient.Size = new System.Drawing.Size(60, 55);
            this.id_patient.TabIndex = 13;
            // 
            // Mouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1141, 615);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mouse";
            this.Text = "Form1";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_doctor;
        private System.Windows.Forms.Button show_list;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox disease;
        private System.Windows.Forms.TextBox father;
        private System.Windows.Forms.TextBox old;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id_doctor;
        private System.Windows.Forms.Button delete_info;
        private System.Windows.Forms.TextBox id_patient;
    }
}

