/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class CameraFrustumPreview : MonoBehaviour // TypeDefIndex: 31381
	{
		// Fields
		public bool enableInGameView; // 0x18
		public bool enableInSceneView; // 0x19
		public float crosshairSize; // 0x1C
		public float crosshairLineWidth; // 0x20
		public Color crosshairColor; // 0x24
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float widthOffsetFactor; // 0x34
		public AspectConfig[] aspectConfigs; // 0x38
	
		// Nested types
		[Serializable]
		public struct AspectConfig // TypeDefIndex: 31382
		{
			// Fields
			public int width; // 0x00
			public int height; // 0x04
			public float lineWidth; // 0x08
			public Color color; // 0x0C
	
			// Properties
			public float aspect { /* [XID] */ /* 0x0000000189ACAA40-0x0000000189ACAA60 */ get => default; } // 0x0000000181ACA830-0x0000000181ACA840 
		}
	
		// Constructors
		public CameraFrustumPreview() {} // 0x0000000181AD79D0-0x0000000181AD7A70
	}
}
