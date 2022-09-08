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
public class ConfigRuleLimitFrame : ConfigAudioEventCullingRuleBase, IAutoAllocRecycle // TypeDefIndex: 17579
{
	// Fields
	private SimpleSafeInt32 limitFrameRawNum; // 0x10

	// Properties
	public int limitFrame { /* [XID] */ /* 0x0000000189A38130-0x0000000189A38150 */ get => default; /* [XID] */ /* 0x0000000189A3F860-0x0000000189A3F880 */ private set {} } // 0x0000000181734CC0-0x0000000181734D90 0x0000000181734E10-0x0000000181734EF0

	// Constructors
	public ConfigRuleLimitFrame() {} // 0x0000000181736300-0x0000000181736360

	// Methods
	// [XID] // 0x0000000189A46F10-0x0000000189A46F30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181736170-0x0000000181736260
	// [XID] // 0x0000000189A4E830-0x0000000189A4E850
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181735E90-0x0000000181735F40
	// [XID] // 0x0000000189A55F40-0x0000000189A55F60
	public override ConfigAudioEventCullingRuleBase Clone(bool useObjectPool = false /* Metadata: 0x00AF738B */) => default; // 0x0000000181735AA0-0x0000000181735B80
	// [XID] // 0x0000000189A5D9E0-0x0000000189A5DA00
	public override int GetHashNum() => default; // 0x0000000181734820-0x00000001817348F0
	// [XID] // 0x0000000189A65120-0x0000000189A65140
	public override void InitEmpty() {} // 0x0000000181735500-0x00000001817355D0
	[BlackList] // 0x0000000189A6C8C0-0x0000000189A6C900
	// [XID] // 0x0000000189A6C8C0-0x0000000189A6C900
	public override bool FromJson(JSONNode node) => default; // 0x0000000181734EF0-0x0000000181735270
	// [XID] // 0x0000000189A77090-0x0000000189A770B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181734050-0x00000001817342B0
	[BlackList] // 0x0000000189A7EAA0-0x0000000189A7EAE0
	// [XID] // 0x0000000189A7EAA0-0x0000000189A7EAE0
	public static new ConfigRuleLimitFrame ParseFromJson(JSONNode node) => default; // 0x0000000181735BE0-0x0000000181735E30
	// [XID] // 0x0000000189A895B0-0x0000000189A895D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF738C */, bool useObjectPool = false /* Metadata: 0x00AF7390 */) => default; // 0x00000001817357A0-0x0000000181735AA0
	// [XID] // 0x0000000189A90DB0-0x0000000189A90DD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7391 */, bool useObjectPool = false /* Metadata: 0x00AF7395 */) => default; // 0x00000001817349D0-0x0000000181734C40
	// [XID] // 0x0000000189A98580-0x0000000189A985A0
	public static new ConfigRuleLimitFrame ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7396 */, bool useObjectPool = false /* Metadata: 0x00AF739A */) => default; // 0x0000000181735270-0x0000000181735490
	[BlackList] // 0x0000000189A9F970-0x0000000189A9F9B0
	// [XID] // 0x0000000189A9F970-0x0000000189A9F9B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001817342B0-0x0000000181734580
	// [XID] // 0x0000000189AA9DC0-0x0000000189AA9DE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181735F40-0x0000000181736170
	[BlackList] // 0x0000000189AB1CC0-0x0000000189AB1D00
	// [XID] // 0x0000000189AB1CC0-0x0000000189AB1D00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001817356B0-0x00000001817357A0
	[BlackList] // 0x0000000189ABC660-0x0000000189ABC6A0
	// [XID] // 0x0000000189ABC660-0x0000000189ABC6A0
	public override void AutoAllocTypeFields() {} // 0x0000000181734580-0x0000000181734620
	[BlackList] // 0x0000000189AC6D00-0x0000000189AC6D40
	// [XID] // 0x0000000189AC6D00-0x0000000189AC6D40
	public override void AutoRecycleTypeFields() {} // 0x0000000181734620-0x0000000181734700
	[BlackList] // 0x0000000189AD1570-0x0000000189AD15B0
	// [XID] // 0x0000000189AD1570-0x0000000189AD15B0
	public override void ReturnToObjectPool() {} // 0x0000000181736260-0x0000000181736300
}

