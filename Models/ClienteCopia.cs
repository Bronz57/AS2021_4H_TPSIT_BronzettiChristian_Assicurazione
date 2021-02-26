using System;

namespace AS2021_4H_TPSIT_BronzettiChristian_assicurazioni.Models
{
    class Cliente:Polizza
    {
        string _nome;
        string _cognome;
        int _id;

        public Cliente(string nome, string cognome)
        {
            this._cognome = cognome;
            this._nome = nome;
            _id = Id;
        }

        public override string ToString()
          => $"Nome: {_nome}\nCognome: {_cognome}";

    }   
}
