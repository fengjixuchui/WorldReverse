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
	public class MonoGiveCharacterContext : MonoBehaviour // TypeDefIndex: 31220
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _progressRoot; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _getRoot; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _fetchRoot; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockObj; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _talkBubbleObj; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _talkText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _talkAnimator; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _goalText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _curProgressText; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _character; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _getCharacter; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockTipsText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollDesc; // 0x80
		private uint _chaConfigID; // 0x88
		private List<uint> _voiceIndexList; // 0x90
		private bool _isPlaying; // 0x98
		private int currVoiceID; // 0x9C
		private uint _bonusId; // 0xA0
	
		// Properties
		public ScrollRect scrollDesc { /* [XID] */ /* 0x0000000189BB0300-0x0000000189BB0320 */ get => default; } // 0x0000000184072050-0x0000000184072100 
		public MonoUIContainer btnExit { /* [XID] */ /* 0x0000000189BB7740-0x0000000189BB7760 */ get => default; } // 0x0000000184071CD0-0x0000000184071D90 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x0000000189BBEDE0-0x0000000189BBEE00 */ get => default; } // 0x0000000184071C10-0x0000000184071CD0 
		public MonoUIContainer BtnAudio { /* [XID] */ /* 0x0000000189BC6A90-0x0000000189BC6AB0 */ get => default; } // 0x0000000184071A90-0x0000000184071B50 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x0000000189BCE760-0x0000000189BCE780 */ get => default; } // 0x0000000184071B50-0x0000000184071C10 
		public Button character { /* [XID] */ /* 0x0000000189BD5A20-0x0000000189BD5A40 */ get => default; } // 0x0000000184071D90-0x0000000184071E30 
		public Button getCharacter { /* [XID] */ /* 0x0000000189BDD660-0x0000000189BDD680 */ get => default; } // 0x0000000184071E30-0x0000000184071ED0 
		public MonoUIContainer gotoButton { /* [XID] */ /* 0x00000001895EA230-0x00000001895EA250 */ get => default; } // 0x0000000184071ED0-0x0000000184071F90 
		public string gotoButtonText { /* [XID] */ /* 0x00000001895F16B0-0x00000001895F16D0 */ set {} } // 0x00000001840727C0-0x00000001840728A0
		public MonoUIContainer lookButton { /* [XID] */ /* 0x00000001895F9110-0x00000001895F9130 */ get => default; } // 0x0000000184071F90-0x0000000184072050 
		public bool ShowProgress { /* [XID] */ /* 0x0000000189600720-0x0000000189600740 */ set {} } // 0x00000001840723D0-0x00000001840724C0
		public bool ShowGetRoot { /* [XID] */ /* 0x0000000189608060-0x0000000189608080 */ set {} } // 0x00000001840721F0-0x00000001840722E0
		public bool ShowFetchRoot { /* [XID] */ /* 0x000000018960F9E0-0x000000018960FA00 */ set {} } // 0x0000000184072100-0x00000001840721F0
		public bool ShowLockObj { /* [XID] */ /* 0x0000000189616C30-0x0000000189616C50 */ set {} } // 0x00000001840722E0-0x00000001840723D0
		public bool ShowTalk { /* [XID] */ /* 0x000000018961E7E0-0x000000018961E800 */ set {} } // 0x00000001840724C0-0x00000001840725A0
		public string talkText { /* [XID] */ /* 0x0000000189625BC0-0x0000000189625BE0 */ set {} } // 0x00000001840728A0-0x0000000184072980
		public string unlockTipsText { /* [XID] */ /* 0x000000018962D4E0-0x000000018962D500 */ set {} } // 0x0000000184072980-0x0000000184072A60
		public string goalText { /* [XID] */ /* 0x00000001896350A0-0x00000001896350C0 */ set {} } // 0x00000001840726B0-0x00000001840727C0
		public string curProgressText { /* [XID] */ /* 0x000000018963C6C0-0x000000018963C6E0 */ set {} } // 0x00000001840725A0-0x00000001840726B0
	
		// Constructors
		public MonoGiveCharacterContext() {} // 0x00000001840719A0-0x0000000184071A90
	
		// Methods
		// [XID] // 0x0000000189643E10-0x0000000189643E30
		public void BubbleFadeIn() {} // 0x0000000184070E80-0x0000000184070FB0
		// [XID] // 0x000000018964B550-0x000000018964B570
		public void BubbleFadeOut() {} // 0x0000000184070FB0-0x00000001840710E0
		// [XID] // 0x0000000189652D80-0x0000000189652DA0
		public void SetVoiceList(uint bonusId, uint avatarConfigID, SimpleSafeUInt32[] voiceIndexList) {} // 0x0000000184071610-0x00000001840717A0
		// [XID] // 0x000000018965A460-0x000000018965A480
		public void Play(int index) {} // 0x0000000184071310-0x0000000184071610
		// [XID] // 0x0000000189661AB0-0x0000000189661AD0
		public void PlayRandom() {} // 0x0000000184071220-0x0000000184071310
		// [XID] // 0x0000000189669650-0x0000000189669670
		public void TryStop() {} // 0x00000001840718A0-0x00000001840719A0
		// [XID] // 0x0000000189671160-0x0000000189671180
		public void StopCallback(int voiceID) {} // 0x00000001840717A0-0x00000001840718A0
		// [XID] // 0x00000001896789C0-0x00000001896789E0
		private void OnEnable() {} // 0x0000000184071180-0x0000000184071220
		// [XID] // 0x000000018967FFC0-0x000000018967FFE0
		private void OnDisable() {} // 0x00000001840710E0-0x0000000184071180
	}
}
