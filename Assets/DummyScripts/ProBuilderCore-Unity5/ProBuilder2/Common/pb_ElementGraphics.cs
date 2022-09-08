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
	[Serializable]
	// [AddComponentMenu] // 0x0000000189612560-0x00000001896125A0
	[ExecuteInEditMode] // 0x0000000189612560-0x00000001896125A0
	public class pb_ElementGraphics : pb_MonoBehaviourSingleton<ProBuilder2.Common.pb_ElementGraphics> // TypeDefIndex: 3375
	{
		// Fields
		private const string FACE_SHADER = "Hidden/ProBuilder/FaceHighlight"; // Metadata: 0x00AC3A0A
		private const string EDGE_SHADER = "Hidden/ProBuilder/FaceHighlight"; // Metadata: 0x00AC3A2D
		private const string VERT_SHADER = "Hidden/ProBuilder/pb_VertexShader"; // Metadata: 0x00AC3A50
		private const string PREVIEW_OBJECT_NAME = "ProBuilderSelectionGameObject"; // Metadata: 0x00AC3A75
		private const string WIREFRAME_OBJECT_NAME = "ProBuilderWireframeGameObject"; // Metadata: 0x00AC3A96
		private const string SELECTION_MESH_NAME = "ProBuilderEditorSelectionMesh"; // Metadata: 0x00AC3AB7
		private const string WIREFRAME_MESH_NAME = "ProBuilderEditorWireframeMesh"; // Metadata: 0x00AC3AD8
		private static float vertexHandleSize; // 0x00
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material faceMaterial; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material vertexMaterial; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material wireframeMaterial; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color faceSelectionColor; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color edgeSelectionColor; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color vertSelectionColor; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color wireframeColor; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color vertexDotColor; // 0x70
		private static readonly HideFlags PB_EDITOR_GRAPHIC_HIDE_FLAGS; // 0x04
		private pb_ObjectPool<pb_Renderable> pool; // 0x80
		private List<pb_Renderable> activeRenderables; // 0x88
	
		// Constructors
		public pb_ElementGraphics() {} // 0x000000018772D680-0x000000018772D850
		static pb_ElementGraphics() {} // 0x000000018772D610-0x000000018772D680
	
		// Methods
		public override void Awake() {} // 0x000000018772B220-0x000000018772B490
		private void OnDestroy() {} // 0x000000018772CE30-0x000000018772CEE0
		public override void OnEnable() {} // 0x000000018772CF60-0x000000018772D170
		private void OnDisable() {} // 0x000000018772CEE0-0x000000018772CF60
		private UnityEngine.Material CreateMaterial(Shader shader, string materialName) => default; // 0x000000018772CBA0-0x000000018772CC90
		public void LoadPrefs(Color in_faceSelectionColor, Color in_edgeSelectionColor, Color in_vertSelectionColor, Color in_vertexDotColor, float in_vertexHandleSize) {} // 0x000000018772CC90-0x000000018772CE30
		private void AddRenderable(pb_Renderable ren) {} // 0x000000018772B180-0x000000018772B220
		public void RebuildGraphics(pb_Object[] selection, pb_Edge[][] universalEdgesDistinct, EditLevel editLevel, SelectMode selectionMode) {} // 0x000000018772D170-0x000000018772D610
		private pb_Renderable BuildFaceMesh(pb_Object pb) => default; // 0x000000018772B970-0x000000018772BB60
		private pb_Renderable BuildVertexMesh(pb_Object pb) => default; // 0x000000018772BB60-0x000000018772CBA0
		private pb_Renderable BuildEdgeMesh(pb_Object pb, pb_Edge[] universalEdgesDistinct) => default; // 0x000000018772B490-0x000000018772B970
	}
}
