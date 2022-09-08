/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MemoryAssetList // TypeDefIndex: 31578
{
	// Fields
	private SizeComparer _sizeComparer; // 0x10
	private List<AssetItem> _list; // 0x18
	private int _max; // 0x20

	// Nested types
	public struct AssetItem // TypeDefIndex: 31579
	{
		// Fields
		public uint _sizeKB; // 0x00
		public string _name; // 0x08
		public string _prefabName; // 0x10

		// Constructors
		public AssetItem(uint sizeKb, string name) {
			_sizeKB = default;
			_name = default;
			_prefabName = default;
		} // 0x0000000184CF2F30-0x0000000184CF3000
		public AssetItem(uint sizeKb, string name, string inPrefabName) {
			_sizeKB = default;
			_name = default;
			_prefabName = default;
		} // 0x0000000184CF3000-0x0000000184CF3010

		// Methods
		// [XID] // 0x00000001898A2AA0-0x00000001898A2AC0
		public string ToLog(bool bNeedPrefabPath) => default; // 0x0000000184CF2EA0-0x0000000184CF2F30
	}

	public class SizeComparer : IComparer<AssetItem> // TypeDefIndex: 31580
	{
		// Constructors
		public SizeComparer() {} // 0x0000000184CF3120-0x0000000184CF3180

		// Methods
		// [XID] // 0x0000000189AC3300-0x0000000189AC3320
		public int Compare(AssetItem x, AssetItem y) => default; // 0x0000000184CF3010-0x0000000184CF3120
	}

	// Constructors
	public MemoryAssetList() {} // Dummy constructor
	public MemoryAssetList(int max = 200 /* Metadata: 0x00B13347 */) {} // 0x0000000184CF3630-0x0000000184CF3730

	// Methods
	// [XID] // 0x0000000189A96030-0x0000000189A96050
	public void Add(uint size, string name) {} // 0x0000000184CF32D0-0x0000000184CF3460
	// [XID] // 0x0000000189A9D570-0x0000000189A9D590
	public void ClampToMaxNum() {} // 0x0000000184CF3520-0x0000000184CF3630
	// [XID] // 0x0000000189AA4DA0-0x0000000189AA4DC0
	public void Sort() {} // 0x0000000184CF3460-0x0000000184CF3520
	// [XID] // 0x0000000189AAC5C0-0x0000000189AAC5E0
	public List<AssetItem> GetList() => default; // 0x0000000184CF3180-0x0000000184CF3220
	// [XID] // 0x0000000189ABFDF0-0x0000000189ABFE10
	public void Clear() {} // 0x0000000184CF3220-0x0000000184CF32D0
}

