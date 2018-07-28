﻿using Nashet.UnityUIUtils;
using UnityEngine;
using UnityEngine.UI;

namespace Nashet.EconomicSimulation
{
    public class LoadingPanel : Hideable
    {
        [SerializeField]
        private Text loadingText;

        [SerializeField]
        private GameObject mapOptionsWindowPrefab;

        // Use this for initialization
        private void Start()
        {
            MainCamera.loadingPanel = this;
            var window = Instantiate(mapOptionsWindowPrefab, transform.parent);
        }

        public void updateStatus(string text)
        {
            loadingText.text = text;
        }
    }
}