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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	internal class MonoMechanicusGearLevelUpDialog : MonoUIProxy // TypeDefIndex: 31122
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _level; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _effectTips; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _effectTipsGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _upgrade; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<MonoMechanicusLevelUpItem> _propItemList; // 0x70
	
		// Properties
		public List<MonoMechanicusLevelUpItem> propItemList { /* [XID] */ /* 0x0000000189B6F450-0x0000000189B6F470 */ get => default; } // 0x000000018493B060-0x000000018493B100 
		public bool ShowEffectTips { /* [XID] */ /* 0x0000000189B76AB0-0x0000000189B76AD0 */ set {} } // 0x000000018493B100-0x000000018493B1F0
		public string effectTips { /* [XID] */ /* 0x0000000189B7E060-0x0000000189B7E080 */ set {} } // 0x000000018493B1F0-0x000000018493B2D0
		public string upgrade { /* [XID] */ /* 0x0000000189B85C60-0x0000000189B85C80 */ set {} } // 0x000000018493B410-0x000000018493B4F0
		public Image gearIcon { /* [XID] */ /* 0x0000000189B8CC50-0x0000000189B8CC70 */ get => default; } // 0x000000018493AFC0-0x000000018493B060 
		public uint level { /* [XID] */ /* 0x0000000189B94480-0x0000000189B944A0 */ set {} } // 0x000000018493B2D0-0x000000018493B410
		public Button BtnClose { /* [XID] */ /* 0x0000000189B9BB70-0x0000000189B9BB90 */ get => default; } // 0x000000018493AF00-0x000000018493AFC0 
	
		// Constructors
		public MonoMechanicusGearLevelUpDialog() {} // 0x000000018493AE90-0x000000018493AF00
	}
}
