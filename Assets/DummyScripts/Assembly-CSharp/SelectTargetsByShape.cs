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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class SelectTargetsByShape : SelectTargets, IAutoAllocRecycle // TypeDefIndex: 14945
{
	// Fields
	private string _shapeName; // 0x28
	private AbilityTargetting _centerBasedOn; // 0x30
	private TargetType _campTargetType; // 0x34
	private AbilityTargetting _campBasedOn; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _sizeRatio; // 0x40

	// Properties
	public string shapeName { /* [XID] */ /* 0x00000001899A0630-0x00000001899A0650 */ get => default; /* [XID] */ /* 0x00000001899A8180-0x00000001899A81A0 */ private set {} } // 0x00000001810CCE00-0x00000001810CCEA0 0x00000001810CE060-0x00000001810CE110
	public AbilityTargetting centerBasedOn { /* [XID] */ /* 0x00000001899AF910-0x00000001899AF930 */ get => default; /* [XID] */ /* 0x00000001899B6D90-0x00000001899B6DB0 */ private set {} } // 0x00000001810CDFC0-0x00000001810CE060 0x00000001810CCD50-0x00000001810CCE00
	public TargetType campTargetType { /* [XID] */ /* 0x0000000189982820-0x0000000189982840 */ get => default; /* [XID] */ /* 0x00000001899C60B0-0x00000001899C60D0 */ private set {} } // 0x00000001810CD990-0x00000001810CDA30 0x00000001810CE330-0x00000001810CE3E0
	public AbilityTargetting campBasedOn { /* [XID] */ /* 0x00000001899CD830-0x00000001899CD850 */ get => default; /* [XID] */ /* 0x00000001899D4CF0-0x00000001899D4D10 */ private set {} } // 0x00000001810CD560-0x00000001810CD600 0x00000001810CE280-0x00000001810CE330
	public DynamicFloat sizeRatio { /* [XID] */ /* 0x00000001899DC410-0x00000001899DC430 */ get => default; /* [XID] */ /* 0x00000001899E3C30-0x00000001899E3C50 */ private set {} } // 0x00000001810CC690-0x00000001810CC730 0x00000001810CCEA0-0x00000001810CCF50

	// Constructors
	public SelectTargetsByShape(AbilityTargetting campBaseOn, string shapeName, float sizeRatio, TargetType campTargetType) {} // 0x00000001810CE480-0x00000001810CE580
	public SelectTargetsByShape() {} // 0x00000001810CE580-0x00000001810CE620

	// Methods
	// [XID] // 0x00000001899EB040-0x00000001899EB060
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001810CE110-0x00000001810CE280
	// [XID] // 0x00000001899F2C60-0x00000001899F2C80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001810CDA90-0x00000001810CDB90
	// [XID] // 0x00000001899FA2F0-0x00000001899FA310
	public override SelectTargets Clone(bool useObjectPool = false /* Metadata: 0x00AEFB32 */) => default; // 0x00000001810CD600-0x00000001810CD6E0
	// [XID] // 0x0000000189A01670-0x0000000189A01690
	public override int GetHashNum() => default; // 0x00000001810CBFF0-0x00000001810CC0C0
	// [XID] // 0x0000000189A090F0-0x0000000189A09110
	public override void InitEmpty() {} // 0x00000001810CCFC0-0x00000001810CD090
	[BlackList] // 0x0000000189A105B0-0x0000000189A105F0
	// [XID] // 0x0000000189A105B0-0x0000000189A105F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001810CC7B0-0x00000001810CCB30
	// [XID] // 0x0000000189A1A9F0-0x0000000189A1AA10
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001810CB4B0-0x00000001810CBA20
	[BlackList] // 0x0000000189A22310-0x0000000189A22350
	// [XID] // 0x0000000189A22310-0x0000000189A22350
	public static new SelectTargetsByShape ParseFromJson(JSONNode node) => default; // 0x00000001810CD740-0x00000001810CD990
	// [XID] // 0x0000000189A2C530-0x0000000189A2C550
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB33 */, bool useObjectPool = false /* Metadata: 0x00AEFB37 */) => default; // 0x00000001810CD260-0x00000001810CD560
	// [XID] // 0x0000000189A33C00-0x0000000189A33C20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB38 */, bool useObjectPool = false /* Metadata: 0x00AEFB3C */) => default; // 0x00000001810CC1A0-0x00000001810CC610
	// [XID] // 0x0000000189A3B360-0x0000000189A3B380
	public static new SelectTargetsByShape ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB3D */, bool useObjectPool = false /* Metadata: 0x00AEFB41 */) => default; // 0x00000001810CCB30-0x00000001810CCD50
	[BlackList] // 0x0000000189A42E10-0x0000000189A42E50
	// [XID] // 0x0000000189A42E10-0x0000000189A42E50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001810CBA20-0x00000001810CBCF0
	// [XID] // 0x0000000189A4D3C0-0x0000000189A4D3E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001810CDB90-0x00000001810CDFC0
	[BlackList] // 0x0000000189A54BB0-0x0000000189A54BF0
	// [XID] // 0x0000000189A54BB0-0x0000000189A54BF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001810CD170-0x00000001810CD260
	[BlackList] // 0x0000000189A5F5B0-0x0000000189A5F5F0
	// [XID] // 0x0000000189A5F5B0-0x0000000189A5F5F0
	public override void AutoAllocTypeFields() {} // 0x00000001810CBCF0-0x00000001810CBD90
	[BlackList] // 0x0000000189A6A110-0x0000000189A6A150
	// [XID] // 0x0000000189A6A110-0x0000000189A6A150
	public override void AutoRecycleTypeFields() {} // 0x00000001810CBD90-0x00000001810CBED0
	[BlackList] // 0x0000000189A744F0-0x0000000189A74530
	// [XID] // 0x0000000189A744F0-0x0000000189A74530
	public override void ReturnToObjectPool() {} // 0x00000001810CE3E0-0x00000001810CE480
}

