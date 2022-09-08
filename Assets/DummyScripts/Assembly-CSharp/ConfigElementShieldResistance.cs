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
public class ConfigElementShieldResistance : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18105
{
	// Fields
	private ElementType _elementType; // 0x10
	private SimpleSafeFloat[] _damageRatio; // 0x18
	private SimpleSafeInt32[] _restraint; // 0x20

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189777530-0x0000000189777550 */ get => default; /* [XID] */ /* 0x000000018977EC60-0x000000018977EC80 */ private set {} } // 0x0000000183183C20-0x0000000183183CC0 0x0000000183184580-0x0000000183184630
	public SimpleSafeFloat[] damageRatio { /* [XID] */ /* 0x0000000189786580-0x00000001897865A0 */ get => default; /* [XID] */ /* 0x000000018978DC50-0x000000018978DC70 */ private set {} } // 0x0000000183183CC0-0x0000000183183D60 0x0000000183183B70-0x0000000183183C20
	public SimpleSafeInt32[] restraint { /* [XID] */ /* 0x0000000189795240-0x0000000189795260 */ get => default; /* [XID] */ /* 0x000000018979D610-0x000000018979D630 */ private set {} } // 0x00000001831837A0-0x0000000183183840 0x00000001831844D0-0x0000000183184580

	// Constructors
	public ConfigElementShieldResistance() {} // 0x0000000183184C50-0x0000000183184CB0

	// Methods
	// [XID] // 0x00000001897A4910-0x00000001897A4930
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183184950-0x0000000183184A70
	// [XID] // 0x00000001897ABEE0-0x00000001897ABF00
	public void InitEmpty() {} // 0x00000001831840E0-0x00000001831841D0
	[BlackList] // 0x00000001897B3E70-0x00000001897B3EB0
	// [XID] // 0x00000001897B3E70-0x00000001897B3EB0
	public bool FromJson(JSONNode node) => default; // 0x0000000183183D60-0x00000001831840E0
	// [XID] // 0x00000001897BEED0-0x00000001897BEEF0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183182FE0-0x0000000183183380
	// [XID] // 0x00000001897C6520-0x00000001897C6540
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B31 */, bool useObjectPool = false /* Metadata: 0x00AF8B35 */) => default; // 0x00000001831841D0-0x00000001831844D0
	// [XID] // 0x00000001897CDCE0-0x00000001897CDD00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B36 */, bool useObjectPool = false /* Metadata: 0x00AF8B3A */) => default; // 0x0000000183183840-0x0000000183183B70
	[BlackList] // 0x00000001897D51D0-0x00000001897D5210
	// [XID] // 0x00000001897D51D0-0x00000001897D5210
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183183380-0x0000000183183650
	// [XID] // 0x00000001897DFAB0-0x00000001897DFAD0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183184630-0x0000000183184950
	[BlackList] // 0x00000001897E7110-0x00000001897E7150
	// [XID] // 0x00000001897E7110-0x00000001897E7150
	public virtual void AutoAllocTypeFields() {} // 0x0000000183183650-0x00000001831836F0
	[BlackList] // 0x00000001897F2190-0x00000001897F21D0
	// [XID] // 0x00000001897F2190-0x00000001897F21D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001831836F0-0x00000001831837A0
	[BlackList] // 0x00000001897FC9C0-0x00000001897FCA00
	// [XID] // 0x00000001897FC9C0-0x00000001897FCA00
	public virtual void ReturnToObjectPool() {} // 0x0000000183184BB0-0x0000000183184C50
	[BlackList] // 0x0000000189806DD0-0x0000000189806E10
	// [XID] // 0x0000000189806DD0-0x0000000189806E10
	public virtual void OnPoolAllocated() {} // 0x0000000183184B10-0x0000000183184BB0
	[BlackList] // 0x0000000189811320-0x0000000189811360
	// [XID] // 0x0000000189811320-0x0000000189811360
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183184A70-0x0000000183184B10
}

