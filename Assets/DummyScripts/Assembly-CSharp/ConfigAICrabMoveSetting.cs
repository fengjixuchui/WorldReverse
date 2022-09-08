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
public class ConfigAICrabMoveSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17459
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAICrabMoveData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAICrabMoveData> _specification; // 0x30

	// Properties
	public ConfigAICrabMoveData defaultSetting { /* [XID] */ /* 0x0000000189897920-0x0000000189897940 */ get => default; /* [XID] */ /* 0x000000018989EDA0-0x000000018989EDC0 */ private set {} } // 0x00000001821450A0-0x0000000182145140 0x0000000182142EE0-0x0000000182142F90
	public Dictionary<SimpleSafeInt32, ConfigAICrabMoveData> specification { /* [XID] */ /* 0x00000001898A6860-0x00000001898A6880 */ get => default; /* [XID] */ /* 0x00000001898ADF70-0x00000001898ADF90 */ private set {} } // 0x0000000182143590-0x0000000182143630 0x0000000182144B00-0x0000000182144BB0

	// Constructors
	public ConfigAICrabMoveSetting() {} // 0x00000001821455E0-0x0000000182145660

	// Methods
	// [XID] // 0x00000001898B5550-0x00000001898B5570
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182145420-0x0000000182145540
	// [XID] // 0x00000001898BCF60-0x00000001898BCF80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182144FA0-0x00000001821450A0
	// [XID] // 0x00000001898C46E0-0x00000001898C4700
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6F51 */) => default; // 0x0000000182144BB0-0x0000000182144C90
	// [XID] // 0x00000001898CBD10-0x00000001898CBD30
	public override int GetHashNum() => default; // 0x0000000182143940-0x0000000182143A10
	// [XID] // 0x00000001898D35B0-0x00000001898D35D0
	public override void InitEmpty() {} // 0x0000000182144540-0x0000000182144630
	[BlackList] // 0x00000001898DAD20-0x00000001898DAD60
	// [XID] // 0x00000001898DAD20-0x00000001898DAD60
	public override bool FromJson(JSONNode node) => default; // 0x0000000182143F30-0x00000001821442B0
	// [XID] // 0x00000001898E5BC0-0x00000001898E5BE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182142F90-0x00000001821432C0
	[BlackList] // 0x00000001898ED500-0x00000001898ED540
	// [XID] // 0x00000001898ED500-0x00000001898ED540
	public static new ConfigAICrabMoveSetting ParseFromJson(JSONNode node) => default; // 0x0000000182144CF0-0x0000000182144F40
	// [XID] // 0x00000001898F7F10-0x00000001898F7F30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F52 */, bool useObjectPool = false /* Metadata: 0x00AF6F56 */) => default; // 0x0000000182144800-0x0000000182144B00
	// [XID] // 0x00000001898FF570-0x00000001898FF590
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F57 */, bool useObjectPool = false /* Metadata: 0x00AF6F5B */) => default; // 0x0000000182143AF0-0x0000000182143E30
	// [XID] // 0x0000000189906D50-0x0000000189906D70
	public static new ConfigAICrabMoveSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F5C */, bool useObjectPool = false /* Metadata: 0x00AF6F60 */) => default; // 0x00000001821442B0-0x00000001821444D0
	[BlackList] // 0x000000018990E790-0x000000018990E7D0
	// [XID] // 0x000000018990E790-0x000000018990E7D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001821432C0-0x0000000182143590
	// [XID] // 0x00000001899190C0-0x00000001899190E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182145140-0x0000000182145420
	[BlackList] // 0x0000000189920650-0x0000000189920690
	// [XID] // 0x0000000189920650-0x0000000189920690
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182144710-0x0000000182144800
	[BlackList] // 0x000000018992AF20-0x000000018992AF60
	// [XID] // 0x000000018992AF20-0x000000018992AF60
	public override void AutoAllocTypeFields() {} // 0x0000000182143630-0x00000001821436D0
	[BlackList] // 0x00000001899352D0-0x0000000189935310
	// [XID] // 0x00000001899352D0-0x0000000189935310
	public override void AutoRecycleTypeFields() {} // 0x00000001821436D0-0x0000000182143820
	[BlackList] // 0x000000018993FC60-0x000000018993FCA0
	// [XID] // 0x000000018993FC60-0x000000018993FCA0
	public override void ReturnToObjectPool() {} // 0x0000000182145540-0x00000001821455E0
}

