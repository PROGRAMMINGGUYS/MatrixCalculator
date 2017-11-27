using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixCalculator.DataStructures;

namespace MatrixCalculator.MathOps
{
    /// <summary>
    /// An implementation of the Gaussian elimination algorithm w/ partial pivoting
    /// </summary>
    class GaussianEliminationAlg
    {
        /// <summary>
        /// Calculates a solution for a linear system using the Gaussian algorithm w/ partial pivoting
        /// </summary>
        /// <param name="logHandler"></param>
        /// <param name="linearSystem"></param>
        /// <returns></returns>
        public static double[] SolveSystem(LogHandler logHandler, LinearSystem linearSystem)
        {
            logHandler.LogMessage("Initializing the Gaussian elimination algorithm w/ partial pivoting...\r\n");

            // make copies of the system components
            Matrix coefMatrix = new Matrix(linearSystem.CoefMatrix);
            double[] constVect = new double[linearSystem.Dimension];
            linearSystem.ConstTermsVector.CopyTo(constVect, 0);

            ToEchelonForm(logHandler, coefMatrix, constVect); // converts the whole system into the echelon form
            return ToReducedEchelonForm(logHandler, coefMatrix, constVect);
        }

        /// <summary>
        /// Converts the matrix (and constant terms vector if it's provided) to the echelon (triangular) form.
        /// Returns the coefficient for the matrix determinant or null if the matrix is not conversible
        /// </summary>
        /// <param name="logHandler"></param>
        /// <param name="matrix"></param>
        /// <param name="constVect"></param>
        /// <returns></returns>
        public static double? ToEchelonForm(LogHandler logHandler, Matrix matrix, double[] constVect = null)
        {
            if (matrix.RowNum == matrix.ColNum && matrix.RowNum == constVect.Length) // if a matrix is square
            {
                int dim = matrix.RowNum;
                double deterCoef = 1;
                double pivot = 0;

                for (int k = 0; k < dim; k++)
                {
                    if (!PartialPivot(k, matrix, constVect)) { return null; } // if the partial pivot has failed
                    deterCoef *= -1; // swapping rows switches the sign of the determinant

                    for (int i = k + 1; i < dim; i++)
                    {
                        pivot = -1 * matrix[i, k] / matrix[k, k];
                        for (int j = k; j < dim; j++)
                        {
                            matrix[i, j] = matrix[i, j] + (pivot * matrix[k, j]);
                        }

                        if (constVect != null)
                        {
                            constVect[i] = constVect[i] + (pivot * constVect[k]);
                        }

                        deterCoef *= pivot;
                    }
                }


                logHandler.LogMessage("Echelon form: ");
                if (constVect == null) { logHandler.LogMatrix(matrix); }
                #warning Slightly messy code
                else { logHandler.LogSystem(new LinearSystem(matrix, constVect)); } // for linear system

                return deterCoef;
            }
            return null;
        }

        /// <summary>
        /// Returns the solution for a matrix in the echelon (triangular) form
        /// </summary>
        /// <param name="logHandler"></param>
        /// <param name="matrix"></param>
        /// <param name="constVect"></param>
        /// <returns></returns>
        public static double[] ToReducedEchelonForm(LogHandler logHandler, Matrix matrix, double[] constVect)
        {
            // if a matrix is square and upper diagonal
            if (matrix != null && matrix.RowNum == matrix.ColNum && matrix.RowNum == constVect.Length && 
                matrix.IsTriangular(Matrix.TriangularType.Upper, true))
            {
                bool isDetNull = false;
                int dim = matrix.RowNum;
                double[] solution = new double[dim];

                for (int i = 0; i < dim; i++)
                {
                    if (matrix[i, i] == 0) { isDetNull = true; }
                }

                if (isDetNull) { return null; } // if the main diagonal has at least one zero, the system is unsolvable via this method 

                solution[dim - 1] = constVect[dim - 1] / matrix[dim - 1, dim - 1];
                for (int k = dim - 2; k >= 0; k--)
                {
                    double sum = 0;
                    for (int j = k + 1; j < dim; j++)
                    {
                        sum += matrix[k, j] * solution[j];
                    }
                    solution[k] = (constVect[k] - sum) / matrix[k, k];
                }
                
                logHandler.LogMessage("Solution: ");
                logHandler.LogVector(solution);

                return solution;
            }
            return null;
        }

        /// <summary>
        /// Finds the largest element in the kth column & swaps its row with the kth row
        /// </summary>
        /// <param name="k"></param>
        /// <param name="matrix"></param>
        /// <param name="constVect"></param>
        /// <returns></returns>
        private static bool PartialPivot(int k, Matrix matrix, double[] constVect = null)
        {
            int len = matrix.RowNum;
            int max = k;

            for (int i = k + 1; i < len; i++) // find the max element in the kth column
            {
                if (Math.Abs(matrix[i, k]) > Math.Abs(matrix[max, k]))
                {
                    max = i;
                }
            }

            if (matrix[max, k] == 0) { return false; }
            else
            {
                // swap the max row and kth row

                if (constVect != null)
                {
                    double swap = constVect[max];
                    constVect[max] = constVect[k];
                    constVect[k] = swap;
                }

                for (int j = k; j < len; j++)
                {
                    double swap = matrix[max, j];
                    matrix[max, j] = matrix[k, j];
                    matrix[k, j] = swap;
                }

                return true;
            }
        }
    }
}
