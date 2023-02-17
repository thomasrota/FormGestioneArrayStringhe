using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
        private void agg_Click(object sender, EventArgs e)                              // Aggiunta elementi
        {
            Aggiunta(input.Text, array, ref dim);                                       // Chiamata funzione 'Aggiunta'
            input.Text = "";
        }
        private void canc_Click(object sender, EventArgs e)                             // Cancella elementi
        {
            listview.Items.Clear();                                                     // Pulizia elementi 'listview'
            CancellaS(input.Text, array, ref dim);                                      // Chiamata funzione 'CancellaS'
            for (int i = 0; i < dim; i++)
            {
                listview.Items.Add(array[i]);                                           // Inserimento array in 'listview'
            }
            input.Text = "";
        }
        private void bubblesort_Click(object sender, EventArgs e)                       // Ordina elementi
        {
            listview.Items.Clear();                                                     // Pulizia elementi 'listview'
            BubbleSort(array, ref dim);                                                 // Chiamata funzione 'BubbleSort'
            for (int i = 0; i < dim; i++)
            {
                listview.Items.Add(array[i]);                                           // Inserimento array in 'listview'
            }
        }
        private void ricerseq_Click(object sender, EventArgs e)                         // Cerca posizione elementi
        {
            if (RicercaSeq(input.Text, array) == -1)
            {
                listview.Clear();
                listview.Items.Add("Elemento non trovato!");
            }
            else
            {
                listview.Clear();
                listview.Items.Add($"Elemento '{input.Text}' trovato in posizone " + RicercaSeq(input.Text, array));
            }
        }
        private void ripet_Click(object sender, EventArgs e)                            // Visualizza elementi ripetuti
        {
            listview.Clear();
            NumeroRipet(array, ref dim);                                                // Chiamata funzione 'NumeroRipet'
        }
        private void mod_Click(object sender, EventArgs e)                              // Modifica elemento array
        {
            ModificaN(input.Text, Convert.ToInt32(posinpt.Text), array, ref dim);       // Chiamata funzione 'ModificaN'
        }
        private void lung_Click(object sender, EventArgs e)                             // Visualizza elemento più lungo e più corto
        {
            listview.Clear();
            Lunghezza(array, ref dim);
        }
        private void cancocc_Click(object sender, EventArgs e)                          // Cancella occorrenze
        {
            CancellaOcc(input.Text, array, ref dim);                                    // Chiamata funzione 'CancellaOcc'
        }
        private void clsout_Click(object sender, EventArgs e)                           // Pulire lista e stampa array
        {
            listview.Clear();
            Visualizza(array, ref dim);                                                 // Chiamata funzione 'Visualizza'
        }
        private void ext_Click(object sender, EventArgs e)                              // Uscita programma
        {
            Application.Exit();
        }
        #endregion Funzioni Evento

        #region Funzioni Servizio
        public void Visualizza(string[] array, ref int dim)
        {
            for (int i = 0; i < dim; i++)
            {
                listview.Items.Add(array[i]);
            }
        }
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
        public int RicercaSeq(string e, string[] array)                                 // Funzione 'RicercaSeq' che cerca e resituisce la posizione di un'elemento
        {
            int risultatoricerca = 0;                                                   // Dichiarazione variabile tipo intero 'risultatoricerca'
            for (int i = 0; i < array.Length; i++)                                      // Ciclo controllo presenza elemento ricercato
            {
                if (array[i] == e)                                                      // Se elemento array in posizione 'i' è uguale a 'e' (elemento da ricercare)
                {
                    risultatoricerca = i;                                               // Assegnazione 'risultatoricerca' valore 'i'
                    break;                                                              // Interrompere esecuzione
                }
                else                                                                    // Altrimenti
                {
                    risultatoricerca = -1;                                              // Assegnazione a 'risultatoricerca' valore '-1'
                }
            }
            return risultatoricerca;
        }
        public void NumeroRipet(string[] array, ref int dim)                            // Funzione 'NumeroRipet' che restituisce il numero di volte che si ripete un elemento all'interno dell'onc
        {
            string[] onc = new string[dim];
            for (int i = 0; i < dim; i++)
            {
                onc[i] = array[i];
            }
            int x, y;
            string temp;
            for (x = 0; x < dim - 1; x++)
            {
                for (y = 0; y < dim - 1; y++)
                {
                    int comp = string.Compare(onc[y], onc[y + 1]);
                    if (comp == 1)
                    {
                        temp = onc[y];
                        onc[y] = onc[y + 1];
                        onc[y + 1] = temp;
                    }
                }
            }
            string rc = onc[0];
            int conteggio = 1;
            for (int i = 1; i < dim; i++)
            {
                if (onc[i] == rc)
                {
                    conteggio++;
                }
                else
                {
                    listview.Items.Add($"Elemento: '{rc}' Conteggio: {conteggio}");
                    rc = onc[i];
                    conteggio = 1;
                }
            }
            listview.Items.Add($"Elemento: '{rc}' Conteggio: {conteggio}");
        }
        public void Lunghezza(string[] array, ref int dim)                              // Funzione 'Lunghezza' che ricerca e restituisce il nome più lungo e più corto
        {
            string longstr = array[0], shortstr = array[0];                             // Dichiarazione varabili tipo stringa 'longstr' e 'shortstr'
            for (int i = 1; i < dim; i++)                                               // Ciclo per scorrere tutto l'array
            {
                if (array[i].Length > longstr.Length)                                   // Se lunghezza dell'elemento in posizione 'i' è maggiore rispetto a quella della lunghezza di 'longstr'
                {
                    longstr = array[i];                                                 // Assegna a 'longstr' elemento array in posizione 'i'
                }
                if (array[i].Length < shortstr.Length)                                  // Se lunghezza dell'elemento in posizione 'i' è minore rispetto a quella della lunghezza di 'shortstr'
                {
                    shortstr = array[i];                                                // Assegna a 'shortstr' elemento array in posizione 'i'
                }
            }
            listview.Items.Add("L'elemento più lungo è: '" + longstr + "', mentre l'elemento più corto è: '" + shortstr + "'.");
        }
        public void ModificaN(string e, int p, string[] array, ref int dim)             // Funzione 'MofificaN' che va a modificare un elemento in una determinata posizone
        {
            if (p < 0 || p > dim)                                                       // Se 'p' minore 0 o 'p' maggiore di 'dim'
            {
                listview.Clear();
                listview.Items.Add("Posizione non valida!");
            }
            else
            {
                array[p] = e;
                listview.Clear();
                Visualizza(array, ref dim);
            }
        }
        public void CancellaOcc(string e, string[] array, ref int dim)                  // Funzione 'CancellaOcc' che cancella tutte le occorrenze di un elemento
        {
            bool canc = false;
            for (int i = 0; i < dim; i++)
            {
                if (array[i] == e)
                {                                                      
                    dim--;
                    for (int j = i; j < dim; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    i--;
                    canc = true;
                }
            }
            if (canc == true)
            {
                listview.Clear();
                Visualizza(array, ref dim);
            }
        }
        #endregion Funzioni servizio
    }
}