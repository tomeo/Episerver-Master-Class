using System.ComponentModel.DataAnnotations;
using Domain.Enum;
using EpiserverMasterClass.Business;
using EpiserverMasterClass.Business.EditorDescriptors;
using EpiserverMasterClass.Business.Rendering;
using EPiServer.Web;
using EPiServer.Core;

namespace EpiserverMasterClass.Models.Pages
{
    /// <summary>
    /// Represents contact details for a contact person
    /// </summary>
    [SiteContentType(
        GUID = "F8D47655-7B50-4319-8646-3369BA9AF05B",
        GroupName = GroupNames.Specialized)]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
    public class ContactPage : SitePageData, IContainerPage
    {
        [Display(GroupName = GroupNames.Contact)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(GroupName = GroupNames.Contact)]
        public virtual string Phone { get; set; }
        
        [Display(GroupName = GroupNames.Contact)]
        [Business.EmailAddress]
        public virtual string Email { get; set; }
    }
}
