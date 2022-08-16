using System;

namespace ObjetoTransferencia
{
    public class Favoritos
    {
        public int ID { get; set; }
        public Usuario Usuario { get; set; }
        public Filme_Serie Filme_Serie { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
