using MathNet.Numerics.LinearAlgebra;
using System;

public class Program
{
    static void Main(string[] args)
    {
        // Matrizen
        Matrix<double> matrix1 = Matrix<double>.Build.DenseIdentity(5);
        Matrix<double> matrix2 = Matrix<double>.Build.Dense(3, 4, (i,j) => i*j/100.0);

        // Vektoren
        Vector<double> vector1 = Vector<double>.Build.Dense(5, i => Math.Pow(0, i));
        Vector<double> vector2 = Vector<double>.Build.Dense(3, i => i/100.0);

        // Strings generieren
        string string1 = LaTriXLib.LaTeXConverter.ConvertMatrixToLaTeX(matrix1);
        string string2 = LaTriXLib.LaTeXConverter.ConvertMatrixToLaTeX(matrix2, LaTriXLib.LaTeXConverter.Alignment.right);
        string string3 = LaTriXLib.LaTeXConverter.ConvertMatrixToLaTeX(matrix2, LaTriXLib.LaTeXConverter.Alignment.left);
        string string4 = LaTriXLib.LaTeXConverter.ConvertVectorToLaTeX(vector1);
        string string5 = LaTriXLib.LaTeXConverter.ConvertVectorToLaTeX(vector2, LaTriXLib.LaTeXConverter.Alignment.center, LaTriXLib.LaTeXConverter.VectorType.row);

        // Ausgabe über die Konsole
        foreach (string item in new string[] {string1, string2, string3, string4, string5})
        {
            
            Console.WriteLine(item);
            Console.WriteLine(); // Zeilenumbruch
        }
    }
}