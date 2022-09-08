/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace UnityEngine.UI
{
	// [AddComponentMenu] // 0x00000001899349B0-0x0000000189934A30
	// [RequireComponent] // 0x00000001899349B0-0x0000000189934A30
	public class LetterSpacing : BaseMeshEffect, ILayoutElement // TypeDefIndex: 31069
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_spacing; // 0x20
		public bool autoFixLine; // 0x24
		private List<UIVertex> _vertices; // 0x28
	
		// Properties
		public float spacing { get => default; set {} } // 0x0000000185234FF0-0x0000000185235060 0x00000001852350F0-0x0000000185235240
		private Text text { get => default; } // 0x0000000185235060-0x00000001852350F0 
		public float minWidth { get => default; } // 0x0000000185234C00-0x0000000185234C90 
		public float preferredWidth { get => default; } // 0x0000000185234D20-0x0000000185234FF0 
		public float flexibleWidth { get => default; } // 0x0000000185234A50-0x0000000185234AE0 
		public float minHeight { get => default; } // 0x0000000185234B70-0x0000000185234C00 
		public float preferredHeight { get => default; } // 0x0000000185234C90-0x0000000185234D20 
		public float flexibleHeight { get => default; } // 0x00000001852349C0-0x0000000185234A50 
		public int layoutPriority { get => default; } // 0x0000000185234AE0-0x0000000185234B70 
	
		// Constructors
		protected LetterSpacing() {} // 0x0000000185234920-0x00000001852349C0
	
		// Methods
		private int GetValidCharCount(string str) => default; // 0x0000000185233B50-0x0000000185233C20
		protected override void Start() {} // 0x00000001852348B0-0x0000000185234920
		public void CalculateLayoutInputHorizontal() {} // 0x00000001852334D0-0x0000000185233520
		public void CalculateLayoutInputVertical() {} // 0x0000000185233520-0x0000000185233570
		public void AccommodateText() {} // 0x0000000185232EC0-0x00000001852334D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator ReAccommodateText() => default; // 0x00000001852347E0-0x00000001852348B0
		public int GetLineCount(string targetText) => default; // 0x0000000185233570-0x0000000185233A50
		private string[] GetLines() => default; // 0x0000000185233A50-0x0000000185233B50
		public override void ModifyMesh(VertexHelper vh) {} // 0x0000000185233C20-0x0000000185233D70
		public void ModifyVertices(List<UIVertex> verts) {} // 0x0000000185233D70-0x00000001852347E0
	}
}
