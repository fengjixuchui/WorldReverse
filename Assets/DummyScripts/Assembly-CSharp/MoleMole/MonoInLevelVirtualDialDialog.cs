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
	public class MonoInLevelVirtualDialDialog : MonoUIProxy // TypeDefIndex: 31287
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoVirtualDialItem[] _slots; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _joypadExtraWheelGrp; // 0x48
		// [Header] // 0x0000000189BD1600-0x0000000189BD1650
		[SerializeField] // 0x0000000189BD1600-0x0000000189BD1650
		private RectTransform _5thAvatarTransform; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _5thAvatarIcons; // 0x58
		// [Header] // 0x00000001895EA1E0-0x00000001895EA230
		[SerializeField] // 0x00000001895EA1E0-0x00000001895EA230
		private RectTransform _quickUseButton; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _quickUseButtonPrefab; // 0x68
		// [Header] // 0x00000001895FD500-0x00000001895FD540
		[SerializeField] // 0x00000001895FD500-0x00000001895FD540
		private RectTransform _chargeButton; // 0x70
		// [Header] // 0x0000000189609810-0x0000000189609860
		[SerializeField] // 0x0000000189609810-0x0000000189609860
		private RectTransform _homeworldEditorButton; // 0x78
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _extraSelectGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform[] _extraSelects; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _extraSelectsIcon; // 0x90
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.Material _deadMaterial; // 0x98
		// [Range] // 0x0000000189639800-0x0000000189639850
		[SerializeField] // 0x0000000189639800-0x0000000189639850
		[Space] // 0x0000000189639800-0x0000000189639850
		private float _selectDelay; // 0xA0
		// [Header] // 0x0000000189646DD0-0x0000000189646E20
		[SerializeField] // 0x0000000189646DD0-0x0000000189646E20
		private RectTransform _deadZone; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _cursor; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _characterPageSprite; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _joypadInputDelay; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _prefabPlugin; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _handbookIcon; // 0xD0
		private MonoActivitySkillButton _activitySkillButton; // 0xD8
	
		// Properties
		public Image characterPageSprite { /* [XID] */ /* 0x00000001896770C0-0x00000001896770E0 */ get => default; } // 0x000000018431F310-0x000000018431F3C0 
		public uint joypadInputDelayMS { /* [XID] */ /* 0x000000018967E670-0x000000018967E690 */ get => default; } // 0x000000018431F900-0x000000018431F9E0 
		public RectTransform extraAvatarTransform { /* [XID] */ /* 0x0000000189685E80-0x0000000189685EA0 */ get => default; } // 0x000000018431F5B0-0x000000018431F650 
		public Image extraAvatarIcon { /* [XID] */ /* 0x000000018968DCB0-0x000000018968DCD0 */ get => default; } // 0x000000018431F510-0x000000018431F5B0 
		public RectTransform quickUseButtonTransform { /* [XID] */ /* 0x0000000189695600-0x0000000189695620 */ get => default; } // 0x000000018431FA80-0x000000018431FB20 
		public GameObject quickUseButtonPrefab { /* [XID] */ /* 0x000000018969CC90-0x000000018969CCB0 */ get => default; } // 0x000000018431F9E0-0x000000018431FA80 
		public RectTransform chargeButtonTransform { /* [XID] */ /* 0x00000001896A4000-0x00000001896A4020 */ get => default; } // 0x000000018431F3C0-0x000000018431F460 
		public Image handbookIcon { /* [XID] */ /* 0x00000001896AB5E0-0x00000001896AB600 */ get => default; } // 0x000000018431F7B0-0x000000018431F860 
		public RectTransform homeworldEdtiorButtonTransform { /* [XID] */ /* 0x00000001896B27D0-0x00000001896B27F0 */ get => default; } // 0x000000018431F860-0x000000018431F900 
		public float deadZone { /* [XID] */ /* 0x00000001896C8870-0x00000001896C8890 */ set {} } // 0x000000018431FE40-0x000000018431FF50
		public Vector2 cursorPosition { /* [XID] */ /* 0x00000001896D0260-0x00000001896D0280 */ set {} } // 0x000000018431FCE0-0x000000018431FE40
		public UnityEngine.Material deadMaterial { /* [XID] */ /* 0x00000001896D77E0-0x00000001896D7800 */ get => default; } // 0x000000018431F460-0x000000018431F510 
		public float selectDelay { /* [XID] */ /* 0x00000001896DEFC0-0x00000001896DEFE0 */ get => default; } // 0x000000018431FB20-0x000000018431FBD0 
		public bool showJoypadExtraSelectGrp { /* [XID] */ /* 0x00000001896E6430-0x00000001896E6450 */ set {} } // 0x0000000184320190-0x0000000184320270
		public bool showExtraSelectGrp { /* [XID] */ /* 0x00000001896ED940-0x00000001896ED960 */ set {} } // 0x00000001843200B0-0x0000000184320190
		public RectTransform[] extraSelects { /* [XID] */ /* 0x00000001896F50F0-0x00000001896F5110 */ get => default; } // 0x000000018431F700-0x000000018431F7B0 
		public Image[] extraSelectsIcon { /* [XID] */ /* 0x00000001896FC930-0x00000001896FC950 */ get => default; } // 0x000000018431F650-0x000000018431F700 
		public MonoActivitySkillButton activitySkillButton { /* [XID] */ /* 0x0000000189703DF0-0x0000000189703E10 */ get => default; } // 0x000000018431F150-0x000000018431F310 
		public bool showActivitySkillButton { /* [XID] */ /* 0x0000000189712F30-0x0000000189712F50 */ get => default; /* [XID] */ /* 0x000000018970B6B0-0x000000018970B6D0 */ set {} } // 0x000000018431FBD0-0x000000018431FCE0 0x000000018431FF50-0x00000001843200B0
	
		// Constructors
		public MonoInLevelVirtualDialDialog() {} // 0x000000018431F070-0x000000018431F150
	
		// Methods
		// [XID] // 0x00000001896B9ED0-0x00000001896B9EF0
		public int UpdateSelection(float degree) => default; // 0x000000018431EEE0-0x000000018431F070
		// [XID] // 0x00000001896C11D0-0x00000001896C11F0
		public MonoVirtualDialItem GetItemAt(int index) => default; // 0x000000018431EDF0-0x000000018431EEE0
	}
}
