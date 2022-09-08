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
public class ConfigLocalEntity : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 18928
{
	// Fields
	private SimpleSafeFloat checkDistRawNum; // 0x60
	private bool _withGO; // 0x64

	// Properties
	public float checkDist { /* [XID] */ /* 0x0000000189837D00-0x0000000189837D20 */ get => default; /* [XID] */ /* 0x000000018983F470-0x000000018983F490 */ private set {} } // 0x0000000184973A10-0x0000000184973AF0 0x0000000184972870-0x0000000184972950
	public bool withGO { /* [XID] */ /* 0x0000000189846B30-0x0000000189846B50 */ get => default; /* [XID] */ /* 0x000000018984E1A0-0x000000018984E1C0 */ private set {} } // 0x0000000184972B70-0x0000000184972C10 0x0000000184973230-0x00000001849732E0

	// Constructors
	public ConfigLocalEntity() {} // 0x0000000184973CA0-0x0000000184973D40

	// Methods
	// [XID] // 0x0000000189855250-0x0000000189855270
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184973AF0-0x0000000184973C00
	// [XID] // 0x000000018985C910-0x000000018985C930
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001849736D0-0x0000000184973780
	// [XID] // 0x00000001898641D0-0x00000001898641F0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AFB3EB */) => default; // 0x00000001849732E0-0x00000001849733C0
	// [XID] // 0x000000018986B680-0x000000018986B6A0
	public override int GetHashNum() => default; // 0x0000000184971FA0-0x0000000184972070
	// [XID] // 0x00000001898729D0-0x00000001898729F0
	public override void InitEmpty() {} // 0x0000000184972C80-0x0000000184972D60
	[BlackList] // 0x000000018987A630-0x000000018987A670
	// [XID] // 0x000000018987A630-0x000000018987A670
	public override bool FromJson(JSONNode node) => default; // 0x00000001849724F0-0x0000000184972870
	// [XID] // 0x0000000189884490-0x00000001898844B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184971720-0x0000000184971A30
	[BlackList] // 0x000000018988BBA0-0x000000018988BBE0
	// [XID] // 0x000000018988BBA0-0x000000018988BBE0
	public static new ConfigLocalEntity ParseFromJson(JSONNode node) => default; // 0x0000000184973420-0x0000000184973670
	// [XID] // 0x0000000189895DE0-0x0000000189895E00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3EC */, bool useObjectPool = false /* Metadata: 0x00AFB3F0 */) => default; // 0x0000000184972F30-0x0000000184973230
	// [XID] // 0x000000018989D420-0x000000018989D440
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3F1 */, bool useObjectPool = false /* Metadata: 0x00AFB3F5 */) => default; // 0x0000000184972150-0x00000001849723F0
	// [XID] // 0x00000001898A4E20-0x00000001898A4E40
	public static new ConfigLocalEntity ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3F6 */, bool useObjectPool = false /* Metadata: 0x00AFB3FA */) => default; // 0x0000000184972950-0x0000000184972B70
	[BlackList] // 0x00000001898AC280-0x00000001898AC2C0
	// [XID] // 0x00000001898AC280-0x00000001898AC2C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184971A30-0x0000000184971D00
	// [XID] // 0x00000001898B6A70-0x00000001898B6A90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184973780-0x0000000184973A10
	[BlackList] // 0x00000001898BE200-0x00000001898BE240
	// [XID] // 0x00000001898BE200-0x00000001898BE240
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184972E40-0x0000000184972F30
	[BlackList] // 0x00000001898C8C40-0x00000001898C8C80
	// [XID] // 0x00000001898C8C40-0x00000001898C8C80
	public override void AutoAllocTypeFields() {} // 0x0000000184971D00-0x0000000184971DA0
	[BlackList] // 0x00000001898D31D0-0x00000001898D3210
	// [XID] // 0x00000001898D31D0-0x00000001898D3210
	public override void AutoRecycleTypeFields() {} // 0x0000000184971DA0-0x0000000184971E80
	[BlackList] // 0x00000001898DE060-0x00000001898DE0A0
	// [XID] // 0x00000001898DE060-0x00000001898DE0A0
	public override void ReturnToObjectPool() {} // 0x0000000184973C00-0x0000000184973CA0
}

