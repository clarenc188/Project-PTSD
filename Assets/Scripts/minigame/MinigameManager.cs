using UnityEngine;
using TMPro;
using PTSD.minigame.Components;
using PTSD.minigame.data;

namespace PTSD.minigame
{
     public class MinigameManager : MonoBehaviour
    {
        private static MinigameData data;

        [SerializeField] private TextMeshProUGUI gameatomicnumber;
        [SerializeField] private TemplateComponents templatecomponents0;
        [SerializeField] private TemplateComponents templatecomponents1;
        [SerializeField] private TemplateComponents templatecomponents2;
        [SerializeField] private CheckAndConfirm checkbutton;
        
        void Awake()
        {
            MinigameData[] dataarray = Resources.LoadAll<MinigameData>("Formulas");
            //data = dataarray[Random.Range(0, dataarray.Length)];
            data = getPermanganato(dataarray);

            //assegna ad ogni bottone il proprio template
            templatecomponents0.Load();
            templatecomponents1.Load();
            templatecomponents2.Load();
            
        }

        void Start()
        {
            //inizializza i bottoni template
            templatecomponents0.Setup();
            templatecomponents1.Setup();
            templatecomponents2.Setup();

            gameatomicnumber.text = $"{data.getTotalAtomicNumber()}";
        }

        public static MinigameData getData() => data;

        private MinigameData getPermanganato(MinigameData[] formulas)
        {
            MinigameData f = null;

            for (int i = 0; i < formulas.Length; i++)
            {
                if (formulas[i].Length == 3) f = formulas[i];
                    
            }

            return f;
        }
        
    }
}
