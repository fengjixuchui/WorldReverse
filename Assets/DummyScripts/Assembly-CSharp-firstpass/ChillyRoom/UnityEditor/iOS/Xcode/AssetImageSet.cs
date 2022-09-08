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
	internal class AssetImageSet : AssetCatalogItemWithVariants // TypeDefIndex: 10350
	{
		// Nested types
		private class ImageSetVariant : AssetCatalogItemWithVariants.VariantData // TypeDefIndex: 10351
		{
			// Fields
			public ImageAlignment alignment; // 0x20
			public ImageResizing resizing; // 0x28
	
			// Constructors
			public ImageSetVariant() {} // Dummy constructor
			public ImageSetVariant(DeviceRequirement requirement, string path) {} // 0x00000001864DAA00-0x00000001864DAA90
		}
	
		// Constructors
		public AssetImageSet() {} // Dummy constructor
		internal AssetImageSet(string assetCatalogPath, string name, string authorId) {} // 0x00000001864CC190-0x00000001864CC280
	
		// Methods
		// [IDTag] // 0x0000000189B82670-0x0000000189B826B0
		// [XID] // 0x0000000189B82670-0x0000000189B826B0
		public void AddVariant(DeviceRequirement requirement, string path) {} // 0x00000001864CB660-0x00000001864CB760
		// [IDTag] // 0x0000000189B8C770-0x0000000189B8C7B0
		// [XID] // 0x0000000189B8C770-0x0000000189B8C7B0
		public void AddVariant(DeviceRequirement requirement, string path, ImageAlignment alignment, ImageResizing resizing) {} // 0x00000001864CB760-0x00000001864CB890
		// [XID] // 0x0000000189B96E60-0x0000000189B96E80
		private void WriteAlignmentToJson(JsonElementDict item, ImageAlignment alignment) {} // 0x00000001864CBA30-0x00000001864CBB90
		// [XID] // 0x0000000189B9E2D0-0x0000000189B9E2F0
		private static string GetSlicingMode(ImageResizing.SlicingType mode) => default; // 0x00000001864CB960-0x00000001864CBA30
		// [XID] // 0x0000000189BDBA30-0x0000000189BDBA50
		private static string GetCenterResizeMode(ImageResizing.ResizeMode mode) => default; // 0x00000001864CB890-0x00000001864CB960
		// [XID] // 0x0000000189BACFC0-0x0000000189BACFE0
		private void WriteResizingToJson(JsonElementDict item, ImageResizing resizing) {} // 0x00000001864CBB90-0x00000001864CBDA0
		// [XID] // 0x00000001895F75F0-0x00000001895F7610
		public override void Write(List<string> warnings) {} // 0x00000001864CBDA0-0x00000001864CC190
	}
}
