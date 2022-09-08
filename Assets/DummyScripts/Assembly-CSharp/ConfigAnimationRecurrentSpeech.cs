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
public class ConfigAnimationRecurrentSpeech : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17517
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigFluctuatedValue _start; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigFluctuatedValue _interval; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _eventName; // 0x20

	// Properties
	public ConfigFluctuatedValue start { /* [XID] */ /* 0x000000018983DDA0-0x000000018983DDC0 */ get => default; /* [XID] */ /* 0x00000001898455D0-0x00000001898455F0 */ private set {} } // 0x000000018413CFF0-0x000000018413D090 0x000000018413C0E0-0x000000018413C190
	public ConfigFluctuatedValue interval { /* [XID] */ /* 0x000000018984CB00-0x000000018984CB20 */ get => default; /* [XID] */ /* 0x0000000189853BE0-0x0000000189853C00 */ private set {} } // 0x000000018413C9B0-0x000000018413CA50 0x000000018413BF80-0x000000018413C030
	public ConfigWwiseString eventName { /* [XID] */ /* 0x000000018985B5D0-0x000000018985B5F0 */ get => default; /* [XID] */ /* 0x0000000189862BB0-0x0000000189862BD0 */ private set {} } // 0x000000018413C510-0x000000018413C5B0 0x000000018413C030-0x000000018413C0E0

	// Constructors
	public ConfigAnimationRecurrentSpeech() {} // 0x000000018413D130-0x000000018413D190

	// Methods
	// [XID] // 0x000000018986A0A0-0x000000018986A0C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018413CD80-0x000000018413CEB0
	// [XID] // 0x00000001898713D0-0x00000001898713F0
	public void InitEmpty() {} // 0x000000018413C5B0-0x000000018413C6B0
	[BlackList] // 0x0000000189878DD0-0x0000000189878E10
	// [XID] // 0x0000000189878DD0-0x0000000189878E10
	public bool FromJson(JSONNode node) => default; // 0x000000018413C190-0x000000018413C510
	// [XID] // 0x0000000189882E10-0x0000000189882E30
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018413B210-0x000000018413B600
	// [XID] // 0x000000018988A670-0x000000018988A690
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF717F */, bool useObjectPool = false /* Metadata: 0x00AF7183 */) => default; // 0x000000018413C6B0-0x000000018413C9B0
	// [XID] // 0x0000000189891AE0-0x0000000189891B00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7184 */, bool useObjectPool = false /* Metadata: 0x00AF7188 */) => default; // 0x000000018413BB90-0x000000018413BF80
	[BlackList] // 0x0000000189899430-0x0000000189899470
	// [XID] // 0x0000000189899430-0x0000000189899470
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018413B600-0x000000018413B8D0
	// [XID] // 0x00000001898A3760-0x00000001898A3780
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018413CA50-0x000000018413CD80
	[BlackList] // 0x00000001898AABC0-0x00000001898AAC00
	// [XID] // 0x00000001898AABC0-0x00000001898AAC00
	public virtual void AutoAllocTypeFields() {} // 0x000000018413B8D0-0x000000018413B970
	[BlackList] // 0x00000001898B5510-0x00000001898B5550
	// [XID] // 0x00000001898B5510-0x00000001898B5550
	public virtual void AutoRecycleTypeFields() {} // 0x000000018413B970-0x000000018413BB90
	[BlackList] // 0x00000001898BFDC0-0x00000001898BFE00
	// [XID] // 0x00000001898BFDC0-0x00000001898BFE00
	public virtual void ReturnToObjectPool() {} // 0x000000018413D090-0x000000018413D130
	[BlackList] // 0x00000001898CA5C0-0x00000001898CA600
	// [XID] // 0x00000001898CA5C0-0x00000001898CA600
	public virtual void OnPoolAllocated() {} // 0x000000018413CF50-0x000000018413CFF0
	[BlackList] // 0x00000001898D4D90-0x00000001898D4DD0
	// [XID] // 0x00000001898D4D90-0x00000001898D4DD0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018413CEB0-0x000000018413CF50
}

