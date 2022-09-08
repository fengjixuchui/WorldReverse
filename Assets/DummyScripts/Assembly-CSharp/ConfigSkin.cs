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
public class ConfigSkin : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19001
{
	// Constructors
	public ConfigSkin() {} // 0x0000000183245620-0x0000000183245680

	// Methods
	// [XID] // 0x00000001898A65E0-0x00000001898A6600
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183245390-0x0000000183245440
	// [XID] // 0x00000001898ADD30-0x00000001898ADD50
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183245230-0x00000001832452E0
	// [XID] // 0x00000001898B51F0-0x00000001898B5210
	public virtual ConfigSkin Clone(bool useObjectPool = false /* Metadata: 0x00AFB6E9 */) => default; // 0x0000000183244F50-0x0000000183245030
	// [XID] // 0x00000001898BCCE0-0x00000001898BCD00
	public virtual int GetHashNum() => default; // 0x00000001832443C0-0x0000000183244490
	// [XID] // 0x00000001898C4440-0x00000001898C4460
	public virtual void InitEmpty() {} // 0x0000000183244AC0-0x0000000183244B60
	[BlackList] // 0x00000001898CB9B0-0x00000001898CB9F0
	// [XID] // 0x00000001898CB9B0-0x00000001898CB9F0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183244570-0x00000001832448F0
	// [XID] // 0x00000001898D6320-0x00000001898D6340
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183243F00-0x0000000183243FB0
	[BlackList] // 0x00000001898DDFE0-0x00000001898DE020
	// [XID] // 0x00000001898DDFE0-0x00000001898DE020
	public static ConfigSkin ParseFromJson(JSONNode node) => default; // 0x0000000183245030-0x0000000183245230
	// [XID] // 0x00000001898E8AC0-0x00000001898E8AE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6EA */, bool useObjectPool = false /* Metadata: 0x00AFB6EE */) => default; // 0x0000000183244C50-0x0000000183244F50
	// [XID] // 0x00000001898F0220-0x00000001898F0240
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6EF */, bool useObjectPool = false /* Metadata: 0x00AFB6F3 */) => default; // 0x0000000183244490-0x0000000183244570
	// [XID] // 0x00000001898F7CD0-0x00000001898F7CF0
	public static ConfigSkin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6F4 */, bool useObjectPool = false /* Metadata: 0x00AFB6F8 */) => default; // 0x00000001832448F0-0x0000000183244AC0
	[BlackList] // 0x00000001898FF230-0x00000001898FF270
	// [XID] // 0x00000001898FF230-0x00000001898FF270
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183243FB0-0x0000000183244280
	// [XID] // 0x0000000189909A00-0x0000000189909A20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832452E0-0x0000000183245390
	[BlackList] // 0x00000001899111A0-0x00000001899111E0
	// [XID] // 0x00000001899111A0-0x00000001899111E0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183244B60-0x0000000183244C50
	[BlackList] // 0x000000018991BEA0-0x000000018991BEE0
	// [XID] // 0x000000018991BEA0-0x000000018991BEE0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183244280-0x0000000183244320
	[BlackList] // 0x0000000189926580-0x00000001899265C0
	// [XID] // 0x0000000189926580-0x00000001899265C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183244320-0x00000001832443C0
	[BlackList] // 0x0000000189930C80-0x0000000189930CC0
	// [XID] // 0x0000000189930C80-0x0000000189930CC0
	public virtual void ReturnToObjectPool() {} // 0x0000000183245580-0x0000000183245620
	[BlackList] // 0x000000018993B530-0x000000018993B570
	// [XID] // 0x000000018993B530-0x000000018993B570
	public virtual void OnPoolAllocated() {} // 0x00000001832454E0-0x0000000183245580
	[BlackList] // 0x00000001899459C0-0x0000000189945A00
	// [XID] // 0x00000001899459C0-0x0000000189945A00
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183245440-0x00000001832454E0
}

