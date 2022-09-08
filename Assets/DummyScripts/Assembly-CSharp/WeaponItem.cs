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

public sealed class WeaponItem : BagItem // TypeDefIndex: 20669
{
	// Fields
	public bool fullAwaken; // 0x68
	public Action onUseAwakenTexture; // 0x70
	public bool useAwakenTexture; // 0x78
	public Action onGoldWeapon; // 0x80
	private bool _isGoldWeapon; // 0x88
	private uint _goldAffixId; // 0x8C
	public static readonly float goldWeaponQuality; // 0x00

	// Properties
	public uint level { /* [XID] */ /* 0x00000001899CFEF0-0x00000001899CFF10 */ get => default; } // 0x000000018471C220-0x000000018471C2D0 
	public uint exp { /* [XID] */ /* 0x00000001899D7410-0x00000001899D7430 */ get => default; } // 0x000000018471C590-0x000000018471C640 
	public uint breakLevel { /* [XID] */ /* 0x00000001899DE7B0-0x00000001899DE7D0 */ get => default; } // 0x000000018471C640-0x000000018471C6F0 
	public MapField<uint, uint> affixMap { /* [XID] */ /* 0x00000001899E64B0-0x00000001899E64D0 */ get => default; } // 0x000000018471B580-0x000000018471B630 
	public WeaponExcelConfig excelConfig { /* [XID] */ /* 0x00000001899EDA00-0x00000001899EDA20 */ get => default; } // 0x000000018471B170-0x000000018471B250 
	public uint cost { /* [XID] */ /* 0x00000001899F53F0-0x00000001899F5410 */ get => default; } // 0x000000018471C080-0x000000018471C120 
	public override uint rankLevel { /* [XID] */ /* 0x00000001899FCA50-0x00000001899FCA70 */ get => default; } // 0x000000018471BAF0-0x000000018471BBB0 
	public uint maxBreakLevel { /* [XID] */ /* 0x0000000189A3DBD0-0x0000000189A3DBF0 */ get => default; } // 0x000000018471B8D0-0x000000018471BAF0 
	public uint awakenLevel { /* [XID] */ /* 0x0000000189A45350-0x0000000189A45370 */ get => default; } // 0x000000018471AEC0-0x000000018471B020 
	public uint maxAwakenLevel { /* [XID] */ /* 0x0000000189A4CA40-0x0000000189A4CA60 */ get => default; } // 0x000000018471C120-0x000000018471C220 
	private int affixIDForAwaken { /* [XID] */ /* 0x0000000189A542B0-0x0000000189A542D0 */ get => default; } // 0x000000018471B020-0x000000018471B170 

	// Constructors
	public WeaponItem() {} // 0x000000018471C820-0x000000018471C890
	static WeaponItem() {} // 0x000000018471C7C0-0x000000018471C820

	// Methods
	// [XID] // 0x0000000189A03F40-0x0000000189A03F60
	public EquipAffixExcelConfig GetGoldAffixConfig() => default; // 0x000000018471C3C0-0x000000018471C4E0
	// [XID] // 0x0000000189A0B5F0-0x0000000189A0B610
	public List<EquipAffixExcelConfig> GetAffixConfigList() => default; // 0x000000018471BBB0-0x000000018471C080
	// [IDTag] // 0x0000000189A12D70-0x0000000189A12DB0
	// [XID] // 0x0000000189A12D70-0x0000000189A12DB0
	public float GetWeaponPropValue(FightPropType propType) => default; // 0x000000018471AD60-0x000000018471AEC0
	// [IDTag] // 0x0000000189A1D0D0-0x0000000189A1D110
	// [XID] // 0x0000000189A1D0D0-0x0000000189A1D110
	public float GetWeaponPropValue(int index) => default; // 0x000000018471AC60-0x000000018471AD60
	// [XID] // 0x0000000189A27500-0x0000000189A27520
	private float ComputeRealValue(int index) => default; // 0x000000018471B6B0-0x000000018471B8D0
	// [XID] // 0x0000000189A2ED20-0x0000000189A2ED40
	public float GetPromotePropAddValue(FightPropType propType, uint promoteLevel) => default; // 0x000000018471A860-0x000000018471AAC0
	// [XID] // 0x0000000189A365D0-0x0000000189A365F0
	public static float ComputeCurveValue(float src, GrowCurveType type, WeaponCurveExcelConfig curve) => default; // 0x000000018471B390-0x000000018471B580
	// [XID] // 0x0000000189A5BCE0-0x0000000189A5BD00
	public override void Refresh(Item item) {} // 0x000000018471A790-0x000000018471A860
	// [XID] // 0x0000000189A63430-0x0000000189A63450
	protected override void Recycle() {} // 0x000000018471B250-0x000000018471B2F0
	// [XID] // 0x0000000189A6AF50-0x0000000189A6AF70
	private void RefreshFullAwaken() {} // 0x000000018471AAC0-0x000000018471AC60
	// [XID] // 0x0000000189A725E0-0x0000000189A72600
	private void RefreshAwakenTexture() {} // 0x000000018471C6F0-0x000000018471C7C0
	// [XID] // 0x0000000189A7A230-0x0000000189A7A250
	private void SetGoldWeapon(bool isGoldWeapon, uint goldAffixId) {} // 0x000000018471C2D0-0x000000018471C3C0
	// [XID] // 0x00000001895F1340-0x00000001895F1360
	public bool IsGoldWeapon() => default; // 0x000000018471C4E0-0x000000018471C590
	// [XID] // 0x0000000189A89150-0x0000000189A89170
	public uint goldAffixId() => default; // 0x000000018471B2F0-0x000000018471B390
}

