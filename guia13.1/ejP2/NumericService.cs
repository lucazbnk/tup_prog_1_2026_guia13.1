using System;
using System.Collections.Generic;
using System.Text;

namespace ejP2
{
    internal class NumericService
    {
        string[] patente = new string[100];
        double[] kilometraje = new double[100];
        int cont = 0;
        int cviajes=0;

        public void RegistrarVehi(string patente, double km)
        {
            this.patente[cont] = patente;
            kilometraje[cont] = km;
            cont++;
        }

        public void CargarViaje(double km, int idx)
        {
            kilometraje[idx] = kilometraje[idx] + km;
            cviajes++;
        }

        public int CantidadViajes()
        {
            return cviajes;
        }

        public double VerKilometraje(int idx)
        {
            return kilometraje[idx];
        }
        public string VerPatente(int idx)
        {
            return patente[idx];
        }

        public void Ordenar()
        {
            for (int i = 0; i < cont-1; i++)
            {
                for (int j = i+1; j< cont; j++)
                {
                    if (kilometraje[i] > kilometraje[j])
                    {
                        double auxkm = kilometraje[i];
                        kilometraje[i] = kilometraje[j];
                        kilometraje[j] = auxkm;

                        string auxpat=patente[i];
                        patente[i] = patente[j];
                        patente[j]=auxpat;
                    }
                }
            }
        }

        public double PromKM()
        {
            double acum = 0;
            double prom = 0;
            for (int i = 0;i < cont; i++)
            {
                acum+= kilometraje[i];
            }
            prom=acum/cont;
            return prom;
        }

        public int CantidadVehiculos()
        {
            return cont;
        }

        public int BuscarPorPatente(string patente)
        {
            int idx = -1;
            int i = 0;
            while(idx==-1 && i<cont) 
            {
                if (this.patente[i] == patente) 
                    idx = i;
                i++;
            }
            return idx;
        }
    }
}
