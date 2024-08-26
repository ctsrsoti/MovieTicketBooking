using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace MovieTicketBooking.Data.Models.Entities
{
    /// <summary>
    /// Represents a ticket entity.
    /// </summary>
    public class Tickets
    {
        /// <summary>
        /// ID of the ticket.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? TicketId { get; set; }

        /// <summary>
        /// Total count of tickets.
        /// </summary>
        [BsonElement("TicketsCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// ID of the theater associated with the ticket.
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string? TheaterId { get; set; }

        /// <summary>
        /// Theater associated with the ticket.
        /// </summary>
        [BsonIgnore]
        public Theater? Theater { get; set; }

        /// <summary>
        /// ID of the movie associated with the ticket.
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string? MovieId { get; set; }

        /// <summary>
        /// Movie associated with the ticket.
        /// </summary>
        [BsonIgnore]
        public Movie? Movie { get; set; }

        /// <summary>
        /// ID of the user who booked the ticket.
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string? UserId { get; set; }

        /// <summary>
        /// User who booked the ticket.
        /// </summary>
        [BsonIgnore]
        public User? User { get; set; }

        /// <summary>
        /// Date and time when the ticket was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Date and time when the ticket was last updated.
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
