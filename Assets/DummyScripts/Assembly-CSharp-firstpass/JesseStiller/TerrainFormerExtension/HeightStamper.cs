/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace JesseStiller.TerrainFormerExtension
{
	public class HeightStamper : MonoBehaviour // TypeDefIndex: 10071
	{
		// Fields
		public string stampID; // 0x18
		public Texture2D previewImage; // 0x20
		public float width; // 0x28
		public float height; // 0x2C
		public float rotation; // 0x30
		public bool invertStamp; // 0x34
		public bool normaliseStamp; // 0x35
		public StamperOperationTeyp stampOperation; // 0x38
		public float blendStrength; // 0x3C
		public float operationStrength; // 0x40
		private Color _gizmoColour; // 0x44
		private UnityEngine.Material _previewMaterial; // 0x58
		private MeshFilter _previewFilter; // 0x60
		private MeshRenderer _previewRenderer; // 0x68
		private Bounds _scanBounds; // 0x70
		private HeightMapData _heightMapData; // 0x88
		private int _scanWidth; // 0x90
		private int _scanDepth; // 0x94
		private int _scanHeight; // 0x98
		private float _scanResolution; // 0x9C
	
		// Properties
		public float maxWidth { /* [XID] */ /* 0x0000000189B2D260-0x0000000189B2D280 */ get => default; } // 0x0000000186D0E100-0x0000000186D0E1C0 
		public float maxHeight { /* [XID] */ /* 0x00000001897EC300-0x00000001897EC320 */ get => default; } // 0x0000000186D0E050-0x0000000186D0E100 
		public Terrain terrain { /* [XID] */ /* 0x0000000189B3BFF0-0x0000000189B3C030 */ get; /* [XID] */ /* 0x0000000189B46BE0-0x0000000189B46C20 */ private set; } // 0x0000000186D0E1C0-0x0000000186D0E220 0x0000000186D0E220-0x0000000186D0E290
		public HeightMapData heightMapData { /* [XID] */ /* 0x0000000189893C50-0x0000000189893C70 */ get => default; } // 0x0000000186D0DFA0-0x0000000186D0E050 
	
		// Constructors
		public HeightStamper() {} // 0x0000000186D0DE50-0x0000000186D0DFA0
	
		// Methods
		// [XID] // 0x0000000189B58EA0-0x0000000189B58EC0
		private void OnDrawGizmosSelected() {} // 0x0000000186D0C4C0-0x0000000186D0C560
		// [XID] // 0x0000000189B60510-0x0000000189B60530
		private void OnDrawGizmos() {} // 0x0000000186D0C560-0x0000000186D0C600
		// [XID] // 0x0000000189B67CD0-0x0000000189B67CF0
		private void DrawGizmos(bool isSelected) {} // 0x0000000186D0A380-0x0000000186D0AA40
		// [XID] // 0x0000000189965B80-0x0000000189965BA0
		public void SetTerrain(Terrain stampTerrain) {} // 0x0000000186D0D640-0x0000000186D0DA50
		// [XID] // 0x0000000189B766C0-0x0000000189B766E0
		public void LoadStamp() {} // 0x0000000186D0C050-0x0000000186D0C400
		// [XID] // 0x0000000189B7DC80-0x0000000189B7DCA0
		public void InvertStamp() {} // 0x0000000186D0BF90-0x0000000186D0C050
		// [XID] // 0x0000000189B85980-0x0000000189B859A0
		public void NormaliseStamp() {} // 0x0000000186D0C400-0x0000000186D0C4C0
		// [XID] // 0x0000000189B6C760-0x0000000189B6C780
		public void UpdateStamp() {} // 0x0000000186D0DB60-0x0000000186D0DE50
		// [XID] // 0x0000000189B94100-0x0000000189B94120
		public void FitToTerrain() {} // 0x0000000186D0AA40-0x0000000186D0AD10
		// [XID] // 0x0000000189B9B770-0x0000000189B9B790
		public bool CanPreview() => default; // 0x0000000186D09950-0x0000000186D09A20
		// [XID] // 0x0000000189BA2F50-0x0000000189BA2F70
		public bool CurrentPreviewState() => default; // 0x0000000186D0A280-0x0000000186D0A380
		// [XID] // 0x0000000189936410-0x0000000189936430
		public void TogglePreview() {} // 0x0000000186D0DA50-0x0000000186D0DB60
		// [XID] // 0x0000000189BB1A20-0x0000000189BB1A40
		public Bounds GetApplyBounds() => default; // 0x0000000186D0B390-0x0000000186D0BA40
		// [XID] // 0x0000000189B29440-0x0000000189B29460
		private float GetRotationUVScale() => default; // 0x0000000186D0BBD0-0x0000000186D0BD30
		// [XID] // 0x0000000189BC0460-0x0000000189BC0480
		private Vector2 GetRotaionUV(Vector2 uv) => default; // 0x0000000186D0BA40-0x0000000186D0BBD0
		// [XID] // 0x0000000189B30900-0x0000000189B30920
		private void GeneratePreviewMesh() {} // 0x0000000186D0AD10-0x0000000186D0B390
		// [XID] // 0x0000000189BCFA90-0x0000000189BCFAB0
		private Mesh CreateMesh(float[,] heightmap, Vector3 targetSize, float heightValueScale) => default; // 0x0000000186D09A20-0x0000000186D0A280
		// [XID] // 0x0000000189A376D0-0x0000000189A376F0
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle) => default; // 0x0000000186D0D3C0-0x0000000186D0D640
		// [XID] // 0x0000000189BDEBA0-0x0000000189BDEBC0
		private Texture2D RenderTerrain() => default; // 0x0000000186D0C600-0x0000000186D0D3C0
		// [XID] // 0x00000001895EB610-0x00000001895EB630
		private Mesh BakingTerrainMesh(Terrain curTerrain) => default; // 0x0000000186D09160-0x0000000186D09950
		// [XID] // 0x00000001895F2A60-0x00000001895F2A80
		private bool GetTerrainBounds(Terrain terrain, ref Bounds bounds) => default; // 0x0000000186D0BD30-0x0000000186D0BF90
	}
}
