using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voitho.SQLite
{
    public class SQLiteManager : BaseClass
    {
        SQLiteConnection db = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "voitho.db3"));
        public SQLiteManager()
        {
            db.CreateTable<User>();

            db.CreateTable<Request>();

            //Mock Data
            if (GetAllUsers().Result.Count == 0)
            {
                InsertUser(new User("johndoe", "password", "test@test.test", "John", "Doe", DateTime.Today.AddYears(-5),
                    "Country", "City", "Address 01",
                    "12345", "1234567890", 1, false));
                InsertUser(new User("User1", "password", "test@test.test", "John", "Doe", DateTime.Today.AddYears(-5),
                    "Country", "City", "Address 01",
                    "12345", "1234567890", 150, false));
                InsertUser(new User("User5", "password", "test@test.test", "John", "Doe", DateTime.Today.AddYears(-5),
                    "Country", "City", "Address 01",
                    "12345", "1234567890", 44, false));
                InsertUser(new User("User2", "password", "test@test.test", "John", "Doe", DateTime.Today.AddYears(-5),
                    "Country", "City", "Address 01",
                    "12345", "1234567890", 44, false));
                InsertUser(new User("User4", "password", "test@test.test", "John", "Doe", DateTime.Today.AddYears(-5),
                    "Country", "City", "Address 01",
                    "12345", "1234567890", 0, false));
                InsertUser(new User("User3", "password", "test@test.test", "John", "Doe", DateTime.Today.AddYears(-5),
                    "Country", "City", "Address 01",
                    "12345", "1234567890", 10, false));
            }
        }

        #region For Users

        protected User _pLastUserSearched;
        public User LastUserSearched
        {
            get
            {
                return _pLastUserSearched;
            }
            set
            {
                _pLastUserSearched = value;
                OnPropertyChanged(nameof(LastUserSearched));
            }
        }

        public async Task<bool> InsertUser(User user)
        {
            try
            {
                db.Insert(user);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteUser(User user)
        {
            try
            {
                db.Delete(user);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteAllUsers()
        {
            try
            {
                db.DeleteAll<User>();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> UpdateUser(User user)
        {
            try
            {
                db.Update(user);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return db.Table<User>().ToList();
        }

        public async Task<bool> ActiveUserExists()
        {
            var UsersList = GetAllUsers().Result;
            return UsersList?.Count > 0 && UsersList.Where(el => el.IsActiveUser == true).Count() > 0;
        }

        public async Task<bool> LoginTask(string username, string password)
        {
            var users = GetAllUsers().Result;
            if (users.Count > 0)
            {
                var user = users.Where(el => el.Username == username && el.Password == password);
                if (user.Count() > 0)
                {
                    LastUserSearched = user.FirstOrDefault();
                    return true;
                }
            }

            return false;
        }

        public async Task<User> GetActiveUser()
        {
            return GetAllUsers().Result.Where(el => el.IsActiveUser == true).FirstOrDefault();
        }

        public async Task<bool> DisableActiveUser()
        {
            try
            {
                foreach (var user in GetAllUsers().Result)
                {
                    user.IsActiveUser = false;
                    db.Update(user);
                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> SetActiveUser(User user)
        {
            try
            {
                foreach (var savedUser in GetAllUsers().Result)
                {
                    savedUser.IsActiveUser = savedUser.ID == user.ID;
                    await UpdateUser(savedUser);
                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region For Requests
        
        public async Task<bool> InsertRequest(Request request)
        {
            try
            {
                db.Insert(request);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteRequest(Request request)
        {
            try
            {
                db.Delete(request);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteAllRequests()
        {
            try
            {
                db.DeleteAll<Request>();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> UpdateRequest(Request request)
        {
            try
            {
                db.Update(request);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<List<Request>> GetAllRequests()
        {
            return db.Table<Request>().ToList();
        }
        
        #endregion
    }
}
