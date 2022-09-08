/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCPose : LCBase // TypeDefIndex: 11755
{
	// Fields
	public static readonly int POSE_STATE_PARAM_STRING; // 0x00
	private Animator _fsm; // 0x130
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private int _currentPoseID; // 0x138
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private int _currentPoseStateHash; // 0x13C
	private int _reinitPoseID; // 0x140
	private ConfigPoseInitialParam _initialParams; // 0x148
	private Dictionary<int, bool> _boolParamPersistence; // 0x150
	private Dictionary<int, int> _intParamPersistence; // 0x158
	private Dictionary<int, float> _floatParamPersistence; // 0x160
	public const int UNASSIGNED_POSE_ID = 0; // Metadata: 0x00AEA79A
	public Action<int, int> onPoseIDChanged; // 0x168
	private ActorAbilityPlugin _selfAbilityPlugin; // 0x170
	public static bool globalSyncPose; // 0x04

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189689040-0x0000000189689060 */ get => default; } // 0x0000000181EFDA00-0x0000000181EFDAA0 

	// Constructors
	public LCPose() {} // 0x0000000181EFD910-0x0000000181EFDA00
	public LCPose(int initialPoseID, Dictionary<string, ConfigMonsterInitialPose> poseMap) {} // 0x0000000181EFD810-0x0000000181EFD910
	static LCPose() {} // 0x0000000181EFD780-0x0000000181EFD810

	// Methods
	// [XID] // 0x00000001898FCD20-0x00000001898FCD40
	public void ResetInitPos(int initPoseID, Dictionary<string, ConfigMonsterInitialPose> poseMap) {} // 0x0000000181EF9BA0-0x0000000181EFA2C0
	// [XID] // 0x00000001899046C0-0x00000001899046E0
	public void InitPoseAnimatorAndParameters(int initialPoseID) {} // 0x0000000181EF95C0-0x0000000181EF9740
	// [XID] // 0x00000001896B5760-0x00000001896B5780
	public void ConditionalPauseFSM() {} // 0x0000000181EFC8C0-0x0000000181EFCA30
	// [XID] // 0x0000000189913880-0x00000001899138A0
	protected override void Tick(float inDeltaTime) {} // 0x0000000181EFD4C0-0x0000000181EFD780
	// [XID] // 0x000000018991B1C0-0x000000018991B1E0
	public override void OnEnable() {} // 0x0000000181EFCFF0-0x0000000181EFD0B0
	// [XID] // 0x00000001899227D0-0x00000001899227F0
	public override void OnDisable() {} // 0x0000000181EFCF40-0x0000000181EFCFF0
	// [XID] // 0x0000000189929EE0-0x0000000189929F00
	private void OnAnimatorTickStateChange(TickState ts, bool entityIsTickable, bool intervalAnimatorTickRootMotion) {} // 0x0000000181EFC290-0x0000000181EFC3E0
	// [XID] // 0x00000001896CB460-0x00000001896CB480
	public override void Init() {} // 0x0000000181EFB8A0-0x0000000181EFB9E0
	// [XID] // 0x00000001898A5AB0-0x00000001898A5AD0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181EFD380-0x0000000181EFD4C0
	// [XID] // 0x0000000189940530-0x0000000189940550
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181EF9940-0x0000000181EF9BA0
	// [XID] // 0x000000018970C8E0-0x000000018970C900
	public override void Destroy() {} // 0x0000000181EFA320-0x0000000181EFA4C0
	// [XID] // 0x000000018994F270-0x000000018994F290
	private void SetPoseParamsToFSM() {} // 0x0000000181EFA520-0x0000000181EFA9B0
	// [XID] // 0x0000000189956800-0x0000000189956820
	public void TrySyncPoseParameterBool(int paraID, bool value) {} // 0x0000000181EFAA30-0x0000000181EFAE70
	// [XID] // 0x000000018995E270-0x000000018995E290
	public void TrySyncPoseParameterInt(int paraID, int value) {} // 0x0000000181EFB040-0x0000000181EFB470
	// [XID] // 0x0000000189B4B320-0x0000000189B4B340
	public void TrySyncPoseParameterFloat(int paraID, float value) {} // 0x0000000181EFB470-0x0000000181EFB8A0
	// [XID] // 0x000000018996D230-0x000000018996D250
	public void SyncPoseParameterHandler(AnimatorParameterValueInfoPair poseParameterValue) {} // 0x0000000181EFCBC0-0x0000000181EFCDB0
	// [XID] // 0x0000000189974AF0-0x0000000189974B10
	public void SyncPoseParameterListHandler(RepeatedField<AnimatorParameterValueInfoPair> poseParaList) {} // 0x0000000181EFBE70-0x0000000181EFC030
	// [XID] // 0x000000018969F7E0-0x000000018969F800
	private void HandlePoseSpecialValue(AnimatorParameterValueInfoPair poseParameterValue) {} // 0x0000000181EFC030-0x0000000181EFC230
	// [XID] // 0x00000001896DA480-0x00000001896DA4A0
	private void UpdateCurrentPoseStateToAnimator() {} // 0x0000000181EFCDB0-0x0000000181EFCED0
	// [XID] // 0x000000018998B540-0x000000018998B560
	public int GetPoseID() => default; // 0x0000000181EF97B0-0x0000000181EF9850
	// [XID] // 0x00000001895F76D0-0x00000001895F76F0
	public Animator GetPoseFSM() => default; // 0x0000000181EFBBD0-0x0000000181EFBC80
	// [XID] // 0x00000001897859A0-0x00000001897859C0
	public bool HasParameter(int id) => default; // 0x0000000181EFCAA0-0x0000000181EFCBC0
	// [IDTag] // 0x00000001899A2370-0x00000001899A23B0
	// [XID] // 0x00000001899A2370-0x00000001899A23B0
	public void SetPoseParameterBool(string boolParamName, bool boolValue, bool syncToServer) {} // 0x0000000181EFC3E0-0x0000000181EFC4E0
	// [IDTag] // 0x00000001899ACDB0-0x00000001899ACDF0
	// [XID] // 0x00000001899ACDB0-0x00000001899ACDF0
	public void SetPoseParameterBool(int boolParamID, bool boolValue, bool syncToServer) {} // 0x0000000181EFC4E0-0x0000000181EFC5E0
	// [XID] // 0x00000001899B7100-0x00000001899B7120
	public bool InternalSetPoseBool(int boolParamID, bool boolValue) => default; // 0x0000000181EFD0B0-0x0000000181EFD290
	// [XID] // 0x0000000189731E20-0x0000000189731E40
	public bool GetPoseParameterBool(int hashName, out bool boolValue) {
		boolValue = default;
		return default;
	} // 0x0000000181EFD290-0x0000000181EFD380
	// [IDTag] // 0x00000001899C6620-0x00000001899C6660
	// [XID] // 0x00000001899C6620-0x00000001899C6660
	public void SetPoseParameterInt(string intParamName, int intValue, bool syncToServer) {} // 0x0000000181EFBD80-0x0000000181EFBE70
	// [IDTag] // 0x00000001899D0C20-0x00000001899D0C60
	// [XID] // 0x00000001899D0C20-0x00000001899D0C60
	public void SetPoseParameterInt(int intParamID, int intValue, bool syncToServer) {} // 0x0000000181EFBC80-0x0000000181EFBD80
	// [XID] // 0x00000001899DAFE0-0x00000001899DB000
	public bool InternalSetPoseInt(int intParamID, int intValue) => default; // 0x0000000181EFAE70-0x0000000181EFB040
	// [XID] // 0x00000001899E2780-0x00000001899E27A0
	public bool GetPoseParameterInt(int hashName, out int intValue) {
		intValue = default;
		return default;
	} // 0x0000000181EF9850-0x0000000181EF9940
	// [IDTag] // 0x00000001899E9D70-0x00000001899E9DB0
	// [XID] // 0x00000001899E9D70-0x00000001899E9DB0
	public void SetPoseParameterFloat(string floatParamName, float floatValue, bool syncToServer) {} // 0x0000000181EFC6E0-0x0000000181EFC7D0
	// [IDTag] // 0x00000001899F4A80-0x00000001899F4AC0
	// [XID] // 0x00000001899F4A80-0x00000001899F4AC0
	public void SetPoseParameterFloat(int floatParamID, float floatValue, bool syncToServer) {} // 0x0000000181EFC5E0-0x0000000181EFC6E0
	// [XID] // 0x00000001899FEE60-0x00000001899FEE80
	public bool InternalSetPoseFloat(int floatParamID, float floatValue) => default; // 0x0000000181EFB9E0-0x0000000181EFBBD0
	// [XID] // 0x0000000189A066E0-0x0000000189A06700
	public bool GetPoseParameterFloat(int hashName, out float floatValue) {
		floatValue = default;
		return default;
	} // 0x0000000181EFC7D0-0x0000000181EFC8C0
	// [XID] // 0x0000000189A0DBE0-0x0000000189A0DC00
	public void ChangeAuthorityHandle(int poseID) {} // 0x0000000181EF9510-0x0000000181EF95C0
}

