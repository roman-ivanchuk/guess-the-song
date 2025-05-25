namespace GuessTheSong.Components.Pages;

public partial class RoomPage
{
    [Parameter]
    public Guid Id { get; set; }

    [Inject]
    private RoomService RoomService { get; set; } = default!;

    private Room Room { get; set; } = new();
    private string? ErrorMessage { get; set; }

    protected override void OnParametersSet()
    {
        var room = RoomService.GetRoom(Id);

        if (room is null)
        {
            ErrorMessage = "cannot find rrom";
        }
        else
        {
            Room = room;
        }
    }
}
