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
public class ConfigCrowdQuestRestriction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17764
{
	// Fields
	private SimpleSafeUInt32 questIDRawNum; // 0x10
	private bool _questAccepted; // 0x14
	private QuestState[] _questStates; // 0x18

	// Properties
	public uint questID { /* [XID] */ /* 0x0000000189665510-0x0000000189665530 */ get => default; /* [XID] */ /* 0x000000018966CC00-0x000000018966CC20 */ private set {} } // 0x0000000184249760-0x0000000184249830 0x0000000184249680-0x0000000184249760
	public bool questAccepted { /* [XID] */ /* 0x0000000189674AB0-0x0000000189674AD0 */ get => default; /* [XID] */ /* 0x000000018967C380-0x000000018967C3A0 */ private set {} } // 0x00000001842495E0-0x0000000184249680 0x00000001842481D0-0x0000000184248280
	public QuestState[] questStates { /* [XID] */ /* 0x00000001896839B0-0x00000001896839D0 */ get => default; /* [XID] */ /* 0x000000018968B770-0x000000018968B790 */ private set {} } // 0x0000000184249830-0x00000001842498D0 0x0000000184248A80-0x0000000184248B30

	// Constructors
	public ConfigCrowdQuestRestriction() {} // 0x0000000184249EF0-0x0000000184249F60

	// Methods
	// [XID] // 0x00000001896932C0-0x00000001896932E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184249BF0-0x0000000184249D10
	// [XID] // 0x000000018969A4F0-0x000000018969A510
	public void InitEmpty() {} // 0x00000001842491E0-0x00000001842492E0
	[BlackList] // 0x00000001896A1E00-0x00000001896A1E40
	// [XID] // 0x00000001896A1E00-0x00000001896A1E40
	public bool FromJson(JSONNode node) => default; // 0x0000000184248E60-0x00000001842491E0
	// [XID] // 0x00000001896AC0D0-0x00000001896AC0F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184248280-0x0000000184248630
	// [XID] // 0x00000001896B3370-0x00000001896B3390
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B61 */, bool useObjectPool = false /* Metadata: 0x00AF7B65 */) => default; // 0x00000001842492E0-0x00000001842495E0
	// [XID] // 0x00000001896BAB70-0x00000001896BAB90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B66 */, bool useObjectPool = false /* Metadata: 0x00AF7B6A */) => default; // 0x0000000184248B30-0x0000000184248E60
	[BlackList] // 0x00000001896C1B20-0x00000001896C1B60
	// [XID] // 0x00000001896C1B20-0x00000001896C1B60
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184248630-0x0000000184248900
	// [XID] // 0x00000001896CC330-0x00000001896CC350
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842498D0-0x0000000184249BF0
	[BlackList] // 0x00000001896D3500-0x00000001896D3540
	// [XID] // 0x00000001896D3500-0x00000001896D3540
	public virtual void AutoAllocTypeFields() {} // 0x0000000184248900-0x00000001842489A0
	[BlackList] // 0x00000001896DDFE0-0x00000001896DE020
	// [XID] // 0x00000001896DDFE0-0x00000001896DE020
	public virtual void AutoRecycleTypeFields() {} // 0x00000001842489A0-0x0000000184248A80
	[BlackList] // 0x00000001896E8400-0x00000001896E8440
	// [XID] // 0x00000001896E8400-0x00000001896E8440
	public virtual void ReturnToObjectPool() {} // 0x0000000184249E50-0x0000000184249EF0
	[BlackList] // 0x00000001896F2910-0x00000001896F2950
	// [XID] // 0x00000001896F2910-0x00000001896F2950
	public virtual void OnPoolAllocated() {} // 0x0000000184249DB0-0x0000000184249E50
	[BlackList] // 0x00000001896FD410-0x00000001896FD450
	// [XID] // 0x00000001896FD410-0x00000001896FD450
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184249D10-0x0000000184249DB0
}

