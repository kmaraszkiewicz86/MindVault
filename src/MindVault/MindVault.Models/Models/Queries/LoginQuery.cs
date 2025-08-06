namespace MindVault.Models.Models.Queries
{
    /// <summary>
    /// Represents a query containing login credentials for authentication purposes.
    /// </summary>
    public class LoginQuery
    {
        /// <summary>
        /// Gets or sets the password associated with the user or system.
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }
}
