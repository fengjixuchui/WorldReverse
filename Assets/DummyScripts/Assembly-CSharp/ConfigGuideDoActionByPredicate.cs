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
public class ConfigGuideDoActionByPredicate : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18330
{
	// Fields
	private ConfigGuideCondition[][] _predicates; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideAction[] _actions; // 0x20

	// Properties
	public ConfigGuideCondition[][] predicates { /* [XID] */ /* 0x000000018981A5E0-0x000000018981A600 */ get => default; /* [XID] */ /* 0x0000000189821D90-0x0000000189821DB0 */ private set {} } // 0x0000000181D57D80-0x0000000181D57E20 0x0000000181D578C0-0x0000000181D57970
	public ConfigGuideAction[] actions { /* [XID] */ /* 0x0000000189829230-0x0000000189829250 */ get => default; /* [XID] */ /* 0x0000000189830880-0x00000001898308A0 */ private set {} } // 0x0000000181D57E20-0x0000000181D57EC0 0x0000000181D56360-0x0000000181D56410

	// Constructors
	public ConfigGuideDoActionByPredicate() {} // 0x0000000181D583E0-0x0000000181D58440

	// Methods
	// [XID] // 0x0000000189837D80-0x0000000189837DA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181D58230-0x0000000181D58340
	// [XID] // 0x000000018983F570-0x000000018983F590
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181D57C80-0x0000000181D57D80
	// [XID] // 0x0000000189846BF0-0x0000000189846C10
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF945B */) => default; // 0x0000000181D577E0-0x0000000181D578C0
	// [XID] // 0x000000018984E240-0x000000018984E260
	public override int GetHashNum() => default; // 0x0000000181D56530-0x0000000181D56600
	// [XID] // 0x0000000189855370-0x0000000189855390
	public override void InitEmpty() {} // 0x0000000181D571B0-0x0000000181D572A0
	[BlackList] // 0x000000018985C9D0-0x000000018985CA10
	// [XID] // 0x000000018985C9D0-0x000000018985CA10
	public override bool FromJson(JSONNode node) => default; // 0x0000000181D56BA0-0x0000000181D56F20
	// [XID] // 0x0000000189866ED0-0x0000000189866EF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181D55C10-0x0000000181D55F30
	[BlackList] // 0x000000018986E6D0-0x000000018986E710
	// [XID] // 0x000000018986E6D0-0x000000018986E710
	public static new ConfigGuideDoActionByPredicate ParseFromJson(JSONNode node) => default; // 0x0000000181D579D0-0x0000000181D57C20
	// [XID] // 0x0000000189878C50-0x0000000189878C70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF945C */, bool useObjectPool = false /* Metadata: 0x00AF9460 */) => default; // 0x0000000181D574E0-0x0000000181D577E0
	// [XID] // 0x0000000189880220-0x0000000189880240
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9461 */, bool useObjectPool = false /* Metadata: 0x00AF9465 */) => default; // 0x0000000181D56790-0x0000000181D56AA0
	// [XID] // 0x0000000189887740-0x0000000189887760
	public static new ConfigGuideDoActionByPredicate ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9466 */, bool useObjectPool = false /* Metadata: 0x00AF946A */) => default; // 0x0000000181D56F20-0x0000000181D57140
	[BlackList] // 0x000000018988EA60-0x000000018988EAA0
	// [XID] // 0x000000018988EA60-0x000000018988EAA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181D55F30-0x0000000181D56200
	// [XID] // 0x0000000189899290-0x00000001898992B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181D57F40-0x0000000181D58230
	[BlackList] // 0x00000001898A0430-0x00000001898A0470
	// [XID] // 0x00000001898A0430-0x00000001898A0470
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181D573F0-0x0000000181D574E0
	// [XID] // 0x00000001898AA960-0x00000001898AA980
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x0000000181D566E0-0x0000000181D56790
	// [XID] // 0x00000001898B2310-0x00000001898B2330
	protected override bool Stop() => default; // 0x0000000181D55B70-0x0000000181D55C10
	[BlackList] // 0x00000001898BA080-0x00000001898BA0C0
	// [XID] // 0x00000001898BA080-0x00000001898BA0C0
	public override void AutoAllocTypeFields() {} // 0x0000000181D56200-0x0000000181D562A0
	[BlackList] // 0x00000001898C4520-0x00000001898C4560
	// [XID] // 0x00000001898C4520-0x00000001898C4560
	public override void AutoRecycleTypeFields() {} // 0x0000000181D562A0-0x0000000181D56360
	[BlackList] // 0x00000001898CEB30-0x00000001898CEB70
	// [XID] // 0x00000001898CEB30-0x00000001898CEB70
	public override void ReturnToObjectPool() {} // 0x0000000181D58340-0x0000000181D583E0
}

