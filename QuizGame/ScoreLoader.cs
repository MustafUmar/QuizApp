using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace QuizGame
{
    class ScoreLoader
    {
        private bool Isloaded = false;
        public List<Scores> scores { get; set; }
        public Scores currentPlayer { get; set; }

        public ScoreLoader()
        {
            string data;
            try
            {
                using (StreamReader st = new StreamReader("scores.json"))
                {
                    data = st.ReadToEnd();
                }
                scores = JsonConvert
                    .DeserializeObject<List<Scores>>(data)
                    .OrderByDescending(s => s.playerScore)
                    .ThenBy(s => s.playerTime)
                    .ToList();
                
                Isloaded = true;
            }
            catch (Exception)
            {
                Isloaded = false;
            }
            
        }

        public ScoreStat add(Scores newscore)
        {
            //ScoreStat curstat;
            if (isLoaded)
            {
                if(newscore.playerScore > 0 ) {
                    var oldscore = scores.FindIndex(s => s.playerName.Equals(newscore.playerName) && s.passkey.Equals(newscore.passkey));
                    if (oldscore > -1)
                    {
                        if (scores[oldscore].playerScore > newscore.playerScore)
                            return ScoreStat.NotUpdated;
                        else
                        {
                            scores[oldscore].playerScore = newscore.playerScore;
                            scores[oldscore].playerTime = newscore.playerTime;

                            try { saveScores(); }
                            catch (IOException e)
                            { return ScoreStat.Missing; }

                            return ScoreStat.Updated;
                        }

                    }
                    else
                    {
                        if (scores.Count() > 40)
                        {
                            if (scores.Last().playerScore > newscore.playerScore)
                                return ScoreStat.NoAdd;
                            else
                            {
                                scores.RemoveAt(scores.Count - 1);
                                scores.Add(newscore);
                                scores = scores.OrderByDescending(s => s.playerScore)
                                                .ThenBy(s => s.playerTime)
                                                .ToList();
                                try { saveScores(); }
                                catch (IOException e)
                                { return ScoreStat.Missing; }

                                return ScoreStat.NewScore;
                            }
                        }
                        else
                        {
                            scores.Add(newscore);
                            scores = scores.OrderByDescending(s => s.playerScore)
                                            .ThenBy(s => s.playerTime)
                                            .ToList();
                            try { saveScores(); }
                            catch (IOException e)
                            { return ScoreStat.Missing; }

                            return ScoreStat.NewScore;
                        }
                    }
                } else
                {
                    return ScoreStat.NoAdd;
                } 
            }
            else
                return ScoreStat.Missing;
            

        }

        public void saveScores()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("scores.json", false))
            //using(JsonWriter jw = new JsonTextWriter(sw)
            {
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(sw, scores);
            }
        }

        public bool isLoaded
        {
            get {
                return Isloaded;
            }
            
        }

        public int playerPosition(Scores sc)
        {
            return scores.FindIndex(s => s.Equals(sc)) + 1;
        }

        public Scores getPlayer(string name)
        {
            return scores.Find(s => s.playerName.Equals(name.ToFirstCharUpper()));   
        }
    }
}
