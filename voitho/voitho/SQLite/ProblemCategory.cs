using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite;

namespace voitho.SQLite
{
    public class ProblemCategory : BaseClass
    {

        public ProblemCategory(CategoriesEnum categoryId, string categoryName, bool isSelected = false)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            IsSelected = isSelected;
        }

        protected CategoriesEnum _pCategoryId;
        [PrimaryKey]
        public CategoriesEnum CategoryId
        {
            get { return _pCategoryId; }
            set
            {
                _pCategoryId = value;
                OnPropertyChanged(nameof(CategoryId));
            }
        }

        protected string _pCategoryName;
        public string CategoryName
        {
            get { return _pCategoryName; }
            set
            {
                _pCategoryName = value;
                OnPropertyChanged(nameof(CategoryName));
            }
        }

        protected bool _pIsSelected;

        public bool IsSelected
        {
            get { return _pIsSelected; }
            set
            {
                _pIsSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
    }
}
