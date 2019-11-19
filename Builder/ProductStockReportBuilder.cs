using Builder.Interfaces;
using Builder.Models;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private IEnumerable<Product> _products;

        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _products = products;
            _productStockReport = new ProductStockReport();
        }

        public IProductStockReportBuilder BuildHeader()
        {
            _productStockReport.HeaderPart = $"Stock report header part \n";
            return this;
        }

        public IProductStockReportBuilder BuildBody()
        {
            _productStockReport.BodyPart = $"Stock report body part\n";
            _productStockReport.BodyPart += string.Concat(_products.Select(p => $"Product name: {p.Name}, Product price {p.Price} \n"));
            return this;
        }

        public IProductStockReportBuilder BuildFooter()
        {
            _productStockReport.FooterPart = $"Stock report footer part";
            return this; 
        }

        public ProductStockReport GetProductStockReport()
        {
            var productStockReport = _productStockReport;
            Clear();
            return productStockReport;

        }
        
        private void Clear()
        {
            _productStockReport = new ProductStockReport();
        }
    }
}
