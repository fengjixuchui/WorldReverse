/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MihoyoTextMeshEffect : BaseMeshEffect // TypeDefIndex: 31071
	{
		// Fields
		private int _charNum; // 0x20
		private byte _lastCharAlpha; // 0x24
		private static List<UIVertex> _tempVertList; // 0x00
		private static UIVertex[] _tempVertQuad; // 0x08
		private bool _isOnlyText; // 0x25
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _isActive; // 0x26
	
		// Constructors
		public MihoyoTextMeshEffect() {} // 0x000000018114C4C0-0x000000018114C540
		static MihoyoTextMeshEffect() {} // 0x000000018114C410-0x000000018114C4C0
	
		// Methods
		// [XID] // 0x0000000189988B80-0x0000000189988BA0
		protected override void OnEnable() {} // 0x000000018114C0E0-0x000000018114C250
		// [XID] // 0x0000000189990300-0x0000000189990320
		public void SetCurrCharNum(int currCharNum) {} // 0x000000018114C250-0x000000018114C330
		// [XID] // 0x0000000189997E90-0x0000000189997EB0
		public void SetLastCharAlpha(byte alpha) {} // 0x000000018114C330-0x000000018114C410
		// [XID] // 0x000000018999F5E0-0x000000018999F600
		public override void ModifyMesh(VertexHelper vertices) {} // 0x000000018114BD20-0x000000018114C0E0
		// [XID] // 0x00000001899A7150-0x00000001899A7170
		private void UpdateVerticesOnlyText(VertexHelper vertices, int vertCount) {} // 0x000000018114BA30-0x000000018114BD20
		// [XID] // 0x00000001899AEA80-0x00000001899AEAA0
		private void UpdateVertices(VertexHelper vertices, int vertCount) {} // 0x000000018114B710-0x000000018114B9D0
	}
}
