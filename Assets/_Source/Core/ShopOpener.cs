using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.Core
{
    public class ShopOpener : MonoBehaviour
    {
        [SerializeField]
        private GameObject shop;
    
        private Button _button;

        public void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnClick);
            shop.SetActive(false);
        }

        private void OnClick()
        {
            shop.SetActive(!shop.activeSelf);   
        }
    }
}
