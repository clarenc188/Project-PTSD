namespace PTSD.minigame
{
    public class Element
    {
        public string elementName { get; private set; }
        public int atomicNumber { get; private set; }
        public ElementType type { get; private set; }


        public Element(string element, int atomicNumber, ElementType type)
        {
            elementName = element;
            this.atomicNumber = atomicNumber;
            this.type = type;
        }
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
        P_Block_Metals,
        Halogens,
        Noble_gases
    }
}
