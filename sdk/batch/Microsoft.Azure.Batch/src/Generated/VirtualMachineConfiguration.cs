// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration for compute nodes in a pool based on the Azure Virtual Machines infrastructure.
    /// </summary>
    public partial class VirtualMachineConfiguration : ITransportObjectProvider<Models.VirtualMachineConfiguration>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<ContainerConfiguration> ContainerConfigurationProperty;
            public readonly PropertyAccessor<IList<DataDisk>> DataDisksProperty;
            public readonly PropertyAccessor<DiskEncryptionConfiguration> DiskEncryptionConfigurationProperty;
            public readonly PropertyAccessor<ImageReference> ImageReferenceProperty;
            public readonly PropertyAccessor<string> LicenseTypeProperty;
            public readonly PropertyAccessor<string> NodeAgentSkuIdProperty;
            public readonly PropertyAccessor<NodePlacementConfiguration> NodePlacementConfigurationProperty;
            public readonly PropertyAccessor<WindowsConfiguration> WindowsConfigurationProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.ContainerConfigurationProperty = this.CreatePropertyAccessor<ContainerConfiguration>(nameof(ContainerConfiguration), BindingAccess.Read | BindingAccess.Write);
                this.DataDisksProperty = this.CreatePropertyAccessor<IList<DataDisk>>(nameof(DataDisks), BindingAccess.Read | BindingAccess.Write);
                this.DiskEncryptionConfigurationProperty = this.CreatePropertyAccessor<DiskEncryptionConfiguration>(nameof(DiskEncryptionConfiguration), BindingAccess.Read | BindingAccess.Write);
                this.ImageReferenceProperty = this.CreatePropertyAccessor<ImageReference>(nameof(ImageReference), BindingAccess.Read | BindingAccess.Write);
                this.LicenseTypeProperty = this.CreatePropertyAccessor<string>(nameof(LicenseType), BindingAccess.Read | BindingAccess.Write);
                this.NodeAgentSkuIdProperty = this.CreatePropertyAccessor<string>(nameof(NodeAgentSkuId), BindingAccess.Read | BindingAccess.Write);
                this.NodePlacementConfigurationProperty = this.CreatePropertyAccessor<NodePlacementConfiguration>(nameof(NodePlacementConfiguration), BindingAccess.Read | BindingAccess.Write);
                this.WindowsConfigurationProperty = this.CreatePropertyAccessor<WindowsConfiguration>(nameof(WindowsConfiguration), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.VirtualMachineConfiguration protocolObject) : base(BindingState.Bound)
            {
                this.ContainerConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ContainerConfiguration, o => new ContainerConfiguration(o)),
                    nameof(ContainerConfiguration),
                    BindingAccess.Read | BindingAccess.Write);
                this.DataDisksProperty = this.CreatePropertyAccessor(
                    DataDisk.ConvertFromProtocolCollection(protocolObject.DataDisks),
                    nameof(DataDisks),
                    BindingAccess.Read | BindingAccess.Write);
                this.DiskEncryptionConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.DiskEncryptionConfiguration, o => new DiskEncryptionConfiguration(o)),
                    nameof(DiskEncryptionConfiguration),
                    BindingAccess.Read | BindingAccess.Write);
                this.ImageReferenceProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ImageReference, o => new ImageReference(o)),
                    nameof(ImageReference),
                    BindingAccess.Read | BindingAccess.Write);
                this.LicenseTypeProperty = this.CreatePropertyAccessor(
                    protocolObject.LicenseType,
                    nameof(LicenseType),
                    BindingAccess.Read | BindingAccess.Write);
                this.NodeAgentSkuIdProperty = this.CreatePropertyAccessor(
                    protocolObject.NodeAgentSKUId,
                    nameof(NodeAgentSkuId),
                    BindingAccess.Read | BindingAccess.Write);
                this.NodePlacementConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.NodePlacementConfiguration, o => new NodePlacementConfiguration(o)),
                    nameof(NodePlacementConfiguration),
                    BindingAccess.Read | BindingAccess.Write);
                this.WindowsConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.WindowsConfiguration, o => new WindowsConfiguration(o)),
                    nameof(WindowsConfiguration),
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualMachineConfiguration"/> class.
        /// </summary>
        /// <param name='imageReference'>A reference to the Azure Virtual Machines Marketplace Image or the custom Virtual Machine Image to use.</param>
        /// <param name='nodeAgentSkuId'>The SKU of Batch Node Agent to be provisioned on the compute node.</param>
        public VirtualMachineConfiguration(
            ImageReference imageReference,
            string nodeAgentSkuId)
        {
            this.propertyContainer = new PropertyContainer();
            this.ImageReference = imageReference;
            this.NodeAgentSkuId = nodeAgentSkuId;
        }

        internal VirtualMachineConfiguration(Models.VirtualMachineConfiguration protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region VirtualMachineConfiguration

        /// <summary>
        /// Gets or sets the container configuration for the pool.
        /// </summary>
        /// <remarks>
        /// If specified, setup is performed on each node in the pool to allow tasks to run in containers. All regular tasks 
        /// and job manager tasks run on this pool must specify <see cref="TaskContainerSettings" />, and all other tasks 
        /// may specify it.
        /// </remarks>
        public ContainerConfiguration ContainerConfiguration
        {
            get { return this.propertyContainer.ContainerConfigurationProperty.Value; }
            set { this.propertyContainer.ContainerConfigurationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the configuration for data disks attached to the Comptue Nodes in the pool.
        /// </summary>
        /// <remarks>
        /// This property must be specified if the Compute Nodes in the pool need to have empty data disks attached to them. 
        /// This cannot be updated.
        /// </remarks>
        public IList<DataDisk> DataDisks
        {
            get { return this.propertyContainer.DataDisksProperty.Value; }
            set
            {
                this.propertyContainer.DataDisksProperty.Value = ConcurrentChangeTrackedModifiableList<DataDisk>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the disk encryption configuration for the pool.
        /// </summary>
        /// <remarks>
        /// If specified, encryption is performed on each node in the pool during node provisioning.
        /// </remarks>
        public DiskEncryptionConfiguration DiskEncryptionConfiguration
        {
            get { return this.propertyContainer.DiskEncryptionConfigurationProperty.Value; }
            set { this.propertyContainer.DiskEncryptionConfigurationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a reference to the Azure Virtual Machines Marketplace Image or the custom Virtual Machine Image 
        /// to use.
        /// </summary>
        public ImageReference ImageReference
        {
            get { return this.propertyContainer.ImageReferenceProperty.Value; }
            set { this.propertyContainer.ImageReferenceProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the type of on-premises license to be used when deploying the operating system.
        /// </summary>
        /// <remarks>
        /// This only applies to images that contain the Windows operating system, and should only be used when you hold 
        /// valid on-premises licenses for the nodes which will be deployed. If omitted, no on-premises licensing discount 
        /// is applied. Values are: 'Windows_Server' - The on-premises license is for Windows Server. 'Windows_Client' - 
        /// The on-premises license is for Windows Client.
        /// </remarks>
        public string LicenseType
        {
            get { return this.propertyContainer.LicenseTypeProperty.Value; }
            set { this.propertyContainer.LicenseTypeProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the SKU of Batch Node Agent to be provisioned on the compute node.
        /// </summary>
        /// <remarks>
        /// The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface 
        /// between the node and the Batch service. There are different implementations of the node agent, known as SKUs, 
        /// for different operating systems.
        /// </remarks>
        public string NodeAgentSkuId
        {
            get { return this.propertyContainer.NodeAgentSkuIdProperty.Value; }
            set { this.propertyContainer.NodeAgentSkuIdProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the node placement configuration for the pool.
        /// </summary>
        /// <remarks>
        /// This configuration will specify rules on how nodes in the pool will be physically allocated.
        /// </remarks>
        public NodePlacementConfiguration NodePlacementConfiguration
        {
            get { return this.propertyContainer.NodePlacementConfigurationProperty.Value; }
            set { this.propertyContainer.NodePlacementConfigurationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets windows operating system settings on the Virtual Machine. This property must not be specified if 
        /// the ImageReference property specifies a Linux OS image.
        /// </summary>
        public WindowsConfiguration WindowsConfiguration
        {
            get { return this.propertyContainer.WindowsConfigurationProperty.Value; }
            set { this.propertyContainer.WindowsConfigurationProperty.Value = value; }
        }

        #endregion // VirtualMachineConfiguration

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.VirtualMachineConfiguration ITransportObjectProvider<Models.VirtualMachineConfiguration>.GetTransportObject()
        {
            Models.VirtualMachineConfiguration result = new Models.VirtualMachineConfiguration()
            {
                ContainerConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.ContainerConfiguration, (o) => o.GetTransportObject()),
                DataDisks = UtilitiesInternal.ConvertToProtocolCollection(this.DataDisks),
                DiskEncryptionConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.DiskEncryptionConfiguration, (o) => o.GetTransportObject()),
                ImageReference = UtilitiesInternal.CreateObjectWithNullCheck(this.ImageReference, (o) => o.GetTransportObject()),
                LicenseType = this.LicenseType,
                NodeAgentSKUId = this.NodeAgentSkuId,
                NodePlacementConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.NodePlacementConfiguration, (o) => o.GetTransportObject()),
                WindowsConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.WindowsConfiguration, (o) => o.GetTransportObject()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}