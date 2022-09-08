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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigTrigger : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19084
{
	// Fields
	private TriggerFlag _triggerFlag; // 0x10
	private ConcernType _concernType; // 0x14
	private string _shape; // 0x18
	private bool _checkInfinite; // 0x20
	private bool _triggerInfinite; // 0x21
	private bool _lifeInfinite; // 0x22
	private SimpleSafeFloat startCheckTimeRawNum; // 0x24
	private SimpleSafeFloat checkIntervalRawNum; // 0x28
	private SimpleSafeInt32 checkCountRawNum; // 0x2C
	private SimpleSafeFloat triggerIntervalRawNum; // 0x30
	private SimpleSafeInt32 triggerCountRawNum; // 0x34
	private SimpleSafeFloat lifeTimeRawNum; // 0x38
	private bool _overwriteCampType; // 0x3C
	private TargetType _campType; // 0x40
	private bool _checkPoint; // 0x44
	private bool _useSurfaceHeight; // 0x45
	private bool _useCollider; // 0x46

	// Properties
	public TriggerFlag triggerFlag { /* [XID] */ /* 0x00000001897C9420-0x00000001897C9440 */ get => default; /* [XID] */ /* 0x00000001897D0A10-0x00000001897D0A30 */ private set {} } // 0x0000000183AB54E0-0x0000000183AB5580 0x0000000183AB5130-0x0000000183AB51E0
	public ConcernType concernType { /* [XID] */ /* 0x00000001897D87B0-0x00000001897D87D0 */ get => default; /* [XID] */ /* 0x00000001897DF8B0-0x00000001897DF8D0 */ private set {} } // 0x0000000183AB5090-0x0000000183AB5130 0x0000000183AB4570-0x0000000183AB4620
	public string shape { /* [XID] */ /* 0x0000000189877DC0-0x0000000189877DE0 */ get => default; /* [XID] */ /* 0x00000001897EED50-0x00000001897EED70 */ private set {} } // 0x0000000183AB3200-0x0000000183AB32A0 0x0000000183AB4090-0x0000000183AB4140
	public bool checkInfinite { /* [XID] */ /* 0x00000001897F63C0-0x00000001897F63E0 */ get => default; /* [XID] */ /* 0x00000001897FDAE0-0x00000001897FDB00 */ private set {} } // 0x0000000183AB4A90-0x0000000183AB4B30 0x0000000183AB2880-0x0000000183AB2930
	public bool triggerInfinite { /* [XID] */ /* 0x0000000189805290-0x00000001898052B0 */ get => default; /* [XID] */ /* 0x000000018980C850-0x000000018980C870 */ private set {} } // 0x0000000183AB4E30-0x0000000183AB4ED0 0x0000000183AB5430-0x0000000183AB54E0
	public bool lifeInfinite { /* [XID] */ /* 0x000000018992FE70-0x000000018992FE90 */ get => default; /* [XID] */ /* 0x000000018981BBA0-0x000000018981BBC0 */ private set {} } // 0x0000000183AB66A0-0x0000000183AB6740 0x0000000183AB5710-0x0000000183AB57C0
	public float startCheckTime { /* [XID] */ /* 0x0000000189823010-0x0000000189823030 */ get => default; /* [XID] */ /* 0x000000018982AA50-0x000000018982AA70 */ private set {} } // 0x0000000183AB3FB0-0x0000000183AB4090 0x0000000183AB4ED0-0x0000000183AB4FB0
	public float checkInterval { /* [XID] */ /* 0x0000000189831F10-0x0000000189831F30 */ get => default; /* [XID] */ /* 0x0000000189839540-0x0000000189839560 */ private set {} } // 0x0000000183AB5580-0x0000000183AB5660 0x0000000183AB3120-0x0000000183AB3200
	public int checkCount { /* [XID] */ /* 0x0000000189840B80-0x0000000189840BA0 */ get => default; /* [XID] */ /* 0x0000000189848000-0x0000000189848020 */ private set {} } // 0x0000000183AB5360-0x0000000183AB5430 0x0000000183AB51E0-0x0000000183AB52C0
	public float triggerInterval { /* [XID] */ /* 0x000000018984F700-0x000000018984F720 */ get => default; /* [XID] */ /* 0x0000000189856900-0x0000000189856920 */ private set {} } // 0x0000000183AB49B0-0x0000000183AB4A90 0x0000000183AB4FB0-0x0000000183AB5090
	public int triggerCount { /* [XID] */ /* 0x000000018985DB50-0x000000018985DB70 */ get => default; /* [XID] */ /* 0x0000000189865610-0x0000000189865630 */ private set {} } // 0x0000000183AB2CB0-0x0000000183AB2D80 0x0000000183AB3040-0x0000000183AB3120
	public float lifeTime { /* [XID] */ /* 0x000000018986CAB0-0x000000018986CAD0 */ get => default; /* [XID] */ /* 0x0000000189873F80-0x0000000189873FA0 */ private set {} } // 0x0000000183AB46C0-0x0000000183AB47A0 0x0000000183AB32A0-0x0000000183AB3380
	public bool overwriteCampType { /* [XID] */ /* 0x000000018988DCB0-0x000000018988DCD0 */ get => default; /* [XID] */ /* 0x0000000189882BB0-0x0000000189882BD0 */ private set {} } // 0x0000000183AB52C0-0x0000000183AB5360 0x0000000183AB3380-0x0000000183AB3430
	public TargetType campType { /* [XID] */ /* 0x00000001898B01D0-0x00000001898B01F0 */ get => default; /* [XID] */ /* 0x00000001898917E0-0x0000000189891800 */ private set {} } // 0x0000000183AB4620-0x0000000183AB46C0 0x0000000183AB5660-0x0000000183AB5710
	public bool checkPoint { /* [XID] */ /* 0x0000000189899150-0x0000000189899170 */ get => default; /* [XID] */ /* 0x00000001898A02F0-0x00000001898A0310 */ private set {} } // 0x0000000183AB47A0-0x0000000183AB4840 0x0000000183AB2F90-0x0000000183AB3040
	public bool useSurfaceHeight { /* [XID] */ /* 0x0000000189886BF0-0x0000000189886C10 */ get => default; /* [XID] */ /* 0x00000001898AF5F0-0x00000001898AF610 */ private set {} } // 0x0000000183AB6600-0x0000000183AB66A0 0x0000000183AB2930-0x0000000183AB29E0
	public bool useCollider { /* [XID] */ /* 0x0000000189880DD0-0x0000000189880DF0 */ get => default; /* [XID] */ /* 0x00000001898BE1C0-0x00000001898BE1E0 */ private set {} } // 0x0000000183AB3F10-0x0000000183AB3FB0 0x0000000183AB44C0-0x0000000183AB4570

	// Constructors
	public ConfigTrigger() {} // 0x0000000183AB67E0-0x0000000183AB6860

	// Methods
	// [XID] // 0x00000001898C5A70-0x00000001898C5A90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AB6230-0x0000000183AB64C0
	// [XID] // 0x00000001898CD1C0-0x00000001898CD1E0
	public void InitEmpty() {} // 0x0000000183AB4840-0x0000000183AB49B0
	[BlackList] // 0x00000001898D4AB0-0x00000001898D4AF0
	// [XID] // 0x00000001898D4AB0-0x00000001898D4AF0
	public bool FromJson(JSONNode node) => default; // 0x0000000183AB4140-0x0000000183AB44C0
	// [XID] // 0x00000001898DF840-0x00000001898DF860
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183AB18A0-0x0000000183AB2880
	// [XID] // 0x00000001898E7310-0x00000001898E7330
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBA25 */, bool useObjectPool = false /* Metadata: 0x00AFBA29 */) => default; // 0x0000000183AB4B30-0x0000000183AB4E30
	// [XID] // 0x00000001898EEB40-0x00000001898EEB60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFBA2A */, bool useObjectPool = false /* Metadata: 0x00AFBA2E */) => default; // 0x0000000183AB3430-0x0000000183AB3F10
	[BlackList] // 0x00000001898F6300-0x00000001898F6340
	// [XID] // 0x00000001898F6300-0x00000001898F6340
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AB29E0-0x0000000183AB2CB0
	// [XID] // 0x0000000189900C90-0x0000000189900CB0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AB57C0-0x0000000183AB6230
	[BlackList] // 0x0000000189908430-0x0000000189908470
	// [XID] // 0x0000000189908430-0x0000000189908470
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AB2D80-0x0000000183AB2E20
	[BlackList] // 0x0000000189912E20-0x0000000189912E60
	// [XID] // 0x0000000189912E20-0x0000000189912E60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AB2E20-0x0000000183AB2F90
	[BlackList] // 0x000000018991D5F0-0x000000018991D630
	// [XID] // 0x000000018991D5F0-0x000000018991D630
	public virtual void ReturnToObjectPool() {} // 0x0000000183AB6740-0x0000000183AB67E0
	[BlackList] // 0x0000000189927C30-0x0000000189927C70
	// [XID] // 0x0000000189927C30-0x0000000189927C70
	public virtual void OnPoolAllocated() {} // 0x0000000183AB6560-0x0000000183AB6600
	[BlackList] // 0x0000000189932220-0x0000000189932260
	// [XID] // 0x0000000189932220-0x0000000189932260
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AB64C0-0x0000000183AB6560
}

