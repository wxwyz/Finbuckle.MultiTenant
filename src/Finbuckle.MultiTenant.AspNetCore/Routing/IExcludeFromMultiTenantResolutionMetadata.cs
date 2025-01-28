namespace Finbuckle.MultiTenant.AspNetCore.Routing;

/// <summary>
/// Indicates whether MultiTenant resolution should occur for this endpoint.
/// </summary>
public interface IExcludeFromMultiTenantResolutionMetadata
{
    /// <summary>
    /// Gets a value indicating whether MultiTenant resolution
    /// should occur for this endpoint. If <see langword="true"/>,
    /// tenant resolution will not be executed.
    /// </summary>
    bool ExcludeFromResolution { get; }
}