﻿namespace DieRoller
{
	/// <summary>
	/// Represents a single six sided die (1 - 6)
	/// </summary>
	public class Die
	{
		/// <summary>
		/// Creates the die and rolls it to start with a random numver
		/// </summary>
		public Die()
		{
			Roll();
		}
		/// <summary>
		/// The Current Face up value of the die
		/// </summary>
		public byte FaceValue { get; private set; }
		
		/// <summary>
		/// True if the die is currently held
		/// </summary>
		public bool IsHeld { get; set; }

		/// <summary>
		/// Rolls the die and sets the <see cref="FaceValue"/>
		/// to the new number. Returns the new number
		/// </summary>
		/// <returns>Returns the new random number</returns>
		public byte Roll()
		{
			//Generate random number
			Random random= new();
			byte newValue = (byte)random.Next(1, 7);

			FaceValue = newValue;

			return FaceValue;
		}
	}
}
