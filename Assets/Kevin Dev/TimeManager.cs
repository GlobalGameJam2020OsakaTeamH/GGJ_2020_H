using UnityEngine;

namespace GGJ2020 {
    public class TimeManager : MonoBehaviour {
        public static float GameTime {
            get {
                return Time.time;
            }
        }
    }
}
