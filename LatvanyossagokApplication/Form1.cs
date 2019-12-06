using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LatvanyossagokApplication {
    public partial class Form1 : Form {
        private MySqlConnection conn;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        static readonly HttpClient client = new HttpClient();
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
            varos_torol.Enabled = false;
            latvanyossagok_logo.Image = ((System.Drawing.Image)(resources.GetObject("latvanyossagok_logo.Image")));
            latvanyossagok_logo_cim.Visible = true;
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
            latvanyossag_torol.Enabled = false;
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
            if (varos_nev.Text.Length > 1 && varos_lakossag.Text.Length > 2) {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO varosok (nev, lakossag) VALUES (@nev, @lakossag)";
                cmd.Parameters.AddWithValue("@nev", varos_nev.Text);
                cmd.Parameters.AddWithValue("@lakossag", varos_lakossag.Value);
                cmd.ExecuteNonQuery();
                varos_nev.Text = "";
                varos_lakossag.Text = "";
                VarosLista();
            } else {
                MessageBox.Show("Hiányzó adat.");
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
            } else {
                MessageBox.Show("Hiányzó adat.");
            }
        }

        private void varos_modosit_Click(object sender, EventArgs e)
        {
            if (varos_nev.Text.Length > 1 && varos_lakossag.Text.Length > 2)
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
                if (latvanyossag_db < 1) {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM varosok WHERE id=@id;";
                    cmd.Parameters.AddWithValue("@id", varos.Id);
                    cmd.ExecuteNonQuery();
                    VarosLista();
                } else {
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
                varosok_group.Enabled = false;
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
            varosok_group.Enabled = true;
            latvanyossag_hozzaad_group.Enabled = false;
            latvanyossag_nev.Text = "";
            latvanyossag_leiras.Text = "";
            latvanyossag_belepo.Value = 0;
        }

        private void varosok_lista_SelectedIndexChanged(object sender, EventArgs e) {
            if (varosok_lista.SelectedIndex > -1) {
                var varos = (Varos)varosok_lista.SelectedItem;
                LatvanyossagLista(varos.Id);
                loadCimerAsync(varos.Nev);
                varos_torol.Enabled = true;
            } else {
                varos_torol.Enabled = false;
            }
        }
        private void latvanyossagok_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (latvanyossagok_lista.SelectedIndex > -1) {
                latvanyossag_torol.Enabled = true;
            } else {
                latvanyossag_torol.Enabled = false;
            }
        }

        private async Task loadCimerAsync(string varos) {
            try {
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                HttpResponseMessage response = await client.GetAsync("https://magyarcimerek.hu/kereses/"+varos);
                response.EnsureSuccessStatusCode();
                string responseHeaders = response.Headers.ToString();
                string responseBody = await response.Content.ReadAsStringAsync();
                string[] cimer_ = responseBody.Split(new string[] { "<div class='img'>" }, StringSplitOptions.None);
                if (cimer_.Length>1) {
                    string cimer = cimer_[1];
                    cimer = cimer.Split(new string[] { "/>" }, StringSplitOptions.None)[0];
                    string cimer_url = cimer.Split(new string[] { "src='" }, StringSplitOptions.None)[1];
                    cimer_url = cimer_url.Split(new string[] { "'" }, StringSplitOptions.None)[0];
                    latvanyossagok_logo.LoadAsync("https://magyarcimerek.hu"+cimer_url);
                    //latvanyossagok_logo.LoadAsync("http://www.nemzetijelkepek.hu/pictures/onkormanyzat/"+varos+"_265.jpg");
                    latvanyossagok_logo_cim.Visible = false;
                } else {
                    latvanyossagok_logo.Image = ((System.Drawing.Image)(resources.GetObject("latvanyossagok_logo.Image")));
                    latvanyossagok_logo_cim.Visible = true;
                }
            }
            catch (HttpRequestException e) {
                latvanyossagok_logo.Image = ((System.Drawing.Image)(resources.GetObject("latvanyossagok_logo.Image")));
                latvanyossagok_logo_cim.Visible = true;
            }
        }
    }
}
