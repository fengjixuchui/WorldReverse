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
	public class MonoHideandSeekPreviewDialog : MonoUIProxy // TypeDefIndex: 30115
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _tabList; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tips; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _mapGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _challengeGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _mapScroller; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _challengeScroller; // 0x70
	
		// Properties
		public MonoSimpleReusableList tabList { /* [XID] */ /* 0x00000001898DA560-0x00000001898DA580 */ get => default; } // 0x0000000184B5DFF0-0x0000000184B5E090 
		public MonoGridScroller mapScroller { /* [XID] */ /* 0x00000001898E2230-0x00000001898E2250 */ get => default; } // 0x0000000184B5DF50-0x0000000184B5DFF0 
		public MonoSimpleReusableList challengeScroller { /* [XID] */ /* 0x00000001898E9E10-0x00000001898E9E30 */ get => default; } // 0x0000000184B5DEB0-0x0000000184B5DF50 
		public string tips { /* [XID] */ /* 0x00000001898F1560-0x00000001898F1580 */ set {} } // 0x0000000184B5E090-0x0000000184B5E170
		public MonoUIContainer BtnReturn { /* [XID] */ /* 0x00000001899006E0-0x0000000189900700 */ get => default; } // 0x0000000184B5DDF0-0x0000000184B5DEB0 
		public MonoUIContainer BtnCheck { /* [XID] */ /* 0x0000000189907E30-0x0000000189907E50 */ get => default; } // 0x0000000184B5DC70-0x0000000184B5DD30 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x000000018990F5D0-0x000000018990F5F0 */ get => default; } // 0x0000000184B5DD30-0x0000000184B5DDF0 
	
		// Constructors
		public MonoHideandSeekPreviewDialog() {} // 0x0000000184B5DBF0-0x0000000184B5DC70
	
		// Methods
		// [XID] // 0x00000001898F8D40-0x00000001898F8D60
		public void SwitchPanel(bool mapPanel) {} // 0x0000000184B5DAE0-0x0000000184B5DBF0
	}
}
