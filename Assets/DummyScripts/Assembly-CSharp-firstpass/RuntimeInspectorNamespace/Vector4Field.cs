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
	public class Vector4Field : InspectorField // TypeDefIndex: 10009
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField inputX; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField inputY; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField inputZ; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField inputW; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text labelX; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text labelY; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text labelZ; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text labelW; // 0xA8
		private bool isQuaternion; // 0xB0
	
		// Properties
		protected override float HeightMultiplier { /* [XID] */ /* 0x0000000189624080-0x00000001896240A0 */ get => default; } // 0x0000000186759210-0x00000001867592C0 
	
		// Constructors
		public Vector4Field() {} // 0x00000001867591B0-0x0000000186759210
	
		// Methods
		// [XID] // 0x00000001897AFBD0-0x00000001897AFBF0
		public override void Initialize() {} // 0x0000000186757BD0-0x0000000186757F60
		// [XID] // 0x00000001897B7930-0x00000001897B7950
		public override bool SupportsType(System.Type type) => default; // 0x0000000186758E90-0x0000000186758FC0
		// [XID] // 0x00000001899C00B0-0x00000001899C00D0
		protected override void OnBound() {} // 0x0000000186757F60-0x00000001867583A0
		// [XID] // 0x00000001896422B0-0x00000001896422D0
		private bool OnValueChanged(BoundInputField source, string input) => default; // 0x0000000186758580-0x00000001867588E0
		// [XID] // 0x0000000189649A80-0x0000000189649AA0
		protected override void OnSkinChanged() {} // 0x00000001867583A0-0x0000000186758580
		// [XID] // 0x000000018967F480-0x000000018967F4A0
		public override void Refresh() {} // 0x00000001867588E0-0x0000000186758E90
	}
}
