using System;
using Cards.Core;

namespace Cards
{
    public class PlayingCard<TSuit> : IGroupedCard<PlayingCardValues, TSuit>
        where TSuit : struct, Enum

    {
        /// <summary>
        /// Recieves card suit.
        /// </summary>
        public TSuit CardSuit { get; }
        /// <summary>
        /// Recieves card value.
        /// </summary>
        public PlayingCardValues CardValue { get; }

        /// <summary>
        /// Created a playing card with the given suit and value.
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="value"></param>
        public PlayingCard(TSuit suit, PlayingCardValues value)
        {
            CardSuit = suit;
            CardValue = value;
        }

        public override string ToString() =>
            $"{CardValue} of {CardSuit}";

        TSuit IGroupedCard<PlayingCardValues, TSuit>.CardGroup => CardSuit;
    }
}