// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.listItemVersion&quot; objects.</para>
    ///     <para type="description">GET ~/me/drive/list/items/{itemId}/versions</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.listItemVersion&quot; objects in the &quot;versions&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_List_Items_Versions", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.listItemVersion")]
    [ResourceIdPropertyName("versionId")]
    [ResourceReference]
    public class Get_Me_Drive_List_Items_Versions : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fieldValueSet")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.publicationFacet")]
        [Selectable]
        [Sortable]
        public System.Object publication { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/list/items/{itemId}/versions/{versionId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.listItemVersion&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/list/items/{itemId}/versions</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.listItemVersion&quot; object to the &quot;versions&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_List_Items_Versions", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.listItemVersion")]
    [ODataType("microsoft.graph.listItemVersion")]
    [ResourceReference]
    public class New_Me_Drive_List_Items_Versions : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fieldValueSet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        public System.Object fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.publicationFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        public System.Object publication { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/list/items/{itemId}/versions";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.listItemVersion&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/list/items/{itemId}/versions</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_List_Items_Versions", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.listItemVersion")]
    [ODataType("microsoft.graph.listItemVersion")]
    [ResourceIdPropertyName("versionId")]
    public class Update_Me_Drive_List_Items_Versions : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fieldValueSet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        public System.Object fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.publicationFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        public System.Object publication { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/list/items/{itemId}/versions/{versionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.listItemVersion&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/list/items/{itemId}/versions/versionId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.listItemVersion&quot; object from the &quot;versions&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_List_Items_Versions", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.listItemVersion")]
    [ResourceIdPropertyName("versionId")]
    public class Remove_Me_Drive_List_Items_Versions : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/list/items/{itemId}/versions/{versionId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/list/items/{itemId}/versions/restoreVersion</para>
    ///     <para type="description">The action &quot;microsoft.graph.restoreVersion&quot;, which exists on the type &quot;microsoft.graph.listItemVersion&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_List_Items_Versions_RestoreVersion", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.listItemVersion")]
    [ResourceIdPropertyName("versionId")]
    public class Invoke_Me_Drive_List_Items_Versions_RestoreVersion : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/list/items/{itemId}/versions/{versionId}/restoreVersion";
        }
    }
}