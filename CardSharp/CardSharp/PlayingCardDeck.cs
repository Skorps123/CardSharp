using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cards.Core;

namespace Cards
{
    public class PlayingCardDeck : PlayingCardDeck<StandardSuits>
    {
        public PlayingCardDeck(int setsInDeck, int jokerPerSet, Random? random = null) : base(setsInDeck, jokerPerSet, random)
        {
        }
    }

    public class PlayingCardDeck<TSuit> : IGroupedDeck<PlayingCard<TSuit>, TSuit, PlayingCardValues>
         where TSuit : struct, Enum
    {
        private readonly Random rng;
        private readonly Stack<PlayingCard<TSuit>> dealPile;
        private readonly List<PlayingCard<TSuit>> discardPile;

 
        /// <inheritdoc/>
        public int CardAmount { get; }
 
        public PlayingCardDeck(int setsInDeck, int jokerPerSet, Random? random = null)
        {
            rng = random ?? new Random();
            const int suitedCardsInSet = 52;
            CardAmount = (suitedCardsInSet + jokerPerSet) * setsInDeck;


            dealPile = new Stack<PlayingCard<TSuit>>(CardAmount);
            discardPile = new List<PlayingCard<TSuit>>(CardAmount);
            //TO DO:
            //-ADD CARDS TO DISCARD PILE
            //-SHUFFLE CARDS IN DISCARD AND REDEAL THEM
            //-ADD CARDS DEAL PILE
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