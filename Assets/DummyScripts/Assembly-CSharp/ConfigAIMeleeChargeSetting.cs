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
public class ConfigAIMeleeChargeSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17443
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIMeleeChargeData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIMeleeChargeData> _specification; // 0x30

	// Properties
	public ConfigAIMeleeChargeData defaultSetting { /* [XID] */ /* 0x0000000189B1AEA0-0x0000000189B1AEC0 */ get => default; /* [XID] */ /* 0x0000000189B22590-0x0000000189B225B0 */ private set {} } // 0x00000001829DF380-0x00000001829DF420 0x00000001829DD1C0-0x00000001829DD270
	public Dictionary<SimpleSafeInt32, ConfigAIMeleeChargeData> specification { /* [XID] */ /* 0x0000000189B29AC0-0x0000000189B29AE0 */ get => default; /* [XID] */ /* 0x0000000189B31090-0x0000000189B310B0 */ private set {} } // 0x00000001829DD870-0x00000001829DD910 0x00000001829DEDE0-0x00000001829DEE90

	// Constructors
	public ConfigAIMeleeChargeSetting() {} // 0x00000001829DF8C0-0x00000001829DF940

	// Methods
	// [XID] // 0x0000000189B386D0-0x0000000189B386F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829DF700-0x00000001829DF820
	// [XID] // 0x0000000189B40120-0x0000000189B40140
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829DF280-0x00000001829DF380
	// [XID] // 0x0000000189B47A40-0x0000000189B47A60
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6EC5 */) => default; // 0x00000001829DEE90-0x00000001829DEF70
	// [XID] // 0x0000000189B4F1D0-0x0000000189B4F1F0
	public override int GetHashNum() => default; // 0x00000001829DDC20-0x00000001829DDCF0
	// [XID] // 0x0000000189B56BB0-0x0000000189B56BD0
	public override void InitEmpty() {} // 0x00000001829DE820-0x00000001829DE910
	[BlackList] // 0x0000000189B5E460-0x0000000189B5E4A0
	// [XID] // 0x0000000189B5E460-0x0000000189B5E4A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001829DE210-0x00000001829DE590
	// [XID] // 0x0000000189B68A20-0x0000000189B68A40
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829DD270-0x00000001829DD5A0
	[BlackList] // 0x0000000189B6FF60-0x0000000189B6FFA0
	// [XID] // 0x0000000189B6FF60-0x0000000189B6FFA0
	public static new ConfigAIMeleeChargeSetting ParseFromJson(JSONNode node) => default; // 0x00000001829DEFD0-0x00000001829DF220
	// [XID] // 0x0000000189B7A4F0-0x0000000189B7A510
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EC6 */, bool useObjectPool = false /* Metadata: 0x00AF6ECA */) => default; // 0x00000001829DEAE0-0x00000001829DEDE0
	// [XID] // 0x0000000189B81C50-0x0000000189B81C70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6ECB */, bool useObjectPool = false /* Metadata: 0x00AF6ECF */) => default; // 0x00000001829DDDD0-0x00000001829DE110
	// [XID] // 0x0000000189B89370-0x0000000189B89390
	public static new ConfigAIMeleeChargeSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6ED0 */, bool useObjectPool = false /* Metadata: 0x00AF6ED4 */) => default; // 0x00000001829DE590-0x00000001829DE7B0
	[BlackList] // 0x0000000189B90910-0x0000000189B90950
	// [XID] // 0x0000000189B90910-0x0000000189B90950
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829DD5A0-0x00000001829DD870
	// [XID] // 0x0000000189B9AC20-0x0000000189B9AC40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829DF420-0x00000001829DF700
	[BlackList] // 0x0000000189BA23F0-0x0000000189BA2430
	// [XID] // 0x0000000189BA23F0-0x0000000189BA2430
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829DE9F0-0x00000001829DEAE0
	[BlackList] // 0x0000000189BAC4D0-0x0000000189BAC510
	// [XID] // 0x0000000189BAC4D0-0x0000000189BAC510
	public override void AutoAllocTypeFields() {} // 0x00000001829DD910-0x00000001829DD9B0
	[BlackList] // 0x0000000189BB6B70-0x0000000189BB6BB0
	// [XID] // 0x0000000189BB6B70-0x0000000189BB6BB0
	public override void AutoRecycleTypeFields() {} // 0x00000001829DD9B0-0x00000001829DDB00
	[BlackList] // 0x0000000189BC1960-0x0000000189BC19A0
	// [XID] // 0x0000000189BC1960-0x0000000189BC19A0
	public override void ReturnToObjectPool() {} // 0x00000001829DF820-0x00000001829DF8C0
}

