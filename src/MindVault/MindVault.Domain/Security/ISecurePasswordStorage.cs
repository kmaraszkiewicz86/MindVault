namespace MindVault.Domain.Security
{
    /// <summary>
    /// Provides secure storage operations for user passwords.
    /// </summary>
    public interface ISecurePasswordStorage
    {
        /// <summary>
        /// Saves the specified password securely.
        /// </summary>
        /// <param name="password">The password to save.</param>
        Task SavePasswordAsync(string password);

        /// <summary>
        /// Updates the stored password with a new value.
        /// </summary>
        /// <param name="newPassword">The new password to store.</param>
        Task EditPasswordAsync(string newPassword);

        /// <summary>
        /// Verifies if the provided password matches the stored password.
        /// </summary>
        /// <param name="password">The password to verify.</param>
        /// <returns>True if the password matches; otherwise, false.</returns>
        Task<bool> VerifyPasswordAsync(string password);
    }
}
