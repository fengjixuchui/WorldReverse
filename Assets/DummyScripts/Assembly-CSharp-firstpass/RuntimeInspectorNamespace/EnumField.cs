/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class EnumField : InspectorField // TypeDefIndex: 9986
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image background; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image dropdownArrow; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform templateTransform; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image templateBackground; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image templateCheckmark; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text templateText; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Dropdown input; // 0xA0
		private static Dictionary<System.Type, List<string>> enumNames; // 0x00
		private static Dictionary<System.Type, List<object>> enumValues; // 0x08
		private List<string> currEnumNames; // 0xA8
		private List<object> currEnumValues; // 0xB0
	
		// Constructors
		public EnumField() {} // 0x00000001867EAF40-0x00000001867EAFF0
		static EnumField() {} // 0x00000001867EAE80-0x00000001867EAF40
	
		// Methods
		// [XID] // 0x0000000189B914D0-0x0000000189B914F0
		public override void Initialize() {} // 0x00000001867EA210-0x00000001867EA330
		// [XID] // 0x00000001899B62F0-0x00000001899B6310
		public override bool SupportsType(System.Type type) => default; // 0x00000001867EAC40-0x00000001867EAD00
		// [XID] // 0x00000001899BDF50-0x00000001899BDF70
		protected override void OnBound() {} // 0x00000001867EA330-0x00000001867EA6E0
		// [XID] // 0x0000000189BA73D0-0x0000000189BA73F0
		private void OnValueChanged(int input) {} // 0x00000001867EAA60-0x00000001867EAB40
		// [XID] // 0x0000000189A17BD0-0x0000000189A17BF0
		protected override void OnSkinChanged() {} // 0x00000001867EA6E0-0x00000001867EAA60
		// [XID] // 0x0000000189BB5E30-0x0000000189BB5E50
		public override void Refresh() {} // 0x00000001867EAB40-0x00000001867EAC40
	}
}
