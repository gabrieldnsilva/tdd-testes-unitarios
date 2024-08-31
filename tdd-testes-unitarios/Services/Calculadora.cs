using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tdd_testes_unitarios.Services
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }
        public int Somar(int num1, int num2)
        {

            var res = num1 + num2;

            listaHistorico.Insert(0, "Res: " + res);

            return res;

            
        }

        public int Subtrair(int num1, int num2)
        {
            var res = num1 - num2;

            listaHistorico.Insert(0, "Res: " + res);

            return res;

            
        }

        public int Multiplicar(int num1, int num2)
        {
            var res = num1 * num2;
            
            listaHistorico.Insert(0, "Res: " + res);

            return res;

            
        }

        public int Dividir(int num1, int num2)
        {
            var res = num1 / num2;
            
            listaHistorico.Insert(0, "Res: " + res);
            
            return res;

           
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}