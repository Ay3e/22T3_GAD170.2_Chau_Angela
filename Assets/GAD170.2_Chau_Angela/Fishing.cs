using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace AngelaChau{
    public class Fishing : MonoBehaviour
    {
        [SerializeField] private string[] species = {"Orange ClownFish", "Blackstorm Clownfish", "Angelfish", "Yellowtang", "Ribbontail Ray", "Salmon", "Great Barracuda", "Yellowfin Tuna", "Goliath Grouper" };
        private float length;
        private int value;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //LengthOfSpecies needs to be run every round

        }

        void LengthOfSpecies()
        {
            for(int i=0; i<species.Length; i++) {
                if (species[i] == "Orange ClownFish" || species[i] == "Blackstorm Clownfish")
                {
                    length = 8;
                }
                if (species[i] == "Angelfish" || species[i] == "Yellowtang")
                {
                    length = 15;
                }
                if (species[i] == "Ribbontail Ray")
                {
                    length = 70;
                }
                if (species[i] == "Salmon" || species[i] == "Great Barracuda")
                {
                    length = 100;
                }
                if (species[i] == "Yellowfin Tuna" || species[i] == "GoliathGrouper")
                {
                    length = 200;
                }
            }
        }

        void ValueOfSpecies()
        {
            for (int i = 0; i < species.Length; i++)
            {
                if (species[i] == "Orange ClownFish")
                {
                    value = 50;
                }
                if (species[i] == "Blackstorm Clownfish")
                {
                    value = 500;
                }
                if (species[i] == "Angelfish")
                {
                    value = 20;
                }
                if (species[i] == "Yellowtang")
                {
                    value = 80;
                }
                if (species[i] == "Ribbontail Ray")
                {
                    value = 1500;
                }
                if (species[i] == "Salmon")
                {
                    value = 500;
                }
                if (species[i] == "Great Barracuda")
                {
                    value = 350;
                }
                if (species[i] == "Yellowfin Tuna")
                {
                    value = 4500;
                }
                if (species[i] == "Goliath Grouper")
                {
                    value = 28800;
                }
            }
        }
    }
}

