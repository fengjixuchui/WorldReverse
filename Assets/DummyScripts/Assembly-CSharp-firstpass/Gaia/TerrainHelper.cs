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
	public class TerrainHelper : MonoBehaviour // TypeDefIndex: 9340
	{
		// Fields
		// [Range] // 0x0000000189A154A0-0x0000000189A154F0
		// [Tooltip] // 0x0000000189A154A0-0x0000000189A154F0
		public int m_smoothIterations; // 0x18
	
		// Constructors
		public TerrainHelper() {} // 0x000000018645EBB0-0x000000018645EC20
	
		// Methods
		// [XID] // 0x0000000189A20F80-0x0000000189A20FA0
		private void Awake() {} // 0x000000018645C550-0x000000018645C610
		// [XID] // 0x0000000189A28320-0x0000000189A28340
		public static void Flatten() {} // 0x000000018645CDE0-0x000000018645CE80
		// [IDTag] // 0x0000000189A2FBB0-0x0000000189A2FBF0
		// [XID] // 0x0000000189A2FBB0-0x0000000189A2FBF0
		public static void FlattenTerrain(Terrain terrain) {} // 0x000000018645CAE0-0x000000018645CC30
		// [IDTag] // 0x0000000189A3A2F0-0x0000000189A3A330
		// [XID] // 0x0000000189A3A2F0-0x0000000189A3A330
		public static void FlattenTerrain(Terrain[] terrains) {} // 0x000000018645CC30-0x000000018645CDE0
		// [XID] // 0x0000000189A44A60-0x0000000189A44A80
		public static void Stitch() {} // 0x000000018645EB10-0x000000018645EBB0
		// [XID] // 0x0000000189B57D90-0x0000000189B57DB0
		public static void StitchTerrains(Terrain[] terrains) {} // 0x000000018645E590-0x000000018645EB10
		// [IDTag] // 0x0000000189A53910-0x0000000189A53950
		// [XID] // 0x0000000189A53910-0x0000000189A53950
		public void Smooth() {} // 0x000000018645E4F0-0x000000018645E590
		// [IDTag] // 0x0000000189A5E380-0x0000000189A5E3C0
		// [XID] // 0x0000000189A5E380-0x0000000189A5E3C0
		public static void Smooth(int iterations) {} // 0x000000018645E3F0-0x000000018645E4F0
		// [XID] // 0x0000000189A68F90-0x0000000189A68FB0
		public static Vector3 GetActiveTerrainCenter(bool flushToGround = true /* Metadata: 0x00AE5766 */) => default; // 0x000000018645CE80-0x000000018645D090
		// [XID] // 0x0000000189A70330-0x0000000189A70350
		public static Terrain GetActiveTerrain() => default; // 0x000000018645D450-0x000000018645D600
		// [XID] // 0x0000000189A77BA0-0x0000000189A77BC0
		public static LayerMask GetActiveTerrainLayer() => default; // 0x000000018645D310-0x000000018645D450
		// [XID] // 0x0000000189A7F100-0x0000000189A7F120
		public static LayerMask GetActiveTerrainLayerAsInt() => default; // 0x000000018645D1F0-0x000000018645D310
		// [XID] // 0x0000000189A86C20-0x0000000189A86C40
		public static int GetActiveTerrainCount() => default; // 0x000000018645D090-0x000000018645D1F0
		// [XID] // 0x00000001899BBAB0-0x00000001899BBAD0
		public static Terrain GetTerrain(Vector3 locationWU) => default; // 0x000000018645E030-0x000000018645E3F0
		// [IDTag] // 0x0000000189A95C10-0x0000000189A95C50
		// [XID] // 0x0000000189A95C10-0x0000000189A95C50
		public static bool GetTerrainBounds(Terrain terrain, ref Bounds bounds) => default; // 0x000000018645DDE0-0x000000018645E030
		// [IDTag] // 0x0000000189AA0290-0x0000000189AA02D0
		// [XID] // 0x0000000189AA0290-0x0000000189AA02D0
		public static bool GetTerrainBounds(Vector3 locationWU, ref Bounds bounds) => default; // 0x000000018645DB60-0x000000018645DDE0
		// [XID] // 0x0000000189AAA720-0x0000000189AAA740
		public static Vector3 GetRandomPositionOnTerrain(Terrain terrain, Vector3 start, float radius) => default; // 0x000000018645D600-0x000000018645D9C0
		// [XID] // 0x0000000189AB2550-0x0000000189AB2570
		public static void ClearTrees() {} // 0x000000018645C8B0-0x000000018645CAE0
		// [XID] // 0x0000000189AB9A70-0x0000000189AB9A90
		public static void ClearDetails() {} // 0x000000018645C610-0x000000018645C8B0
		// [XID] // 0x00000001896BC9C0-0x00000001896BC9E0
		public static float GetRangeFromTerrain() => default; // 0x000000018645D9C0-0x000000018645DB60
	}
}
