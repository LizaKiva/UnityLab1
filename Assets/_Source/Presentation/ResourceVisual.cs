using Assets._Source.Core;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Source.Presentation
{
    public class ResourceVisual : MonoBehaviour
    {
        public Assets._Source.Core.GameResource resourceType;
        public Assets._Source.Core.RecourceBank resourceBank;
        public Text text;

        void Start()
        {
            resourceBank = FindAnyObjectByType<Assets._Source.Core.RecourceBank>();
            if (resourceBank != null)
            {
                Assets._Source.Core.ObservableInt resource = resourceBank.GetResource(resourceType);
                resource.PropertyChanged += UpdateTextEvent;
                UpdateText(resource.Value);
    }
        }


        void UpdateTextEvent(object sender, PropertyChangedEventArgs e)
        {
            UpdateText(((ObservableInt)sender).Value);
        }

        void UpdateText(int value)
        {
            text.text = $"{value}";
        }
    }
}
