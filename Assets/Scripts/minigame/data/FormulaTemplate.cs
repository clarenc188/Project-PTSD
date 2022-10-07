using System;
using UnityEngine;


namespace PTSD.minigame.data
{
     [Serializable]
     public class FormulaTemplate
     {

          [SerializeField] private ElementAndQuantity[] formula;
          public int Length => formula.Length;

          public int getTotalAtomicNumber()
          {
               int counter = 0;
               for(int i = 0; i < formula.Length; i++)
                    counter += (formula[i].GetElement().getAtomicNumber() * formula[i].getQuantinty());
               
               return counter;
          }

          public ElementAndQuantity[] getFormula() => formula;

          public void setElementAt(Element element, int index) => 
               formula[index].setElement(element);

    }
}