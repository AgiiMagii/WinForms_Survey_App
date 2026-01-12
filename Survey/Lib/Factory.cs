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
        public List<Question> GetQuestionEntities()
        {
            return repository.GetEntities<Question>();
        }
        public void AddTest(Test test)
        {
            repository.AddEntity<Test>(test);
        }
        public Test GetTestById(long id)
        {
            return repository.GetEntityById<Test>(id);
        }
        public List<QuestionView> GetQuestionViewByTestId(long testId)
        {
            return MapQuestionsToQuestionViews(repository.GetEntityById<Test>(testId).Question.ToList());
        }
        public void UpdateTest(Test test)
        {
            repository.UpdateEntity<Test>(test);
        }
        public void UpdateQuestion(Question question)
        {
            repository.UpdateEntity<Question>(question);
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
        private List<QuestionView> MapQuestionsToQuestionViews(List<Question> questions)
        {
            List<QuestionView> questionViews = new List<QuestionView>();
            foreach (var question in questions)
            {
                QuestionView questionView = new QuestionView
                {
                    Id_Question = question.Id_Question,
                    Question1 = question.Question1,
                    Answer1 = question.Answer1,
                    Answer2 = question.Answer2,
                    Answer3 = question.Answer3,
                    Answer4 = question.Answer4,
                    CorrectAnswer = question.CorrectNr
                };
                questionViews.Add(questionView);
            }
            return questionViews;
        }
        public void DeleteTest(Test test)
        {
            repository.DeleteEntity<Test>(test);
        }
        public void DeleteQuestion(Question question)
        {
            repository.DeleteEntity<Question>(question);
        }
        public List<GroupName> GetGroupNames()
        {
            return repository.GetEntities<GroupName>();
        }
        
    }
}
