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
public class ConfigRuleLimitFrameGlobal : ConfigAudioEventCullingRuleBase, IAutoAllocRecycle // TypeDefIndex: 17577
{
	// Fields
	private SimpleSafeInt32 limitFrameRawNum; // 0x10

	// Properties
	public int limitFrame { /* [XID] */ /* 0x00000001897DBEC0-0x00000001897DBEE0 */ get => default; /* [XID] */ /* 0x00000001899957D0-0x00000001899957F0 */ private set {} } // 0x00000001820962C0-0x0000000182096390 0x0000000182096410-0x00000001820964F0

	// Constructors
	public ConfigRuleLimitFrameGlobal() {} // 0x0000000182097900-0x0000000182097960

	// Methods
	// [XID] // 0x000000018999D170-0x000000018999D190
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182097770-0x0000000182097860
	// [XID] // 0x00000001899A4B50-0x00000001899A4B70
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182097490-0x0000000182097540
	// [XID] // 0x00000001899AC5D0-0x00000001899AC5F0
	public override ConfigAudioEventCullingRuleBase Clone(bool useObjectPool = false /* Metadata: 0x00AF737B */) => default; // 0x00000001820970A0-0x0000000182097180
	// [XID] // 0x00000001899B3D80-0x00000001899B3DA0
	public override int GetHashNum() => default; // 0x0000000182095E20-0x0000000182095EF0
	// [XID] // 0x00000001899BB190-0x00000001899BB1B0
	public override void InitEmpty() {} // 0x0000000182096B00-0x0000000182096BD0
	[BlackList] // 0x00000001899C2C20-0x00000001899C2C60
	// [XID] // 0x00000001899C2C20-0x00000001899C2C60
	public override bool FromJson(JSONNode node) => default; // 0x00000001820964F0-0x0000000182096870
	// [XID] // 0x00000001899CD330-0x00000001899CD350
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182095650-0x00000001820958B0
	[BlackList] // 0x00000001899D47D0-0x00000001899D4810
	// [XID] // 0x00000001899D47D0-0x00000001899D4810
	public static new ConfigRuleLimitFrameGlobal ParseFromJson(JSONNode node) => default; // 0x00000001820971E0-0x0000000182097430
	// [XID] // 0x00000001899DEC30-0x00000001899DEC50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF737C */, bool useObjectPool = false /* Metadata: 0x00AF7380 */) => default; // 0x0000000182096DA0-0x00000001820970A0
	// [XID] // 0x00000001899E6830-0x00000001899E6850
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7381 */, bool useObjectPool = false /* Metadata: 0x00AF7385 */) => default; // 0x0000000182095FD0-0x0000000182096240
	// [XID] // 0x00000001899EDE60-0x00000001899EDE80
	public static new ConfigRuleLimitFrameGlobal ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7386 */, bool useObjectPool = false /* Metadata: 0x00AF738A */) => default; // 0x0000000182096870-0x0000000182096A90
	[BlackList] // 0x00000001899F56B0-0x00000001899F56F0
	// [XID] // 0x00000001899F56B0-0x00000001899F56F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001820958B0-0x0000000182095B80
	// [XID] // 0x00000001899FFB80-0x00000001899FFBA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182097540-0x0000000182097770
	[BlackList] // 0x0000000189A073D0-0x0000000189A07410
	// [XID] // 0x0000000189A073D0-0x0000000189A07410
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182096CB0-0x0000000182096DA0
	[BlackList] // 0x0000000189A11BC0-0x0000000189A11C00
	// [XID] // 0x0000000189A11BC0-0x0000000189A11C00
	public override void AutoAllocTypeFields() {} // 0x0000000182095B80-0x0000000182095C20
	[BlackList] // 0x0000000189A1BD50-0x0000000189A1BD90
	// [XID] // 0x0000000189A1BD50-0x0000000189A1BD90
	public override void AutoRecycleTypeFields() {} // 0x0000000182095C20-0x0000000182095D00
	[BlackList] // 0x0000000189A26360-0x0000000189A263A0
	// [XID] // 0x0000000189A26360-0x0000000189A263A0
	public override void ReturnToObjectPool() {} // 0x0000000182097860-0x0000000182097900
}

