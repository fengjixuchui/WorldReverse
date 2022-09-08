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
public class ConfigGear : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17983
{
	// Fields
	private GearType _gearType; // 0x10
	private ElementType _startElemType; // 0x14
	private SimpleSafeUInt32 startValueRawNum; // 0x18
	private SimpleSafeUInt32 startLastTimeRawNum; // 0x1C
	private ElementType _stopElemType; // 0x20
	private SimpleSafeUInt32 stopValueRawNum; // 0x24
	private SimpleSafeUInt32 stopLastTimeRawNum; // 0x28

	// Properties
	public GearType gearType { /* [XID] */ /* 0x0000000189972AB0-0x0000000189972AD0 */ get => default; /* [XID] */ /* 0x000000018997A330-0x000000018997A350 */ private set {} } // 0x0000000184B115C0-0x0000000184B11660 0x0000000184B11E20-0x0000000184B11ED0
	public ElementType startElemType { /* [XID] */ /* 0x0000000189981B00-0x0000000189981B20 */ get => default; /* [XID] */ /* 0x00000001899894A0-0x00000001899894C0 */ private set {} } // 0x0000000184B12250-0x0000000184B122F0 0x0000000184B12940-0x0000000184B129F0
	public uint startValue { /* [XID] */ /* 0x0000000189990C70-0x0000000189990C90 */ get => default; /* [XID] */ /* 0x0000000189998790-0x00000001899987B0 */ private set {} } // 0x0000000184B114F0-0x0000000184B115C0 0x0000000184B122F0-0x0000000184B123D0
	public uint startLastTime { /* [XID] */ /* 0x00000001899A0010-0x00000001899A0030 */ get => default; /* [XID] */ /* 0x00000001899A7BE0-0x00000001899A7C00 */ private set {} } // 0x0000000184B13410-0x0000000184B134E0 0x0000000184B129F0-0x0000000184B12AD0
	public ElementType stopElemType { /* [XID] */ /* 0x00000001899AF3B0-0x00000001899AF3D0 */ get => default; /* [XID] */ /* 0x00000001899B6830-0x00000001899B6850 */ private set {} } // 0x0000000184B11730-0x0000000184B117D0 0x0000000184B123D0-0x0000000184B12480
	public uint stopValue { /* [XID] */ /* 0x00000001899BE3D0-0x00000001899BE3F0 */ get => default; /* [XID] */ /* 0x00000001899C5B90-0x00000001899C5BB0 */ private set {} } // 0x0000000184B12480-0x0000000184B12550 0x0000000184B13330-0x0000000184B13410
	public uint stopLastTime { /* [XID] */ /* 0x00000001899CD1F0-0x00000001899CD210 */ get => default; /* [XID] */ /* 0x00000001899D4770-0x00000001899D4790 */ private set {} } // 0x0000000184B11660-0x0000000184B11730 0x0000000184B11D40-0x0000000184B11E20

	// Constructors
	public ConfigGear() {} // 0x0000000184B13580-0x0000000184B135E0

	// Methods
	// [XID] // 0x00000001899DBE30-0x00000001899DBE50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B13060-0x0000000184B131F0
	// [XID] // 0x00000001899E37F0-0x00000001899E3810
	public void InitEmpty() {} // 0x0000000184B12550-0x0000000184B12640
	[BlackList] // 0x00000001899EAB60-0x00000001899EABA0
	// [XID] // 0x00000001899EAB60-0x00000001899EABA0
	public bool FromJson(JSONNode node) => default; // 0x0000000184B11ED0-0x0000000184B12250
	// [XID] // 0x00000001899F5610-0x00000001899F5630
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184B10880-0x0000000184B11070
	// [XID] // 0x00000001899FCD70-0x00000001899FCD90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF859D */, bool useObjectPool = false /* Metadata: 0x00AF85A1 */) => default; // 0x0000000184B12640-0x0000000184B12940
	// [XID] // 0x0000000189A041B0-0x0000000189A041D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85A2 */, bool useObjectPool = false /* Metadata: 0x00AF85A6 */) => default; // 0x0000000184B117D0-0x0000000184B11D40
	[BlackList] // 0x0000000189A0B910-0x0000000189A0B950
	// [XID] // 0x0000000189A0B910-0x0000000189A0B950
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B11070-0x0000000184B11340
	// [XID] // 0x0000000189A15EC0-0x0000000189A15EE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B12AD0-0x0000000184B13060
	[BlackList] // 0x0000000189A1D440-0x0000000189A1D480
	// [XID] // 0x0000000189A1D440-0x0000000189A1D480
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B11340-0x0000000184B113E0
	[BlackList] // 0x0000000189A27860-0x0000000189A278A0
	// [XID] // 0x0000000189A27860-0x0000000189A278A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B113E0-0x0000000184B114F0
	[BlackList] // 0x0000000189A31DC0-0x0000000189A31E00
	// [XID] // 0x0000000189A31DC0-0x0000000189A31E00
	public virtual void ReturnToObjectPool() {} // 0x0000000184B134E0-0x0000000184B13580
	[BlackList] // 0x0000000189A3C530-0x0000000189A3C570
	// [XID] // 0x0000000189A3C530-0x0000000189A3C570
	public virtual void OnPoolAllocated() {} // 0x0000000184B13290-0x0000000184B13330
	[BlackList] // 0x0000000189A46E90-0x0000000189A46ED0
	// [XID] // 0x0000000189A46E90-0x0000000189A46ED0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B131F0-0x0000000184B13290
}

