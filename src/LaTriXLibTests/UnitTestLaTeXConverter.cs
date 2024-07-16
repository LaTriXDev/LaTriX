using System.Collections;
using LaTriXLib;
using MathNet.Numerics.LinearAlgebra;

namespace LaTriXLibTests;

/// <summary>
/// Abstrakte Klasse <c>TestDataGenerator</c>.
/// Bildet die Basis für die anderen Testdatenklassen.
/// </summary>
/// <remarks>
/// Enthält den <c>protected</c> Member <c>test_strings</c>, in welchem die geparsten Test-Strings aus der Testdatendatei
/// gespeichert werden.
/// </remarks>
public abstract class TestDataGenerator
{
    // Reads the test strings from the config file and separates them by double newlines.
    protected static string[] test_strings = new StreamReader("./test_strings.txt").ReadToEnd().Split("\r\n\r\n");
}

/// <summary>
/// Klasse <c>DoubleMatrixTestDataGenerator</c>.
/// Stellt die Testdaten für die <c>TestLaTeXConverter.TestConvertDoubleMatrixToLaTeX</c>-Methode bereit.
/// </summary>
public class DoubleMatrixTestDataGenerator : TestDataGenerator, IEnumerable<object[]>
{
    private readonly List<object[]> _data = new List<object[]>
    {
        // 5-reihige Einheitsmatrix
        new object[] {Matrix<double>.Build.DenseIdentity(5), test_strings[0]},
        // 3x4-Matrix verschiedener Fließkommazahlen (Zeilenindex mal Spaltenindex durch 100)
        new object[] {Matrix<double>.Build.Dense(3, 4, (i,j) => i*j/100.0), test_strings[1]},
        // 1x1-Matrix mit negativer Zahl
        new object[] {Matrix<double>.Build.Dense(1, 1, (i,j) => -3), test_strings[2]}
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Klasse <c>FloatMatrixTestDataGenerator</c>.
/// Stellt die Testdaten für die <c>TestLaTeXConverter.TestConvertFloatMatrixToLaTeX</c>-Methode bereit.
/// </summary>
public class FloatMatrixTestDataGenerator : TestDataGenerator, IEnumerable<object[]>
{
    private readonly List<object[]> _data = new List<object[]>
    {
        // 5-reihige Einheitsmatrix
        new object[] {Matrix<float>.Build.DenseIdentity(5), test_strings[0]},
        // 3x4-Matrix verschiedener Fließkommazahlen (Zeilenindex mal Spaltenindex durch 100)
        new object[] {Matrix<float>.Build.Dense(3, 4, (i,j) => (float)(i*j/100.0)), test_strings[1]},
        // 1x1-Matrix mit negativer Zahl
        new object[] {Matrix<float>.Build.Dense(1, 1, (i,j) => -3), test_strings[2]}
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Klasse <c>VectorTestDataGenerator</c>.
/// Stellt die Testdaten für die <c>TestLaTeXConverter.TestConvertVectorToLaTeX</c>-Methode bereit.
/// </summary>
public class VectorTestDataGenerator : TestDataGenerator, IEnumerable<object[]>
{
    private readonly List<object[]> _data = new List<object[]>
    {
        // 5-komponentiger Spaltenvektor, bei dem die erste Komponente 1 und sonst 0 ist
        new object[] {Vector<double>.Build.Dense(5, i => Math.Pow(0, i)), LaTeXConverter.VectorType.column, test_strings[3]},
        // 3-komponentiger Zeilenvektor, bei verschiedener Fließkommazahlen (Index durch 100)
        new object[] {Vector<double>.Build.Dense(3, i => i/100.0), LaTeXConverter.VectorType.row, test_strings[4]},
        // 1-komponentiger Spaltenvektor mit negativer Zahl
        new object[] {Vector<double>.Build.Dense(1, i => -2), LaTeXConverter.VectorType.column, test_strings[5]}
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Klasse <c>AlignmentTestDataGenerator</c>.
/// Stellt die Testdaten für die <c>TestLaTeXConverter.TestMatrixAlignment</c>-Methode bereit.
/// </summary>
public class AlignmentTestDataGenerator : TestDataGenerator, IEnumerable<object[]>
{
    private readonly List<object[]> _data = new List<object[]>
    {
        // 5-reihige Einheitsmatrix, linksbündig
        new object[] {Matrix<double>.Build.DenseIdentity(5), LaTeXConverter.Alignment.left, test_strings[0].Replace('c', 'l')},
        // 3x4-Matrix verschiedener Fließkommazahlen (Zeilenindex mal Spaltenindex durch 100), rechtsbündig
        new object[] {Matrix<double>.Build.Dense(3, 4, (i,j) => i*j/100.0), LaTeXConverter.Alignment.right, test_strings[1].Replace('c', 'r')},
        // 1x1-Matrix mit negativer Zahl, zentriert
        new object[] {Matrix<double>.Build.Dense(1, 1, (i,j) => -3), LaTeXConverter.Alignment.center, test_strings[2]}
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Klasse <c>TestLaTeXConverter</c>.
/// Enthält integrierte Tests, um die Methoden der Klasse <c>LaTeXConverter</c> zu testen.
/// </summary>
public class TestLaTeXConverter
{
    /// <summary>
    /// Test, ob die Anwendung der <c>LaTeXConverter.ConvertMatrixToLaTeX</c>-Methode auf eine
    /// Matrix vom Typ double dasselbe Ergebnis liefert wie die händische Übersetzung der
    /// Matrix-Repräsentation in LaTeX-Code.
    /// </summary>
    /// <param name="matrix">Die zu konvertierende Testmatrix, vom Typ double.</param>
    /// <param name="expected_string">Der erwartete String aus einer händischen Übersetzung.</param>
    /// <seealso cref="TestConvertFloatMatrixToLaTeX(Matrix{float}, string)"/>
    [Theory]
    [ClassData(typeof(DoubleMatrixTestDataGenerator))]
    public void TestConvertDoubleMatrixToLaTeX(Matrix<double> matrix, string expected_string)
    /* Testet die ConvertMatrixToLaTeX-Methode mit double-Matrizen. */
    {
        Assert.Equal(LaTeXConverter.ConvertMatrixToLaTeX(matrix), expected_string);
    }

    /// <summary>
    /// Test, ob die Anwendung der <c>LaTeXConverter.ConvertMatrixToLaTeX</c>-Methode auf eine
    /// Matrix vom Typ float dasselbe Ergebnis liefert wie die händische Übersetzung der
    /// Matrix-Repräsentation in LaTeX-Code.
    /// </summary>
    /// <param name="matrix">Die zu konvertierende Testmatrix, vom Typ float.</param>
    /// <param name="expected_string">Der erwartete String aus einer händischen Übersetzung.</param>
    /// <seealso cref="TestConvertDoubleMatrixToLaTeX(Matrix{double}, string)"/>
    [Theory]
    [ClassData(typeof(FloatMatrixTestDataGenerator))]
    public void TestConvertFloatMatrixToLaTeX(Matrix<float> matrix, string expected_string)
    /* Testet die ConvertMatrixToLaTeX-Methode mit float-Matrizen. */
    {
        Assert.Equal(LaTeXConverter.ConvertMatrixToLaTeX(matrix), expected_string);
    }

    /// <summary>
    /// Test, ob die Anwendung der <c>LaTeXConverter.ConvertVectorToLaTeX</c>-Methode auf einen
    /// Vektor vom Typ double dasselbe Ergebnis liefert wie die händische Übersetzung der
    /// Vektor-Repräsentation in LaTeX-Code.
    /// </summary>
    /// <param name="vector">Der zu konvertierende Testvektor, vom Typ double.</param>
    /// <param name="vector_type">Die Typinterpretation des Vektors, also ein Element des
    /// <c>LaTeXConverter.VectorType</c>-Enums (Spalten- oder Zeilenvektor).</param>
    /// <param name="expected_string">Der erwartete String aus einer händischen Übersetzung.</param>
    [Theory]
    [ClassData(typeof(VectorTestDataGenerator))]
    public void TestConvertVectorToLaTeX(Vector<double> vector, LaTeXConverter.VectorType vector_type, string expected_string)
    /* Testet die ConvertVectorToLaTeX-Methode mit double-Vektoren, sowohl als Zeilen- als auch Spaltenvektor.*/
    {
        Assert.Equal(LaTeXConverter.ConvertVectorToLaTeX(vector, LaTeXConverter.Alignment.center, vector_type), expected_string);
    }

    /// <summary>
    /// Test, ob die Anwendung der <c>LaTeXConverter.ConvertMatrixToLaTeX</c>-Methode auf eine
    /// Matrix vom Typ double mit explizit genanntem alignment-Argument dasselbe Ergebnis liefert
    /// wie die händische Übersetzung der Matrix-Repräsentation in LaTeX-Code mit entsprechenden Alignment-Specifiern.
    /// </summary>
    /// <param name="matrix">Die zu konvertierende Testmatrix, vom Typ double.</param>
    /// <param name="expected_string">Der erwartete String aus einer händischen Übersetzung.</param>
    [Theory]
    [ClassData(typeof(AlignmentTestDataGenerator))]
    public void TestMatrixAlignment(Matrix<double> matrix, LaTeXConverter.Alignment alignment, string expected_string)
    /* Testet die ConvertMatrixToLaTeX-Methode mit verschiedenen Argumenten für das Alignment.*/
    {
        Assert.Equal(LaTeXConverter.ConvertMatrixToLaTeX(matrix, alignment), expected_string);
    }
}