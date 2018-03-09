using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace rattrapagecsharp
{
    // Programme permettant de gerer les vecteurs 2D et 3D
    class Vecteur2D
    {
        protected double absX;
        protected double ordY;
        private static int nbreVect;

    
        public Vecteur2D()
        {
            this.absX = 0;
            this.ordY = 0;

        }
       
        public Vecteur2D(double abscisse, double ordonne)
        {
            this.absX = abscisse;
            this.ordY = ordonne;
            nbreVect++;
        }

        public Vecteur2D(Vecteur2D vecteur2D)
        {
            this.absX = vecteur2D.absX;
            this.ordY = vecteur2D.ordY;
        }
        public double AbscisseX
        {
            get { return this.absX; }
            set { this.absX = value; }
        }

        public double OrdonneY
        {
            get { return this.ordY; }
            set { this.ordY = value; }
        }

        public string Tostring()
        {

            return "X=" + this.absX + "-" + "Y=" + this.ordY;
        }

        public static bool Equals(Vecteur2D vect1, Vecteur2D vect2)
        {
            if ((vect1.absX == vect2.absX) && (vect1.ordY == vect2.ordY))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double Norme()
        {
            double x = this.absX * this.absX;
            double y = this.ordY * this.ordY;
            double z = x + y;
            double result = Math.Sqrt(z);
            return result;
        }

    }

    class Vecteur3D : Vecteur2D
    {
        protected double Z;

        public Vecteur3D()
        {
            this.Z = 0;
        }
        public Vecteur3D(double abscisse, double ordonne, double z)
            : base(abscisse, ordonne)
        {
            this.Z = z;
        }

        public Vecteur3D(Vecteur3D vecteur3D)
        {
            this.absX = vecteur3D.absX;
            this.ordY = vecteur3D.ordY;
            this.Z = vecteur3D.Z;

        }

        public double TroisiemedimensionZ
        {
            get { return this.Z; }
            set { this.Z = value; }
        }
        
        new public bool Equals()
        {
            if ((this.absX == this.ordY) && (this.absX == this.Z))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        new public string Tostring()
        {

            return "X=" + this.absX + "-" + "Y=" + this.ordY + "Z=" + this.Z;
        }
       
        new public double Norme()
        {
            double x = this.absX * this.absX;
            double y = this.ordY * this.ordY;
            double t = this.Z * this.Z;
            double z = x + y + t;
            double result = Math.Sqrt(z);
            return result;
        }
    }
}