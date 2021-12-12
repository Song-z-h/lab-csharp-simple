using System;

namespace Properties
{
    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            Name = name;
            Ordinal = ordinal;
            Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3) 
        {
        }

        public string Seed{ get; }
        public string Name { get; }
        public int Ordinal { get; }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString() => $"{GetType().Name}(Name={Name}, Seed={Seed}, Ordinal={Ordinal})";

        protected bool Equals(Card other)
        {
            return Seed == other.Seed && Name == other.Name && Ordinal == other.Ordinal;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Card) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Seed, Name, Ordinal);
        }
    }
}
