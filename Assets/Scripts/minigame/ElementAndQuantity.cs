using System;
using UnityEngine;


namespace PTSD.minigame
{
    [Serializable]
    public class ElementAndQuantity
    {
        [SerializeField] private Element element;

        [SerializeField] private int quantity = 1;

        public Element GetElement(){ return element; }

        public int getQuantinty(){ return quantity; }

        public ElementAndQuantity(Element element, int quantity)
        {
            this.element = element;
            this.quantity = quantity;
        }
    }
}

