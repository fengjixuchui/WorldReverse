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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoElementSwitch : MonoBehaviour // TypeDefIndex: 30752
	{
		// Fields
		public List<ElementVariants> elementVariants; // 0x18
		private LayoutVersion _version; // 0x20
		private bool _previewMobileJoystick; // 0x24
	
		// Nested types
		[Serializable]
		public struct ElementVariants // TypeDefIndex: 30753
		{
			// Fields
			public string name; // 0x00
			public bool inactive; // 0x08
			public Transform[] variants; // 0x10
			public bool applyMobileJoystick; // 0x18
			public Transform mobileJoystickVariant; // 0x20
	
			// Methods
			// [XID] // 0x0000000189BA77E0-0x0000000189BA7800
			public Transform GetVariant(LayoutVersion version) => default; // 0x0000000183C931F0-0x0000000183C93220
		}
	
		// Constructors
		public MonoElementSwitch() {} // 0x0000000183CA3400-0x0000000183CA3470
	
		// Methods
		// [XID] // 0x0000000189B5D960-0x0000000189B5D980
		private void Awake() {} // 0x0000000183CA2320-0x0000000183CA2450
		// [XID] // 0x0000000189B64EA0-0x0000000189B64EC0
		private void OnEnable() {} // 0x0000000183CA2A70-0x0000000183CA2BA0
		// [XID] // 0x0000000189B6C4A0-0x0000000189B6C4C0
		public void Refresh(LayoutVersion version, bool force = false /* Metadata: 0x00B1150B */) {} // 0x0000000183CA2C50-0x0000000183CA3070
		// [XID] // 0x0000000189B73BD0-0x0000000189B73BF0
		public Transform GetElementVariant(string name) => default; // 0x0000000183CA2670-0x0000000183CA2960
		// [XID] // 0x0000000189B7B1E0-0x0000000189B7B200
		public MonoUIContainer GetUIContainerVariant(string name) => default; // 0x0000000183CA2960-0x0000000183CA2A70
		// [XID] // 0x0000000189B82B90-0x0000000189B82BB0
		public void SetElementActive(string name, bool active) {} // 0x0000000183CA3070-0x0000000183CA3170
		// [XID] // 0x0000000189B8A1C0-0x0000000189B8A1E0
		public void SetElementVariantActive(string name, bool active) {} // 0x0000000183CA3170-0x0000000183CA3400
		// [XID] // 0x0000000189B91800-0x0000000189B91820
		public MonoUIContainer GetElementVariantContainer(string name) => default; // 0x0000000183CA2560-0x0000000183CA2670
		// [XID] // 0x0000000189B98BE0-0x0000000189B98C00
		public Button GetElementVariantButton(string name) => default; // 0x0000000183CA2450-0x0000000183CA2560
		public T GetElementVariantComponent<T>(string name)
			where T : Component => default;
		// [XID] // 0x0000000189B9FF00-0x0000000189B9FF20
		public void PreviewMobileJoystick(bool value) {} // 0x0000000183CA2BA0-0x0000000183CA2C50
	}
}
