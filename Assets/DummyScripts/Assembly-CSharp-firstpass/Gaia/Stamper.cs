/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class Stamper : MonoBehaviour // TypeDefIndex: 9323
	{
		// Fields
		public string m_stampID; // 0x18
		public Texture2D m_stampPreviewImage; // 0x20
		public float m_x; // 0x28
		public float m_y; // 0x2C
		public float m_z; // 0x30
		public float m_width; // 0x34
		public float m_height; // 0x38
		public float m_rotation; // 0x3C
		public bool m_stickBaseToGround; // 0x40
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public GaiaResource m_resources; // 0x48
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public float m_seaLevel; // 0x50
		public string m_resourcesPath; // 0x58
		public bool m_invertStamp; // 0x60
		public bool m_normaliseStamp; // 0x61
		public float m_baseLevel; // 0x64
		public bool m_drawStampBase; // 0x68
		public GaiaConstants.FeatureOperation m_stampOperation; // 0x6C
		public int m_smoothIterations; // 0x70
		public float m_blendStrength; // 0x74
		public float m_stencilHeight; // 0x78
		public AnimationCurve m_heightModifier; // 0x80
		public AnimationCurve m_distanceMask; // 0x88
		public GaiaConstants.ImageFitnessFilterMode m_areaMaskMode; // 0x90
		public Texture2D m_imageMask; // 0x98
		public bool m_imageMaskInvert; // 0xA0
		public bool m_imageMaskNormalise; // 0xA1
		public bool m_imageMaskFlip; // 0xA2
		public int m_imageMaskSmoothIterations; // 0xA4
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public HeightMap m_imageMaskHM; // 0xA8
		public float m_noiseMaskSeed; // 0xB0
		public int m_noiseMaskOctaves; // 0xB4
		public float m_noiseMaskPersistence; // 0xB8
		public float m_noiseMaskFrequency; // 0xBC
		public float m_noiseMaskLacunarity; // 0xC0
		public float m_noiseZoom; // 0xC4
		public bool m_alwaysShow; // 0xC8
		public bool m_showBase; // 0xC9
		public bool m_showSeaLevel; // 0xCA
		public bool m_showRulers; // 0xCB
		public bool m_showTerrainHelper; // 0xCC
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public Color m_gizmoColour; // 0xD0
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public IEnumerator m_updateCoroutine; // 0xE0
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public float m_updateTimeAllowed; // 0xE8
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public float m_stampProgress; // 0xEC
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public bool m_stampComplete; // 0xF0
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public bool m_cancelStamp; // 0xF1
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public UnityEngine.Material m_previewMaterial; // 0xF8
		private int m_scanWidth; // 0x100
		private int m_scanDepth; // 0x104
		private int m_scanHeight; // 0x108
		private float m_scanResolution; // 0x10C
		private Bounds m_scanBounds; // 0x110
		private UnityHeightMap m_stampHM; // 0x128
		private GaiaWorldManager m_undoMgr; // 0x130
		private GaiaWorldManager m_redoMgr; // 0x138
		private MeshFilter m_previewFilter; // 0x140
		private MeshRenderer m_previewRenderer; // 0x148
		private bool m_heightChangedInThisFrame; // 0x150
		private bool m_fitToTerrainPending; // 0x151
	
		// Constructors
		public Stamper() {} // 0x000000018645AAA0-0x000000018645AD90
	
		// Methods
		// [IDTag] // 0x00000001898DA0F0-0x00000001898DA130
		// [XID] // 0x00000001898DA0F0-0x00000001898DA130
		public void LoadStamp() {} // 0x0000000186458F30-0x0000000186459490
		// [IDTag] // 0x00000001898E4BB0-0x00000001898E4BF0
		// [XID] // 0x00000001898E4BB0-0x00000001898E4BF0
		public void LoadStamp(string imagePreviewPath) {} // 0x0000000186459490-0x0000000186459540
		// [XID] // 0x00000001896807F0-0x0000000189680810
		public bool LoadRuntimeStamp(TextAsset stamp) => default; // 0x0000000186458BA0-0x0000000186458F30
		// [XID] // 0x00000001898F4DC0-0x00000001898F4DE0
		public void InvertStamp() {} // 0x0000000186457600-0x00000001864576C0
		// [XID] // 0x00000001898FE8B0-0x00000001898FE8D0
		public void NormaliseStamp() {} // 0x0000000186459540-0x0000000186459600
		// [XID] // 0x0000000189905F90-0x0000000189905FB0
		public void Stamp() {} // 0x000000018645A1F0-0x000000018645A320
		// [XID] // 0x000000018990D920-0x000000018990D940
		public void CancelStamp() {} // 0x0000000186455350-0x00000001864553F0
		// [XID] // 0x0000000189915050-0x0000000189915070
		public bool IsStamping() => default; // 0x0000000186457970-0x0000000186457A20
		// [XID] // 0x000000018991CC00-0x000000018991CC20
		public void UpdateStamp() {} // 0x000000018645A6B0-0x000000018645AAA0
		// [XID] // 0x0000000189924600-0x0000000189924620
		public void AlignToGround() {} // 0x0000000186454740-0x0000000186454AB0
		// [XID] // 0x000000018992B9F0-0x000000018992BA10
		public bool GetHeightRange(ref float baseLevel, ref float minHeight, ref float maxHeight) => default; // 0x00000001864573E0-0x0000000186457500
		// [XID] // 0x0000000189933100-0x0000000189933120
		public void FitToTerrain() {} // 0x0000000186456950-0x0000000186456BE0
		// [XID] // 0x000000018968FC00-0x000000018968FC20
		public bool IsFitToTerrain() => default; // 0x00000001864576C0-0x0000000186457970
		// [XID] // 0x0000000189A1A4F0-0x0000000189A1A510
		public void AddToSession(GaiaOperation.OperationType opType, string opName) {} // 0x00000001864544A0-0x0000000186454740
		// [XID] // 0x00000001899496B0-0x00000001899496D0
		public string SerialiseJson() => default; // 0x0000000186459E80-0x0000000186459F90
		// [XID] // 0x000000018992AF60-0x000000018992AF80
		public void DeSerialiseJson(string json) {} // 0x0000000186455770-0x00000001864558C0
		// [XID] // 0x00000001899585F0-0x0000000189958610
		public void FlattenTerrain() {} // 0x0000000186456BE0-0x0000000186456D40
		// [XID] // 0x0000000189A0BA70-0x0000000189A0BA90
		public void SmoothTerrain() {} // 0x000000018645A090-0x000000018645A1F0
		// [XID] // 0x0000000189967600-0x0000000189967620
		public void ClearTrees() {} // 0x00000001864554B0-0x0000000186455570
		// [XID] // 0x000000018996E830-0x000000018996E850
		public void ClearDetails() {} // 0x00000001864553F0-0x00000001864554B0
		// [XID] // 0x0000000189858380-0x00000001898583A0
		public bool CanPreview() => default; // 0x0000000186455120-0x00000001864551F0
		// [XID] // 0x000000018997D6F0-0x000000018997D710
		public bool CurrentPreviewState() => default; // 0x0000000186455670-0x0000000186455770
		// [XID] // 0x0000000189B759B0-0x0000000189B759D0
		public void ShowPreview() {} // 0x0000000186459F90-0x000000018645A090
		// [XID] // 0x000000018998CD20-0x000000018998CD40
		public void HidePreview() {} // 0x0000000186457500-0x0000000186457600
		// [XID] // 0x0000000189697600-0x0000000189697620
		public void TogglePreview() {} // 0x000000018645A460-0x000000018645A570
		// [XID] // 0x000000018999C2F0-0x000000018999C310
		public bool CanUndo() => default; // 0x00000001864552A0-0x0000000186455350
		// [XID] // 0x00000001898D6740-0x00000001898D6760
		public void CreateUndo() {} // 0x0000000186455570-0x0000000186455670
		// [XID] // 0x00000001896F8820-0x00000001896F8840
		public void Undo() {} // 0x000000018645A570-0x000000018645A6B0
		// [XID] // 0x00000001899B30D0-0x00000001899B30F0
		public bool CanRedo() => default; // 0x00000001864551F0-0x00000001864552A0
		// [XID] // 0x0000000189707890-0x00000001897078B0
		public void Redo() {} // 0x0000000186459970-0x0000000186459A50
		// [XID] // 0x00000001899C1E10-0x00000001899C1E30
		private void OnEnable() {} // 0x00000001864597F0-0x00000001864598D0
		// [XID] // 0x0000000189B2ADA0-0x0000000189B2ADC0
		public void StartEditorUpdates() {} // 0x000000018645A320-0x000000018645A3C0
		// [XID] // 0x00000001896CA6F0-0x00000001896CA710
		public void StopEditorUpdates() {} // 0x000000018645A3C0-0x000000018645A460
		// [XID] // 0x000000018961EF20-0x000000018961EF40
		private void EditorUpdate() {} // 0x0000000186456880-0x0000000186456950
		// [XID] // 0x0000000189ABA840-0x0000000189ABA860
		private void OnDrawGizmosSelected() {} // 0x00000001864596B0-0x0000000186459750
		// [XID] // 0x00000001899E7350-0x00000001899E7370
		private void OnDrawGizmos() {} // 0x0000000186459750-0x00000001864597F0
		// [XID] // 0x00000001896262C0-0x00000001896262E0
		private void DrawGizmos(bool isSelected) {} // 0x00000001864558C0-0x00000001864567E0
		// [XID] // 0x0000000189AC2150-0x0000000189AC2170
		private void DrawRulers() {} // 0x00000001864567E0-0x0000000186456880
		// [XID] // 0x0000000189AC9740-0x0000000189AC9760
		public void OnParamChangedButPositionSame() {} // 0x00000001864598D0-0x0000000186459970
		// [XID] // 0x0000000189635870-0x0000000189635890
		public void OnCreateNewStamper() {} // 0x0000000186459600-0x00000001864596B0
		// [XID] // 0x0000000189A0C410-0x0000000189A0C430
		private void AddStamp2() {} // 0x00000001864543B0-0x00000001864544A0
		[DebuggerHidden] // 0x0000000189A13E10-0x0000000189A13E50
		// [XID] // 0x0000000189A13E10-0x0000000189A13E50
		public IEnumerator ApplyStampMultiTerrain() => default; // 0x0000000186454BC0-0x0000000186454CD0
		[DebuggerHidden] // 0x0000000189A1DEA0-0x0000000189A1DEE0
		// [XID] // 0x0000000189A1DEA0-0x0000000189A1DEE0
		public IEnumerator ApplyStampMultiTerrainNew() => default; // 0x0000000186454AB0-0x0000000186454BC0
		// [ContextMenu] // 0x0000000189A28340-0x0000000189A28390
		// [XID] // 0x0000000189A28340-0x0000000189A28390
		private void ResetSubterrain(List<Terrain> savedTerrains, int terrainIndex, bool disableOthers) {} // 0x0000000186459A50-0x0000000186459C00
		[DebuggerHidden] // 0x0000000189A341A0-0x0000000189A341F0
		// [IDTag] // 0x0000000189A341A0-0x0000000189A341F0
		// [XID] // 0x0000000189A341A0-0x0000000189A341F0
		public IEnumerator ApplyStamp(Terrain targetTerrain) => default; // 0x0000000186454DE0-0x0000000186454F10
		[DebuggerHidden] // 0x0000000189A41B10-0x0000000189A41B60
		// [IDTag] // 0x0000000189A41B10-0x0000000189A41B60
		// [XID] // 0x0000000189A41B10-0x0000000189A41B60
		public IEnumerator ApplyStamp() => default; // 0x0000000186454CD0-0x0000000186454DE0
		// [XID] // 0x0000000189A4F170-0x0000000189A4F190
		private void GeneratePreviewMesh() {} // 0x0000000186456D40-0x00000001864573E0
		// [XID] // 0x00000001898B86A0-0x00000001898B86C0
		private bool LoadImageMask() => default; // 0x0000000186457A20-0x0000000186458BA0
		// [XID] // 0x0000000189A5E3C0-0x0000000189A5E3E0
		private float CalculateHeight(float terrainHeight, float smHeightRaw, float smHeightAdj, float stencilHeightNU, float strength) => default; // 0x0000000186454F10-0x0000000186455120
		// [XID] // 0x0000000189A65C20-0x0000000189A65C40
		private Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle) => default; // 0x0000000186459C00-0x0000000186459E80
	}
}
