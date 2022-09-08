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
public class TemplateParamString : TemplateParam, IAutoAllocRecycle // TypeDefIndex: 18999
{
	// Fields
	private string _originValue; // 0x18

	// Properties
	public string originValue { /* [XID] */ /* 0x0000000189761250-0x0000000189761270 */ get => default; /* [XID] */ /* 0x00000001897685A0-0x00000001897685C0 */ private set {} } // 0x0000000181D1BBB0-0x0000000181D1BC50 0x0000000181D1B4F0-0x0000000181D1B5A0

	// Constructors
	public TemplateParamString() {} // 0x0000000181D1C4B0-0x0000000181D1C510

	// Methods
	// [XID] // 0x000000018976FC50-0x000000018976FC70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181D1C320-0x0000000181D1C410
	// [XID] // 0x0000000189777430-0x0000000189777450
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181D1C040-0x0000000181D1C120
	// [XID] // 0x000000018977EBE0-0x000000018977EC00
	public override TemplateParam Clone(bool useObjectPool = false /* Metadata: 0x00AFB6CF */) => default; // 0x0000000181D1BC50-0x0000000181D1BD30
	// [XID] // 0x00000001897864C0-0x00000001897864E0
	public override int GetHashNum() => default; // 0x0000000181D1AA30-0x0000000181D1AB00
	// [XID] // 0x000000018978DB30-0x000000018978DB50
	public override void InitEmpty() {} // 0x0000000181D1B610-0x0000000181D1B6E0
	[BlackList] // 0x00000001897950A0-0x00000001897950E0
	// [XID] // 0x00000001897950A0-0x00000001897950E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181D1AF50-0x0000000181D1B2D0
	// [XID] // 0x00000001897A0170-0x00000001897A0190
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181D1A2C0-0x0000000181D1A4F0
	[BlackList] // 0x00000001897A76E0-0x00000001897A7720
	// [XID] // 0x00000001897A76E0-0x00000001897A7720
	public static new TemplateParamString ParseFromJson(JSONNode node) => default; // 0x0000000181D1BD90-0x0000000181D1BFE0
	// [XID] // 0x00000001897B1F90-0x00000001897B1FB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6D0 */, bool useObjectPool = false /* Metadata: 0x00AFB6D4 */) => default; // 0x0000000181D1B8B0-0x0000000181D1BBB0
	// [XID] // 0x00000001897B99D0-0x00000001897B99F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6D5 */, bool useObjectPool = false /* Metadata: 0x00AFB6D9 */) => default; // 0x0000000181D1ABE0-0x0000000181D1AE50
	// [XID] // 0x00000001897C1A50-0x00000001897C1A70
	public static new TemplateParamString ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6DA */, bool useObjectPool = false /* Metadata: 0x00AFB6DE */) => default; // 0x0000000181D1B2D0-0x0000000181D1B4F0
	[BlackList] // 0x00000001897C9440-0x00000001897C9480
	// [XID] // 0x00000001897C9440-0x00000001897C9480
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181D1A4F0-0x0000000181D1A7C0
	// [XID] // 0x00000001897D3920-0x00000001897D3940
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181D1C120-0x0000000181D1C320
	[BlackList] // 0x00000001897DB330-0x00000001897DB370
	// [XID] // 0x00000001897DB330-0x00000001897DB370
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181D1B7C0-0x0000000181D1B8B0
	[BlackList] // 0x00000001897E5B10-0x00000001897E5B50
	// [XID] // 0x00000001897E5B10-0x00000001897E5B50
	public override void AutoAllocTypeFields() {} // 0x0000000181D1A7C0-0x0000000181D1A860
	[BlackList] // 0x00000001897F06C0-0x00000001897F0700
	// [XID] // 0x00000001897F06C0-0x00000001897F0700
	public override void AutoRecycleTypeFields() {} // 0x0000000181D1A860-0x0000000181D1A910
	[BlackList] // 0x00000001897FB0F0-0x00000001897FB130
	// [XID] // 0x00000001897FB0F0-0x00000001897FB130
	public override void ReturnToObjectPool() {} // 0x0000000181D1C410-0x0000000181D1C4B0
}

