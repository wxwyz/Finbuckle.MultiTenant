using Microsoft.AspNetCore.Http;

namespace Finbuckle.MultiTenant.AspNetCore.Routing;

/// <summary>
/// Indicates that this <see cref="Endpoint"/> should not be included in the generated API metadata.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Delegate, AllowMultiple = false, Inherited = true)]
public class ExcludeFromMultiTenantResolutionAttribute : Attribute, IExcludeFromMultiTenantResolutionMetadata
{
    /// <inheritdoc />
    public bool ExcludeFromResolution => true;
}