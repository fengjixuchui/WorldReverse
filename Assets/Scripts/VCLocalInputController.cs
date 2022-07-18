/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCLocalInputController : VCBaseInputController // TypeDefIndex: 11893
{
    // Fields
    private LCCharacterCombat _combatComponent; // 0x118

    // Properties
    public override int metaTypeID { /* [XID] */ /* 0x0000000189BCCA60-0x0000000189BCCA80 */ get => VCBaseComponentTypeIDs.VCLocalInputController; } // 0x00000001824FF5B0-0x00000001824FF650 

    // Constructors
    public VCLocalInputController()
    {
        _combatComponent = new LCCharacterCombat();
    } // 0x00000001824FF540-0x00000001824FF5B0

    // Methods
    // [XID] // 0x0000000189BD4110-0x0000000189BD4130

    public override void Init()
    {
        base.Init();
        _combatComponent = GetEntity().GetLogicCombatComponent<LCCharacterCombat>();
    } // 0x00000001824FE7B0-0x00000001824FE880
      // [IDTag] // 0x0000000189BDB9F0-0x0000000189BDBA30
      // [XID] // 0x0000000189BDB9F0-0x0000000189BDBA30
    public override void TrySteer(bool isMoving, float joystickAngle)
    {
        int angle = Mathf.RoundToInt(joystickAngle);
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.TrySteer(isMoving, angle);
                if (_moveComponent.IsActive())
                {
                    _moveComponent.TrySteer(isMoving, angle);
                }
            }
        }
    } // 0x00000001824FF3A0-0x00000001824FF540
      // [IDTag] // 0x00000001895EB4D0-0x00000001895EB510
      // [XID] // 0x00000001895EB4D0-0x00000001895EB510
    public override void TrySteer(Vector3 targetDir)
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.TrySteer(targetDir);
                if (_moveComponent.IsActive())
                {
                    _moveComponent.TrySteer(targetDir);
                }
                else
                {
                    _moveComponent.SetTargetSteer(targetDir);
                }
            }
        }
    } // 0x00000001824FF1E0-0x00000001824FF3A0
      // [XID] // 0x00000001895F5C50-0x00000001895F5C70
    public override void TrySteerWithAngleExactly(Vector3 targetDir, VCMoveData.MotionDirection motionDir, Vector3 targetPosition)
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.TrySteer(targetDir);
                if (_moveComponent.IsActive())
                {
                    _moveComponent.TrySteerWithAngleExactly(targetDir, motionDir, targetPosition);
                }
                else
                {
                    _moveComponent.SetTargetSteerExactly(targetDir, targetPosition);
                }
            }
        }
    }// 0x00000001824FDDC0-0x00000001824FDFE0
     // [XID] // 0x00000001895FD150-0x00000001895FD170
    public override void TrySprint()
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.TrySprint();
                if (_moveComponent.IsActive())
                {
                    (_moveComponent as VCHumanoidMove).TrySprintBS();
                }
            }
        }
    } // 0x00000001824FE370-0x00000001824FE490
      // [XID] // 0x0000000189604B30-0x0000000189604B50
    public override void TryStop()
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.TryStop();
                if (_moveComponent.IsActive())
                {
                    _moveComponent.TryStop();
                }
            }
        }
    } // 0x00000001824FDB00-0x00000001824FDC20
      // [XID] // 0x0000000189767860-0x0000000189767880
    public override void TryStopSprint()
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.TryStopSprint();
            }
        }
    } // 0x00000001824FEEF0-0x00000001824FEFD0
      // [XID] // 0x00000001899992A0-0x00000001899992C0
    public override void TryJump()
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.TryJump();
                if (_moveComponent.IsActive())
                {
                    _moveComponent.DoJump();
                }
                controlData.jumpThisFrame = true;
            }
        }
    } // 0x00000001824FF090-0x00000001824FF1E0
      // [XID] // 0x00000001899917F0-0x0000000189991810
    public override void TryDoSkill(uint skillID)
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.TryDoSkill(skillID);
                if (_combatComponent.IsActive())
                {
                    _combatComponent.DoSkill(skillID);
                }
            }
        }
    } // 0x00000001824FED70-0x00000001824FEE80
      // [XID] // 0x00000001896227A0-0x00000001896227C0
    public override void TryReleaseSkill(uint skillID)
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.TryReleaseSkill(skillID);
                if (_combatComponent.IsActive())
                {
                    _combatComponent.ReleaseSkill(skillID);
                }
            }
        }
    } // 0x00000001824FE950-0x00000001824FEAC0
      // [XID] // 0x0000000189776AE0-0x0000000189776B00
    public override void SetMotionFlag(VCMoveData.MotionFlag moveState)
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                base.SetMotionFlag(moveState);
                if (_moveComponent.IsActive())
                {
                    _moveComponent.SetMotionFlag(moveState);
                }
            }
        }
    } // 0x00000001824FDC80-0x00000001824FDDC0
      // [XID] // 0x00000001896318E0-0x0000000189631900
    public bool IsInClimb()
    {
        return _moveComponent.IsInClimb();
    } // 0x00000001824FE2B0-0x00000001824FE370
      // [XID] // 0x0000000189639340-0x0000000189639360
    public void UpdateMoveMold(float moveMold)
    {
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                if (moveMold != controlData.rawInputMold)
                {
                    _entity.SetAnimatorFloat(AnimatorParamsData.INPUT_MOLD, moveMold);
                }
            }
        }
    } // 0x00000001824FE050-0x00000001824FE1F0
      // [XID] // 0x000000018977DEF0-0x000000018977DF10
    public void UpdateMoveInput(float moveAngle, float moveMold, out bool isRunning)
    {
        isRunning = false;
        if (!controlData.isMuteControl)
        {
            if (_entity.isAlive)
            {
                float rawInput = controlData.rawInputMold;
                controlData.rawInputMold = moveMold;
                TrySteer(moveMold > 0.0, moveAngle);
                if (moveMold <= 0.0)
                {
                    SetMotionFlag(VCMoveData.MotionFlag.Idle);
                    isRunning = false;
                    return;
                }
                bool walkThreshold = (Mathf.Abs(rawInput - moveMold) / Time.deltaTime) > AvatarInputControllerData_H4.TO_WALK_MOLD_CHANGE_THRESHOLD;
                VCMoveData.MotionFlag motionFlag = base.GetMotionFlag();
                if (motionFlag > VCMoveData.MotionFlag.Walk)
                {
                    if (motionFlag != VCMoveData.MotionFlag.Run)
                    {
                        SetMotionFlag(motionFlag);
                        return;
                    }
                    isRunning = true;
                    if (moveMold >= 0.35 || walkThreshold)
                    {
                        SetMotionFlag(motionFlag);
                        return;
                    }
                }
                else if (moveMold > 0.45)
                {
                    motionFlag = VCMoveData.MotionFlag.Run;
                    isRunning = true;
                    SetMotionFlag(motionFlag);
                    return;
                }
                isRunning = false;
                motionFlag = VCMoveData.MotionFlag.Walk;
                SetMotionFlag(motionFlag);
            }
        }
    } // 0x00000001824FE490-0x00000001824FE750
      // [XID] // 0x00000001897858E0-0x0000000189785900
    public override void OnDisable()
    {
        controlData.rawInputMold = 0;
    } // 0x00000001824FEFD0-0x00000001824FF090
}

