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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigLevelRoute : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18509
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigRoute[] _routes; // 0x18

	// Properties
	public uint sceneId { /* [XID] */ /* 0x0000000189701800-0x0000000189701820 */ get => default; /* [XID] */ /* 0x0000000189709060-0x0000000189709080 */ private set {} } // 0x0000000182B26B40-0x0000000182B26C10 0x0000000182B26F10-0x0000000182B26FF0
	public ConfigRoute[] routes { /* [XID] */ /* 0x0000000189710910-0x0000000189710930 */ get => default; /* [XID] */ /* 0x0000000189717CB0-0x0000000189717CD0 */ private set {} } // 0x0000000182B274E0-0x0000000182B27580 0x0000000182B26A90-0x0000000182B26B40

	// Constructors
	public ConfigLevelRoute() {} // 0x0000000182B27620-0x0000000182B27680

	// Methods
	// [XID] // 0x000000018971F6F0-0x000000018971F710
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B27290-0x0000000182B273A0
	// [XID] // 0x0000000189726C60-0x0000000189726C80
	public void InitEmpty() {} // 0x0000000182B26990-0x0000000182B26A90
	[BlackList] // 0x000000018972E230-0x000000018972E270
	// [XID] // 0x000000018972E230-0x000000018972E270
	public bool FromJson(JSONNode node) => default; // 0x0000000182B26610-0x0000000182B26990
	// [XID] // 0x0000000189738A70-0x0000000189738A90
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182B25BF0-0x0000000182B25EF0
	// [XID] // 0x0000000189740840-0x0000000189740860
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9FD7 */, bool useObjectPool = false /* Metadata: 0x00AF9FDB */) => default; // 0x0000000182B26C10-0x0000000182B26F10
	// [XID] // 0x0000000189747B50-0x0000000189747B70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9FDC */, bool useObjectPool = false /* Metadata: 0x00AF9FE0 */) => default; // 0x0000000182B26340-0x0000000182B26610
	[BlackList] // 0x000000018974F370-0x000000018974F3B0
	// [XID] // 0x000000018974F370-0x000000018974F3B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B25EF0-0x0000000182B261C0
	// [XID] // 0x00000001897596C0-0x00000001897596E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B26FF0-0x0000000182B27290
	[BlackList] // 0x00000001897612F0-0x0000000189761330
	// [XID] // 0x00000001897612F0-0x0000000189761330
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B261C0-0x0000000182B26260
	[BlackList] // 0x000000018976B7E0-0x000000018976B820
	// [XID] // 0x000000018976B7E0-0x000000018976B820
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B26260-0x0000000182B26340
	[BlackList] // 0x0000000189775DE0-0x0000000189775E20
	// [XID] // 0x0000000189775DE0-0x0000000189775E20
	public virtual void ReturnToObjectPool() {} // 0x0000000182B27580-0x0000000182B27620
	[BlackList] // 0x0000000189780480-0x00000001897804C0
	// [XID] // 0x0000000189780480-0x00000001897804C0
	public virtual void OnPoolAllocated() {} // 0x0000000182B27440-0x0000000182B274E0
	[BlackList] // 0x000000018978ACC0-0x000000018978AD00
	// [XID] // 0x000000018978ACC0-0x000000018978AD00
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B273A0-0x0000000182B27440
}

