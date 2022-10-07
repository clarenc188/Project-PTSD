using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PTSD.minigame.data;
using TMPro;


namespace PTSD.minigame.Components
{
    public class MinigameComponents : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI AtomicNumber;
        private Formula formula;

        private Formula[] formulas;

        void Awake()
        {
            formulas = Resources.LoadAll<Formula>("Formulas");
            //formula = formulas[Random.Range(0, formulas.Length)];
            formula = getPermanganato();
            
        }

        public Formula getFormula() => formula;

        public TextMeshProUGUI getAtomicNumber() => AtomicNumber;

        private Formula getPermanganato()
        {
            Formula f = null;

            for (int i = 0; i < formulas.Length; i++)
            {
                if (formulas[i].Length == 3) f = formulas[i];
                    
            }

            return f;
        }

    }
}