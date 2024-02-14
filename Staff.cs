using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_3
{
    class Staff
    {
        /// <summary>
        /// Name and surname 
        /// </summary>
        private string name;
        private string surname;
        /// <summary>
        /// Date of birth
        /// </summary>
        private DateTime dateofbirth;
        /// <summary>
        /// Minimal salary
        /// </summary>
        private double p;
        /// <summary>
        /// Properties
        /// </summary>
        protected string Surname { get => (surname != "" && surname != " ") ? surname : "None"; set => surname = value; }
        protected string Name { get => (name != "" && name != " ") ? name : "None"; set => name = value; }
        protected DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        protected double P { get => (p > 0) ? p : 0; set => p = value; }
        /// <summary>
        /// Constructros
        /// </summary>
        public Staff() { }
        public Staff(string name, string surname, DateTime dateofbirth, double p)
        {
            this.name = name; this.surname = surname; this.dateofbirth = dateofbirth; this.p = p;
        }
        /// <summary>
        /// Calculating income
        /// </summary>
        /// <param name="k">Increasing coeff.</param>
        /// <returns>Income</returns>
        virtual public double Income(double k, double h)
        {
            return p * k;
        }
        /// <summary>
        /// Output info
        /// </summary>
        virtual public void ShowInfo(double k, double h)
        {
            WriteLine($"Surname: {Surname}\nName: {Name}\nDate of birth: {Dateofbirth}\nMinimal salary: {P}");
        }
    }
}
