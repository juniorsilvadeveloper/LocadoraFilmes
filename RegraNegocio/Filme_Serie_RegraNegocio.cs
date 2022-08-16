using AcessoBancoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace RegraNegocio
{
    public class Filme_Serie_RegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Manipulacoes(string opcao, Filme_Serie filme_Serie)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@ID", filme_Serie.ID);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", filme_Serie.Titulo);

                if(filme_Serie.Genero != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Genero", filme_Serie.Genero);

                if (filme_Serie.Duracao != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Duracao", filme_Serie.Duracao);

                if (filme_Serie.Ano != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Ano", filme_Serie.Ano);

                if (filme_Serie.Classificacao != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Classificacao", filme_Serie.Classificacao);

                if (filme_Serie.Origem != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Origem", filme_Serie.Origem);

                if (filme_Serie.Link != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Link", filme_Serie.Link);
                acessoDadosSqlServer.AdicionarParametros("@Produtor_Editora", filme_Serie.Produtor_Editora);

                if (filme_Serie.Sinopse != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Sinopse", filme_Serie.Sinopse);

                if (filme_Serie.Imagem != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Imagem", filme_Serie.Imagem);

                acessoDadosSqlServer.AdicionarParametros("@Filme_Serie", filme_Serie.FilmeSerie);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", filme_Serie.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@IDUsuarioCadastrou", filme_Serie.IDUsuarioCadastrou.ID);
                acessoDadosSqlServer.AdicionarParametros("@IDUsuarioAlterou", filme_Serie.IDUsuarioAlterou.ID);

                string idFilme_Serie = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFilme_Serie").ToString();
                return idFilme_Serie;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public Filme_Serie_Colecao Consultar(string iD,
                                             string titulo,
                                             string genero,
                                             string ano,
                                             string produtor_Editora,
                                             string filmeSerie,
                                             string situacao)
        {
            try
            {
                var filme_Serie_Colecao = new Filme_Serie_Colecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 1);
                acessoDadosSqlServer.AdicionarParametros("@ID", iD);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", titulo);
                acessoDadosSqlServer.AdicionarParametros("@Genero", genero);
                acessoDadosSqlServer.AdicionarParametros("@Ano", ano);
                acessoDadosSqlServer.AdicionarParametros("@Produtor_Editora", produtor_Editora);
                acessoDadosSqlServer.AdicionarParametros("@Filme_Serie", filmeSerie);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFilme_Serie_Consultar");

                foreach (DataRow filme_Serie_Linha in dataTable.Rows)
                {
                    var filme_Serie = new Filme_Serie();

                    filme_Serie.ID = Convert.ToInt32(filme_Serie_Linha["ID"]);
                    filme_Serie.Titulo = Convert.ToString(filme_Serie_Linha["Titulo"]);
                    if (filme_Serie_Linha["Genero"] != DBNull.Value)
                        filme_Serie.Genero = Convert.ToString(filme_Serie_Linha["Genero"]);
                    if (filme_Serie_Linha["Duracao"] != DBNull.Value)
                        filme_Serie.Duracao = Convert.ToString(filme_Serie_Linha["Duracao"]);
                    if (filme_Serie_Linha["Ano"] != DBNull.Value)
                        filme_Serie.Ano = Convert.ToString(filme_Serie_Linha["Ano"]);
                    if (filme_Serie_Linha["Classificacao"] != DBNull.Value)
                        filme_Serie.Classificacao = Convert.ToString(filme_Serie_Linha["Classificacao"]);
                    if (filme_Serie_Linha["Origem"] != DBNull.Value)
                        filme_Serie.Origem = Convert.ToString(filme_Serie_Linha["Origem"]);
                    if (filme_Serie_Linha["Link"] != DBNull.Value)
                        filme_Serie.Link = Convert.ToString(filme_Serie_Linha["Link"]);
                    filme_Serie.Produtor_Editora = Convert.ToString(filme_Serie_Linha["Produtor_Editora"]);
                    if (filme_Serie_Linha["Sinopse"] != DBNull.Value)
                        filme_Serie.Sinopse = Convert.ToString(filme_Serie_Linha["Sinopse"]);
                    if (filme_Serie_Linha["Imagem"] != DBNull.Value)
                        filme_Serie.Imagem = Convert.ToString(filme_Serie_Linha["Imagem"]);
                    filme_Serie.FilmeSerie = Convert.ToString(filme_Serie_Linha["Filme_Serie"]);
                    filme_Serie.Situacao = Convert.ToBoolean(filme_Serie_Linha["Situacao"]);
                    filme_Serie.DataCadastro = Convert.ToDateTime(filme_Serie_Linha["DataCadastro"]);

                    if (filme_Serie_Linha["DataAlteracao"] != DBNull.Value)
                        filme_Serie.DataAlteracao = Convert.ToDateTime(filme_Serie_Linha["DataAlteracao"]);

                    Usuario usuarioCadastrou = new Usuario();
                    usuarioCadastrou.ID = Convert.ToInt32(filme_Serie_Linha["IDUsuarioCadastrou"]);
                    usuarioCadastrou.UsuarioLogin = Convert.ToString(filme_Serie_Linha["NomeUsuarioCadastrou"]);
                    usuarioCadastrou.Nome = Convert.ToString(filme_Serie_Linha["NomeRealUsuarioCadastrou"]);                  
                    usuarioCadastrou.Imagem = Convert.ToString(filme_Serie_Linha["ImagemUsuarioCadastrou"]);

                    var tipoUsuarioCadastrou = new TipoUsuario();
                    tipoUsuarioCadastrou.IDTipoUsuario = Convert.ToInt32(filme_Serie_Linha["IDTipoUsuarioCadastrou"]);
                    tipoUsuarioCadastrou.Descricao = Convert.ToString(filme_Serie_Linha["DescricaoTipoUsuarioCadastrou"]);
                    usuarioCadastrou.IDTipoUsuario = tipoUsuarioCadastrou;

                    filme_Serie.IDUsuarioCadastrou = usuarioCadastrou;

                    Usuario usuarioAlterou = new Usuario();
                    if (filme_Serie_Linha["IDUsuarioAlterou"] != DBNull.Value)
                        usuarioAlterou.ID = Convert.ToInt32(filme_Serie_Linha["IDUsuarioAlterou"]);
                    usuarioAlterou.UsuarioLogin = Convert.ToString(filme_Serie_Linha["NomeUsuarioAlterou"]);
                    usuarioAlterou.Nome = Convert.ToString(filme_Serie_Linha["NomeRealUsuarioAlterou"]);
                    usuarioAlterou.Imagem = Convert.ToString(filme_Serie_Linha["ImagemUsuarioAlterou"]);

                    var tipoUsuarioAlterou = new TipoUsuario();
                    if (filme_Serie_Linha["IDTipoUsuarioAlterou"] != DBNull.Value)
                        tipoUsuarioAlterou.IDTipoUsuario = Convert.ToInt32(filme_Serie_Linha["IDTipoUsuarioAlterou"]);
                    tipoUsuarioAlterou.Descricao = Convert.ToString(filme_Serie_Linha["DescricaoTipoUsuarioAlterou"]);
                    usuarioAlterou.IDTipoUsuario = tipoUsuarioAlterou;

                    filme_Serie.IDUsuarioAlterou = usuarioAlterou;

                    filme_Serie.Favoritos = Convert.ToBoolean(filme_Serie_Linha["Favoritos"]);

                    filme_Serie_Colecao.Add(filme_Serie);
                }
                return filme_Serie_Colecao;
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

                return dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFilme_Serie_Consultar");
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
