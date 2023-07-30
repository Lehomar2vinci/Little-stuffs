using System;
using System.Collections.Generic;

namespace CouperFoutre
{
    class NameGenerator
    {
        private Random rand = new Random();
        private List<string> nameListOne = new List<string>()
        { "un colibri", "des arbres", "macron", "une orange", "une serviette", "du chocolat", "Hervé" };

        private List<string> nameListTwo = new List<string>()
        { "une louche", "un enfant", "une chaleur etouffante", "une bananer", "du riz" };

        public string GetRandomFirstName()
        {
            int randomIndex = rand.Next(nameListOne.Count);
            return nameListOne[randomIndex];
        }

        public string GetRandomLastName()
        {
            int randomIndex = rand.Next(nameListTwo.Count);
            return nameListTwo[randomIndex];
        }
    }
}