using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDao _colorDao;

        public ColorManager(IColorDao colorDao)
        {
            _colorDao = colorDao;
        }

        public IResult Add(Color color)
        {
            if (color.Name.Length <= 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }
            _colorDao.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            var numOfColors = _colorDao.GetAll().ToArray().Length;
            if (numOfColors<=1)
            {
                return new ErrorResult(Messages.NumOfColorNotEnough);
            }
            _colorDao.Delete(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IDataResult<Color> Get(int id)
        {
            return new SuccessDataResult<Color>(_colorDao.GetById(c => c.Id == id), Messages.ColorListed);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDao.GetAll(), Messages.ColorsListed);
        }

        public IResult Update(Color color)
        {
            _colorDao.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
