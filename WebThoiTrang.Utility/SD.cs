using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusDelayedPayment = "ApprovedForDelayedPayment";
        public const string PaymentStatusRejected = "Rejected";


        public const string SessionCart = "SessionShoppingCart";


    }
}
