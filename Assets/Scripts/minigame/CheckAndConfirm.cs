using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PTSD.minigame.TemplatePrefabSpawner;
using PTSD.minigame.data;
using PTSD.minigame.Components;

namespace PTSD.minigame
{
    public class CheckAndConfirm : MonoBehaviour
    {
        public Transform FormulaSlot;
        private MinigameData minigamedata;
        private GameObject[] ObjectList;
        
        void Awake()
        {
            FormulaSlot = GameObject.FindGameObjectWithTag("FormulaSlot")
                            .GetComponent<Transform>();
        }

        private bool Check()
        {
            if(ObjectList.Length == 0 || ObjectList.Length != minigamedata.Length || ObjectList == null)
                return false;
            for(int i = 0; i < ObjectList.Length; i++)
            {
                var Item = ObjectList[i].GetComponent<SlotAndNumberComponents>().GetElementAndQuantity();
                if(!(Item.GetElement() == minigamedata.getFormula()[i].GetElement())
                    && (Item.getQuantinty() == minigamedata.getFormula()[i].getQuantinty()))
                    return false;
            }
            return true;
        }

        public void Confirm()
        {
            ObjectList = FormulaSlot.GetComponent<FormulaAreaParent>().toArray();
            minigamedata = MinigameManager.getData();
            
            if (Check())
                Debug.Log("Yeeee");
            else
                Debug.Log("Nooo");
        }
        
    }
}
