/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	// [AddComponentMenu] // 0x00000001899D0FA0-0x00000001899D1000
	[DisallowMultipleComponent] // 0x00000001899D0FA0-0x00000001899D1000
	[ProGridsConditionalSnap] // 0x00000001899D0FA0-0x00000001899D1000
	public class pb_PolyShape : MonoBehaviour // TypeDefIndex: 3418
	{
		// Fields
		public List<Vector3> points; // 0x18
		public float extrude; // 0x20
		public PolyEditMode polyEditMode; // 0x24
		public bool flipNormals; // 0x28
		private pb_Object m_Mesh; // 0x30
		public bool isOnGrid; // 0x38
	
		// Properties
		public pb_Object mesh { get => default; set {} } // 0x0000000186BB4B40-0x0000000186BB4BF0 0x0000000186BB4BF0-0x0000000186BB4C50
	
		// Nested types
		public enum PolyEditMode // TypeDefIndex: 3419
		{
			None = 0,
			Path = 1,
			Height = 2,
			Edit = 3
		}
	
		// Constructors
		public pb_PolyShape() {} // 0x0000000186BB4AB0-0x0000000186BB4B40
	
		// Methods
		private bool IsSnapEnabled() => default; // 0x0000000186BB4A50-0x0000000186BB4AB0
	}
}
