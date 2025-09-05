using Microsoft.EntityFrameworkCore;

namespace Cos.Internal.Dashboards.Data;

public class CosDahboardsContext(DbContextOptions<CosDahboardsContext> options) : DbContext(options)
{
    public DbSet<Dashboard> Blogs { get; set; }
    public DbSet<Widget> Posts { get; set; }
}

public class Dashboard
{
    public int ID { get; set; }
    public required string Name { get; set; }
    public required string CreatorID { get; set; }
    public required DateTimeOffset CreatedAt { get; set; }
    public string? UpdaterID { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? DeleterID { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}

public class Widget
{
    public required int ID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public required string Type { get; set; }
    public required string Source { get; set; }
    public required string CreatorID { get; set; }
    public required DateTimeOffset CreatedAt { get; set; }
    public string? UpdaterID { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? DeleterID { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}
