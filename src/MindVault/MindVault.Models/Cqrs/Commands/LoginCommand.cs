namespace MindVault.Models.Cqrs.Commands
{
    /// <summary>
    /// Represents a save an user password.
    /// </summary>
    public class LoginCommand
    {
        /// <summary>
        /// Gets or sets the password associated with the user or system.
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }
}
