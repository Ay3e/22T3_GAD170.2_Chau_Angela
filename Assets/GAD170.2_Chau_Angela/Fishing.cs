using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace AngelaChau
{
    public class Fishing : MonoBehaviour
    {
        //UI Text GameObjects
        public GameObject textDisplaySpecies;
        public GameObject textDisplayLength;
        public GameObject textDisplayValue;

        //GameVariables for text changes
        [SerializeField] private string[] species = { "ORANGE CLOWNFISH", "BLACKSTORM CLOWNFISH", "ANGELFISH", "YELLOWTANG", "RIBBONTAIL RAY", "SALMON", "GREAT BARRACUDA", "YELLOWFIN TUNA", "GOLIATH GROUPER" };
        [SerializeField] private float[] length = { 8, 8, 15, 15, 70, 100, 100, 200, 200 };
        [SerializeField] private int[] value = { 50, 500, 20, 1500, 500, 350, 4500, 9000 };
        //GameVariables for rounds
        private int roundCounter = 0;
        private int maxRound = 10;
        //GameVariables for Aquarium Value
        [SerializeField] public int aquariumValue;


        void Update()
        {
            textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: " + species[roundCounter];
            textDisplayLength.GetComponent<Text>().text = "FISH LENGTH: " + length[roundCounter] + "cm";
            textDisplayValue.GetComponent<Text>().text = "FISH VALUE: $" + value[roundCounter];

        }

        public void CatchAnotherFIsh()
        {
            roundCounter++;
        }

        public void CheckIfFishIsEaten()
        {
            for (int i = 1; i < maxRound; i++)
            {
                if (length[i] >= length[i - 1] * 2)
                {
                    aquariumValue = -value[i - 1] + value[i];
                }
                else
                {
                    aquariumValue = aquariumValue + value[i];
                }
            }
        }
    }
}
