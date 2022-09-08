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
public class SECTR_BakeLayerInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18976
{
	// Fields
	private ulong _id; // 0x10
	private SimpleSafeInt32[] _invisibleList; // 0x18

	// Properties
	public ulong id { /* [XID] */ /* 0x0000000189B6B6D0-0x0000000189B6B6F0 */ get => default; /* [XID] */ /* 0x0000000189B72C70-0x0000000189B72C90 */ set {} } // 0x0000000181FC77F0-0x0000000181FC7890 0x0000000181FC6FE0-0x0000000181FC7090
	public SimpleSafeInt32[] invisibleList { /* [XID] */ /* 0x0000000189B7A1D0-0x0000000189B7A1F0 */ get => default; /* [XID] */ /* 0x0000000189B818B0-0x0000000189B818D0 */ set {} } // 0x0000000181FC6E70-0x0000000181FC6F10 0x0000000181FC6A40-0x0000000181FC6AF0

	// Constructors
	public SECTR_BakeLayerInfo() {} // 0x0000000181FC7930-0x0000000181FC7990

	// Methods
	// [XID] // 0x0000000189B89010-0x0000000189B89030
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FC7600-0x0000000181FC76B0
	// [XID] // 0x0000000189B905F0-0x0000000189B90610
	public void InitEmpty() {} // 0x0000000181FC6F10-0x0000000181FC6FE0
	[BlackList] // 0x0000000189B979C0-0x0000000189B97A00
	// [XID] // 0x0000000189B979C0-0x0000000189B97A00
	public bool FromJson(JSONNode node) => default; // 0x0000000181FC6AF0-0x0000000181FC6E70
	// [XID] // 0x0000000189BA20F0-0x0000000189BA2110
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181FC60E0-0x0000000181FC6390
	// [XID] // 0x0000000189BA95A0-0x0000000189BA95C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB61B */, bool useObjectPool = false /* Metadata: 0x00AFB61F */) => default; // 0x0000000181FC7090-0x0000000181FC7390
	// [XID] // 0x0000000189BB0D70-0x0000000189BB0D90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB620 */, bool useObjectPool = false /* Metadata: 0x00AFB624 */) => default; // 0x0000000181FC67A0-0x0000000181FC6A40
	[BlackList] // 0x0000000189BB7F00-0x0000000189BB7F40
	// [XID] // 0x0000000189BB7F00-0x0000000189BB7F40
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FC6390-0x0000000181FC6660
	// [XID] // 0x0000000189BC2FB0-0x0000000189BC2FD0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FC7390-0x0000000181FC7600
	[BlackList] // 0x0000000189BCA7B0-0x0000000189BCA7F0
	// [XID] // 0x0000000189BCA7B0-0x0000000189BCA7F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181FC6660-0x0000000181FC6700
	[BlackList] // 0x0000000189BD4C10-0x0000000189BD4C50
	// [XID] // 0x0000000189BD4C10-0x0000000189BD4C50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181FC6700-0x0000000181FC67A0
	[BlackList] // 0x0000000189BDF700-0x0000000189BDF740
	// [XID] // 0x0000000189BDF700-0x0000000189BDF740
	public virtual void ReturnToObjectPool() {} // 0x0000000181FC7890-0x0000000181FC7930
	[BlackList] // 0x00000001895EEFA0-0x00000001895EEFE0
	// [XID] // 0x00000001895EEFA0-0x00000001895EEFE0
	public virtual void OnPoolAllocated() {} // 0x0000000181FC7750-0x0000000181FC77F0
	[BlackList] // 0x00000001895F98E0-0x00000001895F9920
	// [XID] // 0x00000001895F98E0-0x00000001895F9920
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181FC76B0-0x0000000181FC7750
}

