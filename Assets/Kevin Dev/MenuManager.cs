﻿using UnityEngine;
using GGJ2020;

public class MenuManager : MonoBehaviour {
    public GameObject menu;
    public GameObject menumessage;
    GameObject player;

    enum State {
        NotAtBase,
        AtBase,
        MenuOpen
    }

    State state;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        state = State.AtBase;
    }

    // Update is called once per frame
    void Update() {
        if (!player) {
            return;
        }
        switch (state) {
            case State.AtBase:
                if (Input.GetButtonDown("Menu")) {
                    OpenMenu();
                }
                if (!PlayerIsAtBase) {
                    menumessage.SetActive(false);
                    state = State.NotAtBase;
                }
                break;
            case State.NotAtBase:
                if (PlayerIsAtBase) {
                    state = State.AtBase;
                    menumessage.SetActive(true);
                }
                break;
            case State.MenuOpen:
                break;
        }
    }

    bool PlayerIsAtBase {
        get {
            return (player.transform.position - transform.position).magnitude < 3;
        }
    }

    public void OpenMenu() {
        state = State.MenuOpen;
        menumessage.SetActive(false);
        menu.SetActive(true);
        GameTime.Instance.Paused = true;
    }

    public void CloseMenu() {
        state = State.AtBase;
        menumessage.SetActive(true);
        menu.SetActive(false);
        GameTime.Instance.Paused = false;
    }
}
