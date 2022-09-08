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
	public class SignInItemController : MonoBehaviour // TypeDefIndex: 31301
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lights; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _highLight; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _gotMask; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _dayDes; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemName; // 0x38
		public SIGNIN_REWARD_STATE state; // 0x40
	
		// Properties
		public UnityEngine.UI.Text dayDesc { /* [XID] */ /* 0x0000000189A58260-0x0000000189A58280 */ get => default; } // 0x0000000184EF85F0-0x0000000184EF8690 
		public UnityEngine.UI.Text itemName { /* [XID] */ /* 0x0000000189A5FD20-0x0000000189A5FD40 */ get => default; } // 0x0000000184EF8690-0x0000000184EF8730 
	
		// Constructors
		public SignInItemController() {} // 0x0000000184EF8570-0x0000000184EF85F0
	
		// Methods
		// [XID] // 0x0000000189A679C0-0x0000000189A679E0
		public void SetItemState(SIGNIN_REWARD_STATE _state) {} // 0x0000000184EF8440-0x0000000184EF8570
	}
}
