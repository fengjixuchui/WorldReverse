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

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ConfigActionPointSelectType : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17881
{
	// Fields
	public static Action<ConfigActionPointSelectType, bool> postProcessData; // 0x00
	public static Action<ConfigActionPointSelectType> postInitEmpty; // 0x08

	// Constructors
	public ConfigActionPointSelectType() {} // 0x00000001841384A0-0x0000000184138500
	static ConfigActionPointSelectType() {} // 0x0000000184138430-0x00000001841384A0

	// Methods
	// [XID] // 0x00000001899D4790-0x00000001899D47B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841381A0-0x0000000184138250
	// [XID] // 0x00000001899DBE50-0x00000001899DBE70
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184138040-0x00000001841380F0
	// [XID] // 0x00000001899E3810-0x00000001899E3830
	public virtual ConfigActionPointSelectType Clone(bool useObjectPool = false /* Metadata: 0x00AF8009 */) => default; // 0x0000000184137D60-0x0000000184137E40
	// [XID] // 0x00000001899EABA0-0x00000001899EABC0
	public virtual int GetHashNum() => default; // 0x0000000184136F80-0x0000000184137050
	// [XID] // 0x00000001899F27A0-0x00000001899F27C0
	public virtual void InitEmpty() {} // 0x00000001841377E0-0x00000001841378F0
	[BlackList] // 0x00000001899F9CD0-0x00000001899F9D10
	// [XID] // 0x00000001899F9CD0-0x00000001899F9D10
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000184137130-0x0000000184137530
	// [XID] // 0x0000000189A041D0-0x0000000189A041F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184136AC0-0x0000000184136B70
	[BlackList] // 0x0000000189A0B950-0x0000000189A0B990
	// [XID] // 0x0000000189A0B950-0x0000000189A0B990
	public static ConfigActionPointSelectType ParseFromJson(JSONNode node) => default; // 0x0000000184137E40-0x0000000184138040
	// [XID] // 0x0000000189A15F00-0x0000000189A15F20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF800A */, bool useObjectPool = false /* Metadata: 0x00AF800E */) => default; // 0x00000001841379E0-0x0000000184137D60
	// [XID] // 0x0000000189A1D4E0-0x0000000189A1D500
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF800F */, bool useObjectPool = false /* Metadata: 0x00AF8013 */) => default; // 0x0000000184137050-0x0000000184137130
	// [XID] // 0x0000000189A24990-0x0000000189A249B0
	public static ConfigActionPointSelectType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8014 */, bool useObjectPool = false /* Metadata: 0x00AF8018 */) => default; // 0x0000000184137610-0x00000001841377E0
	[BlackList] // 0x0000000189A2BF70-0x0000000189A2BFB0
	// [XID] // 0x0000000189A2BF70-0x0000000189A2BFB0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000184136B70-0x0000000184136E40
	// [XID] // 0x0000000189A369B0-0x0000000189A369D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841380F0-0x00000001841381A0
	[BlackList] // 0x0000000189A3E010-0x0000000189A3E050
	// [XID] // 0x0000000189A3E010-0x0000000189A3E050
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001841378F0-0x00000001841379E0
	[BlackList] // 0x0000000189A48690-0x0000000189A486D0
	// [XID] // 0x0000000189A48690-0x0000000189A486D0
	public virtual void OnPoolAllocated() {} // 0x00000001841382F0-0x0000000184138390
	[BlackList] // 0x0000000189A52C40-0x0000000189A52C80
	// [XID] // 0x0000000189A52C40-0x0000000189A52C80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184138250-0x00000001841382F0
	// [XID] // 0x0000000189A5D880-0x0000000189A5D8A0
	public virtual LevelActionPoint GetActionPoint(ActionPointType actionPointType, BaseEntity targetEntity, BaseEntity selfEntity) => default; // 0x0000000184137530-0x0000000184137610
	[BlackList] // 0x0000000189A65020-0x0000000189A65060
	// [XID] // 0x0000000189A65020-0x0000000189A65060
	public virtual void AutoAllocTypeFields() {} // 0x0000000184136E40-0x0000000184136EE0
	[BlackList] // 0x0000000189A6F7E0-0x0000000189A6F820
	// [XID] // 0x0000000189A6F7E0-0x0000000189A6F820
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184136EE0-0x0000000184136F80
	[BlackList] // 0x0000000189A7A4F0-0x0000000189A7A530
	// [XID] // 0x0000000189A7A4F0-0x0000000189A7A530
	public virtual void ReturnToObjectPool() {} // 0x0000000184138390-0x0000000184138430
}

