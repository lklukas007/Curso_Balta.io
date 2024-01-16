using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Helpers
{
    public class ValidadorDeTexto
    {
        public static short ValidarValorEntradaUsuario(string option)
        {
            short opcaoUsuarioValidada;
            bool entradaValida = short.TryParse(option.ToString(), out opcaoUsuarioValidada);
            if (entradaValida)
            {
            return opcaoUsuarioValidada;
            }
            else
            {
                return 0;
            }

        }

    }
}
