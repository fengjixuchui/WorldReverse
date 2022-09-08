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
public class ConfigMonsterSkin : ConfigSkin, IAutoAllocRecycle // TypeDefIndex: 19004
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private SkinColor[] _skinColors; // 0x10

	// Properties
	public SkinColor[] skinColors { /* [XID] */ /* 0x0000000189A18BD0-0x0000000189A18BF0 */ get => default; /* [XID] */ /* 0x0000000189A20270-0x0000000189A20290 */ private set {} } // 0x0000000181262F80-0x0000000181263020 0x0000000181264160-0x0000000181264210

	// Constructors
	public ConfigMonsterSkin() {} // 0x0000000181264970-0x00000001812649D0

	// Methods
	// [XID] // 0x0000000189A27760-0x0000000189A27780
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001812647E0-0x00000001812648D0
	// [XID] // 0x0000000189A2EEB0-0x0000000189A2EED0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001812644C0-0x00000001812645A0
	// [XID] // 0x0000000189A367B0-0x0000000189A367D0
	public override ConfigSkin Clone(bool useObjectPool = false /* Metadata: 0x00AFB703 */) => default; // 0x0000000181264020-0x0000000181264100
	// [XID] // 0x0000000189A3DD50-0x0000000189A3DD70
	public override int GetHashNum() => default; // 0x0000000181262EB0-0x0000000181262F80
	// [XID] // 0x0000000189A45500-0x0000000189A45520
	public override void InitEmpty() {} // 0x0000000181263A80-0x0000000181263B50
	[BlackList] // 0x0000000189A4CB00-0x0000000189A4CB40
	// [XID] // 0x0000000189A4CB00-0x0000000189A4CB40
	public override bool FromJson(JSONNode node) => default; // 0x0000000181263470-0x00000001812637F0
	// [XID] // 0x0000000189A57270-0x0000000189A57290
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181262740-0x0000000181262970
	[BlackList] // 0x0000000189A5EDD0-0x0000000189A5EE10
	// [XID] // 0x0000000189A5EDD0-0x0000000189A5EE10
	public static new ConfigMonsterSkin ParseFromJson(JSONNode node) => default; // 0x0000000181264210-0x0000000181264460
	// [XID] // 0x0000000189A69AD0-0x0000000189A69AF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB704 */, bool useObjectPool = false /* Metadata: 0x00AFB708 */) => default; // 0x0000000181263D20-0x0000000181264020
	// [XID] // 0x0000000189A70DC0-0x0000000189A70DE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB709 */, bool useObjectPool = false /* Metadata: 0x00AFB70D */) => default; // 0x0000000181263100-0x0000000181263370
	// [XID] // 0x0000000189A78860-0x0000000189A78880
	public static new ConfigMonsterSkin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB70E */, bool useObjectPool = false /* Metadata: 0x00AFB712 */) => default; // 0x00000001812637F0-0x0000000181263A10
	[BlackList] // 0x0000000189A7FCE0-0x0000000189A7FD20
	// [XID] // 0x0000000189A7FCE0-0x0000000189A7FD20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181262970-0x0000000181262C40
	// [XID] // 0x0000000189A8A990-0x0000000189A8A9B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001812645A0-0x00000001812647E0
	[BlackList] // 0x0000000189A922B0-0x0000000189A922F0
	// [XID] // 0x0000000189A922B0-0x0000000189A922F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181263C30-0x0000000181263D20
	[BlackList] // 0x0000000189A9C870-0x0000000189A9C8B0
	// [XID] // 0x0000000189A9C870-0x0000000189A9C8B0
	public override void AutoAllocTypeFields() {} // 0x0000000181262C40-0x0000000181262CE0
	[BlackList] // 0x0000000189AA6F40-0x0000000189AA6F80
	// [XID] // 0x0000000189AA6F40-0x0000000189AA6F80
	public override void AutoRecycleTypeFields() {} // 0x0000000181262CE0-0x0000000181262D90
	[BlackList] // 0x0000000189AB1A00-0x0000000189AB1A40
	// [XID] // 0x0000000189AB1A00-0x0000000189AB1A40
	public override void ReturnToObjectPool() {} // 0x00000001812648D0-0x0000000181264970
}

