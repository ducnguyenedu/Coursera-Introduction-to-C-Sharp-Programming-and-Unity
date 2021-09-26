using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using ConsoleCards;


namespace ProgrammingAssignment2

{

    // IMPORTANT: Only add code in the section

    // indicated below. The code I've provided

    // makes your solution work with the

    // automated grader on Coursera

    /// <summary>

    /// Programming Assignment 2

    /// </summary>

    class Program

    {

        /// <summary>

        /// Implements Nothing Like Blackjack functionality

        /// </summary>

        /// <param name="args">command-line args</param>

        static void Main(string[] args)

        {

            // loop while there's more input

            string input = Console.ReadLine();

            while (input[0] != 'q')

            {

                // Add your code between this comment

                // and the comment below. You can of

                // course add more space between the

                // comments as needed

                // declare a deck variables and create a deck object

                // DON'T SHUFFLE THE DECK

                Deck deck = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing

                // the first card to each player before dealing the

                // second card to each player)

                Card index11 = deck.TakeTopCard();

                Card index21 = deck.TakeTopCard();

                Card index31 = deck.TakeTopCard();

                Card index41 = deck.TakeTopCard();

                Card index12 = deck.TakeTopCard();

                Card index22 = deck.TakeTopCard();

                Card index32 = deck.TakeTopCard();

                Card index42 = deck.TakeTopCard();

                // deal 1 more card to players 2 and 3

                Card index23 = deck.TakeTopCard();

                Card index33 = deck.TakeTopCard();

                // flip all the cards over

                index11.FlipOver();

                index12.FlipOver();

                index21.FlipOver();

                index22.FlipOver();

                index23.FlipOver();

                index31.FlipOver();

                index32.FlipOver();

                index33.FlipOver();

                index41.FlipOver();

                index42.FlipOver();

                // print the cards for player 1

                Console.WriteLine(index11.Rank + "," + index11.Suit);

                Console.WriteLine(index12.Rank + "," + index12.Suit);

                // print the cards for player 2

                Console.WriteLine(index21.Rank + "," + index21.Suit);

                Console.WriteLine(index22.Rank + "," + index22.Suit);

                Console.WriteLine(index23.Rank + "," + index23.Suit);

                // print the cards for player 3

                Console.WriteLine(index31.Rank + "," + index31.Suit);

                Console.WriteLine(index32.Rank + "," + index32.Suit);

                Console.WriteLine(index33.Rank + "," + index33.Suit);

                // print the cards for player 4

                Console.WriteLine(index41.Rank + "," + index41.Suit);

                Console.WriteLine(index42.Rank + "," + index42.Suit);

                // Don't add or modify any code below

                // this comment

                input = Console.ReadLine();

            }

        }

    }

}