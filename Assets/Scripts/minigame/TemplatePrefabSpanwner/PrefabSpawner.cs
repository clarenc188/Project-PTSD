using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using PTSD.minigame.data;
using PTSD.minigame.DragAndDrop;
using PTSD.minigame.Components; 
using System.Linq;

namespace PTSD.minigame.TemplatePrefabSpawner
{
    public class PrefabSpawner : MonoBehaviour
    {
        [SerializeField] public GameObject prefab;
        private FormulaAreaParent InstanceList;
        public Transform FormulaPanel;

        void Awake()
        {
            FormulaPanel = GameObject.FindGameObjectWithTag("FormulaSlot")
                            .GetComponent<Transform>();
            InstanceList = FormulaPanel.GetComponent<FormulaAreaParent>();
        }

        public void InstantiateTemplate()
        {
            FormulaTemplate template = GetComponent<TemplateComponents>().getTemplate();
            hideExistingInstances(InstanceList.Length > 0);
            if((template != null)) 
            {
                for(int i = 0; i < template.Length; i++)
                {
                    InstanceList.addInstance(Instantiate(prefab, FormulaPanel));
                    InstanceList.LastAdded().GetComponent<SlotAndNumberComponents>()
                        .setQuantity(template.getFormula()[i].getQuantinty());
                    
                }

            }

        }

        private void hideExistingInstances(bool condition)
        {
            if(condition)
            {
                foreach(var Instance in InstanceList)
                {
                    if (Instance.GetComponentInChildren<DragController>() != null)
                        Instance.GetComponentInChildren<DragController>().returnToElementSlot();
                    Destroy(Instance);
                }
                InstanceList.clearInstanceList();
            }
        }
        
    }
}