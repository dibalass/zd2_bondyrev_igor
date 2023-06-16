
namespace zad2
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
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.add_button = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.numberPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(356, 93);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 26);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.Add_button);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИО,
            this.Телефон});
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(311, 376);
            this.table.TabIndex = 1;
            // 
            // ФИО
            // 
            this.ФИО.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            this.ФИО.Width = 59;
            // 
            // Телефон
            // 
            this.Телефон.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Телефон.HeaderText = "Телефон";
            this.Телефон.Name = "Телефон";
            this.Телефон.Width = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(356, 28);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(100, 20);
            this.FIO.TabIndex = 3;
            // 
            // numberPhone
            // 
            this.numberPhone.Location = new System.Drawing.Point(356, 67);
            this.numberPhone.Name = "numberPhone";
            this.numberPhone.Size = new System.Drawing.Size(100, 20);
            this.numberPhone.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Телефон";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(521, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(356, 394);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(93, 44);
            this.Save.TabIndex = 7;
            this.Save.Text = "Сохранить в файл";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(532, 35);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(100, 20);
            this.search_text.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Поиск";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Search);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(356, 368);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 20);
            this.fileName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Имя файла";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(356, 147);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(93, 55);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Удалить выбранную строчку";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.numberPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.add_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Телефон;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox numberPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete_button;
    }
}

