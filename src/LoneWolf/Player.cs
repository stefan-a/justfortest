using System;
using System.Linq;

namespace LoneWolf
{
    /// <summary>
    /// This class holds information about the player
    /// </summary>
    public class Player
    {
        private const int MaxHealth = 100;

        /// <summary>
        /// Creates a new instance of a player.
        /// </summary>
        /// <param name="name">The name of the player. Must contain at least one letter.</param>
        public Player(string name)
        {
            if (!name.Any() || name.Any(x => !char.IsLetter(x)))
                throw new ArgumentException("Name must contain at least one letter");

            Name = name;
            HealthPoints = MaxHealth;
        }
        
        public string Name { get; }

        /// <summary>
        /// This returns the current number of health points for the player.
        /// </summary>
        public int HealthPoints { get; private set; }
        
        /// <summary>
        /// Player receives damage. This will reduce the <see cref="HealthPoints" />
        /// </summary>
        /// <param name="damagePoints"></param>
        public void ReceiveDamagePoints(int damagePoints)
        {
            HealthPoints -= damagePoints;
        }
    }
}
