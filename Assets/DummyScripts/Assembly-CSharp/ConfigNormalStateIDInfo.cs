/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigNormalStateIDInfo : ConfigBaseStateIDInfo, IAutoAllocRecycle // TypeDefIndex: 19028
{
	// Fields
	private Dictionary<string, string[]> _animatorStates; // 0x18
	private MoveType _moveType; // 0x20
	private bool _combatMoveOnWater; // 0x24
	private bool _canDoSkill; // 0x25
	private SimpleSafeFloat canDoSkillStartRawNum; // 0x28
	private SimpleSafeFloat canDoSkillEndRawNum; // 0x2C
	private bool _canSyncMove; // 0x30
	private bool _cullingModelAlwaysAnimate; // 0x31
	private SimpleSafeFloat addEndureRawNum; // 0x34
	private SimpleSafeFloat massRatioRawNum; // 0x38
	private string[] _resetAnimatorTriggerOnEnter; // 0x40
	private string[] _resetAnimatorTriggerOnExit; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAnimatorBoolean[] _setAnimatorBoolean; // 0x50
	private bool _enableRagDoll; // 0x58
	private bool _needFaceToAnimParam; // 0x59
	private bool _enableCCD; // 0x5A

	// Properties
	public Dictionary<string, string[]> animatorStates { /* [XID] */ /* 0x000000018986B5E0-0x000000018986B600 */ get => default; /* [XID] */ /* 0x00000001898729B0-0x00000001898729D0 */ private set {} } // 0x0000000181FCCA50-0x0000000181FCCAF0 0x0000000181FCE330-0x0000000181FCE3E0
	public MoveType moveType { /* [XID] */ /* 0x000000018987A610-0x000000018987A630 */ get => default; /* [XID] */ /* 0x0000000189881760-0x0000000189881780 */ private set {} } // 0x0000000181FCB240-0x0000000181FCB2E0 0x0000000181FCB190-0x0000000181FCB240
	public bool combatMoveOnWater { /* [XID] */ /* 0x0000000189888D20-0x0000000189888D40 */ get => default; /* [XID] */ /* 0x0000000189890100-0x0000000189890120 */ private set {} } // 0x0000000181FC9BE0-0x0000000181FC9C80 0x0000000181FCAA30-0x0000000181FCAAE0
	public bool canDoSkill { /* [XID] */ /* 0x0000000189897600-0x0000000189897620 */ get => default; /* [XID] */ /* 0x000000018989EBA0-0x000000018989EBC0 */ private set {} } // 0x0000000181FCB890-0x0000000181FCB930 0x0000000181FC9AD0-0x0000000181FC9B80
	public float canDoSkillStart { /* [XID] */ /* 0x00000001898A65C0-0x00000001898A65E0 */ get => default; /* [XID] */ /* 0x00000001898ADD10-0x00000001898ADD30 */ private set {} } // 0x0000000181FCAB60-0x0000000181FCAC40 0x0000000181FCB7B0-0x0000000181FCB890
	public float canDoSkillEnd { /* [XID] */ /* 0x00000001898B51D0-0x00000001898B51F0 */ get => default; /* [XID] */ /* 0x00000001898BCCC0-0x00000001898BCCE0 */ private set {} } // 0x0000000181FCB5B0-0x0000000181FCB690 0x0000000181FCD0F0-0x0000000181FCD1D0
	public bool canSyncMove { /* [XID] */ /* 0x00000001898C4420-0x00000001898C4440 */ get => default; /* [XID] */ /* 0x00000001898CB990-0x00000001898CB9B0 */ private set {} } // 0x0000000181FCAD70-0x0000000181FCAE10 0x0000000181FCC030-0x0000000181FCC0E0
	public bool cullingModelAlwaysAnimate { /* [XID] */ /* 0x00000001898D3170-0x00000001898D3190 */ get => default; /* [XID] */ /* 0x00000001898DAAA0-0x00000001898DAAC0 */ private set {} } // 0x0000000181FCC0E0-0x0000000181FCC180 0x0000000181FCB2E0-0x0000000181FCB390
	public float addEndure { /* [XID] */ /* 0x0000000189649B30-0x0000000189649B50 */ get => default; /* [XID] */ /* 0x00000001898EA3F0-0x00000001898EA410 */ private set {} } // 0x0000000181FCC730-0x0000000181FCC810 0x0000000181FCDF00-0x0000000181FCDFE0
	public float massRatio { /* [XID] */ /* 0x00000001898F1BB0-0x00000001898F1BD0 */ get => default; /* [XID] */ /* 0x00000001898F9370-0x00000001898F9390 */ private set {} } // 0x0000000181FC8230-0x0000000181FC8310 0x0000000181FCC360-0x0000000181FCC440
	public string[] resetAnimatorTriggerOnEnter { /* [XID] */ /* 0x0000000189900CB0-0x0000000189900CD0 */ get => default; /* [XID] */ /* 0x0000000189908470-0x0000000189908490 */ private set {} } // 0x0000000181FC9840-0x0000000181FC98E0 0x0000000181FCCAF0-0x0000000181FCCBA0
	public string[] resetAnimatorTriggerOnExit { /* [XID] */ /* 0x000000018990FBD0-0x000000018990FBF0 */ get => default; /* [XID] */ /* 0x0000000189917660-0x0000000189917680 */ private set {} } // 0x0000000181FCD1D0-0x0000000181FCD270 0x0000000181FCACC0-0x0000000181FCAD70
	public ConfigAnimatorBoolean[] setAnimatorBoolean { /* [XID] */ /* 0x000000018991ECC0-0x000000018991ECE0 */ get => default; /* [XID] */ /* 0x0000000189926560-0x0000000189926580 */ private set {} } // 0x0000000181FCC260-0x0000000181FCC300 0x0000000181FCC9A0-0x0000000181FCCA50
	public bool enableRagDoll { /* [XID] */ /* 0x000000018992DD10-0x000000018992DD30 */ get => default; /* [XID] */ /* 0x0000000189935050-0x0000000189935070 */ private set {} } // 0x0000000181FC9A30-0x0000000181FC9AD0 0x0000000181FCBC80-0x0000000181FCBD30
	public bool needFaceToAnimParam { /* [XID] */ /* 0x000000018993CC10-0x000000018993CC30 */ get => default; /* [XID] */ /* 0x0000000189944240-0x0000000189944260 */ private set {} } // 0x0000000181FC91A0-0x0000000181FC9240 0x0000000181FCB690-0x0000000181FCB740
	public bool enableCCD { /* [XID] */ /* 0x000000018994B8A0-0x000000018994B8C0 */ get => default; /* [XID] */ /* 0x0000000189953090-0x00000001899530B0 */ private set {} } // 0x0000000181FCC440-0x0000000181FCC4E0 0x0000000181FC9510-0x0000000181FC95C0

	// Constructors
	public ConfigNormalStateIDInfo() {} // 0x0000000181FCE540-0x0000000181FCE620

	// Methods
	// [XID] // 0x000000018995A730-0x000000018995A750
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FCDFE0-0x0000000181FCE260
	// [XID] // 0x0000000189962270-0x0000000189962290
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181FCC870-0x0000000181FCC9A0
	// [XID] // 0x0000000189969660-0x0000000189969680
	public override ConfigBaseStateIDInfo Clone(bool useObjectPool = false /* Metadata: 0x00AFB7F9 */) => default; // 0x0000000181FCC180-0x0000000181FCC260
	// [XID] // 0x0000000189971340-0x0000000189971360
	public override int GetHashNum() => default; // 0x0000000181FC9960-0x0000000181FC9A30
	// [XID] // 0x0000000189978D10-0x0000000189978D30
	public override void InitEmpty() {} // 0x0000000181FCB930-0x0000000181FCBAB0
	[BlackList] // 0x000000018997FE00-0x000000018997FE40
	// [XID] // 0x000000018997FE00-0x000000018997FE40
	public override bool FromJson(JSONNode node) => default; // 0x0000000181FCAE10-0x0000000181FCB190
	// [XID] // 0x000000018998AA00-0x000000018998AA20
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181FC8310-0x0000000181FC91A0
	[BlackList] // 0x00000001899922F0-0x0000000189992330
	// [XID] // 0x00000001899922F0-0x0000000189992330
	public static new ConfigNormalStateIDInfo ParseFromJson(JSONNode node) => default; // 0x0000000181FCC4E0-0x0000000181FCC730
	// [XID] // 0x000000018999CFB0-0x000000018999CFD0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7FA */, bool useObjectPool = false /* Metadata: 0x00AFB7FE */) => default; // 0x0000000181FCBD30-0x0000000181FCC030
	// [XID] // 0x00000001899A48B0-0x00000001899A48D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7FF */, bool useObjectPool = false /* Metadata: 0x00AFB803 */) => default; // 0x0000000181FC9FC0-0x0000000181FCAA30
	// [XID] // 0x00000001899AC1F0-0x00000001899AC210
	public static new ConfigNormalStateIDInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB804 */, bool useObjectPool = false /* Metadata: 0x00AFB808 */) => default; // 0x0000000181FCB390-0x0000000181FCB5B0
	[BlackList] // 0x00000001899B3A60-0x00000001899B3AA0
	// [XID] // 0x00000001899B3A60-0x00000001899B3AA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FC9240-0x0000000181FC9510
	// [XID] // 0x00000001899BE190-0x00000001899BE1B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FCD410-0x0000000181FCDF00
	[BlackList] // 0x00000001899C5950-0x00000001899C5990
	// [XID] // 0x00000001899C5950-0x00000001899C5990
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181FCBB90-0x0000000181FCBC80
	[BlackList] // 0x00000001899D0090-0x00000001899D00D0
	// [XID] // 0x00000001899D0090-0x00000001899D00D0
	public override void AutoAllocTypeFields() {} // 0x0000000181FC95C0-0x0000000181FC9660
	[BlackList] // 0x00000001899DA460-0x00000001899DA4A0
	// [XID] // 0x00000001899DA460-0x00000001899DA4A0
	public override void AutoRecycleTypeFields() {} // 0x0000000181FC9660-0x0000000181FC97A0
	[BlackList] // 0x00000001899E4F80-0x00000001899E4FC0
	// [XID] // 0x00000001899E4F80-0x00000001899E4FC0
	public override void ReturnToObjectPool() {} // 0x0000000181FCE4A0-0x0000000181FCE540
	// [XID] // 0x00000001899EF330-0x00000001899EF350
	public virtual void ProcessNormalizedTime(BaseEntity entity, float normalizedTime) {} // 0x0000000181FCE260-0x0000000181FCE330
	// [XID] // 0x00000001899F6CD0-0x00000001899F6CF0
	private void ProcessNormalizeBoolean(BaseEntity entity, float normalizedTime) {} // 0x0000000181FCD270-0x0000000181FCD410
	// [XID] // 0x00000001899FE350-0x00000001899FE370
	public override void HandleAnimatorState(BaseEntity entity, bool isTo, int fromStateID, int toStateID, VCAnimatorEvent animatorComponent) {} // 0x0000000181FCCBA0-0x0000000181FCD0F0
	// [XID] // 0x0000000189A05C10-0x0000000189A05C30
	public void SetColliderStartEndTime(BaseEntity entity, VCAnimatorEvent animatorComponent, float startTime, float endTime) {} // 0x0000000181FC9D00-0x0000000181FC9FC0
}

