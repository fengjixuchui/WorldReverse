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

namespace Gaia
{
	public class GaiaWorldManager // TypeDefIndex: 9285
	{
		// Fields
		private Bounds m_worldBoundsWU; // 0x10
		private Bounds m_worldBoundsTU; // 0x28
		private Bounds m_worldBoundsNU; // 0x40
		private Vector3 m_WUtoTU; // 0x58
		private Vector3 m_TUtoWU; // 0x64
		private Vector3 m_TUtoNU; // 0x70
		private Vector3 m_NUtoTU; // 0x7C
		private Vector3 m_WUtoNU; // 0x88
		private Vector3 m_NUtoWU; // 0x94
		private Vector3 m_NUZeroOffset; // 0xA0
		private Vector3 m_TUZeroOffset; // 0xAC
		private ulong m_boundsCheckErrors; // 0xB8
		private Terrain[,] m_physicalTerrainArray; // 0xC0
		private Bounds[,] m_physicalTerrainBoundsArray; // 0xC8
		private UnityHeightMap[,] m_heightMapTerrainArray; // 0xD0
		private int m_tilesX; // 0xD8
		private int m_tilesZ; // 0xDC
		private Vector3 m_tileSizeWU; // 0xE0
		private Vector3 m_tileSizeTU; // 0xEC
	
		// Properties
		public int TileCount { /* [XID] */ /* 0x00000001899C9240-0x00000001899C9260 */ get => default; } // 0x0000000185EDE980-0x0000000185EDEA30 
		public int TileCountX { /* [XID] */ /* 0x00000001899D0DD0-0x00000001899D0DF0 */ get => default; } // 0x0000000185EDE840-0x0000000185EDE8E0 
		public int TileCountZ { /* [XID] */ /* 0x0000000189AF4DA0-0x0000000189AF4DC0 */ get => default; } // 0x0000000185EDE8E0-0x0000000185EDE980 
		public Terrain[,] PhysicalTerrainArray { /* [XID] */ /* 0x00000001899DF880-0x00000001899DF8A0 */ get => default; /* [XID] */ /* 0x00000001899E7370-0x00000001899E7390 */ set {} } // 0x0000000185EDE6E0-0x0000000185EDE790 0x0000000185EDF1E0-0x0000000185EDF290
		public Bounds[,] PhysicalTerrainBoundsArray { /* [XID] */ /* 0x00000001899EE840-0x00000001899EE860 */ get => default; /* [XID] */ /* 0x00000001899F6070-0x00000001899F6090 */ set {} } // 0x0000000185EDE790-0x0000000185EDE840 0x0000000185EDF290-0x0000000185EDF340
		public UnityHeightMap[,] HeightMapTerrainArray { /* [XID] */ /* 0x00000001899FD6D0-0x00000001899FD6F0 */ get => default; /* [XID] */ /* 0x0000000189A04D80-0x0000000189A04DA0 */ set {} } // 0x0000000185EDE630-0x0000000185EDE6E0 0x0000000185EDF130-0x0000000185EDF1E0
		public Vector3 TileSizeTU { /* [XID] */ /* 0x0000000189A0C430-0x0000000189A0C450 */ get => default; } // 0x0000000185EDEA30-0x0000000185EDEB10 
		public Vector3 TileSizeWU { /* [XID] */ /* 0x0000000189A13E50-0x0000000189A13E70 */ get => default; } // 0x0000000185EDEB10-0x0000000185EDEBF0 
		public Bounds WorldBoundsWU { /* [XID] */ /* 0x00000001899F8DB0-0x00000001899F8DD0 */ get => default; } // 0x0000000185EDEF90-0x0000000185EDF080 
		public Bounds WorldBoundsTU { /* [XID] */ /* 0x0000000189A22960-0x0000000189A22980 */ get => default; } // 0x0000000185EDEEA0-0x0000000185EDEF90 
		public Bounds WorldBoundsNU { /* [XID] */ /* 0x000000018982F950-0x000000018982F970 */ get => default; } // 0x0000000185EDEDB0-0x0000000185EDEEA0 
		public Vector3 WUtoTUConversionFactor { /* [XID] */ /* 0x0000000189961310-0x0000000189961330 */ get => default; } // 0x0000000185EDECD0-0x0000000185EDEDB0 
		public Vector3 WUtoNUConversionFactor { /* [XID] */ /* 0x0000000189A38CB0-0x0000000189A38CD0 */ get => default; } // 0x0000000185EDEBF0-0x0000000185EDECD0 
		public ulong BoundsCheckErrors { /* [XID] */ /* 0x0000000189AFF3B0-0x0000000189AFF3D0 */ get => default; /* [XID] */ /* 0x0000000189A479B0-0x0000000189A479D0 */ set {} } // 0x0000000185EDE580-0x0000000185EDE630 0x0000000185EDF080-0x0000000185EDF130
	
		// Constructors
		public GaiaWorldManager() {} // 0x0000000185EDE390-0x0000000185EDE580
		public GaiaWorldManager(Terrain[] terrains) {} // 0x0000000185EDD430-0x0000000185EDE390
	
		// Methods
		// [XID] // 0x0000000189A4F190-0x0000000189A4F1B0
		public string IsValidWorld(Terrain[] terrains) => default; // 0x0000000185ED6430-0x0000000185ED7AF0
		// [XID] // 0x0000000189A56720-0x0000000189A56740
		public Terrain GetTerrainWU(Vector3 positionWU) => default; // 0x0000000185ED5C60-0x0000000185ED5DF0
		// [XID] // 0x0000000189A5E420-0x0000000189A5E440
		public bool GetTerrainBoundsWU(Vector3 positionWU, ref Bounds terrainBounds) => default; // 0x0000000185ED5530-0x0000000185ED56F0
		// [XID] // 0x00000001899FEE60-0x00000001899FEE80
		private Terrain GetTerrainTU(Vector3 positionTU) => default; // 0x0000000185ED5AD0-0x0000000185ED5C60
		// [XID] // 0x0000000189A94D50-0x0000000189A94D70
		private Terrain GetTerrainNU(Vector3 positionNU) => default; // 0x0000000185ED5940-0x0000000185ED5AD0
		// [XID] // 0x0000000189A74AE0-0x0000000189A74B00
		public UnityHeightMap GetHeightMapWU(Vector3 positionWU) => default; // 0x0000000185ED4CE0-0x0000000185ED4F30
		// [XID] // 0x0000000189A7C4F0-0x0000000189A7C510
		private UnityHeightMap GetHeightMapTU(Vector3 positionTU) => default; // 0x0000000185ED4A90-0x0000000185ED4CE0
		// [XID] // 0x0000000189A83E20-0x0000000189A83E40
		private UnityHeightMap GetHeightMapNU(Vector3 positionNU) => default; // 0x0000000185ED4840-0x0000000185ED4A90
		// [XID] // 0x0000000189B03110-0x0000000189B03130
		public void LoadFromWorld() {} // 0x0000000185ED7AF0-0x0000000185ED7D20
		// [XID] // 0x0000000189755DE0-0x0000000189755E00
		public void SaveToWorld(bool forceWrite = false /* Metadata: 0x00AE5712 */) {} // 0x0000000185ED8730-0x0000000185ED88F0
		// [IDTag] // 0x0000000189A9A900-0x0000000189A9A940
		// [XID] // 0x0000000189A9A900-0x0000000189A9A940
		public void SetHeightWU(float heightWU) {} // 0x0000000185ED8BD0-0x0000000185ED8D90
		// [IDTag] // 0x0000000189AA4BA0-0x0000000189AA4BE0
		// [XID] // 0x0000000189AA4BA0-0x0000000189AA4BE0
		public void SetHeightWU(Vector3 positionWU, float height) {} // 0x0000000185ED8A60-0x0000000185ED8BD0
		// [XID] // 0x0000000189A06700-0x0000000189A06720
		public float GetHeightWU(Vector3 positionWU) => default; // 0x0000000185ED5090-0x0000000185ED51F0
		// [XID] // 0x00000001896DA400-0x00000001896DA420
		public float GetHeightInterpolatedWU(Vector3 positionWU) => default; // 0x0000000185ED46E0-0x0000000185ED4840
		// [XID] // 0x0000000189ABE700-0x0000000189ABE720
		public void SetHeightTU(Vector3 positionTU, float height) {} // 0x0000000185ED88F0-0x0000000185ED8A60
		// [XID] // 0x0000000189AC6210-0x0000000189AC6230
		public float GetHeightTU(Vector3 positionTU) => default; // 0x0000000185ED4F30-0x0000000185ED5090
		// [XID] // 0x000000018976A0D0-0x000000018976A0F0
		public float GetHeightInterpolatedTU(Vector3 positionTU) => default; // 0x0000000185ED4580-0x0000000185ED46E0
		// [XID] // 0x0000000189AD56F0-0x0000000189AD5710
		public void StitchTiles() {} // 0x0000000185ED9380-0x0000000185ED99B0
		// [XID] // 0x00000001897A3A90-0x00000001897A3AB0
		public void FlattenWorld() {} // 0x0000000185ED41B0-0x0000000185ED43F0
		// [XID] // 0x00000001899FD4B0-0x00000001899FD4D0
		public void SmoothWorld() {} // 0x0000000185ED9140-0x0000000185ED9380
		// [XID] // 0x0000000189B05870-0x0000000189B05890
		public void ClearDetails() {} // 0x0000000185ED2B30-0x0000000185ED2D40
		// [XID] // 0x0000000189AF3950-0x0000000189AF3970
		public void ClearTrees() {} // 0x0000000185ED2D40-0x0000000185ED2EB0
		// [XID] // 0x0000000189AFB180-0x0000000189AFB1A0
		public Vector3 GetRandomLocationInWorld(Vector3 start, float radius = 100f /* Metadata: 0x00AE5713 */, float safetyBounds = 50f /* Metadata: 0x00AE5717 */) => default; // 0x0000000185ED51F0-0x0000000185ED5530
		// [XID] // 0x0000000189796C90-0x0000000189796CB0
		public void ExportWorldAsPng(string path) {} // 0x0000000185ED3E90-0x0000000185ED41B0
		// [XID] // 0x0000000189B09D90-0x0000000189B09DB0
		public void ExportSplatmapAsPng(string path, int textureIdx) {} // 0x0000000185ED3BD0-0x0000000185ED3E90
		// [XID] // 0x0000000189B11720-0x0000000189B11740
		public void ExportGrassmapAsPng(string path) {} // 0x0000000185ED2EB0-0x0000000185ED32B0
		// [XID] // 0x00000001897DF7D0-0x00000001897DF7F0
		public void ExportNormalmapAsPng(string path) {} // 0x0000000185ED32B0-0x0000000185ED37F0
		// [XID] // 0x0000000189B20010-0x0000000189B20030
		public void ExportShorelineMask(string path, float shoreHeightWU, float shoreWidthWU) {} // 0x0000000185ED37F0-0x0000000185ED3BD0
		// [XID] // 0x0000000189B276E0-0x0000000189B27700
		private void MakeMask(Vector3 positionTU, float shoreHeightNU, float maskSizeTU, HeightMap waterMask) {} // 0x0000000185ED7D20-0x0000000185ED8060
		// [XID] // 0x00000001896A1A20-0x00000001896A1A40
		public static bool GetTerrainBounds(Terrain terrain, ref Bounds bounds) => default; // 0x0000000185ED56F0-0x0000000185ED5940
		// [IDTag] // 0x0000000189B361C0-0x0000000189B36200
		// [XID] // 0x0000000189B361C0-0x0000000189B36200
		public bool InBoundsWU(Vector3 positionWU) => default; // 0x0000000185ED62B0-0x0000000185ED6430
		// [IDTag] // 0x0000000189B40C80-0x0000000189B40CC0
		// [XID] // 0x0000000189B40C80-0x0000000189B40CC0
		public bool InBoundsWU(Vector3 positionWU, float safety) => default; // 0x0000000185ED60F0-0x0000000185ED62B0
		// [XID] // 0x0000000189B4B320-0x0000000189B4B340
		public bool InBoundsTU(Vector3 positionTU) => default; // 0x0000000185ED5F70-0x0000000185ED60F0
		// [XID] // 0x0000000189B52B00-0x0000000189B52B20
		public bool InBoundsNU(Vector3 positionNU) => default; // 0x0000000185ED5DF0-0x0000000185ED5F70
		// [XID] // 0x0000000189B5A520-0x0000000189B5A540
		public Vector3 WUtoTU(Vector3 positionWU) => default; // 0x0000000185EDD2B0-0x0000000185EDD430
		// [XID] // 0x0000000189B61920-0x0000000189B61940
		public Vector3 WUtoNU(Vector3 positionWU) => default; // 0x0000000185EDCAB0-0x0000000185EDCC30
		// [XID] // 0x0000000189B69510-0x0000000189B69530
		public Vector3 WUtoNUL(Vector3 positionWU) => default; // 0x0000000185EDC8C0-0x0000000185EDCAB0
		// [XID] // 0x0000000189B70A40-0x0000000189B70A60
		public Vector3 WUtoPNU(Vector3 positionWU) => default; // 0x0000000185EDCE50-0x0000000185EDCFF0
		// [XID] // 0x0000000189B77FB0-0x0000000189B77FD0
		public Vector3 WUtoPNUL(Vector3 positionWU) => default; // 0x0000000185EDCC30-0x0000000185EDCE50
		// [XID] // 0x00000001899B7100-0x00000001899B7120
		public Vector3 WUtoPTI(Vector3 positionWU) => default; // 0x0000000185EDCFF0-0x0000000185EDD150
		// [XID] // 0x00000001895E5E90-0x00000001895E5EB0
		public Vector3 WUtoPTO(Vector3 positionWU) => default; // 0x0000000185EDD150-0x0000000185EDD2B0
		// [XID] // 0x0000000189B8E2C0-0x0000000189B8E2E0
		public Vector3 TUtoWU(Vector3 positionTU) => default; // 0x0000000185ED9EA0-0x0000000185EDA020
		// [XID] // 0x000000018994AB40-0x000000018994AB60
		public Vector3 TUtoNU(Vector3 positionTU) => default; // 0x0000000185ED99B0-0x0000000185ED9B30
		// [XID] // 0x0000000189B9CD00-0x0000000189B9CD20
		public Vector3 TUtoPTI(Vector3 positionTU) => default; // 0x0000000185ED9B30-0x0000000185ED9C90
		// [XID] // 0x0000000189BA4490-0x0000000189BA44B0
		public Vector3 TUtoPTO(Vector3 positionTU) => default; // 0x0000000185ED9C90-0x0000000185ED9EA0
		// [XID] // 0x00000001897E2DC0-0x00000001897E2DE0
		public Vector3 NUtoWU(Vector3 positionNU) => default; // 0x0000000185ED85B0-0x0000000185ED8730
		// [XID] // 0x0000000189BB2F80-0x0000000189BB2FA0
		public Vector3 NUtoTU(Vector3 positionNU) => default; // 0x0000000185ED8430-0x0000000185ED85B0
		// [XID] // 0x0000000189956800-0x0000000189956820
		public Vector3 NUtoPTI(Vector3 positionNU) => default; // 0x0000000185ED8060-0x0000000185ED8200
		// [XID] // 0x00000001899F3100-0x00000001899F3120
		public Vector3 NUtoPTO(Vector3 positionNU) => default; // 0x0000000185ED8200-0x0000000185ED8430
		// [XID] // 0x0000000189BC9AE0-0x0000000189BC9B00
		public Vector3 Ceil(Vector3 source) => default; // 0x0000000185ED29A0-0x0000000185ED2B30
		// [XID] // 0x0000000189BD1210-0x0000000189BD1230
		public Vector3 Floor(Vector3 source) => default; // 0x0000000185ED43F0-0x0000000185ED4580
		// [XID] // 0x0000000189BD8910-0x0000000189BD8930
		public void Test() {} // 0x0000000185EDA4F0-0x0000000185EDC8C0
		// [XID] // 0x0000000189BE0070-0x0000000189BE0090
		public void TestBlobWU(Vector3 positionWU, int widthWU, float height) {} // 0x0000000185EDA290-0x0000000185EDA4F0
		// [XID] // 0x00000001895ECE40-0x00000001895ECE60
		public void TestBlobTU(Vector3 positionTU, int widthWU, float height) {} // 0x0000000185EDA020-0x0000000185EDA290
		// [XID] // 0x00000001895F4520-0x00000001895F4540
		public void SetSubterrainByIndex(int terrainIndex, bool toDisableOthers) {} // 0x0000000185ED8D90-0x0000000185ED9140
	}
}
