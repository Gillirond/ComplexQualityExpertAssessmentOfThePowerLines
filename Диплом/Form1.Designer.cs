namespace Диплом
{
    partial class Form1
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
            this.MethodButton = new System.Windows.Forms.Button();
            this.ExcelBrowseButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FindYButton = new System.Windows.Forms.Button();
            this.ExcelAddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HelpButton_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HelpButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AlterParamsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MethodButton
            // 
            this.MethodButton.Enabled = false;
            this.MethodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodButton.Location = new System.Drawing.Point(11, 80);
            this.MethodButton.Name = "MethodButton";
            this.MethodButton.Size = new System.Drawing.Size(124, 82);
            this.MethodButton.TabIndex = 0;
            this.MethodButton.Text = "Побудувати базу правил та функції приналежності";
            this.MethodButton.UseVisualStyleBackColor = true;
            this.MethodButton.Click += new System.EventHandler(this.MethodButton_Click);
            // 
            // ExcelBrowseButton
            // 
            this.ExcelBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcelBrowseButton.Location = new System.Drawing.Point(13, 112);
            this.ExcelBrowseButton.Name = "ExcelBrowseButton";
            this.ExcelBrowseButton.Size = new System.Drawing.Size(158, 62);
            this.ExcelBrowseButton.TabIndex = 1;
            this.ExcelBrowseButton.Text = "Обрати файл експертних оцінок стану ПЛ";
            this.ExcelBrowseButton.UseVisualStyleBackColor = true;
            this.ExcelBrowseButton.Click += new System.EventHandler(this.ExcelFileButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePathTextBox.Location = new System.Drawing.Point(13, 10);
            this.filePathTextBox.Multiline = true;
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(158, 96);
            this.filePathTextBox.TabIndex = 2;
            this.filePathTextBox.TextChanged += new System.EventHandler(this.filePathTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.FindYButton);
            this.panel1.Controls.Add(this.ExcelAddButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.MethodButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(2, 279);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 184);
            this.panel1.TabIndex = 3;
            // 
            // FindYButton
            // 
            this.FindYButton.Enabled = false;
            this.FindYButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindYButton.Location = new System.Drawing.Point(145, 79);
            this.FindYButton.Name = "FindYButton";
            this.FindYButton.Size = new System.Drawing.Size(137, 82);
            this.FindYButton.TabIndex = 14;
            this.FindYButton.Text = "Знайти комплексну якісну оцінку технічного стану ПЛ";
            this.FindYButton.UseVisualStyleBackColor = true;
            this.FindYButton.Click += new System.EventHandler(this.FindYButton_Click);
            // 
            // ExcelAddButton
            // 
            this.ExcelAddButton.Enabled = false;
            this.ExcelAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcelAddButton.Location = new System.Drawing.Point(651, 79);
            this.ExcelAddButton.Name = "ExcelAddButton";
            this.ExcelAddButton.Size = new System.Drawing.Size(160, 82);
            this.ExcelAddButton.TabIndex = 6;
            this.ExcelAddButton.Text = "Додати отриманий рядок до файлу експертних оцінок";
            this.ExcelAddButton.UseVisualStyleBackColor = true;
            this.ExcelAddButton.Click += new System.EventHandler(this.ExcelAddButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(284, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Комплексна якісна оцінка технічного стану ПЛ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(787, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "КДА";
            this.toolTip6.SetToolTip(this.label6, "коефіцієнт дефектності арматури");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(648, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "КДІ";
            this.toolTip5.SetToolTip(this.label5, "коефіцієнт дефектності ізоляторів");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(499, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "КДТ";
            this.toolTip4.SetToolTip(this.label4, "коефіцієнт дефектності тросів");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(350, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "КДП";
            this.toolTip3.SetToolTip(this.label3, "коефіцієнт дефектності проводів");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(201, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "КДФ";
            this.toolTip2.SetToolTip(this.label2, "коефіцієнт дефектності фундаментів");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "КДО";
            this.toolTip1.SetToolTip(this.label1, "коефіцієнт дефектності опор");
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(333, 139);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(200, 22);
            this.textBox7.TabIndex = 6;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(740, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(130, 22);
            this.textBox6.TabIndex = 5;
            this.toolTip2.SetToolTip(this.textBox6, "коефіцієнт дефектності арматури");
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(596, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 22);
            this.textBox5.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBox5, "коефіцієнт дефектності ізоляторів");
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(448, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 22);
            this.textBox4.TabIndex = 3;
            this.HelpButton_toolTip.SetToolTip(this.textBox4, "коефіцієнт дефектності тросів");
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(300, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 2;
            this.toolTip3.SetToolTip(this.textBox3, "коефіцієнт дефектності проводів");
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(152, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 1;
            this.toolTip6.SetToolTip(this.textBox2, "коефіцієнт дефектності фундаментів");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(4, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 0;
            this.toolTip5.SetToolTip(this.textBox1, "коефіцієнт дефектності опор");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(306, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Введіть коефіцієнти дефектності ПЛ";
            // 
            // HelpButton
            // 
            this.HelpButton.BackgroundImage = global::Диплом.Properties.Resources.Vista_Help_thumb_7AEAB696;
            this.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HelpButton.Location = new System.Drawing.Point(832, 9);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(1);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(40, 40);
            this.HelpButton.TabIndex = 4;
            this.HelpButton_toolTip.SetToolTip(this.HelpButton, "Довідка");
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Диплом.Properties.Resources.LEP_1_1140x560_1;
            this.pictureBox1.Location = new System.Drawing.Point(206, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AlterParamsButton
            // 
            this.AlterParamsButton.Enabled = false;
            this.AlterParamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlterParamsButton.Location = new System.Drawing.Point(13, 174);
            this.AlterParamsButton.Margin = new System.Windows.Forms.Padding(0);
            this.AlterParamsButton.Name = "AlterParamsButton";
            this.AlterParamsButton.Size = new System.Drawing.Size(158, 33);
            this.AlterParamsButton.TabIndex = 7;
            this.AlterParamsButton.Text = "Змінити стандартні параметри перед виконанням алгоритму";
            this.AlterParamsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AlterParamsButton.UseVisualStyleBackColor = true;
            this.AlterParamsButton.Visible = false;
            this.AlterParamsButton.Click += new System.EventHandler(this.AlterParamsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 464);
            this.Controls.Add(this.AlterParamsButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.ExcelBrowseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HelpButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Комплексне експертне оцінювання стану ліній електропередач";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MethodButton;
        private System.Windows.Forms.Button ExcelBrowseButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExcelAddButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip HelpButton_toolTip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Button AlterParamsButton;
        private System.Windows.Forms.Button FindYButton;
    }
}

