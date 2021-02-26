using System;

namespace AS2021_4H_TPSIT_BronzettiChristian_assicurazioni.Models
{
    class Polizza
    {
       
        int _id; //id privata per ogni oggetto creato da main
        public int Id { get => _id; } //proprieta readonly per id
        static int _nPolizza; //campo statico per aggiornare l'id
        string _tipo;
        public string Tipo { get=> _tipo; }//proprieta readonly per il tipo
        bool _pagamento;
        public bool Pagamento { get => _pagamento;}
        int _annoValidazione;
        public int AnnoValidazione { get => _annoValidazione;}ù
        int _annoScadenza;
        public int AnnoScadenza { get => _annoScadenza;}

        public Polizza(string tipo, bool pagamento, int annoVal, int annoScadenza, string nome, string cognome)
        {
            _tipo = tipo.ToUpper();
            _annoValidazione = annoVal;
            _annoScadenza = annoScadenza:
            _id = ContaPolizza();
            _pagamento = pagamento;
            PassaNome(nome, cognome);

         }

        private void PassaNome(nome, cognome)
        {
            Cliente $"{nome}" = new Cliente(nome, cognome);
        }

        private static int ContaPolizza() => _nPolizza++;

        public override string ToString()
        {
           return $""+
                  $"Id polizza: {_id}\n"+ $"Tipo polizza: {_tipo}\n"+
                  $"Pagamento: {_pagamento}\n"+ $"Anno validazione: {_annoValidazione}\n+$"Anno Scadenza: {_annoScadenza} ";
        }
    }
}

