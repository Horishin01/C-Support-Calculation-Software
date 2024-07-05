using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE15_01
{
    internal class TaxPrice
    {
        //フィールド
        private string _name;       //バイト先名
        private int _yearPay;       //年間時給
        private int _realmonthPay;  //月間実給与
        private int _monthlyPay;    //月間想定時給
        private int _hourlyPay;     //時給

        //メソッド

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int YearPay
        {
            get { return _yearPay; }
            set { _yearPay = value; }
        }

        public int RealMonthPay
        {
            get { return _realmonthPay; }
            set { _realmonthPay = value; }
        }
        public int MonthlyPay
        {
            get { return _monthlyPay; }
            set { _monthlyPay = value; }
        }

        public int HourlyPay
        {
            get { return _hourlyPay; }
            set { _hourlyPay = value; }
        }

        //コンストラクタ
        public TaxPrice(string name, int yearPay , int realMounthPay, int monthlypay ,int hourlyPay)
        {
            Name = name;
            YearPay = yearPay;
            RealMonthPay = realMounthPay;
            MonthlyPay = monthlypay;
            HourlyPay = hourlyPay;
        }
    }
}
