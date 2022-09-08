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
public class ConfigBaseAttackPattern : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17530
{
	// Fields
	private TriggerType _triggerType; // 0x10
	private CheckHitLayerType _checkHitLayerType; // 0x14
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigHitScene _hitScene; // 0x18
	private SimpleSafeFloat triggerCDRawNum; // 0x20
	private bool _filterByFrame; // 0x24
	private bool _ignoreMassive; // 0x25
	private EntityAttackFilter _entityAttackFilter; // 0x28
	private SimpleSafeFloat massiveAttackRatioRawNum; // 0x2C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x30

	// Properties
	public TriggerType triggerType { /* [XID] */ /* 0x000000018999C340-0x000000018999C360 */ get => default; /* [XID] */ /* 0x0000000189BBE210-0x0000000189BBE230 */ private set {} } // 0x0000000182DFB9D0-0x0000000182DFBA70 0x0000000182DFB080-0x0000000182DFB130
	public CheckHitLayerType checkHitLayerType { /* [XID] */ /* 0x0000000189BC5EE0-0x0000000189BC5F00 */ get => default; /* [XID] */ /* 0x0000000189BCD940-0x0000000189BCD960 */ private set {} } // 0x0000000182DFB1E0-0x0000000182DFB280 0x0000000182DFBB10-0x0000000182DFBBC0
	public ConfigHitScene hitScene { /* [XID] */ /* 0x0000000189BD4E10-0x0000000189BD4E30 */ get => default; /* [XID] */ /* 0x0000000189BDC980-0x0000000189BDC9A0 */ private set {} } // 0x0000000182DFC2D0-0x0000000182DFC370 0x0000000182DFCDE0-0x0000000182DFCE90
	public float triggerCD { /* [XID] */ /* 0x00000001895E9210-0x00000001895E9230 */ get => default; /* [XID] */ /* 0x00000001895F09C0-0x00000001895F09E0 */ private set {} } // 0x0000000182DFBF40-0x0000000182DFC020 0x0000000182DFB8F0-0x0000000182DFB9D0
	public bool filterByFrame { /* [XID] */ /* 0x00000001895F8370-0x00000001895F8390 */ get => default; /* [XID] */ /* 0x00000001895FF8D0-0x00000001895FF8F0 */ private set {} } // 0x0000000182DFBA70-0x0000000182DFBB10 0x0000000182DFAF30-0x0000000182DFAFE0
	public bool ignoreMassive { /* [XID] */ /* 0x00000001896070E0-0x0000000189607100 */ get => default; /* [XID] */ /* 0x000000018960EB20-0x000000018960EB40 */ private set {} } // 0x0000000182DFCD40-0x0000000182DFCDE0 0x0000000182DFB130-0x0000000182DFB1E0
	public EntityAttackFilter entityAttackFilter { /* [XID] */ /* 0x0000000189616120-0x0000000189616140 */ get => default; /* [XID] */ /* 0x000000018961D910-0x000000018961D930 */ private set {} } // 0x0000000182DFADC0-0x0000000182DFAE60 0x0000000182DF9EE0-0x0000000182DF9F90
	public float massiveAttackRatio { /* [XID] */ /* 0x0000000189624D70-0x0000000189624D90 */ get => default; /* [XID] */ /* 0x000000018962C570-0x000000018962C590 */ private set {} } // 0x0000000182DFC970-0x0000000182DFCA50 0x0000000182DFC1F0-0x0000000182DFC2D0
	public ConfigBornType born { /* [XID] */ /* 0x00000001896341B0-0x00000001896341D0 */ get => default; /* [XID] */ /* 0x000000018963BA20-0x000000018963BA40 */ private set {} } // 0x0000000182DFAFE0-0x0000000182DFB080 0x0000000182DFD7F0-0x0000000182DFD8A0

	// Constructors
	public ConfigBaseAttackPattern() {} // 0x0000000182DFD940-0x0000000182DFD9E0

	// Methods
	// [XID] // 0x0000000189994A80-0x0000000189994AA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182DFD4C0-0x0000000182DFD6B0
	// [XID] // 0x000000018964A7A0-0x000000018964A7C0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182DFCC50-0x0000000182DFCD40
	// [XID] // 0x0000000189652040-0x0000000189652060
	public virtual ConfigBaseAttackPattern Clone(bool useObjectPool = false /* Metadata: 0x00AF71E9 */) => default; // 0x0000000182DFC890-0x0000000182DFC970
	// [XID] // 0x0000000189659710-0x0000000189659730
	public virtual int GetHashNum() => default; // 0x0000000182DFAE60-0x0000000182DFAF30
	// [XID] // 0x0000000189660E30-0x0000000189660E50
	public virtual void InitEmpty() {} // 0x0000000182DFC370-0x0000000182DFC4A0
	[BlackList] // 0x0000000189668780-0x00000001896687C0
	// [XID] // 0x0000000189668780-0x00000001896687C0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000182DFBBC0-0x0000000182DFBF40
	// [XID] // 0x0000000189673240-0x0000000189673260
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182DF9F90-0x0000000182DFA870
	[BlackList] // 0x000000018967A940-0x000000018967A980
	// [XID] // 0x000000018967A940-0x000000018967A980
	public static ConfigBaseAttackPattern ParseFromJson(JSONNode node) => default; // 0x0000000182DFCA50-0x0000000182DFCC50
	// [XID] // 0x0000000189685200-0x0000000189685220
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF71EA */, bool useObjectPool = false /* Metadata: 0x00AF71EE */) => default; // 0x0000000182DFC590-0x0000000182DFC890
	// [XID] // 0x000000018968CCA0-0x000000018968CCC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF71EF */, bool useObjectPool = false /* Metadata: 0x00AF71F3 */) => default; // 0x0000000182DFB280-0x0000000182DFB8F0
	// [XID] // 0x00000001896947E0-0x0000000189694800
	public static ConfigBaseAttackPattern ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF71F4 */, bool useObjectPool = false /* Metadata: 0x00AF71F8 */) => default; // 0x0000000182DFC020-0x0000000182DFC1F0
	[BlackList] // 0x000000018969BE40-0x000000018969BE80
	// [XID] // 0x000000018969BE40-0x000000018969BE80
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000182DFA870-0x0000000182DFAB40
	// [XID] // 0x00000001896A6170-0x00000001896A6190
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182DFCE90-0x0000000182DFD4C0
	[BlackList] // 0x00000001896AD630-0x00000001896AD670
	// [XID] // 0x00000001896AD630-0x00000001896AD670
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182DFC4A0-0x0000000182DFC590
	[BlackList] // 0x00000001896B7D30-0x00000001896B7D70
	// [XID] // 0x00000001896B7D30-0x00000001896B7D70
	public virtual void AutoAllocTypeFields() {} // 0x0000000182DFAB40-0x0000000182DFABE0
	[BlackList] // 0x00000001896C1C40-0x00000001896C1C80
	// [XID] // 0x00000001896C1C40-0x00000001896C1C80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182DFABE0-0x0000000182DFADC0
	[BlackList] // 0x00000001896CC3F0-0x00000001896CC430
	// [XID] // 0x00000001896CC3F0-0x00000001896CC430
	public virtual void ReturnToObjectPool() {} // 0x0000000182DFD8A0-0x0000000182DFD940
	[BlackList] // 0x00000001896D6A20-0x00000001896D6A60
	// [XID] // 0x00000001896D6A20-0x00000001896D6A60
	public virtual void OnPoolAllocated() {} // 0x0000000182DFD750-0x0000000182DFD7F0
	[BlackList] // 0x00000001896E1210-0x00000001896E1250
	// [XID] // 0x00000001896E1210-0x00000001896E1250
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182DFD6B0-0x0000000182DFD750
}

