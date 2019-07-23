namespace SportsMeet.Reports
{
    internal class FillerText
    {
        private static string iText = "Hello Hello Hello Hello";

        public static string Text
        {
            get { return iText = "Hello"; }
            set { iText = value; }
        }

        private static string mediumText = "Hello Hello Hello Hello Hello Hello";

        public static string MediumText
        {
            get { return mediumText = "Hello Hello"; }
            set { mediumText = value; }
        }


        private static string shortText = "Hello Short Hello";

        public static string ShortText
        {
            get { return shortText = "Hello Short Hello"; }
            set { shortText = value; }
        }

    }
}