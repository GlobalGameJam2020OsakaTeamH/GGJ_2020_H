﻿using UnityEngine;

namespace GGJ2020 {
    public interface BodyCollisionHandler {
        void OnWeaponHit(Collision2D collision);
    }

}
