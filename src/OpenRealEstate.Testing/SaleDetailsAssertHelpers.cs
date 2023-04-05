using OpenRealEstate.Core;
using Shouldly;

namespace OpenRealEstate.Testing
{
    public static class SaleDetailsAssertHelpers
    {
        public static void AssertSaleDetails(ISaleDetails source,
                                             ISaleDetails destination)
        {
            if (source == null &&
                destination == null)
            {
                return;
            }

            source.AuctionOn.ShouldBe(destination.AuctionOn);
            source.YearBuilt.ShouldBe(destination.YearBuilt);
            source.YearLastRenovated.ShouldBe(destination.YearLastRenovated);
            source.Authority.ShouldBe(destination.Authority);

            source.Pricing.SalePrice.ShouldBe(destination.Pricing.SalePrice);
            source.Pricing.SalePriceText.ShouldBe(destination.Pricing.SalePriceText);
            source.Pricing.IsUnderOffer.ShouldBe(destination.Pricing.IsUnderOffer);
            source.Pricing.SoldOn.ShouldBe(destination.Pricing.SoldOn);
            source.Pricing.SoldPrice.ShouldBe(destination.Pricing.SoldPrice);
            source.Pricing.SoldPriceText.ShouldBe(destination.Pricing.SoldPriceText);
        }
    }
}
