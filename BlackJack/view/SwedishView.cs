﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
  class SwedishView : IView
  {
    private view.SimpleRuleTypePrinter m_rulePrinter;
    private model.rules.IAbstractRulesFactory m_rules;

    public SwedishView(model.rules.IAbstractRulesFactory a_rules)
    {
      m_rulePrinter = new view.SimpleRuleTypePrinter();
      m_rules = a_rules;
    }
    public void DisplayWelcomeMessage()
    {
      System.Console.Clear();
      System.Console.WriteLine("Hej Black Jack Världen");
      m_rules.Accept(m_rulePrinter);
      System.Console.WriteLine("----------------------");
      System.Console.WriteLine("Skriv 'p' för att Spela, 'h' för nytt kort, 's' för att stanna 'q' för att avsluta\n");
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
      if (a_card.GetColor() == model.Card.Color.Hidden)
      {
        System.Console.WriteLine("Dolt Kort");
      }
      else
      {
        String[] colors = new String[(int)model.Card.Color.Count]
            { "Hjärter", "Spader", "Ruter", "Klöver" };
        String[] values = new String[(int)model.Card.Value.Count]
            { "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio", "tio", "knekt", "dam", "kung", "ess" };
        System.Console.WriteLine("{0} {1}", colors[(int)a_card.GetColor()], values[(int)a_card.GetValue()]);
      }
    }
    public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
    {
      DisplayHand("Spelare", a_hand, a_score);
    }
    public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
    {
      DisplayHand("Croupier", a_hand, a_score);
    }
    public void DisplayGameOver(bool a_dealerIsWinner)
    {
      System.Console.Write("Slut: ");
      if (a_dealerIsWinner)
      {
        System.Console.WriteLine("Croupiern Vann!");
      }
      else
      {
        System.Console.WriteLine("Du vann!");
      }
    }

    private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
    {
      System.Console.WriteLine("{0} Har: ", a_name);
      foreach (model.Card c in a_hand)
      {
        DisplayCard(c);
      }
      System.Console.WriteLine("Poäng: {0}", a_score);
      System.Console.WriteLine("");
    }
  }
}
