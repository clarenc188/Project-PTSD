using UnityEngine;
using UnityEngine.EventSystems;
using PTSD.minigame.Components;

namespace PTSD.minigame.DragAndDrop
{
     public class DragController : MonoBehaviour,
                            IBeginDragHandler,
                            IEndDragHandler,
                            IDragHandler
    {

        private Canvas canvas;
        private CanvasGroup CGroup;
        private ElementComponents components;
        private Transform ElementSlot;
        public Transform LastParent { get; set;}

        private void Awake()
        {
            canvas = GetComponentInParent<Canvas>();
            CGroup = GetComponent<CanvasGroup>();
            components = GetComponent<ElementComponents>();
            ElementSlot = transform.parent;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            EnableAndDisableComponents(false);
            LastParent = transform.parent;
            transform.SetParent(transform.parent.parent);
            CGroup.blocksRaycasts = false;
        }


        public void OnDrag(PointerEventData eventData)
        {
            components.getElementTransform()
            .anchoredPosition += eventData.delta / canvas.scaleFactor;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            //if it is't in the Formulas slot slot, re-enable the BG and number
            if (LastParent.tag != "Formula")
                EnableAndDisableComponents(true);

            transform.SetParent(LastParent);
            CGroup.blocksRaycasts = true;

            if(LastParent != ElementSlot)
            {
                LastParent.GetComponentInParent<SlotAndNumberComponents>()
                .GetElementAndQuantity()
                .setElement(GetComponentInChildren<ElementComponents>().getElement());
            }
        }

        public void returnToElementSlot()
        {
            transform.SetParent(ElementSlot);
            EnableAndDisableComponents(true);
        }

        private void EnableAndDisableComponents(bool enabled)
        {
            components.getBorder().enabled = enabled;
            components.getBackGround().enabled = enabled;
            components.getAtomicNumber().enabled = enabled;
        }
    }
}
