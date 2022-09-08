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
	public class MonoArenaChallengeListRow : MonoBehaviour // TypeDefIndex: 30365
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitle; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDesc; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockGO; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noticeContainer; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _monsterLockMask; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _monsterIcon; // 0x50
	
		// Properties
		public Animator animator { /* [XID] */ /* 0x00000001897D9710-0x00000001897D9730 */ get => default; } // 0x0000000184C91910-0x0000000184C919B0 
		public GameObject noticeContainer { /* [XID] */ /* 0x00000001897E0A90-0x00000001897E0AB0 */ get => default; } // 0x0000000184C91B90-0x0000000184C91C30 
		public GameObject monsterLockMask { /* [XID] */ /* 0x00000001897E8150-0x00000001897E8170 */ get => default; } // 0x0000000184C91AF0-0x0000000184C91B90 
		public Image monsterIcon { /* [XID] */ /* 0x00000001897EFDF0-0x00000001897EFE10 */ get => default; } // 0x0000000184C91A50-0x0000000184C91AF0 
		public Button actionBtn { /* [XID] */ /* 0x00000001897F75E0-0x00000001897F7600 */ get => default; } // 0x0000000184C91870-0x0000000184C91910 
		public UnityEngine.UI.Text txtTitle { /* [XID] */ /* 0x00000001897FECF0-0x00000001897FED10 */ get => default; } // 0x0000000184C91CD0-0x0000000184C91D70 
		public UnityEngine.UI.Text txtDesc { /* [XID] */ /* 0x0000000189806430-0x0000000189806450 */ get => default; } // 0x0000000184C91C30-0x0000000184C91CD0 
		public GameObject lockGO { /* [XID] */ /* 0x000000018980DB10-0x000000018980DB30 */ get => default; } // 0x0000000184C919B0-0x0000000184C91A50 
		public bool select { /* [XID] */ /* 0x00000001898240F0-0x0000000189824110 */ set {} } // 0x0000000184C91F60-0x0000000184C921A0
		public bool highlighted { /* [XID] */ /* 0x000000018982BAF0-0x000000018982BB10 */ set {} } // 0x0000000184C91D70-0x0000000184C91F60
	
		// Constructors
		public MonoArenaChallengeListRow() {} // 0x0000000184C917E0-0x0000000184C91870
	
		// Methods
		// [XID] // 0x00000001898152B0-0x00000001898152D0
		public void SetLock(uint leftDay) {} // 0x0000000184C91540-0x0000000184C916B0
		// [XID] // 0x000000018981CCB0-0x000000018981CCD0
		public void SetUnLock() {} // 0x0000000184C916B0-0x0000000184C917E0
	}
}
