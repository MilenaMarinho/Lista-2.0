using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Retangulo
    {
        private double b;
        private double h;
        private double area;

        public Retangulo()
        { 
        this.b = 0;
        this.h = 0;
        }
        public Retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public void setB(double b)
        {
            this.b = b;
            
        }
        public void setH(double h)
        {
            this.h = h;
           
        }
        public double getB()
        {
            return this.b;
        }
        public double getH()
        {
            return this.h;
        }

        public double getArea()
        {
            return this.area;
        }
        public void calcular()
        {
            this.area = this.b * this.h;
        }
    }
}
