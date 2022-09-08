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
	public class MonoAdventureMonsterPanel : MonoBehaviour // TypeDefIndex: 30684
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoGridScroller _monsterScroller; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _locationText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _locationRoot; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _monsterIcon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _lockText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockDesc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _lockRewardScorller; // 0x60
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _detailRoot; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noInfoRoot; // 0x70
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoMaterialItemRow _worldStaminaRow; // 0x78
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _rewardComsumeGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _consumeItemIcon; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _consumeItemCountText; // 0x90
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _cooldownTipsGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cooldownTipsText; // 0xA0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _rewardTipsGrp; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardTipsText; // 0xB0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _occupiedTipGrp; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _occupiedTipText; // 0xC0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _grpNum; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpHalfNum; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _halfNumNewTxt; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _halfNumOldTxt; // 0xE0
	
		// Properties
		public MonoGridScroller monsterScroller { /* [XID] */ /* 0x000000018978EBB0-0x000000018978EBD0 */ get => default; } // 0x0000000184C86970-0x0000000184C86A10 
		public UnityEngine.UI.Text nameText { /* [XID] */ /* 0x0000000189796340-0x0000000189796360 */ get => default; } // 0x0000000184C86A10-0x0000000184C86AB0 
		public UnityEngine.UI.Text locationText { /* [XID] */ /* 0x000000018979E410-0x000000018979E430 */ get => default; } // 0x0000000184C86650-0x0000000184C866F0 
		public GameObject locationRoot { /* [XID] */ /* 0x00000001897A5B90-0x00000001897A5BB0 */ get => default; } // 0x0000000184C865B0-0x0000000184C86650 
		public UnityEngine.UI.Text descText { /* [XID] */ /* 0x00000001897AD100-0x00000001897AD120 */ get => default; } // 0x0000000184C86310-0x0000000184C863B0 
		public MonoSimpleReusableList monsterIcon { /* [XID] */ /* 0x00000001897B5130-0x00000001897B5150 */ get => default; } // 0x0000000184C868D0-0x0000000184C86970 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x00000001897BCDA0-0x00000001897BCDC0 */ get => default; } // 0x0000000184C86CB0-0x0000000184C86D50 
		public UnityEngine.UI.Text lockText { /* [XID] */ /* 0x00000001897C4120-0x00000001897C4140 */ get => default; } // 0x0000000184C86830-0x0000000184C868D0 
		public UnityEngine.UI.Text lockDesc { /* [XID] */ /* 0x00000001897CB9A0-0x00000001897CB9C0 */ get => default; } // 0x0000000184C866F0-0x0000000184C86790 
		public MonoGridScroller lockRewardScorller { /* [XID] */ /* 0x00000001897D32B0-0x00000001897D32D0 */ get => default; } // 0x0000000184C86790-0x0000000184C86830 
		public GameObject detailRoot { /* [XID] */ /* 0x00000001897DAD30-0x00000001897DAD50 */ get => default; } // 0x0000000184C863B0-0x0000000184C86450 
		public GameObject noInfoRoot { /* [XID] */ /* 0x00000001897E2440-0x00000001897E2460 */ get => default; } // 0x0000000184C86AB0-0x0000000184C86B50 
		public MonoMaterialItemRow worldStaminaRow { /* [XID] */ /* 0x00000001897E9BB0-0x00000001897E9BD0 */ get => default; } // 0x0000000184C86E20-0x0000000184C86EC0 
		public bool showRewardConsumeGrp { /* [XID] */ /* 0x00000001897F1870-0x00000001897F1890 */ set {} } // 0x0000000184C87440-0x0000000184C87520
		public Image rewardConsumeItemIcon { /* [XID] */ /* 0x00000001897F8FA0-0x00000001897F8FC0 */ get => default; } // 0x0000000184C86C00-0x0000000184C86CB0 
		public string rewardConsumeItemCountString { /* [XID] */ /* 0x00000001898005B0-0x00000001898005D0 */ set {} } // 0x0000000184C87060-0x0000000184C87130
		public bool showCooldownTipsGrp { /* [XID] */ /* 0x000000018980F4F0-0x000000018980F510 */ get => default; /* [XID] */ /* 0x0000000189807C30-0x0000000189807C50 */ set {} } // 0x0000000184C86D50-0x0000000184C86E20 0x0000000184C87200-0x0000000184C872E0
		public string cooldownTipsString { /* [XID] */ /* 0x0000000189816BA0-0x0000000189816BC0 */ set {} } // 0x0000000184C86EC0-0x0000000184C86F90
		public bool showRewardTipsGrp { /* [XID] */ /* 0x000000018981E450-0x000000018981E470 */ set {} } // 0x0000000184C87520-0x0000000184C87600
		public string rewardTipsString { /* [XID] */ /* 0x0000000189825910-0x0000000189825930 */ set {} } // 0x0000000184C87130-0x0000000184C87200
		public RectTransform occupiedTipGrp { /* [XID] */ /* 0x000000018982D0C0-0x000000018982D0E0 */ get => default; } // 0x0000000184C86B50-0x0000000184C86C00 
		public string occupiedTipString { /* [XID] */ /* 0x0000000189834800-0x0000000189834820 */ set {} } // 0x0000000184C86F90-0x0000000184C87060
		public UnityEngine.UI.Text halfNumNewTxt { /* [XID] */ /* 0x000000018983BE70-0x000000018983BE90 */ get => default; } // 0x0000000184C86450-0x0000000184C86500 
		public UnityEngine.UI.Text halfNumOldTxt { /* [XID] */ /* 0x00000001898434A0-0x00000001898434C0 */ get => default; } // 0x0000000184C86500-0x0000000184C865B0 
		public bool showHalfNum { /* [XID] */ /* 0x000000018984A9C0-0x000000018984A9E0 */ set {} } // 0x0000000184C872E0-0x0000000184C87440
	
		// Constructors
		public MonoAdventureMonsterPanel() {} // 0x0000000184C86210-0x0000000184C86310
	}
}
