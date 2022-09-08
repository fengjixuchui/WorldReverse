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
public class ConfigWidgetToyGeneral : ConfigBaseWidgetToy, IAutoAllocRecycle // TypeDefIndex: 19196
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWidgetBehaviour _DoBag; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWidgetBehaviour _DoActionPanel; // 0x38

	// Properties
	public ConfigWidgetBehaviour DoBag { /* [XID] */ /* 0x00000001898A6560-0x00000001898A6580 */ get => default; /* [XID] */ /* 0x00000001898ADC70-0x00000001898ADC90 */ private set {} } // 0x0000000183649D80-0x0000000183649E20 0x00000001836498C0-0x0000000183649970
	public ConfigWidgetBehaviour DoActionPanel { /* [XID] */ /* 0x00000001898B5170-0x00000001898B5190 */ get => default; /* [XID] */ /* 0x00000001898BCC40-0x00000001898BCC60 */ private set {} } // 0x0000000183648390-0x0000000183648430 0x0000000183649100-0x00000001836491B0

	// Constructors
	public ConfigWidgetToyGeneral() {} // 0x000000018364A2A0-0x000000018364A300

	// Methods
	// [XID] // 0x00000001898C4380-0x00000001898C43A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018364A0F0-0x000000018364A200
	// [XID] // 0x00000001898CB950-0x00000001898CB970
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183649C80-0x0000000183649D80
	// [XID] // 0x00000001898D30F0-0x00000001898D3110
	public override ConfigBaseWidgetToy Clone(bool useObjectPool = false /* Metadata: 0x00AFC4F5 */) => default; // 0x00000001836497E0-0x00000001836498C0
	// [XID] // 0x00000001898DAA60-0x00000001898DAA80
	public override int GetHashNum() => default; // 0x0000000183648550-0x0000000183648620
	// [XID] // 0x00000001898E2980-0x00000001898E29A0
	public override void InitEmpty() {} // 0x0000000183649220-0x0000000183649310
	[BlackList] // 0x00000001898EA390-0x00000001898EA3D0
	// [XID] // 0x00000001898EA390-0x00000001898EA3D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183648B60-0x0000000183648EE0
	// [XID] // 0x00000001898F4960-0x00000001898F4980
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183647B30-0x0000000183647E70
	[BlackList] // 0x00000001898FC230-0x00000001898FC270
	// [XID] // 0x00000001898FC230-0x00000001898FC270
	public static new ConfigWidgetToyGeneral ParseFromJson(JSONNode node) => default; // 0x00000001836499D0-0x0000000183649C20
	// [XID] // 0x0000000189906970-0x0000000189906990
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4F6 */, bool useObjectPool = false /* Metadata: 0x00AFC4FA */) => default; // 0x00000001836494E0-0x00000001836497E0
	// [XID] // 0x000000018990E530-0x000000018990E550
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4FB */, bool useObjectPool = false /* Metadata: 0x00AFC4FF */) => default; // 0x0000000183648700-0x0000000183648A60
	// [XID] // 0x0000000189915BC0-0x0000000189915BE0
	public static new ConfigWidgetToyGeneral ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC500 */, bool useObjectPool = false /* Metadata: 0x00AFC504 */) => default; // 0x0000000183648EE0-0x0000000183649100
	[BlackList] // 0x000000018991D570-0x000000018991D5B0
	// [XID] // 0x000000018991D570-0x000000018991D5B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183647E70-0x0000000183648140
	// [XID] // 0x0000000189927BD0-0x0000000189927BF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183649E20-0x000000018364A0F0
	[BlackList] // 0x000000018992F400-0x000000018992F440
	// [XID] // 0x000000018992F400-0x000000018992F440
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001836493F0-0x00000001836494E0
	[BlackList] // 0x0000000189939BF0-0x0000000189939C30
	// [XID] // 0x0000000189939BF0-0x0000000189939C30
	public override void AutoAllocTypeFields() {} // 0x0000000183648140-0x00000001836481E0
	[BlackList] // 0x00000001899441C0-0x0000000189944200
	// [XID] // 0x00000001899441C0-0x0000000189944200
	public override void AutoRecycleTypeFields() {} // 0x00000001836481E0-0x0000000183648390
	[BlackList] // 0x000000018994E7C0-0x000000018994E800
	// [XID] // 0x000000018994E7C0-0x000000018994E800
	public override void ReturnToObjectPool() {} // 0x000000018364A200-0x000000018364A2A0
}

