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
	public class MonoMPTeamRow : MonoBehaviour, EditMenuTarget // TypeDefIndex: 30979
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _icon; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _iconBtn; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _markIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _blockChatImg; // 0x30
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _playerNameLabel; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0x40
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _firstAvatarGrp; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _firstAvatarIcon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _secondAvatarGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _secondAvatarIcon; // 0x60
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _operationGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _operatingGrp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _selectBtn; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _onlineID; // 0x80
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _rtt; // 0x88
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _imgL; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imgR; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _nameCardPic; // 0xA0
		private uint _uid; // 0xA8
		public MonoUIContainer addButtonContainer; // 0xB0
		public MonoUIContainer kickButtonContainer; // 0xB8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _avatarIconSelector; // 0xC0
	
		// Properties
		public bool showOnlineID { /* [XID] */ /* 0x000000018975A500-0x000000018975A520 */ set {} } // 0x0000000182F11100-0x0000000182F111E0
		public string onlineID { /* [XID] */ /* 0x0000000189762200-0x0000000189762220 */ set {} } // 0x0000000182F10B40-0x0000000182F10CB0
		public Image icon { /* [XID] */ /* 0x0000000189769770-0x0000000189769790 */ get => default; } // 0x0000000182F10360-0x0000000182F10400 
		public Button iconBtn { /* [XID] */ /* 0x0000000189770D70-0x0000000189770D90 */ get => default; } // 0x0000000182F102C0-0x0000000182F10360 
		public Sprite markIcon { /* [XID] */ /* 0x0000000189778700-0x0000000189778720 */ set {} } // 0x0000000182F10940-0x0000000182F10A00
		public RectTransform blockChatImg { /* [XID] */ /* 0x000000018977FC60-0x000000018977FC80 */ get => default; } // 0x0000000182F10220-0x0000000182F102C0 
		public string playerName { /* [XID] */ /* 0x0000000189787540-0x0000000189787560 */ set {} } // 0x0000000182F10CB0-0x0000000182F10D80
		public string levelString { /* [XID] */ /* 0x000000018978EB10-0x000000018978EB30 */ set {} } // 0x0000000182F10870-0x0000000182F10940
		public bool showFirstAvatarGrp { /* [XID] */ /* 0x0000000189796290-0x00000001897962B0 */ set {} } // 0x0000000182F10F30-0x0000000182F11010
		public Sprite firstAvatarIcon { /* [XID] */ /* 0x000000018979E3D0-0x000000018979E3F0 */ set {} } // 0x0000000182F107B0-0x0000000182F10870
		public bool showSecondAvatarGrp { /* [XID] */ /* 0x00000001897A5B50-0x00000001897A5B70 */ set {} } // 0x0000000182F113A0-0x0000000182F11480
		public Sprite secondAvatarGrp { /* [XID] */ /* 0x00000001897AD0C0-0x00000001897AD0E0 */ set {} } // 0x0000000182F10D80-0x0000000182F10E40
		public bool showOperationGrp { /* [XID] */ /* 0x00000001897B50F0-0x00000001897B5110 */ set {} } // 0x0000000182F112C0-0x0000000182F113A0
		public bool showKickButton { /* [XID] */ /* 0x00000001897C40A0-0x00000001897C40C0 */ get => default; /* [XID] */ /* 0x00000001897BCD20-0x00000001897BCD40 */ set {} } // 0x0000000182F10640-0x0000000182F10710 0x0000000182F11010-0x0000000182F11100
		public bool showAddButton { /* [XID] */ /* 0x00000001897D3250-0x00000001897D3270 */ get => default; /* [XID] */ /* 0x00000001897CB960-0x00000001897CB980 */ set {} } // 0x0000000182F10570-0x0000000182F10640 0x0000000182F10E40-0x0000000182F10F30
		public bool showOperatingHint { /* [XID] */ /* 0x00000001897DACD0-0x00000001897DACF0 */ set {} } // 0x0000000182F111E0-0x0000000182F112C0
		public uint uid { /* [XID] */ /* 0x00000001897E23C0-0x00000001897E23E0 */ get => default; /* [XID] */ /* 0x00000001897E9B30-0x00000001897E9B50 */ set {} } // 0x0000000182F10710-0x0000000182F107B0 0x0000000182F11480-0x0000000182F11530
		private bool showDefaultNameCard { /* [XID] */ /* 0x00000001897F8EC0-0x00000001897F8EE0 */ set {} } // 0x0000000182F0FA10-0x0000000182F0FB40
		public Sprite nameCardPic { /* [XID] */ /* 0x00000001898004F0-0x0000000189800510 */ set {} } // 0x0000000182F10A00-0x0000000182F10B40
		public Button addButton { /* [XID] */ /* 0x0000000189807B70-0x0000000189807B90 */ get => default; } // 0x0000000182F10160-0x0000000182F10220 
		public Button kickButton { /* [XID] */ /* 0x000000018980F470-0x000000018980F490 */ get => default; } // 0x0000000182F10400-0x0000000182F104C0 
		public Image rttIcon { /* [XID] */ /* 0x0000000189816B20-0x0000000189816B40 */ get => default; } // 0x0000000182F104C0-0x0000000182F10570 
	
		// Nested types
		public enum SelectState // TypeDefIndex: 30980
		{
			None = 0,
			Select = 1,
			UnSelect = 2
		}
	
		// Constructors
		public MonoMPTeamRow() {} // 0x0000000182F10090-0x0000000182F10160
	
		// Methods
		// [XID] // 0x00000001897F17F0-0x00000001897F1810
		public void SetSelectState(SelectState state) {} // 0x0000000182F0FD40-0x0000000182F10090
		// [XID] // 0x000000018981E3B0-0x000000018981E3D0
		RectTransform MoleMole.EditMenuTarget.GetTransform() => default; // 0x0000000182F0FB40-0x0000000182F0FC50
		// [XID] // 0x0000000189825840-0x0000000189825860
		void MoleMole.EditMenuTarget.Selected(bool selected) {} // 0x0000000182F0FC50-0x0000000182F0FD40
	}
}
