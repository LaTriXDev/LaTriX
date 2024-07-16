using System.Globalization;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace LaTriXLib;

/// <summary>
/// Die LaTeXConverter-Klasse.
/// Enthält Methoden zur Konversion von MathNet.Numerics.LinearAlgebra-Matrizen und -Vektoren in einfügbaren
/// LaTeX-Code.
/// </summary>
/// 
/// <remarks>
/// Im LaTeX-Dokument werden keine weiteren Bibliotheken zur Matrizen- und Vektoranzeige benötigt, der Code muss
/// lediglich im Mathematikmodus eingefügt werden.
/// </remarks>
public static class LaTeXConverter
{
    /// <summary>
    /// Ein Enum-Typ, der eine Elementanordnung innerhalb einer Matrix/eines Vektors repräsentiert.
    /// </summary>
    /// 
    /// <remarks>
    /// Alignment.left steht dabei für linksbündige Ausrichtung, Alignment.right für rechtsbündige Ausrichtung sowie
    /// Alignment.center für zentrierte Elemente.
    /// </remarks>
    public enum Alignment
    {
        left, center, right
    }

    /// <summary>
    /// Ein Enum-Typ, der eine Typinterpretation eines Vektors repräsentiert.
    /// </summary>
    /// 
    /// <remarks>
    /// VectorType.column steht dafür für eine Interpretation als Spaltenvektor,
    /// VectorType.row für eine Interpretation als Zeilenvektor.
    /// </remarks>
    public enum VectorType
    {
        column, row
    }

    /// <summary>
    /// Konvertiert die übergebene Matrix <paramref name="matrix"/> in einen LaTeX-Code, der diese anzeigen kann.
    /// </summary>
    /// <typeparam name="T">Ein Datentyp, aus dem eine MathNet.Numerics.LinearAlgebra.Matrix gebaut werden kann
    /// (Double, Single, Complex, Complex32).</typeparam>
    /// <param name="matrix">Die zu konvertierende Matrix.</param>
    /// <param name="alignment">Anordnung der Matrixelemente. Eines von LaTeXConverter.Alignment.center (zentriert),
    /// LaTeXConverter.Alignment.left (linksbündig) oder LaTeXConverter.Alignment.right (rechtsbündig). Standardmäßig
    /// LaTeXConverter.Alignment.center.</param>
    /// <returns>Ein LaTeX-Code, der direkt in ein LaTeX-Dokument (im Mathematikmodus!) eingefügt werden kann, um die
    /// konvertierte Matrix anzuzeigen.</returns>
    /// 
    /// <remarks>
    /// <para>
    /// Der erzeugte LaTeX-Code besitzt keine eigene Kontrollsequenz zur Einleitung des Mathematikmodus. Der Code muss explizit im
    /// Mathematikmodus eingefügt werden.
    /// </para>
    /// <para>
    /// Aus Kompatibilitätsgründen (und da LaTeX diese ebenfalls standardmäßig als Dezimaltrennzeichen nutzt) wird als Trennzeichen
    /// zwischen "Vorkommastellen" und "Nachkommastellen" der im englischen Sprachraum übliche Punkt genutzt.
    /// </para>
    /// <para>
    /// Der erzeugte Code arbeitet mit der LaTeX-Kontrollsequenz <c>\begin{array}</c> statt <c>\begin{pmatrix}</c>, um auch ohne den Import
    /// des amsmath-Moduls zu funktionieren.
    /// </para>
    /// </remarks>
    public static string ConvertMatrixToLaTeX<T>(Matrix<T> matrix, Alignment alignment=Alignment.center) where T : struct, IEquatable<T>, IFormattable
    /* Die Einschränkung des Typparameters T auf ein struct, das IEquatable<T> und IFormattable implementiert, ist wegen
    der internen Implementierung der `MathNet.Numerics.LinearAlgebra.Matrix`-Klasse zu nutzen, da nur aus solchen Typen Matrizen
    erstellt werden können. */
    {
        StringBuilder latexStringBuilder = new StringBuilder(@"\left( \begin{array}{"); // Overhead, der die Matrix initialisiert
        char alignment_char = GetAlignmentChar(alignment);
        latexStringBuilder.Append(new string(alignment_char, matrix.ColumnCount)); // Formatspecifier der Matrix (linksbündig, rechtsbündig oder zentriert)
        latexStringBuilder.AppendLine(@"}");
        for (int i=0; i < matrix.RowCount; i++) // Iteration über die Reihen
        {
            latexStringBuilder.Append(matrix[i,0].ToString()); // Vor das erste Element darf kein & gesetzt werden, deswegen Extrabehandlung!
            for (int j=1; j < matrix.ColumnCount; j++) // Iteration über die Spalten
            {
                latexStringBuilder.Append('&'); // Zwischen Zeilenelementen muss ein Trennzeichen gesetzt werden
                latexStringBuilder.Append(matrix[i,j].ToString("G", CultureInfo.InvariantCulture)); // InvariantCulture erzwingt hier einen Dezimalpunkt!
            }
            latexStringBuilder.AppendLine(@"\\"); // Zeile beendet, setze LaTeX-Linebreak (\\) und Datei-Linebreak (\n)
        }
        latexStringBuilder.Append(@"\end{array} \right)"); // Matrixsuffix, Gegenstück zum Overhead
        return latexStringBuilder.ToString();
    }

    /// <summary>
    /// Konvertiert den übergebenen Vektor <paramref name="vector"/> in einen LaTeX-Code, der diesen anzeigen kann.
    /// </summary>
    /// <typeparam name="T">Ein Datentyp, aus dem ein MathNet.Numerics.LinearAlgebra.Vector gebaut werden kann
    /// (Double, Single, Complex, Complex32).</typeparam>
    /// <param name="vector">Der zu konvertierende Vektor.</param>
    /// <param name="alignment">Anordnung der Vektorelemente. Eines von LaTeXConverter.Alignment.center (zentriert),
    /// LaTeXConverter.Alignment.left (linksbündig) oder LaTeXConverter.Alignment.right (rechtsbündig). Standardmäßig
    /// LaTeXConverter.Alignment.center.</param>
    /// <param name="vector_type">Gibt an, ob der Vektor als Spalten- oder Zeilenvektor interpretiert werden soll.
    /// Eines von LaTeXConverter.VectorType.column oder LaTeXConverter.VectorType.row. Standardmäßig
    /// LaTeXConverter.VectorType.column.</param>
    /// <returns>Ein LaTeX-Code, der direkt in ein LaTeX-Dokument (im Mathematikmodus!) eingefügt werden kann, um den
    /// konvertierten Vektor anzuzeigen.</returns>
    /// 
    /// <remarks>
    /// <para>
    /// Der erzeugte LaTeX-Code besitzt keine eigene Kontrollsequenz zur Einleitung des Mathematikmodus. Der Code muss explizit im
    /// Mathematikmodus eingefügt werden.
    /// </para>
    /// <para>
    /// Aus Kompatibilitätsgründen (und da LaTeX diese ebenfalls standardmäßig als Dezimaltrennzeichen nutzt) wird als Trennzeichen
    /// zwischen "Vorkommastellen" und "Nachkommastellen" der im englischen Sprachraum übliche Punkt genutzt.
    /// </para>
    /// <para>
    /// Der erzeugte Code arbeitet mit der LaTeX-Kontrollsequenz <c>\begin{array}</c> statt <c>\begin{pmatrix}</c>, um auch ohne den Import
    /// des amsmath-Moduls zu funktionieren.
    /// </para>
    /// </remarks>
    public static string ConvertVectorToLaTeX<T>(Vector<T> vector, Alignment alignment=Alignment.center, VectorType vector_type=VectorType.column)
    where T : struct, IEquatable<T>, IFormattable
    {
        Matrix<T> vector_as_matrix;
        switch (vector_type) // Konvertiert in diesem Switch den Vektor in eine einzeilige/einspaltige Matrix, je nach angegebenem VectorType.
        {
            case VectorType.column:
                vector_as_matrix = vector.ToColumnMatrix();
                break;
            case VectorType.row:
                vector_as_matrix = vector.ToRowMatrix();
                break;
            default:
                vector_as_matrix = vector.ToColumnMatrix();
                break;
        }
        return ConvertMatrixToLaTeX(vector_as_matrix, alignment); // Rückführung auf den Matrix-Fall.
    }

    /// <summary>
    /// Konvertiert ein Alignment in den entsprechenden LaTeX-Specifier (l, c oder r).
    /// </summary>
    /// <param name="alignment">Eines von LaTeXConverter.Alignment.center, LaTeXConverter.Alignment.left
    /// oder LaTeXConverter.Alignment.right.</param>
    /// <returns>Den char 'l', falls <paramref name="alignment"/>==LaTeXConverter.Alignment.left, 'r' falls
    /// <paramref name="alignment"/>==LaTeXConverter.Alignment.right, 'c' sonst.</returns>
    private static char GetAlignmentChar(Alignment alignment)
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
