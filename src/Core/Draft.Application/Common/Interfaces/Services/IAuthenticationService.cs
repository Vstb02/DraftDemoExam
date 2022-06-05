using Draft.Domain.Entites;
using Draft.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Application.Common.Interfaces.Services
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// Регистрация нового пользователя
        /// </summary>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <returns>Результат регистрации</returns>
        Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword);
        /// <summary>
        /// Получение аккаунта по данным пользователя
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Аккаунт пользователя</returns>
        Task<Account> Login(string username, string password);
    }
}
