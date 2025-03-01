// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Recovery point for a migration item.</summary>
    public partial class MigrationRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPoint,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.Resource();

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; }

        /// <summary>Resource Location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.MigrationRecoveryPointProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RecoveryPointTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointInternal.RecoveryPointTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointPropertiesInternal)Property).RecoveryPointTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointPropertiesInternal)Property).RecoveryPointTime = value; }

        /// <summary>Internal Acessors for RecoveryPointType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationRecoveryPointType? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointInternal.RecoveryPointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointPropertiesInternal)Property).RecoveryPointType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointPropertiesInternal)Property).RecoveryPointType = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointProperties _property;

        /// <summary>Recovery point properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.MigrationRecoveryPointProperties()); set => this._property = value; }

        /// <summary>The recovery point time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? RecoveryPointTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointPropertiesInternal)Property).RecoveryPointTime; }

        /// <summary>The recovery point type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationRecoveryPointType? RecoveryPointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointPropertiesInternal)Property).RecoveryPointType; }

        /// <summary>Resource Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="MigrationRecoveryPoint" /> instance.</summary>
        public MigrationRecoveryPoint()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Recovery point for a migration item.
    public partial interface IMigrationRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource
    {
        /// <summary>The recovery point time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The recovery point time.",
        SerializedName = @"recoveryPointTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecoveryPointTime { get;  }
        /// <summary>The recovery point type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The recovery point type.",
        SerializedName = @"recoveryPointType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationRecoveryPointType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationRecoveryPointType? RecoveryPointType { get;  }

    }
    /// Recovery point for a migration item.
    internal partial interface IMigrationRecoveryPointInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal
    {
        /// <summary>Recovery point properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationRecoveryPointProperties Property { get; set; }
        /// <summary>The recovery point time.</summary>
        global::System.DateTime? RecoveryPointTime { get; set; }
        /// <summary>The recovery point type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationRecoveryPointType? RecoveryPointType { get; set; }

    }
}