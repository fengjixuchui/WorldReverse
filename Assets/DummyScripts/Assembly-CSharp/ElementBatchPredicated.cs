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
public class ElementBatchPredicated : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17111
{
	// Fields
	private ElementType[] _elementTypeArr; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _successActions; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _failActions; // 0x20

	// Properties
	public ElementType[] elementTypeArr { /* [XID] */ /* 0x0000000189B67400-0x0000000189B67420 */ get => default; /* [XID] */ /* 0x0000000189B6E620-0x0000000189B6E640 */ private set {} } // 0x00000001832469C0-0x0000000183246A60 0x0000000183246190-0x0000000183246240
	public ConfigAbilityAction[] successActions { /* [XID] */ /* 0x0000000189B75E10-0x0000000189B75E30 */ get => default; /* [XID] */ /* 0x0000000189B7D3A0-0x0000000189B7D3C0 */ private set {} } // 0x0000000183246F10-0x0000000183246FB0 0x0000000183246E60-0x0000000183246F10
	public ConfigAbilityAction[] failActions { /* [XID] */ /* 0x0000000189B85110-0x0000000189B85130 */ get => default; /* [XID] */ /* 0x0000000189B8BFA0-0x0000000189B8BFC0 */ private set {} } // 0x00000001832465A0-0x0000000183246640 0x0000000183247570-0x0000000183247620

	// Constructors
	public ElementBatchPredicated() {} // 0x00000001832476C0-0x0000000183247720

	// Methods
	// [XID] // 0x0000000189B93770-0x0000000189B93790
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183247310-0x0000000183247430
	// [XID] // 0x0000000189B9ACA0-0x0000000189B9ACC0
	public void InitEmpty() {} // 0x0000000183246A60-0x0000000183246B60
	[BlackList] // 0x0000000189BA24F0-0x0000000189BA2530
	// [XID] // 0x0000000189BA24F0-0x0000000189BA2530
	public bool FromJson(JSONNode node) => default; // 0x0000000183246640-0x00000001832469C0
	// [XID] // 0x0000000189BAC570-0x0000000189BAC590
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001832459C0-0x0000000183245D70
	// [XID] // 0x0000000189BB3E50-0x0000000189BB3E70
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63A3 */, bool useObjectPool = false /* Metadata: 0x00AF63A7 */) => default; // 0x0000000183246B60-0x0000000183246E60
	// [XID] // 0x0000000189BBB430-0x0000000189BBB450
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63A8 */, bool useObjectPool = false /* Metadata: 0x00AF63AC */) => default; // 0x0000000183246240-0x00000001832465A0
	[BlackList] // 0x0000000189BC3290-0x0000000189BC32D0
	// [XID] // 0x0000000189BC3290-0x0000000189BC32D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183245D70-0x0000000183246040
	// [XID] // 0x0000000189BCDA40-0x0000000189BCDA60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183246FB0-0x0000000183247310
	[BlackList] // 0x0000000189BD4F30-0x0000000189BD4F70
	// [XID] // 0x0000000189BD4F30-0x0000000189BD4F70
	public virtual void AutoAllocTypeFields() {} // 0x0000000183246040-0x00000001832460E0
	[BlackList] // 0x0000000189BDFA00-0x0000000189BDFA40
	// [XID] // 0x0000000189BDFA00-0x0000000189BDFA40
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832460E0-0x0000000183246190
	[BlackList] // 0x00000001895EF380-0x00000001895EF3C0
	// [XID] // 0x00000001895EF380-0x00000001895EF3C0
	public virtual void ReturnToObjectPool() {} // 0x0000000183247620-0x00000001832476C0
	[BlackList] // 0x00000001895F9B60-0x00000001895F9BA0
	// [XID] // 0x00000001895F9B60-0x00000001895F9BA0
	public virtual void OnPoolAllocated() {} // 0x00000001832474D0-0x0000000183247570
	[BlackList] // 0x00000001896043D0-0x0000000189604410
	// [XID] // 0x00000001896043D0-0x0000000189604410
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183247430-0x00000001832474D0
}

