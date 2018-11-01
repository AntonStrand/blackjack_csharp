using BlackJack.model.rules;

namespace BlackJack.view
{
  class SwedishRuleTypePrinter : IRuleVisitor
  {
    public void VisitInternationalRule(InternationalRulesFactory rule)
    {
      System.Console.WriteLine("Du använder dig av internationella regler.");
    }
    public void VisitAmericanRule(AmericanRulesFactory rule)
    {
      System.Console.WriteLine("Du använder dig av amerikanska regler.");
    }
  }
}