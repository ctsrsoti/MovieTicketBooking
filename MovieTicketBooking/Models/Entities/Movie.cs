using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace MovieTicketBooking.Data.Models.Entities
{
    /// <summary>
    /// Represents a movie entity.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Unique ID of the movie.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the movie.
        /// </summary>
        public string? MovieName { get; set; }

        /// <summary>
        /// URL of the movie poster.
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

        /// <summary>
        /// Date and time of creation.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Date and time when the movie was last updated.
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
