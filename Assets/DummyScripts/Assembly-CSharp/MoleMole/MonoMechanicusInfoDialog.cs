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
	public class MonoMechanicusInfoDialog : MonoUIProxy // TypeDefIndex: 29768
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _itemScrollerRatio; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDialogTitle; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _menuTabList; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _showPanel; // 0x60
		// [Header] // 0x00000001896EF290-0x00000001896EF2F0
		[SerializeField] // 0x00000001896EF290-0x00000001896EF2F0
		[Space] // 0x00000001896EF290-0x00000001896EF2F0
		private GameObject _enemyInfoGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtEnemyTitle; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _enemyScroller; // 0x78
		// [Header] // 0x000000018970D1E0-0x000000018970D240
		[SerializeField] // 0x000000018970D1E0-0x000000018970D240
		[Space] // 0x000000018970D1E0-0x000000018970D240
		private GameObject _mapInfoGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMapTitle; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _mapImage; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _mapIconGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMapDesc; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _mapDescScroller; // 0xA8
		// [Header] // 0x0000000189741680-0x00000001897416E0
		[SerializeField] // 0x0000000189741680-0x00000001897416E0
		[Space] // 0x0000000189741680-0x00000001897416E0
		private GameObject _buildingInfoGrp; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _singlePlayerGrp; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtSinglePlayerName; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _singleBuildingScroller; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _dualPlayerGrp; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtPlayer1Name; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _player1BuildingScroller; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtPlayer2Name; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _player2BuildingScroller; // 0xF0
		// [Header] // 0x000000018978BE00-0x000000018978BE60
		[SerializeField] // 0x000000018978BE00-0x000000018978BE60
		[Space] // 0x000000018978BE00-0x000000018978BE60
		private GameObject _buffInfoGrp; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _buffScroller; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noBuffGrp; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtNoBuff; // 0x110
		// [Header] // 0x00000001897B1930-0x00000001897B1990
		[SerializeField] // 0x00000001897B1930-0x00000001897B1990
		[Space] // 0x00000001897B1930-0x00000001897B1990
		private GameObject _challengeInfoGrp; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _challengeTitle; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _challengeScroller; // 0x128
	
		// Properties
		public UnityEngine.UI.Text txtDialogTitle { /* [XID] */ /* 0x00000001897D04E0-0x00000001897D0500 */ get => default; } // 0x000000018493D380-0x000000018493D420 
		public MonoSimpleReusableList menuTabList { /* [XID] */ /* 0x00000001897D8200-0x00000001897D8220 */ get => default; } // 0x000000018493CD10-0x000000018493CDB0 
		public GameObject enemyInfoGrp { /* [XID] */ /* 0x00000001897DF2C0-0x00000001897DF2E0 */ get => default; } // 0x000000018493C860-0x000000018493C900 
		public GameObject mapInfoGrp { /* [XID] */ /* 0x00000001897E6B80-0x00000001897E6BA0 */ get => default; } // 0x000000018493CC60-0x000000018493CD10 
		public GameObject buildingInfoGrp { /* [XID] */ /* 0x00000001897EE6F0-0x00000001897EE710 */ get => default; } // 0x000000018493BFB0-0x000000018493C060 
		public GameObject buffInfoGrp { /* [XID] */ /* 0x00000001897F5F60-0x00000001897F5F80 */ get => default; } // 0x000000018493BE50-0x000000018493BF00 
		public GameObject challengeInfoGrp { /* [XID] */ /* 0x00000001897FD680-0x00000001897FD6A0 */ get => default; } // 0x000000018493C060-0x000000018493C110 
		public UnityEngine.UI.Text txtEnemyTitle { /* [XID] */ /* 0x0000000189804CC0-0x0000000189804CE0 */ get => default; } // 0x000000018493D420-0x000000018493D4C0 
		public MonoGridScroller enemyScroller { /* [XID] */ /* 0x000000018980C270-0x000000018980C290 */ get => default; } // 0x000000018493C900-0x000000018493C9A0 
		public GameObject singlePlayerGrp { /* [XID] */ /* 0x0000000189813A20-0x0000000189813A40 */ get => default; } // 0x000000018493D2D0-0x000000018493D380 
		public GameObject dualPlayerGrp { /* [XID] */ /* 0x000000018981B530-0x000000018981B550 */ get => default; } // 0x000000018493C7B0-0x000000018493C860 
		public UnityEngine.UI.Text txtSinglePlayerName { /* [XID] */ /* 0x0000000189822BA0-0x0000000189822BC0 */ get => default; } // 0x000000018493D830-0x000000018493D8E0 
		public UnityEngine.UI.Text txtPlayer1Name { /* [XID] */ /* 0x000000018982A4D0-0x000000018982A4F0 */ get => default; } // 0x000000018493D6D0-0x000000018493D780 
		public UnityEngine.UI.Text txtPlayer2Name { /* [XID] */ /* 0x0000000189831820-0x0000000189831840 */ get => default; } // 0x000000018493D780-0x000000018493D830 
		public MonoGridScroller singleBuildingScroller { /* [XID] */ /* 0x0000000189838F00-0x0000000189838F20 */ get => default; } // 0x000000018493D220-0x000000018493D2D0 
		public MonoGridScroller player1BuildingScroller { /* [XID] */ /* 0x0000000189840580-0x00000001898405A0 */ get => default; } // 0x000000018493CE60-0x000000018493CF10 
		public MonoGridScroller player2BuildingScroller { /* [XID] */ /* 0x0000000189847B30-0x0000000189847B50 */ get => default; } // 0x000000018493CF10-0x000000018493CFC0 
		public MonoSimpleReusableList buffScroller { /* [XID] */ /* 0x000000018984F2A0-0x000000018984F2C0 */ get => default; } // 0x000000018493BF00-0x000000018493BFB0 
		public UnityEngine.UI.Text challengeTitle { /* [XID] */ /* 0x0000000189856400-0x0000000189856420 */ get => default; } // 0x000000018493C1C0-0x000000018493C270 
		public MonoSimpleReusableList challengeScroller { /* [XID] */ /* 0x000000018985D7F0-0x000000018985D810 */ get => default; } // 0x000000018493C110-0x000000018493C1C0 
		public ScrollRect mapDescScroller { /* [XID] */ /* 0x0000000189865110-0x0000000189865130 */ get => default; } // 0x000000018493CA50-0x000000018493CB00 
		public UnityEngine.UI.Text txtMapTitle { /* [XID] */ /* 0x000000018986C670-0x000000018986C690 */ get => default; } // 0x000000018493D570-0x000000018493D620 
		public Image mapImage { /* [XID] */ /* 0x0000000189873AC0-0x0000000189873AE0 */ get => default; } // 0x000000018493CBB0-0x000000018493CC60 
		public UnityEngine.UI.Text txtMapDesc { /* [XID] */ /* 0x000000018987B550-0x000000018987B570 */ get => default; } // 0x000000018493D4C0-0x000000018493D570 
		public GameObject mapIconGrp { /* [XID] */ /* 0x00000001898826D0-0x00000001898826F0 */ get => default; } // 0x000000018493CB00-0x000000018493CBB0 
		public GameObject noBuffGrp { /* [XID] */ /* 0x0000000189889EC0-0x0000000189889EE0 */ get => default; } // 0x000000018493CDB0-0x000000018493CE60 
		public RectTransform showPanel { /* [XID] */ /* 0x0000000189891320-0x0000000189891340 */ get => default; } // 0x000000018493D180-0x000000018493D220 
		public UnityEngine.UI.Text txtNoBuff { /* [XID] */ /* 0x0000000189898930-0x0000000189898950 */ get => default; } // 0x000000018493D620-0x000000018493D6D0 
		public MonoUIContainer closeBtn { /* [XID] */ /* 0x000000018989FB70-0x000000018989FB90 */ get => default; } // 0x000000018493C430-0x000000018493C5F0 
		public MonoUIContainer checkBtn { /* [XID] */ /* 0x00000001898A75A0-0x00000001898A75C0 */ get => default; } // 0x000000018493C270-0x000000018493C430 
		public MonoUIContainer detailBtn { /* [XID] */ /* 0x00000001898AEFA0-0x00000001898AEFC0 */ get => default; } // 0x000000018493C5F0-0x000000018493C7B0 
		public MonoUIContainer selectBtn { /* [XID] */ /* 0x00000001898B6410-0x00000001898B6430 */ get => default; } // 0x000000018493CFC0-0x000000018493D180 
		public float itemScrollerRatio { /* [XID] */ /* 0x00000001898BDC60-0x00000001898BDC80 */ get => default; } // 0x000000018493C9A0-0x000000018493CA50 
	
		// Constructors
		public MonoMechanicusInfoDialog() {} // 0x000000018493BD30-0x000000018493BE50
	}
}
