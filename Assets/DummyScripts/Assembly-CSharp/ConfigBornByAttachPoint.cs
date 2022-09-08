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
public class ConfigBornByAttachPoint : ConfigBornType, IAutoAllocRecycle // TypeDefIndex: 17862
{
	// Fields
	private string _attachPointName; // 0x38
	private AttachPointTargetType _attachPointTargetType; // 0x40

	// Properties
	public string attachPointName { /* [XID] */ /* 0x0000000189917880-0x00000001899178A0 */ get => default; /* [XID] */ /* 0x000000018991EE80-0x000000018991EEA0 */ private set {} } // 0x0000000184B1DF20-0x0000000184B1DFC0 0x0000000184B1DFC0-0x0000000184B1E070
	public AttachPointTargetType attachPointTargetType { /* [XID] */ /* 0x00000001899268A0-0x00000001899268C0 */ get => default; /* [XID] */ /* 0x000000018992DDF0-0x000000018992DE10 */ private set {} } // 0x0000000184B1FAE0-0x0000000184B1FB80 0x0000000184B20200-0x0000000184B202B0

	// Constructors
	public ConfigBornByAttachPoint() {} // 0x0000000184B20460-0x0000000184B204C0

	// Methods
	// [XID] // 0x0000000189935230-0x0000000189935250
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B202B0-0x0000000184B203C0
	// [XID] // 0x000000018993CD90-0x000000018993CDB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184B1FE90-0x0000000184B1FF70
	// [XID] // 0x0000000189944460-0x0000000189944480
	public override ConfigBornType Clone(bool useObjectPool = false /* Metadata: 0x00AF7F69 */) => default; // 0x0000000184B1FA00-0x0000000184B1FAE0
	// [XID] // 0x000000018994BA60-0x000000018994BA80
	public override int GetHashNum() => default; // 0x0000000184B1E8C0-0x0000000184B1E990
	// [XID] // 0x0000000189953230-0x0000000189953250
	public override void InitEmpty() {} // 0x0000000184B1F460-0x0000000184B1F530
	[BlackList] // 0x000000018995A930-0x000000018995A970
	// [XID] // 0x000000018995A930-0x000000018995A970
	public override bool FromJson(JSONNode node) => default; // 0x0000000184B1EE50-0x0000000184B1F1D0
	// [XID] // 0x0000000189965330-0x0000000189965350
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184B1E070-0x0000000184B1E380
	[BlackList] // 0x000000018996C810-0x000000018996C850
	// [XID] // 0x000000018996C810-0x000000018996C850
	public static new ConfigBornByAttachPoint ParseFromJson(JSONNode node) => default; // 0x0000000184B1FBE0-0x0000000184B1FE30
	// [XID] // 0x00000001899771C0-0x00000001899771E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F6A */, bool useObjectPool = false /* Metadata: 0x00AF7F6E */) => default; // 0x0000000184B1F700-0x0000000184B1FA00
	// [XID] // 0x000000018997E560-0x000000018997E580
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F6F */, bool useObjectPool = false /* Metadata: 0x00AF7F73 */) => default; // 0x0000000184B1EA70-0x0000000184B1ED50
	// [XID] // 0x0000000189985FF0-0x0000000189986010
	public static new ConfigBornByAttachPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F74 */, bool useObjectPool = false /* Metadata: 0x00AF7F78 */) => default; // 0x0000000184B1F1D0-0x0000000184B1F3F0
	[BlackList] // 0x000000018998DC80-0x000000018998DCC0
	// [XID] // 0x000000018998DC80-0x000000018998DCC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B1E380-0x0000000184B1E650
	// [XID] // 0x00000001899987F0-0x0000000189998810
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B1FF70-0x0000000184B20200
	[BlackList] // 0x00000001899A0050-0x00000001899A0090
	// [XID] // 0x00000001899A0050-0x00000001899A0090
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184B1F610-0x0000000184B1F700
	[BlackList] // 0x00000001899AAAE0-0x00000001899AAB20
	// [XID] // 0x00000001899AAAE0-0x00000001899AAB20
	public override void AutoAllocTypeFields() {} // 0x0000000184B1E650-0x0000000184B1E6F0
	[BlackList] // 0x00000001899B5320-0x00000001899B5360
	// [XID] // 0x00000001899B5320-0x00000001899B5360
	public override void AutoRecycleTypeFields() {} // 0x0000000184B1E6F0-0x0000000184B1E7A0
	[BlackList] // 0x00000001899BFBB0-0x00000001899BFBF0
	// [XID] // 0x00000001899BFBB0-0x00000001899BFBF0
	public override void ReturnToObjectPool() {} // 0x0000000184B203C0-0x0000000184B20460
}

