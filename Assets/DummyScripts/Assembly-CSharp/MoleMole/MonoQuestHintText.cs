/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoQuestHintText : MonoBehaviour // TypeDefIndex: 31294
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected Animator _animator; // 0x18
		// [Range] // 0x00000001898EE590-0x00000001898EE5D0
		[SerializeField] // 0x00000001898EE590-0x00000001898EE5D0
		protected float _fadeOutDuration; // 0x20
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _label; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _button; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _description; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _questMainIcon; // 0x48
		private bool _needRecovery; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _canvasGroup; // 0x58
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private float _newHintNormalShowDuration; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _newHintInterruptShowDuration; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _replaceHintNormalShowDuration; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _replaceHintInterruptShowDuration; // 0x6C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _completeHintNormalShowDuration; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _completeHintInterruptShowDuration; // 0x74
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _remindHintNormalShowDuration; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _remindHintInterruptShowDuration; // 0x7C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _defaultNormalShowDuration; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _defaultInterruptShowDuration; // 0x84
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private uint _newAudioID; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _replaceAudioID; // 0x8C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _completeAudioID; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _failAudioID; // 0x94
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _progressQuestWaitFrame; // 0x98
		private float _normalDeadline; // 0x9C
		private float _interruptDeadline; // 0xA0
		private float _saveTime; // 0xA4
		private uint _mainQuestId; // 0xA8
		private uint _setId; // 0xAC
		private uint _questId; // 0xB0
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		private State _state; // 0xB4
		private RecycledLinkedList<Tuple<QuestExcelConfigProxy, QuestHintType, string, int>> _cache; // 0xB8
		private Dictionary<uint, RecycledLinkedList<Tuple<QuestExcelConfigProxy, QuestHintType, string, int>>> _cacheDic; // 0xC0
		private Transform _trackIns; // 0xC8
		private MonoElementSwitch _monoTrackElementSwitch; // 0xD0
		private List<KeyCode> _trackKeyCodeList; // 0xD8
	
		// Properties
		public uint mainQuestId { /* [XID] */ /* 0x000000018972F240-0x000000018972F260 */ get => default; } // 0x000000018372E320-0x000000018372E3C0 
		public Button actionButton { /* [XID] */ /* 0x0000000189736C20-0x0000000189736C40 */ get => default; } // 0x000000018372DF40-0x000000018372DFE0 
		public bool active { /* [XID] */ /* 0x0000000189797C30-0x0000000189797C50 */ get => default; } // 0x000000018372E0B0-0x000000018372E160 
		public bool activeOrWaiting { /* [XID] */ /* 0x000000018979F8D0-0x000000018979F8F0 */ get => default; } // 0x000000018372DFE0-0x000000018372E0B0 
		public RecycledLinkedList<Tuple<QuestExcelConfigProxy, QuestHintType, string, int>> cache { /* [XID] */ /* 0x00000001897A6E70-0x00000001897A6E90 */ get => default; /* [XID] */ /* 0x00000001897AE7D0-0x00000001897AE7F0 */ set {} } // 0x000000018372E240-0x000000018372E320 0x000000018372E470-0x000000018372E540
		public Dictionary<uint, RecycledLinkedList<Tuple<QuestExcelConfigProxy, QuestHintType, string, int>>> cacheDic { /* [XID] */ /* 0x00000001897B6710-0x00000001897B6730 */ get => default; /* [XID] */ /* 0x00000001897BE550-0x00000001897BE570 */ set {} } // 0x000000018372E160-0x000000018372E240 0x000000018372E3C0-0x000000018372E470
	
		// Nested types
		private enum State // TypeDefIndex: 31295
		{
			None = 0,
			Fadingout = 1,
			New = 2,
			Replace = 3,
			Complete = 4,
			Fail = 5,
			Remind = 6
		}
	
		// Constructors
		public MonoQuestHintText() {} // 0x000000018372DDE0-0x000000018372DF40
	
		// Methods
		// [XID] // 0x000000018973E7A0-0x000000018973E7C0
		public void SaveState() {} // 0x000000018372D500-0x000000018372D5B0
		// [XID] // 0x0000000189745AA0-0x0000000189745AC0
		private void OnEnable() {} // 0x000000018372CA00-0x000000018372CC80
		// [XID] // 0x000000018974D5D0-0x000000018974D5F0
		public void Tick() {} // 0x000000018372DA40-0x000000018372DCC0
		// [XID] // 0x0000000189754C30-0x0000000189754C50
		private float FadeOut() => default; // 0x000000018372BB00-0x000000018372BC50
		// [XID] // 0x000000018975BDE0-0x000000018975BE00
		private void ShowHint() {} // 0x000000018372C250-0x000000018372C700
		// [XID] // 0x0000000189763780-0x00000001897637A0
		public void TryRefreshDesc() {} // 0x000000018372DCC0-0x000000018372DDE0
		// [XID] // 0x000000018976AF90-0x000000018976AFB0
		private bool New(ref QuestExcelConfigProxy cfg) => default; // 0x000000018372CE90-0x000000018372D1B0
		// [XID] // 0x00000001897725E0-0x0000000189772600
		private void Replace(ref QuestExcelConfigProxy cfg) {} // 0x000000018372B730-0x000000018372BB00
		// [XID] // 0x0000000189779BF0-0x0000000189779C10
		private void Complete(ref QuestExcelConfigProxy cfg) {} // 0x000000018372C7A0-0x000000018372CA00
		// [XID] // 0x0000000189781810-0x0000000189781830
		private void Fail(ref QuestExcelConfigProxy cfg, string title) {} // 0x000000018372C040-0x000000018372C250
		// [XID] // 0x0000000189788D10-0x0000000189788D30
		private void Remind(ref QuestExcelConfigProxy cfg) {} // 0x000000018372D1B0-0x000000018372D500
		// [XID] // 0x0000000189790280-0x00000001897902A0
		private void OnFadeOutFinished() {} // 0x000000018372C700-0x000000018372C7A0
		// [XID] // 0x00000001897C5C00-0x00000001897C5C20
		public void SetTrack() {} // 0x000000018372D5B0-0x000000018372DA40
		// [XID] // 0x00000001897CD3E0-0x00000001897CD400
		public bool CanTrackBtnClick() => default; // 0x000000018372BC50-0x000000018372BE80
		// [XID] // 0x00000001897D4A40-0x00000001897D4A60
		public void OnTrackBtnClick() {} // 0x000000018372CC80-0x000000018372CE90
		// [XID] // 0x00000001897DC0C0-0x00000001897DC0E0
		private void TryToRemoveFromRedPointList(uint mainId) {} // 0x000000018372BE80-0x000000018372C040
	}
}
