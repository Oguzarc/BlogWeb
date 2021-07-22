using System;
using BlogWeb.entity;
using BlogWeb.Repository;

namespace BlogWeb.Service
{
    public class UserService
    {
        UserRepository _repo = new UserRepository();
        public Result<User> Register(User user)
        {
            try
            {
                if (_repo.GetByUserName(user.username) != null)
                {
                    throw new Exception("Bu username zaten kullanımda.");
                }               
                return new Result<User>(_data: _repo.Register(user));
            }
            catch (Exception ex)
            {
                return new Result<User>(_is_success: false, _message: ex.Message);
            }
        }
        public Result<User> GetByUsername(string username)
        {
            try
            {
                Result<User> result = new Result<User>(_data: _repo.GetByUserName(username));
                if (result.data == null)
                {
                    result.errorMessage = "kullanıcı bulunamadı";
                    result.isSuccess = false;
                }
                return result;
            }
            catch (Exception ex)
            {
                return new Result<User>(_is_success: false, _message: ex.Message);
            }
        }
        public Result<User> Authenticate(string username,string password)
        {
            try
            {
                Result<User> result = new Result<User>(_data: _repo.Authenticate(username,password));
                if (result.data== null)
                {
                    throw new Exception("Kullanıcı hatalı");
                }
                return result;
            }
            catch (Exception ex)
            {
                return new Result<User>(_is_success: false, _message: ex.Message);
            }
        }
    }
}
