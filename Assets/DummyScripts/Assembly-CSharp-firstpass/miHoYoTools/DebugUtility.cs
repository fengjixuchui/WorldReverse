/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MihoyoTools
{
	public class DebugUtility // TypeDefIndex: 9138
	{
		// Constructors
		public DebugUtility() {} // 0x00000001853FDBA0-0x00000001853FDC50
	
		// Methods
		// [XID] // 0x00000001896468E0-0x0000000189646900
		public static string GetFileName(UnityEngine.Object assetObj, bool includeFullPath = true /* Metadata: 0x00AE5476 */) => default; // 0x00000001853FD480-0x00000001853FD560
		// [XID] // 0x0000000189965D30-0x0000000189965D50
		public static GameObject CreateMarker(PrimitiveType objType, Color objColor, Vector3 objPosition, float objScale = 1f /* Metadata: 0x00AE5477 */, string objName = null, bool fetchExistingMarkerWithSameName = true /* Metadata: 0x00AE547B */) => default; // 0x00000001853FD370-0x00000001853FD480
		// [XID] // 0x000000018996D350-0x000000018996D370
		public static void CreateLineMarker(Vector3 objPosition, Color objColor, float lineLength = 1f /* Metadata: 0x00AE547C */) {} // 0x00000001853FCED0-0x00000001853FD370
		// [XID] // 0x0000000189974C10-0x0000000189974C30
		public static GUIStyle GreyBackground(Color _color) => default; // 0x00000001853FD560-0x00000001853FD690
		// [XID] // 0x00000001897690D0-0x00000001897690F0
		public static GUIStyle RedTextColor() => default; // 0x00000001853FDAA0-0x00000001853FDBA0
		// [XID] // 0x0000000189983DB0-0x0000000189983DD0
		public static Texture2D MakeTex(int width, int height, Color col) => default; // 0x00000001853FD690-0x00000001853FD810
		// [XID] // 0x000000018998B7C0-0x000000018998B7E0
		public static float ProjectedAndSignedAngleBetweenVectors(Vector3 fromVector, Vector3 toVector, Vector3 normalVector) => default; // 0x00000001853FD810-0x00000001853FDAA0
		public static void SwapTwoObj<T>(ref T first, ref T second) {}
		public static void SwapTwoElementInList<T>(IList<T> list, int indexA, int indexB) {}
	}
}
