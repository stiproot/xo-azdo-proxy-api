
internal record BulkCreateWiReq : Req
{
    public IEnumerable<CreateWiCmd> Cmds { get; init; } = new List<CreateWiCmd>();
}