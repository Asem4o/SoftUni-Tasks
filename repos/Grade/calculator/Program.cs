using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    ublic static double DET(double[,] a, int n)
    {
        int i, j, k;
        double det = 0;
        for (i = 0; i < n - 1; i++)
        {
            for (j = i + 1; j < n + 1; j++)
            {
                det = a[j, i] / a[i, i];
                for (k = i; k < n; k++)
                    a[j, k] = a[j, k] - det * a[i, k]; // Here's exception
            }
        }
        det = 1;
        for (i = 0; i < n; i++)
            det = det * a[i, i];
        return det;
    }
}
