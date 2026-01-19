using Survey.Lib;
using Survey.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey.Services
{
    public class Security
    {

        Repository repo = new Repository(new SurveyEntities());
        BCryptPasswordHasher bCryptPasswordHasher = new BCryptPasswordHasher();
        public bool RegisterPerson(PersonReg personReg)
        {
            try
            {
                if (repo.GetEntities<Person>().Any(p => p.Username == personReg.Username || p.Email == personReg.Email))
                {
                    return false;
                }
                else
                {
                    Person newPerson = new Person
                    {
                        Name = personReg.Name,
                        Surname = personReg.Surname,
                        GroupName = personReg.GroupName,
                        Username = personReg.Username,
                        Email = personReg.Email,
                        PasswordHash = bCryptPasswordHasher.HashPassword(personReg.Password),
                        CreatedAt = DateTime.Now,
                        IsActive = true,
                        IsAdmin = false
                    };
                    repo.AddEntity<Person>(newPerson);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Person Login(string username, string password)
        {
            Person person = repo.GetEntities<Person>().FirstOrDefault(p => p.Username == username && p.IsActive && p.Enabled);
            bool isSuccess = person != null && bCryptPasswordHasher.VerifyPassword(password, person.PasswordHash);
            LogAuthenticationAttempt(username, isSuccess);
            if (isSuccess)
            {
                return person;
            }
            return null;
        }
        public void UpdateLastLogin(Person person)
        {
            person.LastLoginAt = DateTime.Now;
            repo.UpdateEntity<Person>(person);
        }
        public bool UpdatePassword(string email, string newPassword)
        {
            try
            {
                Person person = GetPersonByEmail(email);
                if (person == null)
                {
                    return false;
                }
                person.PasswordHash = bCryptPasswordHasher.HashPassword(newPassword);
                repo.UpdateEntity<Person>(person);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Person GetPersonByEmail(string email)
        {
            return repo.GetEntities<Person>().FirstOrDefault(p => p.Email == email);
        }
        private void LogAuthenticationAttempt(string username, bool isSuccess)
        {
            try 
            {
                Audit audit = new Audit
                {
                    LoginTime = DateTime.Now,
                    Id_Person = username != null ? repo.GetEntities<Person>().FirstOrDefault(p => p.Username == username)?.Id_Person ?? 0 : 0,
                    LoginResult = isSuccess
                };
                repo.AddEntity<Audit>(audit);
                if (!isSuccess && IsTooManyAttempts(username))
                {
                    Person person = repo.GetEntities<Person>().FirstOrDefault(p => p.Username == username);
                    if (person != null)
                    {
                        person.Enabled = false;
                        repo.UpdateEntity<Person>(person);
                        MessageBox.Show("Your account has been disabled due to too many failed login attempts. Please contact support.");
                    }
                }
            }
            catch
            {

            }
        }
        private bool IsTooManyAttempts(string username)
        {
            DateTime thresholdTime = DateTime.Now.AddMinutes(-15); // Check last 15 minutes
            int failedAttempts = repo.GetEntities<Audit>()
                .Count(a => a.Id_Person == repo.GetEntities<Person>().FirstOrDefault(p => p.Username == username)?.Id_Person
                            && !a.LoginResult
                            && a.LoginTime >= thresholdTime);
            return failedAttempts >= 5;
        }
    }
}
