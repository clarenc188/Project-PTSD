using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using PTSD.minigame.data;
using TMPro;

namespace PTSD.minigame.Components
{
    public class ElementComponents : MonoBehaviour
    {

        [SerializeField] private Element element;
        private TextMeshProUGUI AtomicNumber;
        private TextMeshProUGUI Symbol;
        [SerializeField] private Image BackGround;
        [SerializeField] private Image Border;
        private RectTransform elementTransform;

        void Awake()
        {
            elementTransform = GetComponent<RectTransform>();
            AtomicNumber = transform.Find("AtomicNumber").GetComponent<TextMeshProUGUI>();
            Symbol = transform.Find("Symbol").GetComponent<TextMeshProUGUI>();
        }

        public RectTransform getElementTransform() => elementTransform;

        public TextMeshProUGUI getAtomicNumber() => AtomicNumber;

        public TextMeshProUGUI getSymbol() => Symbol;
        
        public Element getElement() => element;

        public Image getBackGround() => BackGround;

        public Image getBorder() => Border;
    }
}