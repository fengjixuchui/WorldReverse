/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BaseActionContainer : IEmptyInitable, IHashable // TypeDefIndex: 16852
{
	// Fields
	[NonSerialized]
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private SimpleSafeInt32 localIDRawNum; // 0x10
	public List<ConfigAbilityAction[]> actionsList; // 0x18

	// Properties
	public int localID { /* [XID] */ /* 0x0000000189BA3C70-0x0000000189BA3C90 */ get; /* [XID] */ /* 0x0000000189BAB0E0-0x0000000189BAB100 */ set; } // 0x00000001835D64C0-0x00000001835D6590 0x00000001835D6330-0x00000001835D6410

	// Constructors
	public BaseActionContainer() {} // 0x00000001835D6590-0x00000001835D6620

	// Methods
	// [XID] // 0x00000001898E4BF0-0x00000001898E4C10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835D6410-0x00000001835D64C0
	// [XID] // 0x0000000189BB9B00-0x0000000189BB9B20
	public virtual void InitEmpty() {} // 0x00000001835D6260-0x00000001835D6330
	public abstract void GetAllSubActions();
	// [Conditional] // 0x0000000189BC1AA0-0x0000000189BC1AF0
	// [XID] // 0x0000000189BC1AA0-0x0000000189BC1AF0
	public void Assert(bool cond, string msg) {} // 0x00000001835D61A0-0x00000001835D6260
}

