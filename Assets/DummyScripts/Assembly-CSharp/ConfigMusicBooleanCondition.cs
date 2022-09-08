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
public class ConfigMusicBooleanCondition : ConfigMusicParameterCondition, IAutoAllocRecycle // TypeDefIndex: 18716
{
	// Fields
	private bool _value; // 0x20

	// Properties
	public bool value { /* [XID] */ /* 0x00000001897C94A0-0x00000001897C94C0 */ get => default; /* [XID] */ /* 0x00000001897D0A90-0x00000001897D0AB0 */ private set {} } // 0x0000000181DBF090-0x0000000181DBF130 0x0000000181DBEF60-0x0000000181DBF010

	// Constructors
	public ConfigMusicBooleanCondition() {} // 0x0000000181DC04E0-0x0000000181DC0540

	// Methods
	// [XID] // 0x00000001897D8870-0x00000001897D8890
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181DC0350-0x0000000181DC0440
	// [XID] // 0x00000001897DF8F0-0x00000001897DF910
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181DC00A0-0x0000000181DC0150
	// [XID] // 0x00000001897E7010-0x00000001897E7030
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA9CB */) => default; // 0x0000000181DBFCB0-0x0000000181DBFD90
	// [XID] // 0x00000001897EEE50-0x00000001897EEE70
	public override int GetHashNum() => default; // 0x0000000181DBEB00-0x0000000181DBEBD0
	// [XID] // 0x00000001897F6480-0x00000001897F64A0
	public override void InitEmpty() {} // 0x0000000181DBF740-0x0000000181DBF7E0
	[BlackList] // 0x00000001897FDBC0-0x00000001897FDC00
	// [XID] // 0x00000001897FDBC0-0x00000001897FDC00
	public override bool FromJson(JSONNode node) => default; // 0x0000000181DBF130-0x0000000181DBF4B0
	// [XID] // 0x0000000189808240-0x0000000189808260
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181DBE200-0x0000000181DBE400
	[BlackList] // 0x000000018980FBF0-0x000000018980FC30
	// [XID] // 0x000000018980FBF0-0x000000018980FC30
	public static new ConfigMusicBooleanCondition ParseFromJson(JSONNode node) => default; // 0x0000000181DBFDF0-0x0000000181DC0040
	// [XID] // 0x000000018981A560-0x000000018981A580
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA9CC */, bool useObjectPool = false /* Metadata: 0x00AFA9D0 */) => default; // 0x0000000181DBF9B0-0x0000000181DBFCB0
	// [XID] // 0x0000000189821CD0-0x0000000189821CF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA9D1 */, bool useObjectPool = false /* Metadata: 0x00AFA9D5 */) => default; // 0x0000000181DBECB0-0x0000000181DBEEE0
	// [XID] // 0x00000001898291F0-0x0000000189829210
	public static new ConfigMusicBooleanCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA9D6 */, bool useObjectPool = false /* Metadata: 0x00AFA9DA */) => default; // 0x0000000181DBF4B0-0x0000000181DBF6D0
	[BlackList] // 0x00000001898307C0-0x0000000189830800
	// [XID] // 0x00000001898307C0-0x0000000189830800
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181DBE400-0x0000000181DBE6D0
	// [XID] // 0x000000018983ADE0-0x000000018983AE00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181DC0150-0x0000000181DC0350
	[BlackList] // 0x0000000189842440-0x0000000189842480
	// [XID] // 0x0000000189842440-0x0000000189842480
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181DBF8C0-0x0000000181DBF9B0
	// [XID] // 0x000000018984C8C0-0x000000018984C8E0
	public override bool IsMet(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> paramLookup) => default; // 0x0000000181DBE950-0x0000000181DBEA80
	[BlackList] // 0x00000001898539C0-0x0000000189853A00
	// [XID] // 0x00000001898539C0-0x0000000189853A00
	public override void AutoAllocTypeFields() {} // 0x0000000181DBE760-0x0000000181DBE800
	[BlackList] // 0x000000018985DBD0-0x000000018985DC10
	// [XID] // 0x000000018985DBD0-0x000000018985DC10
	public override void AutoRecycleTypeFields() {} // 0x0000000181DBE800-0x0000000181DBE8B0
	[BlackList] // 0x0000000189868610-0x0000000189868650
	// [XID] // 0x0000000189868610-0x0000000189868650
	public override void ReturnToObjectPool() {} // 0x0000000181DC0440-0x0000000181DC04E0
}

