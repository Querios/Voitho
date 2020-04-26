using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using voitho.SQLite;

namespace voitho.ViewModels
{
    public class OfferHelpVisualState : BaseVisualState
    {
        public ObservableCollection<ProblemCategory> CategoriesList => new ObservableCollection<ProblemCategory>
        {
            new ProblemCategory(CategoriesEnum.Shopping, "Shopping:"),
            new ProblemCategory(CategoriesEnum.Cleaning, "Cleaning:"),
            new ProblemCategory(CategoriesEnum.Pet_Caring, "Pet Caring:"),
            new ProblemCategory(CategoriesEnum.Psychological_Support, "Psychological Support:"),
            new ProblemCategory(CategoriesEnum.Nursing, "Nursing"),
            new ProblemCategory(CategoriesEnum.Other, "Other:")
        };
    }
}
