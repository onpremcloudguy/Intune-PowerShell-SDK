// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerExternalReferences&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerExternalReferences&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerExternalReferencesObject", DefaultParameterSetName = @"microsoft.graph.plannerExternalReferences")]
    [ODataType("microsoft.graph.plannerExternalReferences")]
    public class New_PlannerExternalReferencesObject : ObjectFactoryCmdletBase
    {
    }
}