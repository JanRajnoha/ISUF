using System;

namespace ISUF.Win10.Timeline
{
    public static class AdaptiveCards
    {
        public static string AdaptiveHeaderDescription =
        "{	" +
            "\"$schema\": \"http://adaptivecards.io/schemas/adaptive-card.json\"," +
            "\"type\": \"AdaptiveCard\"," +
            "\"backgroundImage\": \"{backgroundImage}\"," +
            "\"version\": \"1.0\"," +
            "\"body\": [" +
                "{" +
                    "\"type\": \"Container\"," +
                    "\"items\": [" +
                        "{" +
                            "\"type\": \"TextBlock\"," +
                            "\"text\": \"{name}\"," +
                            "\"weight\": \"bolder\"," +
                            "\"size\": \"medium\"," +
                            "\"maxLines\": 3" +
                        "}" +
                    "]" +
                "}," +
                "{" +
                    "\"type\": \"Container\"," +
                    "\"items\": [" +
                        "{" +
                            "\"type\": \"TextBlock\"," +
                            "\"text\": \"{description}\"," +
                            "\"wrap\": true," +
                            "\"maxLines\": 5" +
                        "}" +
                    "]" +
                "}" +
            "]}";
    }
}
