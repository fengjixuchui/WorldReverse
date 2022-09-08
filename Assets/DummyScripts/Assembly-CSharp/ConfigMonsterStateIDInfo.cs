/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMonsterStateIDInfo : ConfigNormalStateIDInfo, IAutoAllocRecycle // TypeDefIndex: 19032
{
	// Fields
	private bool _canSteer; // 0x60
	private bool _autoSteer; // 0x61
	private bool _followAnimRotation; // 0x62
	private SimpleSafeFloat gravityAdjustScaleRawNum; // 0x64
	private bool _forceSetAirMove; // 0x68
	private bool _remoteForceUseAnimatorVel; // 0x69

	// Properties
	public bool canSteer { /* [XID] */ /* 0x0000000189BD3410-0x0000000189BD3430 */ get => default; /* [XID] */ /* 0x0000000189BDAD20-0x0000000189BDAD40 */ private set {} } // 0x00000001839C3D20-0x00000001839C3DC0 0x00000001839C4660-0x00000001839C4710
	public bool autoSteer { /* [XID] */ /* 0x00000001895E7670-0x00000001895E7690 */ get => default; /* [XID] */ /* 0x00000001895EEF80-0x00000001895EEFA0 */ private set {} } // 0x00000001839C55A0-0x00000001839C5640 0x00000001839C4530-0x00000001839C45E0
	public bool followAnimRotation { /* [XID] */ /* 0x00000001895F6980-0x00000001895F69A0 */ get => default; /* [XID] */ /* 0x00000001895FDD40-0x00000001895FDD60 */ private set {} } // 0x00000001839C3C80-0x00000001839C3D20 0x00000001839C3E20-0x00000001839C3ED0
	public float gravityAdjustScale { /* [XID] */ /* 0x0000000189605590-0x00000001896055B0 */ get => default; /* [XID] */ /* 0x000000018960CF40-0x000000018960CF60 */ private set {} } // 0x00000001839C2F70-0x00000001839C3050 0x00000001839C4E40-0x00000001839C4F20
	public bool forceSetAirMove { /* [XID] */ /* 0x00000001896145E0-0x0000000189614600 */ get => default; /* [XID] */ /* 0x000000018961BEF0-0x000000018961BF10 */ private set {} } // 0x00000001839C4D30-0x00000001839C4DD0 0x00000001839C5A00-0x00000001839C5AB0
	public bool remoteForceUseAnimatorVel { /* [XID] */ /* 0x0000000189623480-0x00000001896234A0 */ get => default; /* [XID] */ /* 0x000000018962ACC0-0x000000018962ACE0 */ private set {} } // 0x00000001839C5AB0-0x00000001839C5B50 0x00000001839C3FE0-0x00000001839C4090

	// Constructors
	public ConfigMonsterStateIDInfo() {} // 0x00000001839C67E0-0x00000001839C6880

	// Methods
	// [XID] // 0x0000000189632460-0x0000000189632480
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839C6420-0x00000001839C65A0
	// [XID] // 0x0000000189639EF0-0x0000000189639F10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001839C5950-0x00000001839C5A00
	// [XID] // 0x00000001896413E0-0x0000000189641400
	public override ConfigBaseStateIDInfo Clone(bool useObjectPool = false /* Metadata: 0x00AFB819 */) => default; // 0x00000001839C54C0-0x00000001839C55A0
	// [XID] // 0x0000000189648E00-0x0000000189648E20
	public override int GetHashNum() => default; // 0x00000001839C3BB0-0x00000001839C3C80
	// [XID] // 0x00000001896503B0-0x00000001896503D0
	public override void InitEmpty() {} // 0x00000001839C4F20-0x00000001839C4FF0
	[BlackList] // 0x0000000189657CB0-0x0000000189657CF0
	// [XID] // 0x0000000189657CB0-0x0000000189657CF0
	public override bool FromJson(JSONNode node) => default; // 0x00000001839C4790-0x00000001839C4B10
	// [XID] // 0x0000000189662260-0x0000000189662280
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001839C3050-0x00000001839C3640
	[BlackList] // 0x0000000189669E60-0x0000000189669EA0
	// [XID] // 0x0000000189669E60-0x0000000189669EA0
	public static new ConfigMonsterStateIDInfo ParseFromJson(JSONNode node) => default; // 0x00000001839C56A0-0x00000001839C58F0
	// [XID] // 0x0000000189674870-0x0000000189674890
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB81A */, bool useObjectPool = false /* Metadata: 0x00AFB81E */) => default; // 0x00000001839C51C0-0x00000001839C54C0
	// [XID] // 0x000000018967C220-0x000000018967C240
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB81F */, bool useObjectPool = false /* Metadata: 0x00AFB823 */) => default; // 0x00000001839C4090-0x00000001839C4530
	// [XID] // 0x0000000189683750-0x0000000189683770
	public static new ConfigMonsterStateIDInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB824 */, bool useObjectPool = false /* Metadata: 0x00AFB828 */) => default; // 0x00000001839C4B10-0x00000001839C4D30
	[BlackList] // 0x000000018968B450-0x000000018968B490
	// [XID] // 0x000000018968B450-0x000000018968B490
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001839C3640-0x00000001839C3910
	// [XID] // 0x0000000189695F70-0x0000000189695F90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001839C5E80-0x00000001839C6320
	[BlackList] // 0x000000018969D650-0x000000018969D690
	// [XID] // 0x000000018969D650-0x000000018969D690
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001839C50D0-0x00000001839C51C0
	[BlackList] // 0x00000001896A7720-0x00000001896A7760
	// [XID] // 0x00000001896A7720-0x00000001896A7760
	public override void AutoAllocTypeFields() {} // 0x00000001839C3910-0x00000001839C39B0
	[BlackList] // 0x00000001896B15D0-0x00000001896B1610
	// [XID] // 0x00000001896B15D0-0x00000001896B1610
	public override void AutoRecycleTypeFields() {} // 0x00000001839C39B0-0x00000001839C3A90
	[BlackList] // 0x00000001896BBE40-0x00000001896BBE80
	// [XID] // 0x00000001896BBE40-0x00000001896BBE80
	public override void ReturnToObjectPool() {} // 0x00000001839C6740-0x00000001839C67E0
	// [XID] // 0x00000001896C6430-0x00000001896C6450
	public override void ProcessNormalizedTime(BaseEntity entity, float normalizedTime) {} // 0x00000001839C65A0-0x00000001839C6680
	// [XID] // 0x00000001896CDA50-0x00000001896CDA70
	private void ProcessAutoSteer(BaseEntity entity, float normalizedTime) {} // 0x00000001839C6320-0x00000001839C6420
	// [XID] // 0x00000001896D4FA0-0x00000001896D4FC0
	public override void HandleAnimatorState(BaseEntity entity, bool isTo, int fromStateID, int toStateID, VCAnimatorEvent animatorComponent) {} // 0x00000001839C5B50-0x00000001839C5E80
}

