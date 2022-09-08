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
	public class MonoFleurFairMiniGameRow : MonoBehaviour // TypeDefIndex: 30385
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _detailBtn; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _rewardBtn; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _missionDesc; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bestScore; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockTimeText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _notChallenged; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeMask; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockedIcon; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _newTag; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _bestScoreRootTrans; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoFleurFairMiniGameRewardBtn _miniGameRewardBtn; // 0x70
		public const int LOCKED = 0; // Metadata: 0x00B10A0B
		public const int OPENED_NO_CHALLENGE = 1; // Metadata: 0x00B10A0F
		public const int CHALLENGED = 2; // Metadata: 0x00B10A13
		private readonly int STATE_HASH; // 0x78
		private int _toSetState; // 0x7C
	
		// Properties
		public Button detailBtn { /* [XID] */ /* 0x00000001899396A0-0x00000001899396C0 */ get => default; } // 0x0000000184ADD520-0x0000000184ADD5C0 
		public Button rewardBtn { /* [XID] */ /* 0x0000000189940930-0x0000000189940950 */ get => default; } // 0x0000000184ADD660-0x0000000184ADD700 
		public UnityEngine.UI.Text missionDesc { /* [XID] */ /* 0x00000001899481D0-0x00000001899481F0 */ get => default; } // 0x0000000184ADD5C0-0x0000000184ADD660 
		public UnityEngine.UI.Text bestScore { /* [XID] */ /* 0x000000018994F950-0x000000018994F970 */ get => default; } // 0x0000000184ADD480-0x0000000184ADD520 
		public UnityEngine.UI.Text unlockTimeText { /* [XID] */ /* 0x0000000189956F10-0x0000000189956F30 */ get => default; } // 0x0000000184ADD700-0x0000000184ADD7A0 
		public Transform bestScoreRootTrans { /* [XID] */ /* 0x000000018995EA80-0x000000018995EAA0 */ get => default; } // 0x0000000184ADD3E0-0x0000000184ADD480 
		public int CurState { /* [XID] */ /* 0x00000001899661A0-0x00000001899661E0 */ get; /* [XID] */ /* 0x0000000189970B90-0x0000000189970BD0 */ private set; } // 0x0000000184ADD380-0x0000000184ADD3E0 0x0000000184ADCEA0-0x0000000184ADCF10
		public bool CanTakeReward { /* [XID] */ /* 0x0000000189991C40-0x0000000189991C80 */ get; /* [XID] */ /* 0x000000018999C730-0x000000018999C770 */ set; } // 0x0000000184ADD320-0x0000000184ADD380 0x0000000184ADD7A0-0x0000000184ADD810
	
		// Constructors
		public MonoFleurFairMiniGameRow() {} // 0x0000000184ADD270-0x0000000184ADD320
	
		// Methods
		// [XID] // 0x000000018997B070-0x000000018997B090
		public void SetState(int state) {} // 0x0000000184ADD0F0-0x0000000184ADD270
		// [XID] // 0x0000000189982BA0-0x0000000189982BC0
		public void SetRewardState(int state) {} // 0x0000000184ADCFF0-0x0000000184ADD0F0
		// [XID] // 0x000000018998A370-0x000000018998A390
		public void SetNewTag(bool isNew) {} // 0x0000000184ADCF10-0x0000000184ADCFF0
		// [XID] // 0x00000001899A7210-0x00000001899A7230
		private void LateUpdate() {} // 0x0000000184ADCD80-0x0000000184ADCEA0
	}
}
