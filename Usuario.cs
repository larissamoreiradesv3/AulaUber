namespace Aula13Uber
{
    public class Usuario
    {
        
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Foto { get; set; }
        private string login = "larissamoreira.s2003@gmail.com";
        private string senha = "AmandaZoada";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; } 
        public string TipoAcesso { get; set; }

        /// <summary>
        /// Faz Login no sistema
        /// </summary>
        /// <param name="login">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>Salva o token e retorna se o login foi aprovado ou nao</returns>
        public bool Login(string login, string senha){

            if( this.login == login && this.senha == senha ){
                TokenLogin = "asdfghjklqwertyuiopzxcvbnm,.";
                return true;
            }

            return false;
        }

        /// <summary>
        /// Apaga o token do usuario
        /// </summary>
        public void Logout(){
            TokenLogin = "";
        }


    }
}