namespace GuessTheSong.Extensions;

/// <summary>
/// Extension methods for <see cref="NavigationManager"/> to provide strongly-typed navigation.
/// </summary>
public static class NavigationManagerExtensions
{
    public static void NavigateToRoomPage(this NavigationManager nav, Guid roomId, bool forceLoad = false)
    {
        var path = string.Format(Paths.RoomPageTemplate, roomId);
        nav.NavigateTo(path, forceLoad);
    }

    public static void NavigateToRoomCodeEntryPage(this NavigationManager nav, bool forceLoad = false)
    {
        nav.NavigateTo(Paths.RoomCodeEntryPage, forceLoad);
    }

    public static void NavigateToParticipantNameEntryPage(this NavigationManager nav, Guid roomId, bool forceLoad = false)
    {
        var path = string.Format(Paths.ParticipantNameEntryPageTemplate, roomId);
        nav.NavigateTo(path, forceLoad);
    }
}
