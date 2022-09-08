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
	public class MonoServerSelectDialog : MonoUIProxy // TypeDefIndex: 30581
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		public MonoGridScroller scroll; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public UnityEngine.UI.Text nameText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject tips; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject selectPanel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject actions; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x68
	
		// Properties
		public Button cancelButton { /* [XID] */ /* 0x0000000189B4A1B0-0x0000000189B4A1D0 */ get => default; } // 0x0000000184118380-0x0000000184118440 
		public Button closeButton { /* [XID] */ /* 0x0000000189B519B0-0x0000000189B519D0 */ get => default; } // 0x0000000184118440-0x0000000184118500 
		public Button confirmButton { /* [XID] */ /* 0x0000000189B59170-0x0000000189B59190 */ get => default; } // 0x0000000184118500-0x00000001841185C0 
		public Button selectButton { /* [XID] */ /* 0x0000000189B609A0-0x0000000189B609C0 */ get => default; } // 0x00000001841185C0-0x0000000184118680 
	
		// Constructors
		public MonoServerSelectDialog() {} // 0x0000000184118300-0x0000000184118380
	
		// Methods
		// [XID] // 0x0000000189B680F0-0x0000000189B68110
		public void FadeIn() {} // 0x0000000184117AE0-0x0000000184117BF0
		// [XID] // 0x0000000189B6F490-0x0000000189B6F4B0
		public new void FadeOut() {} // 0x0000000184117BF0-0x0000000184117D00
		// [XID] // 0x0000000189B76B10-0x0000000189B76B30
		public void OnConfirmShow() {} // 0x0000000184117D00-0x0000000184118000
		// [XID] // 0x0000000189B7E0C0-0x0000000189B7E0E0
		public void OnSelectShow() {} // 0x0000000184118000-0x0000000184118300
	}
}
