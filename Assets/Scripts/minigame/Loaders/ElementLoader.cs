using System;
using System.Collections.Generic;
using UnityEngine;
using PTSD.minigame.data;

namespace PTSD.minigame.Components
{
    public class ElementLoader : MonoBehaviour
    {
        private ElementComponents components;

        void Start()
        {
            components = GetComponent<ElementComponents>();
            components.getBackGround().color = ElementColor.getColorByType(components.getElement().GetElementType());
            components.getAtomicNumber().text = components.getElement().getAtomicNumber().ToString();
            components.getSymbol().text = components.getElement().getElementName();
        }

    }
}