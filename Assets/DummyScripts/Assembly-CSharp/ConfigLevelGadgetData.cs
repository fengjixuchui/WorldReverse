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
public class ConfigLevelGadgetData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18491
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private LevelGadget[] _gadgets; // 0x18

	// Properties
	public uint sceneId { /* [XID] */ /* 0x000000018993FB60-0x000000018993FB80 */ get => default; /* [XID] */ /* 0x0000000189947220-0x0000000189947240 */ private set {} } // 0x0000000182951A80-0x0000000182951B50 0x0000000182951E50-0x0000000182951F30
	public LevelGadget[] gadgets { /* [XID] */ /* 0x000000018994E8C0-0x000000018994E8E0 */ get => default; /* [XID] */ /* 0x0000000189955F20-0x0000000189955F40 */ private set {} } // 0x0000000182950A90-0x0000000182950B30 0x00000001829518D0-0x0000000182951980

	// Constructors
	public ConfigLevelGadgetData() {} // 0x00000001829524C0-0x0000000182952520

	// Methods
	// [XID] // 0x000000018995DA90-0x000000018995DAB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829521D0-0x00000001829522E0
	// [XID] // 0x0000000189965250-0x0000000189965270
	public void InitEmpty() {} // 0x0000000182951980-0x0000000182951A80
	[BlackList] // 0x000000018996C6F0-0x000000018996C730
	// [XID] // 0x000000018996C6F0-0x000000018996C730
	public bool FromJson(JSONNode node) => default; // 0x0000000182951550-0x00000001829518D0
	// [XID] // 0x00000001899770E0-0x0000000189977100
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182950B30-0x0000000182950E30
	// [XID] // 0x000000018997E3C0-0x000000018997E3E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F3B */, bool useObjectPool = false /* Metadata: 0x00AF9F3F */) => default; // 0x0000000182951B50-0x0000000182951E50
	// [XID] // 0x0000000189985E90-0x0000000189985EB0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F40 */, bool useObjectPool = false /* Metadata: 0x00AF9F44 */) => default; // 0x0000000182951280-0x0000000182951550
	[BlackList] // 0x000000018998DAE0-0x000000018998DB20
	// [XID] // 0x000000018998DAE0-0x000000018998DB20
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182950E30-0x0000000182951100
	// [XID] // 0x0000000189998630-0x0000000189998650
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182951F30-0x00000001829521D0
	[BlackList] // 0x000000018999FEB0-0x000000018999FEF0
	// [XID] // 0x000000018999FEB0-0x000000018999FEF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182951100-0x00000001829511A0
	[BlackList] // 0x00000001899AA9E0-0x00000001899AAA20
	// [XID] // 0x00000001899AA9E0-0x00000001899AAA20
	public virtual void AutoRecycleTypeFields() {} // 0x00000001829511A0-0x0000000182951280
	[BlackList] // 0x00000001899B5200-0x00000001899B5240
	// [XID] // 0x00000001899B5200-0x00000001899B5240
	public virtual void ReturnToObjectPool() {} // 0x0000000182952420-0x00000001829524C0
	[BlackList] // 0x00000001899BFAF0-0x00000001899BFB30
	// [XID] // 0x00000001899BFAF0-0x00000001899BFB30
	public virtual void OnPoolAllocated() {} // 0x0000000182952380-0x0000000182952420
	[BlackList] // 0x00000001899CA000-0x00000001899CA040
	// [XID] // 0x00000001899CA000-0x00000001899CA040
	public virtual void OnBeforePoolRecycled() {} // 0x00000001829522E0-0x0000000182952380
}

