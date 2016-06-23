using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCars.Data
{
    public class CarRepository
    {
        private string _connectionString;

        public CarRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddCar(Car car)
        {
            using (var context = new PersonCarsDataContext(_connectionString))
            {
                context.Cars.InsertOnSubmit(car);
                context.SubmitChanges();
            }
        }
    }
}
