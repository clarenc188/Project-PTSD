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
        [SerializeField] private TextMeshProUGUI AtomicNumber;
        [SerializeField] private TextMeshProUGUI Symbol;
        [SerializeField] private Image BackGround;
        [SerializeField] private Image Border;
        private RectTransform elementTransform;

        void Awake()
        {
            elementTransform = GetComponent<RectTransform>();
        }

        public RectTransform getElementTransform() => elementTransform;

        public TextMeshProUGUI getAtomicNumber() => AtomicNumber;

        public TextMeshProUGUI getSymbol() => Symbol;
        
        public Element getElement() => element;

        public Image getBackGround() => BackGround;

        public Image getBorder() => Border;
    }
}