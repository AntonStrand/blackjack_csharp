namespace BlackJack.model.rules
{
  interface IWinStrategy
  {
    bool IsDealerWinner(Dealer a_dealer, Player a_player, int a_maxScore);
  }
}