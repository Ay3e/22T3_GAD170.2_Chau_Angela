using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace AngelaChau
{
    public class TextDisplay : MonoBehaviour
    {
        public GameObject textDisplay;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            textDisplay.GetComponent<Text>().text = "FISH SPECIES: TUNA";
        }
    }
}
