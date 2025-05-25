namespace GuessTheSong.Models;

public class Participant
{
    public Guid UserId { get; set; }

    public string UserName { get; set; } = string.Empty;
}
