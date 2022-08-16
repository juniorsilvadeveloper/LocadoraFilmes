using System;

namespace ObjetoTransferencia
{
    public class Filme_Serie
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Duracao { get; set; }
        public string Ano { get; set; }
        public string Classificacao { get; set; }
        public string Origem { get; set; }
        public string Link { get; set; }
        public string Produtor_Editora { get; set; }
        public string Sinopse { get; set; }
        public string Imagem { get; set; }
        public string FilmeSerie { get; set; }
        public Boolean Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario IDUsuarioCadastrou { get; set; }
        public Usuario IDUsuarioAlterou { get; set; }
        public Boolean Favoritos { get; set; }
    }
}
