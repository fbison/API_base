using ApiBase.Domain.Models;
namespace ApiBase.Domain.Consts
{
    public static class Errors
    {
        #region Global
        public static readonly Notificacao GlobalErroDeRepositorio = new("Err01", "Erro durante a execução da requisição, tente mais tarde");
        #endregion

        public static readonly Notificacao RequestInvalido = new("Err02", "Dados enviados incorretamente");
        public static readonly Notificacao SenhaInvalida = new("Err03", "Não tem autorização para acessar essa url");
        public static readonly Notificacao DeletarFalhou = new("Err04", "Não Foi possível deletar");
        public static readonly Notificacao EditarFalhou = new("Err05", "Não Foi possível editar");
        public static readonly Notificacao CriarFalhou = new("Err06", "Não Foi possível criar");
        public static readonly Notificacao IdNaoEncontrado = new("Err07", "Esse registro não foi encontrado");
        public static readonly Notificacao ObterPorIdFalhou = new("Err08", "Não Foi possível obter pelo Id");
        public static readonly Notificacao ObterTodosFalhou = new("Err08", "Não Foi possível obter todos");

        public static readonly Notificacao DadosEnviadosIncorretamente = new("Err11", "Dados enviados incorretamente");
        public static readonly Notificacao ErroInesperado = new("Err12", "Ocorreu um erro inesperado");
        #region Usuario
        public static readonly Notificacao UsuarioLoginExiste = new("Err21", "Esse login não está disponível");
        public static readonly Notificacao UsuarioApplicationUsuarioNaoEncontrado = new("Err22", "Usuário não encontrado");
        public static readonly Notificacao UsuarioApplicationUsuarioReferenciado = new("Err23", "Usuário referenciado em outra tabela");
        public static readonly Notificacao UsuarioApplicationUsuarioDesativado = new("Err24", "Usuário desativado");
        public static readonly Notificacao UsuarioApplicationSenhaInvalida = new("Err25", "Senha inválida");
        public static readonly Notificacao UsuarioApplicationUsuarioInvalido = new("Err26", "Usuário informado é inválido ou não existe");
        public static readonly Notificacao UsuarioSemLogin = new("Err27", "Login é obrigatório");
        public static readonly Notificacao UsuarioAutoDesativando = new("Err28", "O usuário logado não pode se desativar");
        public static readonly Notificacao UsuarioAutoDeletando = new("Err29", "O usuário logado não pode se deletar");
        public static readonly Notificacao UsuarioTrocandoPermissao = new("Err2A", "O usuário logado não pode trocar sua permissão");

        #endregion

    }
}