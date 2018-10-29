﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
  class Game
  {
    private model.Dealer m_dealer;
    private model.Player m_player;

    public Game(rules.IAbstractRulesFactory rules)
    {
      m_dealer = new Dealer(rules);
      m_player = new Player();
    }

    public void Attach(IObserver a_observer)
    {
      m_dealer.Attach(a_observer);
      m_player.Attach(a_observer);
    }

    public bool IsGameOver()
    {
      return m_dealer.IsGameOver();
    }

    public bool IsDealerWinner()
    {
      return m_dealer.IsDealerWinner(m_player);
    }

    public bool NewGame()
    {
      return m_dealer.NewGame(m_player);
    }

    public bool Hit()
    {
      return m_dealer.Hit(m_player);
    }

    public bool Stand()
    {
      return m_dealer.Stand();
    }

    public IEnumerable<Card> GetDealerHand()
    {
      return m_dealer.GetHand();
    }

    public IEnumerable<Card> GetPlayerHand()
    {
      return m_player.GetHand();
    }

    public int GetDealerScore()
    {
      return m_dealer.CalcScore();
    }

    public int GetPlayerScore()
    {
      return m_player.CalcScore();
    }
  }
}
