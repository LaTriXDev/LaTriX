namespace LaTriX
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.TextBox textBoxLaTeXOutput;
        private System.Windows.Forms.Label columnsLabel;
        private System.Windows.Forms.Label Rows;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownAlignment;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCenter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLeft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRight;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.Panel panelToolStrip;
        private System.Windows.Forms.ToolTip toolTip;

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            textBoxLaTeXOutput = new System.Windows.Forms.TextBox();
            columnsLabel = new System.Windows.Forms.Label();
            Rows = new System.Windows.Forms.Label();
            labelX = new System.Windows.Forms.Label();
            toolStripMenu = new System.Windows.Forms.ToolStrip();
            toolStripDropDownAlignment = new System.Windows.Forms.ToolStripDropDownButton();
            toolStripMenuItemCenter = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemLeft = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemRight = new System.Windows.Forms.ToolStripMenuItem();
            toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            panelToolStrip = new System.Windows.Forms.Panel();
            toolTip = new System.Windows.Forms.ToolTip(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownColumns).BeginInit();
            toolStripMenu.SuspendLayout();
            panelToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrix.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewMatrix.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMatrix.Location = new System.Drawing.Point(13, 195);
            dataGridViewMatrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new System.Drawing.Size(605, 739);
            dataGridViewMatrix.TabIndex = 0;
            dataGridViewMatrix.CellValueChanged += dataGridViewMatrix_CellValueChanged;
            dataGridViewMatrix.EditingControlShowing += dataGridViewMatrix_EditingControlShowing;
            dataGridViewMatrix.SizeChanged += dataGridViewMatrix_SizeChanged;
            // 
            // numericUpDownRows
            // 
            numericUpDownRows.Location = new System.Drawing.Point(68, 115);
            numericUpDownRows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numericUpDownRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRows.Name = "numericUpDownRows";
            numericUpDownRows.Size = new System.Drawing.Size(107, 27);
            numericUpDownRows.TabIndex = 1;
            numericUpDownRows.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownRows.ValueChanged += NumericUpDownRows_ValueChanged;
            // 
            // numericUpDownColumns
            // 
            numericUpDownColumns.Location = new System.Drawing.Point(220, 115);
            numericUpDownColumns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            numericUpDownColumns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownColumns.Name = "numericUpDownColumns";
            numericUpDownColumns.Size = new System.Drawing.Size(107, 27);
            numericUpDownColumns.TabIndex = 2;
            numericUpDownColumns.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownColumns.ValueChanged += NumericUpDownColumns_ValueChanged;
            // 
            // textBoxLaTeXOutput
            // 
            textBoxLaTeXOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxLaTeXOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            textBoxLaTeXOutput.Font = new System.Drawing.Font("Segoe UI", 15F);
            textBoxLaTeXOutput.Location = new System.Drawing.Point(799, 195);
            textBoxLaTeXOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBoxLaTeXOutput.Multiline = true;
            textBoxLaTeXOutput.Name = "textBoxLaTeXOutput";
            textBoxLaTeXOutput.ReadOnly = true;
            textBoxLaTeXOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxLaTeXOutput.Size = new System.Drawing.Size(370, 739);
            textBoxLaTeXOutput.TabIndex = 4;
            // 
            // columnsLabel
            // 
            columnsLabel.AutoSize = true;
            columnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            columnsLabel.Location = new System.Drawing.Point(225, 90);
            columnsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            columnsLabel.Name = "columnsLabel";
            columnsLabel.Size = new System.Drawing.Size(64, 16);
            columnsLabel.TabIndex = 6;
            columnsLabel.Text = "Spalten:";
            // 
            // Rows
            // 
            Rows.AutoSize = true;
            Rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Rows.Location = new System.Drawing.Point(65, 90);
            Rows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Rows.Name = "Rows";
            Rows.Size = new System.Drawing.Size(54, 16);
            Rows.TabIndex = 7;
            Rows.Text = "Zeilen:";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelX.Location = new System.Drawing.Point(183, 118);
            labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelX.Name = "labelX";
            labelX.Size = new System.Drawing.Size(21, 20);
            labelX.TabIndex = 8;
            labelX.Text = "X";
            // 
            // toolStripMenu
            // 
            toolStripMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripDropDownAlignment, toolStripButtonCopy });
            toolStripMenu.Location = new System.Drawing.Point(0, 59);
            toolStripMenu.Name = "toolStripMenu";
            toolStripMenu.Size = new System.Drawing.Size(370, 27);
            toolStripMenu.TabIndex = 10;
            toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripDropDownAlignment
            // 
            toolStripDropDownAlignment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownAlignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemCenter, toolStripMenuItemLeft, toolStripMenuItemRight });
            toolStripDropDownAlignment.Name = "toolStripDropDownAlignment";
            toolStripDropDownAlignment.Size = new System.Drawing.Size(101, 24);
            toolStripDropDownAlignment.Text = "Ausrichtung";
            // 
            // toolStripMenuItemCenter
            // 
            toolStripMenuItemCenter.Name = "toolStripMenuItemCenter";
            toolStripMenuItemCenter.Size = new System.Drawing.Size(182, 26);
            toolStripMenuItemCenter.Text = "Zentriert";
            toolStripMenuItemCenter.Click += ToolStripMenuItemCenter_Click;
            // 
            // toolStripMenuItemLeft
            // 
            toolStripMenuItemLeft.Name = "toolStripMenuItemLeft";
            toolStripMenuItemLeft.Size = new System.Drawing.Size(182, 26);
            toolStripMenuItemLeft.Text = "Linksbündig";
            toolStripMenuItemLeft.Click += ToolStripMenuItemLeft_Click;
            // 
            // toolStripMenuItemRight
            // 
            toolStripMenuItemRight.Name = "toolStripMenuItemRight";
            toolStripMenuItemRight.Size = new System.Drawing.Size(182, 26);
            toolStripMenuItemRight.Text = "Rechtsbündig";
            toolStripMenuItemRight.Click += ToolStripMenuItemRight_Click;
            // 
            // toolStripButtonCopy
            // 
            toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButtonCopy.Name = "toolStripButtonCopy";
            toolStripButtonCopy.Size = new System.Drawing.Size(200, 24);
            toolStripButtonCopy.Text = "Kopieren in Zwischenablage";
            toolStripButtonCopy.Click += ToolStripButtonCopy_Click;
            // 
            // panelToolStrip
            // 
            panelToolStrip.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panelToolStrip.Controls.Add(toolStripMenu);
            panelToolStrip.Location = new System.Drawing.Point(799, 56);
            panelToolStrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelToolStrip.Name = "panelToolStrip";
            panelToolStrip.Size = new System.Drawing.Size(370, 86);
            panelToolStrip.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(625, 462);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(167, 202);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1200, 1100);
            Controls.Add(pictureBox1);
            Controls.Add(panelToolStrip);
            Controls.Add(labelX);
            Controls.Add(Rows);
            Controls.Add(columnsLabel);
            Controls.Add(textBoxLaTeXOutput);
            Controls.Add(numericUpDownColumns);
            Controls.Add(numericUpDownRows);
            Controls.Add(dataGridViewMatrix);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "LaTriX";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownColumns).EndInit();
            toolStripMenu.ResumeLayout(false);
            toolStripMenu.PerformLayout();
            panelToolStrip.ResumeLayout(false);
            panelToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}