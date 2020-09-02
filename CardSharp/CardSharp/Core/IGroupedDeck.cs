using System;

namespace Cards.Core
{
    /// <summary>
    /// Declares a deck of <typeparamref name="TCard"/> grouped by <typeparamref name="TGroup"/>.
    /// </summary>
    /// <typeparam name="TCard"></typeparam>
    /// <typeparam name="TGroup"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public interface IGroupedDeck<TCard, TGroup, TValue> : IDeck<TCard, TValue>
        where TCard : IGroupedCard<TValue, TGroup>
        where TValue : struct, Enum
        where TGroup : struct, Enum
    {

    }
}