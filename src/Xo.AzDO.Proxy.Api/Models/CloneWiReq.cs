
internal record CloneWiReq : Req
{
    public CloneWiCmd Cmd { get; init; } = new();
}