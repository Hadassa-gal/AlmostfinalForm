using System;
using HexagonalTorneo.Persona.domain;
namespace HexagonalTorneo.Player.domain
{
    public class Player : Person
    {

        public Player(string name, string lastname, int age, string documentNumber, string documentType, string countryOfOrigin) : base(name, lastname, age, documentNumber, documentType, countryOfOrigin)
        {}
    }
}