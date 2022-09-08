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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class MonsterRelationshipExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15845
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _tagStr; // 0x18
	protected MonsterRarityType _monsterRarity; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A69F10-0x0000000189A69F30 */ get => default; /* [XID] */ /* 0x0000000189A711C0-0x0000000189A711E0 */ protected set {} } // 0x00000001847453D0-0x00000001847454A0 0x0000000184744BB0-0x0000000184744C90
	public string tagStr { /* [XID] */ /* 0x0000000189A78D60-0x0000000189A78D80 */ get => default; /* [XID] */ /* 0x0000000189A802A0-0x0000000189A802C0 */ protected set {} } // 0x0000000184745140-0x00000001847451E0 0x00000001847451E0-0x0000000184745290
	public MonsterRarityType monsterRarity { /* [XID] */ /* 0x0000000189A88000-0x0000000189A88020 */ get => default; /* [XID] */ /* 0x0000000189A8F890-0x0000000189A8F8B0 */ protected set {} } // 0x00000001847450A0-0x0000000184745140 0x0000000184744550-0x0000000184744600

	// Constructors
	public MonsterRelationshipExcelConfig() {} // 0x0000000184745540-0x00000001847455A0

	// Methods
	// [IDTag] // 0x0000000189A96EC0-0x0000000189A96F00
	// [XID] // 0x0000000189A96EC0-0x0000000189A96F00
	public virtual bool ParseFromLine(string line) => default; // 0x00000001847448C0-0x0000000184744BB0
	// [IDTag] // 0x0000000189AA1220-0x0000000189AA1260
	// [XID] // 0x0000000189AA1220-0x0000000189AA1260
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184744600-0x00000001847448C0
	// [XID] // 0x0000000189AABB70-0x0000000189AABB90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2831 */, bool useObjectPool = false /* Metadata: 0x00AF2835 */) => default; // 0x0000000184744C90-0x00000001847450A0
	[BlackList] // 0x0000000189AB34E0-0x0000000189AB3520
	// [XID] // 0x0000000189AB34E0-0x0000000189AB3520
	public virtual void AutoAllocTypeFields() {} // 0x00000001847443D0-0x0000000184744470
	[BlackList] // 0x0000000189ABDF90-0x0000000189ABDFD0
	// [XID] // 0x0000000189ABDF90-0x0000000189ABDFD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184744470-0x0000000184744550
	[BlackList] // 0x0000000189AC8790-0x0000000189AC87D0
	// [XID] // 0x0000000189AC8790-0x0000000189AC87D0
	public virtual void ReturnToObjectPool() {} // 0x00000001847454A0-0x0000000184745540
	[BlackList] // 0x0000000189AD31C0-0x0000000189AD3200
	// [XID] // 0x0000000189AD31C0-0x0000000189AD3200
	public virtual void OnPoolAllocated() {} // 0x0000000184745330-0x00000001847453D0
	[BlackList] // 0x0000000189ADDE60-0x0000000189ADDEA0
	// [XID] // 0x0000000189ADDE60-0x0000000189ADDEA0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184745290-0x0000000184745330
}

