namespace GuessTheSong.Components.Pages;

public partial class RoomCodeEntryPage
{
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    private RoomService RoomService { get; set; } = default!;

    private string RoomCode { get; set; } = string.Empty;
    private string? ErrorMessage { get; set; }

    private void JoinRoom()
    {
        ErrorMessage = null;

        if (!Guid.TryParse(RoomCode.Trim(), out var roomId))
        {
            ErrorMessage = "That doesn’t look like a valid room code.";
            return;
        }

        var room = RoomService.GetRoom(roomId);
        if (room is null)
        {
            ErrorMessage = "Couldn’t find a room with that code.";
            return;
        }

        NavigationManager.NavigateToParticipantNameEntryPage(roomId);
    }
}
