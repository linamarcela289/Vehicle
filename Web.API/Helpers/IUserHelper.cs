using Common.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Data.Entities;
using Web.API.Models;

namespace Web.API.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);
        Task<User> GetUserAsync(Guid id);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(User user, string roleName);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task<IdentityResult> UpdateUserAsync(User user);
        Task<IdentityResult> DeleteUserAsync(User user);
        Task LogoutAsync();
        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);
        Task<User> AddUserAsync(AddUserViewModel model, Guid imageId, UserType userType);
        Task<string> GenerateEmailConfirmationTokenAsync(User user);

        Task<IdentityResult> ConfirmEmailAsync(User user, string token);
    }
}
