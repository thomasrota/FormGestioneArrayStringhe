using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormGestioneArrayStringhe
{
    public partial class Form1 : Form
    {
        // Dichiarazioni
        public string[] array;                                                          // Dichiarazione array di tipo stringa 'array'
        public string e;                                                                // Dichiarazione variabile di tipo stringa 'e'
        public int dim;                                                                 // Dichiarazione variabile di tipo intero 'dim'
        public int scelta;                                                              // Dichiarazione variabile di tipo intero 'scelta'

        #region Funzioni Evento
        public Form1()
        {
            InitializeComponent();
            dim = 0;                                                                    // Inizializzazione variabile 'dim'
            array = new string[100];                                                    // Inizializzazione variabile 'array'
        }
        private void agg_Click(object sender, EventArgs e)
        {
            Aggiunta(input.Text, array, ref dim);                                       // Chiamata funzione 'Aggiunta'
            input.Text = "";
        }
        private void canc_Click(object sender, EventArgs e)
        {
            listview.Items.Clear();                                                     // Pulizia elementi 'listview'
            CancellaS(input.Text, array, ref dim);                                      // Chiamata funzione 'CancellaS'
            for (int i = 0; i < dim; i++)
            {
                listview.Items.Add(array[i]);                                           // Inserimento array in 'listview'
            }
            input.Text = "";
        }
        private void bubblesort_Click(object sender, EventArgs e)
        {
            listview.Items.Clear();                                                     // Pulizia elementi 'listview'
            BubbleSort(array, ref dim);                                                 // Chiamata funzione 'BubbleSort'
            for (int i = 0; i < dim; i++)
            {
                listview.Items.Add(array[i]);                                           // Inserimento array in 'listview'
            }
        }
        private void ext_Click(object sender, EventArgs e)                              // Uscita programma
        {
            Application.Exit();
        }
        #endregion Funzioni Evento

        #region Funzioni Servizio
        public void Aggiunta(string e, string[] array, ref int dim)                     // Funzione 'Aggiunta' per aggiungere elementi all'array
        {
            if (dim < array.Length)                                                     // Se non è stata raggiunta la dimensione massima dell'array           
            {
                array[dim] = e;                                                         // Aggiungere l'elemento
                listview.Items.Add(array[dim]);                                         // Aggiungere l'elemento alla listview
                dim++;                                                                  // Incremento indice
            }
        }
        public void CancellaS(string e, string[] array, ref int dim)                    // Funzione 'CancellaS'
        {
            for (int i = 0; i < dim; i++)                                               // Ciclo
            {
                if (array[i] == e)                                                      // Condizione per verificare che a 'i' sia presente 'e'
                {
                    for (int j = i; j < dim - 1; j++)                                   // Ciclo per spostare di una posizione indietro tutti i valori dopo la posizione del valore eliminato
                    {
                        array[j] = array[j + 1];                                        // Assegnazione all'elemento in posizione 'j' l'elemento successivo
                        dim--;                                                          // Diminuzione variabile 'dim'
                    }
                    break;                                                              // Interruzione esecuzione
                }
            }
        }
        public void BubbleSort(string[] array, ref int dim)                             // Funzione 'BubbleSort' per ordinare in ordine alfabetico gli elementi dell'array
        {
            int x, y;                                                                   // Dichiarazione variabili tipo intero 'x' e 'y'
            string temp;                                                                // Dichiarazione variabile tipo stringa 'temp'
            for (x = 0; x < dim - 1; x++)                                               // Ciclo per scorrere tutto l'array
            {
                for (y = 0; y < dim - 1; y++)                                           // Ciclo confronto a coppie
                {
                    int comp = string.Compare(array[y], array[y + 1]);                  // Dichiarazione variabile 'comp' (string.Compare restituisce un intero che indica se la prima stringa è minore (-1), uguale (0) o maggiore (1) rispetto alla seconda stringa.)
                    if (comp == 1)                                                      // Se 'comp' uguale a '1'
                    {
                        temp = array[y];                                                // Salvataggio del elemento alla posizione 'y' dell'array in 'temp'
                        array[y] = array[y + 1];                                        // Scambio elemento successivo a 'y' nella posizione 'y'
                        array[y + 1] = temp;                                            // Spostamento elemento contenuto in 'temp' nella posizione successiva a 'y'
                    }
                }
            }
        }
        #endregion Funzioni servizio
    }
}