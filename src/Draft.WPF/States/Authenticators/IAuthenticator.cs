using Draft.Domain.Entites;
using Draft.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.WPF.States.Authenticators
{
    public interface IAuthenticator
    {
        Account CurrentAccount { get; }
        bool IsLoggedIn { get; }

        event Action StateChanged;

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <returns>Результат регистрации</returns>
        Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword);
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task Login(string username, string password);

        void Logout();
    }
}
