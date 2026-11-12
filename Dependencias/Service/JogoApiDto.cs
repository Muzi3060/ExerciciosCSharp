public class JogoApiDto(int id, string? name, double rating, int playTimeMinutes)
{
    public int Id { get; set; } = id;
    public string? Name { get; set; } = name;
    public double Rating { get; set; } = rating;
    public int PlayTimeMinutes { get; set; } = playTimeMinutes;
}