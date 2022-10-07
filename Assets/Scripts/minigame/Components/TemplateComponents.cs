using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PTSD.minigame.data;
using PTSD.minigame.Loaders;
using TMPro;

namespace PTSD.minigame.Components
{
    public class TemplateComponents : MonoBehaviour
    {
        [Range(0, 2)]
        [SerializeField] private int ID;
        private FormulaTemplate template;
        private TextMeshProUGUI TextTemplate;

        void Awake()
        {
            Formula formula = GameObject.FindGameObjectWithTag("MinigameLoader")
                        .GetComponent<MinigameComponents>().getFormula();
                        
            TextTemplate = GetComponentInChildren<TextMeshProUGUI>();
            template = (formula.getTemplateFormulas().Length) > ID ?
                        formula.getTemplateFormulas()[ID] : null;
            
        }

        public TextMeshProUGUI getText() => TextTemplate;

        public FormulaTemplate getTemplate() => template;

    }
}