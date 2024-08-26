namespace MovieTicketBooking.Data.Models.Dto
{
    /// <summary>
    /// Represents the request for user authentication.
    /// </summary>
    public class AuthenticationRequest
    {
        /// <summary>
        /// Username of the user.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Password of the user.
        /// </summary>
        public string? Password { get; set; }
    }

    /// <summary>
    /// Represents the response for user authentication.
    /// </summary>
    public class AuthenticationResponse
    {
        /// <summary>
        /// The access token generated upon successful authentication.
        /// </summary>
        public string? AccessToken { get; set; }

        /// <summary>
        /// The ID of the authenticated user.
        /// </summary>
        public string? UserId { get; set; }

        /// <summary>
        /// Value indicating whether the authenticated user is an administrator.
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}
