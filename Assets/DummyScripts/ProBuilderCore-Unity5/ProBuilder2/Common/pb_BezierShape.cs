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
	// [AddComponentMenu] // 0x0000000189B916A0-0x0000000189B916F0
	[DisallowMultipleComponent] // 0x0000000189B916A0-0x0000000189B916F0
	public class pb_BezierShape : MonoBehaviour // TypeDefIndex: 3364
	{
		// Fields
		public List<pb_BezierPoint> m_Points; // 0x18
		public bool m_CloseLoop; // 0x20
		public float m_Radius; // 0x24
		public int m_Rows; // 0x28
		public int m_Columns; // 0x2C
		public bool m_Smooth; // 0x30
		public bool m_IsEditing; // 0x31
		private pb_Object m_Mesh; // 0x38
	
		// Properties
		public pb_Object mesh { get => default; set {} } // 0x000000018770D300-0x000000018770D3B0 0x000000018770D3B0-0x000000018770D410
	
		// Constructors
		public pb_BezierShape() {} // 0x000000018770D250-0x000000018770D300
	
		// Methods
		public void Init() {} // 0x000000018770CDA0-0x000000018770D190
		public void Refresh() {} // 0x000000018770D190-0x000000018770D250
	}
}
