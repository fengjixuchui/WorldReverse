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
public sealed class ConfigGuideOpenStateCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18200
{
	// Fields
	private GuideOpenStateType _openState; // 0x20
	private bool _value; // 0x24
	private NotifyTypes[] _curNotifyList; // 0x28

	// Properties
	public GuideOpenStateType openState { /* [XID] */ /* 0x00000001898A0490-0x00000001898A04B0 */ get => default; /* [XID] */ /* 0x00000001898A7BF0-0x00000001898A7C10 */ private set {} } // 0x00000001822E7A30-0x00000001822E7AD0 0x00000001822E92D0-0x00000001822E9380
	public bool value { /* [XID] */ /* 0x00000001898AF730-0x00000001898AF750 */ get => default; /* [XID] */ /* 0x00000001898B6BB0-0x00000001898B6BD0 */ private set {} } // 0x00000001822E80C0-0x00000001822E8160 0x00000001822E7ED0-0x00000001822E7F80

	// Constructors
	public ConfigGuideOpenStateCondition() {} // 0x00000001822E9840-0x00000001822E9900

	// Methods
	// [XID] // 0x00000001898BE360-0x00000001898BE380
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822E9690-0x00000001822E97A0
	// [XID] // 0x00000001898C5C10-0x00000001898C5C30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001822E9220-0x00000001822E92D0
	// [XID] // 0x00000001898CD360-0x00000001898CD380
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9003 */) => default; // 0x00000001822E8E50-0x00000001822E8F40
	// [XID] // 0x00000001898D4C30-0x00000001898D4C50
	public override int GetHashNum() => default; // 0x00000001822E7960-0x00000001822E7A30
	// [XID] // 0x00000001898DC650-0x00000001898DC670
	public override void InitEmpty() {} // 0x00000001822E88E0-0x00000001822E8980
	[BlackList] // 0x00000001898E40C0-0x00000001898E4100
	// [XID] // 0x00000001898E40C0-0x00000001898E4100
	public override bool FromJson(JSONNode node) => default; // 0x00000001822E8160-0x00000001822E84E0
	// [XID] // 0x00000001898EEC80-0x00000001898EECA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001822E7140-0x00000001822E7420
	[BlackList] // 0x00000001898F6520-0x00000001898F6560
	// [XID] // 0x00000001898F6520-0x00000001898F6560
	public static new ConfigGuideOpenStateCondition ParseFromJson(JSONNode node) => default; // 0x00000001822E8FA0-0x00000001822E91C0
	// [XID] // 0x0000000189900E70-0x0000000189900E90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9004 */, bool useObjectPool = false /* Metadata: 0x00AF9008 */) => default; // 0x00000001822E8B50-0x00000001822E8E50
	// [XID] // 0x00000001899085F0-0x0000000189908610
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9009 */, bool useObjectPool = false /* Metadata: 0x00AF900D */) => default; // 0x00000001822E7BB0-0x00000001822E7E50
	// [XID] // 0x000000018990FCB0-0x000000018990FCD0
	public static new ConfigGuideOpenStateCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF900E */, bool useObjectPool = false /* Metadata: 0x00AF9012 */) => default; // 0x00000001822E84E0-0x00000001822E86D0
	[BlackList] // 0x00000001899177C0-0x0000000189917800
	// [XID] // 0x00000001899177C0-0x0000000189917800
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001822E7420-0x00000001822E76F0
	// [XID] // 0x0000000189922080-0x00000001899220A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001822E9400-0x00000001822E9690
	[BlackList] // 0x00000001899297C0-0x0000000189929800
	// [XID] // 0x00000001899297C0-0x0000000189929800
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001822E8A60-0x00000001822E8B50
	// [XID] // 0x0000000189933B40-0x0000000189933B60
	protected override bool Prepare(GuideManager manager) => default; // 0x00000001822E8000-0x00000001822E80C0
	// [XID] // 0x000000018993B710-0x000000018993B730
	public override bool Ready(object body = null) => default; // 0x00000001822E8740-0x00000001822E8860
	[BlackList] // 0x00000001899427D0-0x0000000189942810
	// [XID] // 0x00000001899427D0-0x0000000189942810
	public override void AutoAllocTypeFields() {} // 0x00000001822E76F0-0x00000001822E7790
	[BlackList] // 0x000000018994CF10-0x000000018994CF50
	// [XID] // 0x000000018994CF10-0x000000018994CF50
	public override void AutoRecycleTypeFields() {} // 0x00000001822E7790-0x00000001822E7840
	[BlackList] // 0x00000001899577A0-0x00000001899577E0
	// [XID] // 0x00000001899577A0-0x00000001899577E0
	public override void ReturnToObjectPool() {} // 0x00000001822E97A0-0x00000001822E9840
}

