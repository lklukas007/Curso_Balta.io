using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
    public class Utm
    {
        public required Url Url { get; set; }

        public required Campaign Campaign { get; set; }

    }
}
