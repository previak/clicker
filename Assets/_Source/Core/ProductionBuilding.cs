using System.Collections;
using System.Collections.Generic;
using _Source.Core;
using UnityEngine;
using UnityEngine.UI;

public class ProductionBuilding : MonoBehaviour
{
    [SerializeField]
    private GameResource gameResource;
        
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private float productionTime;

    private Button _button;
    private Slider _slider;
    private ResourceBank _resourceBank;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
        _slider = GetComponentInChildren<Slider>();
        _resourceBank = gameManager.ResourceBank;
    }
    
    public void OnClick()
    {
        _button.interactable = false;
        _slider.value = 0;
        StartCoroutine(ResourceProduction());
    }

    // ReSharper disable Unity.PerformanceAnalysis
    IEnumerator ResourceProduction()
    {
        float timer = 0;
        while (timer < productionTime)
        {
            timer += Time.deltaTime;
            _slider.value = timer / productionTime;
            yield return null;
        }
        _resourceBank.ChangeResource(gameResource, 1);
        _slider.value = 0;
        _button.interactable = true;
    }
}
