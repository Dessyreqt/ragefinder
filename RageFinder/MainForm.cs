using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RageFinder
{
    public partial class MainForm : Form
    {
        private FormationData formationData;
        private readonly List<int> history;
        private readonly List<int> nextFormations;
        private List<int> findFormations;
        private int startSeed1;
        private int startSeed2;
        private int resetSeed1;
        private int resetSeed2;
        private int startGroup;
        private int matches;
        private int resetGroup;
        private bool resetGroupFound;

        public MainForm()
        {
            InitializeComponent();
            history = new List<int>();
            nextFormations = new List<int>();
        }

        private void groupNum_ValueChanged(object sender, EventArgs e)
        {
            RemoveCheckEvents();

            if (groupNum.Value == -1)
            {
                groupNum.Value = 63;
            }
            else if (groupNum.Value == 64)
            {
                groupNum.Value = 0;
            }
            else
            {
                SetFormations();
                formationData.SelectedGroupNum = (int)groupNum.Value;
                FormationData.Save(formationData);
            }
 
            AddCheckEvents();
        }

        private void AddCheckEvents()
        {
            formNum0.CheckedChanged += formNum0_CheckedChanged;
            formNum1.CheckedChanged += formNum1_CheckedChanged;
            formNum2.CheckedChanged += formNum2_CheckedChanged;
            formNum3.CheckedChanged += formNum3_CheckedChanged;
            formNum4.CheckedChanged += formNum4_CheckedChanged;
            formNum5.CheckedChanged += formNum5_CheckedChanged;
            formNum6.CheckedChanged += formNum6_CheckedChanged;
            formNum7.CheckedChanged += formNum7_CheckedChanged;
        }

        private void RemoveCheckEvents()
        {
            formNum0.CheckedChanged -= formNum0_CheckedChanged;
            formNum1.CheckedChanged -= formNum1_CheckedChanged;
            formNum2.CheckedChanged -= formNum2_CheckedChanged;
            formNum3.CheckedChanged -= formNum3_CheckedChanged;
            formNum4.CheckedChanged -= formNum4_CheckedChanged;
            formNum5.CheckedChanged -= formNum5_CheckedChanged;
            formNum6.CheckedChanged -= formNum6_CheckedChanged;
            formNum7.CheckedChanged -= formNum7_CheckedChanged;
        }

        private void SetFormations()
        {
            formNum0.Text = Formations.GetFormation((int)groupNum.Value, 0);
            formNum1.Text = Formations.GetFormation((int)groupNum.Value, 1);
            formNum2.Text = Formations.GetFormation((int)groupNum.Value, 2);
            formNum3.Text = Formations.GetFormation((int)groupNum.Value, 3);
            formNum4.Text = Formations.GetFormation((int)groupNum.Value, 4);
            formNum5.Text = Formations.GetFormation((int)groupNum.Value, 5);
            formNum6.Text = Formations.GetFormation((int)groupNum.Value, 6);
            formNum7.Text = Formations.GetFormation((int)groupNum.Value, 7);

            formNum0.Checked = formationData.FormationOnVeldt[(int)groupNum.Value * 8];
            formNum1.Checked = formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 1];
            formNum2.Checked = formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 2];
            formNum3.Checked = formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 3];
            formNum4.Checked = formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 4];
            formNum5.Checked = formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 5];
            formNum6.Checked = formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 6];
            formNum7.Checked = formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 7];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formationData = FormationData.Load();
            resetting.Checked = formationData.Resetting;
            RemoveCheckEvents();
            SetFormations();
            AddCheckEvents();
            SetHistoryFormations();
            groupNum.Value = formationData.SelectedGroupNum;
            LoadEnemies();

            /* Test RNG code
            history.Add(6 * 8 + 2);
            history.Add(20 * 8 + 4);
            history.Add(34 * 8 + 5);
            history.Add(50 * 8 + 4);
            history.Add(0 * 8 + 2);
            history.Add(12 * 8 + 4);

            historyGroup.Value = 26;
            historyFormation.SelectedIndex = 2;
            enemiesList.SelectedIndex = 38;
            //*/
        }

        private void LoadEnemies()
        {
            enemiesList.Items.Clear();

            foreach (var enemy in Formations.allEnemies)
            {
                enemiesList.Items.Add(enemy);
            }
            enemiesList.SelectedIndex = 0;
        }

        private void formNum0_CheckedChanged(object sender, EventArgs e)
        {
            formationData.FormationOnVeldt[(int)groupNum.Value * 8] = formNum0.Checked;
            FormationData.Save(formationData);
        }

        private void formNum1_CheckedChanged(object sender, EventArgs e)
        {
            formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 1] = formNum1.Checked;
            FormationData.Save(formationData);
        }

        private void formNum2_CheckedChanged(object sender, EventArgs e)
        {
            formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 2] = formNum2.Checked;
            FormationData.Save(formationData);
        }

        private void formNum3_CheckedChanged(object sender, EventArgs e)
        {
            formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 3] = formNum3.Checked;
            FormationData.Save(formationData);
        }

        private void formNum4_CheckedChanged(object sender, EventArgs e)
        {
            formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 4] = formNum4.Checked;
            FormationData.Save(formationData);
        }

        private void formNum5_CheckedChanged(object sender, EventArgs e)
        {
            formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 5] = formNum5.Checked;
            FormationData.Save(formationData);
        }

        private void formNum6_CheckedChanged(object sender, EventArgs e)
        {
            formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 6] = formNum6.Checked;
            FormationData.Save(formationData);
        }

        private void formNum7_CheckedChanged(object sender, EventArgs e)
        {
            formationData.FormationOnVeldt[(int)groupNum.Value * 8 + 7] = formNum7.Checked;
            FormationData.Save(formationData);
        }

        private void historyGroup_ValueChanged(object sender, EventArgs e)
        {
            if (historyGroup.Value == -1)
            {
                historyGroup.Value = 63;
            }
            else if (historyGroup.Value == 64)
            {
                historyGroup.Value = 0;
            }
            else
            {
                SetHistoryFormations();
            }
        }

        private void SetHistoryFormations()
        {
            historyFormation.Items.Clear();
            historyFormation.Items.Add(Formations.GetFormation((int)historyGroup.Value, 0));
            historyFormation.Items.Add(Formations.GetFormation((int)historyGroup.Value, 1));
            historyFormation.Items.Add(Formations.GetFormation((int)historyGroup.Value, 2));
            historyFormation.Items.Add(Formations.GetFormation((int)historyGroup.Value, 3));
            historyFormation.Items.Add(Formations.GetFormation((int)historyGroup.Value, 4));
            historyFormation.Items.Add(Formations.GetFormation((int)historyGroup.Value, 5));
            historyFormation.Items.Add(Formations.GetFormation((int)historyGroup.Value, 6));
            historyFormation.Items.Add(Formations.GetFormation((int)historyGroup.Value, 7));
            historyFormation.SelectedIndex = 0;
        }

        private void historyAdd_Click(object sender, EventArgs e)
        {
            var addedFormation = (int)historyGroup.Value * 8 + historyFormation.SelectedIndex;
            history.Add(addedFormation);
            RefreshHistory();
            formationData.FormationOnVeldt[addedFormation] = true;
            RemoveCheckEvents();
            SetFormations();
            AddCheckEvents();
            FormationData.Save(formationData);
            SetNextAvailableFormation();

            FindNextGroups();
        }

        private void SetNextAvailableFormation()
        {
            if (!resetGroupFound)
            {
                var previousGroup = (512 + ((int)historyGroup.Value - 1) * 8) % 512;

                while (!formationData.FormationOnVeldt[previousGroup])
                    previousGroup = (previousGroup + 1) % 512;
                previousGroup /= 8;
                if (previousGroup != historyGroup.Value)
                {
                    resetGroup = (int)historyGroup.Value;
                    resetGroupFound = true;
                }
            }


            var nextAvailableFormation = (((int)historyGroup.Value + 1) * 8) % 512;
            if (formationData.Resetting && resetGroupFound)
            {
                nextAvailableFormation = ((resetGroup + 14) * 8) % 512;
                resetGroup = (resetGroup + 14) % 64;
            }

            while (!formationData.FormationOnVeldt[nextAvailableFormation])
                nextAvailableFormation = (nextAvailableFormation + 1) % 512;
            historyGroup.Value = nextAvailableFormation / 8;
            historyFormation.SelectedIndex = nextAvailableFormation % 8;
        }

        private void FindNextGroups()
        {
            matches = 0;
            var matchSeed1 = 0;
            var matchSeed2 = 0;

            for (int i = 0; i < 256; i++)
            {
                var seed1 = i;
                int seed2 = i;

                var found = true;

                foreach (int t in history)
                {
                    resetSeed1 = seed1;
                    resetSeed2 = seed2;
                    var num = RNG.GetFormNumber(ref seed1, ref seed2);

                    if (formationData.Resetting)
                    {
                        seed1 = (resetSeed1 + 14) % 256;
                        seed2 = (resetSeed2 + 14) % 256;
                    }

                    while (!formationData.FormationOnVeldt[(t / 8) * 8 + num])
                    {
                        num = (num + 1) % 8;
                    }

                    if (t % 8 != num)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    matches++;
                    matchSeed1 = seed1;
                    matchSeed2 = seed2;
                    if (formationData.Resetting)
                    {
                        matchSeed1 -= 13;
                        matchSeed2 -= 14;
                    }
                }
            }

            lblMatches.Text = string.Format("Matches: {0}", matches);

            if (matches == 1)
            {
                startSeed1 = matchSeed1;
                lblStartSeed1.Text = string.Format("Start Seed1: {0}", startSeed1);
                startSeed2 = matchSeed2;
                lblStartSeed2.Text = string.Format("Start Seed2: {0}", startSeed2);
                if (formationData.Resetting)
                {
                    resetSeed1 = matchSeed1 - 1;
                    resetSeed2 = matchSeed2;
                }
                startGroup = history[history.Count - 1] / 8;

                var s1 = startSeed1;
                var s2 = startSeed2;
                var g = startGroup;
                nextFormations.Clear();

                for (int i = 0; i < 10; i++)
                {
                    var num = RNG.GetFormNumber(ref s1, ref s2);
                    AddNextBattle(ref g, num);
                }

                RefreshNextFormations();
                FindSelectedEnemy();
            }
        }

        private void FindSelectedEnemy()
        {
            findFormations = new List<int>();

            for (int i = 0; i < Formations.allForms.Length; i++)
            {
                if (Formations.allForms[i].Contains(enemiesList.Items[enemiesList.SelectedIndex].ToString()))
                {
                    findFormations.Add(i);
                }
            }

            for (int i = findFormations.Count - 1; i > -1; i--)
            {
                if (!formationData.FormationOnVeldt[findFormations[i]])
                    findFormations.RemoveAt(i);
            }

            if (findFormations.Count == 0)
            {
                lblFindMethod.Text = "Cannot find selected enemy in visible formations!";
            }
            else
            {
                var output = new StringBuilder();

                foreach (var findFormation in findFormations)
                {
                    output.AppendLine(FindFormation(findFormation));
                    if (formationData.Resetting)
                        output.AppendLine(FindFormationWithResets(findFormation));
                }

                lblFindMethod.Text = output.ToString();
            }
        }

        private string FindFormationWithResets(int findFormation)
        {
            int num = 0;
            var resets = 0;
            int fights;
            int g;
            var output = new StringBuilder();

            do
            {
                if (resets % 14 == 0)
                    output.AppendLine();
                var s1 = resetSeed1;
                var s2 = resetSeed2;
                g = (resetGroup + 50) % 64;

                s1 = (s1 + resets) % 256;
                s2 = (s2 + resets) % 256;
                g = (g + resets) % 64;

                if (resets == 0)
                {
                    RNG.GetFormNumber(ref s1, ref s2);
                    g = startGroup;
                }
                else
                    g = (g + 63) % 64;

                if (resets % 14 == 0)
                    output.AppendFormat("Reset {0}: ", resets / 14);

                fights = 0;

                for (int i = 0; i < 13; i++)
                {
                    num = RNG.GetFormNumber(ref s1, ref s2);
                    var groupEmpty = true;
                    do
                    {
                        g = (g + 1) % 64;

                        for (int j = 0; j < 8; j++)
                        {
                            if (formationData.FormationOnVeldt[g * 8 + j])
                                groupEmpty = false;
                        }
                    } while (groupEmpty);
                    fights++;
                    while (!formationData.FormationOnVeldt[g * 8 + num])
                    {
                        num = (num + 1) % 8;
                    }
                    if (resets % 14 == 0)
                        output.AppendFormat("{0}-{1} ", g, num);
                    if (g * 8 + num == findFormation)
                    {
                        break;
                    }

                }
                if (resets == 0)
                    resets += 13;
                resets++;
                if (resets % 14 == 0)
                    output.AppendLine();
            } while (g * 8 + num != findFormation);

            //lblResets.Text = output.ToString();
            if (resets == 14)
                resets -= 13;
            resets--;

            return string.Format("Resets at load screen: {0} Resets after load (includes current reset): {1} Fights on veldt: {2}", resets % 14, resets / 14, fights);
        }

        private string FindFormation(int findFormation)
        {
            int num;
            var add = 0;
            int f;

            do
            {
                var s1 = startSeed1;
                var s2 = startSeed2;
                var g = startGroup;

                for (int i = 0; i < add; i++)
                {
                    RNG.GetFormNumber(ref s1, ref s2);
                }

                f = 0;

                do
                {
                    num = RNG.GetFormNumber(ref s1, ref s2);
                    var groupEmpty = true;
                    do
                    {
                        g = (g + 1) % 64;

                        for (int i = 0; i < 8; i++)
                        {
                            if (formationData.FormationOnVeldt[g * 8 + i])
                                groupEmpty = false;
                        }
                    } while (groupEmpty);
                    f++;
                } while (g != findFormation / 8);
                add++;

                while (!formationData.FormationOnVeldt[g * 8 + num])
                {
                    num = (num + 1) % 8;
                }
            } while (num != findFormation % 8);

            add--;

            return string.Format("Fights off veldt: {0} Fights on veldt: {1}", add, f);
        }

        private void RefreshNextFormations()
        {
            nextFormationsList.Items.Clear();
            foreach (var futureItem in nextFormations)
            {
                nextFormationsList.Items.Add(new ListViewItem(new[] { (futureItem / 8).ToString(), (futureItem % 8).ToString(), Formations.GetFormation(futureItem / 8, futureItem % 8) }));
            }
        }

        private void AddNextBattle(ref int group, int num)
        {
            var found = false;
            do
            {
                group = (group + 1) % 64;
                for (int i = 0; i < 8; i++)
                {
                    if (formationData.FormationOnVeldt[group * 8 + i])
                        found = true;
                }

            } while (!found);

            while (!formationData.FormationOnVeldt[group * 8 + num])
            {
                num = (num + 1) % 8;
            }

            nextFormations.Add(group * 8 + num);
        }

        private void RefreshHistory()
        {
            historyList.Items.Clear();
            foreach (var historyItem in history)
            {
                historyList.Items.Add(new ListViewItem(new[] { (historyItem / 8).ToString(), (historyItem % 8).ToString(), Formations.GetFormation(historyItem / 8, historyItem % 8) }));
            }
        }

        private void historyClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            history.Clear();
            nextFormations.Clear();
            lblStartSeed1.Text = "Start Seed1:";
            lblStartSeed2.Text = "Start Seed2:";
            lblFindMethod.Text = "";
            matches = 0;
            resetGroupFound = false;
            RefreshHistory();
            RefreshNextFormations();
        }

        private void addTopGroup_Click(object sender, EventArgs e)
        {
            if (nextFormations.Count > 0)
            {
                history.Add(nextFormations[0]);
                RefreshHistory();
                SetNextAvailableFormation();

                FindNextGroups();
            }
        }

        private void enemiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matches == 1)
            {
                FindSelectedEnemy();
            }
            FindPossibleGroups();
        }

        private void FindPossibleGroups()
        {
            var possibleGroups = new List<int>();
            for (int i = 0; i < 512; i++)
            {
                if (Formations.allForms[i].Contains(enemiesList.Items[enemiesList.SelectedIndex].ToString()))
                    if (!possibleGroups.Contains(i / 8))
                        possibleGroups.Add(i / 8);
            }

            var output = new StringBuilder();
            output.Append("Possible groups: ");
            foreach (var possibleGroup in possibleGroups)
            {
                output.AppendFormat("{0}, ", possibleGroup);
            }
            output.Remove(output.Length - 2, 2);

            lblPossibleGroups.Text = output.ToString();
        }

        private void lastClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (history.Count > 0)
            {
                history.RemoveAt(history.Count - 1);
                nextFormations.Clear();
                lblStartSeed1.Text = "Start Seed1:";
                lblStartSeed2.Text = "Start Seed2:";
                lblFindMethod.Text = "";
                matches = 0;
                if (history.Count == 0)
                    resetGroupFound = false;
                if (resetGroupFound)
                    resetGroup = (resetGroup + 50) % 64;
                RefreshHistory();
                RefreshNextFormations();
                FindNextGroups();
            }
        }

        private void resetting_CheckedChanged(object sender, EventArgs e)
        {
            formationData.Resetting = resetting.Checked;
            FormationData.Save(formationData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This program can determine your seed either from resetting and encountering battles on the veldt, or just from encountering battles. 

To start, just run through the veldt for a while until the program has an idea of what's on your veldt. Usually this will take a couple of passes to get a reasonable amount of info. If you add to the history an encounter that isn't known to be present, RageFinder will add it to the list of known encounters automatically.

Start the history by marking down your  first encounter from reset. Continue adding entries until the ""Matches"" in the bottom right changes to 0.

If you don't know what group your current fight is in, select a monster from the group in ""Search for Rage"" and the groups that monster is in will be listed.", "Instructions", MessageBoxButtons.OK);
        }
    }
}
