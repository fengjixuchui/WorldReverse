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
public class ConfigGraphicsSettingEntry : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18157
{
	// Fields
	private GraphicsSettingEntryType _entryType; // 0x10
	private string[] _availableOptions; // 0x18
	private SimpleSafeFloat[] _perfCostRatios; // 0x20
	private SettingEntryDisplayType _displayType; // 0x28
	private SimpleSafeFloat sliderMinRawNum; // 0x2C
	private SimpleSafeFloat sliderMaxRawNum; // 0x30
	private SimpleSafeFloat sliderIntervalRawNum; // 0x34
	private ConfigGraphicSettingEntrySortType _sortOption; // 0x38

	// Properties
	public GraphicsSettingEntryType entryType { /* [XID] */ /* 0x0000000189641680-0x00000001896416A0 */ get => default; /* [XID] */ /* 0x0000000189649000-0x0000000189649020 */ private set {} } // 0x0000000181A23EB0-0x0000000181A23F50 0x0000000181A23E00-0x0000000181A23EB0
	public string[] availableOptions { /* [XID] */ /* 0x00000001896505F0-0x0000000189650610 */ get => default; /* [XID] */ /* 0x0000000189657F30-0x0000000189657F50 */ set {} } // 0x0000000181A239B0-0x0000000181A23A50 0x0000000181A22900-0x0000000181A229B0
	public SimpleSafeFloat[] perfCostRatios { /* [XID] */ /* 0x000000018965F520-0x000000018965F540 */ get => default; /* [XID] */ /* 0x0000000189666DF0-0x0000000189666E10 */ private set {} } // 0x0000000181A22860-0x0000000181A22900 0x0000000181A23100-0x0000000181A231B0
	public SettingEntryDisplayType displayType { /* [XID] */ /* 0x000000018966E560-0x000000018966E580 */ get => default; /* [XID] */ /* 0x00000001896761E0-0x0000000189676200 */ private set {} } // 0x0000000181A227C0-0x0000000181A22860 0x0000000181A23D50-0x0000000181A23E00
	public float sliderMin { /* [XID] */ /* 0x000000018967DA80-0x000000018967DAA0 */ get => default; /* [XID] */ /* 0x00000001896850C0-0x00000001896850E0 */ private set {} } // 0x0000000181A23020-0x0000000181A23100 0x0000000181A238D0-0x0000000181A239B0
	public float sliderMax { /* [XID] */ /* 0x000000018968CBC0-0x000000018968CBE0 */ get => default; /* [XID] */ /* 0x0000000189694720-0x0000000189694740 */ private set {} } // 0x0000000181A235D0-0x0000000181A236B0 0x0000000181A23F50-0x0000000181A24030
	public float sliderInterval { /* [XID] */ /* 0x000000018969BD40-0x000000018969BD60 */ get => default; /* [XID] */ /* 0x00000001896A32E0-0x00000001896A3300 */ private set {} } // 0x0000000181A229B0-0x0000000181A22A90 0x0000000181A236B0-0x0000000181A23790
	public ConfigGraphicSettingEntrySortType sortOption { /* [XID] */ /* 0x00000001896AA730-0x00000001896AA750 */ get => default; /* [XID] */ /* 0x00000001896B17B0-0x00000001896B17D0 */ private set {} } // 0x0000000181A231B0-0x0000000181A23250 0x0000000181A21A50-0x0000000181A21B00

	// Constructors
	public ConfigGraphicsSettingEntry() {} // 0x0000000181A24970-0x0000000181A24A30

	// Methods
	// [XID] // 0x00000001896B9190-0x00000001896B91B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A24600-0x0000000181A24790
	// [XID] // 0x00000001896C05A0-0x00000001896C05C0
	public void InitEmpty() {} // 0x0000000181A23790-0x0000000181A238D0
	[BlackList] // 0x00000001896C7CD0-0x00000001896C7D10
	// [XID] // 0x00000001896C7CD0-0x00000001896C7D10
	public bool FromJson(JSONNode node) => default; // 0x0000000181A23250-0x0000000181A235D0
	// [XID] // 0x00000001896D20A0-0x00000001896D20C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181A21B00-0x0000000181A22350
	// [XID] // 0x00000001896D9990-0x00000001896D99B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8D31 */, bool useObjectPool = false /* Metadata: 0x00AF8D35 */) => default; // 0x0000000181A23A50-0x0000000181A23D50
	// [XID] // 0x000000018977F7C0-0x000000018977F7E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8D36 */, bool useObjectPool = false /* Metadata: 0x00AF8D3A */) => default; // 0x0000000181A22A90-0x0000000181A23020
	[BlackList] // 0x00000001896E8340-0x00000001896E8380
	// [XID] // 0x00000001896E8340-0x00000001896E8380
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181A22350-0x0000000181A22620
	// [XID] // 0x00000001896F2770-0x00000001896F2790
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A24030-0x0000000181A24600
	[BlackList] // 0x00000001896FA0F0-0x00000001896FA130
	// [XID] // 0x00000001896FA0F0-0x00000001896FA130
	public virtual void AutoAllocTypeFields() {} // 0x0000000181A22620-0x0000000181A226C0
	[BlackList] // 0x00000001897047B0-0x00000001897047F0
	// [XID] // 0x00000001897047B0-0x00000001897047F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181A226C0-0x0000000181A227C0
	[BlackList] // 0x000000018970F160-0x000000018970F1A0
	// [XID] // 0x000000018970F160-0x000000018970F1A0
	public virtual void ReturnToObjectPool() {} // 0x0000000181A248D0-0x0000000181A24970
	[BlackList] // 0x00000001897198F0-0x0000000189719930
	// [XID] // 0x00000001897198F0-0x0000000189719930
	public virtual void OnPoolAllocated() {} // 0x0000000181A24830-0x0000000181A248D0
	[BlackList] // 0x0000000189723B30-0x0000000189723B70
	// [XID] // 0x0000000189723B30-0x0000000189723B70
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181A24790-0x0000000181A24830
}

