using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace LaTriXLib;

public static class LaTeXConverter
{
    public enum Alignment
    {
        left, center, right
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
