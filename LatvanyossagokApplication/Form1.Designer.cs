namespace LatvanyossagokApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.varosok_lista = new System.Windows.Forms.ListBox();
            this.varosok_group = new System.Windows.Forms.GroupBox();
            this.varos_menu_modosit = new System.Windows.Forms.Button();
            this.varos_menu_hozzaad = new System.Windows.Forms.Button();
            this.latvanyossagok_lista = new System.Windows.Forms.ListBox();
            this.latvanyossagok_group = new System.Windows.Forms.GroupBox();
            this.latvanyossag_menu_modosit = new System.Windows.Forms.Button();
            this.latvanyossag_menu_hozzaad = new System.Windows.Forms.Button();
            this.varos_hozzaad_group = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.varos_lakossag = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.varos_nev = new System.Windows.Forms.TextBox();
            this.varos_megsem = new System.Windows.Forms.Button();
            this.varos_modosit = new System.Windows.Forms.Button();
            this.varos_hozzaad = new System.Windows.Forms.Button();
            this.latvanyossag_hozzaad_group = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.latvanyossag_belepo = new System.Windows.Forms.NumericUpDown();
            this.latvanyossag_leiras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.latvanyossag_nev = new System.Windows.Forms.TextBox();
            this.latvanyossag_megsem = new System.Windows.Forms.Button();
            this.latvanyossag_modosit = new System.Windows.Forms.Button();
            this.latvanyossag_hozzaad = new System.Windows.Forms.Button();
            this.latvanyossag_torol = new System.Windows.Forms.Button();
            this.varos_torol = new System.Windows.Forms.Button();
            this.varosok_group.SuspendLayout();
            this.latvanyossagok_group.SuspendLayout();
            this.varos_hozzaad_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varos_lakossag)).BeginInit();
            this.latvanyossag_hozzaad_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossag_belepo)).BeginInit();
            this.SuspendLayout();
            // 
            // varosok_lista
            // 
            this.varosok_lista.FormattingEnabled = true;
            this.varosok_lista.Location = new System.Drawing.Point(13, 19);
            this.varosok_lista.Name = "varosok_lista";
            this.varosok_lista.Size = new System.Drawing.Size(322, 238);
            this.varosok_lista.TabIndex = 0;
            this.varosok_lista.SelectedIndexChanged += new System.EventHandler(this.varosok_lista_SelectedIndexChanged);
            // 
            // varosok_group
            // 
            this.varosok_group.Controls.Add(this.varos_torol);
            this.varosok_group.Controls.Add(this.varos_menu_modosit);
            this.varosok_group.Controls.Add(this.varos_menu_hozzaad);
            this.varosok_group.Controls.Add(this.varosok_lista);
            this.varosok_group.Location = new System.Drawing.Point(12, 7);
            this.varosok_group.Name = "varosok_group";
            this.varosok_group.Size = new System.Drawing.Size(350, 295);
            this.varosok_group.TabIndex = 1;
            this.varosok_group.TabStop = false;
            this.varosok_group.Text = "Városok";
            // 
            // varos_menu_modosit
            // 
            this.varos_menu_modosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varos_menu_modosit.Location = new System.Drawing.Point(85, 263);
            this.varos_menu_modosit.Name = "varos_menu_modosit";
            this.varos_menu_modosit.Size = new System.Drawing.Size(57, 21);
            this.varos_menu_modosit.TabIndex = 2;
            this.varos_menu_modosit.Text = "Módosít";
            this.varos_menu_modosit.UseVisualStyleBackColor = true;
            this.varos_menu_modosit.Click += new System.EventHandler(this.varos_menu_modosit_Click);
            // 
            // varos_menu_hozzaad
            // 
            this.varos_menu_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varos_menu_hozzaad.Location = new System.Drawing.Point(13, 263);
            this.varos_menu_hozzaad.Name = "varos_menu_hozzaad";
            this.varos_menu_hozzaad.Size = new System.Drawing.Size(57, 21);
            this.varos_menu_hozzaad.TabIndex = 1;
            this.varos_menu_hozzaad.Text = "Hozzáad";
            this.varos_menu_hozzaad.UseVisualStyleBackColor = true;
            this.varos_menu_hozzaad.Click += new System.EventHandler(this.varos_menu_hozzaad_Click);
            // 
            // latvanyossagok_lista
            // 
            this.latvanyossagok_lista.FormattingEnabled = true;
            this.latvanyossagok_lista.Location = new System.Drawing.Point(13, 19);
            this.latvanyossagok_lista.Name = "latvanyossagok_lista";
            this.latvanyossagok_lista.Size = new System.Drawing.Size(322, 238);
            this.latvanyossagok_lista.TabIndex = 0;
            // 
            // latvanyossagok_group
            // 
            this.latvanyossagok_group.Controls.Add(this.latvanyossag_torol);
            this.latvanyossagok_group.Controls.Add(this.latvanyossag_menu_modosit);
            this.latvanyossagok_group.Controls.Add(this.latvanyossag_menu_hozzaad);
            this.latvanyossagok_group.Controls.Add(this.latvanyossagok_lista);
            this.latvanyossagok_group.Location = new System.Drawing.Point(12, 308);
            this.latvanyossagok_group.Name = "latvanyossagok_group";
            this.latvanyossagok_group.Size = new System.Drawing.Size(350, 295);
            this.latvanyossagok_group.TabIndex = 2;
            this.latvanyossagok_group.TabStop = false;
            this.latvanyossagok_group.Text = "Látványosságok";
            // 
            // latvanyossag_menu_modosit
            // 
            this.latvanyossag_menu_modosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latvanyossag_menu_modosit.Location = new System.Drawing.Point(85, 263);
            this.latvanyossag_menu_modosit.Name = "latvanyossag_menu_modosit";
            this.latvanyossag_menu_modosit.Size = new System.Drawing.Size(57, 21);
            this.latvanyossag_menu_modosit.TabIndex = 6;
            this.latvanyossag_menu_modosit.Text = "Módosít";
            this.latvanyossag_menu_modosit.UseVisualStyleBackColor = true;
            this.latvanyossag_menu_modosit.Click += new System.EventHandler(this.latvanyossag_menu_modosit_Click);
            // 
            // latvanyossag_menu_hozzaad
            // 
            this.latvanyossag_menu_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latvanyossag_menu_hozzaad.Location = new System.Drawing.Point(13, 263);
            this.latvanyossag_menu_hozzaad.Name = "latvanyossag_menu_hozzaad";
            this.latvanyossag_menu_hozzaad.Size = new System.Drawing.Size(57, 21);
            this.latvanyossag_menu_hozzaad.TabIndex = 5;
            this.latvanyossag_menu_hozzaad.Text = "Hozzáad";
            this.latvanyossag_menu_hozzaad.UseVisualStyleBackColor = true;
            this.latvanyossag_menu_hozzaad.Click += new System.EventHandler(this.latvanyossag_menu_hozzaad_Click);
            // 
            // varos_hozzaad_group
            // 
            this.varos_hozzaad_group.Controls.Add(this.label2);
            this.varos_hozzaad_group.Controls.Add(this.varos_lakossag);
            this.varos_hozzaad_group.Controls.Add(this.label1);
            this.varos_hozzaad_group.Controls.Add(this.varos_nev);
            this.varos_hozzaad_group.Controls.Add(this.varos_megsem);
            this.varos_hozzaad_group.Controls.Add(this.varos_modosit);
            this.varos_hozzaad_group.Controls.Add(this.varos_hozzaad);
            this.varos_hozzaad_group.Enabled = false;
            this.varos_hozzaad_group.Location = new System.Drawing.Point(378, 7);
            this.varos_hozzaad_group.Name = "varos_hozzaad_group";
            this.varos_hozzaad_group.Size = new System.Drawing.Size(207, 158);
            this.varos_hozzaad_group.TabIndex = 3;
            this.varos_hozzaad_group.TabStop = false;
            this.varos_hozzaad_group.Text = "Városok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Város lakossága:";
            // 
            // varos_lakossag
            // 
            this.varos_lakossag.Location = new System.Drawing.Point(13, 84);
            this.varos_lakossag.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.varos_lakossag.Name = "varos_lakossag";
            this.varos_lakossag.Size = new System.Drawing.Size(177, 20);
            this.varos_lakossag.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Város neve:";
            // 
            // varos_nev
            // 
            this.varos_nev.Location = new System.Drawing.Point(13, 35);
            this.varos_nev.MaxLength = 25;
            this.varos_nev.Name = "varos_nev";
            this.varos_nev.Size = new System.Drawing.Size(177, 20);
            this.varos_nev.TabIndex = 5;
            // 
            // varos_megsem
            // 
            this.varos_megsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varos_megsem.Location = new System.Drawing.Point(133, 122);
            this.varos_megsem.Name = "varos_megsem";
            this.varos_megsem.Size = new System.Drawing.Size(57, 21);
            this.varos_megsem.TabIndex = 4;
            this.varos_megsem.Text = "Vissza";
            this.varos_megsem.UseVisualStyleBackColor = true;
            this.varos_megsem.Click += new System.EventHandler(this.varos_megsem_Click);
            // 
            // varos_modosit
            // 
            this.varos_modosit.Enabled = false;
            this.varos_modosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varos_modosit.Location = new System.Drawing.Point(73, 122);
            this.varos_modosit.Name = "varos_modosit";
            this.varos_modosit.Size = new System.Drawing.Size(57, 21);
            this.varos_modosit.TabIndex = 2;
            this.varos_modosit.Text = "Módosít";
            this.varos_modosit.UseVisualStyleBackColor = true;
            this.varos_modosit.Click += new System.EventHandler(this.varos_modosit_Click);
            // 
            // varos_hozzaad
            // 
            this.varos_hozzaad.Enabled = false;
            this.varos_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varos_hozzaad.Location = new System.Drawing.Point(13, 122);
            this.varos_hozzaad.Name = "varos_hozzaad";
            this.varos_hozzaad.Size = new System.Drawing.Size(57, 21);
            this.varos_hozzaad.TabIndex = 1;
            this.varos_hozzaad.Text = "Hozzáad";
            this.varos_hozzaad.UseVisualStyleBackColor = true;
            this.varos_hozzaad.Click += new System.EventHandler(this.varos_hozzaad_Click);
            // 
            // latvanyossag_hozzaad_group
            // 
            this.latvanyossag_hozzaad_group.Controls.Add(this.label5);
            this.latvanyossag_hozzaad_group.Controls.Add(this.latvanyossag_belepo);
            this.latvanyossag_hozzaad_group.Controls.Add(this.latvanyossag_leiras);
            this.latvanyossag_hozzaad_group.Controls.Add(this.label3);
            this.latvanyossag_hozzaad_group.Controls.Add(this.label4);
            this.latvanyossag_hozzaad_group.Controls.Add(this.latvanyossag_nev);
            this.latvanyossag_hozzaad_group.Controls.Add(this.latvanyossag_megsem);
            this.latvanyossag_hozzaad_group.Controls.Add(this.latvanyossag_modosit);
            this.latvanyossag_hozzaad_group.Controls.Add(this.latvanyossag_hozzaad);
            this.latvanyossag_hozzaad_group.Enabled = false;
            this.latvanyossag_hozzaad_group.Location = new System.Drawing.Point(378, 308);
            this.latvanyossag_hozzaad_group.Name = "latvanyossag_hozzaad_group";
            this.latvanyossag_hozzaad_group.Size = new System.Drawing.Size(207, 295);
            this.latvanyossag_hozzaad_group.TabIndex = 4;
            this.latvanyossag_hozzaad_group.TabStop = false;
            this.latvanyossag_hozzaad_group.Text = "Látványosságok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Belépő ára:";
            // 
            // latvanyossag_belepo
            // 
            this.latvanyossag_belepo.Location = new System.Drawing.Point(13, 237);
            this.latvanyossag_belepo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.latvanyossag_belepo.Name = "latvanyossag_belepo";
            this.latvanyossag_belepo.Size = new System.Drawing.Size(177, 20);
            this.latvanyossag_belepo.TabIndex = 14;
            // 
            // latvanyossag_leiras
            // 
            this.latvanyossag_leiras.Location = new System.Drawing.Point(13, 84);
            this.latvanyossag_leiras.MaxLength = 1000;
            this.latvanyossag_leiras.Multiline = true;
            this.latvanyossag_leiras.Name = "latvanyossag_leiras";
            this.latvanyossag_leiras.Size = new System.Drawing.Size(177, 124);
            this.latvanyossag_leiras.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Látványosság leírása:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Látványosság neve:";
            // 
            // latvanyossag_nev
            // 
            this.latvanyossag_nev.Location = new System.Drawing.Point(13, 35);
            this.latvanyossag_nev.MaxLength = 100;
            this.latvanyossag_nev.Name = "latvanyossag_nev";
            this.latvanyossag_nev.Size = new System.Drawing.Size(177, 20);
            this.latvanyossag_nev.TabIndex = 10;
            // 
            // latvanyossag_megsem
            // 
            this.latvanyossag_megsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latvanyossag_megsem.Location = new System.Drawing.Point(133, 263);
            this.latvanyossag_megsem.Name = "latvanyossag_megsem";
            this.latvanyossag_megsem.Size = new System.Drawing.Size(57, 21);
            this.latvanyossag_megsem.TabIndex = 7;
            this.latvanyossag_megsem.Text = "Vissza";
            this.latvanyossag_megsem.UseVisualStyleBackColor = true;
            this.latvanyossag_megsem.Click += new System.EventHandler(this.latvanyossag_megsem_Click);
            // 
            // latvanyossag_modosit
            // 
            this.latvanyossag_modosit.Enabled = false;
            this.latvanyossag_modosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latvanyossag_modosit.Location = new System.Drawing.Point(73, 263);
            this.latvanyossag_modosit.Name = "latvanyossag_modosit";
            this.latvanyossag_modosit.Size = new System.Drawing.Size(57, 21);
            this.latvanyossag_modosit.TabIndex = 6;
            this.latvanyossag_modosit.Text = "Módosít";
            this.latvanyossag_modosit.UseVisualStyleBackColor = true;
            this.latvanyossag_modosit.Click += new System.EventHandler(this.latvanyossag_modosit_Click);
            // 
            // latvanyossag_hozzaad
            // 
            this.latvanyossag_hozzaad.Enabled = false;
            this.latvanyossag_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latvanyossag_hozzaad.Location = new System.Drawing.Point(13, 263);
            this.latvanyossag_hozzaad.Name = "latvanyossag_hozzaad";
            this.latvanyossag_hozzaad.Size = new System.Drawing.Size(57, 21);
            this.latvanyossag_hozzaad.TabIndex = 5;
            this.latvanyossag_hozzaad.Text = "Hozzáad";
            this.latvanyossag_hozzaad.UseVisualStyleBackColor = true;
            this.latvanyossag_hozzaad.Click += new System.EventHandler(this.latvanyossag_hozzaad_Click);
            // 
            // latvanyossag_torol
            // 
            this.latvanyossag_torol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latvanyossag_torol.Location = new System.Drawing.Point(278, 263);
            this.latvanyossag_torol.Name = "latvanyossag_torol";
            this.latvanyossag_torol.Size = new System.Drawing.Size(57, 21);
            this.latvanyossag_torol.TabIndex = 8;
            this.latvanyossag_torol.Text = "Töröl";
            this.latvanyossag_torol.UseVisualStyleBackColor = true;
            this.latvanyossag_torol.Click += new System.EventHandler(this.latvanyossag_torol_Click);
            // 
            // varos_torol
            // 
            this.varos_torol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varos_torol.Location = new System.Drawing.Point(278, 263);
            this.varos_torol.Name = "varos_torol";
            this.varos_torol.Size = new System.Drawing.Size(57, 21);
            this.varos_torol.TabIndex = 7;
            this.varos_torol.Text = "Töröl";
            this.varos_torol.UseVisualStyleBackColor = true;
            this.varos_torol.Click += new System.EventHandler(this.varos_torol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 612);
            this.Controls.Add(this.latvanyossag_hozzaad_group);
            this.Controls.Add(this.varos_hozzaad_group);
            this.Controls.Add(this.latvanyossagok_group);
            this.Controls.Add(this.varosok_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Látványosságok";
            this.varosok_group.ResumeLayout(false);
            this.latvanyossagok_group.ResumeLayout(false);
            this.varos_hozzaad_group.ResumeLayout(false);
            this.varos_hozzaad_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varos_lakossag)).EndInit();
            this.latvanyossag_hozzaad_group.ResumeLayout(false);
            this.latvanyossag_hozzaad_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossag_belepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox varosok_lista;
        private System.Windows.Forms.GroupBox varosok_group;
        private System.Windows.Forms.Button varos_menu_modosit;
        private System.Windows.Forms.Button varos_menu_hozzaad;
        private System.Windows.Forms.ListBox latvanyossagok_lista;
        private System.Windows.Forms.GroupBox latvanyossagok_group;
        private System.Windows.Forms.Button latvanyossag_menu_modosit;
        private System.Windows.Forms.Button latvanyossag_menu_hozzaad;
        private System.Windows.Forms.GroupBox varos_hozzaad_group;
        private System.Windows.Forms.Button varos_megsem;
        private System.Windows.Forms.Button varos_modosit;
        private System.Windows.Forms.Button varos_hozzaad;
        private System.Windows.Forms.GroupBox latvanyossag_hozzaad_group;
        private System.Windows.Forms.Button latvanyossag_megsem;
        private System.Windows.Forms.Button latvanyossag_modosit;
        private System.Windows.Forms.Button latvanyossag_hozzaad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox varos_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown varos_lakossag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox latvanyossag_nev;
        private System.Windows.Forms.TextBox latvanyossag_leiras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown latvanyossag_belepo;
        private System.Windows.Forms.Button varos_torol;
        private System.Windows.Forms.Button latvanyossag_torol;
    }
}

