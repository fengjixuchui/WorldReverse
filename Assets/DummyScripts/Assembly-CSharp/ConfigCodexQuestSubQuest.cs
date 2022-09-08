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
public class ConfigCodexQuestSubQuest : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17664
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCodexQuestText _subQuestTitle; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCodexQuestItem[] _items; // 0x18

	// Properties
	public ConfigCodexQuestText subQuestTitle { /* [XID] */ /* 0x0000000189665530-0x0000000189665550 */ get => default; /* [XID] */ /* 0x000000018966CC20-0x000000018966CC40 */ private set {} } // 0x0000000182E136E0-0x0000000182E13780 0x0000000182E13A80-0x0000000182E13B30
	public ConfigCodexQuestItem[] items { /* [XID] */ /* 0x0000000189674B10-0x0000000189674B30 */ get => default; /* [XID] */ /* 0x000000018967C3E0-0x000000018967C400 */ private set {} } // 0x0000000182E13470-0x0000000182E13510 0x0000000182E142A0-0x0000000182E14350

	// Constructors
	public ConfigCodexQuestSubQuest() {} // 0x0000000182E148D0-0x0000000182E14930

	// Methods
	// [XID] // 0x00000001896839D0-0x00000001896839F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182E145E0-0x0000000182E146F0
	// [XID] // 0x000000018968B790-0x000000018968B7B0
	public void InitEmpty() {} // 0x0000000182E13EB0-0x0000000182E13FA0
	[BlackList] // 0x0000000189693300-0x0000000189693340
	// [XID] // 0x0000000189693300-0x0000000189693340
	public bool FromJson(JSONNode node) => default; // 0x0000000182E13B30-0x0000000182E13EB0
	// [XID] // 0x000000018969D950-0x000000018969D970
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182E12EB0-0x0000000182E131A0
	// [XID] // 0x00000001896A4980-0x00000001896A49A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76D5 */, bool useObjectPool = false /* Metadata: 0x00AF76D9 */) => default; // 0x0000000182E13FA0-0x0000000182E142A0
	// [XID] // 0x00000001896AC110-0x00000001896AC130
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76DA */, bool useObjectPool = false /* Metadata: 0x00AF76DE */) => default; // 0x0000000182E13780-0x0000000182E13A80
	[BlackList] // 0x00000001896B33D0-0x00000001896B3410
	// [XID] // 0x00000001896B33D0-0x00000001896B3410
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182E131A0-0x0000000182E13470
	// [XID] // 0x00000001896BD7A0-0x00000001896BD7C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182E14350-0x0000000182E145E0
	[BlackList] // 0x00000001896C4ED0-0x00000001896C4F10
	// [XID] // 0x00000001896C4ED0-0x00000001896C4F10
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E13510-0x0000000182E135B0
	[BlackList] // 0x00000001896CF710-0x00000001896CF750
	// [XID] // 0x00000001896CF710-0x00000001896CF750
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E135B0-0x0000000182E136E0
	[BlackList] // 0x00000001896D9AD0-0x00000001896D9B10
	// [XID] // 0x00000001896D9AD0-0x00000001896D9B10
	public virtual void ReturnToObjectPool() {} // 0x0000000182E14830-0x0000000182E148D0
	[BlackList] // 0x00000001896E40B0-0x00000001896E40F0
	// [XID] // 0x00000001896E40B0-0x00000001896E40F0
	public virtual void OnPoolAllocated() {} // 0x0000000182E14790-0x0000000182E14830
	[BlackList] // 0x00000001896EE2B0-0x00000001896EE2F0
	// [XID] // 0x00000001896EE2B0-0x00000001896EE2F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E146F0-0x0000000182E14790
}

