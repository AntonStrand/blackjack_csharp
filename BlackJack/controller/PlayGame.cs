using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackJack.view;
using System.Threading;

namespace BlackJack.controller
{
  class PlayGame : model.IObserver
  {
    private const int SHOW_DELAY = 500;
    private model.Game m_game;
    private view.IView m_view;

    public PlayGame(model.Game a_game, view.IView a_view)
    {
      m_game = a_game;
      m_view = a_view;
      m_game.Attach(this);
    }

    public bool Play()
    {
      Update();

      if (m_game.IsGameOver())
      {
        m_view.DisplayGameOver(m_game.IsDealerWinner());
      }

      Input input = m_view.GetInput();

      if (input == Input.PlayGame)
      {
        m_game.NewGame();
      }
      else if (input == Input.Hit)
      {
        m_game.Hit();
      }
      else if (input == Input.Stand)
      {
        m_game.Stand();
      }

      return input != Input.Quit;
    }

    public void Update()
    {
      Thread.Sleep(SHOW_DELAY);
      m_view.DisplayWelcomeMessage();

      m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
      m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());
    }
  }

}
