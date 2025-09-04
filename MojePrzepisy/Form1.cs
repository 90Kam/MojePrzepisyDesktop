using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MojePrzepisy.Models;
using MojePrzepisy.Services;

namespace MojePrzepisy
{
    public partial class Form1 : Form
    {
        private List<Przepis> _wszystkie = new();
        private BindingList<Przepis> _widoczne = new();
        private Przepis? _aktywny = null;

        public Form1()
        {
            InitializeComponent();

            // Po inicjalizacji UI – konfiguracja kontrolek
            lstPrzepisy.DataSource = _widoczne;
            lstPrzepisy.DisplayMember = nameof(Przepis.Tytul);

            cmbKategoria.Items.AddRange(new object[] { "Œniadanie", "Obiad", "Kolacja", "Deser", "Przek¹ska" });
            cmbKategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            // Skróty klawiszowe
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.Control && e.KeyCode == Keys.S) { btnZapisz.PerformClick(); e.SuppressKeyPress = true; }
                if (e.Control && e.KeyCode == Keys.N) { btnNowy.PerformClick(); e.SuppressKeyPress = true; }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _wszystkie = StorageService.Load();

            // Dodaj przyk³adowy przepis przy pierwszym uruchomieniu
            //if (_wszystkie.Count == 0)
            //{
            //    _wszystkie.Add(new Przepis
            //    {
            //        Tytul = "Jajecznica klasyczna",
            //        Kategoria = "Œniadanie",
            //        Skladniki = "Jajka\nMas³o\nSól\nPieprz",
            //        Instrukcje = "Rozgrzej mas³o, wlej roztrzepane jajka, mieszaj do œciêcia.",
            //        Ulubiony = true
            //    });
            //}

            OdswiezListe();
        }

        private void OdswiezListe(string? filtr = null)
        {
            _widoczne.RaiseListChangedEvents = false;
            _widoczne.Clear();

            IEnumerable<Przepis> zrodlo = _wszystkie;
            if (!string.IsNullOrWhiteSpace(filtr))
            {
                var f = filtr.Trim().ToLowerInvariant();
                zrodlo = zrodlo.Where(p => (p.Tytul ?? "").ToLowerInvariant().Contains(f)
                                        || (p.Skladniki ?? "").ToLowerInvariant().Contains(f)
                                        || (p.Kategoria ?? "").ToLowerInvariant().Contains(f));
            }

            foreach (var p in zrodlo)
                _widoczne.Add(p);

            _widoczne.RaiseListChangedEvents = true;
            _widoczne.ResetBindings();
        }

        private void lstPrzepisy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var wybrany = lstPrzepisy.SelectedItem as Przepis;
            if (wybrany == null) return;
            _aktywny = wybrany;
            WypelnijFormularz(_aktywny);
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            _aktywny = null;
            WyczyscFormularz();
            txtTytul.Focus();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            var blad = WalidujFormularz();
            if (blad != null)
            {
                MessageBox.Show(blad, "B³¹d danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_aktywny == null)
            {
                var nowy = ZczytajZFormularza(new Przepis());
                _wszystkie.Add(nowy);
                _aktywny = nowy;
            }
            else
            {
                ZczytajZFormularza(_aktywny);
            }

            StorageService.Save(_wszystkie);
            OdswiezListe(txtSzukaj.Text);
            lstPrzepisy.SelectedItem = _aktywny;
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (_aktywny == null) return;
            var potwierdz = MessageBox.Show($"Usun¹æ przepis ‘{_aktywny.Tytul}’?", "PotwierdŸ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (potwierdz == DialogResult.Yes)
            {
                _wszystkie.Remove(_aktywny);
                _aktywny = null;
                WyczyscFormularz();
                StorageService.Save(_wszystkie);
                OdswiezListe(txtSzukaj.Text);
            }
        }

        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            OdswiezListe(txtSzukaj.Text);
        }

        private string? WalidujFormularz()
        {
            if (string.IsNullOrWhiteSpace(txtTytul.Text)) return "Podaj tytu³.";
            if (cmbKategoria.SelectedIndex < 0) return "Wybierz kategoriê.";
            return null;
        }

        private void WyczyscFormularz()
        {
            txtTytul.Text = string.Empty;
            cmbKategoria.SelectedIndex = -1;
            txtSkladniki.Text = string.Empty;
            txtInstrukcje.Text = string.Empty;
            chkUlubiony.Checked = false;
        }

        private void WypelnijFormularz(Przepis p)
        {
            txtTytul.Text = p.Tytul;
            cmbKategoria.SelectedItem = p.Kategoria;
            txtSkladniki.Text = p.Skladniki;
            txtInstrukcje.Text = p.Instrukcje;
            chkUlubiony.Checked = p.Ulubiony;
        }

        private Przepis ZczytajZFormularza(Przepis p)
        {
            p.Tytul = txtTytul.Text.Trim();
            p.Kategoria = cmbKategoria.SelectedItem?.ToString() ?? string.Empty;
            p.Skladniki = txtSkladniki.Text.Trim();
            p.Instrukcje = txtInstrukcje.Text.Trim();
            p.Ulubiony = chkUlubiony.Checked;
            return p;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StorageService.Save(_wszystkie); // auto-save przy wyjœciu
        }
    }
}
