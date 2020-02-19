using GGJ2020.Util;

using UnityEngine;

namespace GGJ2020 {
  public class GameTime : SingletonBase<GameTime> {
    bool paused;
    float timeDelta = 0;
    float time = 0;

    public bool Paused {
      get { return paused; }
      set {
        paused = value;
        Physics2D.autoSimulation = !value;

        foreach (Animator animator in FindObjectsOfType(typeof(Animator)) as Animator[]) {
          animator.enabled = !value;
        }

        if (!value) {
          timeDelta = 0;
        }
      }
    }

    public float Time { get { return time; } }

    void Update() {
      if (!Paused) {
        timeDelta = UnityEngine.Time.deltaTime;
        time += timeDelta;
      }
    }

    public class WaitForSeconds : CustomYieldInstruction
    {
      float startTime;
      float seconds;
      public WaitForSeconds(float seconds) {
        startTime = GameTime.Instance.time;
        this.seconds = seconds;
      }
      public override bool keepWaiting {
        get {
          return GameTime.Instance.Time - startTime < seconds;
        }
      }
    }
  }
}
