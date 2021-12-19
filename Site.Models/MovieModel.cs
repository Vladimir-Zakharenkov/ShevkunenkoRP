using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class MovieModel
    {
        [Key]
        public Guid MovieId { get; set; }

        [Required]
        public string MovieName { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Required]
        public string MovieCaption { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        public string DatePublished { get; set; }

        [Required]
        public string DateCreated { get; set; }

        [Required]
        public string UploadDate { get; set; }

        [Required]
        public string IsFamilyFriendly { get; set; }

        [Required]
        public string InLanguage { get; set; }

        [Required]
        public string РroductionCompany { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string MusicBy { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Description { get; set; }

        public string? Actor01 { get; set; }

        public string? Actor02 { get; set; }

        public string? Actor03 { get; set; }

        public string? Actor04 { get; set; }

        public string? Actor05 { get; set; }

        public string? Actor06 { get; set; }

        public string? Actor07 { get; set; }

        public string? Actor08 { get; set; }

        public string? Actor09 { get; set; }

        public string? Actor10 { get; set; }

        public string ContentUrl { get; set; }
    }
}
