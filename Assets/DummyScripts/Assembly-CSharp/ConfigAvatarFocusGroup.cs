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
public class ConfigAvatarFocusGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17809
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarFocus _ps4; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarFocus _ps5; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarFocus _pc; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarFocus _other; // 0x28

	// Properties
	public ConfigAvatarFocus ps4 { /* [XID] */ /* 0x0000000189610350-0x0000000189610370 */ get => default; /* [XID] */ /* 0x00000001896175D0-0x00000001896175F0 */ private set {} } // 0x0000000184017090-0x0000000184017130 0x0000000184017130-0x00000001840171E0
	public ConfigAvatarFocus ps5 { /* [XID] */ /* 0x000000018961F1A0-0x000000018961F1C0 */ get => default; /* [XID] */ /* 0x00000001896265E0-0x0000000189626600 */ private set {} } // 0x0000000184016FF0-0x0000000184017090 0x00000001840178F0-0x00000001840179A0
	public ConfigAvatarFocus pc { /* [XID] */ /* 0x000000018975BC10-0x000000018975BC30 */ get => default; /* [XID] */ /* 0x0000000189635BB0-0x0000000189635BD0 */ private set {} } // 0x00000001840171E0-0x0000000184017280 0x0000000184016250-0x0000000184016300
	public ConfigAvatarFocus other { /* [XID] */ /* 0x000000018963D230-0x000000018963D250 */ get => default; /* [XID] */ /* 0x0000000189644750-0x0000000189644770 */ private set {} } // 0x0000000184016B40-0x0000000184016BE0 0x00000001840179A0-0x0000000184017A50

	// Constructors
	public ConfigAvatarFocusGroup() {} // 0x0000000184017AF0-0x0000000184017B50

	// Methods
	// [XID] // 0x000000018964C090-0x000000018964C0B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184017650-0x00000001840177B0
	// [XID] // 0x00000001896536C0-0x00000001896536E0
	public void InitEmpty() {} // 0x0000000184016BE0-0x0000000184016CF0
	[BlackList] // 0x000000018965AFF0-0x000000018965B030
	// [XID] // 0x000000018965AFF0-0x000000018965B030
	public bool FromJson(JSONNode node) => default; // 0x00000001840167C0-0x0000000184016B40
	// [XID] // 0x00000001896654F0-0x0000000189665510
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184015790-0x0000000184015C70
	// [XID] // 0x000000018966CBE0-0x000000018966CC00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7D77 */, bool useObjectPool = false /* Metadata: 0x00AF7D7B */) => default; // 0x0000000184016CF0-0x0000000184016FF0
	// [XID] // 0x0000000189674A50-0x0000000189674A70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7D7C */, bool useObjectPool = false /* Metadata: 0x00AF7D80 */) => default; // 0x0000000184016300-0x00000001840167C0
	[BlackList] // 0x000000018967C340-0x000000018967C380
	// [XID] // 0x000000018967C340-0x000000018967C380
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184015C70-0x0000000184015F40
	// [XID] // 0x00000001896869D0-0x00000001896869F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184017280-0x0000000184017650
	[BlackList] // 0x000000018968E810-0x000000018968E850
	// [XID] // 0x000000018968E810-0x000000018968E850
	public virtual void AutoAllocTypeFields() {} // 0x0000000184015F40-0x0000000184015FE0
	[BlackList] // 0x0000000189698F60-0x0000000189698FA0
	// [XID] // 0x0000000189698F60-0x0000000189698FA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184015FE0-0x0000000184016250
	[BlackList] // 0x00000001896A3320-0x00000001896A3360
	// [XID] // 0x00000001896A3320-0x00000001896A3360
	public virtual void ReturnToObjectPool() {} // 0x0000000184017A50-0x0000000184017AF0
	[BlackList] // 0x00000001896AD530-0x00000001896AD570
	// [XID] // 0x00000001896AD530-0x00000001896AD570
	public virtual void OnPoolAllocated() {} // 0x0000000184017850-0x00000001840178F0
	[BlackList] // 0x00000001896B7C50-0x00000001896B7C90
	// [XID] // 0x00000001896B7C50-0x00000001896B7C90
	public virtual void OnBeforePoolRecycled() {} // 0x00000001840177B0-0x0000000184017850
}

