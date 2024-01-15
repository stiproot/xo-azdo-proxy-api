
internal record UpdateWiResp : Resp
{
    public WiRes Res { get; init; } = new();
}
