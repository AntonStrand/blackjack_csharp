using BlackJack.model.rules;

namespace BlackJack.view
{
  class SimpleRuleTypePrinter : IRuleVisitor
  {
    public void VisitInternationalRule(InternationalRulesFactory rule)
    {
      System.Console.WriteLine("You're using international rules.");
    }
    public void VisitAmericanRule(AmericanRulesFactory rule)
    {
      System.Console.WriteLine("You're using american rules.");
    }
  }
}