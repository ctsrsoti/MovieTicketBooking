using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MovieTicketBooking.Data.Models.Entities
{
    /// <summary>
    /// Represents a theater entity.
    /// </summary>
    public class Theater
    {
        /// <summary>
        /// ID of the theater.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the theater.
        /// </summary>
        public string? TheaterName { get; set; }

        /// <summary>
        /// City where the theater is located.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Number of available seats in the theater.
        /// </summary>
        [BsonElement("SeatCount")]
        public int AvailableSeat { get; set; }

        /// <summary>
        /// Date and time when the theater was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Date and time when the theater was last updated.
        /// </summary>
        public DateTime Updated { get; set; }
    }

    /// <summary>
    /// Represents a data transfer object for theater information.
    /// </summary>
    public class TheaterDto
    {
        /// <summary>
        /// Name of the theater.
        /// </summary>
        public string? TheaterName { get; set; }

        /// <summary>
        /// City where the theater is located.
        /// </summary>
        public string? City { get; set; }
    }
}
