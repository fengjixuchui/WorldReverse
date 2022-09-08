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
public class ConfigNormalStateLayer : ConfigBaseStateLayer, IAutoAllocRecycle // TypeDefIndex: 19037
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigNormalStateIDInfo> _stateIDs; // 0x28

	// Properties
	public Dictionary<string, ConfigNormalStateIDInfo> stateIDs { /* [XID] */ /* 0x00000001899702E0-0x0000000189970300 */ get => default; /* [XID] */ /* 0x00000001898900E0-0x0000000189890100 */ private set {} } // 0x0000000181ED7E30-0x0000000181ED7ED0 0x0000000181ED7ED0-0x0000000181ED7F80

	// Constructors
	public ConfigNormalStateLayer() {} // 0x0000000181ED8100-0x0000000181ED8160

	// Methods
	// [XID] // 0x00000001898975E0-0x0000000189897600
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181ED7D40-0x0000000181ED7E30
	// [XID] // 0x000000018989EB80-0x000000018989EBA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181ED7A20-0x0000000181ED7B00
	// [XID] // 0x00000001898A65A0-0x00000001898A65C0
	public override ConfigBaseStateLayer Clone(bool useObjectPool = false /* Metadata: 0x00AFB849 */) => default; // 0x0000000181ED7630-0x0000000181ED7710
	// [XID] // 0x00000001898ADCF0-0x00000001898ADD10
	public override int GetHashNum() => default; // 0x0000000181ED60F0-0x0000000181ED61C0
	// [XID] // 0x00000001898B51B0-0x00000001898B51D0
	public override void InitEmpty() {} // 0x0000000181ED6E50-0x0000000181ED6F20
	[BlackList] // 0x00000001898BCC80-0x00000001898BCCC0
	// [XID] // 0x00000001898BCC80-0x00000001898BCCC0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181ED6610-0x0000000181ED6990
	// [XID] // 0x00000001898C7420-0x00000001898C7440
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181ED5970-0x0000000181ED5BA0
	[BlackList] // 0x00000001898CEA10-0x00000001898CEA50
	// [XID] // 0x00000001898CEA10-0x00000001898CEA50
	public static new ConfigNormalStateLayer ParseFromJson(JSONNode node) => default; // 0x0000000181ED7770-0x0000000181ED79C0
	// [XID] // 0x00000001898D9450-0x00000001898D9470
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB84A */, bool useObjectPool = false /* Metadata: 0x00AFB84E */) => default; // 0x0000000181ED70F0-0x0000000181ED73F0
	// [XID] // 0x00000001898E1020-0x00000001898E1040
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB84F */, bool useObjectPool = false /* Metadata: 0x00AFB853 */) => default; // 0x0000000181ED62A0-0x0000000181ED6510
	// [XID] // 0x00000001898E8AA0-0x00000001898E8AC0
	public static new ConfigNormalStateLayer ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB854 */, bool useObjectPool = false /* Metadata: 0x00AFB858 */) => default; // 0x0000000181ED6990-0x0000000181ED6BB0
	[BlackList] // 0x00000001898F01E0-0x00000001898F0220
	// [XID] // 0x00000001898F01E0-0x00000001898F0220
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181ED5BA0-0x0000000181ED5E70
	// [XID] // 0x00000001898FA8E0-0x00000001898FA900
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181ED7B00-0x0000000181ED7D40
	[BlackList] // 0x00000001899024C0-0x0000000189902500
	// [XID] // 0x00000001899024C0-0x0000000189902500
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181ED7000-0x0000000181ED70F0
	[BlackList] // 0x000000018990CC70-0x000000018990CCB0
	// [XID] // 0x000000018990CC70-0x000000018990CCB0
	public override void AutoAllocTypeFields() {} // 0x0000000181ED5E70-0x0000000181ED5F10
	[BlackList] // 0x0000000189917620-0x0000000189917660
	// [XID] // 0x0000000189917620-0x0000000189917660
	public override void AutoRecycleTypeFields() {} // 0x0000000181ED5F10-0x0000000181ED5FD0
	[BlackList] // 0x0000000189921EA0-0x0000000189921EE0
	// [XID] // 0x0000000189921EA0-0x0000000189921EE0
	public override void ReturnToObjectPool() {} // 0x0000000181ED8060-0x0000000181ED8100
	// [XID] // 0x000000018992C3E0-0x000000018992C400
	public override void InitLayer() {} // 0x0000000181ED6BB0-0x0000000181ED6DE0
	// [XID] // 0x00000001899339E0-0x0000000189933A00
	public override void GetContainerAnimatorStates(Action<int, string, Dictionary<string, string[]>> func) {} // 0x0000000181ED73F0-0x0000000181ED7630
}

