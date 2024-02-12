using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Source.Presentation
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] Assets._Source.Core.RecourceBank bank;// = new Assets._Source.Core.RecourceBank();
        private void Awake()
        {
            bank.resources.Add(Assets._Source.Core.GameResource.Humans, new Assets._Source.Core.ObservableInt(10));
            bank.resources.Add(Assets._Source.Core.GameResource.Food, new Assets._Source.Core.ObservableInt(5));
            bank.resources.Add(Assets._Source.Core.GameResource.Wood, new Assets._Source.Core.ObservableInt(5));
            bank.resources.Add(Assets._Source.Core.GameResource.Stone, new Assets._Source.Core.ObservableInt(0));
            bank.resources.Add(Assets._Source.Core.GameResource.Gold, new Assets._Source.Core.ObservableInt(0));
            bank.resources.Add(Assets._Source.Core.GameResource.HumansProdLvl, new Assets._Source.Core.ObservableInt(1));
            bank.resources.Add(Assets._Source.Core.GameResource.FoodProdLvl, new Assets._Source.Core.ObservableInt(1));
            bank.resources.Add(Assets._Source.Core.GameResource.WoodProdLvl, new Assets._Source.Core.ObservableInt(1));
            bank.resources.Add(Assets._Source.Core.GameResource.StoneProdLvl, new Assets._Source.Core.ObservableInt(1));
            bank.resources.Add(Assets._Source.Core.GameResource.GoldProdLvl, new Assets._Source.Core.ObservableInt(1));
        }
    }
}