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
public class ConfigAnimatorBoolean : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19023
{
	// Fields
	private string _name; // 0x10
	private SimpleSafeFloat normalizeStartRawNum; // 0x18
	private SimpleSafeFloat normalizeEndRawNum; // 0x1C

	// Properties
	public string name { /* [XID] */ /* 0x0000000189B99260-0x0000000189B99280 */ get => default; /* [XID] */ /* 0x0000000189BA0630-0x0000000189BA0650 */ private set {} } // 0x0000000184721A80-0x0000000184721B20 0x0000000184721090-0x0000000184721140
	public float normalizeStart { /* [XID] */ /* 0x0000000189BA7E30-0x0000000189BA7E50 */ get => default; /* [XID] */ /* 0x0000000189BAF300-0x0000000189BAF320 */ private set {} } // 0x0000000184720770-0x0000000184720850 0x0000000184720850-0x0000000184720930
	public float normalizeEnd { /* [XID] */ /* 0x0000000189BB68F0-0x0000000189BB6910 */ get => default; /* [XID] */ /* 0x0000000189BBDFB0-0x0000000189BBDFD0 */ private set {} } // 0x0000000184720C30-0x0000000184720D10 0x0000000184720240-0x0000000184720320

	// Constructors
	public ConfigAnimatorBoolean() {} // 0x0000000184721BC0-0x0000000184721C70

	// Methods
	// [XID] // 0x0000000189BC5C20-0x0000000189BC5C40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184721820-0x0000000184721940
	// [XID] // 0x0000000189BCD680-0x0000000189BCD6A0
	public void InitEmpty() {} // 0x0000000184721140-0x0000000184721250
	[BlackList] // 0x0000000189BD4BD0-0x0000000189BD4C10
	// [XID] // 0x0000000189BD4BD0-0x0000000189BD4C10
	public bool FromJson(JSONNode node) => default; // 0x0000000184720D10-0x0000000184721090
	// [XID] // 0x0000000189BDF6E0-0x0000000189BDF700
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018471FE50-0x0000000184720240
	// [XID] // 0x00000001895EC1B0-0x00000001895EC1D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7CB */, bool useObjectPool = false /* Metadata: 0x00AFB7CF */) => default; // 0x0000000184721250-0x0000000184721550
	// [XID] // 0x00000001895F3670-0x00000001895F3690
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7D0 */, bool useObjectPool = false /* Metadata: 0x00AFB7D4 */) => default; // 0x0000000184720930-0x0000000184720C30
	[BlackList] // 0x00000001895FAFF0-0x00000001895FB030
	// [XID] // 0x00000001895FAFF0-0x00000001895FB030
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184720320-0x00000001847205F0
	// [XID] // 0x00000001896055B0-0x00000001896055D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184721550-0x0000000184721820
	[BlackList] // 0x000000018960CF60-0x000000018960CFA0
	// [XID] // 0x000000018960CF60-0x000000018960CFA0
	public virtual void AutoAllocTypeFields() {} // 0x00000001847205F0-0x0000000184720690
	[BlackList] // 0x00000001896173D0-0x0000000189617410
	// [XID] // 0x00000001896173D0-0x0000000189617410
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184720690-0x0000000184720770
	[BlackList] // 0x0000000189621C20-0x0000000189621C60
	// [XID] // 0x0000000189621C20-0x0000000189621C60
	public virtual void ReturnToObjectPool() {} // 0x0000000184721B20-0x0000000184721BC0
	[BlackList] // 0x000000018962C310-0x000000018962C350
	// [XID] // 0x000000018962C310-0x000000018962C350
	public virtual void OnPoolAllocated() {} // 0x00000001847219E0-0x0000000184721A80
	[BlackList] // 0x00000001896370A0-0x00000001896370E0
	// [XID] // 0x00000001896370A0-0x00000001896370E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184721940-0x00000001847219E0
}

