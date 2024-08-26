namespace MovieTicketBooking.Data.Models.Dto
{
    /// <summary>
    /// Represents a data transfer object for updating user password.
    /// </summary>
    public class UserPasswordUpdate
    {
        /// <summary>
        /// Username of the user.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Old password/Existing password of the user require to update new password.
        /// </summary>
        public string? OldPassword { get; set; }

        /// <summary>
        /// New password of the user.
        /// </summary>
        public string? NewPassword { get; set; }

        /// <summary>
        /// Confirm of the new password.
        /// </summary>
        public string? ConfirmPassword { get; set; }
    }
}
