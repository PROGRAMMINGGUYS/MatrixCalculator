using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator.DataStructures
{
    /// <summary>
    /// A fundamental class for storing a matrix
    /// </summary>
    class Matrix
    {
        public enum TriangularType{ Lower, Upper };

        double[][] elements; // array of elements
        int rowNum; // number of rows
        int colNum; // number of columns

        public int RowNum { get => rowNum; set => rowNum = value; }
        public int ColNum { get => colNum; set => colNum = value; }

        /// <summary>
        /// Elements indexer
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public double this[int i, int j]
        {
            get => elements[i][j];
            set => elements[i][j] = value;
        }

        #region Constructors

        /// <summary>
        /// Null matrix constructor
        /// </summary>
        /// <param name="dim"></param>
        public Matrix(int rowNum, int colNum = 0)
        {
            if (rowNum > 0)
            {
                if (colNum == 0) { colNum = rowNum; }
                if (colNum < 0) { return; }
            }
            else { return; }

            this.rowNum = rowNum;
            this.colNum = colNum;

            // array initialization
            this.elements = new double[rowNum][];
            for (int i = 0; i < rowNum; i++)
            {
                elements[i] = new double[colNum];
            }
        }

        /// <summary>
        /// Copy from array constructor
        /// </summary>
        /// <param name="elements"></param>
        public Matrix(double[][] elements)
        {
            rowNum = elements.Length;
            colNum = elements[0].Length; // all rows are expected to have the same number of elements

            try
            {
                this.elements = new double[rowNum][];
                for (int i = 0; i < rowNum; i++)
                {
                    this.elements[i] = new double[colNum];
                    for (int j = 0; j < colNum; j++)
                    {
                        this.elements[i][j] = elements[i][j];
                    }
                }
            }
            catch (Exception)
            {
                rowNum = 0;
                colNum = 0;
                this.elements = null;
                return;
            }
        }

        /// <summary>
        /// Copy from Matrix constructor
        /// </summary>
        /// <param name="x"></param>
        public Matrix(Matrix x)
        {
            rowNum = x.rowNum;
            colNum = x.colNum;

            elements = new double[rowNum][];
            for (int i = 0; i < rowNum; i++)
            {
                elements[i] = new double[colNum];
                for (int j = 0; j < colNum; j++)
                {
                    elements[i][j] = x.elements[i][j];
                }
            }
        }

        #endregion

        #region Operator overloads

        //public Matrix operator+=(Matrix y)
        //{

        //}

        /// <summary>
        /// Addition operator overload
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Matrix operator +(Matrix x, Matrix y)
        {
            if (x.rowNum != y.rowNum || x.colNum != y.colNum) { return x; } // if the dimensions don't match

            int rNum = x.rowNum;
            int cNum = x.colNum;

            var sum = new Matrix(rNum, cNum);
            for (int i = 0; i < rNum; i++)
            {
                for (int j = 0; j < cNum; j++)
                {
                    sum[i, j] = x[i, j] + y[i, j];
                }
            }

            return sum;
        }

        /// <summary>
        /// Subtraction operator overload
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Matrix operator -(Matrix x, Matrix y)
        {
            if (x.rowNum != y.rowNum || x.colNum != y.colNum) { return x; } // if the dimensions don't match

            int rNum = x.rowNum;
            int cNum = x.colNum;

            var diff = new Matrix(rNum, cNum);
            for (int i = 0; i < rNum; i++)
            {
                for (int j = 0; j < cNum; j++)
                {
                    diff[i, j] = x[i, j] - y[i, j];
                }
            }

            return diff;
        }

        /// <summary>
        /// Multiplication operator overload(for scalar)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Matrix operator *(Matrix x, double s)
        {
            int rNum = x.rowNum;
            int cNum = x.colNum;

            var prod = new Matrix(rNum, cNum);
            for (int i = 0; i < rNum; i++)
            {
                for (int j = 0; j < cNum; j++)
                {
                    prod[i, j] = x[i, j] * s;
                }
            }

            return prod;
        }

        /// <summary>
        /// Multiplication operator overload(for Matrix)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Matrix operator *(Matrix x, Matrix y)
        {
            if (x.colNum != y.rowNum) { return x; } // if the dimensions don't match

            int rNum = x.rowNum;
            int mNum = x.colNum;
            int cNum = y.colNum;

            var prod = new Matrix(rNum, cNum);
            for (int i = 0; i < rNum; i++)
            {
                for (int j = 0; j < mNum; j++)
                {
                    for (int k = 0; k < cNum; k++)
                    {
                        prod[i, j] += x[i, k] * y[k, j];
                    }
                }
            }

            return prod;
        }

        /// <summary>
        /// Equality operator overload
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator ==(Matrix x, Matrix y)
        {
            // null handling
            if (ReferenceEquals(x, null))
            {
                return ReferenceEquals(y, null);
            }
            if (ReferenceEquals(y, null))
            {
                return ReferenceEquals(x, null);
            }

            if (x.rowNum != y.rowNum || x.colNum != y.colNum) { return false; } // if the dimensions don't match

            int rNum = x.rowNum;
            int cNum = x.colNum;

            for (int i = 0; i < rNum; i++)
            {
                for (int j = 0; j < cNum; j++)
                {
                    if (x.elements[i][j] != y[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Inequality opertor overload
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator !=(Matrix x, Matrix y)
        {
            return !(x == y);
        }

        #endregion

        #region Matrix property checks

        /// <summary>
        /// Checks whether a matrix is symmetric
        /// </summary>
        /// <returns></returns>
        public bool IsSymmetric()
        {
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = i; j < colNum; j++)
                {
                    if (elements[i][j] != elements[j][i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Checks whether a matrix is symmetric
        /// </summary>
        /// <returns></returns>
        public bool IsDiagonal()
        {
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    if (i != j && elements[i][j] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Checks whether a matrix is an identity matrix
        /// </summary>
        /// <returns></returns>
        public bool IsIdentity()
        {
            if (!IsDiagonal()) { return false; }

            for (int i = 0; i < rowNum; i++)
            {
                if (elements[i][i] != 1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks whether a matrix is symmetric
        /// </summary>
        /// <param name="triangularType"></param>
        /// <param name="includeDiagonal"></param>
        /// <returns></returns>
        public bool IsTriangular(TriangularType triangularType, bool includeDiagonal = false)
        {
            for (int i = 0; i < rowNum; i++)
            {
                if (triangularType == TriangularType.Lower)
                {
                    for (int j = includeDiagonal ? (i + 1) : (i); j < colNum; j++) // choose whether to include the diagonal or not
                    {
                        if (elements[i][j] != 0) { return false; }
                    }
                }
                else if (triangularType == TriangularType.Upper)
                {
                    for (int j = 0; includeDiagonal ? (j < i) : (j <= i); j++) // choose whether to include the diagonal or not
                    {
                        if (elements[i][j] != 0) { return false; }
                    }
                }
                else { return false; }
            }

            return true;
        }

        /// <summary>
        /// Checks whether the matrix is square (if # of rows matches the # of columns)
        /// </summary>
        /// <returns></returns>
        public bool IsSquare()
        {
            return (rowNum == colNum);
        }

        #endregion

        #region Matrix operations

        /// <summary>
        /// Returns the sum of the main diagonal elements of the matrix
        /// </summary>
        /// <returns></returns>
        public double Trace()
        {
            double trace = 0;

            for (int i = 0; i < rowNum; i++)
            {
                trace += elements[i][i];
            }

            return trace;
        }

        /// <summary>
        /// Return a transpose of the matrix
        /// </summary>
        /// <returns></returns>
        public Matrix Transpose()
        {
            Matrix transpose = new Matrix(rowNum, colNum);

            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    transpose[i, j] = elements[j][i];
                }
            }

            return transpose;
        }
        
        #endregion

        /// <summary>
        /// Converts the matrix into a string with new line whitespaces to indicate rows
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string res = string.Empty;

            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    // avoid appending the space to the last element because it affects the Split function
                    res += (j == colNum - 1) ? string.Format("{0}", elements[i][j]) : string.Format("{0} ", elements[i][j]);
                }
                // avoid appending \n to the last row because it affects the Split function
                if (i != rowNum - 1) { res += "\n"; }
            }
            return res;
        }

        /// <summary>
        /// Equals() override
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {         
            return (this == (obj as Matrix));
        }

        /// <summary>
        /// proMLG GetHashCode override
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + elements.GetHashCode();
                hash = (hash * 23) + rowNum.GetHashCode();
                hash = (hash * 23) + colNum.GetHashCode();

                return hash;
            }
        }
    }
}
