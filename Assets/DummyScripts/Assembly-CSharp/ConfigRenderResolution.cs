/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct ConfigRenderResolution : IEmptyInitable, IHashable // TypeDefIndex: 18171
{
	// Fields
	private SimpleSafeInt32 widthRawNum; // 0x00
	private SimpleSafeInt32 heightRawNum; // 0x04
	private SimpleSafeInt32 secondWidthRawNum; // 0x08
	private SimpleSafeInt32 secondHeightRawNum; // 0x0C
	private SimpleSafeFloat perfCostRatioRawNum; // 0x10

	// Properties
	public int width { /* [XID] */ /* 0x00000001896850A0-0x00000001896850C0 */ get => default; /* [XID] */ /* 0x000000018968CBA0-0x000000018968CBC0 */ set {} } // 0x00000001841E5E40-0x00000001841E5F30 0x00000001841E4FB0-0x00000001841E5050
	public int height { /* [XID] */ /* 0x0000000189694700-0x0000000189694720 */ get => default; /* [XID] */ /* 0x000000018969BD20-0x000000018969BD40 */ set {} } // 0x00000001841E6B40-0x00000001841E6C40 0x00000001841E6420-0x00000001841E65A0
	public int secondWidth { /* [XID] */ /* 0x00000001896A32C0-0x00000001896A32E0 */ get => default; /* [XID] */ /* 0x00000001896AA710-0x00000001896AA730 */ set {} } // 0x00000001841E4BF0-0x00000001841E4ED0 0x00000001841E5F30-0x00000001841E6020
	public int secondHeight { /* [XID] */ /* 0x00000001896B1790-0x00000001896B17B0 */ get => default; /* [XID] */ /* 0x00000001896B9170-0x00000001896B9190 */ set {} } // 0x00000001841E55E0-0x00000001841E5700 0x00000001841E6020-0x00000001841E6330
	public float perfCostRatio { /* [XID] */ /* 0x00000001896C0580-0x00000001896C05A0 */ get => default; /* [XID] */ /* 0x00000001896C7CB0-0x00000001896C7CD0 */ private set {} } // 0x00000001841E6D30-0x00000001841E6E20 0x00000001841E6E20-0x00000001841E6E30

	// Methods
	// [IDTag] // 0x00000001896CF670-0x00000001896CF6B0
	// [XID] // 0x00000001896CF670-0x00000001896CF6B0
	public bool Equals(ConfigRenderResolution otherVal) => default; // 0x00000001841E65A0-0x00000001841E6A60
	// [IDTag] // 0x00000001896D9950-0x00000001896D9990
	// [XID] // 0x00000001896D9950-0x00000001896D9990
	public override bool Equals(object other) => default; // 0x00000001841E5700-0x00000001841E5A90
	// [XID] // 0x00000001896E3F90-0x00000001896E3FB0
	public override int GetHashCode() => default; // 0x00000001841E5B70-0x00000001841E5C30
	// [XID] // 0x00000001896EB460-0x00000001896EB480
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841E6C40-0x00000001841E6D30
	// [XID] // 0x00000001896F2750-0x00000001896F2770
	public void InitEmpty() {} // 0x00000001841E5D60-0x00000001841E5E40
	[BlackList] // 0x00000001896FA0B0-0x00000001896FA0F0
	// [XID] // 0x00000001896FA0B0-0x00000001896FA0F0
	public bool FromJson(JSONNode node) => default; // 0x00000001841E5A90-0x00000001841E5B70
	// [XID] // 0x0000000189704790-0x00000001897047B0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001841E4B10-0x00000001841E4BF0
	// [XID] // 0x000000018970BFB0-0x000000018970BFD0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DC1 */, bool useObjectPool = false /* Metadata: 0x00AF8DC5 */) => default; // 0x00000001841E6330-0x00000001841E6420
	// [XID] // 0x0000000189713860-0x0000000189713880
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DC6 */, bool useObjectPool = false /* Metadata: 0x00AF8DCA */) => default; // 0x00000001841E5500-0x00000001841E55E0
	[BlackList] // 0x000000018971B100-0x000000018971B140
	// [XID] // 0x000000018971B100-0x000000018971B140
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001841E4ED0-0x00000001841E4FB0
	// [XID] // 0x0000000189725540-0x0000000189725560
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841E6A60-0x00000001841E6B40
}

