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
public class ConfigVCustomMapMark : ConfigVMapMark, IAutoAllocRecycle // TypeDefIndex: 18559
{
	// Fields
	private MarkCustomType _customType; // 0x30

	// Properties
	public MarkCustomType customType { /* [XID] */ /* 0x000000018965C6E0-0x000000018965C700 */ get => default; /* [XID] */ /* 0x0000000189663CA0-0x0000000189663CC0 */ private set {} } // 0x0000000181BEE2C0-0x0000000181BEE360 0x0000000181BECBE0-0x0000000181BECC90

	// Constructors
	public ConfigVCustomMapMark() {} // 0x0000000181BEE4F0-0x0000000181BEE550

	// Methods
	// [XID] // 0x000000018966B4A0-0x000000018966B4C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181BEE360-0x0000000181BEE450
	// [XID] // 0x00000001896731A0-0x00000001896731C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181BEE010-0x0000000181BEE0C0
	// [XID] // 0x000000018967A7C0-0x000000018967A7E0
	public override ConfigVBaseMark Clone(bool useObjectPool = false /* Metadata: 0x00AFA3E1 */) => default; // 0x0000000181BEDC20-0x0000000181BEDD00
	// [XID] // 0x00000001896820B0-0x00000001896820D0
	public override int GetHashNum() => default; // 0x0000000181BECB10-0x0000000181BECBE0
	// [XID] // 0x0000000189689A90-0x0000000189689AB0
	public override void InitEmpty() {} // 0x0000000181BED6B0-0x0000000181BED750
	[BlackList] // 0x0000000189691890-0x00000001896918D0
	// [XID] // 0x0000000189691890-0x00000001896918D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181BED0A0-0x0000000181BED420
	// [XID] // 0x000000018969BC60-0x000000018969BC80
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181BEC3B0-0x0000000181BEC5D0
	[BlackList] // 0x00000001896A3200-0x00000001896A3240
	// [XID] // 0x00000001896A3200-0x00000001896A3240
	public static new ConfigVCustomMapMark ParseFromJson(JSONNode node) => default; // 0x0000000181BEDD60-0x0000000181BEDFB0
	// [XID] // 0x00000001896AD410-0x00000001896AD430
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3E2 */, bool useObjectPool = false /* Metadata: 0x00AFA3E6 */) => default; // 0x0000000181BED920-0x0000000181BEDC20
	// [XID] // 0x00000001896B4B90-0x00000001896B4BB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3E7 */, bool useObjectPool = false /* Metadata: 0x00AFA3EB */) => default; // 0x0000000181BECD70-0x0000000181BECFA0
	// [XID] // 0x00000001896BBF40-0x00000001896BBF60
	public static new ConfigVCustomMapMark ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3EC */, bool useObjectPool = false /* Metadata: 0x00AFA3F0 */) => default; // 0x0000000181BED420-0x0000000181BED640
	[BlackList] // 0x00000001896C33C0-0x00000001896C3400
	// [XID] // 0x00000001896C33C0-0x00000001896C3400
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181BEC5D0-0x0000000181BEC8A0
	// [XID] // 0x00000001896CDAF0-0x00000001896CDB10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181BEE0C0-0x0000000181BEE2C0
	[BlackList] // 0x00000001896D5060-0x00000001896D50A0
	// [XID] // 0x00000001896D5060-0x00000001896D50A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181BED830-0x0000000181BED920
	[BlackList] // 0x00000001896DF860-0x00000001896DF8A0
	// [XID] // 0x00000001896DF860-0x00000001896DF8A0
	public override void AutoAllocTypeFields() {} // 0x0000000181BEC8A0-0x0000000181BEC940
	[BlackList] // 0x00000001896E9D40-0x00000001896E9D80
	// [XID] // 0x00000001896E9D40-0x00000001896E9D80
	public override void AutoRecycleTypeFields() {} // 0x0000000181BEC940-0x0000000181BEC9F0
	[BlackList] // 0x00000001896F4260-0x00000001896F42A0
	// [XID] // 0x00000001896F4260-0x00000001896F42A0
	public override void ReturnToObjectPool() {} // 0x0000000181BEE450-0x0000000181BEE4F0
}

