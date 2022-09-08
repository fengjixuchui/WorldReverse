/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigSpecificFloatValue : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17788
{
	// Fields
	private SimpleSafeFloat defaultValueRawNum; // 0x10
	private Dictionary<string, SimpleSafeFloat> _specificValue; // 0x18

	// Properties
	public float defaultValue { /* [XID] */ /* 0x0000000189B44A10-0x0000000189B44A30 */ get => default; /* [XID] */ /* 0x0000000189B4C260-0x0000000189B4C280 */ private set {} } // 0x000000018131AEF0-0x000000018131AFD0 0x000000018131BAC0-0x000000018131BBA0
	public Dictionary<string, SimpleSafeFloat> specificValue { /* [XID] */ /* 0x0000000189B53880-0x0000000189B538A0 */ get => default; /* [XID] */ /* 0x0000000189B5B0F0-0x0000000189B5B110 */ private set {} } // 0x000000018131B720-0x000000018131B7C0 0x000000018131ACC0-0x000000018131AD70

	// Constructors
	public ConfigSpecificFloatValue() {} // 0x000000018131C100-0x000000018131C160

	// Methods
	// [XID] // 0x0000000189B625B0-0x0000000189B625D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018131BE10-0x000000018131BF20
	// [XID] // 0x0000000189B6A170-0x0000000189B6A190
	public void InitEmpty() {} // 0x000000018131B620-0x000000018131B720
	[BlackList] // 0x0000000189B71830-0x0000000189B71870
	// [XID] // 0x0000000189B71830-0x0000000189B71870
	public bool FromJson(JSONNode node) => default; // 0x000000018131B2A0-0x000000018131B620
	// [XID] // 0x0000000189B7BBD0-0x0000000189B7BBF0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018131A6E0-0x000000018131A9F0
	// [XID] // 0x0000000189B834E0-0x0000000189B83500
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C29 */, bool useObjectPool = false /* Metadata: 0x00AF7C2D */) => default; // 0x000000018131B7C0-0x000000018131BAC0
	// [XID] // 0x0000000189B8A970-0x0000000189B8A990
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C2E */, bool useObjectPool = false /* Metadata: 0x00AF7C32 */) => default; // 0x000000018131AFD0-0x000000018131B2A0
	[BlackList] // 0x0000000189B91EC0-0x0000000189B91F00
	// [XID] // 0x0000000189B91EC0-0x0000000189B91F00
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018131A9F0-0x000000018131ACC0
	// [XID] // 0x0000000189B9C420-0x0000000189B9C440
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018131BBA0-0x000000018131BE10
	[BlackList] // 0x0000000189BA3A10-0x0000000189BA3A50
	// [XID] // 0x0000000189BA3A10-0x0000000189BA3A50
	public virtual void AutoAllocTypeFields() {} // 0x000000018131AD70-0x000000018131AE10
	[BlackList] // 0x0000000189BADB40-0x0000000189BADB80
	// [XID] // 0x0000000189BADB40-0x0000000189BADB80
	public virtual void AutoRecycleTypeFields() {} // 0x000000018131AE10-0x000000018131AEF0
	[BlackList] // 0x0000000189BB81C0-0x0000000189BB8200
	// [XID] // 0x0000000189BB81C0-0x0000000189BB8200
	public virtual void ReturnToObjectPool() {} // 0x000000018131C060-0x000000018131C100
	[BlackList] // 0x0000000189BC3150-0x0000000189BC3190
	// [XID] // 0x0000000189BC3150-0x0000000189BC3190
	public virtual void OnPoolAllocated() {} // 0x000000018131BFC0-0x000000018131C060
	[BlackList] // 0x0000000189BCD8A0-0x0000000189BCD8E0
	// [XID] // 0x0000000189BCD8A0-0x0000000189BCD8E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018131BF20-0x000000018131BFC0
}

