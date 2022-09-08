/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoWeaponChangeTip : MonoBehaviour // TypeDefIndex: 30487
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LabelGroup _costLabel; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LabelGroup[] _baseProperties; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LabelGroup[] _txtAffix; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoEquipNameChangeTip _nameChangeTip; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _needLevelText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _needLevelBg; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _needLevelRoot; // 0x58
	
		// Constructors
		public MonoWeaponChangeTip() {} // 0x00000001824A77E0-0x00000001824A7860
	
		// Methods
		// [XID] // 0x0000000189B54710-0x0000000189B54730
		public void UpdateByWeaponInfo(WeaponItem oldWeapon, WeaponItem newWeapon) {} // 0x00000001824A76E0-0x00000001824A77E0
		// [XID] // 0x0000000189B5C300-0x0000000189B5C320
		private void UpdatePropChange(WeaponItem oldWeapon, WeaponItem newWeapon) {} // 0x00000001824A6590-0x00000001824A6F70
		// [XID] // 0x0000000189B63900-0x0000000189B63920
		private void UpdateAffixChange(WeaponItem oldWeapon, WeaponItem newWeapon) {} // 0x00000001824A6F70-0x00000001824A7410
		// [XID] // 0x0000000189B6B0A0-0x0000000189B6B0C0
		private void SetColorAndAnimation(LabelGroup labGrp, Color color) {} // 0x00000001824A60B0-0x00000001824A6330
		// [XID] // 0x0000000189B726E0-0x0000000189B72700
		private void UpdateWeaponName(WeaponItem oldWeapon, WeaponItem newWeapon) {} // 0x00000001824A6330-0x00000001824A6590
		// [XID] // 0x0000000189B79C30-0x0000000189B79C50
		public void SetUseLevel(uint useLevel) {} // 0x00000001824A7410-0x00000001824A76E0
	}
}
