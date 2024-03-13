using _Source.Core;
using UnityEngine;
using TMPro;

namespace _Source.Game
{
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField]
        private GameResource gameResource;
        
        [SerializeField]
        private GameManager gameManager;

        private void Start()
        {
            var bank = gameManager.ResourceBank;

            bank.GetResource(gameResource).OnValueChanged = value =>
                GetComponent<TMP_Text>().text = value.ToString();
            
            bank.ChangeResource(gameResource, 0);
        }
    }
}
