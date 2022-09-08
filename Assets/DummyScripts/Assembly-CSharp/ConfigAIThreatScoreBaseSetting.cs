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
using Newtonsoft.Json;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAIThreatScoreBaseSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17389
{
	// Fields
	private bool _enable; // 0x10
	private SimpleSafeInt32 weightRawNum; // 0x14
	private SimpleSafeFloat valueRawNum; // 0x18
	private SimpleSafeFloat minRawNum; // 0x1C
	private SimpleSafeFloat maxRawNum; // 0x20
	private OrderingType _compareOperation; // 0x24
	[BlackList] // 0x0000000189B4D810-0x0000000189B4D840
	[JsonIgnore] // 0x0000000189B4D810-0x0000000189B4D840
	private float _w; // 0x28

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189B994C0-0x0000000189B994E0 */ get => default; /* [XID] */ /* 0x0000000189BA09B0-0x0000000189BA09D0 */ private set {} } // 0x0000000183DF5070-0x0000000183DF5110 0x0000000183DF5EB0-0x0000000183DF5F60
	public int weight { /* [XID] */ /* 0x0000000189BA80B0-0x0000000189BA80D0 */ get => default; /* [XID] */ /* 0x0000000189BAF540-0x0000000189BAF560 */ private set {} } // 0x0000000183DF6A90-0x0000000183DF6B60 0x0000000183DF51F0-0x0000000183DF52D0
	public float value { /* [XID] */ /* 0x0000000189BB6BF0-0x0000000189BB6C10 */ get => default; /* [XID] */ /* 0x0000000189BBE270-0x0000000189BBE290 */ private set {} } // 0x0000000183DF4C10-0x0000000183DF4CF0 0x0000000183DF4960-0x0000000183DF4A40
	public float min { /* [XID] */ /* 0x000000018985C0C0-0x000000018985C0E0 */ get => default; /* [XID] */ /* 0x0000000189BCD9A0-0x0000000189BCD9C0 */ private set {} } // 0x0000000183DF4440-0x0000000183DF4520 0x0000000183DF3760-0x0000000183DF3840
	public float max { /* [XID] */ /* 0x0000000189A86C20-0x0000000189A86C40 */ get => default; /* [XID] */ /* 0x0000000189BDC9E0-0x0000000189BDCA00 */ private set {} } // 0x0000000183DF54A0-0x0000000183DF5580 0x0000000183DF5110-0x0000000183DF51F0
	public OrderingType compareOperation { /* [XID] */ /* 0x00000001899585F0-0x0000000189958610 */ get => default; /* [XID] */ /* 0x00000001895F0A00-0x00000001895F0A20 */ private set {} } // 0x0000000183DF5580-0x0000000183DF5620 0x0000000183DF5620-0x0000000183DF56D0

	// Constructors
	public ConfigAIThreatScoreBaseSetting() {} // 0x0000000183DF6C00-0x0000000183DF6CE0

	// Methods
	// [XID] // 0x00000001895F83B0-0x00000001895F83D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183DF64A0-0x0000000183DF6610
	// [XID] // 0x00000001895FF910-0x00000001895FF930
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183DF5F60-0x0000000183DF6010
	// [XID] // 0x0000000189607140-0x0000000189607160
	public virtual ConfigAIThreatScoreBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6CE3 */) => default; // 0x0000000183DF5BD0-0x0000000183DF5CB0
	// [XID] // 0x000000018960EB80-0x000000018960EBA0
	public virtual int GetHashNum() => default; // 0x0000000183DF4370-0x0000000183DF4440
	// [XID] // 0x0000000189616160-0x0000000189616180
	public virtual void InitEmpty() {} // 0x0000000183DF56D0-0x0000000183DF57E0
	[BlackList] // 0x000000018961D950-0x000000018961D990
	// [XID] // 0x000000018961D950-0x000000018961D990
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183DF4CF0-0x0000000183DF5070
	// [XID] // 0x0000000189627EF0-0x0000000189627F10
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183DF3840-0x0000000183DF3EE0
	[BlackList] // 0x000000018962F800-0x000000018962F840
	// [XID] // 0x000000018962F800-0x000000018962F840
	public static ConfigAIThreatScoreBaseSetting ParseFromJson(JSONNode node) => default; // 0x0000000183DF5CB0-0x0000000183DF5EB0
	// [XID] // 0x000000018963A290-0x000000018963A2B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6CE4 */, bool useObjectPool = false /* Metadata: 0x00AF6CE8 */) => default; // 0x0000000183DF58D0-0x0000000183DF5BD0
	// [XID] // 0x00000001896417E0-0x0000000189641800
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6CE9 */, bool useObjectPool = false /* Metadata: 0x00AF6CED */) => default; // 0x0000000183DF4520-0x0000000183DF4960
	// [XID] // 0x0000000189649240-0x0000000189649260
	public static ConfigAIThreatScoreBaseSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6CEE */, bool useObjectPool = false /* Metadata: 0x00AF6CF2 */) => default; // 0x0000000183DF52D0-0x0000000183DF54A0
	[BlackList] // 0x0000000189650830-0x0000000189650870
	// [XID] // 0x0000000189650830-0x0000000189650870
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183DF3EE0-0x0000000183DF41B0
	// [XID] // 0x000000018965B110-0x000000018965B130
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183DF6010-0x0000000183DF64A0
	[BlackList] // 0x00000001896625A0-0x00000001896625E0
	// [XID] // 0x00000001896625A0-0x00000001896625E0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183DF57E0-0x0000000183DF58D0
	[BlackList] // 0x000000018966CCE0-0x000000018966CD20
	// [XID] // 0x000000018966CCE0-0x000000018966CD20
	public virtual void AutoAllocTypeFields() {} // 0x0000000183DF41B0-0x0000000183DF4250
	[BlackList] // 0x0000000189677BD0-0x0000000189677C10
	// [XID] // 0x0000000189677BD0-0x0000000189677C10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183DF4250-0x0000000183DF4370
	[BlackList] // 0x00000001896822B0-0x00000001896822F0
	// [XID] // 0x00000001896822B0-0x00000001896822F0
	public virtual void ReturnToObjectPool() {} // 0x0000000183DF6B60-0x0000000183DF6C00
	[BlackList] // 0x000000018968CD20-0x000000018968CD60
	// [XID] // 0x000000018968CD20-0x000000018968CD60
	public virtual void OnPoolAllocated() {} // 0x0000000183DF66B0-0x0000000183DF6750
	[BlackList] // 0x0000000189697A80-0x0000000189697AC0
	// [XID] // 0x0000000189697A80-0x0000000189697AC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183DF6610-0x0000000183DF66B0
	// [XID] // 0x00000001896A1F20-0x00000001896A1F40
	public void Init(float sumWeight) {} // 0x0000000183DF4A40-0x0000000183DF4C10
	// [IDTag] // 0x00000001896A9260-0x00000001896A92A0
	// [XID] // 0x00000001896A9260-0x00000001896A92A0
	protected float CalculateScore(float value) => default; // 0x0000000183DF6830-0x0000000183DF6A90
	// [IDTag] // 0x00000001896B3490-0x00000001896B34D0
	// [XID] // 0x00000001896B3490-0x00000001896B34D0
	public virtual float CalculateScore(AIKnowledge aiKnowledge, ThreatInfo threatInfo, ThreadRuntimeInfo threatRuntimeInfo) => default; // 0x0000000183DF6750-0x0000000183DF6830
}

