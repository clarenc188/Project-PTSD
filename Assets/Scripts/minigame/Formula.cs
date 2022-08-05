using System;
using UnityEngine;


namespace PTSD.minigame
{
     [CreateAssetMenu(fileName = "Formula", menuName ="Data/Formulas")]
     public class Formula : ScriptableObject
     {
          public ElementAndQuantity[] formula;

          public int getTotalAtomicNumber()
          {
               int counter = 0;
               for(int i = 0; i < formula.Length; i++)
                    counter += (formula[i].GetElement().getAtomicNumber() * formula[i].getQuantinty());
               
               return counter;
          } 

          public Formula(ElementAndQuantity[] formula)
          {
               this.formula = formula;
          }

     }
}