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
public class ConfigAttackAttenuation : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18113
{
	// Fields
	private SimpleSafeFloat resetCycleRawNum; // 0x10
	private SimpleSafeFloat[] _durabilitySequence; // 0x18
	private SimpleSafeFloat[] _enbreakSequence; // 0x20
	private SimpleSafeFloat[] _damageSequence; // 0x28

	// Properties
	public float resetCycle { /* [XID] */ /* 0x0000000189684460-0x0000000189684480 */ get => default; /* [XID] */ /* 0x00000001897A9060-0x00000001897A9080 */ private set {} } // 0x0000000183DADBE0-0x0000000183DADCC0 0x0000000183DAD1E0-0x0000000183DAD2C0
	public SimpleSafeFloat[] durabilitySequence { /* [XID] */ /* 0x000000018998CDC0-0x000000018998CDE0 */ get => default; /* [XID] */ /* 0x00000001897B85E0-0x00000001897B8600 */ private set {} } // 0x0000000183DAE590-0x0000000183DAE630 0x0000000183DAEBB0-0x0000000183DAEC60
	public SimpleSafeFloat[] enbreakSequence { /* [XID] */ /* 0x00000001897C06C0-0x00000001897C06E0 */ get => default; /* [XID] */ /* 0x00000001897C7EF0-0x00000001897C7F10 */ private set {} } // 0x0000000183DAE0C0-0x0000000183DAE160 0x0000000183DAE160-0x0000000183DAE210
	public SimpleSafeFloat[] damageSequence { /* [XID] */ /* 0x00000001897CF290-0x00000001897CF2B0 */ get => default; /* [XID] */ /* 0x00000001897D6AE0-0x00000001897D6B00 */ private set {} } // 0x0000000183DAEB10-0x0000000183DAEBB0 0x0000000183DAE760-0x0000000183DAE810

	// Constructors
	public ConfigAttackAttenuation() {} // 0x0000000183DAF360-0x0000000183DAF3C0

	// Methods
	// [XID] // 0x00000001897DE210-0x00000001897DE230
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183DAF040-0x0000000183DAF180
	// [XID] // 0x00000001897E5C90-0x00000001897E5CB0
	public void InitEmpty() {} // 0x0000000183DAE630-0x0000000183DAE760
	[BlackList] // 0x00000001897ED6D0-0x00000001897ED710
	// [XID] // 0x00000001897ED6D0-0x00000001897ED710
	public bool FromJson(JSONNode node) => default; // 0x0000000183DAE210-0x0000000183DAE590
	// [XID] // 0x00000001897F7FA0-0x00000001897F7FC0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183DAD2C0-0x0000000183DAD790
	// [XID] // 0x00000001897FF630-0x00000001897FF650
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B81 */, bool useObjectPool = false /* Metadata: 0x00AF8B85 */) => default; // 0x0000000183DAE810-0x0000000183DAEB10
	// [XID] // 0x0000000189806DB0-0x0000000189806DD0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B86 */, bool useObjectPool = false /* Metadata: 0x00AF8B8A */) => default; // 0x0000000183DADCC0-0x0000000183DAE0C0
	[BlackList] // 0x000000018980E490-0x000000018980E4D0
	// [XID] // 0x000000018980E490-0x000000018980E4D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183DAD790-0x0000000183DADA60
	// [XID] // 0x0000000189818E30-0x0000000189818E50
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183DAEC60-0x0000000183DAF040
	[BlackList] // 0x0000000189820650-0x0000000189820690
	// [XID] // 0x0000000189820650-0x0000000189820690
	public virtual void AutoAllocTypeFields() {} // 0x0000000183DADA60-0x0000000183DADB00
	[BlackList] // 0x000000018982AB30-0x000000018982AB70
	// [XID] // 0x000000018982AB30-0x000000018982AB70
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183DADB00-0x0000000183DADBE0
	[BlackList] // 0x0000000189834FD0-0x0000000189835010
	// [XID] // 0x0000000189834FD0-0x0000000189835010
	public virtual void ReturnToObjectPool() {} // 0x0000000183DAF2C0-0x0000000183DAF360
	[BlackList] // 0x000000018983F5F0-0x000000018983F630
	// [XID] // 0x000000018983F5F0-0x000000018983F630
	public virtual void OnPoolAllocated() {} // 0x0000000183DAF220-0x0000000183DAF2C0
	[BlackList] // 0x0000000189849950-0x0000000189849990
	// [XID] // 0x0000000189849950-0x0000000189849990
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183DAF180-0x0000000183DAF220
}

