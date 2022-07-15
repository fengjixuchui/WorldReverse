/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class VCBaseInputController : VCBase // TypeDefIndex: 11817
	{
		// Fields
		protected VCBaseMove _moveComponent; // 0x110
	
		// Properties
		public override int metaTypeID { /* [XID] */ /* 0x0000000189A6A3E0-0x0000000189A6A400 */ get => 0xC000; } // 0x0000000183BE6720-0x0000000183BE67C0 
		public ControlData controlData { /* [XID] */ /* 0x0000000189A717D0-0x0000000189A71810 */ get; /* [XID] */ /* 0x0000000189A7C320-0x0000000189A7C360 */ set; } // 0x0000000183BE66C0-0x0000000183BE6720 0x0000000183BE67C0-0x0000000183BE6830
	
		// Constructors
		public VCBaseInputController() 
		{
			_moveComponent = new VCBaseMove();
		} // 0x0000000183BE65F0-0x0000000183BE66C0
	
		// Methods
		// [XID] // 0x0000000189A64390-0x0000000189A643B0
		public override void PreInit() 
		{
			base.PreInit();
			order = 2;
		} // 0x0000000183BE6420-0x0000000183BE64D0
		// [XID] // 0x0000000189B9B710-0x0000000189B9B730
		public override void Init() 
		{
			_moveComponent = GetVisualComponent<VCBaseMove>(0xF000);
		} // 0x0000000183BE5470-0x0000000183BE5520
		// [XID] // 0x0000000189A6BC80-0x0000000189A6BCA0
		public override void ReInit(BaseEntity.ReInitReason reason) 
		{
			base.ReInit(reason);
			Init();
			if (reason == BaseEntity.ReInitReason.Reuse) 
			{
				controlData.isMuteControl = false;
			}
		} // 0x0000000183BE64D0-0x0000000183BE65F0
		// [XID] // 0x0000000189A9D320-0x0000000189A9D340
		protected override void LateTick(float inDeltaTime) 
		{
			LateTick(inDeltaTime);
			controlData.Reset();
		} // 0x0000000183BE57E0-0x0000000183BE58F0
		// [XID] // 0x0000000189AA4A60-0x0000000189AA4A80
		public void ClearInputControl()
		{
			Vector3 forward = _entity.GetForward();
			if (!CommonMiscs.IsAlmostZero(forward.y, 0.0001))
			{
				forward = Extension.XZ(forward).normalized;
			}
			controlData.rawTargetDir = forward;
			VCMoveData moveData = _moveComponent.GetMoveData();
			if (moveData != null)
			{
				moveData.targetSteerDir = forward;
				moveData.rawIsMoving = controlData.rawIsMoving;
			}
		} // 0x0000000183BE46B0-0x0000000183BE4930
		// [IDTag] // 0x0000000189AAC070-0x0000000189AAC0B0
		// [XID] // 0x0000000189AAC070-0x0000000189AAC0B0
		public virtual void TrySteer(bool isMoving, float joystickAngle) 
		{
			controlData.rawIsMoving = isMoving;
			controlData.rawJoystickAngle = joystickAngle;
			if (controlData.rawIsMoving) 
			{
				controlData.hasMovedBySelectTarget = true;
				Quaternion axis = Quaternion.AngleAxis(-joystickAngle, Vector3.up);
				Vector3 cameraForward = CameraEntity.GetCameraStableForward();
				Vector3 targetDir = axis * cameraForward;
				controlData.rawTargetDir.x = targetDir.x;
				controlData.rawTargetDir.z = targetDir.z;
			}
		} // 0x0000000183BE5F60-0x0000000183BE62B0
		// [XID] // 0x00000001899E7370-0x00000001899E7390
		public virtual void SetMotionFlag(VCMoveData.MotionFlag moveState) {} // 0x0000000183BE4AF0-0x0000000183BE4BA0
		// [XID] // 0x000000018998B7A0-0x000000018998B7C0
		public virtual VCMoveData.MotionFlag GetMotionFlag()
        {
			if (_moveComponent != null)
            {
				return _moveComponent.GetMotionFlag();
            }
			return VCMoveData.MotionFlag.Idle;
        }// 0x0000000183BE53B0-0x0000000183BE5470
		// [XID] // 0x0000000189AC60B0-0x0000000189AC60D0
		public virtual void SetYawSpeedOverride(float yawSpeed) {} // 0x0000000183BE5A70-0x0000000183BE5B20
		// [XID] // 0x0000000189ACD620-0x0000000189ACD640
		public virtual float? GetYawSpeedOrigin() { return 0; } // 0x0000000183BE5690-0x0000000183BE5730
		// [XID] // 0x0000000189867AB0-0x0000000189867AD0
		public virtual void SetFollowAnimationTransform(bool enabled) {} // 0x0000000183BE4BA0-0x0000000183BE4C50
		// [XID] // 0x0000000189ADCD50-0x0000000189ADCD70
		public virtual void SetGroundFollowAnimationRotation(bool enabled) {} // 0x0000000183BE5730-0x0000000183BE57E0
		// [IDTag] // 0x0000000189AE45A0-0x0000000189AE45E0
		// [XID] // 0x0000000189AE45A0-0x0000000189AE45E0
		public virtual void TrySteer(Vector3 targetDir) 
		{
			controlData.rawIsMoving = true;
			controlData.rawTargetDir.x = targetDir.x;
			controlData.rawTargetDir.z = targetDir.z;
		} // 0x0000000183BE62B0-0x0000000183BE6420
		// [IDTag] // 0x0000000189AEF190-0x0000000189AEF1D0
		// [XID] // 0x0000000189AEF190-0x0000000189AEF1D0
		public virtual void TrySteerAir(Vector3 targetDir) 
		{
			controlData.rawIsMoving = true;
			controlData.rawTargetDir.x = targetDir.x;
			controlData.rawTargetDir.z = targetDir.z;
		} // 0x0000000183BE5CB0-0x0000000183BE5E20
		// [IDTag] // 0x0000000189AF9820-0x0000000189AF9860
		// [XID] // 0x0000000189AF9820-0x0000000189AF9860
		public virtual void TrySteerAir(Vector3 targetDir, Vector3 targetPointForTilt)
		{
			controlData.rawIsMoving = true;
			controlData.rawTargetDir.x = targetDir.x;
			controlData.rawTargetDir.z = targetDir.z;
		} // 0x0000000183BE5B20-0x0000000183BE5CB0
		// [XID] // 0x0000000189B03C30-0x0000000189B03C50
		public virtual void TrySteerWithAngle(Vector3 targetDir, VCMoveData.MotionDirection motionDir)
		{
			controlData.rawIsMoving = true;
			controlData.rawTargetDir.x = targetDir.x;
			controlData.rawTargetDir.z = targetDir.z;
		} // 0x0000000183BE5090-0x0000000183BE5210
		// [XID] // 0x0000000189752D70-0x0000000189752D90
		public virtual void TrySteerWithAngleExactly(Vector3 targetDir, VCMoveData.MotionDirection motionDir, Vector3 targetPosition)
		{
			controlData.rawIsMoving = true;
			controlData.rawTargetDir.x = targetDir.x;
			controlData.rawTargetDir.z = targetDir.z;
		} // 0x0000000183BE4E50-0x0000000183BE4FF0
		// [XID] // 0x0000000189877CE0-0x0000000189877D00
		public virtual void TrySprint() {} // 0x0000000183BE5210-0x0000000183BE52B0
		// [XID] // 0x0000000189B19DA0-0x0000000189B19DC0
		public virtual void TryStop() 
		{
			controlData.rawIsMoving = false;
		} // 0x0000000183BE4930-0x0000000183BE4A20
		  // [XID] // 0x0000000189B21390-0x0000000189B213B0
		public virtual void TryStopSprint() {} // 0x0000000183BE5E20-0x0000000183BE5EC0
		// [XID] // 0x0000000189985220-0x0000000189985240
		public virtual void TryFly() {} // 0x0000000183BE4FF0-0x0000000183BE5090
		// [XID] // 0x000000018987F530-0x000000018987F550
		public virtual void TryJump() {} // 0x0000000183BE5EC0-0x0000000183BE5F60
		// [XID] // 0x0000000189B37880-0x0000000189B378A0
		public virtual void TryTeleport(Vector3 pos) 
		{
            if (!controlData.isMuteControl) 
			{
                if (_entity.isAlive) 
				{
					VCBaseMove entityMove = _entity.GetMoveComponent<VCBaseMove>();
					entityMove.TryTeleport(pos);
				}
			}
		} // 0x0000000183BE4C50-0x0000000183BE4DD0
		// [XID] // 0x0000000189A47990-0x0000000189A479B0
		public virtual void TryDoSkill(uint skillID) 
		{
			if (controlData.isSkillButtonHold != null) 
			{
				controlData.isSkillButtonHold[skillID] = true;
			}
		} // 0x0000000183BE58F0-0x0000000183BE5A00
		// [XID] // 0x0000000189B46AC0-0x0000000189B46AE0
		public virtual void TryReleaseSkill(uint skillID)
		{
			if (controlData.isSkillButtonHold != null)
			{
				controlData.isSkillButtonHold[skillID] = false;
			}
		} // 0x0000000183BE5580-0x0000000183BE5690
		// [XID] // 0x0000000189B4E290-0x0000000189B4E2B0
		public virtual void SetSkillButtonsAvaliable(bool avaliable) 
		{
			controlData.skillButtonsAvaliable = avaliable;
		} // 0x0000000183BE52B0-0x0000000183BE53B0
	}
}
