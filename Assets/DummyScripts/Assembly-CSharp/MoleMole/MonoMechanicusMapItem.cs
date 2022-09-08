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
	public class MonoMechanicusMapItem : MonoSpriteProxy // TypeDefIndex: 30394
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mapName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _mapIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockGrp; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockTips; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _new; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selected; // 0x50
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x0000000189760B50-0x0000000189760B70 */ get => default; } // 0x000000018493ECD0-0x000000018493ED70 
		public bool selected { /* [XID] */ /* 0x0000000189767E10-0x0000000189767E30 */ set {} } // 0x000000018493EE60-0x000000018493EF50
		public bool ShowNew { /* [XID] */ /* 0x000000018977E4C0-0x000000018977E4E0 */ set {} } // 0x000000018493ED70-0x000000018493EE60
	
		// Constructors
		public MonoMechanicusMapItem() {} // 0x000000018493EC50-0x000000018493ECD0
	
		// Methods
		// [XID] // 0x000000018976F3E0-0x000000018976F400
		public void SetMap(uint mapID) {} // 0x000000018493E8C0-0x000000018493EC50
		// [XID] // 0x0000000189776E00-0x0000000189776E20
		public void SetHideAndSeekMap(uint mapID, bool isOpen) {} // 0x000000018493E710-0x000000018493E8C0
	}
}
