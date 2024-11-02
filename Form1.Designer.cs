namespace WindowsFormsApp4
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
            this.comboBoxTasks = new System.Windows.Forms.ComboBox();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.textBoxStartingLetter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkId = new System.Windows.Forms.CheckBox();
            this.chkCountryName = new System.Windows.Forms.CheckBox();
            this.chkPopulation = new System.Windows.Forms.CheckBox();
            this.chkArea = new System.Windows.Forms.CheckBox();
            this.chkContinent = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTasks
            // 
            this.comboBoxTasks.FormattingEnabled = true;
            this.comboBoxTasks.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTasks.Name = "comboBoxTasks";
            this.comboBoxTasks.Size = new System.Drawing.Size(389, 21);
            this.comboBoxTasks.TabIndex = 0;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(776, 308);
            this.dataGridViewResults.TabIndex = 1;
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(12, 39);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(389, 20);
            this.textBoxCountryName.TabIndex = 2;
            // 
            // textBoxStartingLetter
            // 
            this.textBoxStartingLetter.Location = new System.Drawing.Point(407, 39);
            this.textBoxStartingLetter.Name = "textBoxStartingLetter";
            this.textBoxStartingLetter.Size = new System.Drawing.Size(389, 20);
            this.textBoxStartingLetter.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // chkId
            // 
            this.chkId.AutoSize = true;
            this.chkId.Location = new System.Drawing.Point(43, 78);
            this.chkId.Name = "chkId";
            this.chkId.Size = new System.Drawing.Size(35, 17);
            this.chkId.TabIndex = 5;
            this.chkId.Text = "Id";
            this.chkId.UseVisualStyleBackColor = true;
            // 
            // chkCountryName
            // 
            this.chkCountryName.AutoSize = true;
            this.chkCountryName.Location = new System.Drawing.Point(84, 78);
            this.chkCountryName.Name = "chkCountryName";
            this.chkCountryName.Size = new System.Drawing.Size(90, 17);
            this.chkCountryName.TabIndex = 6;
            this.chkCountryName.Text = "CountryName";
            this.chkCountryName.UseVisualStyleBackColor = true;
            // 
            // chkPopulation
            // 
            this.chkPopulation.AutoSize = true;
            this.chkPopulation.Location = new System.Drawing.Point(180, 78);
            this.chkPopulation.Name = "chkPopulation";
            this.chkPopulation.Size = new System.Drawing.Size(76, 17);
            this.chkPopulation.TabIndex = 7;
            this.chkPopulation.Text = "Population";
            this.chkPopulation.UseVisualStyleBackColor = true;
            // 
            // chkArea
            // 
            this.chkArea.AutoSize = true;
            this.chkArea.Location = new System.Drawing.Point(253, 78);
            this.chkArea.Name = "chkArea";
            this.chkArea.Size = new System.Drawing.Size(48, 17);
            this.chkArea.TabIndex = 8;
            this.chkArea.Text = "Area";
            this.chkArea.UseVisualStyleBackColor = true;
            // 
            // chkContinent
            // 
            this.chkContinent.AutoSize = true;
            this.chkContinent.Location = new System.Drawing.Point(307, 78);
            this.chkContinent.Name = "chkContinent";
            this.chkContinent.Size = new System.Drawing.Size(71, 17);
            this.chkContinent.TabIndex = 9;
            this.chkContinent.Text = "Continent";
            this.chkContinent.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDisplayData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkContinent);
            this.Controls.Add(this.chkArea);
            this.Controls.Add(this.chkPopulation);
            this.Controls.Add(this.chkCountryName);
            this.Controls.Add(this.chkId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStartingLetter);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.comboBoxTasks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTasks;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.TextBox textBoxStartingLetter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkId;
        private System.Windows.Forms.CheckBox chkCountryName;
        private System.Windows.Forms.CheckBox chkPopulation;
        private System.Windows.Forms.CheckBox chkArea;
        private System.Windows.Forms.CheckBox chkContinent;
        private System.Windows.Forms.Button button2;
    }
}

