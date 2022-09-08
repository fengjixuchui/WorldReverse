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
public class ConfigLevelEntity : ConfigEntity, IAutoAllocRecycle // TypeDefIndex: 18034
{
	// Fields
	private DropElemControlType _dropElemControlType; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityAbilityEntry[] _abilities; // 0x60
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityAbilityEntry[] _avatarAbilities; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityAbilityEntry[] _teamAbilities; // 0x70
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityAbilityEntry[] _monsterAbilities; // 0x78
	private Dictionary<string, Dictionary<string, SimpleSafeFloat>> _elemAmplifyDamage; // 0x80

	// Properties
	public DropElemControlType dropElemControlType { /* [XID] */ /* 0x0000000189717D90-0x0000000189717DB0 */ get => default; /* [XID] */ /* 0x000000018971F790-0x000000018971F7B0 */ private set {} } // 0x00000001814F22F0-0x00000001814F2390 0x00000001814F4880-0x00000001814F4930
	public ConfigEntityAbilityEntry[] abilities { /* [XID] */ /* 0x0000000189726D60-0x0000000189726D80 */ get => default; /* [XID] */ /* 0x000000018972E350-0x000000018972E370 */ private set {} } // 0x00000001814F4090-0x00000001814F4130 0x00000001814F5530-0x00000001814F55E0
	public ConfigEntityAbilityEntry[] avatarAbilities { /* [XID] */ /* 0x0000000189798D90-0x0000000189798DB0 */ get => default; /* [XID] */ /* 0x000000018973D5D0-0x000000018973D5F0 */ private set {} } // 0x00000001814F3750-0x00000001814F37F0 0x00000001814F3870-0x00000001814F3920
	public ConfigEntityAbilityEntry[] teamAbilities { /* [XID] */ /* 0x0000000189744AB0-0x0000000189744AD0 */ get => default; /* [XID] */ /* 0x000000018974C7A0-0x000000018974C7C0 */ private set {} } // 0x00000001814F2F00-0x00000001814F2FA0 0x00000001814F4C90-0x00000001814F4D40
	public ConfigEntityAbilityEntry[] monsterAbilities { /* [XID] */ /* 0x0000000189753A80-0x0000000189753AA0 */ get => default; /* [XID] */ /* 0x000000018975B040-0x000000018975B060 */ private set {} } // 0x00000001814F3D20-0x00000001814F3DC0 0x00000001814F4990-0x00000001814F4A40
	public Dictionary<string, Dictionary<string, SimpleSafeFloat>> elemAmplifyDamage { /* [XID] */ /* 0x0000000189649B80-0x0000000189649BA0 */ get => default; /* [XID] */ /* 0x0000000189769FB0-0x0000000189769FD0 */ private set {} } // 0x00000001814F5480-0x00000001814F5530 0x00000001814F3FE0-0x00000001814F4090

	// Constructors
	public ConfigLevelEntity() {} // 0x00000001814F5800-0x00000001814F5860

	// Methods
	// [XID] // 0x00000001897717B0-0x00000001897717D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001814F55E0-0x00000001814F5760
	// [XID] // 0x0000000189778F20-0x0000000189778F40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001814F4DA0-0x00000001814F4EF0
	// [XID] // 0x0000000189780620-0x0000000189780640
	public override ConfigEntity Clone(bool useObjectPool = false /* Metadata: 0x00AF874F */) => default; // 0x00000001814F47A0-0x00000001814F4880
	// [XID] // 0x0000000189787E00-0x0000000189787E20
	public override int GetHashNum() => default; // 0x00000001814F3020-0x00000001814F30F0
	// [XID] // 0x000000018978F380-0x000000018978F3A0
	public override void InitEmpty() {} // 0x00000001814F41A0-0x00000001814F42D0
	[BlackList] // 0x0000000189796B10-0x0000000189796B50
	// [XID] // 0x0000000189796B10-0x0000000189796B50
	public override bool FromJson(JSONNode node) => default; // 0x00000001814F39A0-0x00000001814F3D20
	// [XID] // 0x00000001897A1820-0x00000001897A1840
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001814F2390-0x00000001814F2A00
	[BlackList] // 0x00000001897A90A0-0x00000001897A90E0
	// [XID] // 0x00000001897A90A0-0x00000001897A90E0
	public static new ConfigLevelEntity ParseFromJson(JSONNode node) => default; // 0x00000001814F4A40-0x00000001814F4C90
	// [XID] // 0x00000001897B3EF0-0x00000001897B3F10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8750 */, bool useObjectPool = false /* Metadata: 0x00AF8754 */) => default; // 0x00000001814F44A0-0x00000001814F47A0
	// [XID] // 0x00000001897BBC10-0x00000001897BBC30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8755 */, bool useObjectPool = false /* Metadata: 0x00AF8759 */) => default; // 0x00000001814F31D0-0x00000001814F3750
	// [XID] // 0x00000001897C3470-0x00000001897C3490
	public static new ConfigLevelEntity ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF875A */, bool useObjectPool = false /* Metadata: 0x00AF875E */) => default; // 0x00000001814F3DC0-0x00000001814F3FE0
	[BlackList] // 0x00000001897CAC30-0x00000001897CAC70
	// [XID] // 0x00000001897CAC30-0x00000001897CAC70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001814F2A00-0x00000001814F2CD0
	// [XID] // 0x00000001897D5290-0x00000001897D52B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001814F4EF0-0x00000001814F5480
	[BlackList] // 0x00000001897DC990-0x00000001897DC9D0
	// [XID] // 0x00000001897DC990-0x00000001897DC9D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001814F43B0-0x00000001814F44A0
	[BlackList] // 0x00000001897E7190-0x00000001897E71D0
	// [XID] // 0x00000001897E7190-0x00000001897E71D0
	public override void AutoAllocTypeFields() {} // 0x00000001814F2CD0-0x00000001814F2D70
	[BlackList] // 0x00000001897F2250-0x00000001897F2290
	// [XID] // 0x00000001897F2250-0x00000001897F2290
	public override void AutoRecycleTypeFields() {} // 0x00000001814F2D70-0x00000001814F2E60
	[BlackList] // 0x00000001897FCA60-0x00000001897FCAA0
	// [XID] // 0x00000001897FCA60-0x00000001897FCAA0
	public override void ReturnToObjectPool() {} // 0x00000001814F5760-0x00000001814F5800
}

