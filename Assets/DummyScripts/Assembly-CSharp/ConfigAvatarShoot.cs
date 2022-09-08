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
public class ConfigAvatarShoot : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18013
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigShoot _normalShoot; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigShoot _aimingShoot; // 0x18

	// Properties
	public ConfigShoot normalShoot { /* [XID] */ /* 0x000000018960C480-0x000000018960C4A0 */ get => default; /* [XID] */ /* 0x00000001898D0640-0x00000001898D0660 */ private set {} } // 0x0000000183A251A0-0x0000000183A25240 0x0000000183A250F0-0x0000000183A251A0
	public ConfigShoot aimingShoot { /* [XID] */ /* 0x00000001898D7D00-0x00000001898D7D20 */ get => default; /* [XID] */ /* 0x00000001898DF9C0-0x00000001898DF9E0 */ private set {} } // 0x0000000183A24D50-0x0000000183A24DF0 0x0000000183A24510-0x0000000183A245C0

	// Constructors
	public ConfigAvatarShoot() {} // 0x0000000183A257A0-0x0000000183A25800

	// Methods
	// [XID] // 0x00000001898E74B0-0x00000001898E74D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A254C0-0x0000000183A255C0
	// [XID] // 0x00000001898EED20-0x00000001898EED40
	public void InitEmpty() {} // 0x0000000183A24C60-0x0000000183A24D50
	[BlackList] // 0x00000001898F65A0-0x00000001898F65E0
	// [XID] // 0x00000001898F65A0-0x00000001898F65E0
	public bool FromJson(JSONNode node) => default; // 0x0000000183A248E0-0x0000000183A24C60
	// [XID] // 0x0000000189900EF0-0x0000000189900F10
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183A23D00-0x0000000183A24000
	// [XID] // 0x0000000189908690-0x00000001899086B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8697 */, bool useObjectPool = false /* Metadata: 0x00AF869B */) => default; // 0x0000000183A24DF0-0x0000000183A250F0
	// [XID] // 0x000000018990FD30-0x000000018990FD50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF869C */, bool useObjectPool = false /* Metadata: 0x00AF86A0 */) => default; // 0x0000000183A245C0-0x0000000183A248E0
	[BlackList] // 0x0000000189917840-0x0000000189917880
	// [XID] // 0x0000000189917840-0x0000000189917880
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A24000-0x0000000183A242D0
	// [XID] // 0x00000001899220E0-0x0000000189922100
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A25240-0x0000000183A254C0
	[BlackList] // 0x0000000189929860-0x00000001899298A0
	// [XID] // 0x0000000189929860-0x00000001899298A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A242D0-0x0000000183A24370
	[BlackList] // 0x0000000189933BA0-0x0000000189933BE0
	// [XID] // 0x0000000189933BA0-0x0000000189933BE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A24370-0x0000000183A24510
	[BlackList] // 0x000000018993E4F0-0x000000018993E530
	// [XID] // 0x000000018993E4F0-0x000000018993E530
	public virtual void ReturnToObjectPool() {} // 0x0000000183A25700-0x0000000183A257A0
	[BlackList] // 0x0000000189948B40-0x0000000189948B80
	// [XID] // 0x0000000189948B40-0x0000000189948B80
	public virtual void OnPoolAllocated() {} // 0x0000000183A25660-0x0000000183A25700
	[BlackList] // 0x00000001899531B0-0x00000001899531F0
	// [XID] // 0x00000001899531B0-0x00000001899531F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A255C0-0x0000000183A25660
}

