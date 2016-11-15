namespace GofPatterns.StructuralPatterns.Facade
{
    public class LetterFooterService
    {
        public string GetFooter()
        {
            return "Message footer";
        }
    }

    public class LetterPricesService
    {
        public string GetPrices(int letterId)
        {
            return "List of prices for this letter id: " + letterId;
        }
    }

    public class LetterAdvertisingService
    {
        public string GetAds()
        {
            return "You may also like this product: :^)";
        }
    }
}
