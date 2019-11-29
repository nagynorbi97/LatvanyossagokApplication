using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LatvanyossagokApplication {
    public partial class Form1 : Form {
        private MySqlConnection conn;
        public Form1() {
            InitializeComponent();
            conn = dbHelper.Conn();
            VarosLista();
        }
        private void VarosLista() {
            varosok_lista.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM varosok ORDER BY nev;";
            using (var reader = cmd.ExecuteReader()) {
                while (reader.Read()) {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    var varos = new Varos(id, nev, lakossag);
                    varosok_lista.Items.Add(varos);
                }
            }
        }
        private void LatvanyossagLista(int varos_id) {
            latvanyossagok_lista.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM latvanyossagok WHERE varos_id=@varos_id ORDER BY nev;";
            cmd.Parameters.AddWithValue("@varos_id", varos_id);
            using (var reader = cmd.ExecuteReader()) {
                while (reader.Read()) {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var leiras = reader.GetString("leiras");
                    var ar = reader.GetInt32("ar");
                    var latvanyossag = new Latvanyossag(id, nev, leiras, ar, varos_id);
                    latvanyossagok_lista.Items.Add(latvanyossag);
                }
            }
        }

        private void VarosAdatok(int id) {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM varosok WHERE id=@id;";
            cmd.Parameters.AddWithValue("@id", id);
            using (var reader = cmd.ExecuteReader()) {
                reader.Read();
                varos_nev.Text = reader.GetString("nev");
                varos_lakossag.Value = reader.GetInt32("lakossag");
            }
        }
        private void LatvanyossagAdatok(int id) {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM latvanyossagok WHERE id=@id;";
            cmd.Parameters.AddWithValue("@id", id);
            using (var reader = cmd.ExecuteReader()) {
                reader.Read();
                latvanyossag_nev.Text = reader.GetString("nev");
                latvanyossag_leiras.Text = reader.GetString("leiras");
                latvanyossag_belepo.Value = reader.GetInt32("ar");
            }
        }

        private void varos_menu_hozzaad_Click(object sender, EventArgs e) {
            varosok_group.Enabled = false;
            varos_hozzaad.Enabled = true;
            varos_hozzaad_group.Enabled = true;
        }
        private void latvanyossag_menu_hozzaad_Click(object sender, EventArgs e) {
            if (varosok_lista.SelectedIndex > -1) {
                latvanyossagok_group.Enabled = false;
                latvanyossag_hozzaad.Enabled = true;
                latvanyossag_hozzaad_group.Enabled = true;
            }
        }

        private void varos_hozzaad_Click(object sender, EventArgs e) {
            if (varos_nev.Text.Length > 1 && varos_lakossag.Text.Length > 3) {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO varosok (nev, lakossag) VALUES (@nev, @lakossag)";
                cmd.Parameters.AddWithValue("@nev", varos_nev.Text);
                cmd.Parameters.AddWithValue("@lakossag", varos_lakossag.Value);
                cmd.ExecuteNonQuery();
                varos_nev.Text = "";
                varos_lakossag.Text = "";
                VarosLista();
            }
        }
        private void latvanyossag_hozzaad_Click(object sender, EventArgs e) {
            if (latvanyossag_nev.Text.Length > 5 && latvanyossag_leiras.Text.Length > 3 && varosok_lista.SelectedIndex>-1) {
                var varos = (Varos)varosok_lista.SelectedItem;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO latvanyossagok (nev, leiras, ar, varos_id) VALUES (@nev, @leiras, @ar, @varos_id)";
                cmd.Parameters.AddWithValue("@nev", latvanyossag_nev.Text);
                cmd.Parameters.AddWithValue("@leiras", latvanyossag_leiras.Text);
                cmd.Parameters.AddWithValue("@ar", latvanyossag_belepo.Text);
                cmd.Parameters.AddWithValue("@varos_id", varos.Id);
                cmd.ExecuteNonQuery();
                latvanyossag_nev.Text = "";
                latvanyossag_leiras.Text = "";
                latvanyossag_belepo.Text = "";
                LatvanyossagLista(varos.Id);
            }
        }

        private void varos_modosit_Click(object sender, EventArgs e)
        {
            if (varos_nev.Text.Length > 1 && varos_lakossag.Text.Length > 3)
            {
                var varos = (Varos)varosok_lista.SelectedItem;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE varosok SET nev=@nev, lakossag=@lakossag WHERE id=@id";
                cmd.Parameters.AddWithValue("@nev", varos_nev.Text);
                cmd.Parameters.AddWithValue("@lakossag", varos_lakossag.Value);
                cmd.Parameters.AddWithValue("@id", varos.Id);
                cmd.ExecuteNonQuery();
                varos_nev.Text = "";
                varos_lakossag.Text = "";
                VarosLista();
                varos_megsem.PerformClick();
            }
        }
        private void latvanyossag_modosit_Click(object sender, EventArgs e) {
            if (latvanyossag_nev.Text.Length > 5 && latvanyossag_leiras.Text.Length > 3 && varosok_lista.SelectedIndex > -1) {
                var varos = (Varos)varosok_lista.SelectedItem;
                var latvanyossag = (Latvanyossag)latvanyossagok_lista.SelectedItem;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE latvanyossagok SET nev=@nev, leiras=@leiras, ar=@ar WHERE id=@id";
                cmd.Parameters.AddWithValue("@nev", latvanyossag_nev.Text);
                cmd.Parameters.AddWithValue("@leiras", latvanyossag_leiras.Text);
                cmd.Parameters.AddWithValue("@ar", latvanyossag_belepo.Text);
                cmd.Parameters.AddWithValue("@id", latvanyossag.Id);
                cmd.ExecuteNonQuery();
                latvanyossag_nev.Text = "";
                latvanyossag_leiras.Text = "";
                latvanyossag_belepo.Text = "";
                LatvanyossagLista(varos.Id);
                latvanyossag_megsem.PerformClick();
            }
        }

        private void varos_torol_Click(object sender, EventArgs e)
        {
            if (varosok_lista.SelectedIndex > -1)
            {
                var varos = (Varos)varosok_lista.SelectedItem;
                var chck = conn.CreateCommand();
                chck.CommandText = @"SELECT COUNT(id) FROM latvanyossagok WHERE varos_id=@varos_id";
                chck.Parameters.AddWithValue("@varos_id", varos.Id);
                long latvanyossag_db = (long)chck.ExecuteScalar();
                if (latvanyossag_db < 1)
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM varosok WHERE id=@id;";
                    cmd.Parameters.AddWithValue("@id", varos.Id);
                    cmd.ExecuteNonQuery();
                    VarosLista();
                }
                else
                {
                    MessageBox.Show("A kiválasztott városnak még van rögzített látnivalója.", "Hiba");
                }
            }
        }
        private void latvanyossag_torol_Click(object sender, EventArgs e) {
            if (varosok_lista.SelectedIndex > -1 && latvanyossagok_lista.SelectedIndex > -1) {
                var varos = (Varos)varosok_lista.SelectedItem;
                var latvanyossag = (Latvanyossag)latvanyossagok_lista.SelectedItem;
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM latvanyossagok WHERE id=@id;";
                cmd.Parameters.AddWithValue("@id", latvanyossag.Id);
                cmd.ExecuteNonQuery();
                LatvanyossagLista(varos.Id);
            }
        }

        private void varos_menu_modosit_Click(object sender, EventArgs e) {
            if (varosok_lista.SelectedIndex > -1) {
                varosok_group.Enabled = false;
                varos_modosit.Enabled = true;
                varos_hozzaad_group.Enabled = true;
                var varos = (Varos)varosok_lista.SelectedItem;
                VarosAdatok(varos.Id);
            }
        }
        private void latvanyossag_menu_modosit_Click(object sender, EventArgs e) {
            if (latvanyossagok_lista.SelectedIndex > -1) {
                latvanyossagok_group.Enabled = false;
                latvanyossag_modosit.Enabled = true;
                latvanyossag_hozzaad_group.Enabled = true;
                var latvanyossag = (Latvanyossag)latvanyossagok_lista.SelectedItem;
                LatvanyossagAdatok(latvanyossag.Id);
            }
        }

        private void varos_megsem_Click(object sender, EventArgs e) {
            varosok_group.Enabled = true;
            varos_hozzaad.Enabled = false;
            varos_modosit.Enabled = false;
            varos_hozzaad_group.Enabled = false;
            varos_nev.Text = "";
            varos_lakossag.Value = 0;
        }
        private void latvanyossag_megsem_Click(object sender, EventArgs e) {
            latvanyossagok_group.Enabled = true;
            latvanyossag_hozzaad.Enabled = false;
            latvanyossag_modosit.Enabled = false;
            latvanyossag_hozzaad_group.Enabled = false;
            latvanyossag_nev.Text = "";
            latvanyossag_leiras.Text = "";
            latvanyossag_belepo.Value = 0;
        }

        private void varosok_lista_SelectedIndexChanged(object sender, EventArgs e) {
            if (varosok_lista.SelectedIndex > -1) {
                var varos = (Varos)varosok_lista.SelectedItem;
                LatvanyossagLista(varos.Id);
            }
        }
    }
}
