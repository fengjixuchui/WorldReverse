/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigEquipController : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18068
{
	// Fields
	private Dictionary<string, string> _attachPoints; // 0x10
	private string _sheathPoint; // 0x18
	private SimpleSafeFloat dissolveSheathFadeDelayRawNum; // 0x20
	private SimpleSafeFloat dissolveSheathFadeTimeRawNum; // 0x24
	private SimpleSafeFloat dissolveTakeFadeTimeRawNum; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private TriggerToStates[] _triggerToStates; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private WeaponAwayFromHandState[] _weaponAwayFromHandStates; // 0x38

	// Properties
	public Dictionary<string, string> attachPoints { /* [XID] */ /* 0x0000000189B38FD0-0x0000000189B38FF0 */ get => default; /* [XID] */ /* 0x000000018981D610-0x000000018981D630 */ private set {} } // 0x0000000184835E10-0x0000000184835EB0 0x00000001848365B0-0x0000000184836660
	public string sheathPoint { /* [XID] */ /* 0x0000000189824B00-0x0000000189824B20 */ get => default; /* [XID] */ /* 0x000000018982C4B0-0x000000018982C4D0 */ private set {} } // 0x0000000184836510-0x00000001848365B0 0x0000000184835720-0x00000001848357D0
	public float dissolveSheathFadeDelay { /* [XID] */ /* 0x000000018992E950-0x000000018992E970 */ get => default; /* [XID] */ /* 0x000000018983AF00-0x000000018983AF20 */ private set {} } // 0x0000000184836A10-0x0000000184836AF0 0x0000000184836AF0-0x0000000184836BD0
	public float dissolveSheathFadeTime { /* [XID] */ /* 0x00000001898425E0-0x0000000189842600 */ get => default; /* [XID] */ /* 0x0000000189849990-0x00000001898499B0 */ private set {} } // 0x0000000184835640-0x0000000184835720 0x0000000184836230-0x0000000184836310
	public float dissolveTakeFadeTime { /* [XID] */ /* 0x0000000189935C80-0x0000000189935CA0 */ get => default; /* [XID] */ /* 0x0000000189858620-0x0000000189858640 */ private set {} } // 0x0000000184834940-0x0000000184834A20 0x0000000184837200-0x00000001848372E0
	public TriggerToStates[] triggerToStates { /* [XID] */ /* 0x0000000189950E50-0x0000000189950E70 */ get => default; /* [XID] */ /* 0x0000000189866F70-0x0000000189866F90 */ private set {} } // 0x0000000184836310-0x00000001848363B0 0x0000000184837150-0x0000000184837200
	public WeaponAwayFromHandState[] weaponAwayFromHandStates { /* [XID] */ /* 0x000000018986E770-0x000000018986E790 */ get => default; /* [XID] */ /* 0x0000000189875B80-0x0000000189875BA0 */ private set {} } // 0x00000001848357D0-0x0000000184835870 0x0000000184836960-0x0000000184836A10

	// Constructors
	public ConfigEquipController() {} // 0x0000000184837650-0x00000001848376F0

	// Methods
	// [XID] // 0x000000018987D7C0-0x000000018987D7E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001848372E0-0x0000000184837470
	// [XID] // 0x0000000189884690-0x00000001898846B0
	public void InitEmpty() {} // 0x00000001848363B0-0x0000000184836510
	[BlackList] // 0x000000018988BCA0-0x000000018988BCE0
	// [XID] // 0x000000018988BCA0-0x000000018988BCE0
	public bool FromJson(JSONNode node) => default; // 0x0000000184835EB0-0x0000000184836230
	// [XID] // 0x0000000189895FA0-0x0000000189895FC0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184834A20-0x00000001848351C0
	// [XID] // 0x000000018989D600-0x000000018989D620
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89DB */, bool useObjectPool = false /* Metadata: 0x00AF89DF */) => default; // 0x0000000184836660-0x0000000184836960
	// [XID] // 0x00000001898A4FC0-0x00000001898A4FE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89E0 */, bool useObjectPool = false /* Metadata: 0x00AF89E4 */) => default; // 0x0000000184835870-0x0000000184835E10
	[BlackList] // 0x00000001898AC400-0x00000001898AC440
	// [XID] // 0x00000001898AC400-0x00000001898AC440
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001848351C0-0x0000000184835490
	// [XID] // 0x00000001898B6CD0-0x00000001898B6CF0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184836BD0-0x0000000184837150
	[BlackList] // 0x00000001898BE380-0x00000001898BE3C0
	// [XID] // 0x00000001898BE380-0x00000001898BE3C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184835490-0x0000000184835530
	[BlackList] // 0x00000001898C8E20-0x00000001898C8E60
	// [XID] // 0x00000001898C8E20-0x00000001898C8E60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184835530-0x0000000184835640
	[BlackList] // 0x00000001898D33B0-0x00000001898D33F0
	// [XID] // 0x00000001898D33B0-0x00000001898D33F0
	public virtual void ReturnToObjectPool() {} // 0x00000001848375B0-0x0000000184837650
	[BlackList] // 0x00000001898DE220-0x00000001898DE260
	// [XID] // 0x00000001898DE220-0x00000001898DE260
	public virtual void OnPoolAllocated() {} // 0x0000000184837510-0x00000001848375B0
	[BlackList] // 0x00000001898E8C20-0x00000001898E8C60
	// [XID] // 0x00000001898E8C20-0x00000001898E8C60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184837470-0x0000000184837510
}

