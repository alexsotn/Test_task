
namespace Test__Task
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
			this.label1 = new System.Windows.Forms.Label();
			this.Select_Combo = new System.Windows.Forms.ComboBox();
			this.Run_Bt = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Name_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cat_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(11, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Выпонить запрос:";
			// 
			// Select_Combo
			// 
			this.Select_Combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Select_Combo.FormattingEnabled = true;
			this.Select_Combo.Items.AddRange(new object[] {
            "LEFT OUTER JOIN",
            "RIGHT OUTER JOIN",
            "FULL OUTER JOIN",
            "LEFT OUTER JOIN с ограниничением",
            "RIGHT OUTER JOIN с ограниничением",
            " UNION ALL"});
			this.Select_Combo.Location = new System.Drawing.Point(164, 16);
			this.Select_Combo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Select_Combo.Name = "Select_Combo";
			this.Select_Combo.Size = new System.Drawing.Size(370, 28);
			this.Select_Combo.TabIndex = 1;
			// 
			// Run_Bt
			// 
			this.Run_Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Run_Bt.Location = new System.Drawing.Point(542, 16);
			this.Run_Bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Run_Bt.Name = "Run_Bt";
			this.Run_Bt.Size = new System.Drawing.Size(118, 28);
			this.Run_Bt.TabIndex = 2;
			this.Run_Bt.Text = "RUN";
			this.Run_Bt.UseVisualStyleBackColor = true;
			this.Run_Bt.Click += new System.EventHandler(this.Run_Bt_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_p,
            this.Price_P,
            this.N_Cat,
            this.Cat_ID});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 54);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(670, 340);
			this.dataGridView1.TabIndex = 3;
			// 
			// Name_p
			// 
			this.Name_p.DataPropertyName = "Name_product";
			this.Name_p.HeaderText = "Наименование продукта";
			this.Name_p.Name = "Name_p";
			// 
			// Price_P
			// 
			this.Price_P.DataPropertyName = "Price_product";
			this.Price_P.HeaderText = "Стоимость";
			this.Price_P.Name = "Price_P";
			// 
			// N_Cat
			// 
			this.N_Cat.DataPropertyName = "Name_Categories";
			this.N_Cat.HeaderText = "Наименование катег.";
			this.N_Cat.Name = "N_Cat";
			// 
			// Cat_ID
			// 
			this.Cat_ID.DataPropertyName = "UID_Categories";
			this.Cat_ID.HeaderText = "UID категории";
			this.Cat_ID.Name = "Cat_ID";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 394);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Run_Bt);
			this.Controls.Add(this.Select_Combo);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Test task";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Select_Combo;
		private System.Windows.Forms.Button Run_Bt;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name_p;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price_P;
		private System.Windows.Forms.DataGridViewTextBoxColumn N_Cat;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cat_ID;
	}
}

