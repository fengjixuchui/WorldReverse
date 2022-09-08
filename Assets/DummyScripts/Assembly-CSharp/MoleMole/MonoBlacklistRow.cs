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
	public class MonoBlacklistRow : MonoBehaviour // TypeDefIndex: 30704
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _iconBtn; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameLabel; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _ps4ID; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _selectBtn; // 0x48
	
		// Properties
		public Sprite icon { /* [XID] */ /* 0x000000018980C170-0x000000018980C190 */ set {} } // 0x00000001849033E0-0x00000001849034A0
		public string playerName { /* [XID] */ /* 0x0000000189813920-0x0000000189813940 */ set {} } // 0x0000000184903570-0x0000000184903640
		public string levelString { /* [XID] */ /* 0x000000018981B430-0x000000018981B450 */ set {} } // 0x00000001849034A0-0x0000000184903570
		public MonoUIContainer ps4ID { /* [XID] */ /* 0x0000000189822AA0-0x0000000189822AC0 */ get => default; } // 0x0000000184903280-0x0000000184903320 
		public Button iconBtn { /* [XID] */ /* 0x000000018982A3F0-0x000000018982A410 */ get => default; } // 0x00000001849031E0-0x0000000184903280 
		public MonoUIContainer removeBtn { /* [XID] */ /* 0x0000000189831700-0x0000000189831720 */ get => default; } // 0x0000000184903320-0x00000001849033E0 
	
		// Nested types
		public enum SelectState // TypeDefIndex: 30705
		{
			None = 0,
			Select = 1,
			UnSelect = 2
		}
	
		// Constructors
		public MonoBlacklistRow() {} // 0x0000000184903160-0x00000001849031E0
	
		// Methods
		// [XID] // 0x0000000189838E00-0x0000000189838E20
		public void SetSelectState(SelectState state) {} // 0x0000000184902F00-0x0000000184903160
	}
}
