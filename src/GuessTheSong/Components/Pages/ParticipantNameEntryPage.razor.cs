namespace GuessTheSong.Components.Pages;

public partial class ParticipantNameEntryPage
{
    [Parameter]
    public Guid Id { get; set; }

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    private RoomService RoomService { get; set; } = default!;

    private Room Room { get; set; } = new();
    private string ParticipantName { get; set; } = string.Empty;
    private string? ErrorMessage { get; set; }

    protected override void OnInitialized()
    {
        Room = RoomService.GetRoom(Id)
            ?? throw new Exception("Oops — that room doesn’t exist.");
    }

    private void JoinRoom()
    {
        ErrorMessage = null;

        if (string.IsNullOrWhiteSpace(ParticipantName))
        {
            ErrorMessage = "Please enter your name to join.";
            return;
        }

        NavigationManager.NavigateToRoomPage(Room.Id);
    }
}
