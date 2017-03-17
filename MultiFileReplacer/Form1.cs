using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultiFileReplacer.Properties;
using System.IO;

namespace MultiFileReplacer
{
    public partial class Form1 : Form
    {
        int files = 0;
        Config conf;
        struct HoldingCell
        {
            public Control cntrl;
            public TableLayoutPanelCellPosition pos;
        }

        public Form1()
        {
            

            conf = new Config(Application.StartupPath + "\\" + "config.ini");
            InitializeComponent();
 
            txt_machine.Text = Environment.MachineName;
            txt_search.Text = conf.Search;
            txt_replace.Text = conf.Replace;
            ck_update.Checked = conf.Update;
            if (conf.UseMachine)
            {
                rb_machine.Checked = true;
                rb_replace.Checked = false;
            }
            else
            {
                rb_machine.Checked = false;
                rb_replace.Checked = true;
            }
            if (conf.Files.Count > 0)
            {
                int i = 0;
                foreach (KeyValuePair<string,bool> item in conf.Files)
                {
                    if (i != 0) table_files.RowCount++;
                    addEntry(table_files, item.Key, item.Value, i);
                    i++;
                }
                files = i;
            }
            this.Text += " v"+System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void btn_work_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("Suche darf nicht leer sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rb_machine.Checked && txt_replace.Text == "")
            {
                MessageBox.Show("Ersetzung darf nicht leer sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string search = txt_search.Text;
            string replace="";
            if(rb_machine.Checked){
                replace = txt_machine.Text;
            } else {
                replace = txt_replace.Text;
            }
            for (int i = 0; i < files; i++)
            {
                TextBox t = (TextBox)table_files.Controls.Find("txt_" + i.ToString(), true).FirstOrDefault();
                ProgressBar p = (ProgressBar)table_files.Controls.Find("pb_" + i.ToString(), true).FirstOrDefault();
                CheckBox c = (CheckBox)table_files.Controls.Find("ck_" + i.ToString(), true).FirstOrDefault();

                string file = t.Text;

                string new_file = Worker.searchReplace(file, search, replace,c.Checked, p);

                if(ck_update.Checked)t.Text = new_file;
            }
            MessageBox.Show("Ersetzungen erledigt!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_addEntry_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                if (files != 0)
                {
                    table_files.RowCount++;
                }
                addEntry(table_files, path,false, files);
                files++;
            }
        }

        private void addEntry(TableLayoutPanel table_files, string path,bool check,  int file)
        {
            Label l = new Label();
            l.Text = "Datei_"+file.ToString();
            l.Dock = DockStyle.Top;

            TextBox t = new TextBox();
            t.Text = path;
            t.Name = "txt_" + file.ToString();
            t.Dock = DockStyle.Top;
            //t.Width = table_files.col

            Button b = new Button();
            b.Name = "btn_" + file.ToString();
            b.Text = "...";
            b.Click += new EventHandler(b_Click);
            b.Dock = DockStyle.Top;
            //b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));

            ProgressBar p = new ProgressBar();
            p.Name = "pb_" + file.ToString();
            p.Dock = DockStyle.Top;
            //p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));

            CheckBox c = new CheckBox();
            c.Name = "ck_" + file.ToString();
            c.Checked = check;
            c.Dock = DockStyle.Top;
            c.Text = "DE?";

            ToolTip tt = new ToolTip();
            tt.ToolTipIcon = ToolTipIcon.Info;
            tt.ToolTipTitle = "Hinweise";
            tt.SetToolTip(c,"Soll der Dateiname auch nach dem String durchsucht und ersetzt werden?");
            
            table_files.Controls.Add(l, 0, file);
            table_files.Controls.Add(t, 1, file);
            table_files.Controls.Add(b, 2, file);
            table_files.Controls.Add(p, 3, file);
            table_files.Controls.Add(c, 4, file);
        }

        void b2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string id = b.Name.Split('_')[1];

            Control c = default(Control);

            List<HoldingCell> tempHolding = new List<HoldingCell>();
            HoldingCell cell = default(HoldingCell);
            Int32 deleteIndex = Convert.ToInt32(id);

            var _with1 = table_files;
            //Delete all controls on selected row
            for (Int32 col = 0; col <= _with1.ColumnCount - 1; col++) {
	            c = _with1.GetControlFromPosition(column: col, row: deleteIndex);
	            if (c != null) {
		            _with1.Controls.RemoveByKey(c.Name);
		            //remove it from the controls collection
		            c.Dispose();
		            //get rid of it
	            }
            }

            //Temporarly Store the Positions
            for (Int32 row = deleteIndex + 1; row <= table_files.RowCount - 1; row++) {
	            for (Int32 col = 0; col <= table_files.ColumnCount - 1; col++) {
		            cell = new HoldingCell();
		            cell.cntrl = _with1.GetControlFromPosition(col, row);
		            //setup position for restore = current row -1
		            cell.pos = new TableLayoutPanelCellPosition(col, row - 1);
		            tempHolding.Add(cell);
	            }
            }

            //delete the row
            _with1.RowStyles.RemoveAt(index: deleteIndex);
            //deletes the style only
            _with1.RowCount -= 1;

            //adjust control positions
            foreach ( HoldingCell cell2 in tempHolding) {
	            if (cell2.cntrl != null) {
		            _with1.SetCellPosition(cell2.cntrl, cell2.pos);
	            }
            }
            tempHolding = null;
            
        }

        void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string id = b.Name.Split('_')[1];
            TextBox t = (TextBox)table_files.Controls.Find("txt_" + id, true)[0];

            openFileDialog.FileName = t.Text;
            DialogResult d = openFileDialog.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                t.Text = openFileDialog.FileName;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conf.Replace != txt_replace.Text
                || conf.Search != txt_search.Text
                || conf.UseMachine != rb_machine.Checked
                || conf.Update != ck_update.Checked
                || comparePaths(conf.Files, table_files))
            {
                DialogResult d = MessageBox.Show("Wollen sie die Einstellungen speichern?", "Frage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (d)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                    case DialogResult.No:
                        return;
                    case DialogResult.Yes:
                        saveSettings();
                        return;
                }
            }
        }

        private bool comparePaths(Dictionary<string,bool> conf_files, TableLayoutPanel table_files)
        {
            if (files>0)
            {
                Dictionary<string, bool> myFiles = new Dictionary<string,bool>();
                for (int i = 0; i < files; i++)
                {
                    TextBox t = (TextBox)table_files.Controls.Find("txt_" + i.ToString(), true).FirstOrDefault();
                    CheckBox c = (CheckBox)table_files.Controls.Find("ck_" + i.ToString(), true).FirstOrDefault();
                    myFiles.Add(t.Text, c.Checked);
                }
                bool result = conf_files.SequenceEqual(myFiles);
                if (!result) return true;
                else return false;
            }
            else return true;
        }

        private void saveSettings()
        {
            try
            {
                conf.Search = txt_search.Text;
                conf.Replace = txt_replace.Text;
                conf.UseMachine = rb_machine.Checked;
                conf.Update = ck_update.Checked;
               
                if (files > 0)
                {
                    conf.Files.Clear();
                    for (int i = 0; i < files; i++)
                    {
                        TextBox t = (TextBox)table_files.Controls.Find("txt_"+i.ToString(), true).FirstOrDefault();
                        CheckBox c = (CheckBox)table_files.Controls.Find("ck_" + i.ToString(), true).FirstOrDefault();
                       conf.Files.Add(t.Text, c.Checked);
                    }
                }
                conf.Save();
            }
            catch (Exception e)
            {
                if (MessageBox.Show("Fehler beim Speichern:\n" + e.Message, "Fehler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Retry)
                {
                    saveSettings();
                }
                return;
            }
            MessageBox.Show("Daten erfolgreich gespeichert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void table_files_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void table_files_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string item in FileList)
            {
                string path = item;
                if (files != 0)
                {
                    table_files.RowCount++;
                }
                addEntry(table_files, path,false, files);
                files++;
            }
        }
    }
}
