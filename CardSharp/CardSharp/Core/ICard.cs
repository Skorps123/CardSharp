using System;

namespace Cards.Core
{
    /// <summary>
    /// Defines a structure for a card with <typeparamref name="TValue"/> as underlying type.
    /// </summary>
    /// <typeparam name="TValue"> The underlying enumeration used for the card's value.</typeparam>
    public interface ICard<TValue>
        where TValue : struct, Enum
    {
        /// <summary>
        /// Retrieves the value of the card as <typeparamref name="TValue"/>.
        /// </summary>
        TValue CardValue { get; }
    }
}