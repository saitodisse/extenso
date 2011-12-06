using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Extenso
{
    public class ClasseNumerica
    {
        private readonly string _texto;
        private List<Centena> _centenas;
        public List<Bloco> Blocos;

        public ClasseNumerica(string texto)
        {
            _texto = texto;
        }



        public IEnumerable<Centena> Centenas
        {
            get { return _centenas; }
        }

        public override string ToString()
        {
            var centena = Centenas.First();
            if (Centenas.Count() == 3)
            {
                if (centena.ToInt() == 1)
                    return "um milh�o";
                
                return centena + " milh�es";
            }

            var primeiraCentena = centena;
            var ultimaCentena = Centenas.Last();

            if (Centenas.Count() > 1)
            {
                return JuntaDuasCentenas(primeiraCentena, ultimaCentena);
            }

            return primeiraCentena.ToString();
        }

        private string JuntaDuasCentenas(Centena primeiraCentena, Centena ultimaCentena)
        {
            string primeiraCentenaRetorno;

            if (primeiraCentena.ToInt() == 1)
            {
                primeiraCentenaRetorno = "mil";
            }
            else
            {
                primeiraCentenaRetorno = string.Format("{0} mil", primeiraCentena);
            }

            if (ultimaCentena.ToInt() == 0)
            {
                return primeiraCentenaRetorno;
            }

            string milharComCentena;

            if (VerificarCentenaComDezenaZerada(ultimaCentena))
            {
                milharComCentena = string.Format("{0} e {1}", primeiraCentenaRetorno, ultimaCentena);
            }
            else if (VerificarCentenaZerada(ultimaCentena))
            {
                milharComCentena = string.Format("{0} e {1}", primeiraCentenaRetorno, ultimaCentena);
            }
            else
            {
                milharComCentena = string.Format("{0} {1}", primeiraCentenaRetorno, ultimaCentena);
            }

            return milharComCentena;
        }

        private bool VerificarCentenaZerada(Centena ultimaCentena)
        {
            return ultimaCentena.Algarismo_centena == '0'
                   && ultimaCentena.Dezena.ToInt() != 0;
        }

        private static bool VerificarCentenaComDezenaZerada(Centena ultimaCentena)
        {
            return ultimaCentena.Algarismo_centena != '0'
                && ultimaCentena.Dezena.ToInt() == 0;
        }

        public string OrdemPorExtenso(int ordem)
        {
            Bloco bloco = ObterBlocoPorOrdem(ordem);
            return bloco.SufixoPorExtenso();
        }

        private Bloco ObterBlocoPorOrdem(int ordem)
        {
            return Blocos.FirstOrDefault(b => b.Ordem == ordem);
        }
    }
}