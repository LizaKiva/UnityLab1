using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Source.Core
{
    public class ProductionBuilding : MonoBehaviour
    {
        public float productionTime;
        [SerializeField] Assets._Source.Core.GameResource resource;

        [SerializeField] Assets._Source.Core.RecourceBank bank;

        public IEnumerator ProductionResourceCoroutine()
        {
            bank.ChangeRecources(resource, 1);
            yield return new WaitForSeconds(productionTime);
        }
    }
}