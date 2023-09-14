namespace webapi.inlock.codeFirst.manha.Utils
{
    public static class Criptografia
    {
        /// <summary>
        /// Gera uma Hash a partir de uma senha
        /// </summary>
        /// <param name="Senha">Senha que receberá uma hash</param>
        /// <returns>Senha criptografada com a hash</returns>
        public static string GerarHash(string Senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(Senha);
        }


        /// <summary>
        /// Verifica se a hash da senha informada é igual a hash salva no banco
        /// </summary>
        /// <param name="senhaForm">Senha informada pelo usuário</param>
        /// <param name="senhaBanco">Senha cadastrada no banco</param>
        /// <returns>True or False (senha é verdadeira?)</returns>
        public static bool CompararHash(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }
    }
}
