using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace test_code
{
    class test
    {
        public static void Main(string[] args)
        {
            person zhangsan = new person();
            zhangsan.name = "张三";
            zhangsan.height = 1.83;
            zhangsan.gender = "男";
            zhangsan.birthday = DateTime.Parse("1990-3-1");
            zhangsan.Introduce();
            ReadKey();
        }
    }
    class person
    {
        public string name;
        public string gender;
        public DateTime birthday;
        public double height;

        public void Introduce()
        {
            WriteLine("我叫{0},我是{1},我的生日是{2},我的身高是{3}", name, gender, birthday, height);
        }
        private string test_1;

        public string Test_1 { get => test_1; set => test_1 = value; }

        public string test_2 { get; set; }

    }
    public class example
    {
        public string OrderID { get; set; }//订单ID
        public int OrderDetailID { get; set; }//订单详情ID
        public string TicketNum { get; set; }//票号
        public string AirlineCode { get; set; }//航空公司代码
        public string CabinCode { get; set; }//舱位代码
        public DateTime DepartureTime { get; set; }//起飞时间
        public string DepartureAirportName { get; set; }//起飞机场名称
        public string DepartureAirportCode { get; set; }//起飞机场三字码
        public string ArrivalAirportCode { get; set; }//到达机场三字码
        public string ArrivalAirportName { get; set; }//到达机场名称
        public string PassengerCellPhone { get; set; }//乘机人手机
        public string PassengerRealName { get; set; }//乘机人真实姓名
        public decimal ChangeCost { get; set; }//改期费
        public decimal TicketAmount { get; set; }//机票总价
        public decimal InsurancePrice { get; set; }//保险价格
        public DateTime TKTTime { get; set; }//出票时间
        public decimal ReturnTicketCost { get; set; }//机票退款金额
        public decimal ReturnTicketCostDifferent { get; set; }//机票退款差价
        public DateTime ReturnTime { get; set; }//退款时间
        public string ReturnUserName { get; set; }//退款人姓名

    }
}
