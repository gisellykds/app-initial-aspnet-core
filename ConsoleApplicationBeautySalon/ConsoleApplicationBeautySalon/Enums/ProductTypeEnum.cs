using System;

namespace ConsoleApplicationBeautySalon.Enums
{
    public class ProductTypeEnum
    {
        public enum ProductType
        {
            COLORATION = 1,
            TREATMENT = 2,
            CUTING = 3,
            WASHING = 4,
            BRUSH = 5,
            OTHERS = 6
        };

        internal static ProductType GetDescription(string product)
        {
            ProductType productGet;

            try
            {
                productGet = (ProductType)Enum.Parse(typeof(ProductType), product);

                if(!Enum.IsDefined(typeof(ProductType), productGet))
                {
                    productGet = ProductType.OTHERS;
                }

            }
            catch (Exception)
            {
                productGet = ProductType.OTHERS;
            }

            return productGet;
        }
    }
}
