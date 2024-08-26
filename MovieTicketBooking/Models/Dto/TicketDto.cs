using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking.Data.Models.Dto
{
    /// <summary>
    /// Data transfer object representing ticket information for booking and updates.
    /// </summary>
    public class TicketDto
    {
        /// <summary>
        /// Number of tickets.
        /// </summary>
        public int TicketsCount { get; set; }

        /// <summary>
        /// ID of the movie.
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string? MovieId { get; set; }

        /// <summary>
        /// ID of the theater.
        /// </summary>
        public string? TheaterId { get; set; }

        /// <summary>
        /// ID of the ticket.
        /// </summary>
        public string? TicketId { get; set; }
    }
}
