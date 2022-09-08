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
public class ConfigAvatarAudio : ConfigCharacterAudio, IAutoAllocRecycle // TypeDefIndex: 18046
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMoveStateAudio _moveStateAudio; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCombatSpeech _combatSpeech; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _voiceSwitch; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _bodyTypeSwitch; // 0x50
	private SimpleSafeFloat listenerLiftupRawNum; // 0x58
	private SimpleSafeFloat surfaceProberLiftupRawNum; // 0x5C

	// Properties
	public ConfigMoveStateAudio moveStateAudio { /* [XID] */ /* 0x00000001897A6B60-0x00000001897A6B80 */ get => default; /* [XID] */ /* 0x0000000189729BC0-0x0000000189729BE0 */ private set {} } // 0x0000000184E56290-0x0000000184E56330 0x0000000184E57310-0x0000000184E573C0
	public ConfigCombatSpeech combatSpeech { /* [XID] */ /* 0x0000000189731280-0x00000001897312A0 */ get => default; /* [XID] */ /* 0x0000000189738AB0-0x0000000189738AD0 */ private set {} } // 0x0000000184E57440-0x0000000184E574E0 0x0000000184E58FC0-0x0000000184E59070
	public ConfigWwiseString voiceSwitch { /* [XID] */ /* 0x00000001897408A0-0x00000001897408C0 */ get => default; /* [XID] */ /* 0x0000000189747C30-0x0000000189747C50 */ private set {} } // 0x0000000184E57BF0-0x0000000184E57C90 0x0000000184E57B40-0x0000000184E57BF0
	public ConfigWwiseString bodyTypeSwitch { /* [XID] */ /* 0x000000018974F470-0x000000018974F490 */ get => default; /* [XID] */ /* 0x0000000189756A80-0x0000000189756AA0 */ private set {} } // 0x0000000184E57DF0-0x0000000184E57E90 0x0000000184E592E0-0x0000000184E59390
	public float listenerLiftup { /* [XID] */ /* 0x0000000189BDA050-0x0000000189BDA070 */ get => default; /* [XID] */ /* 0x0000000189765670-0x0000000189765690 */ private set {} } // 0x0000000184E598D0-0x0000000184E599B0 0x0000000184E59200-0x0000000184E592E0
	public float surfaceProberLiftup { /* [XID] */ /* 0x000000018976CF00-0x000000018976CF20 */ get => default; /* [XID] */ /* 0x0000000189774390-0x00000001897743B0 */ private set {} } // 0x0000000184E58290-0x0000000184E58370 0x0000000184E57D10-0x0000000184E57DF0

	// Constructors
	public ConfigAvatarAudio() {} // 0x0000000184E59C20-0x0000000184E59C80

	// Methods
	// [XID] // 0x000000018977BCA0-0x000000018977BCC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184E599B0-0x0000000184E59B80
	// [XID] // 0x00000001897836B0-0x00000001897836D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184E590D0-0x0000000184E59200
	// [XID] // 0x000000018978ADA0-0x000000018978ADC0
	public override ConfigEntityAudio Clone(bool useObjectPool = false /* Metadata: 0x00AF87BD */) => default; // 0x0000000184E58C30-0x0000000184E58D10
	// [XID] // 0x00000001897923A0-0x00000001897923C0
	public override int GetHashNum() => default; // 0x0000000184E571E0-0x0000000184E572B0
	// [XID] // 0x0000000189799970-0x0000000189799990
	public override void InitEmpty() {} // 0x0000000184E58600-0x0000000184E58760
	[BlackList] // 0x00000001897A17E0-0x00000001897A1820
	// [XID] // 0x00000001897A17E0-0x00000001897A1820
	public override bool FromJson(JSONNode node) => default; // 0x0000000184E57F10-0x0000000184E58290
	// [XID] // 0x00000001897ABF40-0x00000001897ABF60
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184E56330-0x0000000184E56A90
	[BlackList] // 0x00000001897B3EB0-0x00000001897B3EF0
	// [XID] // 0x00000001897B3EB0-0x00000001897B3EF0
	public static new ConfigAvatarAudio ParseFromJson(JSONNode node) => default; // 0x0000000184E58D70-0x0000000184E58FC0
	// [XID] // 0x00000001897BEF10-0x00000001897BEF30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87BE */, bool useObjectPool = false /* Metadata: 0x00AF87C2 */) => default; // 0x0000000184E58930-0x0000000184E58C30
	// [XID] // 0x00000001897C6560-0x00000001897C6580
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87C3 */, bool useObjectPool = false /* Metadata: 0x00AF87C7 */) => default; // 0x0000000184E574E0-0x0000000184E57B40
	// [XID] // 0x00000001897CDD40-0x00000001897CDD60
	public static new ConfigAvatarAudio ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87C8 */, bool useObjectPool = false /* Metadata: 0x00AF87CC */) => default; // 0x0000000184E58370-0x0000000184E58590
	[BlackList] // 0x00000001897D5250-0x00000001897D5290
	// [XID] // 0x00000001897D5250-0x00000001897D5290
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184E56A90-0x0000000184E56D60
	// [XID] // 0x00000001897DFB50-0x00000001897DFB70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184E59390-0x0000000184E598D0
	[BlackList] // 0x00000001897E7150-0x00000001897E7190
	// [XID] // 0x00000001897E7150-0x00000001897E7190
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184E58840-0x0000000184E58930
	[BlackList] // 0x00000001897F2210-0x00000001897F2250
	// [XID] // 0x00000001897F2210-0x00000001897F2250
	public override void AutoAllocTypeFields() {} // 0x0000000184E56D60-0x0000000184E56E00
	[BlackList] // 0x00000001897FCA20-0x00000001897FCA60
	// [XID] // 0x00000001897FCA20-0x00000001897FCA60
	public override void AutoRecycleTypeFields() {} // 0x0000000184E56E00-0x0000000184E570C0
	[BlackList] // 0x0000000189806E10-0x0000000189806E50
	// [XID] // 0x0000000189806E10-0x0000000189806E50
	public override void ReturnToObjectPool() {} // 0x0000000184E59B80-0x0000000184E59C20
}

