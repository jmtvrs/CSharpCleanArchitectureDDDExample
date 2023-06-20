using Domain.Common.Models;
using Domain.Module.ValueObjects;
using Domain.PhysicalDevice.ValueObjects;

namespace Domain.PhysicalDevice.Entities;

/// <summary>
/// Device Module Entity.
/// </summary>
public sealed class DeviceModule : Entity<DeviceModuleId>
{
    private DeviceModule(
        DeviceModuleId id,
        ModuleId moduleId,
        string variables)
        : base(id)
    {
        ModuleId = moduleId;
        Variables = variables;
    }

    /// <summary>
    /// Gets ModuleId.
    /// </summary>
    /// <value>ModuleId.</value>
    public ModuleId ModuleId { get; }

    /// <summary>
    /// Gets Variables.
    /// </summary>
    /// <value>string.</value>
    public string Variables { get; }

    /// <summary>
    /// Gets created date-time. Default to DateTime.Now.
    /// </summary>
    /// <value>DateTime.</value>
    public DateTime CreatedDateTime { get; } = DateTime.Now;

    /// <summary>
    /// Gets updated date-time. Default to DateTime.Now.
    /// </summary>
    /// <value>DateTime.</value>
    public DateTime UpdatedDateTime { get; } = DateTime.Now;

    /// <summary>
    /// Initializes a new instance of the <see cref="DeviceModule"/> entity.
    /// </summary>
    /// <param name="moduleId">ModuleId.</param>
    /// <param name="variables">string.</param>
    /// <returns>DeviceModule.</returns>
    public static DeviceModule Create(
        ModuleId moduleId,
        string variables)
    {
        return new(
            DeviceModuleId.CreateUnique(),
            moduleId,
            variables);
    }
}
