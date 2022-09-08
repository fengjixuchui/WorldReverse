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
	// [RequireComponent] // 0x00000001897E3980-0x00000001897E39D0
	public class MonoQuestSelectItem : MonoBehaviour // TypeDefIndex: 31296
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _actionBtn; // 0x18
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _bgImg; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _traceMark; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bgMark; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectMark; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgType; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _trackEffect; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _trackDangerEffect; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _trackBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _newMark; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _redPointGO; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _otherInfo; // 0x70
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _imgPoint; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgDisable; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgComplete; // 0x88
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _txtQuestName; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtRecommendLevel; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDistance; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTime; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _mainQuestSign; // 0xB0
		private int _index; // 0xB8
		private uint _mainQuestID; // 0xBC
		private IDType _type; // 0xC0
		private bool _isTracked; // 0xC4
		private bool _isSelected; // 0xC5
		private QuestSelectState _questSelectState; // 0xC8
	
		// Properties
		public int index { /* [XID] */ /* 0x000000018988F9E0-0x000000018988FA00 */ get => default; /* [XID] */ /* 0x0000000189896EE0-0x0000000189896F00 */ set {} } // 0x0000000184425070-0x0000000184425110 0x00000001844258B0-0x0000000184425960
		public IDType type { /* [XID] */ /* 0x000000018989E3E0-0x000000018989E400 */ get => default; /* [XID] */ /* 0x00000001898A5EB0-0x00000001898A5ED0 */ set {} } // 0x00000001844255A0-0x0000000184425640 0x00000001844264B0-0x0000000184426560
		public uint mainQuestID { /* [XID] */ /* 0x00000001898AD4D0-0x00000001898AD4F0 */ get => default; /* [XID] */ /* 0x00000001898B49F0-0x00000001898B4A10 */ set {} } // 0x0000000184425270-0x0000000184425310 0x0000000184425B80-0x0000000184425C30
		public bool isTracked { /* [XID] */ /* 0x00000001898BC540-0x00000001898BC560 */ get => default; /* [XID] */ /* 0x00000001898C3B80-0x00000001898C3BA0 */ set {} } // 0x00000001844251C0-0x0000000184425270 0x0000000184425A70-0x0000000184425B80
		public bool isSelected { /* [XID] */ /* 0x00000001898D2AC0-0x00000001898D2AE0 */ get => default; /* [XID] */ /* 0x00000001898CB400-0x00000001898CB420 */ set {} } // 0x0000000184425110-0x00000001844251C0 0x0000000184425960-0x0000000184425A70
		public Button actionButton { /* [XID] */ /* 0x00000001898DA480-0x00000001898DA4A0 */ get => default; } // 0x0000000184424FD0-0x0000000184425070 
		public string recommendLevel { /* [XID] */ /* 0x00000001898E2150-0x00000001898E2170 */ set {} } // 0x0000000184425E10-0x0000000184425F70
		public Color recommendLevelColor { /* [XID] */ /* 0x00000001898E9D30-0x00000001898E9D50 */ set {} } // 0x0000000184425D10-0x0000000184425E10
		public string distance { /* [XID] */ /* 0x00000001898F1450-0x00000001898F1470 */ set {} } // 0x0000000184425720-0x00000001844257F0
		public Sprite trackMarkIcon { /* [XID] */ /* 0x0000000189907CD0-0x0000000189907CF0 */ set {} } // 0x00000001844263F0-0x00000001844264B0
		public Button trackButton { /* [XID] */ /* 0x000000018990F4B0-0x000000018990F4D0 */ get => default; } // 0x0000000184425450-0x00000001844254F0 
		public string title { /* [XID] */ /* 0x0000000189916F10-0x0000000189916F30 */ set {} } // 0x0000000184426320-0x00000001844263F0
		public Color titleColor { /* [XID] */ /* 0x000000018991E670-0x000000018991E690 */ set {} } // 0x0000000184426240-0x0000000184426320
		public UnityEngine.UI.Text txtTime { /* [XID] */ /* 0x0000000189925E70-0x0000000189925E90 */ get => default; } // 0x00000001844254F0-0x00000001844255A0 
		public bool showMainSign { /* [XID] */ /* 0x000000018992D400-0x000000018992D420 */ set {} } // 0x0000000184425F70-0x0000000184426060
		public Color bgImgColor { /* [XID] */ /* 0x0000000189934950-0x0000000189934970 */ set {} } // 0x0000000184425640-0x0000000184425720
		public Sprite imgTypeIcon { /* [XID] */ /* 0x000000018993C400-0x000000018993C420 */ set {} } // 0x00000001844257F0-0x00000001844258B0
		public QuestSelectState questSelectState { /* [XID] */ /* 0x0000000189943A50-0x0000000189943A70 */ get => default; /* [XID] */ /* 0x000000018994AFD0-0x000000018994AFF0 */ set {} } // 0x00000001844253B0-0x0000000184425450 0x0000000184425C30-0x0000000184425D10
		public GameObject otherInfo { /* [XID] */ /* 0x0000000189968FF0-0x0000000189969010 */ get => default; } // 0x0000000184425310-0x00000001844253B0 
		public bool showNewMark { /* [XID] */ /* 0x0000000189970A30-0x0000000189970A50 */ set {} } // 0x0000000184426060-0x0000000184426150
		public bool showRedPoint { /* [XID] */ /* 0x0000000189978430-0x0000000189978450 */ set {} } // 0x0000000184426150-0x0000000184426240
	
		// Nested types
		public enum QuestSelectState // TypeDefIndex: 31297
		{
			Unfinished = 0,
			Disable = 1,
			Complete = 2
		}
	
		// Constructors
		public MonoQuestSelectItem() {} // 0x0000000184424F10-0x0000000184424FD0
	
		// Methods
		// [XID] // 0x00000001898F8C00-0x00000001898F8C20
		public void SetTrackEffect(bool state) {} // 0x0000000184424E20-0x0000000184424F10
		// [XID] // 0x0000000189900590-0x00000001899005B0
		public void SetDangerEffect(bool isDanger) {} // 0x0000000184424D30-0x0000000184424E20
		// [XID] // 0x0000000189952970-0x0000000189952990
		private void setImgPoint() {} // 0x0000000184424A30-0x0000000184424B30
		// [XID] // 0x0000000189959F10-0x0000000189959F30
		private void setImgDisable() {} // 0x0000000184424C30-0x0000000184424D30
		// [XID] // 0x0000000189961940-0x0000000189961960
		private void setImgComplete() {} // 0x0000000184424B30-0x0000000184424C30
	}
}
