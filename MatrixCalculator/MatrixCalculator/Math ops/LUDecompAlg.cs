using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixCalculator.DataStructures;
using MatrixCalculator.MathOps;

namespace MatrixCalculator.MathOps
{
    /// <summary>
    /// LU decomposition algorithm implementation
    /// </summary>
    class LUDecompAlg
    {
        /// <summary>
        /// Calculates a solution for a linear system using the LU decomposion algorithm
        /// </summary>
        /// <param name="logHandler"></param>
        /// <param name="linearSystem"></param>
        /// <returns></returns>
        public static double[] SolveSystem(LogHandler logHandler, LinearSystem linearSystem)
        {
            logHandler.LogMessage("Initializing the LU decomposion algorithm...\r\n");

            // make copies of the system components
            Matrix coefMatrix = new Matrix(linearSystem.CoefMatrix);

            (Matrix L, Matrix U) decompose = Decompose(logHandler, coefMatrix);
            return GetSolution(logHandler, decompose, linearSystem.ConstTermsVector);
        }

        /// <summary>
        /// Decomposes the matrix into the lower and upper triangular matrices (return via tuple)
        /// </summary>
        /// <param name="logHandler"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static (Matrix L, Matrix U) Decompose(LogHandler logHandler, Matrix matrix)
        {
            if (!matrix.IsSquare()) { return (null, null); }

            int dim = matrix.RowNum;
            // L - lower (left) triangular matrix, U - upper (right) triangular matrix
            var result = (L:new Matrix(dim), U:new Matrix(dim));

            for (int i = 0; i < dim; i++) { result.L[i, i] = 1; }

            for (int j = 0; j < dim; j++) { result.U[0, j] = matrix[0, j]; }

            if (matrix[0, 0] == 0) { return (null, null); } // algorithm is not applicable
            for (int i = 1; i < dim; i++) { result.L[i, 0] = matrix[i, 0] / matrix[0, 0]; }

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (i <= j) // calculate U
                    {
                        double sum = 0;
                        for (int k = 0; k < i; k++)
                        {
                            sum += result.L[i, k] * result.U[k, j];
                        }

                        result.U[i, j] = matrix[i, j] - sum;
                    }
                    else // calcualate L
                    {
                        if (result.U[j, j] == 0) { return (null, null); } // algorithm is not applicable

                        double sum = 0;
                        for (int k = 0; k < j; k++)
                        {
                            sum += result.L[i, k] * result.U[k, j];
                        }

                        result.L[i, j] = (1 / result.U[j, j]) * (matrix[i, j] - sum);
                    }
                }
            }

            logHandler.LogMessage("Lower matrix: ");
            logHandler.LogMatrix(result.L);

            logHandler.LogMessage("Upper matrix: ");
            logHandler.LogMatrix(result.U);

            return result;
        }

        /// <summary>
        /// Calculates the solution from a given LU decomposition  
        /// </summary>
        /// <param name="logHandler"></param>
        /// <param name="decompose"></param>
        /// <param name="constVect"></param>
        /// <returns></returns>
        public static double[] GetSolution(LogHandler logHandler, (Matrix L, Matrix U) decompose, double[] constVect)
        {
            if (decompose.L == null || decompose.U == null || !decompose.L.IsSquare() || !decompose.U.IsSquare() || 
                decompose.L.RowNum != decompose.U.RowNum || !decompose.L.IsTriangular(Matrix.TriangularType.Lower, true) || 
                !decompose.U.IsTriangular(Matrix.TriangularType.Upper, true)) { return null; }

            int dim = decompose.L.RowNum;
            double[] ySolution = new double[dim];

            for (int i = 0; i < dim; i++)
            {
                if (decompose.L[i, i] != 1) { return null; } // invalid lower matrix
            }

            // Ly = b solving
            ySolution[0] = constVect[0];
            for (int i = 1; i < dim; i++)
            {
                double sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += decompose.L[i, j] * ySolution[j];
                }
                ySolution[i] = constVect[i] - sum;
            }

            logHandler.LogMessage("Intermediate solution: ");
            logHandler.LogVector(ySolution);

            return GaussianEliminationAlg.ToReducedEchelonForm(logHandler, decompose.U, ySolution);
        }
    }
}
