using System;
using System.Drawing;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using LaTriXLib;

namespace LaTriX
{
    /// <summary>
    /// Hauptformular für die LaTriX-Anwendung.
    /// </summary>
    public partial class Form1 : Form
    {
        private LaTeXConverter.Alignment currentAlignment = LaTeXConverter.Alignment.center;

        /// <summary>
        /// Initialisiert eine neue Instanz des <see cref="Form1"/> Klasse.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Behandelt das Laden des Hauptformulars.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            numericUpDownRows.Value = 3;
            numericUpDownColumns.Value = 3;
            UpdateDataGridView();
        }

        /// <summary>
        /// Behandelt das Ereignis, wenn sich der Wert der Zeilen-Nummerierung ändert.
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
        /// Behandelt das Ereignis, wenn sich der Wert der Spalten-Nummerierung ändert.
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
        /// Aktualisiert die DataGridView basierend auf den aktuellen Werten der Zeilen und Spalten.
        /// </summary>
        private void UpdateDataGridView()
        {
            dataGridViewMatrix.RowCount = (int)numericUpDownRows.Value;
            dataGridViewMatrix.ColumnCount = (int)numericUpDownColumns.Value;

            for (int i = 0; i < dataGridViewMatrix.ColumnCount; i++)
            {
                dataGridViewMatrix.Columns[i].HeaderText = "Col" + (i + 1).ToString();
            }
            RowHeights();
        }

        /// <summary>
        /// Passt die Höhe der Zeilen in der DataGridView an.
        /// </summary>
        private void RowHeights()
        {
            int rowCount = dataGridViewMatrix.Rows.Count;
            if (rowCount > 0)
            {
                int totalHeight = dataGridViewMatrix.ClientSize.Height;
                int rowHeight = totalHeight / rowCount;
                foreach (DataGridViewRow row in dataGridViewMatrix.Rows)
                {
                    row.Height = rowHeight;
                }
            }
        }

        /// <summary>
        /// Setzt die aktuelle Ausrichtung auf zentriert und aktualisiert die LaTeX-Ausgabe.
        /// </summary>
        private void ToolStripMenuItemCenter_Click(object sender, EventArgs e)
        {
            currentAlignment = LaTeXConverter.Alignment.center;
            toolStripDropDownAlignment.Text = "Zentriert";
            ConvertMatrixToLaTeX();
        }

        /// <summary>
        /// Setzt die aktuelle Ausrichtung auf linksbündig und aktualisiert die LaTeX-Ausgabe.
        /// </summary>
        private void ToolStripMenuItemLeft_Click(object sender, EventArgs e)
        {
            currentAlignment = LaTeXConverter.Alignment.left;
            toolStripDropDownAlignment.Text = "Linksbündig";
            ConvertMatrixToLaTeX();
        }

        /// <summary>
        /// Setzt die aktuelle Ausrichtung auf rechtsbündig und aktualisiert die LaTeX-Ausgabe.
        /// </summary>
        private void ToolStripMenuItemRight_Click(object sender, EventArgs e)
        {
            currentAlignment = LaTeXConverter.Alignment.right;
            toolStripDropDownAlignment.Text = "Rechtsbündig";
            ConvertMatrixToLaTeX();
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
        /// Behandelt das Ereignis, wenn der Wert einer Zelle in der DataGridView geändert wird.
        /// </summary>
        private void dataGridViewMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ConvertMatrixToLaTeX();
        }

        /// <summary>
        /// Behandelt das Ereignis, wenn die Größe der DataGridView geändert wird.
        /// </summary>
        private void dataGridViewMatrix_SizeChanged(object sender, EventArgs e)
        {
            RowHeights();
        }

        /// <summary>
        /// Behandelt das Ereignis, wenn die Bearbeitung einer Zelle in der DataGridView beginnt.
        /// </summary>
        private void dataGridViewMatrix_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                tb.KeyPress -= DataGridViewMatrix_KeyPress;
                tb.KeyPress += DataGridViewMatrix_KeyPress;
            }
        }

        /// <summary>
        /// Behandelt das KeyPress-Ereignis der DataGridView, um nur gültige Zeichen zuzulassen.
        /// </summary>
        private void DataGridViewMatrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Erlaubt nur Ziffern, Steuerzeichen, einen Dezimalpunkt oder Komma und ein Minuszeichen am Anfang
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '-')
                {
                    throw new Exception("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                }

                // Stellt sicher, dass nur ein Dezimalpunkt oder Komma erlaubt ist
                if ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1))
                {
                    throw new Exception("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                }

                // Stellt sicher, dass das Minuszeichen nur am Anfang steht
                if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
                {
                    throw new Exception("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Konvertiert die aktuelle Matrix in LaTeX-Code und aktualisiert die Ausgabebox.
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
