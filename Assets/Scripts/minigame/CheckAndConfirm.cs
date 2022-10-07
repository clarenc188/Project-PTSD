using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PTSD.minigame.TemplatePrefabSpawner;
using PTSD.minigame.data;
using PTSD.minigame.Components;
using PTSD.minigame.Loaders;

namespace PTSD.minigame
{
    public class CheckAndConfirm : MonoBehaviour
    {
        public Transform FormulaSlot;
        private Formula formula;
        private GameObject[] ObjectList;
        
        void Awake()
        {
            FormulaSlot = GameObject.FindGameObjectWithTag("FormulaSlot")
                            .GetComponent<Transform>();
        }

        private bool Check()
        {
            if(ObjectList.Length == 0 || ObjectList.Length != formula.Length || ObjectList == null)
                return false;
            for(int i = 0; i < ObjectList.Length; i++)
            {
                var Item = ObjectList[i].GetComponent<SlotAndNumberComponents>().GetElementAndQuantity();
                if(!(Item.GetElement() == formula.getFormula()[i].GetElement())
                    && (Item.getQuantinty() == formula.getFormula()[i].getQuantinty()))
                    return false;
            }
            return true;
        }

        public void Confirm()
        {
            ObjectList = FormulaSlot.GetComponent<PrefabParent>().toArray();
            formula = GameObject.FindGameObjectWithTag("MinigameLoader")
                        .GetComponent<MinigameComponents>().getFormula();
            
            if (Check())
                Debug.Log("Yeeee");
            else
                Debug.Log("Nooo");
        }
        
    }
}
