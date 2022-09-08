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
	public class MonoTheatreMechanicusCardRow : MonoBehaviour // TypeDefIndex: 31274
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cardDesc; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cardCurseDesc; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _costBuildingPoints; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconPlayer1; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconPlayer2; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconNoPlayer; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconOwner; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _grpCurse; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _grpCurseTips; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _labelCurse; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _labelChallenge; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectGO; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _completeGO; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _failGO; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _progressGO; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtBuffProgress; // 0xA8
		private bool _iconPlayer1Active; // 0xB0
		private bool _iconPlayer2Active; // 0xB1
		private bool _iconOwnerActive; // 0xB2
	
		// Properties
		public InBattleMechanicusCardChallengeState challengeState { /* [XID] */ /* 0x0000000189B11930-0x0000000189B11950 */ set {} } // 0x0000000183B6B920-0x0000000183B6BB50
		public UnityEngine.UI.Text txtBuffProgress { /* [XID] */ /* 0x0000000189B18C60-0x0000000189B18C80 */ get => default; } // 0x0000000183B6B870-0x0000000183B6B920 
		public Animator animator { /* [XID] */ /* 0x0000000189B20330-0x0000000189B20350 */ get => default; } // 0x0000000183B6B2C0-0x0000000183B6B360 
		public Image icon { /* [XID] */ /* 0x0000000189B27930-0x0000000189B27950 */ get => default; } // 0x0000000183B6B680-0x0000000183B6B720 
		public Button actionBtn { /* [XID] */ /* 0x0000000189B2EC10-0x0000000189B2EC30 */ get => default; } // 0x0000000183B6B220-0x0000000183B6B2C0 
		public UnityEngine.UI.Text cardDesc { /* [XID] */ /* 0x0000000189B364B0-0x0000000189B364D0 */ get => default; } // 0x0000000183B6B400-0x0000000183B6B4A0 
		public UnityEngine.UI.Text cardCurseDesc { /* [XID] */ /* 0x0000000189B3DC90-0x0000000189B3DCB0 */ get => default; } // 0x0000000183B6B360-0x0000000183B6B400 
		public UnityEngine.UI.Text costBuildingPoints { /* [XID] */ /* 0x0000000189B45A10-0x0000000189B45A30 */ get => default; } // 0x0000000183B6B4A0-0x0000000183B6B540 
		public Transform grpCurse { /* [XID] */ /* 0x0000000189B4CE90-0x0000000189B4CEB0 */ get => default; } // 0x0000000183B6B5E0-0x0000000183B6B680 
		public Transform grpCurseTips { /* [XID] */ /* 0x0000000189B545B0-0x0000000189B545D0 */ get => default; } // 0x0000000183B6B540-0x0000000183B6B5E0 
		public Transform labelCurse { /* [XID] */ /* 0x0000000189B5C180-0x0000000189B5C1A0 */ get => default; } // 0x0000000183B6B7D0-0x0000000183B6B870 
		public Transform labelChallenge { /* [XID] */ /* 0x0000000189B63780-0x0000000189B637A0 */ get => default; } // 0x0000000183B6B720-0x0000000183B6B7D0 
		public bool isSelected { /* [XID] */ /* 0x0000000189B6AF60-0x0000000189B6AF80 */ set {} } // 0x0000000183B6BB50-0x0000000183B6BC40
	
		// Constructors
		public MonoTheatreMechanicusCardRow() {} // 0x0000000183B6B150-0x0000000183B6B220
	
		// Methods
		// [XID] // 0x0000000189B725A0-0x0000000189B725C0
		public void SetSelfIcon(bool active) {} // 0x0000000183B6AF70-0x0000000183B6B150
		// [XID] // 0x0000000189B79AD0-0x0000000189B79AF0
		public void SetOthersIcon(bool active) {} // 0x0000000183B6ABF0-0x0000000183B6ADB0
		// [XID] // 0x0000000189B81240-0x0000000189B81260
		public void SetPlayerIcon(bool active = true /* Metadata: 0x00B1213A */) {} // 0x0000000183B6ADB0-0x0000000183B6AF70
	}
}
