using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace AngelaChau

{
    public enum Species { Undefined, OrangeClownFish, BlackStormClownFish, AngelFish, YellowTang, RibbonTailRay, Salmon, GreatBarracuda, YellowFinTuna, GoliathGrouper }
    
    public class SpeciesList : MonoBehaviour
    {
        [SerializeField] private Species chosenSpecies = Species.Undefined;
        [SerializeField] private float length;
        [SerializeField] private int value;

        public GameObject textDisplaySpecies;
        public GameObject textDisplayLength;
        public GameObject textDisplayValue;

        public void Initialise()
        {
            switch (chosenSpecies)
            {
                case Species.Undefined:
                    break;
                case Species.OrangeClownFish:
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: ORANGE CLOWNFISH";
                    Debug.Log("welcome");
                    //size: 8cm cost: 50
                    break;
                case Species.BlackStormClownFish:
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: BLACKSTORM CLOWNFISH";
                    //8cm cost: 500
                    break;
                case Species.AngelFish:
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: ANGELFISH";
                    //size: 15cm cost: 20
                    break;
                case Species.YellowTang:
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: YELLOWTANG";
                    //size: 15cm cost: 80
                    break;
                case Species.RibbonTailRay:
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: RIBBONTAIL RAY";
                    //size: 70cm cost: 1,500
                    break;
                case Species.Salmon:
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: SALMON";
                    //size: 1m cost: 500
                    break;
                case Species.GreatBarracuda:
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: GREAT BARRACUDA";
                    //size: 1m cost: 350
                    break;
                case Species.YellowFinTuna:
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: YELLOWFIN TUNA";
                    //size: 2m cost: 4,500
                    break;
                case Species.GoliathGrouper:
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: GOLIATH GROUPER";
                    //size: 2m cost: 28,800
                    break;
                default:
                    break;
            }
        }

        private void SetupSpecies(float newLength,
                                  int newValue)
        {
            length = newLength;
            value = newValue;
        }
    }
}
