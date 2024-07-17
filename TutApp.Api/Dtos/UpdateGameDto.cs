using System.ComponentModel.DataAnnotations;

namespace TutApp.Api.Dtos;

public record class UpdateGameDto(
    [Required][StringLength(50)] string Name, 
    [Required][StringLength(20)] string Genre, 
    [Required][Range(1, 100)]decimal Price, 
    DateOnly ReleaseDate);
