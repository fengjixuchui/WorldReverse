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
public class FocusAssistance : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16354
{
	// Fields
	private bool _useFocusSticky; // 0x10
	private bool _useAutoFocus; // 0x11
	private bool _useGyro; // 0x12

	// Properties
	public bool useFocusSticky { /* [XID] */ /* 0x00000001896A6430-0x00000001896A6450 */ get => default; /* [XID] */ /* 0x00000001896AD9B0-0x00000001896AD9D0 */ private set {} } // 0x00000001822D7F90-0x00000001822D8030 0x00000001822D7EE0-0x00000001822D7F90
	public bool useAutoFocus { /* [XID] */ /* 0x00000001896B5170-0x00000001896B5190 */ get => default; /* [XID] */ /* 0x00000001896BC380-0x00000001896BC3A0 */ private set {} } // 0x00000001822D82F0-0x00000001822D8390 0x00000001822D73A0-0x00000001822D7450
	public bool useGyro { /* [XID] */ /* 0x00000001896C3860-0x00000001896C3880 */ get => default; /* [XID] */ /* 0x00000001896CAD30-0x00000001896CAD50 */ private set {} } // 0x00000001822D7720-0x00000001822D77C0 0x00000001822D85F0-0x00000001822D86A0

	// Constructors
	public FocusAssistance() {} // 0x00000001822D8740-0x00000001822D87B0

	// Methods
	// [XID] // 0x00000001896D23E0-0x00000001896D2400
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822D8390-0x00000001822D84B0
	// [XID] // 0x00000001896D9DF0-0x00000001896D9E10
	public void InitEmpty() {} // 0x00000001822D7B40-0x00000001822D7BE0
	[BlackList] // 0x00000001896E1430-0x00000001896E1470
	// [XID] // 0x00000001896E1430-0x00000001896E1470
	public bool FromJson(JSONNode node) => default; // 0x00000001822D77C0-0x00000001822D7B40
	// [XID] // 0x00000001896EB7E0-0x00000001896EB800
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001822D6C50-0x00000001822D6F90
	// [XID] // 0x00000001896F2BF0-0x00000001896F2C10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38D4 */, bool useObjectPool = false /* Metadata: 0x00AF38D8 */) => default; // 0x00000001822D7BE0-0x00000001822D7EE0
	// [XID] // 0x00000001896FA510-0x00000001896FA530
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38D9 */, bool useObjectPool = false /* Metadata: 0x00AF38DD */) => default; // 0x00000001822D7450-0x00000001822D7720
	[BlackList] // 0x0000000189701C40-0x0000000189701C80
	// [XID] // 0x0000000189701C40-0x0000000189701C80
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001822D6F90-0x00000001822D7260
	// [XID] // 0x000000018970C310-0x000000018970C330
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001822D8030-0x00000001822D82F0
	[BlackList] // 0x0000000189713CC0-0x0000000189713D00
	// [XID] // 0x0000000189713CC0-0x0000000189713D00
	public virtual void AutoAllocTypeFields() {} // 0x00000001822D7260-0x00000001822D7300
	[BlackList] // 0x000000018971E2C0-0x000000018971E300
	// [XID] // 0x000000018971E2C0-0x000000018971E300
	public virtual void AutoRecycleTypeFields() {} // 0x00000001822D7300-0x00000001822D73A0
	[BlackList] // 0x00000001897287F0-0x0000000189728830
	// [XID] // 0x00000001897287F0-0x0000000189728830
	public virtual void ReturnToObjectPool() {} // 0x00000001822D86A0-0x00000001822D8740
	[BlackList] // 0x0000000189732E40-0x0000000189732E80
	// [XID] // 0x0000000189732E40-0x0000000189732E80
	public virtual void OnPoolAllocated() {} // 0x00000001822D8550-0x00000001822D85F0
	[BlackList] // 0x000000018973DAB0-0x000000018973DAF0
	// [XID] // 0x000000018973DAB0-0x000000018973DAF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001822D84B0-0x00000001822D8550
}

