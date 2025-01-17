using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.Models
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            data = data;
        }

        public int somar(int val1, int val2)
        {
            var resultado = val1 + val2;

            listaHistorico.Insert(0, "Res: " + resultado + " data: " + data);
            return resultado;
        }

        public int subtrair(int val1, int val2)
        {
            var resultado = val1 - val2;

            listaHistorico.Insert(0, "Res: " + resultado + " data: " + data);
            return resultado;
        }

        public int multiplicar(int val1, int val2)
        {
            var resultado = val1 * val2;

            listaHistorico.Insert(0, "Res: " + resultado + " data: " + data);
            return resultado;
        }

        public int dividir(int val1, int val2)
        {
            var resultado = val1 / val2;

            listaHistorico.Insert(0, "Res: " + resultado + " data: " + data);
            return resultado;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}