namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.names_listbox = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._school = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.names_listbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // names_listbox
            // 
            this.names_listbox.AllowUserToResizeRows = false;
            this.names_listbox.AutoGenerateColumns = false;
            this.names_listbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.names_listbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._name,
            this._age,
            this._division,
            this._school});
            this.names_listbox.DataSource = this.personBindingSource;
            this.names_listbox.Location = new System.Drawing.Point(0, 0);
            this.names_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.names_listbox.Name = "names_listbox";
            this.names_listbox.RowTemplate.Height = 24;
            this.names_listbox.Size = new System.Drawing.Size(460, 165);
            this.names_listbox.TabIndex = 6;
            this.names_listbox.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.names_listbox_RowLeave);
            // 
            // _name
            // 
            this._name.DataPropertyName = "string";
            this._name.HeaderText = "Name";
            this._name.Name = "_name";
            // 
            // _age
            // 
            this._age.DataPropertyName = "int";
            this._age.HeaderText = "Age";
            this._age.Name = "_age";
            // 
            // _division
            // 
            this._division.DataPropertyName = "int";
            this._division.HeaderText = "Division";
            this._division.Name = "_division";
            // 
            // _school
            // 
            this._school.DataPropertyName = "string";
            this._school.HeaderText = "School";
            this._school.Name = "_school";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 205);
            this.Controls.Add(this.names_listbox);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.names_listbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView names_listbox;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _age;
        private System.Windows.Forms.DataGridViewTextBoxColumn _division;
        private System.Windows.Forms.DataGridViewTextBoxColumn _school;
	}
}

