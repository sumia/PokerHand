namespace PokerHand
{
    public class Card
    {
        private string id;
        private int number;
        private char character;
        public Card(string id)
        {
            this.id = id;

            character = id[^1];
            number = int.Parse(id.Replace(character.ToString(), string.Empty));
        }

        public int GetNumber()
        {
            return number;
        }

        public char GetCharacter()
        {
            return character;
        }
    }
}