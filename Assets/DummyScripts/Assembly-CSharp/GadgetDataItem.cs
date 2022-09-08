/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetDataItem : DataItem // TypeDefIndex: 21458
{
	// Fields
	public uint configId; // 0x38
	public uint mapInstId; // 0x3C
	public uint groupId; // 0x40
	public uint markFlag; // 0x44
	public GadgetBornType bornType; // 0x48
	public Item item; // 0x50
	public uint gatherItemId; // 0x58
	public bool isForbitGuest; // 0x5C
	public bool isShowCutscene; // 0x5D
	public uint gadgetState; // 0x60
	public bool isEnableInteract; // 0x64
	public uint authorityPeerId; // 0x68
	public PlatformInfo platformInfo; // 0x70
	public uint interactId; // 0x78
	public bool isOpenedStatue; // 0x7C
	public EntityClientData entityClientData; // 0x80
	public uint mpPlayId; // 0x88
	public uint draftId; // 0x8C
	public List<uint> optionList; // 0x90
	public List<uint> interactUids; // 0x98
	private OpenData? _openData; // 0xA0
	private FoundationData? _foundationData; // 0xE8

	// Properties
	public OpenData? openData { /* [XID] */ /* 0x000000018986F800-0x000000018986F820 */ get => default; /* [XID] */ /* 0x0000000189876DD0-0x0000000189876DF0 */ set {} } // 0x00000001843A44F0-0x00000001843A4680 0x00000001843A4880-0x00000001843A4B80
	public bool isOpenable { /* [XID] */ /* 0x000000018987E8C0-0x000000018987E8E0 */ get => default; } // 0x00000001843A4D60-0x00000001843A4F80 
	public FoundationData? foundationData { /* [XID] */ /* 0x000000018988D080-0x000000018988D0A0 */ get => default; /* [XID] */ /* 0x00000001898946F0-0x0000000189894710 */ set {} } // 0x00000001843A41A0-0x00000001843A4270 0x00000001843A3F70-0x00000001843A4030

	// Nested types
	public struct OpenData // TypeDefIndex: 21459
	{
		// Fields
		public uint resinCost; // 0x00
		public uint configId; // 0x04
		public uint lifeTime; // 0x08
		public uint blossomRefreshType; // 0x0C
		public uint blossomRefreshId; // 0x10
		public List<uint> authorisedUIDList; // 0x18
		public List<uint> openableUID; // 0x20
		public SceneGadgetInfo.ContentOneofCase type; // 0x28
		public WeeklyBossResinDiscountInfoStruct weeklyBossResinDiscountInfo; // 0x2C

		// Methods
		// [IDTag] // 0x000000018989BCE0-0x000000018989BD20
		// [XID] // 0x000000018989BCE0-0x000000018989BD20
		public void Update(BossChestInfo info) {} // 0x00000001843BDDB0-0x00000001843BDEF0
		// [IDTag] // 0x00000001898A6380-0x00000001898A63C0
		// [XID] // 0x00000001898A6380-0x00000001898A63C0
		public void Update(BlossomChestInfo info) {} // 0x00000001843BDEF0-0x00000001843BE010
		// [IDTag] // 0x00000001898B0A80-0x00000001898B0AC0
		// [XID] // 0x00000001898B0A80-0x00000001898B0AC0
		public void Update(MpPlayRewardInfo info) {} // 0x00000001843BDBA0-0x00000001843BDDB0
		// [IDTag] // 0x00000001898BB4B0-0x00000001898BB4F0
		// [XID] // 0x00000001898BB4B0-0x00000001898BB4F0
		public void Update(GadgetGeneralRewardInfo info) {} // 0x00000001843BDA80-0x00000001843BDBA0
		// [XID] // 0x00000001898C57D0-0x00000001898C57F0
		public void UpateOpenableUID(IList<uint> list) {} // 0x00000001843BE130-0x00000001843BE160
		// [XID] // 0x00000001898CCEB0-0x00000001898CCED0
		public void UpateAuthorisedUIDList(IList<uint> list) {} // 0x00000001843BE010-0x00000001843BE130
	}

	public struct FoundationData // TypeDefIndex: 21460
	{
		// Fields
		public FoundationInfo foundationInfo; // 0x00

		// Methods
		// [XID] // 0x00000001898D4810-0x00000001898D4830
		public void Update(FoundationInfo info) {} // 0x00000001843BD8D0-0x00000001843BDA80
		// [XID] // 0x00000001898DC210-0x00000001898DC230
		public bool IsInteractable() => default; // 0x00000001843BD770-0x00000001843BD8D0
	}

	// Constructors
	public GadgetDataItem() {} // 0x00000001843A52A0-0x00000001843A5400

	// Methods
	// [XID] // 0x00000001898438A0-0x00000001898438C0
	protected override void ClearFightProps() {} // 0x00000001843A5020-0x00000001843A51C0
	// [XID] // 0x000000018984ADF0-0x000000018984AE10
	protected override void UpdateFightProp(FightPropType type, float value, float lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF838 */) {} // 0x00000001843A4270-0x00000001843A44F0
	// [XID] // 0x00000001898520D0-0x00000001898520F0
	protected override void UpdateNormalProp(PropType type, double value, double lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF83C */) {} // 0x00000001843A4680-0x00000001843A4880
	// [XID] // 0x0000000189859B30-0x0000000189859B50
	public override GroupEntityType TryGetGroupEntityType() => default; // 0x00000001843A4090-0x00000001843A4130
	// [XID] // 0x0000000189860BF0-0x0000000189860C10
	public override uint TryGetGroupId() => default; // 0x00000001843A4F80-0x00000001843A5020
	// [XID] // 0x0000000189868380-0x00000001898683A0
	public override uint TryGetMapInstId() => default; // 0x00000001843A4B80-0x00000001843A4C20
	// [XID] // 0x0000000189885D80-0x0000000189885DA0
	public void UpdateOptionList(IList<uint> options) {} // 0x00000001843A4C20-0x00000001843A4D60
}

