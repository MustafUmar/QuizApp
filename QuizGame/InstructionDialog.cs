using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public static class InstructionDialog
    {
        public static void ShowInstructions()
        {
            Console.WriteLine("why are u not executing?");
            Form dg = new Form()
            {
                Width = 362,
                Height = 455,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };

            
            // instructokbtn
            Button instructokbtn = new Button{ DialogResult = DialogResult.OK };
            instructokbtn.Location = new System.Drawing.Point(143, 292);
            instructokbtn.Name = "instructokbtn";
            instructokbtn.Size = new System.Drawing.Size(75, 23);
            instructokbtn.TabIndex = 6;
            instructokbtn.Text = "OK";
            instructokbtn.UseVisualStyleBackColor = true;

            // instruct1lb
            Label instruct1lb = new Label();
            instruct1lb.AutoSize = true;
            instruct1lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            instruct1lb.Location = new System.Drawing.Point(3, 0);
            instruct1lb.Name = "instruct1lb";
            instruct1lb.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            instruct1lb.Size = new System.Drawing.Size(290, 34);
            instruct1lb.TabIndex = 0;
            instruct1lb.Text = "* Answer the questions within the time limit.";
            // 
            // instruct2lb
            // 
            Label instruct2lb = new Label();
            instruct2lb.AutoSize = true;
            instruct2lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            instruct2lb.Location = new System.Drawing.Point(3, 34);
            instruct2lb.Name = "instruct2lb";
            instruct2lb.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            instruct2lb.Size = new System.Drawing.Size(322, 52);
            instruct2lb.TabIndex = 5;
            instruct2lb.Text = "* There are 4 options for each question, choose the correct one.";
            // 
            // instruct3lb
            // 
            Label instruct3lb = new Label();
            instruct3lb.AutoSize = true;
            instruct3lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            instruct3lb.Location = new System.Drawing.Point(3, 86);
            instruct3lb.Name = "instruct3lb";
            instruct3lb.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            instruct3lb.Size = new System.Drawing.Size(218, 32);
            instruct3lb.TabIndex = 1;
            instruct3lb.Text = "* Each question has a time limit.";
            // 
            // instruct4lb
            //
            Label instruct4lb = new Label();
            instruct4lb.AutoSize = true;
            instruct4lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            instruct4lb.Location = new System.Drawing.Point(3, 118);
            instruct4lb.Name = "instruct4lb";
            instruct4lb.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            instruct4lb.Size = new System.Drawing.Size(239, 32);
            instruct4lb.TabIndex = 2;
            instruct4lb.Text = "* Each question carries 100 marks.";
            // 
            // instruct5lb
            // 
            Label instruct5lb = new Label();
            instruct5lb.AutoSize = true;
            instruct5lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            instruct5lb.Location = new System.Drawing.Point(3, 150);
            instruct5lb.Name = "instruct5lb";
            instruct5lb.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            instruct5lb.Size = new System.Drawing.Size(323, 50);
            instruct5lb.TabIndex = 3;
            instruct5lb.Text = "* The faster a question is answered, the higher     the chance of getting full ma" +
    "rks.";
            // 
            // instruct6lb
            // 
            Label instruct6lb = new Label();
            instruct6lb.AutoSize = true;
            instruct6lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            instruct6lb.Location = new System.Drawing.Point(3, 200);
            instruct6lb.Name = "instruct6lb";
            instruct6lb.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            instruct6lb.Size = new System.Drawing.Size(296, 50);
            instruct6lb.TabIndex = 4;
            instruct6lb.Text = "* Taking long in answering a question loses marks.";

            // 
            // flowpaneinstruct
            //  
            FlowLayoutPanel flowpaneinstruct = new FlowLayoutPanel();
            flowpaneinstruct.Controls.Add(instruct1lb);
            flowpaneinstruct.Controls.Add(instruct2lb);
            flowpaneinstruct.Controls.Add(instruct3lb);
            flowpaneinstruct.Controls.Add(instruct4lb);
            flowpaneinstruct.Controls.Add(instruct5lb);
            flowpaneinstruct.Controls.Add(instruct6lb);
            flowpaneinstruct.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowpaneinstruct.Location = new System.Drawing.Point(14, 17);
            flowpaneinstruct.Name = "flowpaneinstruct";
            flowpaneinstruct.Size = new System.Drawing.Size(330, 260);
            flowpaneinstruct.TabIndex = 5;

            // 
            // instructpane
            //
            Panel instructpane = new Panel();
            instructpane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            instructpane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            instructpane.Controls.Add(instructokbtn);
            instructpane.Controls.Add(flowpaneinstruct);
            instructpane.Dock = System.Windows.Forms.DockStyle.Fill;
            instructpane.Location = new System.Drawing.Point(0, 76);
            instructpane.Name = "instructpane";
            instructpane.Size = new System.Drawing.Size(358, 335);
            instructpane.TabIndex = 1;

            // 
            // instructtitlelb
            //
            Label instructtitlelb = new Label();
            //instructtitlelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            instructtitlelb.AutoSize = true;
            instructtitlelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            instructtitlelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            instructtitlelb.Location = new System.Drawing.Point(123, 23);
            instructtitlelb.Name = "instructtitlelb";
            instructtitlelb.Size = new System.Drawing.Size(128, 24);
            instructtitlelb.Text = "How To Play";

            // 
            // instructtitlepane
            // 
            Panel instructtitlepane = new Panel();
            instructtitlepane.BackColor = System.Drawing.Color.LightSlateGray;
            instructtitlepane.Controls.Add(instructtitlelb);
            instructtitlepane.Dock = System.Windows.Forms.DockStyle.Top;
            instructtitlepane.Location = new System.Drawing.Point(0, 0);
            instructtitlepane.Name = "instructtitlepane";
            instructtitlepane.Size = new System.Drawing.Size(358, 76);

            dg.Controls.Add(instructpane);
            dg.Controls.Add(instructtitlepane);

            dg.MinimizeBox = false;
            dg.MaximizeBox = false;
            dg.AcceptButton = instructokbtn;

            dg.ShowDialog();
        }
    }
}
