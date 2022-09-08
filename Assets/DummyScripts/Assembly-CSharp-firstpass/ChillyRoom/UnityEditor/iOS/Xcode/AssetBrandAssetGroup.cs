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
	internal class AssetBrandAssetGroup : AssetCatalogItem // TypeDefIndex: 10354
	{
		// Fields
		private List<AssetBrandAssetItem> m_Items; // 0x30
	
		// Nested types
		private class AssetBrandAssetItem // TypeDefIndex: 10355
		{
			// Fields
			internal string idiom; // 0x10
			internal string role; // 0x18
			internal int width; // 0x20
			internal int height; // 0x24
			internal AssetCatalogItem item; // 0x28
	
			// Constructors
			public AssetBrandAssetItem() {} // 0x00000001864C84B0-0x00000001864C8520
		}
	
		// Constructors
		public AssetBrandAssetGroup() {} // Dummy constructor
		internal AssetBrandAssetGroup(string assetCatalogPath, string name, string authorId) {} // 0x00000001864C8390-0x00000001864C84B0
	
		// Methods
		// [XID] // 0x000000018982D860-0x000000018982D880
		private void AddItem(AssetCatalogItem item, string idiom, string role, int width, int height) {} // 0x00000001864C7A30-0x00000001864C7D00
		// [XID] // 0x00000001895F5DA0-0x00000001895F5DC0
		public AssetImageSet OpenImageSet(string name, string idiom, string role, int width, int height) => default; // 0x00000001864C7D00-0x00000001864C7E60
		// [XID] // 0x00000001897DA5D0-0x00000001897DA5F0
		public AssetImageStack OpenImageStack(string name, string idiom, string role, int width, int height) => default; // 0x00000001864C7E60-0x00000001864C7FC0
		// [XID] // 0x000000018961CA60-0x000000018961CA80
		public override void Write(List<string> warnings) {} // 0x00000001864C7FC0-0x00000001864C8390
	}
}
