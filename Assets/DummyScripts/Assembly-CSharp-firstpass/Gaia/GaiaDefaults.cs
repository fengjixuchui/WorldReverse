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
	public class GaiaDefaults : ScriptableObject // TypeDefIndex: 9282
	{
		// Fields
		[HideInInspector] // 0x00000001896816C0-0x0000000189681700
		// [Tooltip] // 0x00000001896816C0-0x0000000189681700
		public string m_defaultsID; // 0x18
		// [Tooltip] // 0x000000018968D620-0x000000018968D650
		public float m_seaLevel; // 0x20
		// [Tooltip] // 0x0000000189696D80-0x0000000189696DB0
		public float m_beachHeight; // 0x24
		// [Range] // 0x000000018969F8E0-0x000000018969F930
		// [Tooltip] // 0x000000018969F8E0-0x000000018969F930
		public int m_tilesX; // 0x28
		// [Range] // 0x00000001896AB1A0-0x00000001896AB200
		// [Tooltip] // 0x00000001896AB1A0-0x00000001896AB200
		public int m_tilesZ; // 0x2C
		// [Header] // 0x00000001896B6ED0-0x00000001896B6F70
		// [Range] // 0x00000001896B6ED0-0x00000001896B6F70
		[Space] // 0x00000001896B6ED0-0x00000001896B6F70
		// [Tooltip] // 0x00000001896B6ED0-0x00000001896B6F70
		public int m_pixelError; // 0x30
		// [Range] // 0x00000001896C9D70-0x00000001896C9DC0
		// [Tooltip] // 0x00000001896C9D70-0x00000001896C9DC0
		public int m_baseMapDist; // 0x34
		// [Tooltip] // 0x00000001896D5C30-0x00000001896D5C60
		public bool m_castShadows; // 0x38
		// [Tooltip] // 0x00000001896DED90-0x00000001896DEDC0
		public UnityEngine.Material m_material; // 0x40
		// [Tooltip] // 0x00000001896E7700-0x00000001896E7730
		public PhysicMaterial m_physicsMaterial; // 0x48
		// [Header] // 0x00000001896F02C0-0x00000001896F0340
		[Space] // 0x00000001896F02C0-0x00000001896F0340
		// [Tooltip] // 0x00000001896F02C0-0x00000001896F0340
		public bool m_draw; // 0x50
		// [Range] // 0x0000000189700D10-0x0000000189700D70
		// [Tooltip] // 0x0000000189700D10-0x0000000189700D70
		public int m_detailDistance; // 0x54
		// [Range] // 0x000000018970C9A0-0x000000018970C9F0
		// [Tooltip] // 0x000000018970C9A0-0x000000018970C9F0
		public float m_detailDensity; // 0x58
		// [Range] // 0x0000000189718B20-0x0000000189718B70
		// [Tooltip] // 0x0000000189718B20-0x0000000189718B70
		public int m_treeDistance; // 0x5C
		// [Range] // 0x0000000189724780-0x00000001897247E0
		// [Tooltip] // 0x0000000189724780-0x00000001897247E0
		public int m_billboardStart; // 0x60
		// [Range] // 0x00000001897307F0-0x0000000189730850
		// [Tooltip] // 0x00000001897307F0-0x0000000189730850
		public int m_fadeLength; // 0x64
		// [Range] // 0x000000018973C9C0-0x000000018973CA10
		// [Tooltip] // 0x000000018973C9C0-0x000000018973CA10
		public int m_maxMeshTrees; // 0x68
		// [Header] // 0x0000000189748990-0x0000000189748A20
		// [Range] // 0x0000000189748990-0x0000000189748A20
		[Space] // 0x0000000189748990-0x0000000189748A20
		// [Tooltip] // 0x0000000189748990-0x0000000189748A20
		public float m_speed; // 0x6C
		// [Range] // 0x000000018975BB90-0x000000018975BBF0
		// [Tooltip] // 0x000000018975BB90-0x000000018975BBF0
		public float m_size; // 0x70
		// [Range] // 0x00000001897679A0-0x00000001897679F0
		// [Tooltip] // 0x00000001897679A0-0x00000001897679F0
		public float m_bending; // 0x74
		// [Tooltip] // 0x00000001897739B0-0x00000001897739E0
		public Color m_grassTint; // 0x78
		// [Header] // 0x000000018977C880-0x000000018977C900
		[Space] // 0x000000018977C880-0x000000018977C900
		// [Tooltip] // 0x000000018977C880-0x000000018977C900
		public int m_terrainSize; // 0x88
		// [Tooltip] // 0x000000018978CED0-0x000000018978CF00
		public int m_terrainHeight; // 0x8C
		// [Tooltip] // 0x0000000189795E60-0x0000000189795E90
		public int m_heightmapResolution; // 0x90
		// [Tooltip] // 0x000000018979F780-0x000000018979F7B0
		public int m_detailResolution; // 0x94
		// [Tooltip] // 0x00000001897A8340-0x00000001897A8370
		public int m_detailResolutionPerPatch; // 0x98
		// [Tooltip] // 0x00000001897B1340-0x00000001897B1370
		public int m_controlTextureResolution; // 0x9C
		// [Tooltip] // 0x00000001897BA9A0-0x00000001897BA9D0
		public int m_baseMapSize; // 0xA0
	
		// Constructors
		public GaiaDefaults() {} // 0x000000018658CD60-0x000000018658CF10
	
		// Methods
		// [IDTag] // 0x00000001897C3DD0-0x00000001897C3E10
		// [XID] // 0x00000001897C3DD0-0x00000001897C3E10
		public void CreateTerrain() {} // 0x000000018658B0F0-0x000000018658B3F0
		// [XID] // 0x0000000189A39350-0x0000000189A39370
		public void UpdateFromTerrain() {} // 0x000000018658CA30-0x000000018658CD60
		// [IDTag] // 0x00000001897D5EB0-0x00000001897D5EF0
		// [XID] // 0x00000001897D5EB0-0x00000001897D5EF0
		public void CreateTerrain(GaiaResource resources) {} // 0x000000018658B3F0-0x000000018658B680
		// [XID] // 0x00000001897E0770-0x00000001897E0790
		public GaiaOperation GetTerrainCreationOperation(GaiaResource resources) => default; // 0x000000018658C5A0-0x000000018658C720
		// [XID] // 0x00000001897E7DB0-0x00000001897E7DD0
		private void CreateTile(int tx, int tz, ref Terrain[,] world, GaiaResource resources) {} // 0x000000018658B680-0x000000018658BE20
		// [XID] // 0x000000018995A5F0-0x000000018995A610
		private void RemoveWorldSeams(ref Terrain[,] world) {} // 0x000000018658C720-0x000000018658C920
		// [XID] // 0x00000001898916C0-0x00000001898916E0
		public string GetAndFixDefaults() => default; // 0x000000018658BF40-0x000000018658C5A0
		// [XID] // 0x00000001897FE7B0-0x00000001897FE7D0
		public string SerialiseJson() => default; // 0x000000018658C920-0x000000018658CA30
		// [XID] // 0x0000000189BC8FC0-0x0000000189BC8FE0
		public void DeSerialiseJson(string json) {} // 0x000000018658BE20-0x000000018658BF40
	}
}
