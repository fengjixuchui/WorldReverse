/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode
{
	internal abstract class AssetCatalogItemWithVariants : AssetCatalogItem // TypeDefIndex: 10342
	{
		// Fields
		protected List<VariantData> m_Variants; // 0x30
		protected List<string> m_ODRTags; // 0x38
	
		// Nested types
		protected class VariantData // TypeDefIndex: 10343
		{
			// Fields
			public DeviceRequirement requirement; // 0x10
			public string path; // 0x18
	
			// Constructors
			public VariantData() {} // Dummy constructor
			public VariantData(DeviceRequirement requirement, string path) {} // 0x00000001864E6170-0x00000001864E6200
		}
	
		// Constructors
		protected AssetCatalogItemWithVariants() {} // Dummy constructor
		protected AssetCatalogItemWithVariants(string name, string authorId) {} // 0x00000001864C8FF0-0x00000001864C90B0
	
		// Methods
		// [XID] // 0x0000000189B4E470-0x0000000189B4E490
		public bool HasVariant(DeviceRequirement requirement) => default; // 0x00000001864C89A0-0x00000001864C8B90
		// [XID] // 0x00000001896749F0-0x0000000189674A10
		public void AddOnDemandResourceTag(string tag) {} // 0x00000001864C8520-0x00000001864C8610
		// [XID] // 0x0000000189B912C0-0x0000000189B912E0
		protected void AddVariant(VariantData newItem) {} // 0x00000001864C8610-0x00000001864C89A0
		// [XID] // 0x0000000189BBD330-0x0000000189BBD350
		protected void WriteODRTagsToJson(JsonElementDict info) {} // 0x00000001864C8B90-0x00000001864C8D80
		// [XID] // 0x0000000189B6BF60-0x0000000189B6BF80
		protected void WriteRequirementsToJson(JsonElementDict item, DeviceRequirement req) {} // 0x00000001864C8D80-0x00000001864C8FF0
	}
}
