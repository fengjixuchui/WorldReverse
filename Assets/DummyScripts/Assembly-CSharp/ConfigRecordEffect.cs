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
public class ConfigRecordEffect : ConfigRecordActorBase, IAutoAllocRecycle // TypeDefIndex: 18884
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigRecordAnimatorInfo _animatorInfo; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigRecordRendererParameters _rendererParams; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigRecordMaterialParameters _materialParams; // 0x48

	// Properties
	public ConfigRecordAnimatorInfo animatorInfo { /* [XID] */ /* 0x00000001898DF860-0x00000001898DF880 */ get => default; /* [XID] */ /* 0x00000001898E7370-0x00000001898E7390 */ private set {} } // 0x0000000184A8F8C0-0x0000000184A8F960 0x0000000184A8F3B0-0x0000000184A8F460
	public ConfigRecordRendererParameters rendererParams { /* [XID] */ /* 0x00000001898EEBA0-0x00000001898EEBC0 */ get => default; /* [XID] */ /* 0x00000001898F63A0-0x00000001898F63C0 */ private set {} } // 0x0000000184A8E8C0-0x0000000184A8E960 0x0000000184A8F2A0-0x0000000184A8F350
	public ConfigRecordMaterialParameters materialParams { /* [XID] */ /* 0x00000001898FDB40-0x00000001898FDB60 */ get => default; /* [XID] */ /* 0x0000000189905360-0x0000000189905380 */ private set {} } // 0x0000000184A8F6B0-0x0000000184A8F750 0x0000000184A8E410-0x0000000184A8E4C0

	// Constructors
	public ConfigRecordEffect() {} // 0x0000000184A8FEB0-0x0000000184A8FF10

	// Methods
	// [XID] // 0x000000018990CCD0-0x000000018990CCF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A8FCD0-0x0000000184A8FE10
	// [XID] // 0x0000000189914420-0x0000000189914440
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A8F7B0-0x0000000184A8F8C0
	// [XID] // 0x000000018991BF20-0x000000018991BF40
	public override ConfigRecordActorBase Clone(bool useObjectPool = false /* Metadata: 0x00AFB261 */) => default; // 0x0000000184A8F1C0-0x0000000184A8F2A0
	// [XID] // 0x0000000189923660-0x0000000189923680
	public override int GetHashNum() => default; // 0x0000000184A8DDA0-0x0000000184A8DE70
	// [XID] // 0x000000018992ACC0-0x000000018992ACE0
	public override void InitEmpty() {} // 0x0000000184A8EBF0-0x0000000184A8ECF0
	[BlackList] // 0x00000001899322E0-0x0000000189932320
	// [XID] // 0x00000001899322E0-0x0000000189932320
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A8E540-0x0000000184A8E8C0
	// [XID] // 0x000000018993CC70-0x000000018993CC90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A8D2C0-0x0000000184A8D6F0
	[BlackList] // 0x0000000189944260-0x00000001899442A0
	// [XID] // 0x0000000189944260-0x00000001899442A0
	public static new ConfigRecordEffect ParseFromJson(JSONNode node) => default; // 0x0000000184A8F460-0x0000000184A8F6B0
	// [XID] // 0x000000018994E820-0x000000018994E840
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB262 */, bool useObjectPool = false /* Metadata: 0x00AFB266 */) => default; // 0x0000000184A8EEC0-0x0000000184A8F1C0
	// [XID] // 0x0000000189955E80-0x0000000189955EA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB267 */, bool useObjectPool = false /* Metadata: 0x00AFB26B */) => default; // 0x0000000184A8DF50-0x0000000184A8E390
	// [XID] // 0x000000018995D9B0-0x000000018995D9D0
	public static new ConfigRecordEffect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB26C */, bool useObjectPool = false /* Metadata: 0x00AFB270 */) => default; // 0x0000000184A8E960-0x0000000184A8EB80
	[BlackList] // 0x0000000189965130-0x0000000189965170
	// [XID] // 0x0000000189965130-0x0000000189965170
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A8D6F0-0x0000000184A8D9C0
	// [XID] // 0x000000018996F3C0-0x000000018996F3E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A8F960-0x0000000184A8FCD0
	[BlackList] // 0x0000000189977020-0x0000000189977060
	// [XID] // 0x0000000189977020-0x0000000189977060
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A8EDD0-0x0000000184A8EEC0
	[BlackList] // 0x00000001899819A0-0x00000001899819E0
	// [XID] // 0x00000001899819A0-0x00000001899819E0
	public override void AutoAllocTypeFields() {} // 0x0000000184A8D9C0-0x0000000184A8DA60
	[BlackList] // 0x000000018998C1B0-0x000000018998C1F0
	// [XID] // 0x000000018998C1B0-0x000000018998C1F0
	public override void AutoRecycleTypeFields() {} // 0x0000000184A8DA60-0x0000000184A8DC80
	[BlackList] // 0x0000000189996C20-0x0000000189996C60
	// [XID] // 0x0000000189996C20-0x0000000189996C60
	public override void ReturnToObjectPool() {} // 0x0000000184A8FE10-0x0000000184A8FEB0
}

