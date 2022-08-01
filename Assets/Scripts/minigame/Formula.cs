
using System.Collections.Generic;

namespace PTSD.minigame
{
     public class Formula
     {
          private KeyValuePair<Element, int> formula;

          public Formula(KeyValuePair<Element, int> formula)
          {
               this.formula = formula;
          }

          public bool matches(Formula f2)
          {
               
               return true;
          }
     }
}