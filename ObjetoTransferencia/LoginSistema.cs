using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public static class LoginSistema
    {
        private static Usuario usuarioLogin;

        public static Usuario UsuarioLogin { get => usuarioLogin; set => usuarioLogin = value; }
    }
}
