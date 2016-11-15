using System.Text;

namespace GofPatterns.StructuralPatterns.Facade
{
    public class LetterSenderFacade
    {
        public LetterAdvertisingService _advSvc;
        public LetterPricesService _prcSvc;
        public LetterFooterService _footSvc;

        public LetterSenderFacade(LetterAdvertisingService advSvc, LetterPricesService ptcSvc,
            LetterFooterService footSvc)
        {
            _advSvc = advSvc;
            _prcSvc = ptcSvc;
            _footSvc = footSvc;
        }

        public string ComposeLetter()
        {
            var sb = new StringBuilder();

            sb.AppendLine(_prcSvc.GetPrices(123));
            sb.AppendLine(_advSvc.GetAds());
            sb.AppendLine(_footSvc.GetFooter());

            return sb.ToString();
        }
    }
}
