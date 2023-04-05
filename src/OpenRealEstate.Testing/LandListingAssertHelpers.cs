using OpenRealEstate.Core.Land;
using Shouldly;

namespace OpenRealEstate.Testing
{
    public static class LandListingAssertHelpers
    {
        public static void AssertLandListing(LandListing source,
                                             LandListing destination)
        {
            source.CategoryType.ShouldBe(destination.CategoryType);
            source.CouncilRates.ShouldBe(destination.CouncilRates);

            ListingAssertHelpers.AssertCommonData(source, destination);
            SaleDetailsAssertHelpers.AssertSaleDetails(source, destination);
            AssertLandEstate(source.Estate, destination.Estate);
        }

        private static void AssertLandEstate(LandEstate source,
                                             LandEstate destination)
        {
            if (source == null &&
                destination == null)
            {
                return;
            }

            source?.Name.ShouldBe(destination.Name);
            source?.Stage.ShouldBe(destination.Stage);
        }
    }
}
