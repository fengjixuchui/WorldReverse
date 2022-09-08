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
public class TemplateParamInt32 : TemplateParam, IAutoAllocRecycle // TypeDefIndex: 18997
{
	// Fields
	private SimpleSafeInt32 originValueRawNum; // 0x18

	// Properties
	public int originValue { /* [XID] */ /* 0x00000001896B7A30-0x00000001896B7A50 */ get => default; /* [XID] */ /* 0x00000001896BEA90-0x00000001896BEAB0 */ private set {} } // 0x0000000182060950-0x0000000182060A20 0x0000000182060260-0x0000000182060340

	// Constructors
	public TemplateParamInt32() {} // 0x0000000182061280-0x00000001820612E0

	// Methods
	// [XID] // 0x00000001896C6450-0x00000001896C6470
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820610F0-0x00000001820611E0
	// [XID] // 0x00000001896CDA70-0x00000001896CDA90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182060E10-0x0000000182060EC0
	// [XID] // 0x00000001896D4FC0-0x00000001896D4FE0
	public override TemplateParam Clone(bool useObjectPool = false /* Metadata: 0x00AFB6BF */) => default; // 0x0000000182060A20-0x0000000182060B00
	// [XID] // 0x00000001896DC640-0x00000001896DC660
	public override int GetHashNum() => default; // 0x000000018205F7A0-0x000000018205F870
	// [XID] // 0x00000001896E3EB0-0x00000001896E3ED0
	public override void InitEmpty() {} // 0x00000001820603B0-0x0000000182060480
	[BlackList] // 0x00000001896EB280-0x00000001896EB2C0
	// [XID] // 0x00000001896EB280-0x00000001896EB2C0
	public override bool FromJson(JSONNode node) => default; // 0x000000018205FCC0-0x0000000182060040
	// [XID] // 0x00000001896F59A0-0x00000001896F59C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018205EFD0-0x000000018205F230
	[BlackList] // 0x00000001896FD150-0x00000001896FD190
	// [XID] // 0x00000001896FD150-0x00000001896FD190
	public static new TemplateParamInt32 ParseFromJson(JSONNode node) => default; // 0x0000000182060B60-0x0000000182060DB0
	// [XID] // 0x00000001897076B0-0x00000001897076D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6C0 */, bool useObjectPool = false /* Metadata: 0x00AFB6C4 */) => default; // 0x0000000182060650-0x0000000182060950
	// [XID] // 0x000000018970F0C0-0x000000018970F0E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6C5 */, bool useObjectPool = false /* Metadata: 0x00AFB6C9 */) => default; // 0x000000018205F950-0x000000018205FBC0
	// [XID] // 0x00000001897164C0-0x00000001897164E0
	public static new TemplateParamInt32 ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6CA */, bool useObjectPool = false /* Metadata: 0x00AFB6CE */) => default; // 0x0000000182060040-0x0000000182060260
	[BlackList] // 0x000000018971DEC0-0x000000018971DF00
	// [XID] // 0x000000018971DEC0-0x000000018971DF00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018205F230-0x000000018205F500
	// [XID] // 0x0000000189728350-0x0000000189728370
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182060EC0-0x00000001820610F0
	[BlackList] // 0x000000018972FAB0-0x000000018972FAF0
	// [XID] // 0x000000018972FAB0-0x000000018972FAF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182060560-0x0000000182060650
	[BlackList] // 0x000000018973A0B0-0x000000018973A0F0
	// [XID] // 0x000000018973A0B0-0x000000018973A0F0
	public override void AutoAllocTypeFields() {} // 0x000000018205F500-0x000000018205F5A0
	[BlackList] // 0x0000000189744870-0x00000001897448B0
	// [XID] // 0x0000000189744870-0x00000001897448B0
	public override void AutoRecycleTypeFields() {} // 0x000000018205F5A0-0x000000018205F680
	[BlackList] // 0x000000018974F290-0x000000018974F2D0
	// [XID] // 0x000000018974F290-0x000000018974F2D0
	public override void ReturnToObjectPool() {} // 0x00000001820611E0-0x0000000182061280
}

