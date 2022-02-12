using StaffEducation.Business.Abstract;
using StaffEducation.Business.Helpers;
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
    public class CourseContentsManager : CourseContentsService
    {
        private IBaseDal<Course> _courseContentsOperation;

        public CourseContentsManager(IBaseDal<Course> courseContentsOperation)
        {
            _courseContentsOperation = courseContentsOperation;
        }

        public BaseResult<bool> Add(Course entity)
        {
            BaseResult<bool> res = new BaseResult<bool>();
            try
            {
                res.Errors = FormValidation(entity);//olması gereken

                if (res.Errors.Count == 0)
                {
                    _courseContentsOperation.Add(entity);

                    res.Result = true;
                    res.ResultType = ValidationErrorType.Success;
                    res.Message = "Kayıt başarıyla eklendi.";
                }
                else
                {
                    res.Result = false;
                    res.ResultType = ValidationErrorType.Error;
                    res.Message = "Kayıt eklenirken bir sorun oluştu burası.";
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
        //adasdas
        public BaseResult<bool> Delete(Course entity)
        {
            BaseResult<bool> res = new BaseResult<bool>();
            try
            {
                _courseContentsOperation.Delete(entity);
                res.Message = "Kayıt silindi";
            }
            catch (Exception ex)
            {

                res.ResultType = ValidationErrorType.Error;
                res.Message = "Kayıt silinirken bir hata oluştu." + ex.Message;
            }

            return res;
        }

        public BaseResult<Course> Get(Expression<Func<Course, bool>> filter)
        {
             //_courseContentsOperation.Get(filter);
            BaseResult<Course> res = new BaseResult<Course>();
            try
            {
                res.Result = _courseContentsOperation.Get(filter);
            }
            catch (Exception ex)
            {
                res.Result = null;
                res.ResultType = ValidationErrorType.Error;
                res.Message = "Kayıt getirilirken bir sorun oluştu. \rHata Mesajı: " + ex.Message;
            }
            return res;
        }

        public BaseResult<List<Course>> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            BaseResult<List<Course>> res = new BaseResult<List<Course>>();
            try
            {
                res.Result = _courseContentsOperation.GetAll(filter);
            }
            catch (Exception ex)
            {

                res.Result = null;
                res.ResultType = ValidationErrorType.Error;
                res.Message = "Kayıtlar getirilirken bir sorun oluştu. \rHata Mesajı: " + ex.Message;
            }

            return res;
        }

        public List<ValidationError> FormValidation(Course entity)
        {
            List<ValidationError> res = new List<ValidationError>();
            if (string.IsNullOrEmpty(entity.CourseName))
            {
                res.Add(new ValidationError(nameof(entity.CourseName), "Kurs adı boş olamaz."));
            }
            if (string.IsNullOrEmpty(entity.CourseTeacher))
            {
                res.Add(new ValidationError(nameof(entity.CourseTeacher), "Kurs sorumlusu boş olamaz."));
            }
            if (string.IsNullOrEmpty(entity.CourseSubject))
            {
                res.Add(new ValidationError(nameof(entity.CourseSubject), "Kurs konusu boş olamaz."));
            }
            if (!entity.CourseDate.HasValue)// || entity.CourseDate < DateTime.Now)
            {
                res.Add(new ValidationError(nameof(entity.CourseDate), "Kurs tarihi boş olamaz."));
            }
            if (!entity.CourseTime.HasValue || entity.CourseTime.Value == 0)
            {
                res.Add(new ValidationError(nameof(entity.CourseTime), "Kurs satti boş olamaz veya 0'dan büyük olmalıdır."));
            }
            if (string.IsNullOrEmpty(entity.CompanyName))
            {
                res.Add(new ValidationError(nameof(entity.CompanyName), "Kurs veren şirket boş olamaz."));
            }
            if (entity.CourseSubject.Length > 25)
            {
                res.Add(new ValidationError(nameof(entity.CourseSubject), "Kurs konusu 25 karakterinden fazla olmalıdır. "));
            }
            Regex reg;
            reg = new Regex(RegexFormats.IsOnlyAlfabetichs);
            if (!reg.IsMatch(entity.CourseName))
            {
                res.Add(new ValidationError(nameof(entity.CourseName), "Kurs adı sadece alfabetik karakterler içermelidir."));
            }

            if (!reg.IsMatch(entity.CourseTeacher))
            {
                res.Add(new ValidationError(nameof(entity.CourseTeacher), "Kurs Sorumlusu sadece alfabetik karakterler içermelidir."));
            }

            return res;
        }



        public BaseResult<bool> Update(Course entity)
        {
            BaseResult<bool> res = new BaseResult<bool>();
            _courseContentsOperation.Update(entity);
            try
            {
                //res.Errors = FormValidation(entity);
                if (string.IsNullOrEmpty(entity.CourseName))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.CourseName), "Kurs adı boş olamaz.")); 
                }
                if (string.IsNullOrEmpty(entity.CourseTeacher))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.CourseTeacher), "Kurs sorumlusu boş olamaz."));
                }
                if (string.IsNullOrEmpty(entity.CourseSubject))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.CourseSubject), "Kurs konusu boş olamaz."));
                }
                if (!entity.CourseDate.HasValue)// || entity.CourseDate < DateTime.Now)
                {
                    res.Errors.Add(new ValidationError(nameof(entity.CourseDate), "Kurs tarihi boş olamaz."));
                }
                if (!entity.CourseTime.HasValue || entity.CourseTime.Value == 0)
                {
                    res.Errors.Add(new ValidationError(nameof(entity.CourseTime), "Kurs satti boş olamaz veya 0'dan büyük olmalıdır."));
                }
                if (string.IsNullOrEmpty(entity.CompanyName))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.CompanyName), "Kurs veren şirket boş olamaz."));
                }
                if (entity.CourseSubject.Length > 25)
                {
                    res.Errors.Add(new ValidationError(nameof(entity.CourseSubject), "Kurs konusu 25 karakterinden fazla olmalıdır. "));
                }
                Regex reg;
                reg = new Regex(RegexFormats.IsOnlyAlfabetichs);
                if (reg.IsMatch(entity.CourseName))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.CourseName), "Kurs adı sadece alfabetik karakterler içermelidir."));
                }

                if (reg.IsMatch(entity.CourseTeacher))
                {
                    res.Errors.Add(new ValidationError(nameof(entity.CourseTeacher), "Kurs Sorumlusu sadece alfabetik karakterler içermelidir."));
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
