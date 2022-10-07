using PTSD.minigame.Components;
using UnityEngine;

namespace PTSD.minigame.Loaders
{
     public class MinigameLoader : MonoBehaviour
    {
        private MinigameComponents components;

        void Start()
        {
            components = GetComponent<MinigameComponents>();
            components.getAtomicNumber().text = $"{components.getFormula().getTotalAtomicNumber()}";

        }
        
    }
}
