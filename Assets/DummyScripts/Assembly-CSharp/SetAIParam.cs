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
public class SetAIParam : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16468
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicString _param; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x70
	private bool _isBool; // 0x78
	private ParamLogicType _logicType; // 0x7C

	// Properties
	public DynamicString param { /* [XID] */ /* 0x00000001898526C0-0x00000001898526E0 */ get => default; /* [XID] */ /* 0x000000018985A150-0x000000018985A170 */ private set {} } // 0x0000000183CC8100-0x0000000183CC81A0 0x0000000183CC8050-0x0000000183CC8100
	public DynamicFloat value { /* [XID] */ /* 0x00000001898612B0-0x00000001898612D0 */ get => default; /* [XID] */ /* 0x0000000189868A10-0x0000000189868A30 */ private set {} } // 0x0000000183CC67B0-0x0000000183CC6850 0x0000000183CC6680-0x0000000183CC6730
	public bool isBool { /* [XID] */ /* 0x000000018986FEE0-0x000000018986FF00 */ get => default; /* [XID] */ /* 0x00000001898775F0-0x0000000189877610 */ private set {} } // 0x0000000183CC65E0-0x0000000183CC6680 0x0000000183CC7120-0x0000000183CC71D0
	public ParamLogicType logicType { /* [XID] */ /* 0x000000018987EE80-0x000000018987EEA0 */ get => default; /* [XID] */ /* 0x0000000189886480-0x00000001898864A0 */ private set {} } // 0x0000000183CC7E40-0x0000000183CC7EE0 0x0000000183CC79C0-0x0000000183CC7A70

	// Constructors
	public SetAIParam() {} // 0x0000000183CC8240-0x0000000183CC82A0

	// Methods
	// [XID] // 0x000000018988D5A0-0x000000018988D5C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183CC7EE0-0x0000000183CC8050
	// [XID] // 0x0000000189894D30-0x0000000189894D50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183CC78C0-0x0000000183CC79C0
	// [XID] // 0x000000018989C320-0x000000018989C340
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3C60 */) => default; // 0x0000000183CC74D0-0x0000000183CC75B0
	// [XID] // 0x00000001898A39A0-0x00000001898A39C0
	public override int GetHashNum() => default; // 0x0000000183CC5F50-0x0000000183CC6020
	// [XID] // 0x00000001898AAD00-0x00000001898AAD20
	public override void InitEmpty() {} // 0x0000000183CC6E60-0x0000000183CC6F50
	[BlackList] // 0x00000001898B2630-0x00000001898B2670
	// [XID] // 0x00000001898B2630-0x00000001898B2670
	public override bool FromJson(JSONNode node) => default; // 0x0000000183CC6850-0x0000000183CC6BD0
	// [XID] // 0x00000001898BD1A0-0x00000001898BD1C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183CC5430-0x0000000183CC5900
	[BlackList] // 0x00000001898C48E0-0x00000001898C4920
	// [XID] // 0x00000001898C48E0-0x00000001898C4920
	public static new SetAIParam ParseFromJson(JSONNode node) => default; // 0x0000000183CC7610-0x0000000183CC7860
	// [XID] // 0x00000001898CEFB0-0x00000001898CEFD0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C61 */, bool useObjectPool = false /* Metadata: 0x00AF3C65 */) => default; // 0x0000000183CC71D0-0x0000000183CC74D0
	// [XID] // 0x00000001898D6A00-0x00000001898D6A20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C66 */, bool useObjectPool = false /* Metadata: 0x00AF3C6A */) => default; // 0x0000000183CC6100-0x0000000183CC6560
	// [XID] // 0x00000001898DE5C0-0x00000001898DE5E0
	public static new SetAIParam ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C6B */, bool useObjectPool = false /* Metadata: 0x00AF3C6F */) => default; // 0x0000000183CC6BD0-0x0000000183CC6DF0
	[BlackList] // 0x00000001898E5DE0-0x00000001898E5E20
	// [XID] // 0x00000001898E5DE0-0x00000001898E5E20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183CC5900-0x0000000183CC5BD0
	// [XID] // 0x00000001898F0780-0x00000001898F07A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183CC7A70-0x0000000183CC7E40
	[BlackList] // 0x00000001898F80F0-0x00000001898F8130
	// [XID] // 0x00000001898F80F0-0x00000001898F8130
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183CC7030-0x0000000183CC7120
	[BlackList] // 0x0000000189902940-0x0000000189902980
	// [XID] // 0x0000000189902940-0x0000000189902980
	public override void AutoAllocTypeFields() {} // 0x0000000183CC5BD0-0x0000000183CC5C70
	[BlackList] // 0x000000018990D090-0x000000018990D0D0
	// [XID] // 0x000000018990D090-0x000000018990D0D0
	public override void AutoRecycleTypeFields() {} // 0x0000000183CC5C70-0x0000000183CC5E30
	[BlackList] // 0x0000000189917B20-0x0000000189917B60
	// [XID] // 0x0000000189917B20-0x0000000189917B60
	public override void ReturnToObjectPool() {} // 0x0000000183CC81A0-0x0000000183CC8240
}

