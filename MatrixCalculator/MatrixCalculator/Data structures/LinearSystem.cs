using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator.DataStructures
{
    /// <summary>
    /// Class for linear systems
    /// </summary>
    class LinearSystem
    {
        Matrix coefs;
        double[] constVect;
        int dim;

        internal Matrix CoefMatrix { get => coefs; }
        public double[] ConstTermsVector { get => constVect; }
        public int Dimension { get => dim; }

        #region Constructors

        public LinearSystem(int dim)
        {
            this.dim = dim;
            coefs = new Matrix(dim);
            constVect = new double[dim];
        }

        public LinearSystem(Matrix coefs, double[] constVect = null)
        {
            if (coefs.RowNum != coefs.ColNum) { return; } // if a matrix is not square

            dim = coefs.RowNum;
            this.coefs = new Matrix(coefs);
      
            this.constVect = new double[dim];
            if (constVect != null && constVect.Length == dim) // if constVect was passed & is of a valid size
            {
                for (int i = 0; i < dim; i++)
                {
                    this.constVect[i] = constVect[i];
                }
            }
        }

        public LinearSystem(DataGridView coefs, DataGridView constVect)
        {
            // dimension check
            if (coefs.RowCount != coefs.ColumnCount || coefs.RowCount != constVect.RowCount) { return; }

            dim = coefs.RowCount;
            this.coefs = new Matrix(dim);
            this.constVect = new double[dim];

            // get the data from the DataGridViews into the LinearSystem instance
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    this.coefs[i, j] = Convert.ToDouble(coefs.Rows[i].Cells[j].Value);
                }
                this.constVect[i] = Convert.ToDouble(constVect.Rows[i].Cells[0].Value);
            }
        }

        #endregion

        #region Operator overloads

        /// <summary>
        /// Equality operator overload
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator ==(LinearSystem x, LinearSystem y)
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

            if (x.dim != y.dim) { return false; } // if the dimensions don't match

            int dim = x.dim;

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (x.coefs[i, j] != y.coefs[i, j])
                    {
                        return false;
                    }
                }
                if (x.constVect[i] != y.constVect[i]) { return false; }
            }

            return true;
        }

        /// <summary>
        /// Inequality opertor overload
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator !=(LinearSystem x, LinearSystem y)
        {
            return !(x == y);
        }

        #endregion

        /// <summary>
        /// Converts the system into a string with new line whitespaces to indicate rows
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string res = string.Empty;

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    res += string.Format("{0} ", coefs[i, j]);
                }
                // avoid appending \n to the last row because it affects the Split function
                res += (i == dim - 1) ? string.Format("{0}", constVect[i]) : string.Format("{0}\n", constVect[i]);
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
            return (this == (obj as LinearSystem));
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
                hash = (hash * 23) + coefs.GetHashCode();
                hash = (hash * 23) + constVect.GetHashCode();
                hash = (hash * 23) + dim.GetHashCode();

                return hash;
            }
        }
    }
}
