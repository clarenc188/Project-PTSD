using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using PTSD.minigame.data;

namespace PTSD.minigame.Components
{
    public class SlotAndNumberComponents : MonoBehaviour
    {
        private Transform Slot;    
        private TextMeshProUGUI Number;
        private ElementAndQuantity ElementQuantity;

        void OnEnable()
        {
            Slot = transform.Find("Slot");
            Number = GetComponentInChildren<TextMeshProUGUI>();
            ElementQuantity = new ElementAndQuantity();
        }

        public void setQuantity(int quantity)
        {
            ElementQuantity.setQuantity(quantity);
            Number.SetText(quantity.ToString());
        }

        public ElementAndQuantity GetElementAndQuantity() => ElementQuantity;
    }
}