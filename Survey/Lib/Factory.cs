using Survey.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Lib
{
    public class Factory
    {
        Repository repository = new Repository(new SurveyEntities());
        public List<TestView> GetTests()
        {
            return MapTestsToTestViews(repository.GetEntities<Test>());
        }
        public List<Test> GetTestEntities()
        {
            return repository.GetEntities<Test>();
        }
        public void AddTest(Test test)
        {
            repository.AddEntity<Test>(test);
        }
        public Test GetTestById(long id)
        {
            return repository.GetEntityById<Test>(id);
        }
        public void UpdateTest(Test test)
        {
            repository.UpdateEntity<Test>(test);
            
        }
        public void AddQuestion(Question question)
        {
            repository.AddEntity<Question>(question);
        }
        private List<TestView> MapTestsToTestViews(List<Test> tests)
        {
            List<TestView> testViews = new List<TestView>();
            foreach (var test in tests)
            {
                TestView testView = new TestView
                {
                    Id_Test = test.Id_Test,
                    Name = test.Name,
                    Duration = test.Duration,
                    Author = test.Author,
                    CreateDate = test.CreateDate,
                    IsActive = test.IsActive
                };
                testViews.Add(testView);
            }
            return testViews;
        }
    }
}
