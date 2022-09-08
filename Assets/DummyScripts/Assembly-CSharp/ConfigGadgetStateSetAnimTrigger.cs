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
public class ConfigGadgetStateSetAnimTrigger : ConfigGadgetStateAction, IAutoAllocRecycle // TypeDefIndex: 14956
{
	// Fields
	private string _triggerID; // 0x20

	// Properties
	public string triggerID { /* [XID] */ /* 0x000000018995DF10-0x000000018995DF30 */ get => default; /* [XID] */ /* 0x0000000189965790-0x00000001899657B0 */ private set {} } // 0x00000001835E3270-0x00000001835E3310 0x00000001835E41E0-0x00000001835E4290

	// Constructors
	public ConfigGadgetStateSetAnimTrigger() {} // 0x00000001835E4330-0x00000001835E4390

	// Methods
	// [XID] // 0x0000000189956540-0x0000000189956560
	public override void DoAction(BaseEntity entity, GadgetState state) {} // 0x00000001835E3940-0x00000001835E3A20
	// [XID] // 0x000000018996CF10-0x000000018996CF30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835E40F0-0x00000001835E41E0
	// [XID] // 0x0000000189974770-0x0000000189974790
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835E3E10-0x00000001835E3EF0
	// [XID] // 0x000000018997BD40-0x000000018997BD60
	public override ConfigGadgetStateAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFBED */) => default; // 0x00000001835E3A20-0x00000001835E3B00
	// [XID] // 0x0000000189983910-0x0000000189983930
	public override int GetHashNum() => default; // 0x00000001835E2740-0x00000001835E2810
	// [XID] // 0x000000018998B160-0x000000018998B180
	public override void InitEmpty() {} // 0x00000001835E33A0-0x00000001835E3470
	[BlackList] // 0x0000000189992CD0-0x0000000189992D10
	// [XID] // 0x0000000189992CD0-0x0000000189992D10
	public override bool FromJson(JSONNode node) => default; // 0x00000001835E2C60-0x00000001835E2FE0
	// [XID] // 0x000000018999D650-0x000000018999D670
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001835E1FD0-0x00000001835E2200
	[BlackList] // 0x00000001899A4F30-0x00000001899A4F70
	// [XID] // 0x00000001899A4F30-0x00000001899A4F70
	public static new ConfigGadgetStateSetAnimTrigger ParseFromJson(JSONNode node) => default; // 0x00000001835E3B60-0x00000001835E3DB0
	// [XID] // 0x00000001899AF8F0-0x00000001899AF910
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBEE */, bool useObjectPool = false /* Metadata: 0x00AEFBF2 */) => default; // 0x00000001835E3640-0x00000001835E3940
	// [XID] // 0x00000001899B6D70-0x00000001899B6D90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBF3 */, bool useObjectPool = false /* Metadata: 0x00AEFBF7 */) => default; // 0x00000001835E28F0-0x00000001835E2B60
	// [XID] // 0x00000001899BE850-0x00000001899BE870
	public static new ConfigGadgetStateSetAnimTrigger ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBF8 */, bool useObjectPool = false /* Metadata: 0x00AEFBFC */) => default; // 0x00000001835E2FE0-0x00000001835E3200
	[BlackList] // 0x00000001899C6070-0x00000001899C60B0
	// [XID] // 0x00000001899C6070-0x00000001899C60B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001835E2200-0x00000001835E24D0
	// [XID] // 0x00000001899D0730-0x00000001899D0750
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835E3EF0-0x00000001835E40F0
	[BlackList] // 0x00000001899D7C70-0x00000001899D7CB0
	// [XID] // 0x00000001899D7C70-0x00000001899D7CB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001835E3550-0x00000001835E3640
	[BlackList] // 0x00000001899E24C0-0x00000001899E2500
	// [XID] // 0x00000001899E24C0-0x00000001899E2500
	public override void AutoAllocTypeFields() {} // 0x00000001835E24D0-0x00000001835E2570
	[BlackList] // 0x00000001899EC970-0x00000001899EC9B0
	// [XID] // 0x00000001899EC970-0x00000001899EC9B0
	public override void AutoRecycleTypeFields() {} // 0x00000001835E2570-0x00000001835E2620
	[BlackList] // 0x00000001899F7390-0x00000001899F73D0
	// [XID] // 0x00000001899F7390-0x00000001899F73D0
	public override void ReturnToObjectPool() {} // 0x00000001835E4290-0x00000001835E4330
}

