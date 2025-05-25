namespace GuessTheSong.Components.Pages;

public partial class HomePage
{
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    private RoomService RoomService { get; set; } = default!;

    private void CreateRoom()
    {
        // TODO: replace with value from ProtectedLocalStorage
        var userId = Guid.NewGuid();

        var room = RoomService.Create(userId);

        NavigationManager.NavigateToRoomPage(room.Id);
    }

    private void JoinRoom()
    {
        NavigationManager.NavigateToRoomCodeEntryPage();
    }
}
