using System;
using System.Collections;
using UnityEngine;
using PTSD.minigame.Components;

namespace PTSD.minigame.Loaders
{
    public class TemplateLoader : MonoBehaviour
    {
        private TemplateComponents components;
                
        void Start()
        {
            components = GetComponent<TemplateComponents>();

            components.getText().text = "";
            char placeholder = 'A';
            
            if (components.getTemplate() != null)
            {
                for (int i = 0; i < components.getTemplate().Length; i++, placeholder++)
                    components.getText().text += $"{placeholder}{components.getTemplate().getFormula()[i].getQuantinty()}";
            }
        }
    }


}
