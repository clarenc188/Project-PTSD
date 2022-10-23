using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PTSD.minigame.data;
using TMPro;

namespace PTSD.minigame.Components
{
    public class TemplateComponents : MonoBehaviour
    {
        [Range(0, 2)]
        [SerializeField] private int ID;
        private FormulaTemplate template;
        private TextMeshProUGUI TextTemplate;

        public void Load()
        {
            template = ((MinigameManager.getData().getTemplateFormulas().Length) > ID) ?
                        MinigameManager.getData().getTemplateFormulas()[ID] : null;
            TextTemplate = GetComponentInChildren<TextMeshProUGUI>();
            
        }

        public void Setup()
        {   
            TextTemplate.text = "";
            char placeholder = 'A';
            
            if (template != null)
            {
                for (int i = 0; i < template.Length; i++, placeholder++)
                    TextTemplate.text += $"{placeholder}{template.getFormula()[i].getQuantinty()}";
            }
        }

        public int getID() => ID;

        public TextMeshProUGUI getText() => TextTemplate;

        public FormulaTemplate getTemplate() => template;

    }
}