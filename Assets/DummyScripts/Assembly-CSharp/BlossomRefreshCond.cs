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
public class BlossomRefreshCond : IAutoAllocRecycle // TypeDefIndex: 15268
{
	// Fields
	protected BlossomRefreshCondType _type; // 0x10
	protected SimpleSafeUInt32[] _param; // 0x18

	// Properties
	public BlossomRefreshCondType type { /* [XID] */ /* 0x0000000189B1B300-0x0000000189B1B320 */ get => default; /* [XID] */ /* 0x0000000189B22990-0x0000000189B229B0 */ protected set {} } // 0x0000000183A99100-0x0000000183A991A0 0x0000000183A98F10-0x0000000183A98FC0
	public SimpleSafeUInt32[] param { /* [XID] */ /* 0x0000000189B29FC0-0x0000000189B29FE0 */ get => default; /* [XID] */ /* 0x0000000189B31690-0x0000000189B316B0 */ protected set {} } // 0x0000000183A99250-0x0000000183A992F0 0x0000000183A991A0-0x0000000183A99250

	// Constructors
	public BlossomRefreshCond() {} // 0x0000000183A99390-0x0000000183A993F0

	// Methods
	// [XID] // 0x0000000189B38A90-0x0000000189B38AB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183A987A0-0x0000000183A98BA0
	// [XID] // 0x0000000189B40420-0x0000000189B40440
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05C8 */, bool useObjectPool = false /* Metadata: 0x00AF05CC */) => default; // 0x0000000183A98BA0-0x0000000183A98F10
	[BlackList] // 0x0000000189B47CE0-0x0000000189B47D20
	// [XID] // 0x0000000189B47CE0-0x0000000189B47D20
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A98660-0x0000000183A98700
	[BlackList] // 0x0000000189B523E0-0x0000000189B52420
	// [XID] // 0x0000000189B523E0-0x0000000189B52420
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A98700-0x0000000183A987A0
	[BlackList] // 0x0000000189B5CE50-0x0000000189B5CE90
	// [XID] // 0x0000000189B5CE50-0x0000000189B5CE90
	public virtual void ReturnToObjectPool() {} // 0x0000000183A992F0-0x0000000183A99390
	[BlackList] // 0x0000000189B677A0-0x0000000189B677E0
	// [XID] // 0x0000000189B677A0-0x0000000189B677E0
	public virtual void OnPoolAllocated() {} // 0x0000000183A99060-0x0000000183A99100
	[BlackList] // 0x0000000189B71CF0-0x0000000189B71D30
	// [XID] // 0x0000000189B71CF0-0x0000000189B71D30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A98FC0-0x0000000183A99060
}

