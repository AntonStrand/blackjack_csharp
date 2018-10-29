namespace BlackJack.model.rules
{
  class AmericanRulesFactory : IAbstractRulesFactory
  {
    public IHitStrategy GetHitRule()
    {
      return new BasicHitStrategy();
    }

    public INewGameStrategy GetNewGameRule()
    {
      return new AmericanNewGameStrategy();
    }

    public IWinStrategy GetWinRule()
    {
      return new DealerWinOnEqualStrategy();
    }
  }
}
