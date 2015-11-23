using System.Collections.Generic;

namespace Domain.Enum
{
    public class Global
    {
        /// <summary>
        ///     Virtual path to folder with static graphics, such as "~/Static/gfx/"
        /// </summary>
        public const string StaticGraphicsFolderPath = "~/Static/gfx/";

        public static Dictionary<string, int> ContentAreaTagWidths = new Dictionary<string, int>
        {
            {ContentAreaTags.FullWidth, ContentAreaWidths.FullWidth},
            {ContentAreaTags.TwoThirdsWidth, ContentAreaWidths.TwoThirdsWidth},
            {ContentAreaTags.HalfWidth, ContentAreaWidths.HalfWidth},
            {ContentAreaTags.OneThirdWidth, ContentAreaWidths.OneThirdWidth}
        };
    }
}