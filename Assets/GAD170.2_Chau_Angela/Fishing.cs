using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AngelaChau
{

    public class Fishing : MonoBehaviour
    {
        [SerializeField] private List<SpeciesList> speciesList = new List<SpeciesList>();
        private void Start()
        {
            for (int i = 0; i < speciesList.Count; i++)
            {
                speciesList[i].Initialise();
            }
        }
    }
}