/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTeamAvatarBtn : MonoActionBtn // TypeDefIndex: 31086
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _contentGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _addGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _placeGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _disableGrp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _prohibitGrp; // 0x78
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _titleGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _elementIcon; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _avatarNameLabel; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLable; // 0x98
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _exploreGrp; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _exploreCountdownLabel; // 0xA8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _MPTitleGrp; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _playerMarkIcon; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerNameLabel; // 0xC0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _MPAvatarTitleGrp; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _MPElementIcon; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _MPLevelLabel; // 0xD8
		// [Header] // 0x0000000189BA32E0-0x0000000189BA3330
		[SerializeField] // 0x0000000189BA32E0-0x0000000189BA3330
		private RectTransform _readyGrp; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _readyAnimator; // 0xE8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _actionGrp; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _actionList; // 0xF8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _PS4OnlineId; // 0x100
		[NonSerialized]
		public int index; // 0x108
		public Action<int> PointerDownCallback; // 0x110
		public Action<int> PointerUpCallback; // 0x118
	
		// Properties
		public bool showContentGrp { /* [XID] */ /* 0x0000000189BD2DA0-0x0000000189BD2DC0 */ set {} } // 0x0000000183B5A0D0-0x0000000183B5A1B0
		public bool showAddGrp { /* [XID] */ /* 0x0000000189BDA480-0x0000000189BDA4A0 */ set {} } // 0x0000000183B59FF0-0x0000000183B5A0D0
		public bool showPlaceGrp { /* [XID] */ /* 0x00000001895E6F10-0x00000001895E6F30 */ set {} } // 0x0000000183B5A530-0x0000000183B5A610
		public bool showDisableGrp { /* [XID] */ /* 0x00000001895EE8A0-0x00000001895EE8C0 */ set {} } // 0x0000000183B5A1B0-0x0000000183B5A290
		public bool showProhibitGrp { /* [XID] */ /* 0x00000001895F6280-0x00000001895F62A0 */ set {} } // 0x0000000183B5A610-0x0000000183B5A6F0
		public bool showTitleGrp { /* [XID] */ /* 0x00000001895FD5C0-0x00000001895FD5E0 */ set {} } // 0x0000000183B5A7D0-0x0000000183B5A8B0
		public Sprite elementIcon { /* [XID] */ /* 0x0000000189604EE0-0x0000000189604F00 */ set {} } // 0x0000000183B59B00-0x0000000183B59BD0
		public string avatarName { /* [XID] */ /* 0x000000018960C930-0x000000018960C950 */ set {} } // 0x0000000183B59A30-0x0000000183B59B00
		public string levelString { /* [XID] */ /* 0x0000000189613E50-0x0000000189613E70 */ set {} } // 0x0000000183B59CA0-0x0000000183B59D70
		public bool showExploreGrp { /* [XID] */ /* 0x000000018961B820-0x000000018961B840 */ set {} } // 0x0000000183B5A290-0x0000000183B5A370
		public UnityEngine.UI.Text exploreText { /* [XID] */ /* 0x0000000189622DA0-0x0000000189622DC0 */ get => default; } // 0x0000000183B596F0-0x0000000183B597C0 
		public GameObject countDownGameObject { /* [XID] */ /* 0x000000018962A590-0x000000018962A5B0 */ get => default; } // 0x0000000183B59620-0x0000000183B596F0 
		public string exploreCountdownString { /* [XID] */ /* 0x0000000189631D10-0x0000000189631D30 */ set {} } // 0x0000000183B59BD0-0x0000000183B59CA0
		public bool showMPTitleGrp { /* [XID] */ /* 0x0000000189639870-0x0000000189639890 */ set {} } // 0x0000000183B5A450-0x0000000183B5A530
		public Sprite playerMarkIcon { /* [XID] */ /* 0x0000000189640CE0-0x0000000189640D00 */ set {} } // 0x0000000183B59D70-0x0000000183B59E40
		public string playerName { /* [XID] */ /* 0x0000000189648630-0x0000000189648650 */ set {} } // 0x0000000183B59E40-0x0000000183B59F10
		public bool showMPAvatarTitleGrp { /* [XID] */ /* 0x000000018964FD40-0x000000018964FD60 */ set {} } // 0x0000000183B5A370-0x0000000183B5A450
		public Sprite MPElementIcon { /* [XID] */ /* 0x0000000189657580-0x00000001896575A0 */ set {} } // 0x0000000183B59890-0x0000000183B59960
		public string MPLevelString { /* [XID] */ /* 0x000000018965EC40-0x000000018965EC60 */ set {} } // 0x0000000183B59960-0x0000000183B59A30
		public bool showReadyGrp { /* [XID] */ /* 0x000000018967D1D0-0x000000018967D1F0 */ set {} } // 0x0000000183B5A6F0-0x0000000183B5A7D0
		public bool showActionGrp { /* [XID] */ /* 0x000000018968C3F0-0x000000018968C410 */ get => default; /* [XID] */ /* 0x0000000189693EC0-0x0000000189693EE0 */ set {} } // 0x0000000183B597C0-0x0000000183B59890 0x0000000183B59F10-0x0000000183B59FF0
		public MonoSimpleReusableList actionList { /* [XID] */ /* 0x000000018969B490-0x000000018969B4B0 */ get => default; } // 0x0000000183B59570-0x0000000183B59620 
		public UnityEngine.UI.Text PS4OnlineId { /* [XID] */ /* 0x00000001896A2BB0-0x00000001896A2BD0 */ get => default; } // 0x0000000183B594C0-0x0000000183B59570 
	
		// Constructors
		public MonoTeamAvatarBtn() {} // 0x0000000183B593B0-0x0000000183B594C0
	
		// Methods
		// [XID] // 0x00000001896662E0-0x0000000189666300
		public override bool OnRealPointerDown(PointerEventData eventData) => default; // 0x0000000183B59180-0x0000000183B59260
		// [XID] // 0x000000018966DAE0-0x000000018966DB00
		public override void OnPointerUp(PointerEventData eventData) {} // 0x0000000183B590A0-0x0000000183B59180
		// [XID] // 0x00000001896758C0-0x00000001896758E0
		public float GetTotalHoldTime() => default; // 0x0000000183B58FF0-0x0000000183B590A0
		// [XID] // 0x0000000189684880-0x00000001896848A0
		public void SetReadyAnimator(bool ready, bool valid) {} // 0x0000000183B59260-0x0000000183B593B0
	}
}
