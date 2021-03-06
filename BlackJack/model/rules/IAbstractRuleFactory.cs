namespace BlackJack.model.rules
{
  interface IAbstractRulesFactory
  {
    IHitStrategy GetHitRule();
    INewGameStrategy GetNewGameRule();
    IWinStrategy GetWinRule();
    void Accept(IRuleVisitor visitor);
  }
}
