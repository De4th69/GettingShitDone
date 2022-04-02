using GettingShitDone.Database.Entities;
using GettingShitDone.Interfaces;
using GettingShitDone.Models;

namespace GettingShitDone.Database.Repositories
{
    public class CategoryRepository : ISQLiteRepository<CategoryModel>
    {
        private SQLiteRepository sqLiteRepository = new SQLiteRepository();

        public List<CategoryModel> Delete(Guid? categoryId)
        {
            if (!categoryId.HasValue)
            {
                return this.GetAll();
            }
            else
            {
                CategoryEntity categoryEntity = this.sqLiteRepository.DataBase.Get<CategoryEntity>(categoryId);
                if(categoryEntity != null && !categoryEntity.IsDefault)
                {
                    categoryEntity.DeleteDate = DateTime.Now;
                    categoryEntity.UpdateDate = DateTime.Now;
                    int saved = this.sqLiteRepository.DataBase.Update(categoryEntity);

                    if(saved == 1)
                    {
                        return this.GetAll();
                    }
                }
                
                return this.GetAll();
            }
        }

        public List<CategoryModel> GetAll()
        {
            List<CategoryModel> categoryList = new List<CategoryModel>();
            IEnumerable<CategoryEntity> entities = this.sqLiteRepository.GetAll<CategoryEntity>(Tools.Constants.TableNames.Category);
            foreach (CategoryEntity entity in entities)
            {
                CategoryModel categoryModel = new CategoryModel
                {
                    CategoryId = entity.CategoryId,
                    Name = entity.Name,
                    Description = entity.Description,
                    Color = entity.Color,
                    InsertDate = entity.InsertDate,
                    UpdateDate = entity.UpdateDate,
                    DeleteDate = entity.DeleteDate,
                    IsDirty = false,
                    IsNew = false,
                    IsDefault = entity.IsDefault
                };
                categoryList.Add(categoryModel);
            }

            return categoryList;
        }

        public CategoryModel GetById(Guid? id)
        {
            CategoryModel categoryModel = null;
            if (id.HasValue)
            {
                CategoryEntity categoryEntity = this.sqLiteRepository.GetById<CategoryEntity>(id.Value, Tools.Constants.TableNames.Category);
                if(categoryEntity != null)
                {
                    categoryModel.CategoryId = categoryEntity.CategoryId;
                    categoryModel.Name = categoryEntity.Name;
                    categoryModel.Description = categoryEntity.Description;
                    categoryModel.Color = categoryEntity.Color;
                    categoryModel.InsertDate = categoryEntity.InsertDate;
                    categoryModel.UpdateDate = categoryEntity.UpdateDate;
                    categoryModel.DeleteDate = categoryEntity.DeleteDate;
                    categoryModel.IsDirty = false;
                    categoryModel.IsNew = false;
                    categoryEntity.IsDefault = categoryEntity.IsDefault;
                }
            }

            return categoryModel;
        }

        public List<CategoryModel> Save<TModel>(CategoryModel model)
        {
            if (model.IsNew)
            {
                model.CategoryId = Guid.NewGuid();
                model.InsertDate = DateTime.Now;
                model.UpdateDate = DateTime.Now;
            }
            else if(model.IsDirty)
            {
                model.UpdateDate = DateTime.Now;
            }

            CategoryEntity categoryEntity = new CategoryEntity
            {
                CategoryId = model.CategoryId,
                Name = model.Name,
                Description = model.Description,
                Color = model.Color,
                InsertDate = model.InsertDate,
                UpdateDate = model.UpdateDate,
                DeleteDate = model.DeleteDate
            };

            if(this.sqLiteRepository.Save<CategoryEntity>(categoryEntity) == 1)
            {
                model.IsNew = false;
                model.IsDirty = false;
                model.UpdateDate= categoryEntity.UpdateDate;
                model.InsertDate= categoryEntity.InsertDate;
                
                return this.GetAll();
            }

            return null;
        }

        public List<CategoryModel> Update<TModel>(CategoryModel model)
        {
            if (!model.IsNew && !model.CategoryId.HasValue)
            {
                CategoryEntity categoryEntity = this.sqLiteRepository.GetById<CategoryEntity>(model.CategoryId.Value, "Category");
                if(categoryEntity != null)
                {
                    categoryEntity.UpdateDate = DateTime.Now;
                    int updatedEntity = this.sqLiteRepository.Save<CategoryEntity>(categoryEntity);
                    if(updatedEntity == 1)
                    {
                        model.UpdateDate = categoryEntity.UpdateDate;
                        model.IsNew=false;
                        model.IsDirty=false;
                        return this.GetAll();
                    }
                }
            }

            return null;
        }
    }
}
