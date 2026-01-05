namespace ImageBrowser
{
    internal class SizeUtils
    {
        private static readonly string[] SizeExtensions = new[]
        {
            "B", "KB", "MB", "GB", "TB"
        };

        private static string DecimalPlaces(string numString, int decimalPlaces)
        {
            int decimalIndex = numString.IndexOf('.');
            if (decimalIndex == -1) return numString;

            return numString.Substring(0, decimalIndex + decimalPlaces + 1);
        }

        public static string GetBytesString(long bytes)
        {
            double size = bytes;
            int sizeIndex = 0;
            while (size > 1024 && sizeIndex < SizeExtensions.Length - 1)
            {
                size /= 1024;
                sizeIndex++;
            }

            return $"{DecimalPlaces(size.ToString(), 1)} {SizeExtensions[sizeIndex]}";
        }
    }
}
