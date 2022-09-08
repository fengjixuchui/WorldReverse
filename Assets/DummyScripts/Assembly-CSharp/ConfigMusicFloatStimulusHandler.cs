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
using MoleMole.Audio.Music.Miiha;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicFloatStimulusHandler : ConfigMusicParameterizedStimulusHandler, IAutoAllocRecycle // TypeDefIndex: 18754
{
	// Fields
	private SimpleSafeFloat floatParamRawNum; // 0x20

	// Properties
	public float floatParam { /* [XID] */ /* 0x0000000189B22290-0x0000000189B222B0 */ get => default; /* [XID] */ /* 0x0000000189B29860-0x0000000189B29880 */ private set {} } // 0x0000000184FCD330-0x0000000184FCD410 0x0000000184FCBD30-0x0000000184FCBE10

	// Constructors
	public ConfigMusicFloatStimulusHandler() {} // 0x0000000184FCD7A0-0x0000000184FCD800

	// Methods
	// [XID] // 0x0000000189B30E10-0x0000000189B30E30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184FCD600-0x0000000184FCD700
	// [XID] // 0x0000000189B384D0-0x0000000189B384F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184FCD280-0x0000000184FCD330
	// [XID] // 0x0000000189B3FF20-0x0000000189B3FF40
	public override ConfigMusicStimulusHandler Clone(bool useObjectPool = false /* Metadata: 0x00AFAB0D */) => default; // 0x0000000184FCCE90-0x0000000184FCCF70
	// [XID] // 0x0000000189B47760-0x0000000189B47780
	public override int GetHashNum() => default; // 0x0000000184FCBC60-0x0000000184FCBD30
	// [XID] // 0x0000000189B4EEB0-0x0000000189B4EED0
	public override void InitEmpty() {} // 0x0000000184FCC8F0-0x0000000184FCC9C0
	[BlackList] // 0x0000000189B56890-0x0000000189B568D0
	// [XID] // 0x0000000189B56890-0x0000000189B568D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184FCC260-0x0000000184FCC5E0
	// [XID] // 0x0000000189B61070-0x0000000189B61090
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184FCB480-0x0000000184FCB6F0
	[BlackList] // 0x0000000189B68760-0x0000000189B687A0
	// [XID] // 0x0000000189B68760-0x0000000189B687A0
	public static new ConfigMusicFloatStimulusHandler ParseFromJson(JSONNode node) => default; // 0x0000000184FCCFD0-0x0000000184FCD220
	// [XID] // 0x0000000189B72C90-0x0000000189B72CB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB0E */, bool useObjectPool = false /* Metadata: 0x00AFAB12 */) => default; // 0x0000000184FCCB90-0x0000000184FCCE90
	// [XID] // 0x0000000189B7A1F0-0x0000000189B7A210
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB13 */, bool useObjectPool = false /* Metadata: 0x00AFAB17 */) => default; // 0x0000000184FCBEF0-0x0000000184FCC160
	// [XID] // 0x0000000189B81910-0x0000000189B81930
	public static new ConfigMusicFloatStimulusHandler ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB18 */, bool useObjectPool = false /* Metadata: 0x00AFAB1C */) => default; // 0x0000000184FCC5E0-0x0000000184FCC800
	[BlackList] // 0x0000000189B89030-0x0000000189B89070
	// [XID] // 0x0000000189B89030-0x0000000189B89070
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184FCB6F0-0x0000000184FCB9C0
	// [XID] // 0x0000000189B934D0-0x0000000189B934F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184FCD410-0x0000000184FCD600
	[BlackList] // 0x0000000189B9AA00-0x0000000189B9AA40
	// [XID] // 0x0000000189B9AA00-0x0000000189B9AA40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184FCCAA0-0x0000000184FCCB90
	// [XID] // 0x0000000189BA51D0-0x0000000189BA51F0
	protected override bool MatchParameter(IStimulusParameter parameter) => default; // 0x0000000184FCB300-0x0000000184FCB400
	[BlackList] // 0x0000000189BAC2B0-0x0000000189BAC2F0
	// [XID] // 0x0000000189BAC2B0-0x0000000189BAC2F0
	public override void AutoAllocTypeFields() {} // 0x0000000184FCB9C0-0x0000000184FCBA60
	[BlackList] // 0x0000000189BB6970-0x0000000189BB69B0
	// [XID] // 0x0000000189BB6970-0x0000000189BB69B0
	public override void AutoRecycleTypeFields() {} // 0x0000000184FCBA60-0x0000000184FCBB40
	[BlackList] // 0x0000000189BC1700-0x0000000189BC1740
	// [XID] // 0x0000000189BC1700-0x0000000189BC1740
	public override void ReturnToObjectPool() {} // 0x0000000184FCD700-0x0000000184FCD7A0
}

