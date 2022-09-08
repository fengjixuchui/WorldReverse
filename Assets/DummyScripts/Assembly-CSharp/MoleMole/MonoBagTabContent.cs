/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoBagTabContent : MonoBehaviour // TypeDefIndex: 30407
	{
		// Fields
		private Action<BagItemSlot> _onSelectedItemChanged; // 0x18
		private Action<BagItemSlot> _onItemClicked; // 0x20
		private Action<BagItemSlot> _onItemLongPressed; // 0x28
		private List<BagItemSlot> _slotDataList; // 0x30
		private int _slotCount; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _gridScroller; // 0x40
		private int _selectedSlotIndex; // 0x48
		private List<uint> _highLightItem; // 0x50
		private Dictionary<uint, int> _markedItem; // 0x58
		private HashSet<ulong> _destroyModeHighLightItemGuid; // 0x60
		private HashSet<ulong> _destroyModeMarkedItemGuid; // 0x68
		private HashSet<ulong> _miracleRingModeHighLightItemGuid; // 0x70
		private HashSet<ulong> _miracleRingModeMarkedItemGuid; // 0x78
		private bool _isMarkShowMinusIcon; // 0x80
		private bool _isDestroyMode; // 0x81
		private bool _isMiracleRingMode; // 0x82
		public bool showNewCornerMark; // 0x83
		public bool showBuffIcon; // 0x84
	
		// Properties
		public Action<BagItemSlot> onSelectedItemChanged { /* [XID] */ /* 0x0000000189785BF0-0x0000000189785C10 */ set {} } // 0x00000001848F5140-0x00000001848F51F0
		public Action<BagItemSlot> onItemClicked { /* [XID] */ /* 0x000000018978D350-0x000000018978D370 */ set {} } // 0x00000001848F4FE0-0x00000001848F5090
		public Action<BagItemSlot> onItemLongPressed { /* [XID] */ /* 0x00000001897946B0-0x00000001897946D0 */ set {} } // 0x00000001848F5090-0x00000001848F5140
		public HashSet<ulong> destroyModeHighLightItemGuid { /* [XID] */ /* 0x000000018979CB40-0x000000018979CB60 */ get => default; /* [XID] */ /* 0x00000001897A3FA0-0x00000001897A3FC0 */ set {} } // 0x00000001848F45E0-0x00000001848F4680 0x00000001848F4B10-0x00000001848F4BC0
		public HashSet<ulong> destroyModeMarkedItemGuid { /* [XID] */ /* 0x00000001897AB520-0x00000001897AB540 */ get => default; /* [XID] */ /* 0x00000001897B3310-0x00000001897B3330 */ set {} } // 0x00000001848F4680-0x00000001848F4720 0x00000001848F4BC0-0x00000001848F4C70
		public HashSet<ulong> miracleRingModeHighLightItemGuid { /* [XID] */ /* 0x00000001897BB230-0x00000001897BB250 */ get => default; /* [XID] */ /* 0x00000001897C2A10-0x00000001897C2A30 */ set {} } // 0x00000001848F4930-0x00000001848F49D0 0x00000001848F4E80-0x00000001848F4F30
		public HashSet<ulong> miracleRingModeMarkedItemGuid { /* [XID] */ /* 0x00000001897CA230-0x00000001897CA250 */ get => default; /* [XID] */ /* 0x00000001897D18D0-0x00000001897D18F0 */ set {} } // 0x00000001848F49D0-0x00000001848F4A70 0x00000001848F4F30-0x00000001848F4FE0
		public bool isMarkShowMinusIcon { /* [XID] */ /* 0x00000001897D96F0-0x00000001897D9710 */ get => default; /* [XID] */ /* 0x00000001897E0A70-0x00000001897E0A90 */ set {} } // 0x00000001848F47D0-0x00000001848F4880 0x00000001848F4D20-0x00000001848F4DD0
		public bool isDestroyMode { /* [XID] */ /* 0x00000001897E8130-0x00000001897E8150 */ get => default; /* [XID] */ /* 0x00000001897EFDD0-0x00000001897EFDF0 */ set {} } // 0x00000001848F4720-0x00000001848F47D0 0x00000001848F4C70-0x00000001848F4D20
		public bool isMiracleRingMode { /* [XID] */ /* 0x00000001897F75C0-0x00000001897F75E0 */ get => default; /* [XID] */ /* 0x00000001897FECD0-0x00000001897FECF0 */ set {} } // 0x00000001848F4880-0x00000001848F4930 0x00000001848F4DD0-0x00000001848F4E80
		public int slotCount { /* [XID] */ /* 0x0000000189806410-0x0000000189806430 */ get => default; } // 0x00000001848F4A70-0x00000001848F4B10 
	
		// Constructors
		public MonoBagTabContent() {} // 0x00000001848F4500-0x00000001848F45E0
	
		// Methods
		// [XID] // 0x000000018980DAB0-0x000000018980DAD0
		private void Update() {} // 0x00000001848F3EA0-0x00000001848F4500
		// [XID] // 0x0000000189815290-0x00000001898152B0
		public void Setup(List<BagItemSlot> slotList, ulong selectGuid = 0 /* Metadata: 0x00B10CC5 */, List<uint> highLightItem = null, Dictionary<uint, int> markedItem = null, Vector2? scrollPosition = default) {} // 0x00000001848F36E0-0x00000001848F3990
		// [XID] // 0x000000018981CC90-0x000000018981CCB0
		private void Clear() {} // 0x00000001848F1CF0-0x00000001848F1D90
		// [XID] // 0x00000001898240D0-0x00000001898240F0
		private void CheckSlotSelect(ulong guid) {} // 0x00000001848F2C10-0x00000001848F2D50
		// [XID] // 0x000000018982BAD0-0x000000018982BAF0
		public BagItemSlot GetSelectedBagItemSlot() => default; // 0x00000001848F2370-0x00000001848F2480
		// [XID] // 0x00000001898330B0-0x00000001898330D0
		public Vector2 GetScrollPosition() => default; // 0x00000001848F22B0-0x00000001848F2370
		// [XID] // 0x000000018983A560-0x000000018983A580
		public void SetScrollPosition(Vector2 scrollPosition) {} // 0x00000001848F3600-0x00000001848F36E0
		// [XID] // 0x0000000189841B60-0x0000000189841B80
		private void RefreshSlot(Transform trans, int index) {} // 0x00000001848F1D90-0x00000001848F21A0
		// [XID] // 0x0000000189849070-0x0000000189849090
		private void UpdateHighLight(uint itemId, MonoBagProxySlot slotInstance) {} // 0x00000001848F2660-0x00000001848F27E0
		// [XID] // 0x00000001898507F0-0x0000000189850810
		private void UpdateHighLightDestroyMode(ulong guid, MonoBagProxySlot slotInstance) {} // 0x00000001848F2D50-0x00000001848F2EB0
		// [XID] // 0x0000000189857BC0-0x0000000189857BE0
		private void UpdateHighLightMiracleRingMode(ulong guid, MonoBagProxySlot slotInstance) {} // 0x00000001848F1AF0-0x00000001848F1C50
		// [XID] // 0x000000018985EC70-0x000000018985EC90
		private void UpdateMarkAndMinus(uint itemId, MonoBagProxySlot slotInstance) {} // 0x00000001848F27E0-0x00000001848F2930
		// [XID] // 0x0000000189866410-0x0000000189866430
		private void UpdateMarkAndMinusDestroyMode(ulong guid, MonoBagProxySlot slotInstance) {} // 0x00000001848F1220-0x00000001848F1340
		// [XID] // 0x000000018986DD40-0x000000018986DD60
		private void UpdateMarkAndMinusMiracleRingMode(ulong guid, MonoBagProxySlot slotInstance) {} // 0x00000001848F2AF0-0x00000001848F2C10
		// [XID] // 0x00000001898750E0-0x0000000189875100
		private string GetEquipedAvatarName(ulong equipGuid) => default; // 0x00000001848F2930-0x00000001848F2AF0
		// [XID] // 0x000000018987CD50-0x000000018987CD70
		public void UpdateSlots(List<BagItemSlot> slotList, Dictionary<int, bool> slotDirtyDictionary) {} // 0x00000001848F3990-0x00000001848F3EA0
		// [XID] // 0x0000000189883CF0-0x0000000189883D10
		public void FreeCurrentSelectedSlot() {} // 0x00000001848F1C50-0x00000001848F1CF0
		// [XID] // 0x000000018988B390-0x000000018988B3B0
		private void SelectSlotBySlotIndex(int index, bool selected) {} // 0x00000001848F1560-0x00000001848F16E0
		// [XID] // 0x0000000189892AD0-0x0000000189892AF0
		private void OnItemClicked(int index) {} // 0x00000001848F19F0-0x00000001848F1AF0
		// [XID] // 0x000000018989A150-0x000000018989A170
		private void OnItemLongPressed(int index) {} // 0x00000001848F1340-0x00000001848F1440
		// [XID] // 0x00000001898A1410-0x00000001898A1430
		private void OnSlotClicked(int index) {} // 0x00000001848F16E0-0x00000001848F19F0
		// [XID] // 0x00000001898A8C80-0x00000001898A8CA0
		public void SelectPrevSlot() {} // 0x00000001848F33B0-0x00000001848F34D0
		// [XID] // 0x00000001898B0600-0x00000001898B0620
		public void SelectNextSlot() {} // 0x00000001848F3290-0x00000001848F33B0
		// [XID] // 0x00000001898B7BF0-0x00000001898B7C10
		public void SelectUpwardSlot() {} // 0x00000001848F34D0-0x00000001848F3600
		// [XID] // 0x00000001898BF1C0-0x00000001898BF1E0
		public void SelectBelowSlot() {} // 0x00000001848F3130-0x00000001848F3290
		// [XID] // 0x00000001898C6B60-0x00000001898C6B80
		public BagItemSlot GetSlotByItemId(uint item_id, out MonoBagProxySlot monoSlot) {
			monoSlot = default;
			return default;
		} // 0x00000001848F2480-0x00000001848F2660
		// [XID] // 0x00000001898CE140-0x00000001898CE160
		public void ClearSelectedSlotSelectedView() {} // 0x00000001848F1440-0x00000001848F1560
		// [XID] // 0x00000001898D5BB0-0x00000001898D5BD0
		public void RecoverySelectedSlotSelectedView() {} // 0x00000001848F2EB0-0x00000001848F2FD0
		// [XID] // 0x00000001898DD880-0x00000001898DD8A0
		public void ResetSelected() {} // 0x00000001848F3080-0x00000001848F3130
		// [XID] // 0x00000001898E50B0-0x00000001898E50D0
		public MonoBagProxySlot GetCurrentProxySlot() => default; // 0x00000001848F21A0-0x00000001848F22B0
		// [XID] // 0x00000001898EC920-0x00000001898EC940
		public void RefreshCurrent() {} // 0x00000001848F2FD0-0x00000001848F3080
	}
}
