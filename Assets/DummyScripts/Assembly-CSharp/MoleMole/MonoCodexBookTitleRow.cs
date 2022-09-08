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
	public class MonoCodexBookTitleRow : MonoBehaviour, INavSelectable // TypeDefIndex: 30491
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectMark; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _button; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _redpointMark; // 0x30
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x00000001897A1010-0x00000001897A1030 */ get => default; } // 0x0000000184BA0E60-0x0000000184BA0F00 
		public Button button { /* [XID] */ /* 0x00000001897A8680-0x00000001897A86A0 */ get => default; } // 0x0000000184BA0DC0-0x0000000184BA0E60 
		public bool isClicked { /* [XID] */ /* 0x00000001897B0080-0x00000001897B00A0 */ set {} } // 0x0000000184BA0F00-0x0000000184BA0FD0
	
		// Constructors
		public MonoCodexBookTitleRow() {} // 0x0000000184BA0D40-0x0000000184BA0DC0
	
		// Methods
		// [XID] // 0x00000001897B7DD0-0x00000001897B7DF0
		public void SetNavSelected(bool selected) {} // 0x0000000184BA0B60-0x0000000184BA0C50
		// [XID] // 0x00000001897BFE20-0x00000001897BFE40
		public void SetRedPoint(bool show) {} // 0x0000000184BA0C50-0x0000000184BA0D40
	}
}
