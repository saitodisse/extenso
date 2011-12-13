using System;

namespace Extenso
{
    public static class ClasseNumerica
    {
        public static string SufixoDe(Bloco bloco)
        {
            int centenaNum = bloco.Centena.ToInt();

            if (centenaNum == 0)
            {
                return string.Empty;
            }

            bool plural = centenaNum > 1;

            switch (bloco.Ordem)
            {
                case 1:
                    return string.Empty;
                case 2:
                    return "mil";
                case 3:
                    if (plural)
                        return "milh�es";
                    return "milh�o";
                case 4:
                    if (plural)
                        return "bilh�es";
                    return "bilh�o";
                case 5:
                    if (plural)
                        return "trilh�es";
                    return "trilh�o";

                case 6:
                    if (plural)
                        return "quatrilh�es";
                    return "quatrilh�o";

                case 7:
                    if (plural)
                        return "quintilh�es";
                    return "quintilh�o";

                case 8:
                    if (plural)
                        return "sextilh�es";
                    return "sextilh�o";

                case 9:
                    if (plural)
                        return "septilh�es";
                    return "septilh�o";

                case 10:
                    if (plural)
                        return "octilh�es";
                    return "octilh�o";

                case 11:
                    if (plural)
                        return "nonilh�es";
                    return "nonilh�o";

                case 12:
                    if (plural)
                        return "decilh�es";
                    return "decilh�o";

                case 13:
                    if (plural)
                        return "undecilh�es";
                    return "undecilh�o";

                case 14:
                    if (plural)
                        return "doudecilh�es";
                    return "doudecilh�o";

                case 15:
                    if (plural)
                        return "tredecilh�es";
                    return "tredecilh�o";
                default:
                    throw new Exception(string.Format("classe n�merica n�o suportada: {0}", bloco.Ordem));
            }
        }

        //private readonly string _texto;
        //private List<Centena> _centenas;
        //public List<Bloco> Blocos;

        //public ClasseNumerica(string texto)
        //{
        //    _texto = texto;
        //}


        //public IEnumerable<Centena> Centenas
        //{
        //    get { return _centenas; }
        //}

        //public override string ToString()
        //{
        //    var centena = Centenas.First();
        //    if (Centenas.Count() == 3)
        //    {
        //        if (centena.ToInt() == 1)
        //            return "um milh�o";

        //        return centena + " milh�es";
        //    }

        //    var primeiraCentena = centena;
        //    var ultimaCentena = Centenas.Last();

        //    if (Centenas.Count() > 1)
        //    {
        //        return JuntaDuasCentenas(primeiraCentena, ultimaCentena);
        //    }

        //    return primeiraCentena.ToString();
        //}

        //private string JuntaDuasCentenas(Centena primeiraCentena, Centena ultimaCentena)
        //{
        //    string primeiraCentenaRetorno;

        //    if (primeiraCentena.ToInt() == 1)
        //    {
        //        primeiraCentenaRetorno = "mil";
        //    }
        //    else
        //    {
        //        primeiraCentenaRetorno = string.Format("{0} mil", primeiraCentena);
        //    }

        //    if (ultimaCentena.ToInt() == 0)
        //    {
        //        return primeiraCentenaRetorno;
        //    }

        //    string milharComCentena;

        //    if (VerificarCentenaComDezenaZerada(ultimaCentena))
        //    {
        //        milharComCentena = string.Format("{0} e {1}", primeiraCentenaRetorno, ultimaCentena);
        //    }
        //    else if (VerificarCentenaZerada(ultimaCentena))
        //    {
        //        milharComCentena = string.Format("{0} e {1}", primeiraCentenaRetorno, ultimaCentena);
        //    }
        //    else
        //    {
        //        milharComCentena = string.Format("{0} {1}", primeiraCentenaRetorno, ultimaCentena);
        //    }

        //    return milharComCentena;
        //}

        //private bool VerificarCentenaZerada(Centena ultimaCentena)
        //{
        //    return ultimaCentena.Algarismo_centena == '0'
        //           && ultimaCentena.Dezena.ToInt() != 0;
        //}

        //private static bool VerificarCentenaComDezenaZerada(Centena ultimaCentena)
        //{
        //    return ultimaCentena.Algarismo_centena != '0'
        //        && ultimaCentena.Dezena.ToInt() == 0;
        //}

        //public string OrdemPorExtenso(int ordem)
        //{
        //    Bloco bloco = ObterBlocoPorOrdem(ordem);
        //    return bloco.SufixoPorExtenso();
        //}

        //private Bloco ObterBlocoPorOrdem(int ordem)
        //{
        //    return Blocos.FirstOrDefault(b => b.Ordem == ordem);
        //}
    }
}