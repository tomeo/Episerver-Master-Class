using System;
using System.Collections.Generic;
using Domain.Enum;
using EPiServer.Core;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EpiserverMasterClass.Business.EditorDescriptors
{
    /// <summary>
    /// Registers an editor to select a ContactPage for a PageReference property using a dropdown
    /// </summary>
    [EditorDescriptorRegistration(
        TargetType = typeof(PageReference),
        UIHint = SiteUiHints.Contact)]
    public class ContactPageSelector : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            SelectionFactoryType = typeof(ContactPageSelectionFactory);
            
            ClientEditingClass = "epi-cms/contentediting/editors/SelectionEditor";
  
            base.ModifyMetadata(metadata, attributes);
        }
    }
}
