using StaffEducation.Business.Abstract;
using StaffEducation.DataAccess.Abstract;
using StaffEducation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StaffEducation.Business.Concrete
{
    public class DepartmanManager : DepartmanService
    {
        private IBaseDal<Departman> _departmanOperation;

        public DepartmanManager(IBaseDal<Departman> departmanOperation)
        {
            _departmanOperation = departmanOperation;
        }

        public BaseResult<bool> Add(Departman entity)
        {
            BaseResult<bool> res = new BaseResult<bool>();
            try
            {

                if (string.IsNullOrEmpty(entity.DepartmanName))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.DepartmanName), "Departman adı boş olamaz"));
                }
                if (entity.DepartmanName.Length < 2)
                {
                    res.Errors.Add(new ValidationError(nameof(entity.DepartmanName), "Departman adı 2 karakterden fazla olmalıdır."));
                }
             
                Regex reg = new Regex(@"[a-zA-Z]+");
                if (!reg.IsMatch(entity.DepartmanName))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.DepartmanName), "Departman adı sadece alfabetik karakterlerden olmalıdır."));

                }
                if (res.Errors.Count == 0)
                {
                    _departmanOperation.Add(entity);
                    res.Result = true;
                    res.ResultType = ValidationErrorType.Success;
                    res.Message = "Kayıt başarı ile eklendi.";
                }
                else
                {
                    res.Result = false;
                    res.ResultType = ValidationErrorType.Error;
                    res.Message = "Kayıt eklenirken bir sorun oluştu.";
                }
            }
            catch (Exception ex)
            {
                res.Result = false;
                res.ResultType = ValidationErrorType.Error;
                res.Message = "Kayıt eklenirken bir sorun oluştu. \rHata Mesajı: " + ex.Message;

            }

            return res;
        }

        public BaseResult<bool> Delete(Departman entity)
        {
            BaseResult<bool> res = new BaseResult<bool>();
            try
            {
                _departmanOperation.Delete(entity);
                res.Message = "Başarı ile silindi.";
            }
            catch (Exception ex)
            {

                res.ResultType = ValidationErrorType.Error;
                res.Message = "Kayıt silinirken bir hata oluştu." + ex.Message;
            }
            return res;
        }

        public BaseResult<Departman> Get(Expression<Func<Departman, bool>> filter)
        {
            BaseResult<Departman> res = new BaseResult<Departman>();
            try
            {
                res.Result = _departmanOperation.Get(filter);
            }
            catch (Exception ex)
            {

                res.Result = null;
                res.Message = "Kayıt getirilirken bir hata oluştu";
                res.ResultType = ValidationErrorType.Error;
            }

            return res;
        }

        public BaseResult<List<Departman>> GetAll(Expression<Func<Departman, bool>> filter = null)
        {
            BaseResult<List<Departman>> res = new BaseResult<List<Departman>>();
            try
            {
                res.Result = _departmanOperation.GetAll(filter);
                res.Message = "Kayıt başarı ile getirildi";

            }
            catch (Exception ex)
            {

                res.Result = null;
                res.Message = "Kayıt getirilirken bir hata oluştu" + ex.Message;
                res.ResultType = ValidationErrorType.Error;
            }

            return res;
        }

        public BaseResult<bool> Update(Departman entity)
        {
            BaseResult<bool> res = new BaseResult<bool>();
            try
            {
                if (string.IsNullOrEmpty(entity.DepartmanName))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.DepartmanName), "Departman adı boş olamaz"));
                }
                if (entity.DepartmanName.Length < 2)
                {
                    res.Errors.Add(new ValidationError(nameof(entity.DepartmanName), "Departman adı 2 karakterden fazla olmalıdır."));
                }

                if (entity.DepartmanName.Length < 2)
                {
                    res.Errors.Add(new ValidationError(nameof(entity.DepartmanName), "Departman adı 2 karakterden fazla olmalıdır."));
                }
                Regex reg = new Regex(@"[a-zA-Z]+");
                if (!reg.IsMatch(entity.DepartmanName))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.DepartmanName), "Departman adı sadece alfabetik karakterlerden olmalıdır."));

                }
            }
            catch (Exception ex)
            {
                res.Result = false;
                res.ResultType = ValidationErrorType.Error;
                res.Message = "Kayıt güncellenirken bir sorun oluştu. \rHata Mesajı: " + ex.Message;
            }
            return res;
        }
    }
}
