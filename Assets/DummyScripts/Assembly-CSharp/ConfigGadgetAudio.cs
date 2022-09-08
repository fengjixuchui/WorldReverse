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
public class ConfigGadgetAudio : ConfigEntityAudio, IAutoAllocRecycle // TypeDefIndex: 18042
{
	// Fields
	private bool _triggersSpeech; // 0x38

	// Properties
	public bool triggersSpeech { /* [XID] */ /* 0x0000000189A7DCC0-0x0000000189A7DCE0 */ get => default; /* [XID] */ /* 0x0000000189BC17E0-0x0000000189BC1800 */ private set {} } // 0x0000000184185EB0-0x0000000184185F50 0x0000000184186760-0x0000000184186810

	// Constructors
	public ConfigGadgetAudio() {} // 0x0000000184187FD0-0x0000000184188030

	// Methods
	// [XID] // 0x0000000189BC8E20-0x0000000189BC8E40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184187E40-0x0000000184187F30
	// [XID] // 0x0000000189BD0630-0x0000000189BD0650
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184187B90-0x0000000184187C40
	// [XID] // 0x0000000189BD7BF0-0x0000000189BD7C10
	public override ConfigEntityAudio Clone(bool useObjectPool = false /* Metadata: 0x00AF879D */) => default; // 0x00000001841877A0-0x0000000184187880
	// [XID] // 0x0000000189BDF840-0x0000000189BDF860
	public override int GetHashNum() => default; // 0x0000000184186690-0x0000000184186760
	// [XID] // 0x00000001895EC370-0x00000001895EC390
	public override void InitEmpty() {} // 0x0000000184187230-0x00000001841872D0
	[BlackList] // 0x00000001895F3830-0x00000001895F3870
	// [XID] // 0x00000001895F3830-0x00000001895F3870
	public override bool FromJson(JSONNode node) => default; // 0x0000000184186C20-0x0000000184186FA0
	// [XID] // 0x00000001895FDF80-0x00000001895FDFA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184185F50-0x0000000184186150
	[BlackList] // 0x0000000189605750-0x0000000189605790
	// [XID] // 0x0000000189605750-0x0000000189605790
	public static new ConfigGadgetAudio ParseFromJson(JSONNode node) => default; // 0x00000001841878E0-0x0000000184187B30
	// [XID] // 0x0000000189610290-0x00000001896102B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF879E */, bool useObjectPool = false /* Metadata: 0x00AF87A2 */) => default; // 0x00000001841874A0-0x00000001841877A0
	// [XID] // 0x0000000189617550-0x0000000189617570
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87A3 */, bool useObjectPool = false /* Metadata: 0x00AF87A7 */) => default; // 0x00000001841868F0-0x0000000184186B20
	// [XID] // 0x000000018961F100-0x000000018961F120
	public static new ConfigGadgetAudio ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87A8 */, bool useObjectPool = false /* Metadata: 0x00AF87AC */) => default; // 0x0000000184186FA0-0x00000001841871C0
	[BlackList] // 0x0000000189626520-0x0000000189626560
	// [XID] // 0x0000000189626520-0x0000000189626560
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184186150-0x0000000184186420
	// [XID] // 0x0000000189631100-0x0000000189631120
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184187C40-0x0000000184187E40
	[BlackList] // 0x0000000189638AF0-0x0000000189638B30
	// [XID] // 0x0000000189638AF0-0x0000000189638B30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001841873B0-0x00000001841874A0
	[BlackList] // 0x0000000189643060-0x00000001896430A0
	// [XID] // 0x0000000189643060-0x00000001896430A0
	public override void AutoAllocTypeFields() {} // 0x0000000184186420-0x00000001841864C0
	[BlackList] // 0x000000018964D7E0-0x000000018964D820
	// [XID] // 0x000000018964D7E0-0x000000018964D820
	public override void AutoRecycleTypeFields() {} // 0x00000001841864C0-0x0000000184186570
	[BlackList] // 0x0000000189657F70-0x0000000189657FB0
	// [XID] // 0x0000000189657F70-0x0000000189657FB0
	public override void ReturnToObjectPool() {} // 0x0000000184187F30-0x0000000184187FD0
}

