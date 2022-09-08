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
using MoleMole.Audio.Music.Miiha;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicUInt32MultiCondition : ConfigMusicParameterCondition, IAutoAllocRecycle // TypeDefIndex: 18686
{
	// Fields
	private SimpleSafeUInt32[] _values; // 0x20
	private bool _sorted; // 0x28

	// Properties
	public SimpleSafeUInt32[] values { /* [XID] */ /* 0x00000001899EAA80-0x00000001899EAAA0 */ get => default; /* [XID] */ /* 0x00000001899F2620-0x00000001899F2640 */ private set {} } // 0x0000000182D5CC80-0x0000000182D5CD20 0x0000000182D5B700-0x0000000182D5B7B0

	// Constructors
	public ConfigMusicUInt32MultiCondition() {} // 0x0000000182D5D0F0-0x0000000182D5D150

	// Methods
	// [XID] // 0x00000001899F9B90-0x00000001899F9BB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D5CF60-0x0000000182D5D050
	// [XID] // 0x0000000189A00FB0-0x0000000189A00FD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D5CBA0-0x0000000182D5CC80
	// [XID] // 0x0000000189A088B0-0x0000000189A088D0
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA8DB */) => default; // 0x0000000182D5C7B0-0x0000000182D5C890
	// [XID] // 0x0000000189A0FE90-0x0000000189A0FEB0
	public override int GetHashNum() => default; // 0x0000000182D5B630-0x0000000182D5B700
	// [XID] // 0x0000000189A17330-0x0000000189A17350
	public override void InitEmpty() {} // 0x0000000182D5C210-0x0000000182D5C2E0
	[BlackList] // 0x0000000189A1EAB0-0x0000000189A1EAF0
	// [XID] // 0x0000000189A1EAB0-0x0000000189A1EAF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D5BC00-0x0000000182D5BF80
	// [XID] // 0x0000000189A28F60-0x0000000189A28F80
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D5ABD0-0x0000000182D5AE00
	[BlackList] // 0x0000000189A30530-0x0000000189A30570
	// [XID] // 0x0000000189A30530-0x0000000189A30570
	public static new ConfigMusicUInt32MultiCondition ParseFromJson(JSONNode node) => default; // 0x0000000182D5C8F0-0x0000000182D5CB40
	// [XID] // 0x0000000189A3ACE0-0x0000000189A3AD00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA8DC */, bool useObjectPool = false /* Metadata: 0x00AFA8E0 */) => default; // 0x0000000182D5C4B0-0x0000000182D5C7B0
	// [XID] // 0x0000000189A42530-0x0000000189A42550
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA8E1 */, bool useObjectPool = false /* Metadata: 0x00AFA8E5 */) => default; // 0x0000000182D5B890-0x0000000182D5BB00
	// [XID] // 0x0000000189A49BA0-0x0000000189A49BC0
	public static new ConfigMusicUInt32MultiCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA8E6 */, bool useObjectPool = false /* Metadata: 0x00AFA8EA */) => default; // 0x0000000182D5BF80-0x0000000182D5C1A0
	[BlackList] // 0x0000000189A51550-0x0000000189A51590
	// [XID] // 0x0000000189A51550-0x0000000189A51590
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D5AE00-0x0000000182D5B0D0
	// [XID] // 0x0000000189A5BF40-0x0000000189A5BF60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D5CD20-0x0000000182D5CF60
	[BlackList] // 0x0000000189A63750-0x0000000189A63790
	// [XID] // 0x0000000189A63750-0x0000000189A63790
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D5C3C0-0x0000000182D5C4B0
	// [XID] // 0x0000000189A6DFC0-0x0000000189A6DFE0
	public override bool IsMet(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> paramLookup) => default; // 0x0000000182D5B350-0x0000000182D5B5B0
	[BlackList] // 0x0000000189A75470-0x0000000189A754B0
	// [XID] // 0x0000000189A75470-0x0000000189A754B0
	public override void AutoAllocTypeFields() {} // 0x0000000182D5B160-0x0000000182D5B200
	[BlackList] // 0x0000000189A7FD80-0x0000000189A7FDC0
	// [XID] // 0x0000000189A7FD80-0x0000000189A7FDC0
	public override void AutoRecycleTypeFields() {} // 0x0000000182D5B200-0x0000000182D5B2B0
	[BlackList] // 0x0000000189A8AA30-0x0000000189A8AA70
	// [XID] // 0x0000000189A8AA30-0x0000000189A8AA70
	public override void ReturnToObjectPool() {} // 0x0000000182D5D050-0x0000000182D5D0F0
}

