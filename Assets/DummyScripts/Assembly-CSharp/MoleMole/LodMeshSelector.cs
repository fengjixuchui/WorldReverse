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
	public class LodMeshSelector : MonoBehaviour // TypeDefIndex: 12179
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SkeletonBindings _skeletonBindings; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Mesh[] _meshes; // 0x20
	
		// Properties
		public SkeletonBindings skeletonBindings { /* [XID] */ /* 0x0000000189982590-0x00000001899825B0 */ get => default; /* [XID] */ /* 0x0000000189989CF0-0x0000000189989D10 */ set {} } // 0x0000000183A39AC0-0x0000000183A39B60 0x0000000183A39C10-0x0000000183A39CC0
		public Mesh[] meshes { /* [XID] */ /* 0x0000000189991610-0x0000000189991630 */ get => default; /* [XID] */ /* 0x0000000189999120-0x0000000189999140 */ set {} } // 0x0000000183A39A20-0x0000000183A39AC0 0x0000000183A39B60-0x0000000183A39C10
	
		// Constructors
		public LodMeshSelector() {} // 0x0000000183A399C0-0x0000000183A39A20
	
		// Methods
		// [XID] // 0x00000001899A0950-0x00000001899A0970
		public Mesh GetMeshByGraphicsSetting(float[] lodconfig) => default; // 0x0000000183A39690-0x0000000183A397D0
		// [XID] // 0x00000001899A8420-0x00000001899A8440
		private void BindBones(Mesh m, SkinnedMeshRenderer smr) {} // 0x0000000183A39530-0x0000000183A39690
		// [XID] // 0x00000001899AFC30-0x00000001899AFC50
		public void SelectLod(float[] lodconfig) {} // 0x0000000183A397D0-0x0000000183A399C0
	}
}
