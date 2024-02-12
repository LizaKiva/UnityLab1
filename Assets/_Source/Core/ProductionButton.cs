using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Source.Core
{
    public class ProductionButton : MonoBehaviour
    {
        [SerializeField] Assets._Source.Core.ProductionBuilding productionBuilding;
        [SerializeField] Assets._Source.Core.GameResource gameResource;
        [SerializeField] Slider progressSlider;
        [SerializeField] Assets._Source.Core.RecourceBank bank;
        [SerializeField] Button button;
        private bool isProducting = false;
        private float time;

        public void Start()
        {
            progressSlider.gameObject.SetActive(false);
            time  = productionBuilding.productionTime;
            Debug.Log("Start: " + time);
        }

        public void StartProduction()
        {
            if (!isProducting)
            {
                isProducting = true;
                button.interactable = false;
                StartCoroutine(ProduceResource());
            }
        }

        IEnumerator ProduceResource()
        {
            float timer = 0f;
            progressSlider.value = 0f;

            progressSlider.gameObject.SetActive(true);

            while (timer < productionBuilding.productionTime)
            {
                timer += Time.deltaTime;    
                progressSlider.value = timer / productionBuilding.productionTime;
                yield return null;
            }

            bank.StartCoroutine(productionBuilding.ProductionResourceCoroutine());
            progressSlider.gameObject.SetActive(false); 
            isProducting = false;
            button.interactable = true;
        }

        public void LvlUp()
        {
            Debug.Log("Click: " + time);
            bank.ChangeRecources(gameResource, 10);
            productionBuilding.productionTime = time * (1f - (float)bank.resources[gameResource].Value / 100f);
        }
    }
}