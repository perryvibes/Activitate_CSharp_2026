using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s3
{
    public partial class Form1 : Form
    {
        private List<Contact> _contacte;

        public Form1()
        {
            InitializeComponent();
            _contacte = new List<Contact>();
        }

        private void OnBtnAdaugaContactClicked(object sender, EventArgs e)
        {
            var prenume = txtPrenume.Text;
            var nume = txtNume.Text;
            var telefon = txtTelefon.Text;
            var email = txtEmail.Text;
            var notificariActive = chkNotificariActive.Checked;

            if (string.IsNullOrWhiteSpace(prenume)
                || string.IsNullOrWhiteSpace(nume)
                || string.IsNullOrWhiteSpace(telefon)
                || string.IsNullOrWhiteSpace(email)
                )
            {
                MessageBox.Show("Formularul nu este valid", "Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            var contact = new Contact()
            {
                Nume = nume,
                Prenume = prenume,
                Telefon = telefon,
                Email = email,
                NotificariActive = notificariActive,
            };

            _contacte.Add(contact);
            MessageBox.Show($"{prenume} {nume} a fost adaugat!",
                "Succes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //... empty inputs //

            txtNume.Text = string.Empty;
            txtPrenume.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtEmail.Text = string.Empty;
            chkNotificariActive.Checked = false;

            RefreshLista(_contacte);
        }
        private void RefreshLista(List<Contact> contacteFiltrate)
        {
            lstContacte.Items.Clear();
            foreach(Contact contact in contacteFiltrate)
            {
                lstContacte.Items.Add(contact);
            }
        }
        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            var text = txtCautare.Text;
            var listaFiltrata = _contacte.Where(
                contact => contact.ToString().ToLower().Contains(text)).ToList();
        }
    }
}
