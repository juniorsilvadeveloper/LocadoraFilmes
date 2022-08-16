using System;
using System.IO;

namespace ObjetoTransferencia
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string UsuarioLogin { get; set; }
        public string Senha { get; set; }
        public string Imagem { get; set; }
        public TipoUsuario IDTipoUsuario { get; set; }
        public Boolean Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario IDUsuarioCadastrou { get; set; }
        public Usuario IDUsuarioAlterou { get; set; }
    }
}
