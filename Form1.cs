using System;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using LaTriXLib;

/// <summary>
/// Hauptklasse für das Formular.
/// </summary>
namespace LaTriX
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Die aktuelle Ausrichtung der LaTeX-Matrix.
        /// </summary>
        private LaTeXConverter.Alignment currentAlignment = LaTeXConverter.Alignment.center;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Form1"/> Klasse.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ereignishandler für das Laden des Formulars.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            numericUpDownRows.Value = 3;
            numericUpDownColumns.Value = 3;
            UpdateDataGridView();
        }

        /// <summary>
        /// Ereignishandler für die Änderung der Anzahl der Zeilen.
        /// </summary>
        private void NumericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownRows.Value > 16)
            {
                MessageBox.Show("Die maximale Anzahl der Zeilen ist 16.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownRows.Value = 16;
            }
            UpdateDataGridView();
        }

        /// <summary>
        /// Ereignishandler für die Änderung der Anzahl der Spalten.
        /// </summary>
        private void NumericUpDownColumns_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownColumns.Value > 16)
            {
                MessageBox.Show("Die maximale Anzahl der Spalten ist 16.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownColumns.Value = 16;
            }
            UpdateDataGridView();
        }

        /// <summary>
        /// Aktualisiert das DataGridView basierend auf der Anzahl der Zeilen und Spalten.
        /// </summary>
        private void UpdateDataGridView()
        {
            dataGridViewMatrix.RowCount = (int)numericUpDownRows.Value;
            dataGridViewMatrix.ColumnCount = (int)numericUpDownColumns.Value;

            for (int i = 0; i < dataGridViewMatrix.ColumnCount; i++)
            {
                dataGridViewMatrix.Columns[i].HeaderText = "Col" + (i + 1).ToString();
            }
        }

        /// <summary>
        /// Setzt die Ausrichtung der LaTeX-Matrix auf zentriert.
        /// </summary>
        private void ToolStripMenuItemCenter_Click(object sender, EventArgs e)
        {
            currentAlignment = LaTeXConverter.Alignment.center;
            toolStripDropDownAlignment.Text = "Zentriert";
            ConvertMatrixToLaTeX(); // Aktualisiere die Ausgabe nach Änderung der Ausrichtung
        }

        /// <summary>
        /// Setzt die Ausrichtung der LaTeX-Matrix auf linksbündig.
        /// </summary>
        private void ToolStripMenuItemLeft_Click(object sender, EventArgs e)
        {
            currentAlignment = LaTeXConverter.Alignment.left;
            toolStripDropDownAlignment.Text = "Linksbündig";
            ConvertMatrixToLaTeX(); // Aktualisiere die Ausgabe nach Änderung der Ausrichtung
        }

        /// <summary>
        /// Setzt die Ausrichtung der LaTeX-Matrix auf rechtsbündig.
        /// </summary>
        private void ToolStripMenuItemRight_Click(object sender, EventArgs e)
        {
            currentAlignment = LaTeXConverter.Alignment.right;
            toolStripDropDownAlignment.Text = "Rechtsbündig";
            ConvertMatrixToLaTeX(); // Aktualisiere die Ausgabe nach Änderung der Ausrichtung
        }

        /// <summary>
        /// Kopiert den LaTeX-Code in die Zwischenablage.
        /// </summary>
        private void ToolStripButtonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLaTeXOutput.Text))
            {
                Clipboard.SetText(textBoxLaTeXOutput.Text);
                MessageBox.Show("LaTeX-Code in die Zwischenablage kopiert!", "Kopiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Ereignishandler für die Änderung des Werts einer Zelle im DataGridView.
        /// </summary>
        private void dataGridViewMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ConvertMatrixToLaTeX();
        }

        /// <summary>
        /// Konvertiert die Matrix im DataGridView in LaTeX-Code und aktualisiert das Ausgabe-Textfeld.
        /// </summary>
        private void ConvertMatrixToLaTeX()
        {
            var matrix = Matrix<double>.Build.Dense(dataGridViewMatrix.RowCount, dataGridViewMatrix.ColumnCount);

            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    if (double.TryParse(dataGridViewMatrix[j, i].Value?.ToString(), out double value))
                    {
                        matrix[i, j] = value;
                    }
                }
            }

            string latexCode = LaTeXConverter.ConvertMatrixToLaTeX(matrix, currentAlignment);
            textBoxLaTeXOutput.Text = latexCode;
        }
    }
}
