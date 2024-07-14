using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace LaTriXLib;

public static class LaTeXConverter
{
    public enum Alignment
    {
        left, center, right
    }

    public static string ConvertMatrixToLaTeX<T>(Matrix<T> matrix, Alignment alignment=Alignment.center) where T : struct, IEquatable<T>, IFormattable
    /* Die Einschränkung des Typparameters T auf ein struct, das IEquatable<T> und IFormattable implementiert, ist wegen
    der internen Implementierung der `MathNet.Numerics.LinearAlgebra.Matrix`-Klasse zu nutzen, da nur aus solchen Typen Matrizen
    erstellt werden können. */
    {
        StringBuilder latexStringBuilder = new StringBuilder(@"\left( \begin{array}{"); // Overhead, der die Matrix initialisiert
        char alignment_char = GetAlignmentChar(alignment);
        latexStringBuilder.Append(new string(alignment_char, matrix.ColumnCount)); // Formatspecifier der Matrix (linksbündig, rechtsbündig oder zentriert)
        latexStringBuilder.Append(@"}\n");
        for (int i=0; i < matrix.RowCount; i++) // Iteration über die Reihen
        {
            latexStringBuilder.Append(matrix[i,0].ToString()); // Vor das erste Element darf kein & gesetzt werden, deswegen Extrabehandlung!
            for (int j=0; j < matrix.ColumnCount; j++) // Iteration über die Spalten
            {
                latexStringBuilder.Append('&'); // Zwischen Zeilenelementen muss ein Trennzeichen gesetzt werden
                latexStringBuilder.Append(matrix[i,j].ToString());
            }
            latexStringBuilder.Append(@"\\\n"); // Zeile beendet, setze LaTeX-Linebreak (\\) und Datei-Linebreak (\n)
        }
        latexStringBuilder.Append(@"\end{array} \right)"); // Matrixsuffix, Gegenstück zum Overhead
        return latexStringBuilder.ToString();
    }

    private static char GetAlignmentChar(Alignment alignment) // Konvertiert ein Alignment in den LaTeX-Specifier (l, c oder r)
    {
        switch (alignment)
        {
            case Alignment.left:
                return 'l';
            case Alignment.right:
                return 'r';
            case Alignment.center:
                return 'c';
            default:
                return 'c';
        }
    }
}
