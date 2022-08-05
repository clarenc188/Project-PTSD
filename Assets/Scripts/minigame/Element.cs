using UnityEngine;

namespace PTSD.minigame
{
    [CreateAssetMenu(fileName = "Element", menuName ="Data/Elements")]
    public class Element : ScriptableObject
    {
        [SerializeField] private string elementName = null;
        [SerializeField] private int atomicNumber = 0;
        [SerializeField] private ElementType type = 0;

        public string getElementName(){ return elementName; }
        
        public int getAtomicNumber(){ return atomicNumber; }

        public ElementType GetElementType(){ return type; }
    }

    public enum ElementType
    {
        Metals,
        Non_Metals,
        Semi_Metals,
        Alkali_Metals,
        Alkaline_Earth_Metals,
        Lantanoids,
        Actinoids,
        Transition_Metals,
        d_Block_Metals,
        Halogens,
        Noble_gases
    }
}
