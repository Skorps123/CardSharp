using System;
using System.Collections.Generic;

namespace Cards.Core
{
    /// <summary>
    /// Specifies amount of cards. Allows user to draw anad discard.
    /// </summary>
    /// <typeparam name="TCard"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public interface IDeck<TCard, TValue>
        where TCard : ICard<TValue>
        where TValue : struct, Enum
    {
        /// <summary>
        /// Get amount of cards in the deck.
        /// </summary>
        int CardAmount { get; }

        TCard DrawCard();
        //IEnumerable is a list
        IEnumerable<TCard> DrawCard(int amount);

        //out keyword = passed by reference
        bool TryDrawCard(out TCard card);
        bool TryDrawCards(int amount, out IEnumerable<TCard> drawnCards);

        //the following are method prototypes 
        void AddToDiscard(TCard card);
        void AddToDiscard(IEnumerable<TCard> cards);
        void Shuffle();
    }
}