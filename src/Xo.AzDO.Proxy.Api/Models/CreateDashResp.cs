
internal record CreateDashResp : Resp
{
    public DashboardRes Res { get; init; } = new();
}