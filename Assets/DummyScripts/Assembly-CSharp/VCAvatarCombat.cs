/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCAvatarCombat : VCCharacterCombat // TypeDefIndex: 11790
{
	// Fields
	private ActionPanelState _actionPanelState; // 0x224
	private StateCameraType _stateCameraType; // 0x228
	private bool _isCombatCamera; // 0x22C
	private StateCameraParam _stateCameraParam; // 0x230
	private VCAvatarModel _avatarModel; // 0x248
	private LCAvatarCombat _lcAvatarCombat; // 0x250
	private VCBillboard _vcBillboard; // 0x258
	private bool _isCombatHitCamera; // 0x260
	private Transform _rootNode; // 0x268
	private float _shakeOffTimeLeft; // 0x270
	private bool _hasShake; // 0x274
	private float _shakeOffRange; // 0x278

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189874A10-0x0000000189874A30 */ get => default; } // 0x0000000181AA10F0-0x0000000181AA1190 
	public bool canChangeEntity { /* [XID] */ /* 0x000000018987C600-0x000000018987C640 */ get; /* [XID] */ /* 0x0000000189886A40-0x0000000189886A80 */ set; } // 0x0000000181A9F2A0-0x0000000181A9F300 0x0000000181A9CCD0-0x0000000181A9CD40
	public bool canSupportChange { get; /* [XID] */ /* 0x00000001898981A0-0x00000001898981E0 */ set; } // 0x0000000181AA05E0-0x0000000181AA0640 0x0000000181A9F6C0-0x0000000181A9F730
	public bool canMoveOnSwim { /* [XID] */ /* 0x00000001898A27B0-0x00000001898A27F0 */ get; /* [XID] */ /* 0x00000001898ACE80-0x00000001898ACEC0 */ set; } // 0x0000000181A9E2B0-0x0000000181A9E310 0x0000000181AA03E0-0x0000000181AA0450
	public bool sheatheOnEnd { /* [XID] */ /* 0x00000001898B7490-0x00000001898B74D0 */ get; /* [XID] */ /* 0x00000001898C1D50-0x00000001898C1D90 */ set; } // 0x0000000181A9E090-0x0000000181A9E0F0 0x0000000181A9F650-0x0000000181A9F6C0
	public ActionPanelState actionPanelState { /* [XID] */ /* 0x00000001898CC3A0-0x00000001898CC3C0 */ get => default; /* [XID] */ /* 0x00000001898D3C70-0x00000001898D3C90 */ set {} } // 0x0000000181A9CD40-0x0000000181A9CDE0 0x0000000181A9D490-0x0000000181A9D5E0
	public bool isCombatCamera { /* [XID] */ /* 0x00000001898DB460-0x00000001898DB480 */ get => default; } // 0x0000000181A9FF90-0x0000000181AA0040 
	public bool isCombatHitCamera { /* [XID] */ /* 0x00000001898E30E0-0x00000001898E3100 */ get => default; } // 0x0000000181AA0B60-0x0000000181AA0C10 
	public override float cameraRadiusSpringRatio { /* [XID] */ /* 0x0000000189935B40-0x0000000189935B60 */ get => default; } // 0x0000000181A9F7E0-0x0000000181A9F890 
	public override float cameraCombatElevWithHeightRatio { /* [XID] */ /* 0x000000018993D7E0-0x000000018993D800 */ get => default; } // 0x0000000181AA0530-0x0000000181AA05E0 
	public override float cameraForceRadius { /* [XID] */ /* 0x0000000189944C70-0x0000000189944C90 */ get => default; } // 0x0000000181A9CC20-0x0000000181A9CCD0 
	public override float cameraForceRadiusDuration { /* [XID] */ /* 0x00000001898FCE00-0x00000001898FCE20 */ get => default; } // 0x0000000181A9F730-0x0000000181A9F7E0 
	public override bool cameraShouldKeepForceRadius { /* [XID] */ /* 0x000000018995B130-0x000000018995B150 */ get => default; } // 0x0000000181A9D360-0x0000000181A9D410 

	// Nested types
	public struct StateCameraParam // TypeDefIndex: 11791
	{
		// Fields
		public float radiusSpringRatio; // 0x00
		public float combatElevWithHeightRatio; // 0x04
		public float forceRadius; // 0x08
		public float forceRadiusDuration; // 0x0C
		public bool shouldKeepForceRadius; // 0x10

		// Methods
		// [XID] // 0x00000001899EE590-0x00000001899EE5B0
		public void SetByConfig(ConfigStateCameraParam param) {} // 0x0000000181A833C0-0x0000000181A83400
		// [XID] // 0x00000001899F5E80-0x00000001899F5EA0
		public void Reset() {} // 0x0000000181A832B0-0x0000000181A833C0
	}

	// Constructors
	public VCAvatarCombat() {} // 0x0000000181AA1050-0x0000000181AA10F0

	// Methods
	// [XID] // 0x00000001895EE5F0-0x00000001895EE610
	public override void Init() {} // 0x0000000181A9F130-0x0000000181A9F2A0
	// [XID] // 0x00000001898F25E0-0x00000001898F2600
	public void ShowEnergeEffect() {} // 0x0000000181A9FB40-0x0000000181A9FCA0
	// [XID] // 0x00000001898F9D40-0x00000001898F9D60
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000181A9E170-0x0000000181A9E240
	// [XID] // 0x0000000189901760-0x0000000189901780
	protected override bool OnEvent(BaseEvent evt) => default; // 0x0000000181AA0640-0x0000000181AA0920
	// [XID] // 0x0000000189908E70-0x0000000189908E90
	protected override void DieEnd() {} // 0x0000000181A9F890-0x0000000181A9FB40
	// [XID] // 0x00000001899103D0-0x00000001899103F0
	public override void StartDieEnd(bool immediately = false /* Metadata: 0x00AEAB84 */, DieStateFlag dieStateFlag = DieStateFlag.None /* Metadata: 0x00AEAB85 */) {} // 0x0000000181A9EA30-0x0000000181A9ED20
	// [XID] // 0x0000000189917F60-0x0000000189917F80
	public void DoChargeSkill(int triggerID) {} // 0x0000000181A9E8A0-0x0000000181A9EA30
	// [XID] // 0x000000018991F5B0-0x000000018991F5D0
	public bool OnCameraMove(AnimatorEventCameraMove aEvt) => default; // 0x0000000181A9CE40-0x0000000181A9D0E0
	// [XID] // 0x0000000189927100-0x0000000189927120
	public override void SetStateCameraType(StateCameraType stateCameraType) {} // 0x0000000181A9DE40-0x0000000181A9DF30
	// [XID] // 0x000000018992E8B0-0x000000018992E8D0
	public override void SetStateCameraParam(ConfigStateCameraParam stateCameraParam) {} // 0x0000000181A9CAC0-0x0000000181A9CBC0
	// [XID] // 0x000000018994C260-0x000000018994C280
	public override void ResetCameraForceRadius() {} // 0x0000000181AA0130-0x0000000181AA01D0
	// [XID] // 0x0000000189962E10-0x0000000189962E30
	public override void ChangeHP(float HP, float maxHP) {} // 0x0000000181AA0C10-0x0000000181AA0F50
	// [XID] // 0x000000018996A110-0x000000018996A130
	public void RefreshEnergyProperty(ElementType elemType) {} // 0x0000000181AA01D0-0x0000000181AA0290
	// [XID] // 0x0000000189971E70-0x0000000189971E90
	public void ChangeEnergy(float prevValue, float currValue, float max, DataPropOp state) {} // 0x0000000181A9E500-0x0000000181A9E8A0
	// [XID] // 0x00000001899797C0-0x00000001899797E0
	public override void ChangeLevel(int level, int lastLevel, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AEAB89 */) {} // 0x0000000181A9D0E0-0x0000000181A9D360
	// [XID] // 0x0000000189980840-0x0000000189980860
	public override void Die(uint killerID) {} // 0x0000000181A9EE50-0x0000000181A9F130
	// [XID] // 0x0000000189988210-0x0000000189988230
	public void ChangeSkill(int index) {} // 0x0000000181AA0920-0x0000000181AA0AD0
	// [XID] // 0x000000018998FCA0-0x000000018998FCC0
	public void ChangeSkillDepot() {} // 0x0000000181A9ED20-0x0000000181A9EE50
	// [XID] // 0x00000001899975F0-0x0000000189997610
	public void UnlockSkill() {} // 0x0000000181A9E310-0x0000000181A9E460
	// [XID] // 0x0000000189B2D320-0x0000000189B2D340
	public void RecoverySkillChargeCount() {} // 0x0000000181AA0290-0x0000000181AA03E0
	// [IDTag] // 0x00000001899A6B10-0x00000001899A6B50
	// [XID] // 0x00000001899A6B10-0x00000001899A6B50
	public override void UpdateCombatProp(PropType type, float value) {} // 0x0000000181A9DCC0-0x0000000181A9DE40
	// [IDTag] // 0x00000001899B1560-0x00000001899B15A0
	// [XID] // 0x00000001899B1560-0x00000001899B15A0
	public override void UpdateCombatProp(FightPropType type, float value) {} // 0x0000000181A9D9B0-0x0000000181A9DCC0
	// [XID] // 0x00000001899BBA70-0x00000001899BBA90
	protected override void Tick(float inDeltaTime) {} // 0x0000000181AA0F50-0x0000000181AA1050
	// [XID] // 0x00000001899C3690-0x00000001899C36B0
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181A9FD10-0x0000000181A9FF90
	// [XID] // 0x00000001899CAB20-0x00000001899CAB40
	public void DoShakeOff(float time, float range) {} // 0x0000000181A9F560-0x0000000181A9F650
	// [XID] // 0x0000000189718A00-0x0000000189718A20
	private void OnRevive() {} // 0x0000000181A9D5E0-0x0000000181A9D8D0
}

