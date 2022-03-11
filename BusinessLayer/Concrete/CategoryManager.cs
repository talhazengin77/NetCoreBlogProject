using BusinessLayer.Abstract;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository EFCategoryRepository;
        public CategoryManager()
        {
            EFCategoryRepository = new EFCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
             EFCategoryRepository.Insert(category);2
        }

        public void CategoryDelete(Category category)
        {
            EFCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            EFCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return EFCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
            return EFCategoryRepository.GetListAll();
        }
    }
}
