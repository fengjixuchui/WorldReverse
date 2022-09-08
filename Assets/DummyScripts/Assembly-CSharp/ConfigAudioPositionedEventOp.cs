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
public class ConfigAudioPositionedEventOp : ConfigAudioPositionedOp, IAutoAllocRecycle // TypeDefIndex: 17613
{
	// Fields
	private SimpleSafeFloat durationRawNum; // 0x20

	// Properties
	public float duration { /* [XID] */ /* 0x000000018972CBC0-0x000000018972CBE0 */ get => default; /* [XID] */ /* 0x00000001897343B0-0x00000001897343D0 */ private set {} } // 0x000000018464EE00-0x000000018464EEE0 0x000000018464F380-0x000000018464F460

	// Constructors
	public ConfigAudioPositionedEventOp() {} // 0x0000000184650940-0x00000001846509A0

	// Methods
	// [XID] // 0x000000018973BC80-0x000000018973BCA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001846507A0-0x00000001846508A0
	// [XID] // 0x0000000189743550-0x0000000189743570
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184650500-0x00000001846505B0
	// [XID] // 0x000000018974B1E0-0x000000018974B200
	public override ConfigAudioOperation Clone(bool useObjectPool = false /* Metadata: 0x00AF74B9 */) => default; // 0x0000000184650110-0x00000001846501F0
	// [XID] // 0x0000000189752230-0x0000000189752250
	public override int GetHashNum() => default; // 0x000000018464EF60-0x000000018464F030
	// [XID] // 0x0000000189759860-0x0000000189759880
	public override void InitEmpty() {} // 0x000000018464FB70-0x000000018464FC40
	[BlackList] // 0x0000000189761470-0x00000001897614B0
	// [XID] // 0x0000000189761470-0x00000001897614B0
	public override bool FromJson(JSONNode node) => default; // 0x000000018464F560-0x000000018464F8E0
	// [XID] // 0x000000018976B980-0x000000018976B9A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018464E6A0-0x000000018464E910
	[BlackList] // 0x0000000189772E00-0x0000000189772E40
	// [XID] // 0x0000000189772E00-0x0000000189772E40
	public static new ConfigAudioPositionedEventOp ParseFromJson(JSONNode node) => default; // 0x0000000184650250-0x00000001846504A0
	// [XID] // 0x000000018977D740-0x000000018977D760
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74BA */, bool useObjectPool = false /* Metadata: 0x00AF74BE */) => default; // 0x000000018464FE10-0x0000000184650110
	// [XID] // 0x0000000189785020-0x0000000189785040
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74BF */, bool useObjectPool = false /* Metadata: 0x00AF74C3 */) => default; // 0x000000018464F110-0x000000018464F380
	// [XID] // 0x000000018978C4F0-0x000000018978C510
	public static new ConfigAudioPositionedEventOp ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74C4 */, bool useObjectPool = false /* Metadata: 0x00AF74C8 */) => default; // 0x000000018464F8E0-0x000000018464FB00
	[BlackList] // 0x0000000189793A00-0x0000000189793A40
	// [XID] // 0x0000000189793A00-0x0000000189793A40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018464E910-0x000000018464EBE0
	// [XID] // 0x000000018979ED50-0x000000018979ED70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001846505B0-0x00000001846507A0
	[BlackList] // 0x00000001897A6360-0x00000001897A63A0
	// [XID] // 0x00000001897A6360-0x00000001897A63A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018464FD20-0x000000018464FE10
	[BlackList] // 0x00000001897B0960-0x00000001897B09A0
	// [XID] // 0x00000001897B0960-0x00000001897B09A0
	public override void AutoAllocTypeFields() {} // 0x000000018464EBE0-0x000000018464EC80
	[BlackList] // 0x00000001897BBC30-0x00000001897BBC70
	// [XID] // 0x00000001897BBC30-0x00000001897BBC70
	public override void AutoRecycleTypeFields() {} // 0x000000018464EC80-0x000000018464ED60
	[BlackList] // 0x00000001897C65E0-0x00000001897C6620
	// [XID] // 0x00000001897C65E0-0x00000001897C6620
	public override void ReturnToObjectPool() {} // 0x00000001846508A0-0x0000000184650940
}

