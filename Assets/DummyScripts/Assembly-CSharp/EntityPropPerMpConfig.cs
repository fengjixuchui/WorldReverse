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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class EntityPropPerMpConfig : IAutoAllocRecycle // TypeDefIndex: 15331
{
	// Fields
	protected FightPropType _propType; // 0x10
	protected SimpleSafeFloat[] _propValueVec; // 0x18

	// Properties
	public FightPropType propType { /* [XID] */ /* 0x00000001896C6A70-0x00000001896C6A90 */ get => default; /* [XID] */ /* 0x00000001896CE1B0-0x00000001896CE1D0 */ protected set {} } // 0x00000001851A1680-0x00000001851A1720 0x00000001851A11C0-0x00000001851A1270
	public SimpleSafeFloat[] propValueVec { /* [XID] */ /* 0x00000001896D5780-0x00000001896D57A0 */ get => default; /* [XID] */ /* 0x00000001896DCBA0-0x00000001896DCBC0 */ protected set {} } // 0x00000001851A15E0-0x00000001851A1680 0x00000001851A1860-0x00000001851A1910

	// Constructors
	public EntityPropPerMpConfig() {} // 0x00000001851A19B0-0x00000001851A1A10

	// Methods
	// [XID] // 0x00000001896E4570-0x00000001896E4590
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001851A0DC0-0x00000001851A11C0
	// [XID] // 0x00000001896EB960-0x00000001896EB980
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07C7 */, bool useObjectPool = false /* Metadata: 0x00AF07CB */) => default; // 0x00000001851A1270-0x00000001851A15E0
	[BlackList] // 0x00000001896F2EB0-0x00000001896F2EF0
	// [XID] // 0x00000001896F2EB0-0x00000001896F2EF0
	public virtual void AutoAllocTypeFields() {} // 0x00000001851A0C80-0x00000001851A0D20
	[BlackList] // 0x00000001896FD850-0x00000001896FD890
	// [XID] // 0x00000001896FD850-0x00000001896FD890
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851A0D20-0x00000001851A0DC0
	[BlackList] // 0x0000000189707C70-0x0000000189707CB0
	// [XID] // 0x0000000189707C70-0x0000000189707CB0
	public virtual void ReturnToObjectPool() {} // 0x00000001851A1910-0x00000001851A19B0
	[BlackList] // 0x00000001897125B0-0x00000001897125F0
	// [XID] // 0x00000001897125B0-0x00000001897125F0
	public virtual void OnPoolAllocated() {} // 0x00000001851A17C0-0x00000001851A1860
	[BlackList] // 0x000000018971CCC0-0x000000018971CD00
	// [XID] // 0x000000018971CCC0-0x000000018971CD00
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851A1720-0x00000001851A17C0
}

