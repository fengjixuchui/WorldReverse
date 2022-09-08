/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTalkDialog : MonoUIProxy // TypeDefIndex: 31081
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoGrpSelect _selectGrp; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _prefabPlugin; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _keyGameObject; // 0x50
		public MonoControlElement monoControl; // 0x58
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _clickAnimator; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _clickTip; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _countDownTrans; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _conversationRoot; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _talkRoot; // 0x80
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private float _protectTime; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _clickTipAniTime; // 0x8C
		// [Range] // 0x0000000189A52310-0x0000000189A52350
		[SerializeField] // 0x0000000189A52310-0x0000000189A52350
		private float _optionsDisplayDelay; // 0x90
		// [Range] // 0x0000000189A52310-0x0000000189A52350
		[SerializeField] // 0x0000000189A52310-0x0000000189A52350
		private float _waitDialogSelectTime; // 0x94
		// [Range] // 0x0000000189A1E420-0x0000000189A1E460
		[SerializeField] // 0x0000000189A1E420-0x0000000189A1E460
		private float _waitCoopSelectTime; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xA0
		private bool _clickAniTimeAdd; // 0xA8
		private MonoGrpConversation _conversationGrp; // 0xB0
		private MonoCoopPanel _coopPanel; // 0xB8
	
		// Properties
		public MonoGrpSelect selectGrp { /* [XID] */ /* 0x000000018980AB60-0x000000018980AB80 */ get => default; } // 0x00000001850128C0-0x0000000185012960 
		public Transform countDownTrans { /* [XID] */ /* 0x0000000189812130-0x0000000189812150 */ get => default; } // 0x00000001850126C0-0x0000000185012760 
		public GameObject conversationRoot { /* [XID] */ /* 0x0000000189819CE0-0x0000000189819D00 */ get => default; } // 0x00000001850124C0-0x0000000185012560 
		public GameObject talkRoot { /* [XID] */ /* 0x0000000189821560-0x0000000189821580 */ get => default; } // 0x0000000185012A10-0x0000000185012AC0 
		public float optionsDisplayDelay { /* [XID] */ /* 0x000000018982FF80-0x000000018982FFA0 */ get => default; } // 0x0000000185012810-0x00000001850128C0 
		public float waitDialogSelectTime { /* [XID] */ /* 0x00000001898376C0-0x00000001898376E0 */ get => default; } // 0x0000000185012B70-0x0000000185012C20 
		public float waitCoopSelectTime { /* [XID] */ /* 0x000000018983ED90-0x000000018983EDB0 */ get => default; } // 0x0000000185012AC0-0x0000000185012B70 
		public float defaultDialogDisplayDuration { /* [XID] */ /* 0x00000001898463D0-0x00000001898463F0 */ get => default; } // 0x0000000185012760-0x0000000185012810 
		public float clickTipAniTime { /* [XID] */ /* 0x000000018984D9C0-0x000000018984D9E0 */ get => default; } // 0x0000000185012340-0x0000000185012410 
		public bool clickAniTimeAdd { /* [XID] */ /* 0x000000018985C280-0x000000018985C2A0 */ get => default; /* [XID] */ /* 0x0000000189854A20-0x0000000189854A40 */ set {} } // 0x0000000185012290-0x0000000185012340 0x0000000185012C20-0x0000000185012CD0
		public MonoGrpConversation conversationGrp { /* [XID] */ /* 0x00000001898722C0-0x00000001898722E0 */ get => default; } // 0x0000000185012410-0x00000001850124C0 
		public bool showSelectOptions { /* [XID] */ /* 0x0000000189888640-0x0000000189888660 */ set {} } // 0x0000000185012E50-0x0000000185012F60
		public bool showClickTip { /* [XID] */ /* 0x000000018988FA00-0x000000018988FA20 */ get => default; /* [XID] */ /* 0x0000000189896F00-0x0000000189896F20 */ set {} } // 0x0000000185012960-0x0000000185012A10 0x0000000185012CD0-0x0000000185012E50
		public MonoCoopPanel coopPanel { /* [XID] */ /* 0x00000001898B4A50-0x00000001898B4A70 */ get => default; } // 0x0000000185012560-0x00000001850126C0 
		public MonoUIContainer autoTalkPlayBtn { /* [XID] */ /* 0x00000001898C3BE0-0x00000001898C3C00 */ get => default; } // 0x0000000185012110-0x00000001850121D0 
		public MonoUIContainer autoTalkStopBtn { /* [XID] */ /* 0x00000001898CB440-0x00000001898CB460 */ get => default; } // 0x00000001850121D0-0x0000000185012290 
	
		// Constructors
		public MonoTalkDialog() {} // 0x0000000185012030-0x0000000185012110
	
		// Methods
		// [XID] // 0x0000000189828B50-0x0000000189828B70
		public void InitMonoControlIcon() {} // 0x0000000185011770-0x0000000185011AB0
		// [XID] // 0x0000000189863BE0-0x0000000189863C00
		public void CreateNarrationVersion() {} // 0x0000000185011370-0x0000000185011510
		// [XID] // 0x000000018986AEB0-0x000000018986AED0
		public void CreateConversationVersion() {} // 0x00000001850111D0-0x0000000185011370
		// [XID] // 0x0000000189879F30-0x0000000189879F50
		private void OnEnable() {} // 0x0000000185011C10-0x0000000185011CE0
		// [XID] // 0x0000000189881070-0x0000000189881090
		public void OnDialogClick() {} // 0x0000000185011AB0-0x0000000185011C10
		// [XID] // 0x000000018989E400-0x000000018989E420
		public void OnTalkerChange() {} // 0x0000000185011CE0-0x0000000185011F00
		// [XID] // 0x00000001898A5ED0-0x00000001898A5EF0
		public void HideDialog(bool hide) {} // 0x00000001850115D0-0x0000000185011770
		// [XID] // 0x00000001898AD510-0x00000001898AD530
		public void HideCoopPanel(bool hide) {} // 0x0000000185011510-0x00000001850115D0
		// [XID] // 0x00000001898BC5E0-0x00000001898BC600
		public void SetCoopPanelActive(bool active) {} // 0x0000000185011F00-0x0000000185012030
	}
}
