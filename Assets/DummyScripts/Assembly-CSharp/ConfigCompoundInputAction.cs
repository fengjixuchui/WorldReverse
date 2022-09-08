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
public class ConfigCompoundInputAction : ConfigBaseInputAction, IAutoAllocRecycle // TypeDefIndex: 19099
{
	// Fields
	private InputActionType _action1; // 0x20
	private InputActionType _action2; // 0x24
	private ActionCompoundType _compoundType; // 0x28

	// Properties
	public InputActionType action1 { /* [XID] */ /* 0x0000000189A6C5E0-0x0000000189A6C600 */ get => default; /* [XID] */ /* 0x0000000189A73E10-0x0000000189A73E30 */ private set {} } // 0x0000000181C56A20-0x0000000181C56AC0 0x0000000181C575E0-0x0000000181C57690
	public InputActionType action2 { /* [XID] */ /* 0x0000000189A7B8E0-0x0000000189A7B900 */ get => default; /* [XID] */ /* 0x0000000189A830E0-0x0000000189A83100 */ private set {} } // 0x0000000181C56B30-0x0000000181C56BD0 0x0000000181C55EC0-0x0000000181C55F70
	public ActionCompoundType compoundType { /* [XID] */ /* 0x0000000189A8A930-0x0000000189A8A950 */ get => default; /* [XID] */ /* 0x0000000189A92290-0x0000000189A922B0 */ private set {} } // 0x0000000181C57690-0x0000000181C57730 0x0000000181C55430-0x0000000181C554E0

	// Constructors
	public ConfigCompoundInputAction() {} // 0x0000000181C57C10-0x0000000181C57C70

	// Methods
	// [XID] // 0x0000000189A99C20-0x0000000189A99C40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C57A40-0x0000000181C57B70
	// [XID] // 0x0000000189AA0C00-0x0000000189AA0C20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181C57530-0x0000000181C575E0
	// [XID] // 0x0000000189AA8220-0x0000000189AA8240
	public override ConfigBaseInputAction Clone(bool useObjectPool = false /* Metadata: 0x00AFBF0F */) => default; // 0x0000000181C57140-0x0000000181C57220
	// [XID] // 0x0000000189AAFEF0-0x0000000189AAFF10
	public override int GetHashNum() => default; // 0x0000000181C55DF0-0x0000000181C55EC0
	// [XID] // 0x0000000189AB75F0-0x0000000189AB7610
	public override void InitEmpty() {} // 0x0000000181C56BD0-0x0000000181C56C70
	[BlackList] // 0x0000000189ABF070-0x0000000189ABF0B0
	// [XID] // 0x0000000189ABF070-0x0000000189ABF0B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181C56480-0x0000000181C56800
	// [XID] // 0x0000000189AC9980-0x0000000189AC99A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181C554E0-0x0000000181C558B0
	[BlackList] // 0x0000000189AD1210-0x0000000189AD1250
	// [XID] // 0x0000000189AD1210-0x0000000189AD1250
	public static new ConfigCompoundInputAction ParseFromJson(JSONNode node) => default; // 0x0000000181C57280-0x0000000181C574D0
	// [XID] // 0x0000000189ADBFA0-0x0000000189ADBFC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBF10 */, bool useObjectPool = false /* Metadata: 0x00AFBF14 */) => default; // 0x0000000181C56E40-0x0000000181C57140
	// [XID] // 0x0000000189AE3910-0x0000000189AE3930
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBF15 */, bool useObjectPool = false /* Metadata: 0x00AFBF19 */) => default; // 0x0000000181C56050-0x0000000181C56380
	// [XID] // 0x0000000189AEB1B0-0x0000000189AEB1D0
	public static new ConfigCompoundInputAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBF1A */, bool useObjectPool = false /* Metadata: 0x00AFBF1E */) => default; // 0x0000000181C56800-0x0000000181C56A20
	[BlackList] // 0x0000000189AF2B50-0x0000000189AF2B90
	// [XID] // 0x0000000189AF2B50-0x0000000189AF2B90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C558B0-0x0000000181C55B80
	// [XID] // 0x0000000189AFCE90-0x0000000189AFCEB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C57730-0x0000000181C57A40
	[BlackList] // 0x0000000189B04680-0x0000000189B046C0
	// [XID] // 0x0000000189B04680-0x0000000189B046C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181C56D50-0x0000000181C56E40
	[BlackList] // 0x0000000189B0EE90-0x0000000189B0EED0
	// [XID] // 0x0000000189B0EE90-0x0000000189B0EED0
	public override void AutoAllocTypeFields() {} // 0x0000000181C55B80-0x0000000181C55C20
	[BlackList] // 0x0000000189B19310-0x0000000189B19350
	// [XID] // 0x0000000189B19310-0x0000000189B19350
	public override void AutoRecycleTypeFields() {} // 0x0000000181C55C20-0x0000000181C55CD0
	[BlackList] // 0x0000000189B23C80-0x0000000189B23CC0
	// [XID] // 0x0000000189B23C80-0x0000000189B23CC0
	public override void ReturnToObjectPool() {} // 0x0000000181C57B70-0x0000000181C57C10
}

