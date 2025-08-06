using MindVault.Domain.Security;
using Microsoft.Maui.Storage;

namespace MindVault.Infrastructure.Maui.Security
{
    /// <summary>
    /// Secure password storage implementation using .NET MAUI SecureStorage.
    /// </summary>
    public class MauiSecurePasswordStorage : ISecurePasswordStorage
    {
        private const string PasswordKey = "user_password";

        /// <summary>
        /// Saves the specified password securely in platform storage.
        /// </summary>
        public Task SavePasswordAsync(string password)
            => SecureStorage.SetAsync(PasswordKey, password);

        /// <summary>
        /// Updates the stored password with a new value.
        /// </summary>
        public Task EditPasswordAsync(string newPassword)
            => SecureStorage.SetAsync(PasswordKey, newPassword);

        /// <summary>
        /// Verifies if the provided password matches the stored password.
        /// </summary>
        public async Task<bool> VerifyPasswordAsync(string password)
        {
            var storedPassword = await SecureStorage.GetAsync(PasswordKey);
            return storedPassword == password;
        }
    }
}
