using System;
using UnityEngine;


namespace PTSD.minigame.data
{
    [Serializable]
    public class ElementAndQuantity
    {
        [SerializeField] private Element element;

        [SerializeField] protected int quantity = 1;

        public Element GetElement(){ return element; }

        public int getQuantinty(){ return quantity; }

        public void setElement(Element element)
        {
            if (element != null)
                this.element = element;

        }

        public void setQuantity(int quantity)
        {
            if(quantity >= 0)
                this.quantity = quantity;
        }

    }
}

