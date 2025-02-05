﻿using Business.Abstract;
using Business.Constants;
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
    public class BrandManager : IBrandService
    {
        IBrandDao _brandDao;

        public BrandManager(IBrandDao brandDao)
        {
            _brandDao = brandDao;
        }

        public IResult Add(Brand brand)
        {
            _brandDao.Add(brand);
            return new  SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDao.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<Brand> Get(int id)
        {
            return new SuccessDataResult<Brand>(_brandDao.GetById(b =>b.Id == id), Messages.BrandListed);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDao.GetAll(), Messages.BrandsListed);
        }

        public IResult Update(Brand brand)
        {
            _brandDao.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
