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
public class ConfigGadgetDoAttackEvent : ConfigBaseGadgetTriggerAction, IAutoAllocRecycle // TypeDefIndex: 14951
{
	// Fields
	private string _attackEvent; // 0x10

	// Properties
	public string attackEvent { /* [XID] */ /* 0x0000000189B80650-0x0000000189B80670 */ get => default; /* [XID] */ /* 0x0000000189B881E0-0x0000000189B88200 */ private set {} } // 0x0000000184AB94E0-0x0000000184AB9580 0x0000000184AB8E90-0x0000000184AB8F40

	// Constructors
	public ConfigGadgetDoAttackEvent() {} // 0x0000000184AB9E80-0x0000000184AB9EE0

	// Methods
	// [XID] // 0x0000000189B79200-0x0000000189B79220
	public override void DoTriggerAction(LCGadgetCombat gadgetCombat, uint otherID, int actionIdx) {} // 0x0000000184AB77B0-0x0000000184AB7BF0
	// [XID] // 0x0000000189B8F4B0-0x0000000189B8F4D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184AB9C50-0x0000000184AB9D40
	// [XID] // 0x0000000189B96910-0x0000000189B96930
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184AB9970-0x0000000184AB9A50
	// [XID] // 0x0000000189B9DE60-0x0000000189B9DE80
	public override ConfigBaseGadgetTriggerAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFB9D */) => default; // 0x0000000184AB9580-0x0000000184AB9660
	// [XID] // 0x0000000189BA57F0-0x0000000189BA5810
	public override int GetHashNum() => default; // 0x0000000184AB8360-0x0000000184AB8430
	// [XID] // 0x0000000189BACA10-0x0000000189BACA30
	public override void InitEmpty() {} // 0x0000000184AB8F40-0x0000000184AB9010
	[BlackList] // 0x0000000189BB4270-0x0000000189BB42B0
	// [XID] // 0x0000000189BB4270-0x0000000189BB42B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184AB8880-0x0000000184AB8C00
	// [XID] // 0x0000000189BBE550-0x0000000189BBE570
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184AB7BF0-0x0000000184AB7E20
	[BlackList] // 0x0000000189BC6280-0x0000000189BC62C0
	// [XID] // 0x0000000189BC6280-0x0000000189BC62C0
	public static new ConfigGadgetDoAttackEvent ParseFromJson(JSONNode node) => default; // 0x0000000184AB96C0-0x0000000184AB9910
	// [XID] // 0x0000000189BD0BD0-0x0000000189BD0BF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB9E */, bool useObjectPool = false /* Metadata: 0x00AEFBA2 */) => default; // 0x0000000184AB91E0-0x0000000184AB94E0
	// [XID] // 0x0000000189BD81B0-0x0000000189BD81D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBA3 */, bool useObjectPool = false /* Metadata: 0x00AEFBA7 */) => default; // 0x0000000184AB8510-0x0000000184AB8780
	// [XID] // 0x0000000189BDFCE0-0x0000000189BDFD00
	public static new ConfigGadgetDoAttackEvent ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBA8 */, bool useObjectPool = false /* Metadata: 0x00AEFBAC */) => default; // 0x0000000184AB8C00-0x0000000184AB8E20
	[BlackList] // 0x00000001895EC890-0x00000001895EC8D0
	// [XID] // 0x00000001895EC890-0x00000001895EC8D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184AB7E20-0x0000000184AB80F0
	// [XID] // 0x00000001895F71E0-0x00000001895F7200
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184AB9A50-0x0000000184AB9C50
	[BlackList] // 0x00000001895FE600-0x00000001895FE640
	// [XID] // 0x00000001895FE600-0x00000001895FE640
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184AB90F0-0x0000000184AB91E0
	[BlackList] // 0x0000000189609070-0x00000001896090B0
	// [XID] // 0x0000000189609070-0x00000001896090B0
	public override void AutoAllocTypeFields() {} // 0x0000000184AB80F0-0x0000000184AB8190
	[BlackList] // 0x00000001896135A0-0x00000001896135E0
	// [XID] // 0x00000001896135A0-0x00000001896135E0
	public override void AutoRecycleTypeFields() {} // 0x0000000184AB8190-0x0000000184AB8240
	[BlackList] // 0x000000018961DE50-0x000000018961DE90
	// [XID] // 0x000000018961DE50-0x000000018961DE90
	public override void ReturnToObjectPool() {} // 0x0000000184AB9DE0-0x0000000184AB9E80
}

