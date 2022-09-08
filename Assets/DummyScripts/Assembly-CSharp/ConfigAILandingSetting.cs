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
public class ConfigAILandingSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17480
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAILandingData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAILandingData> _specification; // 0x30

	// Properties
	public ConfigAILandingData defaultSetting { /* [XID] */ /* 0x0000000189800F20-0x0000000189800F40 */ get => default; /* [XID] */ /* 0x00000001898083C0-0x00000001898083E0 */ private set {} } // 0x0000000181BD4F10-0x0000000181BD4FB0 0x0000000181BD2D50-0x0000000181BD2E00
	public Dictionary<SimpleSafeInt32, ConfigAILandingData> specification { /* [XID] */ /* 0x000000018980FF10-0x000000018980FF30 */ get => default; /* [XID] */ /* 0x00000001898174C0-0x00000001898174E0 */ private set {} } // 0x0000000181BD3400-0x0000000181BD34A0 0x0000000181BD4970-0x0000000181BD4A20

	// Constructors
	public ConfigAILandingSetting() {} // 0x0000000181BD5450-0x0000000181BD54D0

	// Methods
	// [XID] // 0x000000018981EEA0-0x000000018981EEC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181BD5290-0x0000000181BD53B0
	// [XID] // 0x0000000189826350-0x0000000189826370
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181BD4E10-0x0000000181BD4F10
	// [XID] // 0x000000018982D980-0x000000018982D9A0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF7007 */) => default; // 0x0000000181BD4A20-0x0000000181BD4B00
	// [XID] // 0x0000000189835130-0x0000000189835150
	public override int GetHashNum() => default; // 0x0000000181BD37B0-0x0000000181BD3880
	// [XID] // 0x000000018983C830-0x000000018983C850
	public override void InitEmpty() {} // 0x0000000181BD43B0-0x0000000181BD44A0
	[BlackList] // 0x0000000189843F80-0x0000000189843FC0
	// [XID] // 0x0000000189843F80-0x0000000189843FC0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181BD3DA0-0x0000000181BD4120
	// [XID] // 0x000000018984E360-0x000000018984E380
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181BD2E00-0x0000000181BD3130
	[BlackList] // 0x0000000189855550-0x0000000189855590
	// [XID] // 0x0000000189855550-0x0000000189855590
	public static new ConfigAILandingSetting ParseFromJson(JSONNode node) => default; // 0x0000000181BD4B60-0x0000000181BD4DB0
	// [XID] // 0x000000018985F830-0x000000018985F850
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7008 */, bool useObjectPool = false /* Metadata: 0x00AF700C */) => default; // 0x0000000181BD4670-0x0000000181BD4970
	// [XID] // 0x0000000189867070-0x0000000189867090
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF700D */, bool useObjectPool = false /* Metadata: 0x00AF7011 */) => default; // 0x0000000181BD3960-0x0000000181BD3CA0
	// [XID] // 0x000000018986E890-0x000000018986E8B0
	public static new ConfigAILandingSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7012 */, bool useObjectPool = false /* Metadata: 0x00AF7016 */) => default; // 0x0000000181BD4120-0x0000000181BD4340
	[BlackList] // 0x0000000189875D40-0x0000000189875D80
	// [XID] // 0x0000000189875D40-0x0000000189875D80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181BD3130-0x0000000181BD3400
	// [XID] // 0x0000000189880420-0x0000000189880440
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181BD4FB0-0x0000000181BD5290
	[BlackList] // 0x0000000189887900-0x0000000189887940
	// [XID] // 0x0000000189887900-0x0000000189887940
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181BD4580-0x0000000181BD4670
	[BlackList] // 0x0000000189891B00-0x0000000189891B40
	// [XID] // 0x0000000189891B00-0x0000000189891B40
	public override void AutoAllocTypeFields() {} // 0x0000000181BD34A0-0x0000000181BD3540
	[BlackList] // 0x000000018989C0A0-0x000000018989C0E0
	// [XID] // 0x000000018989C0A0-0x000000018989C0E0
	public override void AutoRecycleTypeFields() {} // 0x0000000181BD3540-0x0000000181BD3690
	[BlackList] // 0x00000001898A6820-0x00000001898A6860
	// [XID] // 0x00000001898A6820-0x00000001898A6860
	public override void ReturnToObjectPool() {} // 0x0000000181BD53B0-0x0000000181BD5450
}

