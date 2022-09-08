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

public sealed class BagManager : BaseBagManager // TypeDefIndex: 20654
{
	// Fields
	private Dictionary<EquipType, List<BagItemSlot>> _equipSlotDic; // 0x60
	private Dictionary<WeaponType, List<BagItemSlot>> _weaponSlotDic; // 0x68
	private Dictionary<MaterialType, List<BagItemSlot>> _materialSlotDic; // 0x70
	private Dictionary<uint, List<BagItemSlot>> _relicSet2listDic; // 0x78
	private Dictionary<uint, List<BagItemSlot>> _furnitureSet2listDic; // 0x80
	private UserLocalDataItem userLocalData; // 0x88
	private int _currTab; // 0x90
	private SortType _weaponSortType; // 0x94
	private SortType _relicSortType; // 0x98
	private bool _isWeaponAscend; // 0x9C
	private bool _isRelicAscend; // 0x9D

	// Properties
	public override StoreType storeType { /* [XID] */ /* 0x00000001896B4AD0-0x00000001896B4AF0 */ get => default; } // 0x0000000183B8DFD0-0x0000000183B8E070 
	public int currTab { /* [XID] */ /* 0x00000001896BBCE0-0x00000001896BBD00 */ get => default; /* [XID] */ /* 0x00000001896C31A0-0x00000001896C31C0 */ set {} } // 0x0000000183B8E0D0-0x0000000183B8E170 0x0000000183B8ECB0-0x0000000183B8ED60

	// Constructors
	public BagManager() {} // 0x0000000183B8F750-0x0000000183B8F920

	// Methods
	// [XID] // 0x00000001896CA6D0-0x00000001896CA6F0
	public List<BagItemSlot> GetBagItemListByEquipType(EquipType equipType) => default; // 0x0000000183B8C540-0x0000000183B8C670
	// [XID] // 0x00000001896D1D80-0x00000001896D1DA0
	public List<BagItemSlot> GetWeaponSlotList(WeaponType weaponType) => default; // 0x0000000183B8CCA0-0x0000000183B8CDF0
	// [XID] // 0x00000001896D95D0-0x00000001896D95F0
	public List<BagItemSlot> GetReliquarySlotListBySet(uint setID, bool sort = false /* Metadata: 0x00AFDF84 */) => default; // 0x0000000183B8CDF0-0x0000000183B8CFA0
	// [XID] // 0x00000001896E0D90-0x00000001896E0DB0
	public List<BagItemSlot> GetFurnitureSlotListBySet(uint setID, bool sort = false /* Metadata: 0x00AFDF85 */) => default; // 0x0000000183B8D170-0x0000000183B8D2F0
	// [XID] // 0x00000001896E8040-0x00000001896E8060
	public List<BagItemSlot> GetMaterialSlotList(MaterialType materialType) => default; // 0x0000000183B8DE10-0x0000000183B8DF60
	// [XID] // 0x00000001896EF6E0-0x00000001896EF700
	public bool HasMaterial(MaterialType type) => default; // 0x0000000183B8E410-0x0000000183B8E510
	// [XID] // 0x00000001896F6FF0-0x00000001896F7010
	protected override void AddItemSlotInternal(BagItemSlot itemSlot) {} // 0x0000000183B8CA60-0x0000000183B8CC20
	// [XID] // 0x00000001896FE960-0x00000001896FE980
	private void AddItemSlotByEquipType(BagItemSlot itemSlot) {} // 0x0000000183B8E5C0-0x0000000183B8E820
	// [XID] // 0x0000000189705C60-0x0000000189705C80
	private void AddWeaponSlot(BagItemSlot itemSlot) {} // 0x0000000183B8E170-0x0000000183B8E2C0
	// [XID] // 0x000000018970D5F0-0x000000018970D610
	private void AddReliquarySlot(BagItemSlot itemSlot) {} // 0x0000000183B8E2C0-0x0000000183B8E410
	// [XID] // 0x00000001897149F0-0x0000000189714A10
	private void AddFurnitureSlot(BagItemSlot itemSlot) {} // 0x0000000183B8D5D0-0x0000000183B8D7C0
	// [XID] // 0x000000018971C480-0x000000018971C4A0
	private void AddMaterialSlot(BagItemSlot itemSlot) {} // 0x0000000183B8C670-0x0000000183B8C7C0
	// [XID] // 0x0000000189723870-0x0000000189723890
	protected override void RemoveItemSlotInternal(BagItemSlot itemSlot) {} // 0x0000000183B8D2F0-0x0000000183B8D4A0
	// [XID] // 0x000000018972AFF0-0x000000018972B010
	private void RemoveEquipSlot(BagItemSlot itemSlot) {} // 0x0000000183B8C370-0x0000000183B8C540
	// [XID] // 0x0000000189732780-0x00000001897327A0
	private void RemoveWeaponSlot(BagItemSlot itemSlot) {} // 0x0000000183B8C7C0-0x0000000183B8C910
	// [XID] // 0x0000000189739EC0-0x0000000189739EE0
	private void RemoveReliquarySlot(BagItemSlot itemSlot) {} // 0x0000000183B8D4A0-0x0000000183B8D5D0
	// [XID] // 0x0000000189741A60-0x0000000189741A80
	private void RemoveFurnitureSlot(BagItemSlot itemSlot) {} // 0x0000000183B8CFA0-0x0000000183B8D170
	// [XID] // 0x0000000189749360-0x0000000189749380
	private void RemoveMaterialSlot(BagItemSlot itemSlot) {} // 0x0000000183B8D8D0-0x0000000183B8D9F0
	// [XID] // 0x00000001897507E0-0x0000000189750800
	public override void RefreshAll(PlayerStoreNotify notify) {} // 0x0000000183B8F4C0-0x0000000183B8F620
	// [XID] // 0x0000000189757CD0-0x0000000189757CF0
	public override void InitByLocalData() {} // 0x0000000183B8D9F0-0x0000000183B8DB10
	// [XID] // 0x000000018975F790-0x000000018975F7B0
	public void ToggleSortAscend(ItemType itemType) {} // 0x0000000183B8F0C0-0x0000000183B8F1D0
	// [XID] // 0x0000000189766C00-0x0000000189766C20
	public SortType GetSortType(ItemType itemType) => default; // 0x0000000183B8F3D0-0x0000000183B8F4C0
	// [XID] // 0x000000018976E1A0-0x000000018976E1C0
	public void SetSortType(ItemType itemType, SortType sortType) {} // 0x0000000183B8D7C0-0x0000000183B8D8D0
	// [IDTag] // 0x0000000189775A20-0x0000000189775A60
	// [XID] // 0x0000000189775A20-0x0000000189775A60
	public void SortMaterial() {} // 0x0000000183B8E950-0x0000000183B8EAB0
	// [XID] // 0x0000000189780160-0x0000000189780180
	private void SortList(ItemType itemType) {} // 0x0000000183B8C910-0x0000000183B8CA60
	// [IDTag] // 0x0000000189787A20-0x0000000189787A60
	// [XID] // 0x0000000189787A20-0x0000000189787A60
	public static void SortMaterial(List<BagItemSlot> list) {} // 0x0000000183B8E820-0x0000000183B8E950
	// [IDTag] // 0x0000000189791FC0-0x0000000189792000
	// [XID] // 0x0000000189791FC0-0x0000000189792000
	public static void SortRelicList(List<BagItemSlot> list, bool isAscend, FightPropType propType) {} // 0x0000000183B8DC90-0x0000000183B8DE10
	// [IDTag] // 0x000000018979D290-0x000000018979D2D0
	// [XID] // 0x000000018979D290-0x000000018979D2D0
	public static void SortRelicList(List<BagItemSlot> list, bool isAscend, SortType sortType) {} // 0x0000000183B8DB10-0x0000000183B8DC90
	// [XID] // 0x00000001897A7500-0x00000001897A7520
	public static void SortWeaponList(List<BagItemSlot> list, bool isAscend, SortType sortType) {} // 0x0000000183B8F1D0-0x0000000183B8F350
	// [XID] // 0x00000001897AF010-0x00000001897AF030
	private static float CalculatePropValue(ReliquaryItem item, FightPropType propType) => default; // 0x0000000183B8F620-0x0000000183B8F750
	// [XID] // 0x00000001897B6CA0-0x00000001897B6CC0
	private int CompareReliquaryItem(BagItemSlot x, BagItemSlot y) => default; // 0x0000000183B8ED60-0x0000000183B8F040
	// [XID] // 0x00000001897BECD0-0x00000001897BECF0
	private void DebugAdd(bool enable = false /* Metadata: 0x00AFDF86 */) {} // 0x0000000183B8E510-0x0000000183B8E5C0
}

