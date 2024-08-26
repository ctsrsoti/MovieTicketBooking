using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieTicketBooking.Data.Models.Entities
{
    /// <summary>
    /// Represents a user entity.
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID of the user.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>
        /// First name of the user.
        /// </summary>
        [Required]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Username of the user.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Password of the user.
        /// </summary>
        [JsonIgnore]
        public byte[]? PasswordHash { get; set; }

        /// <summary>
        /// Confirm Password of the user.
        /// </summary>
        [JsonIgnore]
        public byte[]? PasswordSalt { get; set; }

        /// <summary>
        /// Contact number of the user.
        /// </summary>
        public string? ContactNumber { get; set; }

        /// <summary>
        /// Indicating whether the user is an admin.
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Date and time when the user was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Date and time when the user was last updated.
        /// </summary>
        public DateTime Updated { get; set; }
    }

    /// <summary>
    /// User data transfer object (DTO).
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// First name of the user.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Username of the user.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Password of the user.
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Contact number of the user.
        /// </summary>
        public string? ContactNumber { get; set; }
    }
}
