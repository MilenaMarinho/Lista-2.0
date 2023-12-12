using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Quadrado
    {
        private double diag;
        private double area;

        public Quadrado()
        {
            this.diag = 0;
        }

        public Quadrado (double diag)
        { 
            this.diag = diag;
        }

        public void setDiag(double diag)
        {
            this.diag = diag;
        }

        public double getDiag()
        {
            return this.diag;
        }

        public double getArea()
        {
            return this.area;
        }

        public void calcular()
        {

            this.area = Math.Pow(this.diag / Math.Sqrt(2), 2);

        }

    }
}
