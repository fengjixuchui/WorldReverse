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
public class ConfigAIFacingMoveSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17447
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFacingMoveData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIFacingMoveData> _specification; // 0x30

	// Properties
	public ConfigAIFacingMoveData defaultSetting { /* [XID] */ /* 0x00000001897BBCD0-0x00000001897BBCF0 */ get => default; /* [XID] */ /* 0x00000001897C3550-0x00000001897C3570 */ private set {} } // 0x00000001837D2570-0x00000001837D2610 0x00000001837D03B0-0x00000001837D0460
	public Dictionary<SimpleSafeInt32, ConfigAIFacingMoveData> specification { /* [XID] */ /* 0x00000001897CAD70-0x00000001897CAD90 */ get => default; /* [XID] */ /* 0x00000001897D2390-0x00000001897D23B0 */ private set {} } // 0x00000001837D0A60-0x00000001837D0B00 0x00000001837D1FD0-0x00000001837D2080

	// Constructors
	public ConfigAIFacingMoveSetting() {} // 0x00000001837D2AB0-0x00000001837D2B30

	// Methods
	// [XID] // 0x00000001897DA130-0x00000001897DA150
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837D28F0-0x00000001837D2A10
	// [XID] // 0x00000001897E14C0-0x00000001897E14E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001837D2470-0x00000001837D2570
	// [XID] // 0x00000001897E8D50-0x00000001897E8D70
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6EE9 */) => default; // 0x00000001837D2080-0x00000001837D2160
	// [XID] // 0x00000001897F09E0-0x00000001897F0A00
	public override int GetHashNum() => default; // 0x00000001837D0E10-0x00000001837D0EE0
	// [XID] // 0x00000001897F8080-0x00000001897F80A0
	public override void InitEmpty() {} // 0x00000001837D1A10-0x00000001837D1B00
	[BlackList] // 0x00000001897FF830-0x00000001897FF870
	// [XID] // 0x00000001897FF830-0x00000001897FF870
	public override bool FromJson(JSONNode node) => default; // 0x00000001837D1400-0x00000001837D1780
	// [XID] // 0x0000000189809DD0-0x0000000189809DF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001837D0460-0x00000001837D0790
	[BlackList] // 0x0000000189811500-0x0000000189811540
	// [XID] // 0x0000000189811500-0x0000000189811540
	public static new ConfigAIFacingMoveSetting ParseFromJson(JSONNode node) => default; // 0x00000001837D21C0-0x00000001837D2410
	// [XID] // 0x000000018981BE40-0x000000018981BE60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EEA */, bool useObjectPool = false /* Metadata: 0x00AF6EEE */) => default; // 0x00000001837D1CD0-0x00000001837D1FD0
	// [XID] // 0x00000001898232F0-0x0000000189823310
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EEF */, bool useObjectPool = false /* Metadata: 0x00AF6EF3 */) => default; // 0x00000001837D0FC0-0x00000001837D1300
	// [XID] // 0x000000018982ACD0-0x000000018982ACF0
	public static new ConfigAIFacingMoveSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EF4 */, bool useObjectPool = false /* Metadata: 0x00AF6EF8 */) => default; // 0x00000001837D1780-0x00000001837D19A0
	[BlackList] // 0x00000001898321B0-0x00000001898321F0
	// [XID] // 0x00000001898321B0-0x00000001898321F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001837D0790-0x00000001837D0A60
	// [XID] // 0x000000018983C890-0x000000018983C8B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837D2610-0x00000001837D28F0
	[BlackList] // 0x0000000189843FC0-0x0000000189844000
	// [XID] // 0x0000000189843FC0-0x0000000189844000
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001837D1BE0-0x00000001837D1CD0
	[BlackList] // 0x000000018984E3E0-0x000000018984E420
	// [XID] // 0x000000018984E3E0-0x000000018984E420
	public override void AutoAllocTypeFields() {} // 0x00000001837D0B00-0x00000001837D0BA0
	[BlackList] // 0x0000000189858740-0x0000000189858780
	// [XID] // 0x0000000189858740-0x0000000189858780
	public override void AutoRecycleTypeFields() {} // 0x00000001837D0BA0-0x00000001837D0CF0
	[BlackList] // 0x0000000189862C10-0x0000000189862C50
	// [XID] // 0x0000000189862C10-0x0000000189862C50
	public override void ReturnToObjectPool() {} // 0x00000001837D2A10-0x00000001837D2AB0
}

