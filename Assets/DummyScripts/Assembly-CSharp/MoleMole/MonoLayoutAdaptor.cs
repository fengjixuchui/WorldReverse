/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoLayoutAdaptor : MonoBehaviour // TypeDefIndex: 30814
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<FieldVariants> fieldVariants; // 0x18
		private LayoutVersion _currVersion; // 0x20
		private bool _previewMobileJoystick; // 0x24
	
		// Nested types
		public enum FieldType // TypeDefIndex: 30815
		{
			Active = 0,
			PosX = 1,
			Width = 2,
			PosY = 3,
			Height = 4,
			Left = 5,
			Right = 6,
			Top = 7,
			Bottom = 8,
			Scale = 9
		}
	
		[Serializable]
		public struct FieldVariants // TypeDefIndex: 30816
		{
			// Fields
			public RectTransform target; // 0x00
			public FieldType fieldType; // 0x08
			public float[] variants; // 0x10
			public bool applyMobileJoystickFix; // 0x18
			public float mobileJoystickVaraint; // 0x1C
	
			// Methods
			// [XID] // 0x0000000189912610-0x0000000189912630
			public bool GetBool(int index) => default; // 0x0000000183F7D860-0x0000000183F7D990
			// [XID] // 0x0000000189919EE0-0x0000000189919F00
			public void SetBool(int index, bool value) {} // 0x0000000183F7D990-0x0000000183F7DB20
		}
	
		// Constructors
		public MonoLayoutAdaptor() {} // 0x0000000183F975F0-0x0000000183F97660
	
		// Methods
		// [XID] // 0x00000001898F42B0-0x00000001898F42D0
		private void Awake() {} // 0x0000000183F96B80-0x0000000183F96CA0
		// [XID] // 0x00000001898FBA60-0x00000001898FBA80
		private void OnEnable() {} // 0x0000000183F96CA0-0x0000000183F96DC0
		// [XID] // 0x0000000189903430-0x0000000189903450
		public void Refresh(LayoutVersion toVersion, bool force = false /* Metadata: 0x00B115B4 */) {} // 0x0000000183F96E70-0x0000000183F975F0
		// [XID] // 0x000000018990A980-0x000000018990A9A0
		public void PreviewMobileJoystick(bool preview) {} // 0x0000000183F96DC0-0x0000000183F96E70
	}
}
