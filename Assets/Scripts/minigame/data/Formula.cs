using System;
using UnityEngine;


namespace PTSD.minigame.data
{
     [CreateAssetMenu(fileName = "Formula", menuName ="Data/Formulas")]
     public class Formula : ScriptableObject
     {
          [SerializeField] private ElementAndQuantity[] formula;

          [SerializeField] private FormulaTemplate[] TemplateFormulas;

          public int Length => formula.Length;

          public int getTotalAtomicNumber()
          {
               int counter = 0;
               for(int i = 0; i < formula.Length; i++)
                    counter += (formula[i].GetElement().getAtomicNumber() * formula[i].getQuantinty());
               
               return counter;
          }

          public ElementAndQuantity[] getFormula() => formula;

          public FormulaTemplate[] getTemplateFormulas() => TemplateFormulas;

     }
}