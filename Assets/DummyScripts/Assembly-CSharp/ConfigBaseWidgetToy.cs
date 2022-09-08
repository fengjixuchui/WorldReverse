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
public class ConfigBaseWidgetToy : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19194
{
	// Fields
	private bool _isConsumeMaterial; // 0x10
	private WidgetConsumeTime _consumeTime; // 0x14
	private SimpleSafeUInt32 cdGroupRawNum; // 0x18
	private WidgetOccupyTag[] _tags; // 0x20
	private bool _isShowRedpoint; // 0x28

	// Properties
	public bool isConsumeMaterial { /* [XID] */ /* 0x0000000189781300-0x0000000189781320 */ get => default; /* [XID] */ /* 0x00000001897A4750-0x00000001897A4770 */ private set {} } // 0x00000001847EBD80-0x00000001847EBE20 0x00000001847EAEF0-0x00000001847EAFA0
	public WidgetConsumeTime consumeTime { /* [XID] */ /* 0x00000001897ABC00-0x00000001897ABC20 */ get => default; /* [XID] */ /* 0x00000001897B3C30-0x00000001897B3C50 */ private set {} } // 0x00000001847EAFA0-0x00000001847EB040 0x00000001847EBE20-0x00000001847EBED0
	public uint cdGroup { /* [XID] */ /* 0x00000001897BB9F0-0x00000001897BBA10 */ get => default; /* [XID] */ /* 0x00000001897C32B0-0x00000001897C32D0 */ private set {} } // 0x00000001847EB630-0x00000001847EB700 0x00000001847EC870-0x00000001847EC950
	public WidgetOccupyTag[] tags { /* [XID] */ /* 0x00000001897CAA70-0x00000001897CAA90 */ get => default; /* [XID] */ /* 0x00000001897D2070-0x00000001897D2090 */ private set {} } // 0x00000001847EB590-0x00000001847EB630 0x00000001847EAA20-0x00000001847EAAD0
	public bool isShowRedpoint { /* [XID] */ /* 0x00000001897D9EF0-0x00000001897D9F10 */ get => default; /* [XID] */ /* 0x00000001897E11C0-0x00000001897E11E0 */ private set {} } // 0x00000001847EA980-0x00000001847EAA20 0x00000001847EBCD0-0x00000001847EBD80

	// Constructors
	public ConfigBaseWidgetToy() {} // 0x00000001847EC9F0-0x00000001847ECA50

	// Methods
	// [XID] // 0x00000001897E8A70-0x00000001897E8A90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001847EC5D0-0x00000001847EC730
	// [XID] // 0x00000001897F0660-0x00000001897F0680
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847EC0D0-0x00000001847EC1A0
	// [XID] // 0x00000001897F7D60-0x00000001897F7D80
	public virtual ConfigBaseWidgetToy Clone(bool useObjectPool = false /* Metadata: 0x00AFC4E5 */) => default; // 0x00000001847EBBF0-0x00000001847EBCD0
	// [XID] // 0x00000001897FF450-0x00000001897FF470
	public virtual int GetHashNum() => default; // 0x00000001847EA8B0-0x00000001847EA980
	// [XID] // 0x0000000189806B50-0x0000000189806B70
	public virtual void InitEmpty() {} // 0x00000001847EB700-0x00000001847EB800
	[BlackList] // 0x000000018980E2D0-0x000000018980E310
	// [XID] // 0x000000018980E2D0-0x000000018980E310
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001847EB040-0x00000001847EB3C0
	// [XID] // 0x0000000189818C90-0x0000000189818CB0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001847E9F10-0x00000001847EA460
	[BlackList] // 0x0000000189820530-0x0000000189820570
	// [XID] // 0x0000000189820530-0x0000000189820570
	public static ConfigBaseWidgetToy ParseFromJson(JSONNode node) => default; // 0x00000001847EBED0-0x00000001847EC0D0
	// [XID] // 0x000000018982AA10-0x000000018982AA30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4E6 */, bool useObjectPool = false /* Metadata: 0x00AFC4EA */) => default; // 0x00000001847EB8F0-0x00000001847EBBF0
	// [XID] // 0x0000000189831EB0-0x0000000189831ED0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4EB */, bool useObjectPool = false /* Metadata: 0x00AFC4EF */) => default; // 0x00000001847EAAD0-0x00000001847EAEF0
	// [XID] // 0x00000001898394C0-0x00000001898394E0
	public static ConfigBaseWidgetToy ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4F0 */, bool useObjectPool = false /* Metadata: 0x00AFC4F4 */) => default; // 0x00000001847EB3C0-0x00000001847EB590
	[BlackList] // 0x0000000189840B20-0x0000000189840B60
	// [XID] // 0x0000000189840B20-0x0000000189840B60
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001847EA460-0x00000001847EA730
	// [XID] // 0x000000018984B030-0x000000018984B050
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001847EC1A0-0x00000001847EC5D0
	[BlackList] // 0x00000001898522C0-0x0000000189852300
	// [XID] // 0x00000001898522C0-0x0000000189852300
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001847EB800-0x00000001847EB8F0
	[BlackList] // 0x000000018985C870-0x000000018985C8B0
	// [XID] // 0x000000018985C870-0x000000018985C8B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001847EA730-0x00000001847EA7D0
	[BlackList] // 0x0000000189866CF0-0x0000000189866D30
	// [XID] // 0x0000000189866CF0-0x0000000189866D30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001847EA7D0-0x00000001847EA8B0
	[BlackList] // 0x00000001898710D0-0x0000000189871110
	// [XID] // 0x00000001898710D0-0x0000000189871110
	public virtual void ReturnToObjectPool() {} // 0x00000001847EC950-0x00000001847EC9F0
	[BlackList] // 0x000000018987BA40-0x000000018987BA80
	// [XID] // 0x000000018987BA40-0x000000018987BA80
	public virtual void OnPoolAllocated() {} // 0x00000001847EC7D0-0x00000001847EC870
	[BlackList] // 0x0000000189885F60-0x0000000189885FA0
	// [XID] // 0x0000000189885F60-0x0000000189885FA0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001847EC730-0x00000001847EC7D0
}

