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
public class ConfigAirflowField : ConfigConstForceField, IAutoAllocRecycle // TypeDefIndex: 18918
{
	// Fields
	private SimpleSafeFloat scaleRawNum; // 0x68
	private string _stayEffect; // 0x70
	private string _enterEffect; // 0x78
	private bool _autoFly; // 0x80

	// Properties
	public float scale { /* [XID] */ /* 0x0000000189A05C50-0x0000000189A05C70 */ get => default; /* [XID] */ /* 0x0000000189A0CF60-0x0000000189A0CF80 */ private set {} } // 0x0000000182275740-0x0000000182275820 0x0000000182276C20-0x0000000182276D00
	public string stayEffect { /* [XID] */ /* 0x0000000189A147C0-0x0000000189A147E0 */ get => default; /* [XID] */ /* 0x0000000189A1BB70-0x0000000189A1BB90 */ private set {} } // 0x0000000182275FD0-0x0000000182276070 0x00000001822763D0-0x0000000182276480
	public string enterEffect { /* [XID] */ /* 0x0000000189A23400-0x0000000189A23420 */ get => default; /* [XID] */ /* 0x0000000189A2A720-0x0000000189A2A740 */ private set {} } // 0x0000000182276480-0x0000000182276520 0x0000000182276A20-0x0000000182276AD0
	public bool autoFly { /* [XID] */ /* 0x0000000189A31C60-0x0000000189A31C80 */ get => default; /* [XID] */ /* 0x0000000189A396B0-0x0000000189A396D0 */ private set {} } // 0x00000001822760D0-0x0000000182276180 0x0000000182275B40-0x0000000182275BF0

	// Constructors
	public ConfigAirflowField() {} // 0x0000000182276DA0-0x0000000182276E50

	// Methods
	// [XID] // 0x0000000189A40E70-0x0000000189A40E90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182276AD0-0x0000000182276C20
	// [XID] // 0x0000000189A484D0-0x0000000189A484F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182276580-0x0000000182276680
	// [XID] // 0x0000000189A4FDE0-0x0000000189A4FE00
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AFB39B */) => default; // 0x0000000182275EF0-0x0000000182275FD0
	// [XID] // 0x0000000189A57310-0x0000000189A57330
	public override int GetHashNum() => default; // 0x0000000182274B50-0x0000000182274C20
	// [XID] // 0x0000000189A5EE30-0x0000000189A5EE50
	public override void InitEmpty() {} // 0x0000000182275890-0x0000000182275970
	[BlackList] // 0x0000000189A666E0-0x0000000189A66720
	// [XID] // 0x0000000189A666E0-0x0000000189A66720
	public override bool FromJson(JSONNode node) => default; // 0x00000001822751A0-0x0000000182275520
	// [XID] // 0x0000000189A70E60-0x0000000189A70E80
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182274140-0x00000001822745D0
	[BlackList] // 0x0000000189A788E0-0x0000000189A78920
	// [XID] // 0x0000000189A788E0-0x0000000189A78920
	public static new ConfigAirflowField ParseFromJson(JSONNode node) => default; // 0x0000000182276180-0x00000001822763D0
	// [XID] // 0x0000000189A83120-0x0000000189A83140
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB39C */, bool useObjectPool = false /* Metadata: 0x00AFB3A0 */) => default; // 0x0000000182275BF0-0x0000000182275EF0
	// [XID] // 0x0000000189A8A9F0-0x0000000189A8AA10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3A1 */, bool useObjectPool = false /* Metadata: 0x00AFB3A5 */) => default; // 0x0000000182274D00-0x00000001822750A0
	// [XID] // 0x0000000189A922F0-0x0000000189A92310
	public static new ConfigAirflowField ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3A6 */, bool useObjectPool = false /* Metadata: 0x00AFB3AA */) => default; // 0x0000000182275520-0x0000000182275740
	[BlackList] // 0x0000000189A99C40-0x0000000189A99C80
	// [XID] // 0x0000000189A99C40-0x0000000189A99C80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001822745D0-0x00000001822748A0
	// [XID] // 0x0000000189AA3FC0-0x0000000189AA3FE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182276680-0x0000000182276A20
	[BlackList] // 0x0000000189AAB4F0-0x0000000189AAB530
	// [XID] // 0x0000000189AAB4F0-0x0000000189AAB530
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182275A50-0x0000000182275B40
	[BlackList] // 0x0000000189AB5EC0-0x0000000189AB5F00
	// [XID] // 0x0000000189AB5EC0-0x0000000189AB5F00
	public override void AutoAllocTypeFields() {} // 0x00000001822748A0-0x0000000182274940
	[BlackList] // 0x0000000189AC0830-0x0000000189AC0870
	// [XID] // 0x0000000189AC0830-0x0000000189AC0870
	public override void AutoRecycleTypeFields() {} // 0x0000000182274940-0x0000000182274A30
	[BlackList] // 0x0000000189ACB200-0x0000000189ACB240
	// [XID] // 0x0000000189ACB200-0x0000000189ACB240
	public override void ReturnToObjectPool() {} // 0x0000000182276D00-0x0000000182276DA0
}

