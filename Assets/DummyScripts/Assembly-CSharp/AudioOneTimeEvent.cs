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
public class AudioOneTimeEvent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16308
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _eventName; // 0x10
	private SimpleSafeFloat durationRawNum; // 0x18

	// Properties
	public ConfigWwiseString eventName { /* [XID] */ /* 0x0000000189773160-0x0000000189773180 */ get => default; /* [XID] */ /* 0x000000018977A7C0-0x000000018977A7E0 */ private set {} } // 0x00000001838958A0-0x0000000183895940 0x0000000183895470-0x0000000183895520
	public float duration { /* [XID] */ /* 0x00000001897823E0-0x0000000189782400 */ get => default; /* [XID] */ /* 0x0000000189789700-0x0000000189789720 */ private set {} } // 0x0000000183894FC0-0x00000001838950A0 0x0000000183895390-0x0000000183895470

	// Constructors
	public AudioOneTimeEvent() {} // 0x00000001838962B0-0x0000000183896310

	// Methods
	// [XID] // 0x0000000189790E70-0x0000000189790E90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183895FB0-0x00000001838960D0
	// [XID] // 0x0000000189798640-0x0000000189798660
	public void InitEmpty() {} // 0x0000000183895940-0x0000000183895A40
	[BlackList] // 0x00000001897A04D0-0x00000001897A0510
	// [XID] // 0x00000001897A04D0-0x00000001897A0510
	public bool FromJson(JSONNode node) => default; // 0x0000000183895520-0x00000001838958A0
	// [XID] // 0x00000001897AA9A0-0x00000001897AA9C0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001838947C0-0x0000000183894AF0
	// [XID] // 0x00000001897B2530-0x00000001897B2550
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF372E */, bool useObjectPool = false /* Metadata: 0x00AF3732 */) => default; // 0x0000000183895A40-0x0000000183895D40
	// [XID] // 0x00000001897B9E50-0x00000001897B9E70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3733 */, bool useObjectPool = false /* Metadata: 0x00AF3737 */) => default; // 0x00000001838950A0-0x0000000183895390
	[BlackList] // 0x00000001897C1F30-0x00000001897C1F70
	// [XID] // 0x00000001897C1F30-0x00000001897C1F70
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183894AF0-0x0000000183894DC0
	// [XID] // 0x00000001897CC5B0-0x00000001897CC5D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183895D40-0x0000000183895FB0
	[BlackList] // 0x00000001897D3EC0-0x00000001897D3F00
	// [XID] // 0x00000001897D3EC0-0x00000001897D3F00
	public virtual void AutoAllocTypeFields() {} // 0x0000000183894DC0-0x0000000183894E60
	[BlackList] // 0x00000001897DE5B0-0x00000001897DE5F0
	// [XID] // 0x00000001897DE5B0-0x00000001897DE5F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183894E60-0x0000000183894FC0
	[BlackList] // 0x00000001897E8FD0-0x00000001897E9010
	// [XID] // 0x00000001897E8FD0-0x00000001897E9010
	public virtual void ReturnToObjectPool() {} // 0x0000000183896210-0x00000001838962B0
	[BlackList] // 0x00000001897F3BB0-0x00000001897F3BF0
	// [XID] // 0x00000001897F3BB0-0x00000001897F3BF0
	public virtual void OnPoolAllocated() {} // 0x0000000183896170-0x0000000183896210
	[BlackList] // 0x00000001897FDEA0-0x00000001897FDEE0
	// [XID] // 0x00000001897FDEA0-0x00000001897FDEE0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001838960D0-0x0000000183896170
}

