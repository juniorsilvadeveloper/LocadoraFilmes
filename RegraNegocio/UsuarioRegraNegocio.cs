using AcessoBancoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace RegraNegocio
{
    public class UsuarioRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Manipulacoes(string opcao, Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@ID", usuario.ID);
                acessoDadosSqlServer.AdicionarParametros("@Email", usuario.Email);
                if(usuario.Telefone != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Telefone", usuario.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Nome", usuario.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Usuario", usuario.UsuarioLogin);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", usuario.Senha);
                if (usuario.Imagem != string.Empty)
                    acessoDadosSqlServer.AdicionarParametros("@Imagem", usuario.Imagem);
                acessoDadosSqlServer.AdicionarParametros("@IDTipoUsuario", usuario.IDTipoUsuario.IDTipoUsuario);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", usuario.Situacao);
                if (LoginSistema.UsuarioLogin != null)
                    acessoDadosSqlServer.AdicionarParametros("@IDUsuarioCadastrou", usuario.IDUsuarioCadastrou.ID);
                if (LoginSistema.UsuarioLogin != null)
                    acessoDadosSqlServer.AdicionarParametros("@IDUsuarioAlterou", usuario.IDUsuarioAlterou.ID);

                string idUsuario = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuario").ToString();
                return idUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public Usuario ConsultarCodigoUnico(string iD)
        {
            try
            {
                var usuario = new Usuario();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDUsuario", iD);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioConsultar");

                foreach (DataRow usuarioLinha in dataTable.Rows)
                {
                    usuario.ID = Convert.ToInt32(usuarioLinha["ID"]);
                    usuario.Email = Convert.ToString(usuarioLinha["Email"]);
                    usuario.Telefone = Convert.ToString(usuarioLinha["Telefone"]);
                    usuario.Nome = Convert.ToString(usuarioLinha["Nome"]);
                    usuario.UsuarioLogin = Convert.ToString(usuarioLinha["Usuario"]);
                    usuario.Senha = Convert.ToString(usuarioLinha["Senha"]);
                    usuario.Imagem = Convert.ToString(usuarioLinha["Imagem"]);

                    var tipoUsuario = new TipoUsuario();
                    tipoUsuario.IDTipoUsuario = Convert.ToInt32(usuarioLinha["IDTipoUsuario"]);
                    tipoUsuario.Descricao = Convert.ToString(usuarioLinha["DescricaoTipoUsuario"]);
                    usuario.IDTipoUsuario = tipoUsuario;

                    usuario.Situacao = Convert.ToBoolean(usuarioLinha["Situacao"]);
                    usuario.DataCadastro = Convert.ToDateTime(usuarioLinha["DataCadastro"]);
                    if (usuarioLinha["DataAlteracao"] != DBNull.Value)
                        usuario.DataAlteracao = Convert.ToDateTime(usuarioLinha["DataAlteracao"]);

                    var usuarioCadastrou = new Usuario();
                    if (usuarioLinha["IDUsuarioCadastrou"] != DBNull.Value)
                        usuarioCadastrou.ID = Convert.ToInt32(usuarioLinha["IDUsuarioCadastrou"]);
                    usuarioCadastrou.UsuarioLogin = Convert.ToString(usuarioLinha["NomeUsuarioCadastrou"]);
                    usuarioCadastrou.Nome = Convert.ToString(usuarioLinha["NomeRealUsuarioCadastrou"]);
                    usuarioCadastrou.Imagem = Convert.ToString(usuarioLinha["ImagemUsuarioCadastrou"]);

                    var tipoUsuarioCadastrou = new TipoUsuario();
                    tipoUsuarioCadastrou.IDTipoUsuario = Convert.ToInt32(usuarioLinha["IDTipoUsuarioCadastrou"]);
                    tipoUsuarioCadastrou.Descricao = Convert.ToString(usuarioLinha["DescricaoTipoUsuarioCadastrou"]);
                    usuarioCadastrou.IDTipoUsuario = tipoUsuarioCadastrou;

                    usuario.IDUsuarioCadastrou = usuarioCadastrou;

                    var usuarioAlterou = new Usuario();
                    if (usuarioLinha["IDUsuarioAlterou"] != DBNull.Value)
                        usuarioAlterou.ID = Convert.ToInt32(usuarioLinha["IDUsuarioAlterou"]);
                    usuarioAlterou.UsuarioLogin = Convert.ToString(usuarioLinha["NomeUsuarioAlterou"]);
                    usuarioAlterou.Nome = Convert.ToString(usuarioLinha["NomeRealUsuarioAlterou"]);
                    usuarioAlterou.Imagem = Convert.ToString(usuarioLinha["ImagemUsuarioAlterou"]);

                    var tipoUsuarioAlterou = new TipoUsuario();
                    if (usuarioLinha["IDTipoUsuarioAlterou"] != DBNull.Value)
                        tipoUsuarioAlterou.IDTipoUsuario = Convert.ToInt32(usuarioLinha["IDTipoUsuarioAlterou"]);
                    tipoUsuarioAlterou.Descricao = Convert.ToString(usuarioLinha["DescricaoTipoUsuarioAlterou"]);
                    usuarioAlterou.IDTipoUsuario = tipoUsuarioAlterou;

                    usuario.IDUsuarioAlterou = usuarioAlterou;
                }
                return usuario;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        public UsuarioColecao Consultar(string iDUsuario,
                                        string nomeUsuario,
                                        string nomeReal,
                                        string iDTipoUsuario,
                                        string situacao)
        {
            try
            {
                var usuarioColecao = new UsuarioColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDUsuario", iDUsuario);
                acessoDadosSqlServer.AdicionarParametros("@NomeUsuario", nomeUsuario);
                acessoDadosSqlServer.AdicionarParametros("@NomeReal", nomeReal);
                acessoDadosSqlServer.AdicionarParametros("@IDTipoUsuario", iDTipoUsuario);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@IDUsuarioLogado", LoginSistema.UsuarioLogin.ID);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioConsultar");

                foreach (DataRow usuarioLinha in dataTable.Rows)
                {
                    var usuario = new Usuario();

                    usuario.ID = Convert.ToInt32(usuarioLinha["ID"]);
                    usuario.Email = Convert.ToString(usuarioLinha["Email"]);
                    usuario.Telefone = Convert.ToString(usuarioLinha["Telefone"]);
                    usuario.Nome = Convert.ToString(usuarioLinha["Nome"]);
                    usuario.UsuarioLogin = Convert.ToString(usuarioLinha["Usuario"]);
                    usuario.Senha = Convert.ToString(usuarioLinha["Senha"]);
                    usuario.Imagem = Convert.ToString(usuarioLinha["Imagem"]);

                    var tipoUsuario = new TipoUsuario();
                    tipoUsuario.IDTipoUsuario = Convert.ToInt32(usuarioLinha["IDTipoUsuario"]);
                    tipoUsuario.Descricao = Convert.ToString(usuarioLinha["DescricaoTipoUsuario"]);
                    usuario.IDTipoUsuario = tipoUsuario;

                    usuario.Situacao = Convert.ToBoolean(usuarioLinha["Situacao"]);
                    usuario.DataCadastro = Convert.ToDateTime(usuarioLinha["DataCadastro"]);
                    if (usuarioLinha["DataAlteracao"] != DBNull.Value)
                        usuario.DataAlteracao = Convert.ToDateTime(usuarioLinha["DataAlteracao"]);

                    var usuarioCadastrou = new Usuario();
                    if (usuarioLinha["IDUsuarioCadastrou"] != DBNull.Value)
                        usuarioCadastrou.ID = Convert.ToInt32(usuarioLinha["IDUsuarioCadastrou"]);
                    usuarioCadastrou.UsuarioLogin = Convert.ToString(usuarioLinha["NomeUsuarioCadastrou"]);
                    usuarioCadastrou.Nome = Convert.ToString(usuarioLinha["NomeRealUsuarioCadastrou"]);
                    usuarioCadastrou.Imagem = Convert.ToString(usuarioLinha["ImagemUsuarioCadastrou"]);

                    var tipoUsuarioCadastrou = new TipoUsuario();
                    tipoUsuarioCadastrou.IDTipoUsuario = Convert.ToInt32(usuarioLinha["IDTipoUsuarioCadastrou"]);
                    tipoUsuarioCadastrou.Descricao = Convert.ToString(usuarioLinha["DescricaoTipoUsuarioCadastrou"]);
                    usuarioCadastrou.IDTipoUsuario = tipoUsuarioCadastrou;

                    usuario.IDUsuarioCadastrou = usuarioCadastrou;

                    var usuarioAlterou = new Usuario();
                    if (usuarioLinha["IDUsuarioAlterou"] != DBNull.Value)
                        usuarioAlterou.ID = Convert.ToInt32(usuarioLinha["IDUsuarioAlterou"]);
                    usuarioAlterou.UsuarioLogin = Convert.ToString(usuarioLinha["NomeUsuarioAlterou"]);
                    usuarioAlterou.Nome = Convert.ToString(usuarioLinha["NomeRealUsuarioAlterou"]);
                    usuarioAlterou.Imagem = Convert.ToString(usuarioLinha["ImagemUsuarioAlterou"]);

                    var tipoUsuarioAlterou = new TipoUsuario();
                    if (usuarioLinha["IDTipoUsuarioAlterou"] != DBNull.Value)
                        tipoUsuarioAlterou.IDTipoUsuario = Convert.ToInt32(usuarioLinha["IDTipoUsuarioAlterou"]);
                    tipoUsuarioAlterou.Descricao = Convert.ToString(usuarioLinha["DescricaoTipoUsuarioAlterou"]);
                    usuarioAlterou.IDTipoUsuario = tipoUsuarioAlterou;

                    usuario.IDUsuarioAlterou = usuarioAlterou;

                    usuarioColecao.Add(usuario);
                }
                return usuarioColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        public string validarLogin(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 4);
                acessoDadosSqlServer.AdicionarParametros("@Usuario", usuario.UsuarioLogin);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", usuario.Senha);

                string ID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuario").ToString();
                return ID;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
