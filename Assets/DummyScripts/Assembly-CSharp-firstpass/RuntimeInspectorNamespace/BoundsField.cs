/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class BoundsField : InspectorField // TypeDefIndex: 9980
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3Field inputCenter; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3Field inputExtents; // 0x78
		private MemberInfo centerVariable; // 0x80
		private MemberInfo extentsVariable; // 0x88
	
		// Properties
		protected override float HeightMultiplier { /* [XID] */ /* 0x0000000189A4F110-0x0000000189A4F130 */ get => default; } // 0x00000001868C6460-0x00000001868C6510 
	
		// Constructors
		public BoundsField() {} // 0x00000001868C6400-0x00000001868C6460
	
		// Methods
		// [XID] // 0x00000001898629D0-0x00000001898629F0
		public override void Initialize() {} // 0x00000001868C5A40-0x00000001868C5B80
		// [XID] // 0x0000000189A5E310-0x0000000189A5E330
		public override bool SupportsType(System.Type type) => default; // 0x00000001868C6060-0x00000001868C6150
		// [XID] // 0x0000000189A65BA0-0x0000000189A65BC0
		protected override void OnBound() {} // 0x00000001868C5B80-0x00000001868C5C80
		// [XID] // 0x0000000189A6D1D0-0x0000000189A6D1F0
		protected override void OnInspectorChanged() {} // 0x00000001868C5D80-0x00000001868C5E80
		// [XID] // 0x0000000189A74980-0x0000000189A749A0
		protected override void OnSkinChanged() {} // 0x00000001868C5E80-0x00000001868C5F80
		// [XID] // 0x0000000189A7C440-0x0000000189A7C460
		protected override void OnDepthChanged() {} // 0x00000001868C5C80-0x00000001868C5D80
		// [XID] // 0x0000000189A83DC0-0x0000000189A83DE0
		public override void Refresh() {} // 0x00000001868C5F80-0x00000001868C6060
	}
}
