using EPiServer.Core;

namespace EpiserverMasterClass.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
