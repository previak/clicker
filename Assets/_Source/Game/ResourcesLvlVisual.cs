using System.Collections;
using System.Collections.Generic;
using _Source.Core;
using TMPro;
using UnityEngine;

namespace _Source.Game
{
    public class ResourcesLvlVisual : MonoBehaviour
    {
        [SerializeField]
        private GameResource gameResource;
        
        [SerializeField]
        private GameManager gameManager;

        private void Start()
        {
            var bank = gameManager.ResourceBank;

            bank.GetResourceLevel(gameResource).OnValueChanged = value =>
                GetComponent<TMP_Text>().text = "LVL: " + value.ToString();
            
            bank.ChangeResource(gameResource, 0);
        }
    }
}
