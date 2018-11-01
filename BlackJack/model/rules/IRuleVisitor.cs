namespace BlackJack.model.rules
{
  interface IRuleVisitor
  {
    void VisitInternationalRule(InternationalRulesFactory rule);
    void VisitAmericanRule(AmericanRulesFactory rule);
  }
}