// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.workbookTable&quot; objects.</para>
    ///     <para type="description">GET ~/me/drive/root/children/{childId}/workbook/tables</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.workbookTable&quot; objects in the &quot;tables&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Root_Children_Workbook_Tables", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    [ResourceReference]
    public class Get_Me_Drive_Root_Children_Workbook_Tables : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;highlightFirstColumn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean highlightFirstColumn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;highlightLastColumn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean highlightLastColumn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showBandedColumns&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean showBandedColumns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showBandedRows&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean showBandedRows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showFilterButton&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean showFilterButton { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showHeaders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean showHeaders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showTotals&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean showTotals { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;style&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String style { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columns&quot; property, of type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableColumn")]
        [Selectable]
        [Expandable]
        public System.Object[] columns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookTableRow&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableRow")]
        [Selectable]
        [Expandable]
        public System.Object[] rows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookTableSort&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableSort")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object sort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookTable&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/root/children/{childId}/workbook/tables</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.workbookTable&quot; object to the &quot;tables&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_Root_Children_Workbook_Tables", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookTable")]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceReference]
    public class New_Me_Drive_Root_Children_Workbook_Tables : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;highlightFirstColumn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;highlightFirstColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;highlightFirstColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean highlightFirstColumn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;highlightLastColumn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;highlightLastColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;highlightLastColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean highlightLastColumn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showBandedColumns&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showBandedColumns&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showBandedColumns&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showBandedColumns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showBandedRows&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showBandedRows&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showBandedRows&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showBandedRows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showFilterButton&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showFilterButton&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showFilterButton&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showFilterButton { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showHeaders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showHeaders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showHeaders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showHeaders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showTotals&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showTotals&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showTotals&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showTotals { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;style&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;style&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;style&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String style { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columns&quot; property, of type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableColumn")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.workbookTableColumn&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.workbookTableColumn&quot;.")]
        public System.Object[] columns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookTableRow&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableRow")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookTableRow&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookTableRow&quot;.")]
        public System.Object[] rows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookTableSort&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableSort")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookTableSort&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookTableSort&quot;.")]
        public System.Object sort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/root/children/{childId}/workbook/tables</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_Root_Children_Workbook_Tables", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookTable")]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    public class Update_Me_Drive_Root_Children_Workbook_Tables : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;highlightFirstColumn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;highlightFirstColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;highlightFirstColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean highlightFirstColumn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;highlightLastColumn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;highlightLastColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;highlightLastColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean highlightLastColumn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showBandedColumns&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showBandedColumns&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showBandedColumns&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showBandedColumns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showBandedRows&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showBandedRows&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showBandedRows&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showBandedRows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showFilterButton&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showFilterButton&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showFilterButton&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showFilterButton { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showHeaders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showHeaders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showHeaders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showHeaders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showTotals&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;showTotals&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;showTotals&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showTotals { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;style&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;style&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;style&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String style { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columns&quot; property, of type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableColumn")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.workbookTableColumn&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.workbookTableColumn&quot;.")]
        public System.Object[] columns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookTableRow&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableRow")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookTableRow&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookTableRow&quot;.")]
        public System.Object[] rows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookTableSort&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableSort")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookTableSort&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookTableSort&quot;.")]
        public System.Object sort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTable", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookTable&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/root/children/{childId}/workbook/tables/tableId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.workbookTable&quot; object from the &quot;tables&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Root_Children_Workbook_Tables", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    public class Remove_Me_Drive_Root_Children_Workbook_Tables : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/root/children/{childId}/workbook/tables/clearFilters</para>
    ///     <para type="description">The action &quot;microsoft.graph.clearFilters&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_ClearFilters", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_ClearFilters : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId}/clearFilters";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/root/children/{childId}/workbook/tables/convertToRange</para>
    ///     <para type="description">The action &quot;microsoft.graph.convertToRange&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_ConvertToRange", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_ConvertToRange : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId}/convertToRange";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/root/children/{childId}/workbook/tables/reapplyFilters</para>
    ///     <para type="description">The action &quot;microsoft.graph.reapplyFilters&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_ReapplyFilters", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_ReapplyFilters : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId}/reapplyFilters";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/root/children/{childId}/workbook/tables/add</para>
    ///     <para type="description">The action &quot;microsoft.graph.add&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookTable&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_Add", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTable")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_Add : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;address&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;address&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.String address { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasHeaders&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;hasHeaders&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.Boolean hasHeaders { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/add";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/root/children/{childId}/workbook/tables/dataBodyRange</para>
    ///     <para type="description">The function &quot;microsoft.graph.dataBodyRange&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_DataBodyRange", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_DataBodyRange : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId}/dataBodyRange({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/root/children/{childId}/workbook/tables/headerRowRange</para>
    ///     <para type="description">The function &quot;microsoft.graph.headerRowRange&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_HeaderRowRange", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_HeaderRowRange : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId}/headerRowRange({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/root/children/{childId}/workbook/tables/range</para>
    ///     <para type="description">The function &quot;microsoft.graph.range&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_Range", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_Range : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId}/range({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/root/children/{childId}/workbook/tables/totalRowRange</para>
    ///     <para type="description">The function &quot;microsoft.graph.totalRowRange&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_TotalRowRange", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTable")]
    [ResourceIdPropertyName("tableId")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_TotalRowRange : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/{tableId}/totalRowRange({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/root/children/{childId}/workbook/tables/itemAt</para>
    ///     <para type="description">The function &quot;microsoft.graph.itemAt&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookTable&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_ItemAt", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTable")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_ItemAt : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;index&quot; parameter, which is accepted by the &quot;microsoft.graph.itemAt&quot; function.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;index&quot; parameter, which is accepted by the &quot;microsoft.graph.itemAt&quot; function.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/itemAt({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/root/children/{childId}/workbook/tables/count</para>
    ///     <para type="description">The function &quot;microsoft.graph.count&quot;, which exists on the type &quot;microsoft.graph.workbookTable&quot;.</para>
    ///     <para type="description">This function returns a &quot;Edm.Int32&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Root_Children_Workbook_Tables_Count", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTable")]
    public class Invoke_Me_Drive_Root_Children_Workbook_Tables_Count : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/children/{childId}/workbook/tables/count({this.GetFunctionUrlSegment()})";
        }
    }
}