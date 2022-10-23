using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace PTSD.minigame.TemplatePrefabSpawner
{
    public class FormulaAreaParent : MonoBehaviour
    {
        private List<GameObject> InstanceList = new List<GameObject>();

        public int Length { get => InstanceList.Count; }
        
        public void addInstance(GameObject slotAndnumber)
        {
            if(slotAndnumber != null)
                InstanceList.Add(slotAndnumber);
        }

        public void removeInstance(GameObject slotAndnumber)
        {
            if(slotAndnumber != null)
                InstanceList.Remove(slotAndnumber);
        }

        public void clearInstanceList() => InstanceList.Clear();

        public GameObject[] toArray()
        {
            if(InstanceList == null) return null;
            else return InstanceList.ToArray();
        }

        public GameObject LastAdded() => InstanceList.Last();

        public List<GameObject>.Enumerator GetEnumerator() => InstanceList.GetEnumerator();

    }
}