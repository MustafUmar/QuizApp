using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace QuizGame
{
    class QuizLoader
    {
        private List<Quiz> quizzes;
        private int currentq = 0;
        private int currentIndex;
        private int numofquestions;
        private QuizTypes loadedquiz;
        private Random rndanswers;

        public QuizLoader()
        {
            rndanswers = new Random();
        }

        public Quiz loadQuiz(QuizTypes quiztype, int numquest)
        {
            if (quizzes != null && loadedquiz == quiztype && quizzes.Count < 0)
            {
                currentq = 0;
                return next();
            }
                
            else
            {
                FileStream fs = null;
                string questions = null;
                switch (quiztype)
                {
                    case QuizTypes.EASY:
                        loadedquiz = QuizTypes.EASY;
                        fs = new FileStream("questions.json", FileMode.Open, FileAccess.Read);
                        break;
                    case QuizTypes.MEDIUM:
                        loadedquiz = QuizTypes.MEDIUM;
                        break;
                    case QuizTypes.HARD:
                        loadedquiz = QuizTypes.HARD;
                        break;
                    default:
                        loadedquiz = QuizTypes.EASY;
                        fs = new FileStream("questions.json", FileMode.Open, FileAccess.Read);
                        break;
                }

                using (StreamReader sr = new StreamReader(fs))
                {
                    questions = sr.ReadToEnd();
                }
                   
                quizzes = JsonConvert.DeserializeObject<List<Quiz>>(questions);
                Shuffle();
                currentq = 1;
                currentIndex = 0;
                if(quizzes.Count < numquest)
                    numofquestions = quizzes.Count;
                else
                    numofquestions = numquest;
            }



            //shuffle quiz
            quizzes[currentIndex].choices = shuffleAnswers(quizzes[currentIndex].choices);
            return quizzes[currentIndex];
        }

        public Quiz next()
        {
            if (currentIndex > quizzes.Count)
                currentIndex = 0;
            else
                currentIndex++;
            currentq++;
            quizzes[currentIndex].choices = shuffleAnswers(quizzes[currentIndex].choices);
            return quizzes[currentIndex];   
        }

        public int numberOfQuestions()
        {
            return numofquestions;
        }

        public int numberOfAllQuestions()
        {
            return quizzes.Count();
        }

        public int currentnum()
        {
            return currentq;
        }

        public bool isEnd()
        {
            return currentq >= numofquestions;
        }

        private void Shuffle()
        {
            var rnd = new Random();
            this.quizzes = quizzes.OrderBy(x => rnd.Next()).ToList();
        }

        private string[] shuffleAnswers(string[] options)
        {
            return options.OrderBy(x => rndanswers.Next()).ToArray();
        }

        public List<Quiz> Quizzes
        {
            get { return quizzes; }
            set { quizzes = value; }
        }

        
    }
}
