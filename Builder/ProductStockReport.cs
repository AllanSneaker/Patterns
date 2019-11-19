using System.Text;

namespace Builder
{
    public class ProductStockReport
    {
        public string HeaderPart { get; set; }
        public string BodyPart { get; set; }
        public string FooterPart { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine(HeaderPart)
                .AppendLine(BodyPart)
                .AppendLine(FooterPart)
                .ToString();
        }
    }
}
