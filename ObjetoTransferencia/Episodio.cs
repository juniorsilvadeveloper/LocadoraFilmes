using System;

namespace ObjetoTransferencia
{
    public class Episodio
    {
        public int ID { get; set; }
        public Temporada IDTemporada { get; set; }
        public string NumeroEpisodio { get; set; }
        public string Titulo { get; set; }
        public string Duracao { get; set; }
        public string Link { get; set; }
        public string Sinopse { get; set; }
        public string Imagem { get; set; }
        public Boolean Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario IDUsuarioCadastrou { get; set; }
        public Usuario IDUsuarioAlterou { get; set; }
    }
}
