using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebThoiTrang.Models;

namespace WebThoiTrang.Utility
{
    public class SD
    {
        public const string Role_Customer = "Khách Hàng";
        public const string Role_Company = "Công Ty";
        public const string Role_Admin = "Quản Trị";
        public const string Role_Employee = "Nhân Viên";


        public const string StatusPending = "Đang Chờ Xác Nhận";
        public const string StatusApproved = "Đơn Hàng Đả Được Xác Nhận";
        public const string StatusInProcess = "Đơn Hàng Đang Được Xử Lý";
        public const string StatusShipped = "Đơn Hàng Đả Được Gửi";
        public const string StatusCancelled = "Hủy Đơn Hàng";
        public const string StatusRefunded = "Hoàn Tiền";
        public const string StatusPaymentStatusApproved = "Đả Thanh Toán Khi Nhận Hàng";

        public const string PaymentStatusPending = "Chưa Được Giải Quyết";
        public const string PaymentStatusApproved = "Thanh Toán Thành Công";
        public const string PaymentStatusDelayedPayment = "Đả Được Phê Duyệt Thanh Toán Sau";
        public const string PaymentStatusRejected = "Thanh Toán Không Thành Công";

		public const string ssCouponCode = "ssCouponCode";

		public const string SessionCart = "SessionShoppingCart";

        public static double DiscountedPrice(Coupon couponFromDb, double OriginalOrderTotal)
        {
            if (couponFromDb == null)
            {
                return OriginalOrderTotal;
            }
            else
            {
                if (couponFromDb.MinimumAmount > OriginalOrderTotal)
                {
                    return OriginalOrderTotal;
                }
                else
                {
                    //everything is valid
                    if (Convert.ToInt32(couponFromDb.CouponType) == (int)Coupon.ECouponType.VND)
                    {
                        //$10 off $100
                        return Math.Round(OriginalOrderTotal - couponFromDb.Discount, 2);
                    }
                    if (Convert.ToInt32(couponFromDb.CouponType) == (int)Coupon.ECouponType.Percent)
                    {
                        //10% off $100
                        return Math.Round(OriginalOrderTotal - (OriginalOrderTotal * couponFromDb.Discount / 100), 2);
                    }
                }
            }
            return OriginalOrderTotal;
        }

    }
}
