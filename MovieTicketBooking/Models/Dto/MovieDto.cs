namespace MovieTicketBooking.Data.Models.Dto
{
    /// <summary>
    /// Represents a data transfer object for movie information.
    /// </summary>
    public class MovieDto
    {
        /// <summary>
        /// Name of the movie.
        /// </summary>
        public string? MovieName { get; set; }

        /// <summary>
        ///  URL of the movie poster.
        /// </summary>
        public string? MoviePoster { get; set; }

        /// <summary>
        /// Genre of the movie.
        /// </summary>
        public string? Genre { get; set; }

        /// <summary>
        /// Description of the movie.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Languages in which the movie is available.
        /// </summary>
        public string? Languages { get; set; }
    }
}
