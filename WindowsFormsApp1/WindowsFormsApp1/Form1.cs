using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace proiect
{
    public partial class Form1 : Form
    {
        private BindingList<Angajat> angajati = new BindingList<Angajat>();
        private List<Intrebare> intrebari = new List<Intrebare>()
        {
            new Intrebare("Ce experiență ai în domeniul nostru?", new List<string>() { "Niciuna", "Mai puțin de 1 an", "1-3 ani", "Mai mult de 3 ani" }),
            new Intrebare("Ce abilități cheie ai pentru acest job?", new List<string>() { "Comunicare", "Leadership", "Rezolvarea problemelor", "Colaborare" }),
            new Intrebare("Cum gestionezi situațiile stresante?", new List<string>() { "Mă panichez", "Mă calmez și găsesc soluții", "Cer ajutor colegilor", "Nu întâmpin situații stresante" }),
            new Intrebare("De ce dorești să lucrezi pentru noi?", new List<string>() { "Opportunități de creștere", "Cultură organizațională", "Proiecte interesante", "Echipa talentată" }),
            new Intrebare("Cum ai rezolvat un conflict în cadrul echipei?", new List<string>() { "Evitarea conflictului", "Comunicare deschisă", "Negociere", "Mediere" }),
            new Intrebare("Ce părere ai despre munca în echipă?", new List<string>() { "Îmi place să lucrez în echipă", "Prefer să lucrez individual", "Ambele variant de lucru sunt importante", "Depinde de situație" }),
            new Intrebare("Cum te pregătești pentru un proiect important?", new List<string>() { "Elaborez un plan detaliat", "Cercetez și analizez în profunzime", "Colaborez cu colegii", "Mă bazez pe experiență anterioară" }),
            new Intrebare("Cum îți gestionezi timpul și prioritățile?", new List<string>() { "Folosesc un calendar sau o agendă", "Stabilesc obiective și deadline-uri", "Deleg sarcini", "Rezolv sarcinile în ordinea apariției lor" }),
            new Intrebare("Cum te adaptezi la schimbări?", new List<string>() { "Îmi place să explorez lucruri noi", "Rezist schimbărilor", "Îmi fac un plan de acțiune", "Caut sprijin și consiliere" }),
            new Intrebare("Ce te motivează să ai performanțe ridicate?", new List<string>() { "Dorința de a reuși", "Recunoașterea și recompensele", "Competiția cu colegii", "Responsabilitatea față de echipă" })
        };

        public Form1()
        {
            InitializeComponent();
            ConfigurareTabel();
            AplicaStiluri();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = angajati;
        }

        private void ConfigurareTabel()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Nr", "Nr");
            dataGridView1.Columns["Nr"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns.Add("NumeAngajat", "Nume angajat");
            dataGridView1.Columns["NumeAngajat"].DataPropertyName = "Nume";

            dataGridView1.Columns.Add("Departament", "Departament");
            dataGridView1.Columns["Departament"].DataPropertyName = "Departament";

            dataGridView1.Columns.Add("Raspuns", "Raspuns");
            dataGridView1.Columns["Raspuns"].DataPropertyName = "Raspunsuri";

            dataGridView1.RowsAdded += DataGridView1_RowsAdded;
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Nr"].Value = (i + 1).ToString();
            }
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            string numeAngajat = txtNumeAngajat.Text;
            string departament = txtDepartamentAngajat.Text;

            Angajat angajat = new Angajat(numeAngajat, departament);

            foreach (var intrebare in intrebari)
            {
                string raspuns = Prompt.ShowDialog(intrebare.Text, "Intrebare", intrebare.Optiuni);
                angajat.Raspunsuri.Add(raspuns);
            }

            angajati.Add(angajat);
            txtNumeAngajat.Text = ""; // Clear input fields
            txtDepartamentAngajat.Text = "";
        }

        private void btnTrimiteRaspunsuri_Click(object sender, EventArgs e)
        {
            if (angajati.Count > 0)
            {
                List<string> results = new List<string>();

                foreach (Angajat angajat in angajati)
                {
                    string result = "Rezultate pentru " + angajat.Nume + " (" + angajat.Departament + "):\n";

                    for (int i = 0; i < intrebari.Count; i++)
                    {
                        result += "Intrebare: " + intrebari[i].Text + "\n";
                        result += "Raspuns: " + angajat.Raspunsuri[i] + "\n";
                    }

                    results.Add(result);
                }

                MessageBox.Show(string.Join("\n", results), "Rezultate");
                angajati.Clear();
            }
            else
            {
                MessageBox.Show("Nu există răspunsuri de trimis.");
            }
        }

        private void AplicaStiluri()
        {
            // Culori pentru stilizare
            Color culoareFundal = Color.FromArgb(240, 240, 240);
            Color culoareText = Color.FromArgb(0, 0, 0);
            Color culoareFundalHeader = Color.FromArgb(68, 114, 196);
            Color culoareTextHeader = Color.FromArgb(255, 255, 255);
            Color culoareBorder = Color.FromArgb(170, 170, 170);

            // Schimbarea culorilor labelurilor
            label1.BackColor = culoareFundal;
            label1.ForeColor = culoareText;

            label2.BackColor = culoareFundal;
            label2.ForeColor = culoareText;

            // Schimbarea culorilor butoanelor
            btnStartTest.BackColor = culoareFundalHeader;
            btnStartTest.ForeColor = culoareTextHeader;

            btnTrimiteRaspunsuri.BackColor = culoareFundalHeader;
            btnTrimiteRaspunsuri.ForeColor = culoareTextHeader;

            // Schimbarea culorilor datagridview-ului
            dataGridView1.BackgroundColor = culoareFundal;
            dataGridView1.DefaultCellStyle.BackColor = culoareFundal;
            dataGridView1.DefaultCellStyle.ForeColor = culoareText;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = culoareFundalHeader;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = culoareTextHeader;
            dataGridView1.GridColor = culoareBorder;
        }
    }
    public class Intrebare
    {
        public string Text { get; set; }
        public List<string> Optiuni { get; set; }

        public Intrebare(string text, List<string> optiuni)
        {
            Text = text;
            Optiuni = optiuni;
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, List<string> optiuni)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 50, Top = 20, Width = 400, Text = text };
            ComboBox comboBox = new ComboBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            comboBox.Items.AddRange(optiuni.ToArray());
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;

            prompt.Controls.Add(comboBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? comboBox.SelectedItem.ToString() : "";
        }
    }

    
        }
    

