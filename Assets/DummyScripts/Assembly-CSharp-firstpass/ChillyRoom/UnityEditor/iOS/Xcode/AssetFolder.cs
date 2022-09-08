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
	internal class AssetFolder : AssetCatalogItem // TypeDefIndex: 10341
	{
		// Fields
		private List<AssetCatalogItem> m_Items; // 0x30
		private bool m_ProvidesNamespace; // 0x38
	
		// Properties
		public bool providesNamespace { /* [XID] */ /* 0x0000000189B03D10-0x0000000189B03D30 */ get => default; /* [XID] */ /* 0x0000000189A95290-0x0000000189A952B0 */ set {} } // 0x00000001864CB4B0-0x00000001864CB550 0x00000001864CB550-0x00000001864CB660
	
		// Constructors
		public AssetFolder() {} // Dummy constructor
		internal AssetFolder(string parentPath, string name, string authorId) {} // 0x00000001864CB3C0-0x00000001864CB4B0
	
		// Methods
		// [XID] // 0x0000000189B12B90-0x0000000189B12BB0
		public AssetFolder OpenFolder(string name) => default; // 0x00000001864CAC10-0x00000001864CADF0
		private T GetExistingItemWithType<T>(string name)
			where T : class => default;
		// [XID] // 0x0000000189B19FA0-0x0000000189B19FC0
		public AssetDataSet OpenDataSet(string name) => default; // 0x00000001864CAAE0-0x00000001864CAC10
		// [XID] // 0x0000000189B21450-0x0000000189B21470
		public AssetImageSet OpenImageSet(string name) => default; // 0x00000001864CADF0-0x00000001864CAF20
		// [XID] // 0x0000000189B28CA0-0x0000000189B28CC0
		public AssetImageStack OpenImageStack(string name) => default; // 0x00000001864CAF20-0x00000001864CB050
		// [XID] // 0x0000000189AD6BD0-0x0000000189AD6BF0
		public AssetBrandAssetGroup OpenBrandAssetGroup(string name) => default; // 0x00000001864CA9B0-0x00000001864CAAE0
		// [XID] // 0x00000001899B6930-0x00000001899B6950
		public AssetCatalogItem GetChild(string name) => default; // 0x00000001864CA7B0-0x00000001864CA9B0
		// [XID] // 0x00000001897FE540-0x00000001897FE560
		private void WriteJson() {} // 0x00000001864CB050-0x00000001864CB1E0
		// [XID] // 0x0000000189B824D0-0x0000000189B824F0
		public override void Write(List<string> warnings) {} // 0x00000001864CB1E0-0x00000001864CB3C0
	}
}
