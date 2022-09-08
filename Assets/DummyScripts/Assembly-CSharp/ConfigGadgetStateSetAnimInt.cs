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
public class ConfigGadgetStateSetAnimInt : ConfigGadgetStateAction, IAutoAllocRecycle // TypeDefIndex: 14957
{
	// Fields
	private string _intID; // 0x20
	private SimpleSafeInt32 valueRawNum; // 0x28
	private bool _syncState; // 0x2C

	// Properties
	public string intID { /* [XID] */ /* 0x0000000189A17BF0-0x0000000189A17C10 */ get => default; /* [XID] */ /* 0x0000000189A1F1F0-0x0000000189A1F210 */ private set {} } // 0x0000000182AE8130-0x0000000182AE81D0 0x0000000182AE9050-0x0000000182AE9100
	public int value { /* [XID] */ /* 0x0000000189A267A0-0x0000000189A267C0 */ get => default; /* [XID] */ /* 0x0000000189A2DB10-0x0000000189A2DB30 */ private set {} } // 0x0000000182AE8060-0x0000000182AE8130 0x0000000182AE7F00-0x0000000182AE7FE0
	public bool syncState { /* [XID] */ /* 0x0000000189A35730-0x0000000189A35750 */ get => default; /* [XID] */ /* 0x0000000189A3CBA0-0x0000000189A3CBC0 */ private set {} } // 0x0000000182AE9160-0x0000000182AE9200 0x0000000182AE7DD0-0x0000000182AE7E80

	// Constructors
	public ConfigGadgetStateSetAnimInt() {} // 0x0000000182AE9BF0-0x0000000182AE9C50

	// Methods
	// [XID] // 0x0000000189A09090-0x0000000189A090B0
	public override void DoAction(BaseEntity entity, GadgetState state) {} // 0x0000000182AE8E50-0x0000000182AE8F70
	// [XID] // 0x0000000189A10590-0x0000000189A105B0
	public override bool CheckState(GadgetState curGadgetState) => default; // 0x0000000182AE9590-0x0000000182AE9660
	// [XID] // 0x0000000189A445F0-0x0000000189A44610
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AE9A20-0x0000000182AE9B50
	// [XID] // 0x0000000189A4BBE0-0x0000000189A4BC00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182AE94B0-0x0000000182AE9590
	// [XID] // 0x0000000189A532E0-0x0000000189A53300
	public override ConfigGadgetStateAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFBFD */) => default; // 0x0000000182AE8F70-0x0000000182AE9050
	// [XID] // 0x0000000189A5AA10-0x0000000189A5AA30
	public override int GetHashNum() => default; // 0x0000000182AE78A0-0x0000000182AE7970
	// [XID] // 0x0000000189A621D0-0x0000000189A621F0
	public override void InitEmpty() {} // 0x0000000182AE8870-0x0000000182AE8980
	[BlackList] // 0x0000000189A6A0D0-0x0000000189A6A110
	// [XID] // 0x0000000189A6A0D0-0x0000000189A6A110
	public override bool FromJson(JSONNode node) => default; // 0x0000000182AE81D0-0x0000000182AE8550
	// [XID] // 0x0000000189A744D0-0x0000000189A744F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182AE6F20-0x0000000182AE7330
	[BlackList] // 0x0000000189A7BF40-0x0000000189A7BF80
	// [XID] // 0x0000000189A7BF40-0x0000000189A7BF80
	public static new ConfigGadgetStateSetAnimInt ParseFromJson(JSONNode node) => default; // 0x0000000182AE9200-0x0000000182AE9450
	// [XID] // 0x0000000189A86670-0x0000000189A86690
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBFE */, bool useObjectPool = false /* Metadata: 0x00AEFC02 */) => default; // 0x0000000182AE8B50-0x0000000182AE8E50
	// [XID] // 0x0000000189A8E270-0x0000000189A8E290
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC03 */, bool useObjectPool = false /* Metadata: 0x00AEFC07 */) => default; // 0x0000000182AE7A50-0x0000000182AE7DD0
	// [XID] // 0x0000000189A95770-0x0000000189A95790
	public static new ConfigGadgetStateSetAnimInt ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC08 */, bool useObjectPool = false /* Metadata: 0x00AEFC0C */) => default; // 0x0000000182AE8550-0x0000000182AE8770
	[BlackList] // 0x0000000189A9CFF0-0x0000000189A9D030
	// [XID] // 0x0000000189A9CFF0-0x0000000189A9D030
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AE7330-0x0000000182AE7600
	// [XID] // 0x0000000189AA75E0-0x0000000189AA7600
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AE96E0-0x0000000182AE9A20
	[BlackList] // 0x0000000189AAEC60-0x0000000189AAECA0
	// [XID] // 0x0000000189AAEC60-0x0000000189AAECA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182AE8A60-0x0000000182AE8B50
	[BlackList] // 0x0000000189AB9310-0x0000000189AB9350
	// [XID] // 0x0000000189AB9310-0x0000000189AB9350
	public override void AutoAllocTypeFields() {} // 0x0000000182AE7600-0x0000000182AE76A0
	[BlackList] // 0x0000000189AC4360-0x0000000189AC43A0
	// [XID] // 0x0000000189AC4360-0x0000000189AC43A0
	public override void AutoRecycleTypeFields() {} // 0x0000000182AE76A0-0x0000000182AE7780
	[BlackList] // 0x0000000189ACE8B0-0x0000000189ACE8F0
	// [XID] // 0x0000000189ACE8B0-0x0000000189ACE8F0
	public override void ReturnToObjectPool() {} // 0x0000000182AE9B50-0x0000000182AE9BF0
}

