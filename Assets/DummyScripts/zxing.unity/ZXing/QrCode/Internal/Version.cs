/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.QrCode.Internal
{
	public sealed class Version // TypeDefIndex: 4602
	{
		// Fields
		private static readonly int[] VERSION_DECODE_INFO; // 0x00
		private static readonly Version[] VERSIONS; // 0x08
		private readonly int versionNumber; // 0x10
		private readonly int[] alignmentPatternCenters; // 0x18
		private readonly ECBlocks[] ecBlocks; // 0x20
		private readonly int totalCodewords; // 0x28
	
		// Properties
		public int VersionNumber { get => default; } // 0x0000000188DC4620-0x0000000188DC4680 
		public int TotalCodewords { get => default; } // 0x0000000188DC45C0-0x0000000188DC4620 
		public int DimensionForVersion { get => default; } // 0x0000000188DC4560-0x0000000188DC45C0 
	
		// Nested types
		public sealed class ECBlocks // TypeDefIndex: 4603
		{
			// Fields
			private readonly int ecCodewordsPerBlock; // 0x10
			private readonly ECB[] ecBlocks; // 0x18
	
			// Properties
			public int ECCodewordsPerBlock { get => default; } // 0x0000000188DA4FE0-0x0000000188DA5040 
			public int NumBlocks { get => default; } // 0x0000000188DA5040-0x0000000188DA5130 
			public int TotalECCodewords { get => default; } // 0x0000000188DA5130-0x0000000188DA51B0 
	
			// Constructors
			public ECBlocks() {} // Dummy constructor
			internal ECBlocks(int ecCodewordsPerBlock, params /* 0x000000018989F6F0-0x000000018989F700 */ ECB[] ecBlocks) {} // 0x0000000188DA4F00-0x0000000188DA4F80
	
			// Methods
			public ECB[] getECBlocks() => default; // 0x0000000188DA4F80-0x0000000188DA4FE0
		}
	
		public sealed class ECB // TypeDefIndex: 4604
		{
			// Fields
			private readonly int count; // 0x10
			private readonly int dataCodewords; // 0x14
	
			// Properties
			public int Count { get => default; } // 0x0000000188DA4E40-0x0000000188DA4EA0 
			public int DataCodewords { get => default; } // 0x0000000188DA4EA0-0x0000000188DA4F00 
	
			// Constructors
			public ECB() {} // Dummy constructor
			internal ECB(int count, int dataCodewords) {} // 0x0000000188DA4DC0-0x0000000188DA4E40
		}
	
		// Constructors
		public Version() {} // Dummy constructor
		private Version(int versionNumber, int[] alignmentPatternCenters, params /* 0x000000018989F6F0-0x000000018989F700 */ ECBlocks[] ecBlocks) {} // 0x0000000188DB8880-0x0000000188DB8AE0
		static Version() {} // 0x0000000188DB87C0-0x0000000188DB8880
	
		// Methods
		public ECBlocks getECBlocksForLevel(ErrorCorrectionLevel ecLevel) => default; // 0x0000000188DC4380-0x0000000188DC4460
		public static Version getVersionForNumber(int versionNumber) => default; // 0x0000000188DC4460-0x0000000188DC4560
		public override string ToString() => default; // 0x0000000188DB8730-0x0000000188DB87C0
		private static Version[] buildVersions() => default; // 0x0000000188DB8AE0-0x0000000188DC4380
	}
}
