using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AngelaChau

{
    enum Species { OrangeClownFish, BlackStormClownFish, AngelFish, YellowTang, RibbonTailRay, Salmon, GreatBarracuda, YellowFinTuna, GoliathGrouper }
    public class SpeciesList : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Species speciesPrefab;

        [Header("Size")]
        [SerializeField] private List<Species> species;

        [SerializeField] private float[] size = new float[9] { 8f, 8f, 15f, 15f, 70f, 100f, 100f, 200f, 200f };

        // Start is called before the first frame update
        void Start()
        {
            foreach (Species s in species)
            {
                foreach (float f in size)
                {
                    Instantiate(speciesPrefab, )
                }
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
