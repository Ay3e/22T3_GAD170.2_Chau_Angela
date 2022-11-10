using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//allows you to make changes to the UI
using UnityEngine.UI;
namespace AngelaChau
{
    public class TextDisplay : MonoBehaviour
    {
        //UI Text GameObjects
        public GameObject textDisplaySpecies;
        public GameObject textDisplayLength;
        public GameObject textDisplayValue;

        //GameVariables for text changes
        [SerializeField]private string[] species = { "ORANGE CLOWNFISH", "BLACKSTORM CLOWNFISH", "YELLOWTAIL PIKE", "ANGELFISH", "YELLOWTANG", "RIBBONTAIL RAY", "SALMON", "GREAT BARRACUDA", "YELLOWFIN TUNA", "GOLIATH GROUPER" };
        [SerializeField]private float[] length = {8,8,150,15,15,70,100,100,200,200};
        [SerializeField]private int[] value = {50,500,150,20,80,1500,500,350,4500,9000};

        //GameVariables for rounds
        private int roundCounter = 0;

        void Update()
        {
            //changes text every frame
            ChangeText();
        }

        public void CatchAnotherFIsh()
        {
            //Counts buttons pressed
            roundCounter++;
        }

        public void ChangeText()
        {
            textDisplaySpecies.GetComponent<Text>().text = "FISH SPECIES: " + species[roundCounter];
            textDisplayLength.GetComponent<Text>().text = "FISH LENGTH: " + length[roundCounter] + "cm";
            textDisplayValue.GetComponent<Text>().text = "FISH VALUE: $" + value[roundCounter];
        }
    }
}
