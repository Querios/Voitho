using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using voitho.SQLite;

namespace voitho.ViewModels
{
    public class AskForHelpVisualState: BaseVisualState
    {
        public AskForHelpVisualState(int selectedIndex = 0)
        {
            SelectedIndex = selectedIndex;
        }

        public ObservableCollection<ProblemCategory> CategoriesList => new ObservableCollection<ProblemCategory>
        {
            new ProblemCategory(CategoriesEnum.Null, "-- Please select a category --"),
            new ProblemCategory(CategoriesEnum.Shopping, "Shopping"),
            new ProblemCategory(CategoriesEnum.Cleaning, "Cleaning"),
            new ProblemCategory(CategoriesEnum.Pet_Caring, "Pet Caring"),
            new ProblemCategory(CategoriesEnum.Psychological_Support, "Psychological Support"),
            new ProblemCategory(CategoriesEnum.Nursing, "Nursing"),
            new ProblemCategory(CategoriesEnum.Other, "Other:")
        };

        protected int _pSelectedIndex;
        public int SelectedIndex
        {
            get
            {
                return _pSelectedIndex;
            }
            set
            {
                _pSelectedIndex = value;
                OnPropertyChanged(nameof(SelectedIndex));
            }
        }

        protected string _pComment;
        public string Comment
        {
            get
            {
                return _pComment;
            }
            set
            {
                _pComment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }

    }
}
