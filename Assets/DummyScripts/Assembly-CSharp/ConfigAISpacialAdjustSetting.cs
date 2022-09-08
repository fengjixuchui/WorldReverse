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
public class ConfigAISpacialAdjustSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17471
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISpacialAdjustData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAISpacialAdjustData> _specification; // 0x30

	// Properties
	public ConfigAISpacialAdjustData defaultSetting { /* [XID] */ /* 0x00000001899A30D0-0x00000001899A30F0 */ get => default; /* [XID] */ /* 0x00000001899AABA0-0x00000001899AABC0 */ private set {} } // 0x0000000181982870-0x0000000181982910 0x00000001819806B0-0x0000000181980760
	public Dictionary<SimpleSafeInt32, ConfigAISpacialAdjustData> specification { /* [XID] */ /* 0x00000001899B2570-0x00000001899B2590 */ get => default; /* [XID] */ /* 0x00000001899B98D0-0x00000001899B98F0 */ private set {} } // 0x0000000181980D60-0x0000000181980E00 0x00000001819822D0-0x0000000181982380

	// Constructors
	public ConfigAISpacialAdjustSetting() {} // 0x0000000181982DB0-0x0000000181982E30

	// Methods
	// [XID] // 0x00000001899C13F0-0x00000001899C1410
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181982BF0-0x0000000181982D10
	// [XID] // 0x00000001899C8A20-0x00000001899C8A40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181982770-0x0000000181982870
	// [XID] // 0x00000001899D0390-0x00000001899D03B0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6FB9 */) => default; // 0x0000000181982380-0x0000000181982460
	// [XID] // 0x00000001899D7830-0x00000001899D7850
	public override int GetHashNum() => default; // 0x0000000181981110-0x00000001819811E0
	// [XID] // 0x00000001899DEC50-0x00000001899DEC70
	public override void InitEmpty() {} // 0x0000000181981D10-0x0000000181981E00
	[BlackList] // 0x00000001899E6850-0x00000001899E6890
	// [XID] // 0x00000001899E6850-0x00000001899E6890
	public override bool FromJson(JSONNode node) => default; // 0x0000000181981700-0x0000000181981A80
	// [XID] // 0x00000001899F0D30-0x00000001899F0D50
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181980760-0x0000000181980A90
	[BlackList] // 0x00000001899F85D0-0x00000001899F8610
	// [XID] // 0x00000001899F85D0-0x00000001899F8610
	public static new ConfigAISpacialAdjustSetting ParseFromJson(JSONNode node) => default; // 0x00000001819824C0-0x0000000181982710
	// [XID] // 0x0000000189A02C70-0x0000000189A02C90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FBA */, bool useObjectPool = false /* Metadata: 0x00AF6FBE */) => default; // 0x0000000181981FD0-0x00000001819822D0
	// [XID] // 0x0000000189A0A2E0-0x0000000189A0A300
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FBF */, bool useObjectPool = false /* Metadata: 0x00AF6FC3 */) => default; // 0x00000001819812C0-0x0000000181981600
	// [XID] // 0x0000000189A11C20-0x0000000189A11C40
	public static new ConfigAISpacialAdjustSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FC4 */, bool useObjectPool = false /* Metadata: 0x00AF6FC8 */) => default; // 0x0000000181981A80-0x0000000181981CA0
	[BlackList] // 0x0000000189A18E30-0x0000000189A18E70
	// [XID] // 0x0000000189A18E30-0x0000000189A18E70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181980A90-0x0000000181980D60
	// [XID] // 0x0000000189A235A0-0x0000000189A235C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181982910-0x0000000181982BF0
	[BlackList] // 0x0000000189A2A960-0x0000000189A2A9A0
	// [XID] // 0x0000000189A2A960-0x0000000189A2A9A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181981EE0-0x0000000181981FD0
	[BlackList] // 0x0000000189A35170-0x0000000189A351B0
	// [XID] // 0x0000000189A35170-0x0000000189A351B0
	public override void AutoAllocTypeFields() {} // 0x0000000181980E00-0x0000000181980EA0
	[BlackList] // 0x0000000189A3F8C0-0x0000000189A3F900
	// [XID] // 0x0000000189A3F8C0-0x0000000189A3F900
	public override void AutoRecycleTypeFields() {} // 0x0000000181980EA0-0x0000000181980FF0
	[BlackList] // 0x0000000189A49D20-0x0000000189A49D60
	// [XID] // 0x0000000189A49D20-0x0000000189A49D60
	public override void ReturnToObjectPool() {} // 0x0000000181982D10-0x0000000181982DB0
}

