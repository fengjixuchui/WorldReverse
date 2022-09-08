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
public class TemplateParamFloat : TemplateParam, IAutoAllocRecycle // TypeDefIndex: 18995
{
	// Fields
	private SimpleSafeFloat originValueRawNum; // 0x18

	// Properties
	public float originValue { /* [XID] */ /* 0x000000018960CFA0-0x000000018960CFC0 */ get => default; /* [XID] */ /* 0x0000000189614600-0x0000000189614620 */ private set {} } // 0x0000000182A5A4E0-0x0000000182A5A5C0 0x0000000182A59DF0-0x0000000182A59ED0

	// Constructors
	public TemplateParamFloat() {} // 0x0000000182A5ADF0-0x0000000182A5AE50

	// Methods
	// [XID] // 0x000000018961BF10-0x000000018961BF30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A5AC50-0x0000000182A5AD50
	// [XID] // 0x00000001896234A0-0x00000001896234C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182A5A9B0-0x0000000182A5AA60
	// [XID] // 0x000000018962ACE0-0x000000018962AD00
	public override TemplateParam Clone(bool useObjectPool = false /* Metadata: 0x00AFB6AF */) => default; // 0x0000000182A5A5C0-0x0000000182A5A6A0
	// [XID] // 0x0000000189632480-0x00000001896324A0
	public override int GetHashNum() => default; // 0x0000000182A59330-0x0000000182A59400
	// [XID] // 0x0000000189639F10-0x0000000189639F30
	public override void InitEmpty() {} // 0x0000000182A59F40-0x0000000182A5A010
	[BlackList] // 0x0000000189641400-0x0000000189641440
	// [XID] // 0x0000000189641400-0x0000000189641440
	public override bool FromJson(JSONNode node) => default; // 0x0000000182A59850-0x0000000182A59BD0
	// [XID] // 0x000000018964BE90-0x000000018964BEB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182A58B50-0x0000000182A58DC0
	[BlackList] // 0x0000000189653500-0x0000000189653540
	// [XID] // 0x0000000189653500-0x0000000189653540
	public static new TemplateParamFloat ParseFromJson(JSONNode node) => default; // 0x0000000182A5A700-0x0000000182A5A950
	// [XID] // 0x000000018965DC70-0x000000018965DC90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6B0 */, bool useObjectPool = false /* Metadata: 0x00AFB6B4 */) => default; // 0x0000000182A5A1E0-0x0000000182A5A4E0
	// [XID] // 0x00000001896652F0-0x0000000189665310
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6B5 */, bool useObjectPool = false /* Metadata: 0x00AFB6B9 */) => default; // 0x0000000182A594E0-0x0000000182A59750
	// [XID] // 0x000000018966CAE0-0x000000018966CB00
	public static new TemplateParamFloat ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6BA */, bool useObjectPool = false /* Metadata: 0x00AFB6BE */) => default; // 0x0000000182A59BD0-0x0000000182A59DF0
	[BlackList] // 0x0000000189674890-0x00000001896748D0
	// [XID] // 0x0000000189674890-0x00000001896748D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A58DC0-0x0000000182A59090
	// [XID] // 0x000000018967EE60-0x000000018967EE80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A5AA60-0x0000000182A5AC50
	[BlackList] // 0x00000001896867D0-0x0000000189686810
	// [XID] // 0x00000001896867D0-0x0000000189686810
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182A5A0F0-0x0000000182A5A1E0
	[BlackList] // 0x0000000189691830-0x0000000189691870
	// [XID] // 0x0000000189691830-0x0000000189691870
	public override void AutoAllocTypeFields() {} // 0x0000000182A59090-0x0000000182A59130
	[BlackList] // 0x000000018969BBE0-0x000000018969BC20
	// [XID] // 0x000000018969BBE0-0x000000018969BC20
	public override void AutoRecycleTypeFields() {} // 0x0000000182A59130-0x0000000182A59210
	[BlackList] // 0x00000001896A5F10-0x00000001896A5F50
	// [XID] // 0x00000001896A5F10-0x00000001896A5F50
	public override void ReturnToObjectPool() {} // 0x0000000182A5AD50-0x0000000182A5ADF0
}

