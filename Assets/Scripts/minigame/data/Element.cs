using UnityEngine;
using System.Collections.Generic;
using System;

namespace PTSD.minigame.data
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
        Actinoids,
        Alkaline_Earth_Metals,
        Alkali_Metals,
        Halogens,
        Lantanoids,
        Noble_gases,
        Non_Metals,
        Post_Transition_Metals,
        Semi_Metals,
        Transition_Metals,
    }

}
