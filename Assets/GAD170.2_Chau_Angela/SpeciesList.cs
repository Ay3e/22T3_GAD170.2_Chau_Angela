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
                    SetupSpecies(8, 50);
                    Debug.Log("welcome");
                    //size: 8cm cost: 50
                    break;
                case Species.BlackStormClownFish:
                    SetupSpecies(8, 500);
                    //8cm cost: 500
                    break;
                case Species.AngelFish:
                    SetupSpecies(15, 20);
                    //size: 15cm cost: 20
                    break;
                case Species.YellowTang:
                    SetupSpecies(15, 80);
                    //size: 15cm cost: 80
                    break;
                case Species.RibbonTailRay:
                    SetupSpecies(70, 1500);
                    //size: 70cm cost: 1,500
                    break;
                case Species.Salmon:
                    SetupSpecies(100, 500);
                    //size: 1m cost: 500
                    break;
                case Species.GreatBarracuda:
                    SetupSpecies(100, 350);
                    //size: 1m cost: 350
                    break;
                case Species.YellowFinTuna:
                    SetupSpecies(200, 4500);
                    //size: 2m cost: 4,500
                    break;
                case Species.GoliathGrouper:
                    SetupSpecies(200, 9000);
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
