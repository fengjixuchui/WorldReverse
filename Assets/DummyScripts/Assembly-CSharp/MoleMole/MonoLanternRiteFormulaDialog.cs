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
	public class MonoLanternRiteFormulaDialog : MonoUIProxy // TypeDefIndex: 31238
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		public ItemInfo[] items; // 0x48
	
		// Properties
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x0000000189999850-0x0000000189999870 */ get => default; } // 0x0000000183F95D20-0x0000000183F95E30 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x00000001899A0F20-0x00000001899A0F40 */ get => default; } // 0x0000000183F95E30-0x0000000183F95F40 
	
		// Nested types
		[Serializable]
		public class ItemInfo // TypeDefIndex: 31239
		{
			// Fields
			public Button button; // 0x10
			public Image img; // 0x18
			public UnityEngine.UI.Text nameText; // 0x20
			public UnityEngine.UI.Text numText; // 0x28
	
			// Constructors
			public ItemInfo() {} // 0x0000000183F7DCC0-0x0000000183F7DD20
		}
	
		// Constructors
		public MonoLanternRiteFormulaDialog() {} // 0x0000000183F95CB0-0x0000000183F95D20
	}
}
