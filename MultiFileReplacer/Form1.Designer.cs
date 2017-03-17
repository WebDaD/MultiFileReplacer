namespace MultiFileReplacer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_machine = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_replace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_machine = new System.Windows.Forms.RadioButton();
            this.rb_replace = new System.Windows.Forms.RadioButton();
            this.ck_update = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_work = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.table_files = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addEntry = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tt_rechnername = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.MinimumSize = new System.Drawing.Size(250, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einstellungen";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_machine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_search, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_replace, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ck_update, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "Aktualisiere Dateien";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt_rechnername.SetToolTip(this.label6, "Den Pfad rechts mit dem neuen Dateinamen ersetzen?");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechnername";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tt_rechnername.SetToolTip(this.label1, "Der Rechnername, automatisch ermittelt");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suchen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tt_rechnername.SetToolTip(this.label2, "Der String, nach dem Gesucht wird\r\n");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ersetzen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tt_rechnername.SetToolTip(this.label3, "\r\nDer String, der ersetzen soll");
            // 
            // txt_machine
            // 
            this.txt_machine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_machine.Enabled = false;
            this.txt_machine.Location = new System.Drawing.Point(133, 3);
            this.txt_machine.Name = "txt_machine";
            this.txt_machine.Size = new System.Drawing.Size(125, 20);
            this.txt_machine.TabIndex = 3;
            this.txt_machine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tt_rechnername.SetToolTip(this.txt_machine, "Der Rechnername, automatisch ermittelt");
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(133, 51);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(125, 20);
            this.txt_search.TabIndex = 4;
            this.tt_rechnername.SetToolTip(this.txt_search, "Der String, nach dem gesucht wird\r\n");
            // 
            // txt_replace
            // 
            this.txt_replace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_replace.Location = new System.Drawing.Point(133, 99);
            this.txt_replace.Name = "txt_replace";
            this.txt_replace.Size = new System.Drawing.Size(125, 20);
            this.txt_replace.TabIndex = 5;
            this.tt_rechnername.SetToolTip(this.txt_replace, "Der String, der ersetzen soll");
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nutze ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt_rechnername.SetToolTip(this.label4, "Soll der Rechnername oder der Ersetzen-Text verwendet werden?\r\n");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rb_machine, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb_replace, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(133, 147);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(125, 42);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // rb_machine
            // 
            this.rb_machine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_machine.AutoSize = true;
            this.rb_machine.Location = new System.Drawing.Point(3, 3);
            this.rb_machine.Name = "rb_machine";
            this.rb_machine.Size = new System.Drawing.Size(119, 15);
            this.rb_machine.TabIndex = 0;
            this.rb_machine.TabStop = true;
            this.rb_machine.Text = "Rechnername";
            this.tt_rechnername.SetToolTip(this.rb_machine, "Ersetze den Such-String mit dem Rechnernamen\r\n");
            this.rb_machine.UseVisualStyleBackColor = true;
            // 
            // rb_replace
            // 
            this.rb_replace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_replace.AutoSize = true;
            this.rb_replace.Location = new System.Drawing.Point(3, 24);
            this.rb_replace.Name = "rb_replace";
            this.rb_replace.Size = new System.Drawing.Size(119, 15);
            this.rb_replace.TabIndex = 1;
            this.rb_replace.TabStop = true;
            this.rb_replace.Text = "Ersetzen";
            this.tt_rechnername.SetToolTip(this.rb_replace, "Ersetze den Such-String mit dem Ersetzen-String\r\n");
            this.rb_replace.UseVisualStyleBackColor = true;
            // 
            // ck_update
            // 
            this.ck_update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ck_update.AutoSize = true;
            this.ck_update.Location = new System.Drawing.Point(133, 195);
            this.ck_update.Name = "ck_update";
            this.ck_update.Size = new System.Drawing.Size(125, 44);
            this.ck_update.TabIndex = 9;
            this.tt_rechnername.SetToolTip(this.ck_update, "Den Pfad rechts mit dem neuen Dateinamen ersetzen?");
            this.ck_update.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table_files);
            this.splitContainer1.Panel2.Controls.Add(this.btn_addEntry);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(976, 553);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_work);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Location = new System.Drawing.Point(13, 277);
            this.groupBox2.MinimumSize = new System.Drawing.Size(250, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 264);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrollen";
            // 
            // btn_work
            // 
            this.btn_work.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_work.Location = new System.Drawing.Point(7, 83);
            this.btn_work.Name = "btn_work";
            this.btn_work.Size = new System.Drawing.Size(248, 175);
            this.btn_work.TabIndex = 3;
            this.btn_work.Text = "Arbeite!";
            this.tt_rechnername.SetToolTip(this.btn_work, "Suchen und ersetzen");
            this.btn_work.UseVisualStyleBackColor = true;
            this.btn_work.Click += new System.EventHandler(this.btn_work_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(6, 19);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(249, 58);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Speichern";
            this.tt_rechnername.SetToolTip(this.btn_save, "Alle Einstellungen speichern");
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // table_files
            // 
            this.table_files.AllowDrop = true;
            this.table_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.table_files.AutoScroll = true;
            this.table_files.ColumnCount = 5;
            this.table_files.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_files.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.table_files.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_files.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.table_files.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.table_files.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.table_files.Location = new System.Drawing.Point(8, 27);
            this.table_files.Name = "table_files";
            this.table_files.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.table_files.RowCount = 1;
            this.table_files.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_files.Size = new System.Drawing.Size(672, 514);
            this.table_files.TabIndex = 3;
            this.table_files.DragDrop += new System.Windows.Forms.DragEventHandler(this.table_files_DragDrop);
            this.table_files.DragEnter += new System.Windows.Forms.DragEventHandler(this.table_files_DragEnter);
            // 
            // btn_addEntry
            // 
            this.btn_addEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addEntry.Location = new System.Drawing.Point(557, 3);
            this.btn_addEntry.Name = "btn_addEntry";
            this.btn_addEntry.Size = new System.Drawing.Size(123, 23);
            this.btn_addEntry.TabIndex = 2;
            this.btn_addEntry.Text = "Neue Datei";
            this.tt_rechnername.SetToolTip(this.btn_addEntry, "Füge eine neue Datei hinzu.");
            this.btn_addEntry.UseVisualStyleBackColor = true;
            this.btn_addEntry.Click += new System.EventHandler(this.btn_addEntry_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dateien";
            this.tt_rechnername.SetToolTip(this.label5, "Die Dateien, die durchsucht werden.");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "par";
            this.openFileDialog.ReadOnlyChecked = true;
            // 
            // tt_rechnername
            // 
            this.tt_rechnername.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_rechnername.ToolTipTitle = "Hinweis";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 553);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 420);
            this.Name = "Form1";
            this.Text = "MultiFileReplacer by Dominik Sigmund 2014";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_machine;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_replace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rb_machine;
        private System.Windows.Forms.RadioButton rb_replace;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_work;
        private System.Windows.Forms.Button btn_addEntry;
        private System.Windows.Forms.TableLayoutPanel table_files;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ck_update;
        private System.Windows.Forms.ToolTip tt_rechnername;
    }
}

