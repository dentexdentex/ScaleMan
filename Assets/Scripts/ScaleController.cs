using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class ScaleController : MonoBehaviour
{    

    public Slider slider;
    public Transform characterTransform;
    public float minScale = 0.3f;
    public float maxScale = 5f;

    public float multp;
    private void Start()
    {
        slider.onValueChanged.AddListener(OnSliderValueChanged);
        
    }
    public void OnSliderValueChanged(float value)
    {
        float scale = Mathf.Lerp(minScale, maxScale, value);
        characterTransform.localScale = new Vector3(scale, scale, scale);
        multp=1-slider.value;
    }

 
}
