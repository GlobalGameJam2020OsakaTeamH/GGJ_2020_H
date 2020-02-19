using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleButtons : MonoBehaviour
{
    public float CooldownDuration = .2f;
    private float cooldown = 0f;
    private UIActivator currentActivator;
    private void OnEnable()
    {
        if (!currentActivator)
            currentActivator = GetComponentInChildren<UIActivator>();
        if (currentActivator.AppearanceChanger == null)
        {
            currentActivator.AppearanceChanger = currentActivator.GetComponent<UIAppearanceChanger>();
        }
        currentActivator.AppearanceChanger.SetActive();
    }

    private void OnDisable()
    {
        currentActivator.AppearanceChanger.SetInactive();
    }


    private void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
            cooldown = 0;
        else
            return;

        float horAxis;
        float vertAxis;

        if (Input.GetButtonDown("Fire1") || Input.GetButton("Fire2"))
        {
            currentActivator.ActivateButton();
        }
        else if ((horAxis = Input.GetAxis("Horizontal")) != 0)
        {
            if (horAxis > 0 && currentActivator.RightActivator)
            {
                ChangeActiveUIElement(currentActivator.RightActivator);
            }
            else if (horAxis < 0 && currentActivator.LeftActivator)
            {
                ChangeActiveUIElement(currentActivator.LeftActivator);
            }
        }
        else if ((vertAxis = Input.GetAxis("Vertical")) != 0)
        {
            if (vertAxis > 0 && currentActivator.UpActivator)
            {
                ChangeActiveUIElement(currentActivator.UpActivator);
            }
            else if (vertAxis < 0 && currentActivator.DownActivator)
            {
                ChangeActiveUIElement(currentActivator.DownActivator);
            }
        }


    }

    private void ChangeActiveUIElement(UIActivator newUIElement)
    {
        while(newUIElement.enabled = false){
            newUIElement = newUIElement.UpActivator;
        }
        currentActivator.AppearanceChanger.SetInactive();
        currentActivator = newUIElement;
        currentActivator.AppearanceChanger.SetActive();
        cooldown = CooldownDuration;

    }
}
