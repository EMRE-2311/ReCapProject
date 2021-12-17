using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDao _customerDao;

        public CustomerManager(ICustomerDao customerDao)
        {
            _customerDao = customerDao;
        }

        public IResult Add(Customer customer)
        {
            _customerDao.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDao.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<Customer> Get(int id)
        {
            return new SuccessDataResult<Customer>(_customerDao.GetById(c => c.CustomerId == id));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDao.GetAll());
        }

        public IResult Update(Customer customer)
        {
            _customerDao.Update(customer);
            return new SuccessResult();
        }
    }
}
