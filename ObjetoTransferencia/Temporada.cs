using System;

namespace ObjetoTransferencia
{
    public class Temporada
    {
        public int ID { get; set; }
        public Filme_Serie IDFilme_Serie { get; set; }
        public string NumeroTemporada { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Duracao { get; set; }
        public int Ano { get; set; }
        public int Classificacao { get; set; }
        public string Origem { get; set; }
        public string Produtor_Editora { get; set; }
        public string Sinopse { get; set; }
        public string Imagem { get; set; }
        public Boolean Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario IDUsuarioCadastrou { get; set; }
        public Usuario IDUsuarioAlterou { get; set; }
    }
}
