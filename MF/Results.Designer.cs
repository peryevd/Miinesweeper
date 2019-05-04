namespace MF
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this._easy = new System.Windows.Forms.DataGridView();
            this._medium = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._hard = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.easy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // _easy
            // 
            this._easy.AllowUserToAddRows = false;
            this._easy.AllowUserToDeleteRows = false;
            this._easy.BackgroundColor = System.Drawing.SystemColors.Window;
            this._easy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._easy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._easy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.easy});
            this._easy.Location = new System.Drawing.Point(12, 133);
            this._easy.Name = "_easy";
            this._easy.ReadOnly = true;
            this._easy.Size = new System.Drawing.Size(144, 257);
            this._easy.TabIndex = 0;
            // 
            // _medium
            // 
            this._medium.AllowUserToAddRows = false;
            this._medium.AllowUserToDeleteRows = false;
            this._medium.BackgroundColor = System.Drawing.SystemColors.Window;
            this._medium.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._medium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._medium.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this._medium.Location = new System.Drawing.Point(182, 133);
            this._medium.Name = "_medium";
            this._medium.ReadOnly = true;
            this._medium.Size = new System.Drawing.Size(143, 257);
            this._medium.TabIndex = 1;
            this._medium.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._medium_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Средний";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // _hard
            // 
            this._hard.AllowUserToAddRows = false;
            this._hard.AllowUserToDeleteRows = false;
            this._hard.BackgroundColor = System.Drawing.SystemColors.Window;
            this._hard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._hard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._hard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this._hard.Enabled = false;
            this._hard.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._hard.Location = new System.Drawing.Point(349, 133);
            this._hard.Name = "_hard";
            this._hard.ReadOnly = true;
            this._hard.Size = new System.Drawing.Size(143, 257);
            this._hard.TabIndex = 2;
            this._hard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._hard_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Сложный";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Время, потраченное на прохождение.";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MF.Properties.Resources.back_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(397, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MF.Properties.Resources.results1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(509, 602);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // easy
            // 
            this.easy.HeaderText = "Легкий";
            this.easy.Name = "easy";
            this.easy.ReadOnly = true;
            this.easy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 596);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._hard);
            this.Controls.Add(this._medium);
            this.Controls.Add(this._easy);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this._easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _easy;
        private System.Windows.Forms.DataGridView _medium;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView _hard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn easy;
    }
}