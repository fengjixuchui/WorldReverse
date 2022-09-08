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
public class ConfigAITSTargetDistanceSetting : ConfigAIThreatScoreBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17393
{
	// Constructors
	public ConfigAITSTargetDistanceSetting() {} // 0x000000018160A580-0x000000018160A5E0

	// Methods
	// [XID] // 0x0000000189776140-0x0000000189776160
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018160A330-0x000000018160A3E0
	// [XID] // 0x000000018977D7A0-0x000000018977D7C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018160A190-0x000000018160A240
	// [XID] // 0x00000001897850E0-0x0000000189785100
	public override ConfigAIThreatScoreBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6D03 */) => default; // 0x0000000181609DA0-0x0000000181609E80
	// [XID] // 0x000000018978C5B0-0x000000018978C5D0
	public override int GetHashNum() => default; // 0x0000000181608E40-0x0000000181608F10
	// [XID] // 0x0000000189793AA0-0x0000000189793AC0
	public override void InitEmpty() {} // 0x0000000181609830-0x00000001816098D0
	[BlackList] // 0x000000018979BD10-0x000000018979BD50
	// [XID] // 0x000000018979BD10-0x000000018979BD50
	public override bool FromJson(JSONNode node) => default; // 0x0000000181609220-0x00000001816095A0
	// [XID] // 0x00000001897A63C0-0x00000001897A63E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181608780-0x0000000181608870
	[BlackList] // 0x00000001897AD8D0-0x00000001897AD910
	// [XID] // 0x00000001897AD8D0-0x00000001897AD910
	public static new ConfigAITSTargetDistanceSetting ParseFromJson(JSONNode node) => default; // 0x0000000181609EE0-0x000000018160A130
	// [XID] // 0x00000001897B8760-0x00000001897B8780
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D04 */, bool useObjectPool = false /* Metadata: 0x00AF6D08 */) => default; // 0x0000000181609AA0-0x0000000181609DA0
	// [XID] // 0x00000001897C07C0-0x00000001897C07E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D09 */, bool useObjectPool = false /* Metadata: 0x00AF6D0D */) => default; // 0x0000000181608FF0-0x0000000181609120
	// [XID] // 0x00000001897C8010-0x00000001897C8030
	public static new ConfigAITSTargetDistanceSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D0E */, bool useObjectPool = false /* Metadata: 0x00AF6D12 */) => default; // 0x00000001816095A0-0x00000001816097C0
	[BlackList] // 0x00000001897CF390-0x00000001897CF3D0
	// [XID] // 0x00000001897CF390-0x00000001897CF3D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181608870-0x0000000181608B40
	// [XID] // 0x00000001897DA150-0x00000001897DA170
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018160A240-0x000000018160A330
	[BlackList] // 0x00000001897E14E0-0x00000001897E1520
	// [XID] // 0x00000001897E14E0-0x00000001897E1520
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001816099B0-0x0000000181609AA0
	[BlackList] // 0x00000001897EC060-0x00000001897EC0A0
	// [XID] // 0x00000001897EC060-0x00000001897EC0A0
	public override void AutoAllocTypeFields() {} // 0x0000000181608BE0-0x0000000181608C80
	[BlackList] // 0x00000001897F6680-0x00000001897F66C0
	// [XID] // 0x00000001897F6680-0x00000001897F66C0
	public override void AutoRecycleTypeFields() {} // 0x0000000181608C80-0x0000000181608D20
	[BlackList] // 0x0000000189800F80-0x0000000189800FC0
	// [XID] // 0x0000000189800F80-0x0000000189800FC0
	public override void ReturnToObjectPool() {} // 0x000000018160A4E0-0x000000018160A580
	// [XID] // 0x000000018980B480-0x000000018980B4A0
	public override float CalculateScore(AIKnowledge aiKnowledge, ThreatInfo threatInfo, ThreadRuntimeInfo threatRuntimeInfo) => default; // 0x000000018160A3E0-0x000000018160A4E0
}

