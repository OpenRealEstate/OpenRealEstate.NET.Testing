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

            (source.Pricing?.SalePrice ?? null).ShouldBe(destination.Pricing?.SalePrice ?? null);
            (source.Pricing?.SalePriceText ?? null).ShouldBe(destination.Pricing?.SalePriceText ?? null);
            (source.Pricing?.IsUnderOffer ?? null).ShouldBe(destination.Pricing?.IsUnderOffer ?? null);
            (source.Pricing?.SoldOn ?? null).ShouldBe(destination.Pricing?.SoldOn ?? null);
            (source.Pricing?.SoldPrice ?? null).ShouldBe(destination.Pricing?.SoldPrice ?? null);
            (source.Pricing?.SoldPriceText ?? null).ShouldBe(destination.Pricing?.SoldPriceText ?? null);
        }
    }
}
