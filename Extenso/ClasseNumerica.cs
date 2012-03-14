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
                        return "milhões";
                    return "milhão";
                case 4:
                    if (plural)
                        return "bilhões";
                    return "bilhão";
                case 5:
                    if (plural)
                        return "trilhões";
                    return "trilhão";

                case 6:
                    if (plural)
                        return "quatrilhões";
                    return "quatrilhão";

                case 7:
                    if (plural)
                        return "quintilhões";
                    return "quintilhão";

                case 8:
                    if (plural)
                        return "sextilhões";
                    return "sextilhão";

                case 9:
                    if (plural)
                        return "septilhões";
                    return "septilhão";

                case 10:
                    if (plural)
                        return "octilhões";
                    return "octilhão";

                case 11:
                    if (plural)
                        return "nonilhões";
                    return "nonilhão";

                case 12:
                    if (plural)
                        return "decilhões";
                    return "decilhão";

                case 13:
                    if (plural)
                        return "undecilhões";
                    return "undecilhão";

                case 14:
                    if (plural)
                        return "doudecilhões";
                    return "doudecilhão";

                case 15:
                    if (plural)
                        return "tredecilhões";
                    return "tredecilhão";
                default:
                    throw new Exception(string.Format("classe númerica não suportada: {0}", bloco.Ordem));
            }
        }
    }
}