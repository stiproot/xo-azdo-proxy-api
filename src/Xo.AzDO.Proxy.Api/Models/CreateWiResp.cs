
internal record CreateWiResp : Resp
{
    public WiRes Res { get; init; } = new();
}