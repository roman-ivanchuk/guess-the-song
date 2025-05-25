namespace GuessTheSong.Constants;

public static class Paths
{
    public const string HomePage = "/";

    public const string RoomPage = "/room/{Id:guid}";
    public const string RoomPageTemplate = "/room/{0}";

    public const string RoomCodeEntryPage = "/join-room";

    public const string ParticipantNameEntryPage = "/join-room/{Id:guid}";
    public const string ParticipantNameEntryPageTemplate = "/join-room/{0}";
}
