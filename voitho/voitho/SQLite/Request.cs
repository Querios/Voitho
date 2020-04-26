using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace voitho.SQLite
{
    public class Request: BaseClass
    {
        public Request(int requesterId, CategoriesEnum problemCategory, string comment)
        {
            RequesterId = requesterId;
            ProblemCategory = problemCategory;
            Comment = comment;
        }

        public Request() { }

        protected int _pID;
        [PrimaryKey]
        [AutoIncrement]
        public int ID
        {
            get { return _pID; }
            set
            {
                _pID = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        protected int _pRequesterId;

        public int RequesterId
        {
            get { return _pRequesterId; }
            set
            {
                _pRequesterId = value;
                OnPropertyChanged(nameof(RequesterId));
            }
        }

        protected CategoriesEnum _pProblemCategory;

        public CategoriesEnum ProblemCategory
        {
            get { return _pProblemCategory; }
            set
            {
                _pProblemCategory = value;
                OnPropertyChanged(nameof(ProblemCategory));
            }
        }

        protected string _pComment;

        public string Comment
        {
            get { return _pComment; }
            set
            {
                _pComment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }

    }
}
