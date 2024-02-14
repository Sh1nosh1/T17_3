using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_3
{
    class Manager : Staff
    {
        /// <summary>
        /// Sales volume
        /// </summary>
        private double scope;
        /// <summary>
        /// Properties
        /// </summary>
        protected double Scope { get => scope; set => scope = value; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Manager() { }
        public Manager(string surname, string name, DateTime dateofbirth, double p, double scope) : base(surname, name, dateofbirth, p)
        {
            this.scope = scope;
        }
        /// <summary>
        /// Recalculating income
        /// </summary>
        /// <param name="k">Increasing coeff</param>
        /// <returns>Income</returns>
        public override double Income(double k, double h)
        {
            if (scope > h) { return base.Income(k, h) + h * 0.01; }
            return base.Income(k, h);
        }
        /// <summary>
        /// Output info
        /// </summary>
        /// <param name="k">Increasing coeff.</param>
        public override void ShowInfo(double k, double h)
        {
            base.ShowInfo(k, h);
            WriteLine($"Sales volume: {Scope}\nIncome: {Income(k, h)}");
        }
        public static Manager Input()
        {
            Write("Enter the surname: ");
            string surname = ReadLine();
            Write("Enter the name: ");
            string name = ReadLine();
            Write("Enter the date of birth: ");
            DateTime dateTime = DateTime.Parse(ReadLine());
            Write("Enter the minimal salary: ");
            double p = Convert.ToDouble(ReadLine());
            Write("Enter the sales volume: ");
            int scope = Convert.ToInt32(ReadLine());
            return new Manager(surname, name, dateTime, p, scope);
        }
    }
}
