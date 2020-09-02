using System;
using System.Collections.Generic;
using System.Text;
using Cards.Core;

namespace Cards
{
    public class PlayingCardDeck : PlayingCardDeck<StandardSuits> { }

    public class PlayingCardDeck<TSuit> : IGroupedDeck<PlayingCard<TSuit>, TSuit, PlayingCardValues>
         where TSuit : struct, Enum
    {
        public int CardAmount => throw new NotImplementedException();

        public PlayingCardDeck()
        {

        }

        public void AddToDiscard(PlayingCard<TSuit> card)
        {
            throw new NotImplementedException();
        }

        public void AddToDiscard(IEnumerable<PlayingCard<TSuit>> cards)
        {
            throw new NotImplementedException();
        }

        public PlayingCard<TSuit> DrawCard()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlayingCard<TSuit>> DrawCard(int amount)
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public bool TryDrawCard(out PlayingCard<TSuit> card)
        {
            throw new NotImplementedException();
        }

        public bool TryDrawCards(int amount, out IEnumerable<PlayingCard<TSuit>> drawnCards)
        {
            throw new NotImplementedException();
        }
    }
}