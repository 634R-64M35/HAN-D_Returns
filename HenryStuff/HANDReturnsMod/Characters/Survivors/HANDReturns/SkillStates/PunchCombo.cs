using HANDReturns.Modules.BaseStates;
using RoR2;
using UnityEngine;
using System;

namespace HANDReturns.Survivors.HANDReturns.SkillStates {
    public class PunchCombo : BaseMeleeAttack {

        public override void OnEnter() {
            RoR2.Console.print("punchIndex:" + punchIndex);

            hitboxGroupName = "PunchGroup";

            damageType = DamageType.Generic;
            damageCoefficient = HANDReturnsStaticValues.punchDamageCoefficient;
            procCoefficient = 0.8f;
            pushForce = 300f;
            bonusForce = Vector3.zero;
            baseDuration = 1f;

            //0-1 multiplier of baseduration, used to time when the hitbox is out (usually based on the run time of the animation)
            //for example, if attackStartPercentTime is 0.5, the attack will start hitting halfway through the ability. if baseduration is 3 seconds, the attack will start happening at 1.5 seconds
            attackStartPercentTime = 0.2f;
            attackEndPercentTime = 0.4f;

            //this is the point at which the attack can be interrupted by itself, continuing a combo
            earlyExitPercentTime = 0.6f;

            hitStopDuration = 0.012f;
            attackRecoil = 0.5f;
            hitHopVelocity = 4f;

            swingSoundString = "HANDReturnsSwordSwing";
            hitSoundString = "";
            muzzleString = punchIndex % 2 == 0 ? "SwingLeft" : "SwingRight";
            playbackRateParam = "Slash.playbackRate";
            swingEffectPrefab = HANDReturnsAssets.swordSwingEffect;
            hitEffectPrefab = HANDReturnsAssets.swordHitImpactEffect;

            impactSound = HANDReturnsAssets.swordHitSoundEvent.index;

            base.OnEnter();
        }

        protected override void PlayAttackAnimation() {
            PlayCrossfade("Gesture, Override", "Slash" + (1 + punchIndex), playbackRateParam, duration, 0.1f * duration);
        }

        protected override void PlaySwingEffect() => base.PlaySwingEffect();

        protected override void OnHitEnemyAuthority() => base.OnHitEnemyAuthority();

        public override void OnExit() => base.OnExit();
    }
}