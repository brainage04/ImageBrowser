using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageBrowser
{
    internal class TitleUtils
    {
        public static bool Fits(Label label, string text)
        {
            if (string.IsNullOrEmpty(text))
                return true;

            Size proposedSize = new Size(int.MaxValue, int.MaxValue);
            TextFormatFlags flags = TextFormatFlags.SingleLine;

            Size measured = TextRenderer.MeasureText(
                text,
                label.Font,
                proposedSize,
                flags
            );

            int availableWidth = label.ClientSize.Width;

            // add a little extra space just to be sure the text will fit
            const int padding = 2;
            availableWidth -= padding * 2;

            return measured.Width <= availableWidth;
        }
        public static void SetTruncatedImageLabel(
            Label label,
            string fileNameWithExtension,
            int currentIndex,
            int totalImages)
        {
            // build parts
            string extension = Path.GetExtension(fileNameWithExtension);
            string baseName = Path.GetFileNameWithoutExtension(fileNameWithExtension) ?? string.Empty;

            string indexPart = $" ({currentIndex + 1} of {totalImages})";

            // try full text
            string fullText = baseName + extension + indexPart;
            if (Fits(label, fullText))
            {
                label.Text = fullText;
                return;
            }

            const string ellipsis = "...";

            // binary search over baseName length to find the longest that fits
            int left = 1;
            int right = baseName.Length;
            int bestLen = 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                string candidateBase = baseName.Substring(0, mid);
                string candidate = candidateBase + ellipsis + extension + indexPart;

                if (Fits(label, candidate))
                {
                    bestLen = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            string finalBase = baseName.Substring(0, bestLen);
            label.Text = finalBase + ellipsis + extension + indexPart;
        }
    }
}
