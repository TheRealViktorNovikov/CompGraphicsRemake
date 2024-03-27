using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] ParticleSystem fE_bubbles;
    [SerializeField] ParticleSystem fE_foam;
    [SerializeField] TextMeshProUGUI fireText;
    [SerializeField] ParticleSystem fE_inferno;
    [SerializeField] ParticleSystem fE_infernoAdd;


    private float countdown = 10f;
    private bool fireOut = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButton(0))
        {
            fE_bubbles.enableEmission = true;
            fE_foam.enableEmission = true;
            countdown = countdown - 0.03f;
            if (countdown <= 0  &&  fireOut == false)
            {

                fireText.text = "Fire Has Been Put Out!";
                fireOut = true;
                fE_inferno.enableEmission = false;
                fE_infernoAdd.enableEmission = false;
            }
;

        }
        else
        {
            countdown = 10f;
            fE_bubbles.enableEmission = false;
            fE_foam.enableEmission = false;
        }
    }
}
