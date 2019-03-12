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
        private bool started = false;
        private bool end = false;
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
                    //string questions = @"[
                    //    {
                    //        'question':'What is the name of the main actor of the movie - The terminator?',
                    //        'choices':['Keanu Reaves','Arnold Swachzeneggar','Denzel Washington','Christian Bale'],
                    //        'answer': 'bCbfGVVC0hSOGNDDaRSDz0V7OsvNXYO7NhxbUCTxIsaKadmC3ex34lA3j2WBVj+N'
                    //    },
                    //    {
                    //        ""question"":""Which is the meaning of NIIT?"",
                    //        ""choices"":['National Indepenent Industrial Technology','National Institute of Industrial Technology',
                    //                        'Nation of Indutrial Indian Technology','National Institute of Information Technology'],
                    //        ""answer"": 'WSQU6deAFU/LQRzh+XPUsMbGQim+ab/Y67RdwOHb2TXQoJSR8n5OvQinIvN5yDWLurYEshGrY/ALKG7hwk0NyEAy4fY5JCecwH7EnKhiwKpVZT6nhSh0NbpghOWUx6IV'
                    //    },
                    //    {
                    //        'question':'Fish are cold blooded animals.',
                    //        'choices':['True','False','Both','None'],
                    //        'answer': 'ELpwUqZ0NM615wd2eGNf+w=='
                    //    }
                    //]";
                quizzes = JsonConvert.DeserializeObject<List<Quiz>>(questions);
                Shuffle();
                currentq = 1;
                currentIndex = 0;
                if(quizzes.Count < numquest)
                    numofquestions = quizzes.Count;
                else
                    numofquestions = numquest;
            }



            //started = true;
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

        //public bool checkAnswer(string choice)
        //{
        //    Quiz q = quizzes[currentq];
        //    return Array.Exists(q.choices, el => el.IndexOf(choice) == q.answer);
        //}

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
