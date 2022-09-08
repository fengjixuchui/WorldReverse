/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class BoundInputField : MonoBehaviour // TypeDefIndex: 10010
	{
		// Fields
		private bool initialized; // 0x18
		private bool inputValid; // 0x19
		private InputField inputField; // 0x20
		private Image inputFieldBackground; // 0x28
		[NonSerialized]
		public string DefaultEmptyValue; // 0x30
		private string recentText; // 0x38
		private int m_skinVersion; // 0x40
		private UISkin m_skin; // 0x48
		private bool inputAltered; // 0x50
		public OnValueChangedDelegate OnValueChanged; // 0x58
		public OnValueChangedDelegate OnValueSubmitted; // 0x60
	
		// Properties
		public string Text { /* [XID] */ /* 0x0000000189928DA0-0x0000000189928DC0 */ get => default; /* [XID] */ /* 0x000000018970B1D0-0x000000018970B1F0 */ set {} } // 0x00000001868C56B0-0x00000001868C5760 0x00000001868C58F0-0x00000001868C5A40
		public UISkin Skin { /* [XID] */ /* 0x0000000189771240-0x0000000189771260 */ get => default; /* [XID] */ /* 0x0000000189A0FB90-0x0000000189A0FBB0 */ set {} } // 0x00000001868C5610-0x00000001868C56B0 0x00000001868C5760-0x00000001868C58F0
	
		// Nested types
		public delegate bool OnValueChangedDelegate(BoundInputField source, string input); // TypeDefIndex: 10011; 0x00000001868D81C0-0x00000001868D8470
	
		// Constructors
		public BoundInputField() {} // 0x00000001868C5550-0x00000001868C5610
	
		// Methods
		// [XID] // 0x0000000189954560-0x0000000189954580
		private void Awake() {} // 0x00000001868C4FE0-0x00000001868C5080
		// [XID] // 0x00000001896F9C10-0x00000001896F9C30
		public void Initialize() {} // 0x00000001868C5080-0x00000001868C5220
		// [XID] // 0x00000001896EEBE0-0x00000001896EEC00
		private void InputFieldValueChanged(string str) {} // 0x00000001868C5220-0x00000001868C53A0
		// [XID] // 0x000000018968D570-0x000000018968D590
		private void InputFieldValueSubmitted(string str) {} // 0x00000001868C53A0-0x00000001868C5550
	}
}
