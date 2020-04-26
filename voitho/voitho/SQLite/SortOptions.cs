using System;
using System.Collections.Generic;
using System.Text;

namespace voitho.SQLite
{
    public class SortOptions : BaseClass
    {
        protected SortOptionsEnum _pSortOptionsEnum;
        public SortOptionsEnum SortOptionsEnum
        {
            get { return _pSortOptionsEnum; }
            set
            {
                _pSortOptionsEnum = value;
                OnPropertyChanged(nameof(SortOptionsEnum));
            }
        }

        protected string _pSortOptionName;
        public SortOptions(SortOptionsEnum sortOptionsEnum, string sortOptionName)
        {
            SortOptionsEnum = sortOptionsEnum;
            SortOptionName = sortOptionName;
        }

        public string SortOptionName
        {
            get { return _pSortOptionName; }
            set
            {
                _pSortOptionName = value;
                OnPropertyChanged(nameof(SortOptionName));
            }
        }
    }
}
