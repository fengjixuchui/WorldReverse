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
	public class MonoEquipScreeningRow : MonoBehaviour // TypeDefIndex: 30757
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _actionButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _setName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _num; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _btnCanvas; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _nameCanvas; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _numCanvas; // 0x40
		private bool _isRowDisable; // 0x48
	
		// Properties
		public UnityEngine.UI.Text setName { /* [XID] */ /* 0x00000001897A0FD0-0x00000001897A0FF0 */ get => default; } // 0x0000000183CB0200-0x0000000183CB02A0 
		public UnityEngine.UI.Text num { /* [XID] */ /* 0x00000001897A8640-0x00000001897A8660 */ get => default; } // 0x0000000183CB0160-0x0000000183CB0200 
		public Button actionButton { /* [XID] */ /* 0x00000001897B0040-0x00000001897B0060 */ get => default; } // 0x0000000183CB0020-0x0000000183CB00C0 
		public bool isRowDisable { /* [XID] */ /* 0x00000001897B7D90-0x00000001897B7DB0 */ get => default; } // 0x0000000183CB00C0-0x0000000183CB0160 
		public bool highlighted { /* [XID] */ /* 0x00000001897C7700-0x00000001897C7720 */ set {} } // 0x0000000183CB02A0-0x0000000183CB0390
	
		// Constructors
		public MonoEquipScreeningRow() {} // 0x0000000183CAFFA0-0x0000000183CB0020
	
		// Methods
		// [XID] // 0x00000001897BFDE0-0x00000001897BFE00
		public void SetEquipScreeningRow(BagPageScreenType type, uint setId, int num) {} // 0x0000000183CAFC90-0x0000000183CAFFA0
		// [XID] // 0x00000001897CE9A0-0x00000001897CE9C0
		public void SetDisable(bool disable) {} // 0x0000000183CAFB60-0x0000000183CAFC90
	}
}
