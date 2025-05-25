namespace GuessTheSong.Models;

public class Room
{
    public Guid Id { get; set; }

    public Guid HostUserId { get; set; }

    public ConcurrentDictionary<Guid, Participant> Participants { get; set; } = new();
}
