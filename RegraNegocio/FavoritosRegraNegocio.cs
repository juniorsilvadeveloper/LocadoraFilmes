using System;
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace RegraNegocio
{
    public class FavoritosRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Manipulacoes(string opcao, Favoritos favoritos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                if (favoritos.ID != 0)
                    acessoDadosSqlServer.AdicionarParametros("@ID", favoritos.ID);
                acessoDadosSqlServer.AdicionarParametros("@IDUsuario", LoginSistema.UsuarioLogin.ID);
                acessoDadosSqlServer.AdicionarParametros("@IDFilmeSerie", favoritos.Filme_Serie.ID);

                string idFavoritos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFavoritos").ToString();
                return idFavoritos;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public FavoritosColecao Consultar(string filmeSerie,
                                          string titulo,
                                          string genero,
                                          string produtor_Editora)
        {
            try
            {
                var favoritosColecao = new FavoritosColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Filme_Serie", filmeSerie);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", titulo);
                acessoDadosSqlServer.AdicionarParametros("@Genero", genero);
                acessoDadosSqlServer.AdicionarParametros("@Produtor_Editora", produtor_Editora);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFavoritos_Consultar");

                foreach (DataRow FavoritosLinha in dataTable.Rows)
                {
                    var favoritos = new Favoritos();
                    var filme_Serie = new Filme_Serie();

                    filme_Serie.FilmeSerie = Convert.ToString(FavoritosLinha["Filme_Serie"]);
                    filme_Serie.Titulo = Convert.ToString(FavoritosLinha["Titulo"]);
                    filme_Serie.Genero = Convert.ToString(FavoritosLinha["Genero"]);
                    filme_Serie.Produtor_Editora = Convert.ToString(FavoritosLinha["Produtor_Editora"]);
                    favoritos.Filme_Serie = filme_Serie;

                    favoritos.DataCriacao = Convert.ToDateTime(FavoritosLinha["DataCriacao"]);

                    favoritosColecao.Add(favoritos);
                }
                return favoritosColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
