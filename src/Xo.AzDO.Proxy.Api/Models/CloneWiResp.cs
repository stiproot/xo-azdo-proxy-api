
internal record CloneWiResp : Resp
{
    public CloneWiRes Res { get; init; } = new();
}