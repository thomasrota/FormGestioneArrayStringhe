namespace FormGestioneArrayStringhe
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titolo = new System.Windows.Forms.Label();
            this.inpt = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.ext = new System.Windows.Forms.Button();
            this.listview = new System.Windows.Forms.ListView();
            this.selopz = new System.Windows.Forms.Label();
            this.agg = new System.Windows.Forms.Button();
            this.canc = new System.Windows.Forms.Button();
            this.bubblesort = new System.Windows.Forms.Button();
            this.ricerseq = new System.Windows.Forms.Button();
            this.ripet = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.lung = new System.Windows.Forms.Button();
            this.cancocc = new System.Windows.Forms.Button();
            this.clsout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titolo
            // 
            this.Titolo.AutoSize = true;
            this.Titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titolo.Location = new System.Drawing.Point(13, 13);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(187, 18);
            this.Titolo.TabIndex = 0;
            this.Titolo.Text = "Gestione Stringhe Array";
            // 
            // inpt
            // 
            this.inpt.AutoSize = true;
            this.inpt.Location = new System.Drawing.Point(16, 50);
            this.inpt.Name = "inpt";
            this.inpt.Size = new System.Drawing.Size(34, 13);
            this.inpt.TabIndex = 1;
            this.inpt.Text = "Input:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(19, 67);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(146, 20);
            this.input.TabIndex = 2;
            // 
            // ext
            // 
            this.ext.Location = new System.Drawing.Point(713, 415);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(75, 23);
            this.ext.TabIndex = 3;
            this.ext.Text = "Uscita";
            this.ext.UseVisualStyleBackColor = true;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            // 
            // listview
            // 
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(310, 67);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(455, 258);
            this.listview.TabIndex = 4;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.List;
            // 
            // selopz
            // 
            this.selopz.AutoSize = true;
            this.selopz.Location = new System.Drawing.Point(16, 109);
            this.selopz.Name = "selopz";
            this.selopz.Size = new System.Drawing.Size(92, 13);
            this.selopz.TabIndex = 5;
            this.selopz.Text = "Seleziona opzioni:";
            // 
            // agg
            // 
            this.agg.Location = new System.Drawing.Point(19, 136);
            this.agg.Name = "agg";
            this.agg.Size = new System.Drawing.Size(120, 23);
            this.agg.TabIndex = 6;
            this.agg.Text = "Aggiunta";
            this.agg.UseVisualStyleBackColor = true;
            this.agg.Click += new System.EventHandler(this.agg_Click);
            // 
            // canc
            // 
            this.canc.Location = new System.Drawing.Point(19, 166);
            this.canc.Name = "canc";
            this.canc.Size = new System.Drawing.Size(120, 23);
            this.canc.TabIndex = 7;
            this.canc.Text = "Cancella";
            this.canc.UseVisualStyleBackColor = true;
            this.canc.Click += new System.EventHandler(this.canc_Click);
            // 
            // bubblesort
            // 
            this.bubblesort.Location = new System.Drawing.Point(19, 196);
            this.bubblesort.Name = "bubblesort";
            this.bubblesort.Size = new System.Drawing.Size(120, 23);
            this.bubblesort.TabIndex = 8;
            this.bubblesort.Text = "BubbleSort";
            this.bubblesort.UseVisualStyleBackColor = true;
            this.bubblesort.Click += new System.EventHandler(this.bubblesort_Click);
            // 
            // ricerseq
            // 
            this.ricerseq.Location = new System.Drawing.Point(19, 226);
            this.ricerseq.Name = "ricerseq";
            this.ricerseq.Size = new System.Drawing.Size(120, 23);
            this.ricerseq.TabIndex = 9;
            this.ricerseq.Text = "Ricerca Sequenziale";
            this.ricerseq.UseVisualStyleBackColor = true;
            this.ricerseq.Click += new System.EventHandler(this.ricerseq_Click);
            // 
            // ripet
            // 
            this.ripet.Location = new System.Drawing.Point(158, 136);
            this.ripet.Name = "ripet";
            this.ripet.Size = new System.Drawing.Size(120, 23);
            this.ripet.TabIndex = 10;
            this.ripet.Text = "Ripetuti";
            this.ripet.UseVisualStyleBackColor = true;
            this.ripet.Click += new System.EventHandler(this.ripet_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(158, 166);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(120, 23);
            this.mod.TabIndex = 11;
            this.mod.Text = "Modifica";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // lung
            // 
            this.lung.Location = new System.Drawing.Point(158, 196);
            this.lung.Name = "lung";
            this.lung.Size = new System.Drawing.Size(120, 23);
            this.lung.TabIndex = 12;
            this.lung.Text = "Lunghezza";
            this.lung.UseVisualStyleBackColor = true;
            this.lung.Click += new System.EventHandler(this.lung_Click);
            // 
            // cancocc
            // 
            this.cancocc.Location = new System.Drawing.Point(158, 226);
            this.cancocc.Name = "cancocc";
            this.cancocc.Size = new System.Drawing.Size(120, 23);
            this.cancocc.TabIndex = 13;
            this.cancocc.Text = "Elimina occorenze";
            this.cancocc.UseVisualStyleBackColor = true;
            this.cancocc.Click += new System.EventHandler(this.cancocc_Click);
            // 
            // clsout
            // 
            this.clsout.Location = new System.Drawing.Point(611, 332);
            this.clsout.Name = "clsout";
            this.clsout.Size = new System.Drawing.Size(153, 23);
            this.clsout.TabIndex = 14;
            this.clsout.Text = "Pulisci lista / Stampa array";
            this.clsout.UseVisualStyleBackColor = true;
            this.clsout.Click += new System.EventHandler(this.clsout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clsout);
            this.Controls.Add(this.cancocc);
            this.Controls.Add(this.lung);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.ripet);
            this.Controls.Add(this.ricerseq);
            this.Controls.Add(this.bubblesort);
            this.Controls.Add(this.canc);
            this.Controls.Add(this.agg);
            this.Controls.Add(this.selopz);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.input);
            this.Controls.Add(this.inpt);
            this.Controls.Add(this.Titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titolo;
        private System.Windows.Forms.Label inpt;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.Label selopz;
        private System.Windows.Forms.Button agg;
        private System.Windows.Forms.Button canc;
        private System.Windows.Forms.Button bubblesort;
        private System.Windows.Forms.Button ricerseq;
        private System.Windows.Forms.Button ripet;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button lung;
        private System.Windows.Forms.Button cancocc;
        private System.Windows.Forms.Button clsout;
    }
}

