namespace GuessTheSong.Services;

public class RoomService
{
    private readonly ConcurrentDictionary<Guid, Room> _rooms = new();

    public Room Create(Guid userId)
    {
        var roomToAdd = new Room()
        {
            Id = Guid.NewGuid(),
            HostUserId = userId
        };

        if (_rooms.TryAdd(roomToAdd.Id, roomToAdd))
        {
            return roomToAdd;
        }

        throw new Exception("describe error RoomService.Create");
    }

    public Room? GetRoom(Guid id)
    {
        return _rooms.GetValueOrDefault(id);
    }
}
