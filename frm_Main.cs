using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomWorkout
{
    public enum enum_RunState : int
    {
        Stopped = 0,
        Exercising = 1,
        Resting = 2,
        Paused = 3,
        Waiting = 4
    }

    public partial class frm_Main : Form
    {
        int m_currItemIndex = -1;
        //int m_currCounterVal = 0;
        int m_dfltExTime = 30;
        int m_dfltRestTime = 15;
        //int m_currRestTime = 15;
        cls_ExItem m_CurrExItem;
        cls_ExItem m_NextExItem;
        //enum_RunState m_runState = enum_RunState.Stopped;
        enum_RunState m_PrevRunState = enum_RunState.Stopped;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            m_dfltExTime = Convert.ToInt32(f_DfltExTime.Text);
            m_dfltRestTime = Convert.ToInt32(f_DfltRestTime.Text);
            //m_currRestTime = m_dfltRestTime;

            loadTextFile(Application.StartupPath + @"\workout.txt");


        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            m_CurrExItem.currCounterVal--;
            l_Timer.Text = m_CurrExItem.currCounterVal.ToString();

            if (m_CurrExItem.currCounterVal <= 0)
            {
                if (m_CurrExItem.currState == enum_RunState.Exercising)
                {
                    if (m_CurrExItem.pauseAfter) ChangeState(enum_RunState.Paused);
                    else
                    {
                        m_CurrExItem.currCounterVal = m_CurrExItem.restTime;
                        ChangeState(enum_RunState.Resting);
                    }
                }
                else
                {
                    advanceToNextItem();
                }
                l_Timer.Text = m_CurrExItem.currCounterVal.ToString();
            }
        }


        private void advanceToNextItem()
        {
            m_currItemIndex++;
            if (loadItem(m_currItemIndex))
            {
                ChangeState(enum_RunState.Exercising);
            }
            else
            {
                timer1.Stop();
                l_CurrExercise.Text = "Done";
            }
        }


        private bool loadItem(int par_ItemIndex)
        {
            bool rval = false;
            if (m_currItemIndex < lb_ExList.Items.Count)
            {
                m_CurrExItem = new cls_ExItem(m_dfltExTime, m_dfltRestTime);
                m_NextExItem = new cls_ExItem(m_dfltExTime, m_dfltRestTime);

                m_CurrExItem.loadItem(lb_ExList.Items[m_currItemIndex].ToString());
                if (m_currItemIndex + 1 < lb_ExList.Items.Count)
                {
                    m_NextExItem.loadItem(lb_ExList.Items[m_currItemIndex + 1].ToString());
                    l_NextExercise.Text = m_NextExItem.exName;
                }
                else l_NextExercise.Text = "Done";
                m_CurrExItem.currCounterVal = m_CurrExItem.woTime;
                l_Timer.Text = m_CurrExItem.currCounterVal.ToString();
                //m_currCounterVal = m_CurrExItem.woTime;
                //m_currRestTime = m_CurrExItem.restTime;
                
                //l_Timer.Text = m_currCounterVal.ToString();
                //l_CurrExercise.Text = m_CurrExItem.exName;
                lb_ExList.SelectedIndex = par_ItemIndex;
                

                rval = true;
            }

            return rval;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (m_CurrExItem.currCounterVal < 1) advanceToNextItem();

            if (m_CurrExItem.currState == enum_RunState.Stopped)
            {
                m_currItemIndex = 0;
                loadItem(m_currItemIndex);
                ChangeState(enum_RunState.Exercising);
            }

            if (m_CurrExItem.currState == enum_RunState.Paused)
            {
                if (m_PrevRunState == enum_RunState.Resting) ChangeState(enum_RunState.Resting);
                else ChangeState(enum_RunState.Exercising);                
            }

        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            ChangeState(enum_RunState.Paused);
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            ChangeState(enum_RunState.Stopped);
        }

        private void f_DfltExTime_Validated(object sender, EventArgs e)
        {
            m_dfltExTime = Convert.ToInt32(f_DfltExTime.Text);
        }

        private void f_DfltRestTime_Validated(object sender, EventArgs e)
        {
            m_dfltRestTime = Convert.ToInt32(f_DfltRestTime.Text);
        }

        private void ChangeState(enum_RunState par_NewState)
        {
            
            switch (par_NewState)
            {
                case enum_RunState.Stopped:
                    timer1.Stop();
                    l_Paused.Visible = false;
                    btn_Start.Enabled = true;
                    btn_Pause.Enabled = false;
                    btn_Stop.Enabled = false;
                    m_PrevRunState = m_CurrExItem.currState;
                    m_CurrExItem.currState = enum_RunState.Stopped;
                    l_CurrExercise.Text = "Stopped";
                    l_Timer.Text = m_dfltExTime.ToString();
                    break;
                case enum_RunState.Exercising:
                    l_Paused.Visible = false;
                    btn_Pause.Enabled = true;
                    btn_Stop.Enabled = true;
                    btn_Start.Enabled = false;
                    m_PrevRunState = m_CurrExItem.currState;
                    m_CurrExItem.currState = enum_RunState.Exercising;
                    l_CurrExercise.Text = m_CurrExItem.exName;
                    l_Timer.Text = m_CurrExItem.currCounterVal.ToString(); 
                    timer1.Start();
                    break;
                case enum_RunState.Resting:
                    m_PrevRunState = m_CurrExItem.currState;
                    m_CurrExItem.currState = enum_RunState.Resting;
                    l_CurrExercise.Text = "Resting";
                    l_Timer.Text = m_CurrExItem.currCounterVal.ToString();
                    timer1.Start();
                    break;
                case enum_RunState.Paused:
                    timer1.Stop();
                    btn_Start.Enabled = true;
                    btn_Pause.Enabled = false;
                    btn_Stop.Enabled = true;
                    l_Paused.Visible = true;
                    m_PrevRunState = m_CurrExItem.currState;
                    m_CurrExItem.currState = enum_RunState.Paused;
                    break;
                case enum_RunState.Waiting:
                    break;
                default:
                    break;
            }
            m_CurrExItem.currState = par_NewState;
        }


        private void frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                //m_currItemIndex++;
                //loadItem(m_currItemIndex);
                advanceToNextItem();
                e.Handled = true;
                return;
            }

            switch (m_CurrExItem.currState)
            {
                case enum_RunState.Stopped:
                    //btn_Start.PerformClick();
                    break;
                case enum_RunState.Exercising:
                    btn_Pause.PerformClick();
                    break;
                case enum_RunState.Resting: 
                    btn_Pause.PerformClick();
                    break;
                case enum_RunState.Paused:
                    btn_Start.PerformClick();
                    break;
                case enum_RunState.Waiting:
                    //btn_Start.PerformClick();
                    break;
                default:
                    break;
            }
            e.Handled = true;
        }

        private int loadTextFile(string par_fileName)
        {
            int rval = 0;
            lb_ExList.Items.Clear();
            string ln = "";
            System.IO.StreamReader fl = new System.IO.StreamReader(par_fileName);
            while((ln = fl.ReadLine()) != null)
            {
                rval = lb_ExList.Items.Add(ln);
                lb_ExList.SetItemChecked(rval, true);
                rval++;
            }
            m_currItemIndex = 0;

            if(rval > 0) loadItem(0);
            return rval;
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            string fn = "";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            DialogResult rslt = openFileDialog1.ShowDialog();

            if (rslt == DialogResult.OK)
            {
                fn = openFileDialog1.FileName;
                loadTextFile(fn);
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath);
        }

        private void lb_ExList_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lb_ExList_DoubleClick(object sender, EventArgs e)
        {
            m_currItemIndex = lb_ExList.SelectedIndex;
            loadItem(m_currItemIndex);
            m_CurrExItem.currState = enum_RunState.Paused;
            btn_Start.PerformClick();
        }


    }
}
