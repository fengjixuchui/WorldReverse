/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WidgetSystemManager : GlobalManager // TypeDefIndex: 21381
{
	// Fields
	private Dictionary<uint, QuickWidgetBase> _materialId2WidgetDict; // 0x10
	private Dictionary<uint, List<uint>> _typeId2MaterialId; // 0x18
	private Dictionary<System.Type, JsonProcessor> _buildProcessorMap; // 0x30
	private HashSet<uint> _showBagRedPointWidgetSet; // 0x38
	private Dictionary<WidgetSlotTag, CoolDown> _slotCdDict; // 0x40
	private Dictionary<uint, uint> _cdMaterialToGroupDict; // 0x48
	private Dictionary<uint, CoolDown> _cdDict; // 0x50
	private List<uint> _reviveMaterialList; // 0x58
	private List<uint> _hpMaterialList; // 0x60
	private uint _lunchBoxMaterialId; // 0x68

	// Properties
	public ConfigMainWidgetToy MainJsonConfig { /* [XID] */ /* 0x0000000189BB7D20-0x0000000189BB7D60 */ get; /* [XID] */ /* 0x0000000189BC2DF0-0x0000000189BC2E30 */ private set; } // 0x0000000181985BA0-0x0000000181985C00 0x0000000181984F30-0x0000000181984F90
	public Dictionary<SimpleSafeUInt32, ConfigWidgetGadget> WidgetGadgetConfigMap { /* [XID] */ /* 0x0000000189BCD440-0x0000000189BCD480 */ get; /* [XID] */ /* 0x0000000189BD7850-0x0000000189BD7890 */ private set; } // 0x0000000181985230-0x0000000181985290 0x0000000181984400-0x0000000181984460
	private static string JSON_CONFIG_PATH { /* [XID] */ /* 0x00000001895EECE0-0x00000001895EED00 */ get => default; } // 0x0000000181984360-0x0000000181984400 
	public HashSet<uint> showBagRedPointWidgetSet { /* [XID] */ /* 0x00000001896052D0-0x00000001896052F0 */ get => default; } // 0x0000000181985190-0x0000000181985230 
	public List<uint> reviveMaterialList { /* [XID] */ /* 0x00000001896668B0-0x00000001896668D0 */ get => default; } // 0x0000000181984460-0x0000000181984500 
	public List<uint> hpMaterialList { /* [XID] */ /* 0x000000018966DFB0-0x000000018966DFD0 */ get => default; } // 0x0000000181985D70-0x0000000181985E10 
	public uint LunchBoxMaterialId { /* [XID] */ /* 0x0000000189675E20-0x0000000189675E40 */ get => default; } // 0x0000000181985E10-0x0000000181985F00 

	// Nested types
	private class TypeIdBase // TypeDefIndex: 21382
	{
		// Fields
		protected static uint _next; // 0x00

		// Constructors
		public TypeIdBase() {} // 0x00000001819A1FB0-0x00000001819A2010
		static TypeIdBase() {} // 0x00000001819A1F50-0x00000001819A1FB0
	}

	private class WidgetSystem<T> : TypeIdBase // TypeDefIndex: 21383
		where T : QuickWidgetBase, new()
	{
		// Fields
		private T _instance;

		// Properties
		public static uint TypeId { get; private set; }
		public T Instance { get => default; }

		// Constructors
		static WidgetSystem() {}
		public WidgetSystem() {}
	}

	private delegate void JsonProcessor(uint materialId, ConfigBaseWidgetToy baseConfig); // TypeDefIndex: 21384; 0x00000001819A1C00-0x00000001819A1DC0

	private class CoolDown // TypeDefIndex: 21385
	{
		// Properties
		public ulong finishTime { /* [XID] */ /* 0x00000001896B6120-0x00000001896B6160 */ get; /* [XID] */ /* 0x00000001896C00F0-0x00000001896C0130 */ set; } // 0x00000001819A13B0-0x00000001819A1410 0x00000001819A1350-0x00000001819A13B0
		public ulong cdTime { /* [XID] */ /* 0x00000001896CA5B0-0x00000001896CA5F0 */ get; /* [XID] */ /* 0x00000001896D4C80-0x00000001896D4CC0 */ set; } // 0x00000001819A1470-0x00000001819A14D0 0x00000001819A1640-0x00000001819A16A0
		public bool isUnderTimeScale { /* [XID] */ /* 0x00000001896DF540-0x00000001896DF580 */ get; /* [XID] */ /* 0x00000001896E99C0-0x00000001896E9A00 */ set; } // 0x00000001819A11D0-0x00000001819A1230 0x00000001819A1410-0x00000001819A1470

		// Constructors
		public CoolDown() {} // 0x00000001819A16A0-0x00000001819A1700

		// Methods
		// [XID] // 0x00000001896F3EC0-0x00000001896F3EE0
		public void Set(ulong nextUsableTime, ulong cdTime) {} // 0x00000001819A14D0-0x00000001819A1640
		// [XID] // 0x00000001896FB710-0x00000001896FB730
		public void Reset() {} // 0x00000001819A1230-0x00000001819A1350
	}

	// Constructors
	public WidgetSystemManager() {} // 0x00000001819866F0-0x00000001819868A0

	// Methods
	// [XID] // 0x0000000189B75890-0x0000000189B758B0
	private void BuildJsonProcessMap() {} // 0x0000000181984500-0x0000000181984CD0
	public List<uint> GetMaterialIdListOfWidget<T>()
		where T : QuickWidgetBase, new() => default;
	// [XID] // 0x0000000189B7CD30-0x0000000189B7CD50
	public QuickWidgetBase GetWidget(uint materialId) => default; // 0x0000000181983170-0x0000000181983230
	public T GetWidget<T>(uint materialId)
		where T : QuickWidgetBase, new() => default;
	// [XID] // 0x0000000189B84BD0-0x0000000189B84BF0
	public bool NeedShowBagRedPoint(uint materialID) => default; // 0x00000001819842A0-0x0000000181984360
	// [XID] // 0x0000000189B8B980-0x0000000189B8B9A0
	public ConfigWidgetGadget GetWidgetGadgetConfig(uint gadgetId) => default; // 0x0000000181986380-0x0000000181986560
	// [XID] // 0x0000000189B93170-0x0000000189B93190
	public override void Init() {} // 0x0000000181984F90-0x0000000181985040
	// [XID] // 0x0000000189B9A6C0-0x0000000189B9A6E0
	public override void Destroy() {} // 0x00000001819840A0-0x0000000181984140
	// [XID] // 0x0000000189BA1EB0-0x0000000189BA1ED0
	public override void ClearOnLevelDestroy() {} // 0x0000000181984000-0x00000001819840A0
	// [XID] // 0x0000000189BA92A0-0x0000000189BA92C0
	public override void ReloadRes() {} // 0x0000000181986650-0x00000001819866F0
	// [XID] // 0x0000000189BB0A30-0x0000000189BB0A50
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFF75D */) {} // 0x0000000181983F50-0x0000000181984000
	private List<uint> _GetMaterialIdListOfWidget<T>()
		where T : QuickWidgetBase, new() => default;
	// [XID] // 0x00000001895E73D0-0x00000001895E73F0
	private QuickWidgetBase _GetWidget(uint materialId) => default; // 0x0000000181986560-0x0000000181986650
	private T _GetWidget<T>(uint materialId)
		where T : QuickWidgetBase, new() => default;
	// [XID] // 0x00000001895F66A0-0x00000001895F66C0
	private void BuildFromJson() {} // 0x0000000181983320-0x0000000181983940
	private void BuildJsonProcessMap<T>(uint materialId, ConfigBaseWidgetToy baseConfig)
		where T : QuickWidgetBase, new() {}
	// [XID] // 0x00000001895FDA80-0x00000001895FDAA0
	public string DumpCurrentWidgetSystemInfo() => default; // 0x0000000181983940-0x0000000181983F50
	// [XID] // 0x000000018960CD20-0x000000018960CD40
	private void SetToShowRPList(uint materialID) {} // 0x0000000181983230-0x0000000181983320
	// [XID] // 0x0000000189614230-0x0000000189614250
	private bool _NeedShowBagRedPoint(uint materialID) => default; // 0x0000000181985040-0x0000000181985110
	// [XID] // 0x000000018961BC50-0x000000018961BC70
	private void ClearCDInfoWhenBackHome() {} // 0x0000000181985F00-0x00000001819861B0
	// [XID] // 0x00000001896231C0-0x00000001896231E0
	private void BuildCdGroupDict(Dictionary<SimpleSafeUInt32, ConfigWidgetCdGroup> jsonConfigMap) {} // 0x0000000181984CD0-0x0000000181984F30
	// [XID] // 0x000000018962A9C0-0x000000018962A9E0
	public void SetMaterialCdGroup(uint materialId, uint cdGroupId) {} // 0x00000001819858C0-0x0000000181985A30
	// [XID] // 0x0000000189632140-0x0000000189632160
	public ulong GetCDFinishTime(uint materialID) => default; // 0x0000000181985770-0x00000001819858C0
	// [XID] // 0x0000000189639BF0-0x0000000189639C10
	public ulong GetCDTime(uint materialID) => default; // 0x0000000181985290-0x00000001819853E0
	// [XID] // 0x0000000189641120-0x0000000189641140
	public void SetCDGroupFinishTime(uint groupId, ulong endTime, ulong cdTime = 0 /* Metadata: 0x00AFF75E */) {} // 0x00000001819861B0-0x0000000181986380
	// [XID] // 0x0000000189648A20-0x0000000189648A40
	public void SetCDGroupFinishTimeByMaterialId(uint materialId, ulong endTime, ulong cdTime = 0 /* Metadata: 0x00AFF766 */) {} // 0x0000000181985C00-0x0000000181985D70
	// [XID] // 0x0000000189650100-0x0000000189650120
	public void SetSlotCD(WidgetSlotTag tag, ulong endTime) {} // 0x0000000181985A30-0x0000000181985BA0
	// [XID] // 0x00000001896579F0-0x0000000189657A10
	public bool IsMaterialUnderTimeScale(uint materialId) => default; // 0x0000000181984140-0x00000001819842A0
	// [XID] // 0x000000018965F0C0-0x000000018965F0E0
	public void OnWidgetCoolDownNotify(RepeatedMessageField<WidgetCoolDownData> unGroupData, RepeatedMessageField<WidgetCoolDownData> groupData) {} // 0x00000001819853E0-0x0000000181985770
}

