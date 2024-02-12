using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using UnityEngine;

namespace Assets._Source.Core
{
    public class RecourceBank : MonoBehaviour
    {
        public Dictionary<Assets._Source.Core.GameResource, ObservableInt> resources = new Dictionary<Assets._Source.Core.GameResource, ObservableInt>();

        public void ChangeRecources(Assets._Source.Core.GameResource resource, int value)
        {
            resources[resource].Value += value;
        }

        public ObservableInt GetResource(Assets._Source.Core.GameResource resource)
        {
            return resources[resource];
        }
    }
}