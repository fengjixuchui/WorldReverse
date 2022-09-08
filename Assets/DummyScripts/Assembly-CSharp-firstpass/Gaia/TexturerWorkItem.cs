/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[Serializable]
	public class TexturerWorkItem : IGaiaWorkItem // TypeDefIndex: 9170
	{
		// Fields
		private int m_tileX; // 0x10
		private int m_tileZ; // 0x14
		private bool m_liveUpdate; // 0x18
		private Vector3 m_texturerLocation; // 0x1C
		private Vector3 m_texturerLocationPNU; // 0x28
		private Vector3 m_heightmapLocationPNU; // 0x34
		private float m_seaLevel; // 0x40
		private float m_terrainHeight; // 0x44
		private List<GaiaTextureCriteria> m_textureCriteria; // 0x48
		private Texture2D m_textureMask; // 0x50
		private GaiaTexturerExtension m_texturerExtension; // 0x58
		private float m_texturerHorizontalScale; // 0x60
		private Terrain m_targetTerrain; // 0x68
		private UnityHeightMap m_targetTerrainHM; // 0x70
		private bool m_useHeightMapOverride; // 0x78
		private int m_terrainSplatmapDimensions; // 0x7C
		private int m_terrainSplatmapCount; // 0x80
		private float[,,] m_terrainSplatmaps; // 0x88
		private Bounds m_targetTerrainBounds; // 0x90
		private ComputeShader m_computeShader; // 0xA8
		private int m_computeTexturerKernel; // 0xB0
		private ComputeBuffer m_computeTerrainBuffer; // 0xB8
		private bool m_useCompute; // 0xC0
		private ulong m_jobID; // 0xC8
		private GaiaConstants.JobStatus m_status; // 0xD0
		private static int m_activeTexturerJobs; // 0x00
		private bool m_isCancelled; // 0xD4
		private bool m_isErrored; // 0xD5
		private string m_errorString; // 0xD8
	
		// Properties
		public int TileX { /* [XID] */ /* 0x00000001899A2510-0x00000001899A2530 */ get => default; /* [XID] */ /* 0x00000001899A9C60-0x00000001899A9C80 */ set {} } // 0x0000000185A3FBC0-0x0000000185A3FC60 0x0000000185A40A40-0x0000000185A40AF0
		public int TileZ { /* [XID] */ /* 0x00000001899B1720-0x00000001899B1740 */ get => default; /* [XID] */ /* 0x00000001899B8BD0-0x00000001899B8BF0 */ set {} } // 0x0000000185A3FC60-0x0000000185A3FD00 0x0000000185A40AF0-0x0000000185A40BA0
		public bool LiveUpdate { /* [XID] */ /* 0x00000001899C04E0-0x00000001899C0500 */ get => default; /* [XID] */ /* 0x00000001899C7D50-0x00000001899C7D70 */ set {} } // 0x0000000185A3F4F0-0x0000000185A3F590 0x0000000185A40350-0x0000000185A40400
		public Vector3 TexturerLocation { /* [XID] */ /* 0x00000001899CF620-0x00000001899CF640 */ get => default; /* [XID] */ /* 0x000000018996EBF0-0x000000018996EC10 */ set {} } // 0x0000000185A3FAE0-0x0000000185A3FBC0 0x0000000185A408E0-0x0000000185A40A40
		public float SeaLevel { /* [XID] */ /* 0x0000000189BCF2D0-0x0000000189BCF2F0 */ get => default; /* [XID] */ /* 0x0000000189958430-0x0000000189958450 */ set {} } // 0x0000000185A3F650-0x0000000185A3F700 0x0000000185A40400-0x0000000185A404B0
		public float TerrainHeight { /* [XID] */ /* 0x00000001899ECF20-0x00000001899ECF40 */ get => default; /* [XID] */ /* 0x0000000189763CE0-0x0000000189763D00 */ set {} } // 0x0000000185A3F7A0-0x0000000185A3F850 0x0000000185A40560-0x0000000185A40610
		public List<GaiaTextureCriteria> TextureCriteria { /* [XID] */ /* 0x00000001899FC2A0-0x00000001899FC2C0 */ get => default; /* [XID] */ /* 0x0000000189950C70-0x0000000189950C90 */ set {} } // 0x0000000185A3F850-0x0000000185A3F8F0 0x0000000185A40610-0x0000000185A406C0
		public Texture2D TextureMask { /* [XID] */ /* 0x0000000189712A10-0x0000000189712A30 */ get => default; /* [XID] */ /* 0x00000001899E9D50-0x00000001899E9D70 */ set {} } // 0x0000000185A3F8F0-0x0000000185A3F990 0x0000000185A406C0-0x0000000185A40770
		public GaiaTexturerExtension TexturerExtension { /* [XID] */ /* 0x00000001898286A0-0x00000001898286C0 */ get => default; /* [XID] */ /* 0x0000000189A20FA0-0x0000000189A20FC0 */ set {} } // 0x0000000185A3F990-0x0000000185A3FA30 0x0000000185A40770-0x0000000185A40820
		public float TexturerHorizontalScale { /* [XID] */ /* 0x0000000189A3A070-0x0000000189A3A090 */ get => default; /* [XID] */ /* 0x000000018971A350-0x000000018971A370 */ set {} } // 0x0000000185A3FA30-0x0000000185A3FAE0 0x0000000185A40820-0x0000000185A408E0
		public UnityHeightMap HeightMapOverride { /* [XID] */ /* 0x0000000189773740-0x0000000189773760 */ set {} } // 0x0000000185A40090-0x0000000185A40140
		public ComputeShader GaiaCompute { /* [XID] */ /* 0x0000000189A3EC50-0x0000000189A3EC70 */ get => default; /* [XID] */ /* 0x0000000189A46380-0x0000000189A463A0 */ set {} } // 0x0000000185A3F230-0x0000000185A3F2E0 0x0000000185A3FF80-0x0000000185A40090
		public bool UseCompute { /* [XID] */ /* 0x0000000189A55300-0x0000000189A55320 */ get => default; /* [XID] */ /* 0x0000000189A5CAC0-0x0000000189A5CAE0 */ set {} } // 0x0000000185A3FD00-0x0000000185A3FDB0 0x0000000185A40BA0-0x0000000185A40C50
		public ulong JobID { /* [XID] */ /* 0x0000000189A64430-0x0000000189A64450 */ get => default; /* [XID] */ /* 0x000000018976C320-0x000000018976C340 */ set {} } // 0x0000000185A3F440-0x0000000185A3F4F0 0x0000000185A402A0-0x0000000185A40350
		public GaiaConstants.JobStatus Status { /* [XID] */ /* 0x0000000189785800-0x0000000189785820 */ get => default; /* [XID] */ /* 0x000000018977DE50-0x000000018977DE70 */ set {} } // 0x0000000185A3F700-0x0000000185A3F7A0 0x0000000185A404B0-0x0000000185A40560
		public int ActiveJobs { /* [XID] */ /* 0x0000000189A82600-0x0000000189A82620 */ get => default; /* [XID] */ /* 0x000000018978CD20-0x000000018978CD40 */ set {} } // 0x0000000185A3F0B0-0x0000000185A3F180 0x0000000185A3FDB0-0x0000000185A3FE90
		public bool IsCancelled { /* [XID] */ /* 0x0000000189A91700-0x0000000189A91720 */ get => default; /* [XID] */ /* 0x0000000189A2B0A0-0x0000000189A2B0C0 */ set {} } // 0x0000000185A3F2E0-0x0000000185A3F390 0x0000000185A40140-0x0000000185A401F0
		public bool IsErrored { /* [XID] */ /* 0x0000000189AA02F0-0x0000000189AA0310 */ get => default; /* [XID] */ /* 0x00000001897AAE80-0x00000001897AAEA0 */ set {} } // 0x0000000185A3F390-0x0000000185A3F440 0x0000000185A401F0-0x0000000185A402A0
		public string ErrorStr { /* [XID] */ /* 0x0000000189AAF460-0x0000000189AAF480 */ get => default; /* [XID] */ /* 0x0000000189AB6CB0-0x0000000189AB6CD0 */ set {} } // 0x0000000185A3F180-0x0000000185A3F230 0x0000000185A3FE90-0x0000000185A3FF80
		public bool NeedsBackground { /* [XID] */ /* 0x0000000189AD5710-0x0000000189AD5730 */ get => default; } // 0x0000000185A3F590-0x0000000185A3F650 
	
		// Constructors
		public TexturerWorkItem() {} // Dummy constructor
		public TexturerWorkItem(int tileX, int tileZ, ComputeShader texturerComputeShader) {} // 0x0000000185A3EEA0-0x0000000185A3F0B0
		static TexturerWorkItem() {} // 0x0000000185A3EE40-0x0000000185A3EEA0
	
		// Methods
		// [XID] // 0x0000000189A4D9B0-0x0000000189A4D9D0
		public bool HasCompute() => default; // 0x0000000185A3E560-0x0000000185A3E640
		// [XID] // 0x0000000189ABE740-0x0000000189ABE760
		public float PercentComplete() => default; // 0x0000000185A3E920-0x0000000185A3EA10
		// [XID] // 0x0000000189B23570-0x0000000189B23590
		public void ResetToIdle() {} // 0x0000000185A3EA10-0x0000000185A3EAD0
		// [XID] // 0x0000000189ACD900-0x0000000189ACD920
		public void ExecuteSetupInForeground() {} // 0x0000000185A3E090-0x0000000185A3E490
		// [XID] // 0x00000001897BA5A0-0x00000001897BA5C0
		public void ExecuteWorkInBackground() {} // 0x0000000185A3E490-0x0000000185A3E560
		// [XID] // 0x00000001897D4440-0x00000001897D4460
		public void ExecutePostProcessInForeground() {} // 0x0000000185A3DEC0-0x0000000185A3E090
		// [XID] // 0x0000000189A4BF70-0x0000000189A4BF90
		public void ApplyOperationWithGPU() {} // 0x0000000185A3D170-0x0000000185A3DD80
		// [XID] // 0x00000001897CCDA0-0x00000001897CCDC0
		public void ApplyOperationWithCPU() {} // 0x0000000185A3C970-0x0000000185A3D170
		// [XID] // 0x0000000189A04B80-0x0000000189A04BA0
		public void LoadFromTerrain() {} // 0x0000000185A3E640-0x0000000185A3E920
		// [XID] // 0x0000000189B027C0-0x0000000189B027E0
		public void ApplyToTerrain() {} // 0x0000000185A3DD80-0x0000000185A3DEC0
		// [XID] // 0x000000018982EC90-0x000000018982ECB0
		private static float[] To1DArray(float[,] source) => default; // 0x0000000185A3EAD0-0x0000000185A3EC00
		// [IDTag] // 0x0000000189B11740-0x0000000189B11780
		// [XID] // 0x0000000189B11740-0x0000000189B11780
		private static float[,] To2DArray(float[] source) => default; // 0x0000000185A3ED10-0x0000000185A3EE40
		// [IDTag] // 0x0000000189B1B9E0-0x0000000189B1BA20
		// [XID] // 0x0000000189B1B9E0-0x0000000189B1BA20
		private static float[,] To2DArray(float[] source, int width, int height) => default; // 0x0000000185A3EC00-0x0000000185A3ED10
	}
}
