namespace BlackJack.model.rules
{
  class InternationalRulesFactory : IAbstractRulesFactory
  {
    public IHitStrategy GetHitRule()
    {
      return new Soft17HitStrategy();
    }

    public INewGameStrategy GetNewGameRule()
    {
      return new InternationalNewGameStrategy();
    }

    public IWinStrategy GetWinRule()
    {
      return new PlayerWinOnEqualStrategy();
    }
  }
}
