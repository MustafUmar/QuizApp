using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Security.Cryptography;
using Transitions;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        private double timeleft = 0.00;
        private int score = 0;
        private double time;
        private QuizLoader quizloader;
        private Quiz question;
        private ScoreLoader scoreloader;
        private Scores currentPlayer;
        private Stopwatch stopwatch;
        private bool isAsked;
        private bool ended;
        private Random rndsound;

        private SoundPlayer popsound, tick, correctsound, timesup;
        private List<SoundPlayer> failsounds;

        private Transition transition;

        public Form1()
        {
            InitializeComponent();

            SetDoubleBuffered(this.highscoretable);

            quizloader = new QuizLoader();
            scoreloader = new ScoreLoader();
            if (!scoreloader.isLoaded)
                MessageBox.Show(this, "Some files are missing and the application may not work properly.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            stopwatch = new Stopwatch();

            //sounds
            initSounds();
            rndsound = new Random();

            //transition
            transition = new Transition(new TransitionType_CriticalDamping(600));
            transition.add(quizdisplaypane, "Left", 8);
           
            //displayHighscores();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //--timeleft;
            //countdownbar.Value = timeleft * 10;
            countdownbar.Value = Convert.ToInt32(((timeleft/10000) * 100));
            if (timeleft > 0)
            {
                //countdownbar.PerformStep();
                //ctdownlb.Text = timeleft.ToString();
            } else
            {   
                //ctdownlb.Text = "Time's Up";
                timer1.Stop();
                tick.Stop();
                stopwatch.Stop();
                foreach (var radio in optionsgrid.Controls.OfType<RadioButton>())
                {
                    radio.Enabled = false;
                }
                timeoutanswer();
            }
            timeleft -= timer1.Interval;
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ended = false;
            resetContent();
            //timer1.Tick -= timer1_Tick;
            score = 0;
            this.Controls.Add(this.quizpanel);
            question = quizloader.loadQuiz(QuizTypes.EASY, 10);
            questnumlb.Text = quizloader.currentnum().ToString();
            questtotallb.Text = quizloader.numberOfQuestions().ToString();
            countdownbar.Value = 100;
            curnumscorelb.Text = score.ToString();
            displayQuestion();
            //sounds
            transition.run();
            popsound.Play();
            tick.Play();
            
            //timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void choosedOption(object sender, EventArgs e)
        {
            timer1.Stop();
            tick.Stop();
            stopwatch.Stop();
            for (int i = 0; i < 5; i++)
            {
                optionsgrid.Controls.OfType<FlowLayoutPanel>().ElementAt(i).Controls.OfType<Label>().ElementAt(0).Enabled = false;
            }
            foreach (var radio in optionsgrid.Controls.OfType<RadioButton>())
            {
                radio.Enabled = false;
            }
            RadioButton choice = (RadioButton)sender;
            int index = optionsgrid.Controls.OfType<RadioButton>().ToList().IndexOf(choice);

            FlowLayoutPanel flowpane = (FlowLayoutPanel)optionsgrid.GetControlFromPosition(1, index + 1);
            Label lb = (Label)flowpane.Controls.OfType<Label>().ToList()[0];
            
            if (choice.Checked)
            {
                checkanswer(lb, index, flowpane);
            }
            
            
        }

        private void option1lb_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tick.Stop();
            stopwatch.Stop();
            foreach (var radio in optionsgrid.Controls.OfType<RadioButton>())
            {
                radio.Enabled = false;
            }
            Label choicelb = sender as Label;
            int index = optionsgrid.Controls.OfType<FlowLayoutPanel>().ToList().FindIndex(f => f.Controls.OfType<Label>().Contains(choicelb));
            FlowLayoutPanel flowpane = (FlowLayoutPanel)optionsgrid.GetControlFromPosition(1, index + 1);
            optionsgrid.Controls.OfType<RadioButton>().ElementAt(index).Checked = true;
            
            checkanswer(choicelb, index, flowpane);
        }

        private void checkanswer(Label lb, int index, FlowLayoutPanel fp = null)
        {
            if (lb.Text.Equals(Cipher.Decrypt(question.answer)))
            {
                this.optionsgrid.Controls.Add(correctlb, 2, index + 1);
                lb.ForeColor = System.Drawing.Color.YellowGreen;
                correctsound.Play();
                //score += 10;
                time += stopwatch.ElapsedMilliseconds / 1000;

                //scoring against time
                //if time is less than 8 secs, minus the score
                if ((timeleft > 6500))
                    score += 10;
                else if (timeleft > 4000)
                    score += 8;
                else if (timeleft > 2000)
                    score += 6;
                else
                    score += 5;

                //update ui score
                curnumscorelb.Text = score.ToString();
                
            }
            else
            {
                //RadioButton correctanswer = optionsgrid.Controls.OfType<RadioButton>().ElementAt(question.answer);
                FlowLayoutPanel flowpane2 = optionsgrid.Controls.OfType<FlowLayoutPanel>().First(x => x.Controls.OfType<Label>().ToList()[0].Text.Equals(Cipher.Decrypt(question.answer)));
                failsounds[rndsound.Next(failsounds.Count)].Play();
                int index2 = optionsgrid.Controls.OfType<FlowLayoutPanel>().ToList().IndexOf(flowpane2);
                //FlowLayoutPanel flowpane2 = (FlowLayoutPanel)optionsgrid.GetControlFromPosition(1, question.answer + 1);
                Label lb2 = (Label) flowpane2.Controls.OfType<Label>().ToList()[0];
                this.optionsgrid.Controls.Add(wronglb, 2, index + 1);
                this.optionsgrid.Controls.Add(correctlb, 2, index2 + 1);
                lb2.ForeColor = System.Drawing.Color.YellowGreen;
                lb.ForeColor = System.Drawing.Color.Tomato;
            }


            nextQuestion();
        }

        private void timeoutanswer()
        {
            timesup.Play();
            //FlowLayoutPanel flowpane2 = (FlowLayoutPanel)optionsgrid.GetControlFromPosition(1, question.answer + 1);
            FlowLayoutPanel flowpane2 = optionsgrid.Controls.OfType<FlowLayoutPanel>().First(x => x.Controls.OfType<Label>().ToList()[0].Text.Equals(Cipher.Decrypt(question.answer)));
            int index2 = optionsgrid.Controls.OfType<FlowLayoutPanel>().ToList().IndexOf(flowpane2);
            Label lb2 = (Label)flowpane2.Controls.OfType<Label>().ToList()[0];
            this.optionsgrid.Controls.Add(correctlb, 2, index2 + 1);
            lb2.ForeColor = System.Drawing.Color.YellowGreen;
            nextQuestion();
        }

        private async void nextQuestion()
        {
            await Task.Delay(3500);

            loadQuestion();
            
        }

        public void loadQuestion()
        {
            if(!ended)
                if (!quizloader.isEnd())
                {
                    question = quizloader.next();

                    resetContent();
                    displayQuestion();
                    transition.run();

                    popsound.Play();
                    tick.Play();
                    timer1.Start();
                    stopwatch.Restart();
                }
                else
                    Stop();
            
        }

        public void displayQuestion()
        {
            //ctdownlb.Text = timeleft.ToString();
            quizdisplaypane.Left = 181;
            questlb.Text = question.question;
            option1lb.Text = question.choices[0];
            option2lb.Text = question.choices[1];
            option3lb.Text = question.choices[2];
            option4lb.Text = question.choices[3];
        }

        private void resetContent()
        {
            timeleft = 10000;
            countdownbar.Value = 100;
            this.optionsgrid.Controls.Remove(correctlb);
            this.optionsgrid.Controls.Remove(wronglb);
            option1lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            option2lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            option3lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            option4lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            questnumlb.Text = quizloader.currentnum().ToString();
            countdownbar.Value = 100;

            foreach (var radio in optionsgrid.Controls.OfType<RadioButton>())
            {
                radio.Checked = false;
                radio.Enabled = true;
            }
            timer1.Enabled = false;
            timer1.Enabled = true;
            stopwatch.Reset();
        }

        private void Stop()
        {
            timer1.Stop();
            stopwatch.Stop();
            timer1.Enabled = false;
            //timer1.Tick -= timer1_Tick;
            tick.Stop();
            //resetContent();
            if (currentPlayer == null)
            {
                if(!isAsked)
                {
                    string name = InputDialog.ShowDialog("Enter your name: ");
                    if (name != null && name != "")
                    {
                        setPlayer(name);
                        currentPlayer.playerScore = score;
                        prepHighscores();
                        curplayernamelb.Text = currentPlayer.playerName;
                        curscorelb.Text = currentPlayer.playerScore.ToString();
                    }
                    else
                    {
                        curplayernamelb.Text = "Guest";
                        curscorelb.Text = score.ToString();
                    }

                    isAsked = true;
                } else
                {
                    curplayernamelb.Text = "Guest";
                    curscorelb.Text = score.ToString();
                }
                
            } else
            {
                currentPlayer.playerScore = score;
                prepHighscores();
                curplayernamelb.Text = currentPlayer.playerName;
                curscorelb.Text = currentPlayer.playerScore.ToString();
            }
            this.highscorepanel.Controls.Add(currentscorepanel);
            displayHighscores();
            

        }

        public void prepHighscores()
        {
            var scorestat = scoreloader.add(currentPlayer);
            currentPlayer.playerScore = score;
            currentPlayer.playerTime = time / quizloader.numberOfQuestions();
            switch (scorestat)
            {
                case ScoreStat.NewScore:
                    this.highscoretable.Paint += highScoreTablePaintEvent;
                    Trace.WriteLine("NewScore");
                    break;
                case ScoreStat.Updated:
                    this.highscoretable.Paint += highScoreTablePaintEvent;
                    Trace.WriteLine("Updated");
                    break;
                case ScoreStat.NotUpdated:
                    Trace.WriteLine("Not Updated");
                    break;
                case ScoreStat.NoAdd:
                    Trace.WriteLine("No Add");
                    break;
                case ScoreStat.Missing:
                    MessageBox.Show("Cannot save scores.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    break;
                default:
                    break;
            }
        }

        private void displayHighscores()
        {
            if(scoreloader.isLoaded)
            {
                //for (int i = highscoretable.RowCount - 1; i > 1; i--)
                //{
                //    for (int j = 0; j < highscoretable.ColumnCount; i++)
                //    {
                //        Control c = this.highscoretable.GetControlFromPosition(j, i);
                //        this.highscoretable.Controls.Remove(c);
                //        if(c != null)
                //            c.Dispose();
                //    }
                //    this.highscoretable.RowStyles.RemoveAt(i);
                //    this.highscoretable.RowCount--;
                //}
                this.highscoretable.Controls.Clear();
                this.highscoretable.RowCount = 0;
                this.highscoretable.RowCount = 41;
                this.highscoretable.Controls.Add(this.avgtimehdlb, 3, 0);
                this.highscoretable.Controls.Add(this.scorehdlb, 2, 0);
                this.highscoretable.Controls.Add(this.namehdscorelb, 1, 0);
                this.highscoretable.Controls.Add(this.numhdscorelb, 0, 0);
                List<Scores> scores = scoreloader.scores;
                this.highscoretable.SuspendLayout();
                for (int i = 1; i < 41; i++)
                {
                    this.highscoretable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                    Label numrowlb = new Label();
                    numrowlb.AutoSize = true;
                    numrowlb.Font = new System.Drawing.Font("Imprint MT Shadow", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    numrowlb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                    //numrowlb.Location = new System.Drawing.Point(8, 5);
                    numrowlb.Name = "numrowlb";
                    //numrowlb.Size = new System.Drawing.Size(97, 13);
                    numrowlb.Text = i.ToString();
                    numrowlb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));

                    this.highscoretable.Controls.Add(numrowlb, 0, i);

                    Label namelb = new Label();
                    namelb.AutoSize = true;
                    namelb.Font = new System.Drawing.Font("Imprint MT Shadow", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    namelb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                    //numrowlb.Location = new System.Drawing.Point(8, 5);
                    namelb.Name = "numrowlb";
                    //namelb.Size = new System.Drawing.Size(97, 13);
                    namelb.Text = i - 1 < scores.Count() ? scores[i-1].playerName : "-";
                    namelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                    this.highscoretable.Controls.Add(namelb, 1, i);

                    Label scorelb = new Label();
                    scorelb.AutoSize = true;
                    scorelb.Font = new System.Drawing.Font("Imprint MT Shadow", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    scorelb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                    //numrowlb.Location = new System.Drawing.Point(8, 5);
                    scorelb.Name = "numrowlb";
                    //scorelb.Size = new System.Drawing.Size(97, 13);
                    scorelb.Text = i - 1 < scores.Count() ? scores[i-1].playerScore.ToString() : "-";
                    scorelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                    this.highscoretable.Controls.Add(scorelb, 2, i);

                    Label timelb = new Label();
                    timelb.AutoSize = true;
                    timelb.Font = new System.Drawing.Font("Imprint MT Shadow", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    timelb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                    //numrowlb.Location = new System.Drawing.Point(8, 5);
                    timelb.Name = "numrowlb";
                    //timelb.Size = new System.Drawing.Size(97, 13);
                    timelb.Text = i - 1 < scores.Count() ? scores[i - 1].playerTime.ToString() : "-";
                    timelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                    this.highscoretable.Controls.Add(timelb, 3, i);
                    
                }
                this.highscoretable.ResumeLayout(false);
                this.highscoretable.PerformLayout();

                //how to highlight a row

                this.Controls.Clear();
                this.Controls.Add(this.highscorepanel);

            } else
            {
                MessageBox.Show("Cannot fetch scores.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
   
        }

        private void closelb_Click(object sender, EventArgs e)
        {
            ended = true;
            timer1.Stop();
            stopwatch.Stop();
            tick.Stop();
            this.highscoretable.Paint -= highScoreTablePaintEvent;
            this.highscorepanel.Controls.Remove(currentscorepanel);
            this.showMainmenu();
        }

        private void highscorebtn_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            //this.Controls.Add(this.highscorepanel);
            this.displayHighscores();
        }

        private void backmenubtn_Click(object sender, EventArgs e)
        {
            this.highscoretable.Paint -= highScoreTablePaintEvent;
            this.highscorepanel.Controls.Remove(currentscorepanel);
            this.showMainmenu();
        }

        private void showMainmenu()
        {
            this.Controls.Clear();
            this.Controls.Add(this.menupanel);
        }

        private void playernamebtn_Click(object sender, EventArgs e)
        {
            if (currentPlayer == null)
            {
                string name = InputDialog.ShowDialog("Player Name: ");
                if (name != null && name != "")
                {
                    setPlayer(name);
                    playernamebtn.Text = currentPlayer.playerName;
                    playernamebtn.Enabled = false;
                }
                isAsked = true;
            }

        }

        private void setPlayer(string name)
        {
            int num;
            string key;
            Scores player = scoreloader.getPlayer(name.ToFirstCharUpper());
            if (player != null)
            {
                if (player.passkey != "" && player.passkey != null)
                {
                    key = InputDialog.ShowDialog("Enter your key: ");
                    if (key == player.passkey)
                        currentPlayer = player;
                    else
                    {
                        if (int.TryParse(player.playerName.Last().ToString(), out num))
                            currentPlayer.playerName = player.playerName + (num + 1);
                        else
                            currentPlayer.playerName = player.playerName + 1;
                        currentPlayer.passkey = "";
                    }

                } else
                {
                    currentPlayer = player;
                    currentPlayer.passkey = "";
                }
                    
            }
            else
            {
                Trace.WriteLine("SetPlayer");
                currentPlayer = new Scores();
                currentPlayer.playerName = name.ToFirstCharUpper();
            }
            
        }

        private void highScoreTablePaintEvent(object sender, PaintEventArgs e)
        {
            Trace.WriteLine("Paint");
            if (currentPlayer != null)
                scorecontentpanel.ScrollControlIntoView(this.highscoretable.GetControlFromPosition(1, scoreloader.playerPosition(currentPlayer)));
        }

        private void initSounds()
        {
            popsound = new SoundPlayer("sounds/plop.wav");
            tick = new SoundPlayer("sounds/fast-clock-tick.wav");
            correctsound = new SoundPlayer("sounds/correct-answer2.wav");
            timesup = new SoundPlayer("sounds/bang-times-up.wav");
            failsounds = new List<SoundPlayer>
            {
                //new SoundPlayer("sounds/bang.wav"),
                new SoundPlayer("sounds/bangboing.wav"),
                new SoundPlayer("sounds/boing(long).wav"),
                new SoundPlayer("sounds/boing2.wav"),
                new SoundPlayer("sounds/glass-breaking.wav"),
                new SoundPlayer("sounds/rec-scratch.wav")
            };
        }

        private static void SetDoubleBuffered(Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo prop = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            prop.SetValue(c, true, null);
        }
        
        private void quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void transit()
        {
            //multiple property transition
            Transition tr = new Transition(new TransitionType_EaseInEaseOut(2000));
            tr.add(questionlb, "Left", 200);
            tr.run();

            //single property transtion
            Transition.run(questionlb, "ForeColor", Color.Red, new TransitionType_Bounce(1500));
        }
        
        
    }
}
