using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_3
{
    class Engineer : Staff
    {
        /// <summary>
        /// Developed projects
        /// </summary>
        private int n;
        /// <summary>
        /// Properties
        /// </summary>
        protected int N { get => (n > 0) ? n : 0; set => n = value; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Engineer() { }
        public Engineer(string surname, string name, DateTime dateofbirth, double p, int n) : base(surname, name, dateofbirth, p)
        {
            this.n = n;
        }
        /// <summary>
        /// Recalculating Income()
        /// </summary>
        /// <param name="k">Increasing coeff.</param>
        /// <returns>Income</returns>
        public override double Income(double k, double h)
        {
            return base.Income(k, h) + (4.8 * n);
        }
        /// <summary>
        /// Output info
        /// </summary>
        /// <param name="k"></param>
        public override void ShowInfo(double k, double h)
        {
            base.ShowInfo(k, h);
            WriteLine($"Developed projects: {N}\nIncome: {Income(k, h)}");
        }
        public static Engineer Input()
        {
            Write("Enter the surname: ");
            string surname = ReadLine();
            Write("Enter the name: ");
            string name = ReadLine();
            Write("Enter the date of birth: ");
            DateTime dateTime = DateTime.Parse(ReadLine());
            Write("Enter the minimal salary: ");
            double p = Convert.ToDouble(ReadLine());
            Write("Enter the number of developed projects: ");
            int n = Convert.ToInt32(ReadLine());
            return new Engineer(surname, name, dateTime, p, n);
        }
    }
}
