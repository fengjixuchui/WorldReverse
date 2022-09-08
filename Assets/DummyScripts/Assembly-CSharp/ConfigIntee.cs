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
public class ConfigIntee : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17959
{
	// Fields
	private bool _useTrigger; // 0x10
	private bool _useInteractionTrigger; // 0x11
	private bool _usePushCollider; // 0x12
	private bool _useHeadControlTrigger; // 0x13
	private SimpleSafeFloat triggerRadiusRawNum; // 0x14
	private SimpleSafeFloat triggerHeightRawNum; // 0x18
	private SimpleSafeFloat interactionTriggerRadiusRawNum; // 0x1C
	private SimpleSafeFloat headCtrlRadiusRawNum; // 0x20

	// Properties
	public bool useTrigger { /* [XID] */ /* 0x0000000189ABC580-0x0000000189ABC5A0 */ get => default; /* [XID] */ /* 0x0000000189AC3F40-0x0000000189AC3F60 */ private set {} } // 0x000000018153F100-0x000000018153F1A0 0x0000000181540F30-0x0000000181540FE0
	public bool useInteractionTrigger { /* [XID] */ /* 0x0000000189ACB3B0-0x0000000189ACB3D0 */ get => default; /* [XID] */ /* 0x0000000189AD2E00-0x0000000189AD2E20 */ private set {} } // 0x000000018153F060-0x000000018153F100 0x0000000181540030-0x00000001815400E0
	public bool usePushCollider { /* [XID] */ /* 0x0000000189B64C30-0x0000000189B64C50 */ get => default; /* [XID] */ /* 0x0000000189AE20A0-0x0000000189AE20C0 */ private set {} } // 0x000000018153FE10-0x000000018153FEB0 0x0000000181541360-0x0000000181541410
	public bool useHeadControlTrigger { /* [XID] */ /* 0x0000000189B5D4A0-0x0000000189B5D4C0 */ get => default; /* [XID] */ /* 0x0000000189AF16D0-0x0000000189AF16F0 */ private set {} } // 0x000000018153FF90-0x0000000181540030 0x00000001815400E0-0x0000000181540190
	public float triggerRadius { /* [XID] */ /* 0x0000000189B6C010-0x0000000189B6C030 */ get => default; /* [XID] */ /* 0x0000000189B00270-0x0000000189B00290 */ private set {} } // 0x0000000181540E50-0x0000000181540F30 0x0000000181540FE0-0x00000001815410C0
	public float triggerHeight { /* [XID] */ /* 0x0000000189B7AD80-0x0000000189B7ADA0 */ get => default; /* [XID] */ /* 0x0000000189B0F130-0x0000000189B0F150 */ private set {} } // 0x00000001815410C0-0x00000001815411A0 0x00000001815411A0-0x0000000181541280
	public float interactionTriggerRadius { /* [XID] */ /* 0x0000000189B73870-0x0000000189B73890 */ get => default; /* [XID] */ /* 0x0000000189B1DB90-0x0000000189B1DBB0 */ private set {} } // 0x0000000181541280-0x0000000181541360 0x0000000181541410-0x00000001815414F0
	public float headCtrlRadius { /* [XID] */ /* 0x0000000189B82730-0x0000000189B82750 */ get => default; /* [XID] */ /* 0x0000000189B2C970-0x0000000189B2C990 */ private set {} } // 0x000000018153FEB0-0x000000018153FF90 0x00000001815414F0-0x00000001815415D0

	// Constructors
	public ConfigIntee() {} // 0x0000000181541ED0-0x0000000181541FB0

	// Methods
	// [XID] // 0x0000000189B33D60-0x0000000189B33D80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181541B40-0x0000000181541CF0
	// [XID] // 0x0000000189B3B610-0x0000000189B3B630
	public void InitEmpty() {} // 0x0000000181540A40-0x0000000181540B50
	[BlackList] // 0x0000000189B43050-0x0000000189B43090
	// [XID] // 0x0000000189B43050-0x0000000189B43090
	public bool FromJson(JSONNode node) => default; // 0x00000001815406C0-0x0000000181540A40
	// [XID] // 0x0000000189B4D7B0-0x0000000189B4D7D0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018153F1A0-0x000000018153F990
	// [XID] // 0x0000000189B54FB0-0x0000000189B54FD0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84DD */, bool useObjectPool = false /* Metadata: 0x00AF84E1 */) => default; // 0x0000000181540B50-0x0000000181540E50
	// [XID] // 0x0000000189B5C9B0-0x0000000189B5C9D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84E2 */, bool useObjectPool = false /* Metadata: 0x00AF84E6 */) => default; // 0x0000000181540190-0x00000001815406C0
	[BlackList] // 0x0000000189B64050-0x0000000189B64090
	// [XID] // 0x0000000189B64050-0x0000000189B64090
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018153F990-0x000000018153FC60
	// [XID] // 0x0000000189B6E500-0x0000000189B6E520
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001815415D0-0x0000000181541B40
	[BlackList] // 0x0000000189B75D30-0x0000000189B75D70
	// [XID] // 0x0000000189B75D30-0x0000000189B75D70
	public virtual void AutoAllocTypeFields() {} // 0x000000018153FC60-0x000000018153FD00
	[BlackList] // 0x0000000189B801B0-0x0000000189B801F0
	// [XID] // 0x0000000189B801B0-0x0000000189B801F0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018153FD00-0x000000018153FE10
	[BlackList] // 0x0000000189B8A930-0x0000000189B8A970
	// [XID] // 0x0000000189B8A930-0x0000000189B8A970
	public virtual void ReturnToObjectPool() {} // 0x0000000181541E30-0x0000000181541ED0
	[BlackList] // 0x0000000189B94C50-0x0000000189B94C90
	// [XID] // 0x0000000189B94C50-0x0000000189B94C90
	public virtual void OnPoolAllocated() {} // 0x0000000181541D90-0x0000000181541E30
	[BlackList] // 0x0000000189B9EFF0-0x0000000189B9F030
	// [XID] // 0x0000000189B9EFF0-0x0000000189B9F030
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181541CF0-0x0000000181541D90
}

