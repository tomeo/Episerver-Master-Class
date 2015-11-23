using System;
using System.Collections.Generic;
using Domain.Enum;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using EPiServer.Shell.ObjectEditing;

namespace EpiserverMasterClass.Business.EditorDescriptors
{
    /// <summary>
    /// Register an editor for StringList properties
    /// </summary>
    [EditorDescriptorRegistration(
        TargetType = typeof(string[]),
        UIHint = SiteUiHints.Strings)]
    public class StringListEditorDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            ClientEditingClass = "alloy/editors/StringList";

            base.ModifyMetadata(metadata, attributes);
        }
    }
}
