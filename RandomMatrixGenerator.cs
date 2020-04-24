using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class RandomMatrixGenerator
    {
        private static RandomMatrixGenerator instance;
        private Random generator;
        private RandomMatrixGenerator()
        {
            this.generator = new Random();
        }
        public static RandomMatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomMatrixGenerator();
            }
            return instance;
        }
        
        public double[][] NextMatrix(int rows, int columns)
        {
            double[][] matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new double[columns];
            }            for(int j = 0; j < rows; j++)
            {
                for(int k = 0; k < columns; k++)
                {
                    matrix[j][k] = this.generator.NextDouble();
                }
            }

            return matrix;
        }
    }
}


/*Metoda ima dvije odgovornosti, instanciranje matrice i popunjavanje iste pseudo slučajnim brojevima*/