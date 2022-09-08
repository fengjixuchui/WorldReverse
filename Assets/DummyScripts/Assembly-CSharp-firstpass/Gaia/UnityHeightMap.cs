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

namespace Gaia
{
	public class UnityHeightMap : HeightMap // TypeDefIndex: 9342
	{
		// Fields
		public Bounds m_boundsWU; // 0x50
	
		// Constructors
		public UnityHeightMap() {} // 0x0000000185A43690-0x0000000185A43720
		public UnityHeightMap(int width, int depth) {} // 0x0000000185A43900-0x0000000185A43A10
		public UnityHeightMap(string path) {} // 0x0000000185A43430-0x0000000185A43530
		public UnityHeightMap(TextAsset source) {} // 0x0000000185A437E0-0x0000000185A43900
		public UnityHeightMap(UnityHeightMap source) {} // 0x0000000185A43720-0x0000000185A437E0
		public UnityHeightMap(Terrain terrain) {} // 0x0000000185A43530-0x0000000185A435D0
		public UnityHeightMap(Bounds bounds, string sourceFile) {} // 0x0000000185A435D0-0x0000000185A43690
		public UnityHeightMap(Texture2D texture) {} // 0x0000000185A43380-0x0000000185A43430
	
		// Methods
		// [XID] // 0x0000000189AF6770-0x0000000189AF6790
		public void InvertImage() {} // 0x0000000185A425D0-0x0000000185A42710
		// [XID] // 0x0000000189AFDD10-0x0000000189AFDD30
		public UnityHeightMap GetInvertClone(UnityHeightMap source) => default; // 0x0000000185A422C0-0x0000000185A42440
		// [XID] // 0x00000001897A63A0-0x00000001897A63C0
		public Bounds GetBoundsWU() => default; // 0x0000000185A421D0-0x0000000185A422C0
		// [XID] // 0x00000001896F7A90-0x00000001896F7AB0
		public Vector3 GetPositionWU() => default; // 0x0000000185A42440-0x0000000185A425D0
		// [XID] // 0x0000000189A381B0-0x0000000189A381D0
		public void SetBoundsWU(Bounds bounds) {} // 0x0000000185A431D0-0x0000000185A432A0
		// [XID] // 0x0000000189B1B9A0-0x0000000189B1B9C0
		public void SetPositionWU(Vector3 position) {} // 0x0000000185A432A0-0x0000000185A43380
		// [XID] // 0x00000001899698E0-0x0000000189969900
		public void LoadFromTerrain(Terrain terrain) {} // 0x0000000185A42710-0x0000000185A42A10
		// [XID] // 0x000000018960C3C0-0x000000018960C3E0
		public void SaveToTerrain(Terrain terrain) {} // 0x0000000185A42FA0-0x0000000185A431D0
		// [XID] // 0x0000000189706900-0x0000000189706920
		public void LoadFromTexture2D(Texture2D texture) {} // 0x0000000185A42A10-0x0000000185A42C30
		// [XID] // 0x0000000189B38FF0-0x0000000189B39010
		public void ReadRawFromTextAsset(TextAsset asset) {} // 0x0000000185A42C30-0x0000000185A42FA0
	}
}
