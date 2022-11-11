using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AngelaChau
{
    public class TotalScore : MonoBehaviour
    {
        //UI Text GameObjects
        public GameObject textDisplayAquariumValue;

        //GameVariables
        private float[] length = { 0, 8, 8, 150, 15, 15, 70, 100, 100, 200, 200 };
        private int[] value = { 0, 50, 500, 150, 20, 80, 1500, 500, 350, 4500, 9000 };

        private int aquariumValue = 0;
        private int roundCounter = 0;
        private int previousFishAdded = 1;

        private int restartGame = 11;

        private void Update()
        {
            RestartGame();
            //change the text for Aquarium Value
            textDisplayAquariumValue.GetComponent<Text>().text = "AQUARIUM VALUE: $" + aquariumValue;
            //Allowed user to test if aquarium value work in the console
            
        }

        public void ButtonPressedAdd()
        {
            //only happens when button add is pressed starting from 0
            roundCounter++;
            //checks if its the first round
            if (roundCounter == 1)
            {
                aquariumValue = value[roundCounter];
            }
            //if its not the first round and fishes are added then check if pervious fish
            else if(length[roundCounter]>=(length[roundCounter-previousFishAdded])*2)
            {
                aquariumValue = aquariumValue - value[roundCounter - previousFishAdded];
                aquariumValue = aquariumValue+value[roundCounter];
            }
            else
            //if fish is not eaten add to aquarium value
            {
                aquariumValue = aquariumValue + value[roundCounter];
            }
        }

        public void ButtonPressedRelease()
        {
            roundCounter++;
            //Allows you to find previous fish added from the array
            previousFishAdded++;
        }
        public void RestartGame()
        {
            if (roundCounter == restartGame)
            {
                aquariumValue = 0;
                roundCounter = 0;
                previousFishAdded = 1;

            }
        }
    }
}

