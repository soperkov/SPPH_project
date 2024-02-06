using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPH_project
{
    public partial class SPPH_project : Form
    {

        //PH PROJECT

        class Person
        {
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public char Spol { get; set; }
            public DateTime DatumRođenja { get; set; }
            public string Država { get; set; }
            public string MjestoRođenja { get; set; }
        }

        ObservableCollection<Person> ListOfPersons = new ObservableCollection<Person>()
        { new Person {
            Ime = "Sonja",
            Prezime = "Perković",
            Spol = 'F',
            DatumRođenja = new DateTime(1998, 9, 27),
            Država = "Hrvatska",
            MjestoRođenja = "Zagreb" },
        new Person {
            Ime = "Petar",
            Prezime = "Huljek",
            Spol = 'M',
            DatumRođenja = new DateTime(1997, 9, 21),
            Država = "Hrvatska",
            MjestoRođenja = "Zagreb" },
        new Person {
            Ime = "Henry",
            Prezime = "Cavill",
            Spol = 'M',
            DatumRođenja = new DateTime(1983, 5, 5),
            Država = "SAD",
            MjestoRođenja = "Jersey" },
        new Person {
            Ime = "Miloš",
            Prezime = "Biković",
            Spol = 'M',
            DatumRođenja = new DateTime(1988, 1, 13),
            Država = "Srbija",
            MjestoRođenja = "Beograd" },
        new Person {
            Ime = "Gal",
            Prezime = "Gadot",
            Spol = 'F',
            DatumRođenja = new DateTime(1985, 4, 30),
            Država = "Izrael",
            MjestoRođenja = "Petah Tikva" },
        new Person {
            Ime = "Anna",
            Prezime = "Faris",
            Spol = 'F',
            DatumRođenja = new DateTime(1976, 11, 29),
            Država = "SAD",
            MjestoRođenja = "Maryland" },
        new Person {
            Ime = "Leslie",
            Prezime = "Nielsen",
            Spol = 'M',
            DatumRođenja = new DateTime(1926, 2, 11),
            Država = "SAD",
            MjestoRođenja = "Florida" }
        };

        //SP PROJECT
        public class Card
        {
            public string CardNumber { get; set; }
            public string CardSuit { get; set; }
            public string CardColor { get; set; }
        }

        List<Card> Deck = new List<Card>() {
            new Card{CardNumber = "A", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "A", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "A", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "A", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "2", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "2", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "2", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "2", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "3", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "3", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "3", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "3", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "4", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "4", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "4", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "4", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "5", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "5", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "5", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "5", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "6", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "6", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "6", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "6", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "7", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "7", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "7", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "7", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "8", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "8", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "8", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "8", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "9", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "9", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "9", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "9", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "10", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "10", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "10", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "10", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "J", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "J", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "J", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "J", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "Q", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "Q", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "Q", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "Q", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "K", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "K", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "K", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "K", CardSuit = "♦", CardColor = "red" }
        };


        //Methods
        public void removeCard(int index, Label label, Label labelcopy)
        {
            if (Deck[index].CardColor == "black")
            {
                label.Text = Deck[index].CardNumber + Deck[index].CardSuit;
                labelcopy.Text = Deck[index].CardSuit + Deck[index].CardNumber;
                label.ForeColor = Color.Black;
                labelcopy.ForeColor = Color.Black;
            }
            else
            {
                label.Text = Deck[index].CardNumber + Deck[index].CardSuit;
                labelcopy.Text = Deck[index].CardSuit + Deck[index].CardNumber;
                label.ForeColor = Color.Red;
                labelcopy.ForeColor = Color.Red;
            }
            Deck.RemoveAt(index);
            labelCardsInDeck.Text = Deck.Count.ToString();
        }

        public SPPH_project()
        {
            InitializeComponent();

            dataPersonView.DataSource = ListOfPersons;

            spolBox.Items.Add('M');
            spolBox.Items.Add('F');
            spolBox.SelectedIndex = 0;
            progressBar.Value = 34;
            datumBox.Format = DateTimePickerFormat.Custom;
            datumBox.CustomFormat = "dd/MM/yyyy";

            labelCardsInDeck.Text = Deck.Count.ToString();
        }

        bool IsColumnSorted = false;
        private void dataPersonView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var temp = new List<Person>();
            if (!IsColumnSorted)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        temp = ListOfPersons.OrderBy(x => x.Ime).ToList(); break;
                    case 1:
                        temp = ListOfPersons.OrderBy(x => x.Prezime).ToList(); break;
                    case 2:
                        temp = ListOfPersons.OrderBy(x => x.Spol).ToList(); break;
                    case 3:
                        temp = ListOfPersons.OrderBy(x => x.DatumRođenja).ToList(); break;
                    case 4:
                        temp = ListOfPersons.OrderBy(x => x.Država).ToList(); break;
                    case 5:
                        temp = ListOfPersons.OrderBy(x => x.MjestoRođenja).ToList(); break;
                }
                ListOfPersons = new ObservableCollection<Person>(temp);
                IsColumnSorted = true;

            }
            else if (IsColumnSorted)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        temp = ListOfPersons.OrderByDescending(x => x.Ime).ToList(); break;
                    case 1:
                        temp = ListOfPersons.OrderByDescending(x => x.Prezime).ToList(); break;
                    case 2:
                        temp = ListOfPersons.OrderByDescending(x => x.Spol).ToList(); break;
                    case 3:
                        temp = ListOfPersons.OrderByDescending(x => x.DatumRođenja).ToList(); break;
                    case 4:
                        temp = ListOfPersons.OrderByDescending(x => x.Država).ToList(); break;
                    case 5:
                        temp = ListOfPersons.OrderByDescending(x => x.MjestoRođenja).ToList(); break;
                }
                ListOfPersons = new ObservableCollection<Person>(temp);
                IsColumnSorted = false;

            }
            dataPersonView.DataSource = ListOfPersons;
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (progressBar.Value >= 100)
            {
                ListOfPersons.Add(new Person
                {
                    Ime = imeBox.Text,
                    Prezime = prezimeBox.Text,
                    Spol = (char)spolBox.SelectedItem,
                    DatumRođenja = datumBox.Value,
                    Država = drzavaBox.Text,
                    MjestoRođenja = mjestoBox.Text,
                });

                if (!checkKeepDataBox.Checked)
                {
                    progressBar.Value = 34;
                    imeBox.Text = string.Empty;
                    prezimeBox.Text = string.Empty;
                    drzavaBox.Text = string.Empty;
                    mjestoBox.Text = string.Empty;
                    IsImeEmpty = true;
                    IsPrezimeEmpty = true;
                    IsDrzavaEmpty = true;
                    IsMjestoEmpty = true;
                }

            }
            else
            {
                MessageBox.Show("Fill all data boxes.", "Fill error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataPersonView.DataSource = null;
            dataPersonView.DataSource = ListOfPersons;
        }

        bool IsImeEmpty = true;
        private void imeBox_Validated(object sender, EventArgs e)
        {
            if (imeBox.Text.Length > 0 && IsImeEmpty)
            {
                progressBar.Value += 17;
                IsImeEmpty = false;
            }
            else if (imeBox.Text == "" && progressBar.Value != 0 && !IsImeEmpty)
            {
                progressBar.Value -= 17;
                IsImeEmpty = true;
            }
        }
        bool IsPrezimeEmpty = true;
        private void prezimeBox_Validated(object sender, EventArgs e)
        {
            if (prezimeBox.Text.Length > 0 && IsPrezimeEmpty)
            {
                progressBar.Value += 17;
                IsPrezimeEmpty = false;
            }
            else if (prezimeBox.Text == "" && progressBar.Value != 0 && !IsPrezimeEmpty)
            {
                progressBar.Value -= 17;
                IsPrezimeEmpty = true;
            }
        }
        bool IsDrzavaEmpty = true;
        private void drzavaBox_Validated(object sender, EventArgs e)
        {
            if (drzavaBox.Text.Length > 0 && IsDrzavaEmpty)
            {
                progressBar.Value += 17;
                IsDrzavaEmpty = false;
            }
            else if (drzavaBox.Text == "" && progressBar.Value != 0 && !IsDrzavaEmpty)
            {
                progressBar.Value -= 17;
                IsDrzavaEmpty = true;
            }
        }
        bool IsMjestoEmpty = true;
        private void mjestoBox_Validated(object sender, EventArgs e)
        {
            if (mjestoBox.Text.Length > 0 && IsMjestoEmpty)
            {
                progressBar.Value += 17;
                IsMjestoEmpty = false;
            }
            else if (mjestoBox.Text == "" && progressBar.Value != 0 && !IsMjestoEmpty)
            {
                progressBar.Value -= 17;
                IsMjestoEmpty = true;
            }
        }

        //SP PROJECT
        Random random = new Random();
        int nCards;
        int indexCard;
        private void buttonCardDraw_Click(object sender, EventArgs e)
        {
            if (Deck.Count == 0) { MessageBox.Show("No cards left.", "Reset the deck.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (Deck.Count > 1)
            {
                nCards = random.Next(0, 2);
                if (nCards == 0)
                {
                    labelSecondPile.Text = "   ";
                    labelSecondPile2.Text = "   ";
                    indexCard = random.Next(0, Deck.Count);
                    removeCard(indexCard, labelFirstPile, labelFirstPile2);
                }
                else
                {
                    indexCard = random.Next(0, Deck.Count);
                    removeCard(indexCard, labelFirstPile, labelFirstPile2);

                    indexCard = random.Next(0, Deck.Count);
                    removeCard(indexCard, labelSecondPile, labelSecondPile2);
                }
                labelCardsInDeck.Text = Deck.Count.ToString();
            }
            else
            {
                labelSecondPile.Text = "   ";
                labelSecondPile2.Text = "   ";
                indexCard = random.Next(0, Deck.Count);
                removeCard(indexCard, labelFirstPile, labelFirstPile2);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Deck.Clear();
            Deck = new List<Card>() {
                new Card{CardNumber = "A", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "A", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "A", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "A", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "2", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "2", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "2", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "2", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "3", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "3", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "3", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "3", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "4", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "4", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "4", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "4", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "5", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "5", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "5", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "5", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "6", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "6", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "6", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "6", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "7", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "7", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "7", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "7", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "8", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "8", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "8", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "8", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "9", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "9", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "9", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "9", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "10", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "10", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "10", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "10", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "J", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "J", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "J", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "J", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "Q", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "Q", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "Q", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "Q", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "K", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "K", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "K", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "K", CardSuit = "♦", CardColor = "red" }
            };
            labelCardsInDeck.Text = Deck.Count.ToString();
            labelFirstPile.Text = "   ";
            labelFirstPile2.Text = "   ";
            labelSecondPile.Text = "   ";
            labelSecondPile2.Text = "   ";
        }
    }
}
