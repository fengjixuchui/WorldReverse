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
public class ConfigDirectionByAttachPoint : ConfigBornDirectionType, IAutoAllocRecycle // TypeDefIndex: 17838
{
	// Fields
	private string _attachPointName; // 0x38
	private AttachPointTargetType _attachPointTargetType; // 0x40

	// Properties
	public string attachPointName { /* [XID] */ /* 0x0000000189734DD0-0x0000000189734DF0 */ get => default; /* [XID] */ /* 0x0000000189605830-0x0000000189605850 */ private set {} } // 0x0000000183E21AE0-0x0000000183E21B80 0x0000000183E21B80-0x0000000183E21C30
	public AttachPointTargetType attachPointTargetType { /* [XID] */ /* 0x000000018988C900-0x000000018988C920 */ get => default; /* [XID] */ /* 0x0000000189614880-0x00000001896148A0 */ private set {} } // 0x0000000183E236A0-0x0000000183E23740 0x0000000183E23DC0-0x0000000183E23E70

	// Constructors
	public ConfigDirectionByAttachPoint() {} // 0x0000000183E24020-0x0000000183E24080

	// Methods
	// [XID] // 0x000000018961C1C0-0x000000018961C1E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E23E70-0x0000000183E23F80
	// [XID] // 0x0000000189623600-0x0000000189623620
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183E23A50-0x0000000183E23B30
	// [XID] // 0x000000018962AF40-0x000000018962AF60
	public override ConfigBornDirectionType Clone(bool useObjectPool = false /* Metadata: 0x00AF7E99 */) => default; // 0x0000000183E235C0-0x0000000183E236A0
	// [XID] // 0x0000000189632680-0x00000001896326A0
	public override int GetHashNum() => default; // 0x0000000183E22480-0x0000000183E22550
	// [XID] // 0x000000018963A150-0x000000018963A170
	public override void InitEmpty() {} // 0x0000000183E23020-0x0000000183E230F0
	[BlackList] // 0x0000000189641700-0x0000000189641740
	// [XID] // 0x0000000189641700-0x0000000189641740
	public override bool FromJson(JSONNode node) => default; // 0x0000000183E22A10-0x0000000183E22D90
	// [XID] // 0x000000018964C070-0x000000018964C090
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183E21C30-0x0000000183E21F40
	[BlackList] // 0x0000000189653680-0x00000001896536C0
	// [XID] // 0x0000000189653680-0x00000001896536C0
	public static new ConfigDirectionByAttachPoint ParseFromJson(JSONNode node) => default; // 0x0000000183E237A0-0x0000000183E239F0
	// [XID] // 0x000000018965DD70-0x000000018965DD90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E9A */, bool useObjectPool = false /* Metadata: 0x00AF7E9E */) => default; // 0x0000000183E232C0-0x0000000183E235C0
	// [XID] // 0x00000001896654D0-0x00000001896654F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E9F */, bool useObjectPool = false /* Metadata: 0x00AF7EA3 */) => default; // 0x0000000183E22630-0x0000000183E22910
	// [XID] // 0x000000018966CBC0-0x000000018966CBE0
	public static new ConfigDirectionByAttachPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7EA4 */, bool useObjectPool = false /* Metadata: 0x00AF7EA8 */) => default; // 0x0000000183E22D90-0x0000000183E22FB0
	[BlackList] // 0x0000000189674A10-0x0000000189674A50
	// [XID] // 0x0000000189674A10-0x0000000189674A50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E21F40-0x0000000183E22210
	// [XID] // 0x000000018967F080-0x000000018967F0A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E23B30-0x0000000183E23DC0
	[BlackList] // 0x0000000189686990-0x00000001896869D0
	// [XID] // 0x0000000189686990-0x00000001896869D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183E231D0-0x0000000183E232C0
	[BlackList] // 0x00000001896919F0-0x0000000189691A30
	// [XID] // 0x00000001896919F0-0x0000000189691A30
	public override void AutoAllocTypeFields() {} // 0x0000000183E22210-0x0000000183E222B0
	[BlackList] // 0x000000018969BDA0-0x000000018969BDE0
	// [XID] // 0x000000018969BDA0-0x000000018969BDE0
	public override void AutoRecycleTypeFields() {} // 0x0000000183E222B0-0x0000000183E22360
	[BlackList] // 0x00000001896A6050-0x00000001896A6090
	// [XID] // 0x00000001896A6050-0x00000001896A6090
	public override void ReturnToObjectPool() {} // 0x0000000183E23F80-0x0000000183E24020
}

