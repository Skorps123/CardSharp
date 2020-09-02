﻿using System;

namespace Cards.Core
{
    /// <summary>
    /// Defines a card with <typeparamref name="TValue" /> as value type and <typeparamref name="TGroup" /> as grouping type.
    /// </summary>
    /// <typeparam name="TValue"> The underlying enumeration used for the card's value.</typeparam>
    /// <typeparam name="TGroup"> The underlying enumeration used for the card's grouping.</typeparam>
    public interface IGroupedCard<TValue, TGroup> : ICard<TValue>
        where TValue : struct, Enum
        where TGroup : struct, Enum
    {
        /// <summary>
        /// Retrieves the grouping of the card as <typeparamref name="TGroup"/>.
        /// </summary>
        TGroup CardGroup { get; }
    }
}