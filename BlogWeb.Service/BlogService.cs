using System;
using BlogWeb.entity;
using BlogWeb.Repository;
namespace BlogWeb.Service
{
    public class BlogService
    {
        BlogRepository _repo = new BlogRepository();

        public Result<Blog> Add(Blog blog)
        {
            try
            {               
                return new Result<Blog>(_data: _repo.Add(blog));
            }
            catch (Exception ex)
            {
                return new Result<Blog>(_is_success: false, _message: ex.Message);
            }
        }
        public Result<Blog> GetAll()
        {
            try
            {
                return new Result<Blog>(_datas: _repo.GetAll());
            }
            catch (Exception ex)
            {
                return new Result<Blog>(_is_success: false, _message: ex.Message);
            }
        }
        public Result<Blog> GetByCategory(string category)
        {
            try
            {
                return new Result<Blog>(_datas: _repo.GetByCategory(category));
            }
            catch (Exception ex)
            {
                return new Result<Blog>(_is_success: false, _message: ex.Message);
            }
        }
        public Result<Blog> GetById(int id)
        {
            try
            {
                return new Result<Blog>(_data: _repo.GetById(id));
            }
            catch (Exception ex)
            {
                return new Result<Blog>(_is_success: false, _message: ex.Message);
            }
        }
        public Result<Blog> Delete(int blogId)
        {
            try
            {
                bool check = _repo.Delete(blogId);
                if (check)
                {
                    return new Result<Blog>();
                }
                else
                {
                    return new Result<Blog>(_is_success: false, _message: "blogId Bulunamadı");
                }
            }
            catch (Exception ex)
            {
                return new Result<Blog>(_is_success: false, _message: ex.Message);
            }
        }
        public Result<Blog> Update(Blog blog)
        {
            try
            {
                return new Result<Blog>(_data: _repo.Update(blog));
            }
            catch (Exception ex)
            {
                return new Result<Blog>(_is_success: false, _message: ex.Message);
            }
        }
    }
}
