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
            this._easy = new System.Windows.Forms.DataGridView();
            this.easy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._medium = new System.Windows.Forms.DataGridView();
            this._hard = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._hard)).BeginInit();
            this.SuspendLayout();
            // 
            // _easy
            // 
            this._easy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._easy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.easy});
            this._easy.Location = new System.Drawing.Point(29, 102);
            this._easy.Name = "_easy";
            this._easy.Size = new System.Drawing.Size(139, 257);
            this._easy.TabIndex = 0;
            // 
            // easy
            // 
            this.easy.HeaderText = "Легкий";
            this.easy.Name = "easy";
            this.easy.ReadOnly = true;
            // 
            // _medium
            // 
            this._medium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._medium.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this._medium.Location = new System.Drawing.Point(241, 102);
            this._medium.Name = "_medium";
            this._medium.Size = new System.Drawing.Size(139, 257);
            this._medium.TabIndex = 1;
            // 
            // _hard
            // 
            this._hard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._hard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this._hard.Location = new System.Drawing.Point(466, 102);
            this._hard.Name = "_hard";
            this._hard.Size = new System.Drawing.Size(139, 257);
            this._hard.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Средний";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Сложный";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 776);
            this.Controls.Add(this._hard);
            this.Controls.Add(this._medium);
            this.Controls.Add(this._easy);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this._easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._hard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _easy;
        private System.Windows.Forms.DataGridViewTextBoxColumn easy;
        private System.Windows.Forms.DataGridView _medium;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView _hard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}