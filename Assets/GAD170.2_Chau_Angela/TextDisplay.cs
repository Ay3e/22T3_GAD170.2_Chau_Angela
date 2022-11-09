using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace AngelaChau
{
    public class TextDisplay : MonoBehaviour
    {
        //without prefab
        [SerializeField] public string[] species = { "Orange ClownFish", "Blackstorm Clownfish", "Angelfish", "Yellowtang", "Ribbontail Ray", "Salmon", "Great Barracuda", "Yellowfin Tuna", "Goliath Grouper" };
        [SerializeField]private float[] length = {8,8,15,15,70,100,100,200,200};
        [SerializeField]private int[] value = {50,500,20,1500,500,350,4500,28800};
        private int rounds = 10;
        public GameObject textDisplaySpecies;
        void Start()
        {
            textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: " + species[0];
            //if fish is click button add or click buttton release increase count display 
            if(GetComponent<Button>().onClick != null)
            {
                for (int i = 1; i < rounds; i++)
                {
                    textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: " + species[i]; //how to overwrite a text
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
