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
public class ConfigStandbyPerform : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18019
{
	// Fields
	private SimpleSafeFloat minTimeRawNum; // 0x10
	private SimpleSafeFloat maxTimeRawNum; // 0x14
	private SimpleSafeInt32[] _performIDs; // 0x18

	// Properties
	public float minTime { /* [XID] */ /* 0x0000000189747040-0x0000000189747060 */ get => default; /* [XID] */ /* 0x0000000189B47920-0x0000000189B47940 */ private set {} } // 0x00000001841EC740-0x00000001841EC820 0x00000001841EC820-0x00000001841EC900
	public float maxTime { /* [XID] */ /* 0x0000000189773860-0x0000000189773880 */ get => default; /* [XID] */ /* 0x0000000189B56A50-0x0000000189B56A70 */ private set {} } // 0x00000001841EBDF0-0x00000001841EBED0 0x00000001841EC250-0x00000001841EC330
	public SimpleSafeInt32[] performIDs { /* [XID] */ /* 0x0000000189782BA0-0x0000000189782BC0 */ get => default; /* [XID] */ /* 0x0000000189B657A0-0x0000000189B657C0 */ private set {} } // 0x00000001841EC900-0x00000001841EC9A0 0x00000001841EC9A0-0x00000001841ECA50

	// Constructors
	public ConfigStandbyPerform() {} // 0x00000001841ED050-0x00000001841ED0B0

	// Methods
	// [XID] // 0x0000000189B6CD80-0x0000000189B6CDA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841ECD50-0x00000001841ECE70
	// [XID] // 0x0000000189B74530-0x0000000189B74550
	public void InitEmpty() {} // 0x00000001841EC330-0x00000001841EC440
	[BlackList] // 0x0000000189B7BB30-0x0000000189B7BB70
	// [XID] // 0x0000000189B7BB30-0x0000000189B7BB70
	public bool FromJson(JSONNode node) => default; // 0x00000001841EBED0-0x00000001841EC250
	// [XID] // 0x0000000189B865E0-0x0000000189B86600
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001841EB200-0x00000001841EB630
	// [XID] // 0x0000000189B8D6B0-0x0000000189B8D6D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86DF */, bool useObjectPool = false /* Metadata: 0x00AF86E3 */) => default; // 0x00000001841EC440-0x00000001841EC740
	// [XID] // 0x0000000189B94C30-0x0000000189B94C50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86E4 */, bool useObjectPool = false /* Metadata: 0x00AF86E8 */) => default; // 0x00000001841EBA90-0x00000001841EBDF0
	[BlackList] // 0x0000000189B9C3E0-0x0000000189B9C420
	// [XID] // 0x0000000189B9C3E0-0x0000000189B9C420
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001841EB630-0x00000001841EB900
	// [XID] // 0x0000000189BA6900-0x0000000189BA6920
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841ECA50-0x00000001841ECD50
	[BlackList] // 0x0000000189BADAC0-0x0000000189BADB00
	// [XID] // 0x0000000189BADAC0-0x0000000189BADB00
	public virtual void AutoAllocTypeFields() {} // 0x00000001841EB900-0x00000001841EB9A0
	[BlackList] // 0x0000000189BB8120-0x0000000189BB8160
	// [XID] // 0x0000000189BB8120-0x0000000189BB8160
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841EB9A0-0x00000001841EBA90
	[BlackList] // 0x0000000189BC30F0-0x0000000189BC3130
	// [XID] // 0x0000000189BC30F0-0x0000000189BC3130
	public virtual void ReturnToObjectPool() {} // 0x00000001841ECFB0-0x00000001841ED050
	[BlackList] // 0x0000000189BCD840-0x0000000189BCD880
	// [XID] // 0x0000000189BCD840-0x0000000189BCD880
	public virtual void OnPoolAllocated() {} // 0x00000001841ECF10-0x00000001841ECFB0
	[BlackList] // 0x0000000189BD7C10-0x0000000189BD7C50
	// [XID] // 0x0000000189BD7C10-0x0000000189BD7C50
	public virtual void OnBeforePoolRecycled() {} // 0x00000001841ECE70-0x00000001841ECF10
}

