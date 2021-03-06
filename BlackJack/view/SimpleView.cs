﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
  class SimpleView : IView
  {

    private view.SimpleRuleTypePrinter m_rulePrinter;
    private model.rules.IAbstractRulesFactory m_rules;

    public SimpleView(model.rules.IAbstractRulesFactory a_rules)
    {
      m_rulePrinter = new view.SimpleRuleTypePrinter();
      m_rules = a_rules;
    }
    public void DisplayWelcomeMessage()
    {
      System.Console.Clear();
      System.Console.WriteLine("Hello Black Jack World");
      m_rules.Accept(m_rulePrinter);
      System.Console.WriteLine("Type 'p' to Play, 'h' to Hit, 's' to Stand or 'q' to Quit\n");
    }

    public Input GetInput()
    {
      switch (System.Console.ReadKey().KeyChar)
      {
        case 'p': return Input.PlayGame;
        case 'h': return Input.Hit;
        case 's': return Input.Stand;
        case 'q': return Input.Quit;
        default: return Input.None;
      }
    }

    public void DisplayCard(model.Card a_card)
    {
      System.Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());
    }

    public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
    {
      DisplayHand("Player", a_hand, a_score);
    }

    public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
    {
      DisplayHand("Dealer", a_hand, a_score);
    }

    private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
    {
      System.Console.WriteLine("{0} Has: ", a_name);
      foreach (model.Card c in a_hand)
      {
        DisplayCard(c);
      }
      System.Console.WriteLine("Score: {0}", a_score);
      System.Console.WriteLine("");
    }

    public void DisplayGameOver(bool a_dealerIsWinner)
    {
      System.Console.Write("GameOver: ");
      if (a_dealerIsWinner)
      {
        System.Console.WriteLine("Dealer Won!");
      }
      else
      {
        System.Console.WriteLine("You Won!");
      }

    }
  }
}
