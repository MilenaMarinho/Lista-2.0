using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex6
{
    internal class Quilômetros
    {
        private double milhaM;
        private double km;

        public Quilômetros()
        {
            this.milhaM = 0;
        }

        public Quilômetros(double milhaM)
        {
            this.milhaM = milhaM;
        }

        public void setMilhaM(double milhaM)
        {
            this.milhaM = milhaM;
        }

        public double getMilhaM()
        {
            return this.milhaM;
        }

        public double getKm()
        {
            return this.km;
        }

        public void calcular()
        {
            this.km = this.milhaM * 1.852;
        }
    }
}
