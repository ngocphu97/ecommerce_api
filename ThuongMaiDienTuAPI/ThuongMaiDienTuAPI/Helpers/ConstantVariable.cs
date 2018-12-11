using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThuongMaiDienTuAPI.Helpers
{
    public class ConstantVariable
    {
        public static class UserPermission
        {
            public static string CUSTOMER = "CUSTOMER";
            public static string SELLER = "SELLER";
            public static string ADMIN = "ADMIN";
        }
        public static class PaymentMethod
        {
            public static string CASH = "CASH";
            public static string CREDIT_CARD = "CREDIT_CARD";
        }
        public static class PaymentStatus
        {
            public static string WAIT = "WAIT";
            public static string CONFIRMED = "CONFIRMED";
            public static string COMPLETED = "COMPLETED";
            public static string CANCELLED = "CANCELLED";
        }
        public static class NotifyStatus
        {
            public static string UNSEEN = "UNSEEN";
            public static string SEEN = "SEEN";
        }
        public static class PromotionStatus
        {
            public static string COMMON = "COMMON";
            public static string INDIVIDUAL = "INDIVIDUAL";
        }
    }
}
