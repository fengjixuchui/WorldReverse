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
	public class MonoActivityDragonSpineChapterBtn : MonoSpriteProxy // TypeDefIndex: 30329
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Button _actionButton; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _processText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _imgIcons; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockTrans; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconLockedTrans; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconUnlockTrans; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockHintInfo; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockPreTask; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x70
		private readonly int UnLockHash; // 0x78
		private bool _bTrigger; // 0x7C
		private bool _isLocked; // 0x7D
		private bool _bSetSelected; // 0x7E
		private bool _isToSelected; // 0x7F
		private bool _hightlighted; // 0x80
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189854B20-0x0000000189854B40 */ get => default; } // 0x000000018630EB00-0x000000018630EBA0 
		public Button actionButton { /* [XID] */ /* 0x000000018985C380-0x000000018985C3A0 */ get => default; } // 0x000000018630E730-0x000000018630E7D0 
		public UnityEngine.UI.Text processText { /* [XID] */ /* 0x0000000189863CC0-0x0000000189863CE0 */ get => default; } // 0x000000018630E9C0-0x000000018630EA60 
		public UnityEngine.UI.Text lockHintInfo { /* [XID] */ /* 0x000000018986AFD0-0x000000018986AFF0 */ get => default; } // 0x000000018630E880-0x000000018630E920 
		public UnityEngine.UI.Text lockPreTask { /* [XID] */ /* 0x00000001898723A0-0x00000001898723C0 */ get => default; } // 0x000000018630E920-0x000000018630E9C0 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x0000000189879FD0-0x0000000189879FF0 */ get => default; } // 0x000000018630EA60-0x000000018630EB00 
		public bool highlight { /* [XID] */ /* 0x00000001898AD5F0-0x00000001898AD610 */ get => default; /* [XID] */ /* 0x00000001898B4B90-0x00000001898B4BB0 */ set {} } // 0x000000018630E7D0-0x000000018630E880 0x000000018630EBA0-0x000000018630ED20
	
		// Constructors
		public MonoActivityDragonSpineChapterBtn() {} // 0x000000018630E680-0x000000018630E730
	
		// Methods
		// [XID] // 0x0000000189881150-0x0000000189881170
		public void SetChapterIndex(int index) {} // 0x000000018630E150-0x000000018630E2B0
		// [XID] // 0x0000000189888720-0x0000000189888740
		public void SetLockState(bool isLocked) {} // 0x000000018630E2B0-0x000000018630E470
		// [XID] // 0x000000018988FB00-0x000000018988FB20
		private void OnEnable() {} // 0x000000018630E020-0x000000018630E150
		// [XID] // 0x0000000189896FE0-0x0000000189897000
		private void Update() {} // 0x000000018630E560-0x000000018630E680
		// [XID] // 0x000000018989E520-0x000000018989E540
		private void OnDisable() {} // 0x000000018630DF80-0x000000018630E020
		// [XID] // 0x00000001898A6040-0x00000001898A6060
		public void SetSelectedState(bool selected) {} // 0x000000018630E470-0x000000018630E560
	}
}
