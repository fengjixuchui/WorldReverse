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
public class ConfigAIFollowServerRouteSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17427
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFollowServerRouteData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIFollowServerRouteData> _specification; // 0x30

	// Properties
	public ConfigAIFollowServerRouteData defaultSetting { /* [XID] */ /* 0x0000000189819030-0x0000000189819050 */ get => default; /* [XID] */ /* 0x0000000189820830-0x0000000189820850 */ private set {} } // 0x0000000183116C30-0x0000000183116CD0 0x0000000183114A70-0x0000000183114B20
	public Dictionary<SimpleSafeInt32, ConfigAIFollowServerRouteData> specification { /* [XID] */ /* 0x0000000189827E80-0x0000000189827EA0 */ get => default; /* [XID] */ /* 0x000000018982F120-0x000000018982F140 */ private set {} } // 0x0000000183115120-0x00000001831151C0 0x0000000183116690-0x0000000183116740

	// Constructors
	public ConfigAIFollowServerRouteSetting() {} // 0x0000000183117170-0x00000001831171F0

	// Methods
	// [XID] // 0x00000001898369D0-0x00000001898369F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183116FB0-0x00000001831170D0
	// [XID] // 0x000000018983DDC0-0x000000018983DDE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183116B30-0x0000000183116C30
	// [XID] // 0x00000001898455F0-0x0000000189845610
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6E39 */) => default; // 0x0000000183116740-0x0000000183116820
	// [XID] // 0x000000018984CBA0-0x000000018984CBC0
	public override int GetHashNum() => default; // 0x00000001831154D0-0x00000001831155A0
	// [XID] // 0x0000000189853C00-0x0000000189853C20
	public override void InitEmpty() {} // 0x00000001831160D0-0x00000001831161C0
	[BlackList] // 0x000000018985B5F0-0x000000018985B630
	// [XID] // 0x000000018985B5F0-0x000000018985B630
	public override bool FromJson(JSONNode node) => default; // 0x0000000183115AC0-0x0000000183115E40
	// [XID] // 0x00000001898657D0-0x00000001898657F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183114B20-0x0000000183114E50
	[BlackList] // 0x000000018986CCF0-0x000000018986CD30
	// [XID] // 0x000000018986CCF0-0x000000018986CD30
	public static new ConfigAIFollowServerRouteSetting ParseFromJson(JSONNode node) => default; // 0x0000000183116880-0x0000000183116AD0
	// [XID] // 0x0000000189877430-0x0000000189877450
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E3A */, bool useObjectPool = false /* Metadata: 0x00AF6E3E */) => default; // 0x0000000183116390-0x0000000183116690
	// [XID] // 0x000000018987ECA0-0x000000018987ECC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E3F */, bool useObjectPool = false /* Metadata: 0x00AF6E43 */) => default; // 0x0000000183115680-0x00000001831159C0
	// [XID] // 0x0000000189886140-0x0000000189886160
	public static new ConfigAIFollowServerRouteSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E44 */, bool useObjectPool = false /* Metadata: 0x00AF6E48 */) => default; // 0x0000000183115E40-0x0000000183116060
	[BlackList] // 0x000000018988D3C0-0x000000018988D400
	// [XID] // 0x000000018988D3C0-0x000000018988D400
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183114E50-0x0000000183115120
	// [XID] // 0x0000000189897940-0x0000000189897960
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183116CD0-0x0000000183116FB0
	[BlackList] // 0x000000018989EDC0-0x000000018989EE00
	// [XID] // 0x000000018989EDC0-0x000000018989EE00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001831162A0-0x0000000183116390
	[BlackList] // 0x00000001898A96F0-0x00000001898A9730
	// [XID] // 0x00000001898A96F0-0x00000001898A9730
	public override void AutoAllocTypeFields() {} // 0x00000001831151C0-0x0000000183115260
	[BlackList] // 0x00000001898B3B80-0x00000001898B3BC0
	// [XID] // 0x00000001898B3B80-0x00000001898B3BC0
	public override void AutoRecycleTypeFields() {} // 0x0000000183115260-0x00000001831153B0
	[BlackList] // 0x00000001898BE4C0-0x00000001898BE500
	// [XID] // 0x00000001898BE4C0-0x00000001898BE500
	public override void ReturnToObjectPool() {} // 0x00000001831170D0-0x0000000183117170
}

