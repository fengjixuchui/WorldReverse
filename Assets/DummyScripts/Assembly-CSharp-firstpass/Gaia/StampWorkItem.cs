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
	[Serializable]
	public class StampWorkItem : IGaiaWorkItem // TypeDefIndex: 9168
	{
		// Fields
		private int m_tileX; // 0x10
		private int m_tileZ; // 0x14
		private GaiaConstants.FeatureOperation m_operation; // 0x18
		private GaiaConstants.FeatureOperationType m_operationType; // 0x1C
		private bool m_liveUpdate; // 0x20
		private float m_powerFactor; // 0x24
		private Vector3 m_stampLocation; // 0x28
		private Vector3 m_stampLocationPNU; // 0x34
		private Vector3 m_heightmapLocationPNU; // 0x40
		private float m_stampRotation; // 0x4C
		private float m_stampVerticalScale; // 0x50
		private float m_stampHorizontalScale; // 0x54
		private UnityHeightMap m_stampHM; // 0x58
		private Terrain m_targetTerrain; // 0x60
		private UnityHeightMap m_targetTerrainHM; // 0x68
		private Bounds m_targetTerrainBounds; // 0x70
		private float[] m_distanceMask; // 0x88
		private GaiaTexturer m_texturer; // 0x90
		private GaiaStamper m_gStamper; // 0x98
		private ComputeShader m_computeShader; // 0xA0
		private int m_computeStampKernel; // 0xA8
		private ComputeBuffer m_computeTerrainBuffer; // 0xB0
		private ComputeBuffer m_computeStampBuffer; // 0xB8
		private ComputeBuffer m_computeDistanceMaskBuffer; // 0xC0
		private bool m_useCompute; // 0xC8
		private ulong m_jobID; // 0xD0
		private GaiaConstants.JobStatus m_status; // 0xD8
		private static int m_activeStampJobs; // 0x00
		private bool m_isCancelled; // 0xDC
		private bool m_isErrored; // 0xDD
		private string m_errorString; // 0xE0
	
		// Properties
		public int TileX { /* [XID] */ /* 0x00000001895EEE60-0x00000001895EEE80 */ get => default; /* [XID] */ /* 0x0000000189AB5D60-0x0000000189AB5D80 */ set {} } // 0x0000000186452EC0-0x0000000186452F60 0x00000001864541A0-0x0000000186454250
		public int TileZ { /* [XID] */ /* 0x00000001897F2C70-0x00000001897F2C90 */ get => default; /* [XID] */ /* 0x0000000189B1ABA0-0x0000000189B1ABC0 */ set {} } // 0x0000000186452F60-0x0000000186453000 0x0000000186454250-0x0000000186454300
		public GaiaConstants.FeatureOperation Operation { /* [XID] */ /* 0x0000000189A7E520-0x0000000189A7E540 */ get => default; /* [XID] */ /* 0x00000001899BA170-0x00000001899BA190 */ set {} } // 0x0000000186452890-0x0000000186452930 0x0000000186453860-0x0000000186453960
		public GaiaConstants.FeatureOperationType OperationType { /* [XID] */ /* 0x0000000189810850-0x0000000189810870 */ get => default; /* [XID] */ /* 0x00000001899D2BD0-0x00000001899D2BF0 */ set {} } // 0x00000001864527F0-0x0000000186452890 0x00000001864537B0-0x0000000186453860
		public bool LiveUpdate { /* [XID] */ /* 0x0000000189A65A00-0x0000000189A65A20 */ get => default; /* [XID] */ /* 0x0000000189826F60-0x0000000189826F80 */ set {} } // 0x0000000186452690-0x0000000186452730 0x0000000186453700-0x00000001864537B0
		public float PowerFactor { /* [XID] */ /* 0x0000000189725060-0x0000000189725080 */ get => default; /* [XID] */ /* 0x0000000189835C90-0x0000000189835CB0 */ set {} } // 0x0000000186452930-0x00000001864529E0 0x0000000186453960-0x0000000186453A80
		public Vector3 StampLocation { /* [XID] */ /* 0x000000018971DB80-0x000000018971DBA0 */ get => default; /* [XID] */ /* 0x0000000189A747E0-0x0000000189A74800 */ set {} } // 0x0000000186452B30-0x0000000186452C10 0x0000000186453CA0-0x0000000186453E00
		public float StampRotation { /* [XID] */ /* 0x000000018972C780-0x000000018972C7A0 */ get => default; /* [XID] */ /* 0x0000000189852D30-0x0000000189852D50 */ set {} } // 0x0000000186452C10-0x0000000186452CC0 0x0000000186453E00-0x0000000186453F20
		public float StampVerticalScale { /* [XID] */ /* 0x000000018985A990-0x000000018985A9B0 */ get => default; /* [XID] */ /* 0x0000000189AD6C10-0x0000000189AD6C30 */ set {} } // 0x0000000186452CC0-0x0000000186452D70 0x0000000186453F20-0x0000000186454040
		public float StampHorizontalScale { /* [XID] */ /* 0x0000000189869380-0x00000001898693A0 */ get => default; /* [XID] */ /* 0x0000000189ACEC90-0x0000000189ACECB0 */ set {} } // 0x0000000186452A80-0x0000000186452B30 0x0000000186453B80-0x0000000186453CA0
		public UnityHeightMap StampHeightMap { /* [XID] */ /* 0x0000000189657140-0x0000000189657160 */ get => default; /* [XID] */ /* 0x0000000189A6D110-0x0000000189A6D130 */ set {} } // 0x00000001864529E0-0x0000000186452A80 0x0000000186453A80-0x0000000186453B80
		public float[] DistanceMask { /* [XID] */ /* 0x0000000189886CC0-0x0000000189886CE0 */ get => default; /* [XID] */ /* 0x0000000189AED330-0x0000000189AED350 */ set {} } // 0x00000001864521C0-0x0000000186452270 0x0000000186453190-0x0000000186453240
		public GaiaTexturer Texturer { /* [XID] */ /* 0x00000001896F3F80-0x00000001896F3FA0 */ get => default; /* [XID] */ /* 0x0000000189AE5F20-0x0000000189AE5F40 */ set {} } // 0x0000000186452E10-0x0000000186452EC0 0x00000001864540F0-0x00000001864541A0
		public GaiaStamper GStamper { /* [XID] */ /* 0x000000018966D5F0-0x000000018966D610 */ get => default; /* [XID] */ /* 0x00000001898AB520-0x00000001898AB540 */ set {} } // 0x0000000186452320-0x00000001864523D0 0x0000000186453330-0x00000001864533E0
		public ComputeShader GaiaCompute { /* [XID] */ /* 0x00000001898B2DE0-0x00000001898B2E00 */ get => default; /* [XID] */ /* 0x000000018968A6C0-0x000000018968A6E0 */ set {} } // 0x00000001864523D0-0x0000000186452480 0x00000001864533E0-0x00000001864534F0
		public bool UseCompute { /* [XID] */ /* 0x00000001898C98E0-0x00000001898C9900 */ get => default; /* [XID] */ /* 0x00000001898D1060-0x00000001898D1080 */ set {} } // 0x0000000186453000-0x00000001864530B0 0x0000000186454300-0x00000001864543B0
		public ulong JobID { /* [XID] */ /* 0x00000001898D8770-0x00000001898D8790 */ get => default; /* [XID] */ /* 0x00000001896B2190-0x00000001896B21B0 */ set {} } // 0x00000001864525E0-0x0000000186452690 0x0000000186453650-0x0000000186453700
		public GaiaConstants.JobStatus Status { /* [XID] */ /* 0x0000000189989DB0-0x0000000189989DD0 */ get => default; /* [XID] */ /* 0x00000001898EF7C0-0x00000001898EF7E0 */ set {} } // 0x0000000186452D70-0x0000000186452E10 0x0000000186454040-0x00000001864540F0
		public int ActiveJobs { /* [XID] */ /* 0x00000001898F7100-0x00000001898F7120 */ get => default; /* [XID] */ /* 0x00000001898FE8D0-0x00000001898FE8F0 */ set {} } // 0x00000001864520F0-0x00000001864521C0 0x00000001864530B0-0x0000000186453190
		public bool IsCancelled { /* [XID] */ /* 0x00000001896C0FA0-0x00000001896C0FC0 */ get => default; /* [XID] */ /* 0x000000018974E730-0x000000018974E750 */ set {} } // 0x0000000186452480-0x0000000186452530 0x00000001864534F0-0x00000001864535A0
		public bool IsErrored { /* [XID] */ /* 0x00000001896CFF10-0x00000001896CFF30 */ get => default; /* [XID] */ /* 0x0000000189711FF0-0x0000000189712010 */ set {} } // 0x0000000186452530-0x00000001864525E0 0x00000001864535A0-0x0000000186453650
		public string ErrorStr { /* [XID] */ /* 0x00000001896DEB50-0x00000001896DEB70 */ get => default; /* [XID] */ /* 0x0000000189A0F140-0x0000000189A0F160 */ set {} } // 0x0000000186452270-0x0000000186452320 0x0000000186453240-0x0000000186453330
		public bool NeedsBackground { /* [XID] */ /* 0x0000000189ADCD30-0x0000000189ADCD50 */ get => default; } // 0x0000000186452730-0x00000001864527F0 
	
		// Constructors
		public StampWorkItem() {} // Dummy constructor
		public StampWorkItem(GaiaConstants.FeatureOperation operation, int tileX, int tileZ, ComputeShader stampComputeShader) {} // 0x0000000186451F10-0x00000001864520F0
		static StampWorkItem() {} // 0x0000000186451EB0-0x0000000186451F10
	
		// Methods
		// [XID] // 0x00000001898C1F60-0x00000001898C1F80
		public bool HasCompute() => default; // 0x0000000186451800-0x00000001864518E0
		// [XID] // 0x0000000189933120-0x0000000189933140
		public float PercentComplete() => default; // 0x00000001864518E0-0x00000001864519D0
		// [XID] // 0x00000001899F5EA0-0x00000001899F5EC0
		public void ResetToIdle() {} // 0x00000001864519D0-0x0000000186451A90
		// [XID] // 0x0000000189941B30-0x0000000189941B50
		public void ExecuteSetupInForeground() {} // 0x0000000186451190-0x0000000186451640
		// [XID] // 0x0000000189B26B50-0x0000000189B26B70
		public void ExecuteWorkInBackground() {} // 0x0000000186451640-0x0000000186451710
		// [XID] // 0x0000000189958680-0x00000001899586A0
		public void ExecutePostProcessInForeground() {} // 0x0000000186450EE0-0x0000000186451190
		// [XID] // 0x000000018995FD10-0x000000018995FD30
		public void SetOperation(GaiaConstants.FeatureOperation operation) {} // 0x0000000186451A90-0x0000000186451B40
		// [XID] // 0x0000000189967620-0x0000000189967640
		public void ApplyOperationWithGPU() {} // 0x0000000186450590-0x0000000186450E10
		// [XID] // 0x00000001899BF6B0-0x00000001899BF6D0
		public void ApplyOperationWithCPU() {} // 0x00000001864500F0-0x0000000186450590
		// [XID] // 0x00000001899763F0-0x0000000189976410
		public void ApplyToTerrain() {} // 0x0000000186450E10-0x0000000186450EE0
		// [XID] // 0x000000018997D710-0x000000018997D730
		public void FlushDirtyTilesToTerrain() {} // 0x0000000186451710-0x0000000186451800
		// [XID] // 0x0000000189A2A3A0-0x0000000189A2A3C0
		private static float[] To1DArray(float[,] source) => default; // 0x0000000186451B40-0x0000000186451C70
		// [IDTag] // 0x000000018998CD80-0x000000018998CDC0
		// [XID] // 0x000000018998CD80-0x000000018998CDC0
		private static float[,] To2DArray(float[] source) => default; // 0x0000000186451C70-0x0000000186451DA0
		// [IDTag] // 0x0000000189997810-0x0000000189997850
		// [XID] // 0x0000000189997810-0x0000000189997850
		private static float[,] To2DArray(float[] source, int width, int height) => default; // 0x0000000186451DA0-0x0000000186451EB0
	}
}
