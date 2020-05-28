using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workinterview.Model
{
    public class Data
    {
        public int id { get; set; }
        public string vendorCode { get; set; }
        public bool? noOrder { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int? rate { get; set; }
        public double rating { get; set; }
        public string logo { get; set; }
        public string defLogo { get; set; }
        public bool? taxEnabled { get; set; }
        public bool? taxIncluded { get; set; }
        public bool? taxEnabledInProducts { get; set; }
        public bool? taxEnabledInPackaging { get; set; }
        public bool? taxEnabledInDeliveryFee { get; set; }
        public int? tax { get; set; }
        public int? serviceFee { get; set; }
        public string deliveryArea { get; set; }
        public int? discount { get; set; }
        public bool? isOpen { get; set; }
        public int? minDeliveryFee { get; set; }
        public int? maxDeliveryFee { get; set; }
        public int? deliveryTime { get; set; }
        public IList<int> paymentTypes { get; set; }
        public IList<Schedule> schedules { get; set; }
        public int? minOrder { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public int? status { get; set; }
        public double? lat { get; set; }
        public double? lon { get; set; }
        public string restaurantClass { get; set; }
        public IList<object> foodTypes { get; set; }
        public IList<object> restaurantTypes { get; set; }
        public bool? isFavorite { get; set; }
        public int? priority { get; set; }
        public string city { get; set; }
        public string area { get; set; }
        public int? commentCount { get; set; }
        public string recommendedFor { get; set; }
        public string establishment { get; set; }
        public string mostPopularItems { get; set; }
        public int? costsForTwo { get; set; }
        public bool onlineOrder { get; set; }
        public int? voteCount { get; set; }
        public object discountType { get; set; }
        public string menuUrl { get; set; }
        public int? discountValue { get; set; }
        public bool discountForAll { get; set; }
        public int? containerFee { get; set; }
        public bool deliveryGuarantee { get; set; }
        public IList<Badge> badges { get; set; }
        public string discountStartHour1 { get; set; }
        public string discountStopHour1 { get; set; }
        public string discountStartHour2 { get; set; }
        public string discountStopHour2 { get; set; }
        public int? discountValueForView { get; set; }
        public string coverPath { get; set; }
        public IList<CuisinesArray> cuisinesArray { get; set; }
        public bool preOrderEnabled { get; set; }
        public string vendorType { get; set; }
        public string childType { get; set; }
        public string budgetClass { get; set; }
        public string vendorTypeTitle { get; set; }
        public bool? isZFExpress { get; set; }
        public int? deliveryFee { get; set; }
        public string backgroundImage { get; set; }
        public string backgroundImageCustom { get; set; }
        public bool? has_coupon { get; set; }
        public int? coupon_count { get; set; }
        public IList<UserImage> userImage { get; set; }
        public IList<object> menuImage { get; set; }
        public int? countReview { get; set; }
        public object countOfUserImages { get; set; }
        public int? deliveryFeeDiscount { get; set; }
        public double? trendingScore { get; set; }
        public string delay { get; set; }
        public bool? deliver { get; set; }
        public int? eta { get; set; }
        public int? min_eta { get; set; }
        public int? max_eta { get; set; }
        public int? rank { get; set; }
        public string titleColor { get; set; }
        public string descriptionColor { get; set; }
        public string link { get; set; }
        public object deepLink { get; set; }
        public string image { get; set; }
        public int? index { get; set; }
        public int? style { get; set; }
        public double? ratio { get; set; }
        public int? position { get; set; }
        public object type { get; set; }
        public object viewCount { get; set; }
        public int? vendor_collection { get; set; }
        public string url { get; set; }
        public bool? food_party { get; set; }
        public int? super_type { get; set; }
        public object is_company { get; set; }
    }
}
