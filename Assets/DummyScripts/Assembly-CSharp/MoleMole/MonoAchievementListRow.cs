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
	public class MonoAchievementListRow : MonoBehaviour // TypeDefIndex: 31141
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _rowBtn; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtName; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtProgress; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noticeContainer; // 0x38
		private bool _isSelected; // 0x40
	
		// Properties
		public Button rowBtn { /* [XID] */ /* 0x00000001898403A0-0x00000001898403C0 */ get => default; } // 0x0000000184C62FA0-0x0000000184C63040 
		public Image icon { /* [XID] */ /* 0x0000000189847950-0x0000000189847970 */ get => default; } // 0x0000000184C62DC0-0x0000000184C62E60 
		public UnityEngine.UI.Text txtName { /* [XID] */ /* 0x000000018984F0C0-0x000000018984F0E0 */ get => default; } // 0x0000000184C63040-0x0000000184C630E0 
		public UnityEngine.UI.Text txtProgress { /* [XID] */ /* 0x00000001898561C0-0x00000001898561E0 */ get => default; } // 0x0000000184C630E0-0x0000000184C63180 
		public uint goalId { /* [XID] */ /* 0x000000018985D550-0x000000018985D590 */ get; /* [XID] */ /* 0x0000000189867DD0-0x0000000189867E10 */ set; } // 0x0000000184C62D60-0x0000000184C62DC0 0x0000000184C63180-0x0000000184C631E0
		public bool isSelected { /* [XID] */ /* 0x00000001898722A0-0x00000001898722C0 */ get => default; /* [XID] */ /* 0x0000000189879F10-0x0000000189879F30 */ set {} } // 0x0000000184C62E60-0x0000000184C62F00 0x0000000184C631E0-0x0000000184C632B0
		public GameObject noticeContainer { /* [XID] */ /* 0x0000000189881050-0x0000000189881070 */ get => default; } // 0x0000000184C62F00-0x0000000184C62FA0 
	
		// Constructors
		public MonoAchievementListRow() {} // 0x0000000184C62CE0-0x0000000184C62D60
	}
}
