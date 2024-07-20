namespace LaTriX
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.TextBox textBoxLaTeXOutput;
        private System.Windows.Forms.Label labelArrow;
        private System.Windows.Forms.Label columnsLabel;
        private System.Windows.Forms.Label Rows;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelNachLatex;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownAlignment;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCenter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLeft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRight;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.Panel panelToolStrip;
        private System.Windows.Forms.ToolTip toolTip;

        /// <summary>
        /// Initialisiert die Form-Komponenten.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.textBoxLaTeXOutput = new System.Windows.Forms.TextBox();
            this.labelArrow = new System.Windows.Forms.Label();
            this.columnsLabel = new System.Windows.Forms.Label();
            this.Rows = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelNachLatex = new System.Windows.Forms.Label();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownAlignment = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.panelToolStrip = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.panelToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(13, 156);
            this.dataGridViewMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidth = 51;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(586, 591);
            this.dataGridViewMatrix.TabIndex = 0;
            this.dataGridViewMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_CellValueChanged);
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(68, 92);
            this.numericUpDownRows.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(107, 22);
            this.numericUpDownRows.TabIndex = 1;
            this.numericUpDownRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.NumericUpDownRows_ValueChanged);
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.Location = new System.Drawing.Point(220, 92);
            this.numericUpDownColumns.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Size = new System.Drawing.Size(107, 22);
            this.numericUpDownColumns.TabIndex = 2;
            this.numericUpDownColumns.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownColumns.ValueChanged += new System.EventHandler(this.NumericUpDownColumns_ValueChanged);
            // 
            // textBoxLaTeXOutput
            // 
            this.textBoxLaTeXOutput.Location = new System.Drawing.Point(780, 170);
            this.textBoxLaTeXOutput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLaTeXOutput.Multiline = true;
            this.textBoxLaTeXOutput.Name = "textBoxLaTeXOutput";
            this.textBoxLaTeXOutput.Size = new System.Drawing.Size(370, 591);
            this.textBoxLaTeXOutput.TabIndex = 4;
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrow.Location = new System.Drawing.Point(607, 463);
            this.labelArrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(150, 25);
            this.labelArrow.TabIndex = 5;
            this.labelArrow.Text = "------------------>";
            // 
            // columnsLabel
            // 
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsLabel.Location = new System.Drawing.Point(225, 72);
            this.columnsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(64, 16);
            this.columnsLabel.TabIndex = 6;
            this.columnsLabel.Text = "Spalten:";
            // 
            // Rows
            // 
            this.Rows.AutoSize = true;
            this.Rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rows.Location = new System.Drawing.Point(65, 72);
            this.Rows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(54, 16);
            this.Rows.TabIndex = 7;
            this.Rows.Text = "Zeilen:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(183, 94);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 20);
            this.labelX.TabIndex = 8;
            this.labelX.Text = "X";
            // 
            // labelNachLatex
            // 
            this.labelNachLatex.AutoSize = true;
            this.labelNachLatex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNachLatex.Location = new System.Drawing.Point(626, 443);
            this.labelNachLatex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNachLatex.Name = "labelNachLatex";
            this.labelNachLatex.Size = new System.Drawing.Size(112, 20);
            this.labelNachLatex.TabIndex = 9;
            this.labelNachLatex.Text = "Nach LaTeX";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownAlignment,
            this.toolStripButtonCopy});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 42);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(370, 27);
            this.toolStripMenu.TabIndex = 10;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripDropDownAlignment
            // 
            this.toolStripDropDownAlignment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownAlignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCenter,
            this.toolStripMenuItemLeft,
            this.toolStripMenuItemRight});
            this.toolStripDropDownAlignment.Name = "toolStripDropDownAlignment";
            this.toolStripDropDownAlignment.Size = new System.Drawing.Size(92, 24);
            this.toolStripDropDownAlignment.Text = "Ausrichtung";
            // 
            // toolStripMenuItemCenter
            // 
            this.toolStripMenuItemCenter.Name = "toolStripMenuItemCenter";
            this.toolStripMenuItemCenter.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItemCenter.Text = "Zentriert";
            this.toolStripMenuItemCenter.Click += new System.EventHandler(this.ToolStripMenuItemCenter_Click);
            // 
            // toolStripMenuItemLeft
            // 
            this.toolStripMenuItemLeft.Name = "toolStripMenuItemLeft";
            this.toolStripMenuItemLeft.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItemLeft.Text = "Linksbündig";
            this.toolStripMenuItemLeft.Click += new System.EventHandler(this.ToolStripMenuItemLeft_Click);
            // 
            // toolStripMenuItemRight
            // 
            this.toolStripMenuItemRight.Name = "toolStripMenuItemRight";
            this.toolStripMenuItemRight.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItemRight.Text = "Rechtsbündig";
            this.toolStripMenuItemRight.Click += new System.EventHandler(this.ToolStripMenuItemRight_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(187, 24);
            this.toolStripButtonCopy.Text = "Kopieren in Zwischenablage";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.ToolStripButtonCopy_Click);
            // 
            // panelToolStrip
            // 
            this.panelToolStrip.Controls.Add(this.toolStripMenu);
            this.panelToolStrip.Location = new System.Drawing.Point(780, 45);
            this.panelToolStrip.Name = "panelToolStrip";
            this.panelToolStrip.Size = new System.Drawing.Size(370, 69);
            this.panelToolStrip.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 799);
            this.Controls.Add(this.panelToolStrip);
            this.Controls.Add(this.labelNachLatex);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.columnsLabel);
            this.Controls.Add(this.labelArrow);
            this.Controls.Add(this.textBoxLaTeXOutput);
            this.Controls.Add(this.numericUpDownColumns);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LaTriX";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelToolStrip.ResumeLayout(false);
            this.panelToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
