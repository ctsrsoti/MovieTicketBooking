namespace MovieTicketBooking.Models.Entities
{
    /// <summary>
    /// Represents a response indicating the preparation status.
    /// </summary>
    public class PrepareResponse
    {
        /// <summary>
        /// Value indicating whether the preparation was successful.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Message providing details about the preparation status.
        /// </summary>
        public string? Message { get; set; }
    }
}
