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
	public class DeferredProjector : MonoBehaviour // TypeDefIndex: 26488
	{
		// Fields
		private static readonly float MESH_SCALE_INVERSE; // 0x00
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_NearClipPlane; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_FarClipPlane; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_FieldOfView; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_AspectRatio; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_Orthographic; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_OrthographicSize; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_EnableOcclusion; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_OcclusionBias; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_BakedOcclusionTexture; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Matrix4x4 m_BakedOcclusionProjection; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector4 m_BakedOcclusionParams; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_OcclusionMapResolution; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_OcclusionMapQuality; // 0x94
		private Matrix4x4 m_WorldToProjector; // 0x98
		private Matrix4x4 m_Projector; // 0xD8
		private Matrix4x4 m_ProjectorInverse; // 0x118
		private Matrix4x4 m_WorldToProjectorClip; // 0x158
		private Matrix4x4 m_WorldToLocal; // 0x198
		private bool m_MaterialPropertyDirty; // 0x1D8
		private bool m_IsVaild; // 0x1D9
		private MeshFilter m_MeshFilter; // 0x1E0
		private MeshRenderer m_MeshRenderer; // 0x1E8
		private UnityEngine.Material m_Material; // 0x1F0
		private MaterialPropertyBlock m_MatPropBlock; // 0x1F8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Mesh m_sharedMesh; // 0x200
		private Mesh m_instancedMesh; // 0x208
		private static readonly string s_BuiltinMeshPath; // 0x08
	
		// Properties
		public float NearClipPlane { /* [XID] */ /* 0x00000001897E0DB0-0x00000001897E0DD0 */ get => default; /* [XID] */ /* 0x00000001897E84B0-0x00000001897E84D0 */ set {} } // 0x0000000184D83D70-0x0000000184D83E20 0x0000000184D844B0-0x0000000184D845B0
		public float FarClipPlane { /* [XID] */ /* 0x00000001897F0150-0x00000001897F0170 */ get => default; /* [XID] */ /* 0x00000001897F7940-0x00000001897F7960 */ set {} } // 0x0000000184D83C10-0x0000000184D83CC0 0x0000000184D84290-0x0000000184D843A0
		public float FieldOfView { /* [XID] */ /* 0x00000001897FEFD0-0x00000001897FEFF0 */ get => default; /* [XID] */ /* 0x0000000189806730-0x0000000189806750 */ set {} } // 0x0000000184D83CC0-0x0000000184D83D70 0x0000000184D843A0-0x0000000184D844B0
		public float AspectRatio { /* [XID] */ /* 0x000000018980DF10-0x000000018980DF30 */ get => default; /* [XID] */ /* 0x00000001898155B0-0x00000001898155D0 */ set {} } // 0x0000000184D83A20-0x0000000184D83AD0 0x0000000184D84020-0x0000000184D840E0
		public bool Orthographic { /* [XID] */ /* 0x000000018981CFB0-0x000000018981CFD0 */ get => default; /* [XID] */ /* 0x0000000189824380-0x00000001898243A0 */ set {} } // 0x0000000184D83F80-0x0000000184D84020 0x0000000184D84740-0x0000000184D84800
		public float OrthographicSize { /* [XID] */ /* 0x000000018982BEA0-0x000000018982BEC0 */ get => default; /* [XID] */ /* 0x0000000189833400-0x0000000189833420 */ set {} } // 0x0000000184D83ED0-0x0000000184D83F80 0x0000000184D84670-0x0000000184D84740
		public bool EnabledOcclusion { /* [XID] */ /* 0x000000018983A8F0-0x000000018983A910 */ get => default; /* [XID] */ /* 0x0000000189841EF0-0x0000000189841F10 */ set {} } // 0x0000000184D83B70-0x0000000184D83C10 0x0000000184D841D0-0x0000000184D84290
		public float OcclusionBias { /* [XID] */ /* 0x0000000189849370-0x0000000189849390 */ get => default; /* [XID] */ /* 0x0000000189850B10-0x0000000189850B30 */ set {} } // 0x0000000184D83E20-0x0000000184D83ED0 0x0000000184D845B0-0x0000000184D84670
		public Texture2D BakedOcclusionTexture { /* [XID] */ /* 0x0000000189857F00-0x0000000189857F20 */ get => default; /* [XID] */ /* 0x000000018968C000-0x000000018968C020 */ set {} } // 0x0000000184D83AD0-0x0000000184D83B70 0x0000000184D840E0-0x0000000184D841D0
	
		// Nested types
		private static class PropIDS // TypeDefIndex: 26489
		{
			// Fields
			public static readonly int DPProjectorInversePropID; // 0x00
			public static readonly int DPWorldToProjectorPropID; // 0x04
			public static readonly int DPWorldToProjectorClipPropID; // 0x08
			public static readonly string DPOcclusionKeyword; // 0x10
			public static readonly int DPWorldToOcclusionProjectorID; // 0x18
			public static readonly int DPOcclusionParamsID; // 0x1C
			public static readonly int DPOcclusionShadowMapPropID; // 0x20
	
			// Constructors
			static PropIDS() {} // 0x0000000184D9B2E0-0x0000000184D9B420
		}
	
		// Constructors
		public DeferredProjector() {} // 0x0000000184D838E0-0x0000000184D83A20
		static DeferredProjector() {} // 0x0000000184D83870-0x0000000184D838E0
	
		// Methods
		// [XID] // 0x0000000189866820-0x0000000189866840
		private void OnEnable() {} // 0x0000000184D83110-0x0000000184D83390
		// [XID] // 0x000000018986E120-0x000000018986E140
		private void Update() {} // 0x0000000184D83630-0x0000000184D83870
		// [XID] // 0x00000001898755D0-0x00000001898755F0
		private void OnDisable() {} // 0x0000000184D82F30-0x0000000184D83110
		// [XID] // 0x000000018987D120-0x000000018987D140
		public int GetMainTexSize() => default; // 0x0000000184D82100-0x0000000184D82350
		// [XID] // 0x0000000189884080-0x00000001898840A0
		public void StoreBakedOcclusionInfo(Texture2D occlusionMapReference) {} // 0x0000000184D83390-0x0000000184D83630
		// [XID] // 0x000000018988B7E0-0x000000018988B800
		private void UpdateProjectorMesh() {} // 0x0000000184D81D20-0x0000000184D82100
		// [XID] // 0x0000000189892EE0-0x0000000189892F00
		private void RecalculateMatrix() {} // 0x0000000184D82350-0x0000000184D82F30
	}
}
