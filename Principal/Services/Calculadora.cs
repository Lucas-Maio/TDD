using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Principal.Services
{
    public class Calculadora
    {

        private List<string> _Historico;
        private readonly DateTime data;

        public List<string> HistoricoComIndice()
        {
            var historicoComIndice = new List<string>();

            for (int i = 0; i < _Historico.Count; i++)
            {
                historicoComIndice.Add($"{i + 1}: {_Historico[i]}");
            }

            return historicoComIndice;
        }

        public Calculadora(DateTime data)
        {
            _Historico = new List<string>();
            this.data = data;
        }

        public Calculadora()
        {
            _Historico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            _Historico.Insert(0, "Res:" + res);
            return res;
        }
        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            _Historico.Insert(0, "Res:" + res);
            return res;
        }
        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            _Historico.Insert(0, "Res:" + res);
            return res;
        }
        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            _Historico.Insert(0, "Res:" + res);
            return res;
        }
        public List<string> Historico()
        {
            _Historico.RemoveRange(3, _Historico.Count() - 3);
            return _Historico.ToList();
        }
    }
}