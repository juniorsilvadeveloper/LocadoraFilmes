using AcessoBancoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace RegraNegocio
{
    public class EpisodioRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Manipulacoes(string opcao, Episodio episodio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@ID", episodio.ID);
                acessoDadosSqlServer.AdicionarParametros("@IDTemporada", episodio.IDTemporada.ID);
                acessoDadosSqlServer.AdicionarParametros("@NumeroEpisodio", episodio.NumeroEpisodio);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", episodio.Titulo);
                acessoDadosSqlServer.AdicionarParametros("@Duracao", episodio.Duracao);
                acessoDadosSqlServer.AdicionarParametros("@Link", episodio.Link);
                if(episodio.Sinopse != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Sinopse", episodio.Sinopse);
                if (episodio.Imagem != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Imagem", episodio.Imagem);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", episodio.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@IDUsuarioCadastrou", episodio.IDUsuarioCadastrou.ID);
                acessoDadosSqlServer.AdicionarParametros("@IDUsuarioAlterou", episodio.IDUsuarioAlterou.ID);

                string idEpisodio = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspEpisodio").ToString();
                return idEpisodio;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public EpisodioColecao Consultar(string iD,
                                         string titulo,
                                         string numeroEpisodio,
                                         string iDTemporada,
                                         string nomeTemporada,
                                         string numeroTemporada,     
                                         string iDSerie,
                                         string nomeSerie,
                                         string situacao)
        {
            try
            {
                var episodioColecao = new EpisodioColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ID", iD);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", titulo);
                acessoDadosSqlServer.AdicionarParametros("@NumeroEpisodio", numeroEpisodio);
                acessoDadosSqlServer.AdicionarParametros("@IDTemporada", iDTemporada);
                acessoDadosSqlServer.AdicionarParametros("@NomeTemporada", nomeTemporada);
                acessoDadosSqlServer.AdicionarParametros("@NumeroTemporada", numeroTemporada);
                acessoDadosSqlServer.AdicionarParametros("@IDSerie", iDSerie);
                acessoDadosSqlServer.AdicionarParametros("@NomeSerie", nomeSerie);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEpisodioConsultar");

                foreach (DataRow episodioLinha in dataTable.Rows)
                {
                    var episodio = new Episodio();

                    episodio.ID = Convert.ToInt32(episodioLinha["ID"]);

                    var filme_Serie = new Filme_Serie();
                    filme_Serie.ID = Convert.ToInt32(episodioLinha["IDFilme_Serie"]);
                    filme_Serie.Titulo = Convert.ToString(episodioLinha["NomeFilme_Serie"]);

                    var temporada = new Temporada();
                    temporada.IDFilme_Serie = filme_Serie;
                    temporada.ID = Convert.ToInt32(episodioLinha["IDTemporada"]);
                    temporada.NumeroTemporada = Convert.ToString(episodioLinha["NumeroTemporada"]);
                    temporada.Titulo = Convert.ToString(episodioLinha["TituloTemporada"]);
                    temporada.Ano = Convert.ToInt32(episodioLinha["AnoTemporada"]);
                    episodio.IDTemporada = temporada;

                    episodio.NumeroEpisodio = Convert.ToString(episodioLinha["NumeroEpisodio"]);
                    episodio.Titulo = Convert.ToString(episodioLinha["Titulo"]);
                    episodio.Duracao = Convert.ToString(episodioLinha["Duracao"]);
                    episodio.Link = Convert.ToString(episodioLinha["Link"]);
                    episodio.Sinopse = Convert.ToString(episodioLinha["Sinopse"]);
                    episodio.Imagem = Convert.ToString(episodioLinha["Imagem"]);
                    episodio.Situacao = Convert.ToBoolean(episodioLinha["Situacao"]);
                    episodio.DataCadastro = Convert.ToDateTime(episodioLinha["DataCadastro"]);

                    if (episodioLinha["DataAlteracao"] != DBNull.Value)
                        episodio.DataAlteracao = Convert.ToDateTime(episodioLinha["DataAlteracao"]);

                    Usuario usuarioCadastrou = new Usuario();
                    usuarioCadastrou.ID = Convert.ToInt32(episodioLinha["IDUsuarioCadastrou"]);
                    usuarioCadastrou.UsuarioLogin = Convert.ToString(episodioLinha["NomeUsuarioCadastrou"]);
                    usuarioCadastrou.Nome = Convert.ToString(episodioLinha["NomeRealUsuarioCadastrou"]);
                    usuarioCadastrou.Imagem = Convert.ToString(episodioLinha["ImagemUsuarioCadastrou"]);

                    var tipoUsuarioCadastrou = new TipoUsuario();
                    tipoUsuarioCadastrou.IDTipoUsuario = Convert.ToInt32(episodioLinha["IDTipoUsuarioCadastrou"]);
                    tipoUsuarioCadastrou.Descricao = Convert.ToString(episodioLinha["DescricaoTipoUsuarioCadastrou"]);
                    usuarioCadastrou.IDTipoUsuario = tipoUsuarioCadastrou;

                    episodio.IDUsuarioCadastrou = usuarioCadastrou;

                    Usuario usuarioAlterou = new Usuario();
                    if (episodioLinha["IDUsuarioAlterou"] != DBNull.Value)
                        usuarioAlterou.ID = Convert.ToInt32(episodioLinha["IDUsuarioAlterou"]);
                    usuarioAlterou.UsuarioLogin = Convert.ToString(episodioLinha["NomeUsuarioAlterou"]);
                    usuarioAlterou.Nome = Convert.ToString(episodioLinha["NomeRealUsuarioAlterou"]);
                    usuarioAlterou.Imagem = Convert.ToString(episodioLinha["ImagemUsuarioAlterou"]);

                    var tipoUsuarioAlterou = new TipoUsuario();
                    if (episodioLinha["IDTipoUsuarioAlterou"] != DBNull.Value)
                        tipoUsuarioAlterou.IDTipoUsuario = Convert.ToInt32(episodioLinha["IDTipoUsuarioAlterou"]);
                    tipoUsuarioAlterou.Descricao = Convert.ToString(episodioLinha["DescricaoTipoUsuarioAlterou"]);
                    usuarioAlterou.IDTipoUsuario = tipoUsuarioAlterou;

                    episodio.IDUsuarioAlterou = usuarioAlterou;

                    episodioColecao.Add(episodio);
                }
                return episodioColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
