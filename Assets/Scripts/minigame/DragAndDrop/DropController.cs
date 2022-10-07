using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using PTSD.minigame.Components;

namespace PTSD.minigame.DragAndDrop    
{
    public class DropController : MonoBehaviour, IDropHandler
    {
        private DragController controller;
        public void OnDrop(PointerEventData eventData)
        {
            controller = eventData.pointerDrag.GetComponent<DragController>();

            if (controller != null && 
            ((tag == "ElementSlot") || (tag == "Formula" && transform.childCount < 1)))
                controller.LastParent = transform;
            
        }
    }
}