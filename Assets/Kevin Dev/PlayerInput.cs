using UnityEngine;

namespace GGJ2020 {
    [RequireComponent(typeof(Unit))]
    public class PlayerInput : MonoBehaviour {
        Unit unit;

        void Start() {
            unit = GetComponent<Unit>();
        }

        void Update() {
            unit.SetDirection(InputDirection);
            if (UseSword) {
                unit.UseSword();
            } else if (UseGun) {
                unit.UseGun();
            }
        }

        Vector2 InputDirection {
            get {
                return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            }
        }

        bool UseSword {
            get {
                return Input.GetButtonDown("Fire1");
            }
        }

        bool UseGun {
            get {
                return Input.GetButtonDown("Fire2");
            }
        }
    }

}
