using System;
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace RegraNegocio
{
    public class TemporadaRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Manipulacoes(string opcao, Temporada temporada)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@ID", temporada.ID);
                acessoDadosSqlServer.AdicionarParametros("@IDFilme_Serie", temporada.IDFilme_Serie.ID);
                acessoDadosSqlServer.AdicionarParametros("@NumeroTemporada", temporada.NumeroTemporada);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", temporada.Titulo);
                acessoDadosSqlServer.AdicionarParametros("@Genero", temporada.Genero);

                if(temporada.Duracao != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Duracao", temporada.Duracao);

                acessoDadosSqlServer.AdicionarParametros("@Ano", temporada.Ano);
                acessoDadosSqlServer.AdicionarParametros("@Classificacao", temporada.Classificacao);

                if (temporada.Origem != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Origem", temporada.Origem);

                acessoDadosSqlServer.AdicionarParametros("@Produtor_Editora", temporada.Produtor_Editora);

                if (temporada.Sinopse != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Sinopse", temporada.Sinopse);

                if (temporada.Imagem != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Imagem", temporada.Imagem);

                acessoDadosSqlServer.AdicionarParametros("@Situacao", temporada.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@IDUsuarioCadastrou", temporada.IDUsuarioCadastrou.ID);
                acessoDadosSqlServer.AdicionarParametros("@IDUsuarioAlterou", temporada.IDUsuarioAlterou.ID);

                string idFilme_Serie = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTemporada").ToString();
                return idFilme_Serie;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public TemporadaColecao Consultar(string iD,
                                          string titulo,
                                          string numeroTemporada,
                                          string genero,
                                          string ano,
                                          string produtor_Editora,
                                          string iDSerie,
                                          string nomeSerie,
                                          string situacao)
        {
            try
            {
                var temporadaColecao = new TemporadaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 1);
                acessoDadosSqlServer.AdicionarParametros("@ID", iD);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", titulo);
                acessoDadosSqlServer.AdicionarParametros("@NumeroTemporada", numeroTemporada);
                acessoDadosSqlServer.AdicionarParametros("@Genero", genero);
                acessoDadosSqlServer.AdicionarParametros("@Ano", ano);
                acessoDadosSqlServer.AdicionarParametros("@Produtor_Editora", produtor_Editora);
                acessoDadosSqlServer.AdicionarParametros("@IDSerie", iDSerie);
                acessoDadosSqlServer.AdicionarParametros("@NomeSerie", nomeSerie);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTemporadaConsultar");

                foreach (DataRow temporadaLinha in dataTable.Rows)
                {
                    var temporada = new Temporada();

                    temporada.ID = Convert.ToInt32(temporadaLinha["ID"]);

                    var filmeSerie = new Filme_Serie();
                    filmeSerie.ID = Convert.ToInt32(temporadaLinha["IDFilme_Serie"]);
                    filmeSerie.Titulo = Convert.ToString(temporadaLinha["TituloFilmeSerie"]);
                    temporada.IDFilme_Serie = filmeSerie;

                    temporada.NumeroTemporada = Convert.ToString(temporadaLinha["NumeroTemporada"]);
                    temporada.Titulo = Convert.ToString(temporadaLinha["Titulo"]);
                    temporada.Genero = Convert.ToString(temporadaLinha["Genero"]);
                    temporada.Duracao = Convert.ToString(temporadaLinha["Duracao"]);
                    temporada.Ano = Convert.ToInt32(temporadaLinha["Ano"]);
                    temporada.Classificacao = Convert.ToInt32(temporadaLinha["Classificacao"]);
                    temporada.Origem = Convert.ToString(temporadaLinha["Origem"]);
                    temporada.Produtor_Editora = Convert.ToString(temporadaLinha["Produtor_Editora"]);
                    temporada.Sinopse = Convert.ToString(temporadaLinha["Sinopse"]);
                    temporada.Imagem = Convert.ToString(temporadaLinha["Imagem"]);
                    temporada.Situacao = Convert.ToBoolean(temporadaLinha["Situacao"]);
                    temporada.DataCadastro = Convert.ToDateTime(temporadaLinha["DataCadastro"]);

                    if (temporadaLinha["DataAlteracao"] != DBNull.Value)
                        temporada.DataAlteracao = Convert.ToDateTime(temporadaLinha["DataAlteracao"]);

                    Usuario usuarioCadastrou = new Usuario();
                    usuarioCadastrou.ID = Convert.ToInt32(temporadaLinha["IDUsuarioCadastrou"]);
                    usuarioCadastrou.UsuarioLogin = Convert.ToString(temporadaLinha["NomeUsuarioCadastrou"]);
                    usuarioCadastrou.Nome = Convert.ToString(temporadaLinha["NomeRealUsuarioCadastrou"]);
                    usuarioCadastrou.Imagem = Convert.ToString(temporadaLinha["ImagemUsuarioCadastrou"]);

                    var tipoUsuarioCadastrou = new TipoUsuario();
                    tipoUsuarioCadastrou.IDTipoUsuario = Convert.ToInt32(temporadaLinha["IDTipoUsuarioCadastrou"]);
                    tipoUsuarioCadastrou.Descricao = Convert.ToString(temporadaLinha["DescricaoTipoUsuarioCadastrou"]);
                    usuarioCadastrou.IDTipoUsuario = tipoUsuarioCadastrou;

                    temporada.IDUsuarioCadastrou = usuarioCadastrou;

                    Usuario usuarioAlterou = new Usuario();
                    if (temporadaLinha["IDUsuarioAlterou"] != DBNull.Value)
                        usuarioAlterou.ID = Convert.ToInt32(temporadaLinha["IDUsuarioAlterou"]);
                    usuarioAlterou.UsuarioLogin = Convert.ToString(temporadaLinha["NomeUsuarioAlterou"]);
                    usuarioAlterou.Nome = Convert.ToString(temporadaLinha["NomeRealUsuarioAlterou"]);
                    usuarioAlterou.Imagem = Convert.ToString(temporadaLinha["ImagemUsuarioAlterou"]);

                    var tipoUsuarioAlterou = new TipoUsuario();
                    if (temporadaLinha["IDTipoUsuarioAlterou"] != DBNull.Value)
                        tipoUsuarioAlterou.IDTipoUsuario = Convert.ToInt32(temporadaLinha["IDTipoUsuarioAlterou"]);
                    tipoUsuarioAlterou.Descricao = Convert.ToString(temporadaLinha["DescricaoTipoUsuarioAlterou"]);
                    usuarioAlterou.IDTipoUsuario = tipoUsuarioAlterou;

                    temporada.IDUsuarioAlterou = usuarioAlterou;

                    temporadaColecao.Add(temporada);
                }
                return temporadaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        public DataTable CarregarComboBox()
        {
            try
            {
                var dataTable = new DataTable();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 2);

                return dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTemporadaConsultar");
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
