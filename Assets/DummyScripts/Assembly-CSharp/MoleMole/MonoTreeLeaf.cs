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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoTreeLeaf : MonoSceneProp // TypeDefIndex: 26506
	{
		// Fields
		private static readonly float CheckCutOffValue; // 0x00
		private static readonly float DeltaFading; // 0x04
		private static readonly float MinDitherAlpha; // 0x08
		private static int _cutOffPropID; // 0x0C
		private static int _DitherAlphaPropID; // 0x10
		private static int _UsingDitherAlphaPropID; // 0x14
		private static int _UsingMultiSampleDepthPropID; // 0x18
		// [Header] // 0x0000000189AF8750-0x0000000189AF8780
		public float UpdateTime; // 0x18
		// [Header] // 0x0000000189B01630-0x0000000189B01660
		public Renderer[] Renderers; // 0x20
		// [Header] // 0x0000000189B0A490-0x0000000189B0A4C0
		public CutOffSection[] CutOffSections; // 0x28
		// [Header] // 0x0000000189B130C0-0x0000000189B130F0
		public float TreeRadius; // 0x30
		// [Header] // 0x0000000189B1C2C0-0x0000000189B1C2F0
		public float LeafHeight; // 0x34
		// [Header] // 0x0000000189B24E90-0x0000000189B24EC0
		public bool UpdateDitherAlpha; // 0x38
		[NonSerialized]
		public Vector3 transformPos; // 0x3C
		[NonSerialized]
		public int mangerIndex; // 0x48
		private float _cntTime; // 0x4C
		private float _prevCutOffValue; // 0x50
		private bool _isValidRender; // 0x54
		private float _prevDitherAlphaValue; // 0x58
		private Mesh _mesh; // 0x60
		private List<Vector3> _vertList; // 0x68
		private List<int> _triList; // 0x70
		private List<UnityEngine.Material> _materialsList; // 0x78
		private float _scaledTreeRadius; // 0x80
		private float _scaledLeafHeight; // 0x84
		private bool bEnabled; // 0x88
	
		// Constructors
		public MonoTreeLeaf() {} // 0x000000018488EAF0-0x000000018488EBE0
		static MonoTreeLeaf() {} // 0x000000018488E9F0-0x000000018488EAF0
	
		// Methods
		// [XID] // 0x0000000189B2DAC0-0x0000000189B2DAE0
		public override ScenePropType GetScenePropType() => default; // 0x000000018488C680-0x000000018488C720
		// [XID] // 0x0000000189B34EC0-0x0000000189B34EE0
		public void SetStatusDirty() {} // 0x000000018488E2D0-0x000000018488E3F0
		// [XID] // 0x0000000189B3C790-0x0000000189B3C7B0
		protected override void Awake() {} // 0x000000018488BA00-0x000000018488BAA0
		// [XID] // 0x0000000189B444F0-0x0000000189B44510
		private void OnEnable() {} // 0x000000018488DE20-0x000000018488DEC0
		// [XID] // 0x0000000189B4BBD0-0x0000000189B4BBF0
		private void OnDisable() {} // 0x000000018488DD80-0x000000018488DE20
		// [XID] // 0x0000000189B53190-0x0000000189B531B0
		private void Start() {} // 0x000000018488E3F0-0x000000018488E800
		// [XID] // 0x0000000189B5AB20-0x0000000189B5AB40
		protected override void OnDestroy() {} // 0x000000018488DBC0-0x000000018488DD80
		// [XID] // 0x0000000189B61EF0-0x0000000189B61F10
		private void UpdateTreeBoundInfo() {} // 0x000000018488C500-0x000000018488C680
		// [XID] // 0x0000000189B69BA0-0x0000000189B69BC0
		public void UpdateTreeInfo(MaterialPropertyBlock mpb, bool forceUpdateCutOff, ref Camera mainCam, ref Vector3 camPos, ref Vector3 avatarPos, ref List<UnityEngine.Material> leafDitherMaterials) {} // 0x000000018488E800-0x000000018488E9F0
		// [XID] // 0x0000000189B71140-0x0000000189B71160
		private void SetCutOffValue(MaterialPropertyBlock mpb, bool forceUpdateCutOff, ref Vector3 camPos) {} // 0x000000018488C720-0x000000018488CCA0
		// [XID] // 0x0000000189B78750-0x0000000189B78770
		private int GetSection(float distance) => default; // 0x000000018488BAA0-0x000000018488BBC0
		// [XID] // 0x0000000189B7FD10-0x0000000189B7FD30
		private bool ShouldAddLeafDitherMaterial(float val) => default; // 0x000000018488CCA0-0x000000018488CD60
		// [XID] // 0x0000000189B87780-0x0000000189B877A0
		private void SetDitherAlpha(MaterialPropertyBlock mpb, ref Camera mainCam, ref Vector3 camPos, ref Vector3 avatarPos, ref List<UnityEngine.Material> leafDitherMaterials) {} // 0x000000018488DEC0-0x000000018488E2D0
		// [XID] // 0x0000000189B8E8F0-0x0000000189B8E910
		private float CalDitherAlphaValue(MaterialPropertyBlock mpb, ref Vector3 camPos, ref Vector3 avatarPos) => default; // 0x000000018488BBC0-0x000000018488BFB0
		// [XID] // 0x0000000189B95DD0-0x0000000189B95DF0
		private void SetDitherAlphaValue(float val, MaterialPropertyBlock mpb, ref Camera mainCam) {} // 0x000000018488CD60-0x000000018488D1B0
		// [XID] // 0x0000000189B9D310-0x0000000189B9D330
		private bool IsPointInsideMesh(Vector3 pos) => default; // 0x000000018488C010-0x000000018488C4A0
		// [XID] // 0x0000000189BA4CF0-0x0000000189BA4D10
		private bool IsIntersectWithMeshOrInMesh(ref Vector3 camPos, ref Vector3 avatarPos) => default; // 0x000000018488D1B0-0x000000018488DBC0
	}
}
