namespace MovieTicketBooking.Data.Models.Dto
{
    /// <summary>
    /// Represents the response for create operations such as ticket booking and updates.
    /// </summary>
    public class CreateResponse
    {
        /// <summary>
        /// Value indicating whether the operation was successful.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// The message providing details about the operation's success or failure.
        /// </summary>
        public string? Message { get; set; }
    }
}
