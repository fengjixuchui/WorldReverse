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
	public class GaiaStamper : MonoBehaviour // TypeDefIndex: 9157
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_showSeaLevel; // 0x1A
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_seaLevel; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_showPreviewMesh; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material m_previewMaterial; // 0x28
		private MeshFilter m_previewFilter; // 0x30
		private MeshRenderer m_previewRenderer; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_isFittedToTerrain; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_liveUpdate; // 0x41
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GaiaConstants.FeatureSource m_stampType; // 0x44
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GaiaConstants.FeatureOperation m_operation; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GaiaConstants.FeatureOperationType m_operationType; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_previewImage; // 0x50
		[NonSerialized]
		private UnityHeightMap m_stampHM; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 m_stampLocation; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_stampRotation; // 0x6C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_stampVerticalScale; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_stampHorizontalScale; // 0x74
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 m_stampSizeTU; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Bounds m_boundsWU; // 0x84
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Bounds m_boundsScaledWU; // 0x9C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Bounds m_boundsRotatedScaledWU; // 0xB4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GaiaConstants.GaiaHeightmapResolution m_stampResolution; // 0xCC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_stampResolutionPx; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GaiaConstants.GaiaResolution m_heightmapResolution; // 0xD4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GaiaStamperExtension m_stamperExtension; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GaiaTexturer m_texturer; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_powerFilter; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve m_distanceFilter; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_terraceFilterCount; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GaiaTerraceItem> m_terraceFilters; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_smoothFilter; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_contrastFilter; // 0x10C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_thermalErosionFilterIterations; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_thermalErosionFilterTalus; // 0x114
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_thermalErosionFilterGrowthPower; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_thermalErosionFilterSinkPower; // 0x11C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_hydraulicErosionFilterIterations; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_hydraulicErosionFilterRainFrequency; // 0x124
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_hydraulicErosionFilterSedimentDisolveRate; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_heightMapFilterImage; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_heightMapFilterImageStrength; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_heightMapFilterTiling; // 0x13C
		private float m_heightMapFilterDeformationSize; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseSeed; // 0x144
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_noiseOctaves; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noisePersistence; // 0x14C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseFrequency; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseLacunarity; // 0x154
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseAmplitude; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseRidgeOffset; // 0x15C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseWarp0; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseWarp; // 0x164
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseDamp0; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseDamp; // 0x16C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseDampScale; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseOffsetX; // 0x174
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseOffsetZ; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_noiseDisplacement; // 0x17C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_noiseCellDistanceFunction; // 0x180
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_noiseCellType; // 0x184
		private ComputeShader m_noiseComputeShader; // 0x188
		private int m_noiseSimplexKernel; // 0x190
		private int m_noiseBillowKernel; // 0x194
		private int m_noiseRidgedKernel; // 0x198
		private int m_noiseDerivedIQKernel; // 0x19C
		private int m_noiseDerivedSwissKernel; // 0x1A0
		private int m_noiseDerivedJordanKernel; // 0x1A4
		private int m_noiseCellNoiseKernel; // 0x1A8
		private int m_noiseMultiFractalKernel; // 0x1AC
		private int m_thermalErosionKernel; // 0x1B0
		private int m_hydraulicErosionKernel; // 0x1B4
		private ComputeShader m_stampComputeShader; // 0x1B8
		private ComputeShader m_erosionComputeShader; // 0x1C0
		private StampWorkItem[,] m_stampWorkItems; // 0x1C8
		[NonSerialized]
		private int m_jobsToCompute; // 0x1D0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_useCompute; // 0x1D4
		public string m_stampID; // 0x1D8
		public string m_resourcesPath; // 0x1E0
		public float m_fitToTerrainYScale; // 0x1E8
		private GaiaWorldManager m_undoMgr; // 0x1F0
		private GaiaWorldManager m_redoMgr; // 0x1F8
		private bool m_imageMaskInvert; // 0x200
	
		// Properties
		public bool EditorShowHelpers { get; set; } // 0x0000000185EC5F30-0x0000000185EC5F90 0x0000000185EC8A00-0x0000000185EC8A60
		public bool EditorShowFilters { get; set; } // 0x0000000185EC5ED0-0x0000000185EC5F30 0x0000000185EC89A0-0x0000000185EC8A00
		public bool EditorShowSeaLevel { /* [XID] */ /* 0x0000000189A477E0-0x0000000189A47800 */ get => default; /* [XID] */ /* 0x00000001899FD510-0x00000001899FD530 */ set {} } // 0x0000000185EC6030-0x0000000185EC60D0 0x0000000185EC8BA0-0x0000000185EC8C50
		public float EditorSeaLevel { /* [XID] */ /* 0x0000000189A38B90-0x0000000189A38BB0 */ get => default; /* [XID] */ /* 0x00000001897C1050-0x00000001897C1070 */ set {} } // 0x0000000185EC5E20-0x0000000185EC5ED0 0x0000000185EC88F0-0x0000000185EC89A0
		public bool EditorShowPreviewMesh { /* [XID] */ /* 0x00000001897C8940-0x00000001897C8960 */ get => default; /* [XID] */ /* 0x00000001897D0010-0x00000001897D0030 */ set {} } // 0x0000000185EC5F90-0x0000000185EC6030 0x0000000185EC8A60-0x0000000185EC8BA0
		public UnityEngine.Material EditorStampPreviewMaterial { /* [XID] */ /* 0x00000001897D78F0-0x00000001897D7910 */ get => default; /* [XID] */ /* 0x00000001897DEDD0-0x00000001897DEDF0 */ set {} } // 0x0000000185EC60D0-0x0000000185EC6170 0x0000000185EC8C50-0x0000000185EC8D90
		public bool FittedToTerrain { /* [XID] */ /* 0x0000000189A4EFD0-0x0000000189A4EFF0 */ get => default; /* [XID] */ /* 0x00000001897EE250-0x00000001897EE270 */ set {} } // 0x0000000185EC6170-0x0000000185EC6210 0x0000000185EC8D90-0x0000000185EC8E50
		public bool LiveUpdate { /* [XID] */ /* 0x0000000189A29A40-0x0000000189A29A60 */ get => default; /* [XID] */ /* 0x0000000189A30F00-0x0000000189A30F20 */ set {} } // 0x0000000185EC68C0-0x0000000185EC6960 0x0000000185EC98C0-0x0000000185EC99A0
		public GaiaConstants.FeatureSource StampType { /* [XID] */ /* 0x0000000189804890-0x00000001898048B0 */ get => default; /* [XID] */ /* 0x000000018980BDB0-0x000000018980BDD0 */ set {} } // 0x0000000185EC80A0-0x0000000185EC8140 0x0000000185ECB320-0x0000000185ECB620
		public GaiaConstants.FeatureOperation Operation { /* [XID] */ /* 0x0000000189B32EF0-0x0000000189B32F10 */ get => default; /* [XID] */ /* 0x000000018981B0A0-0x000000018981B0C0 */ set {} } // 0x0000000185EC7580-0x0000000185EC7620 0x0000000185ECA7F0-0x0000000185ECA8B0
		public GaiaConstants.FeatureOperationType OperationType { /* [XID] */ /* 0x0000000189822720-0x0000000189822740 */ get => default; /* [XID] */ /* 0x0000000189B64AF0-0x0000000189B64B10 */ set {} } // 0x0000000185EC74E0-0x0000000185EC7580 0x0000000185ECA740-0x0000000185ECA7F0
		public Texture2D PreviewImage { /* [XID] */ /* 0x0000000189B6BF00-0x0000000189B6BF20 */ get => default; /* [XID] */ /* 0x0000000189838B40-0x0000000189838B60 */ set {} } // 0x0000000185EC76D0-0x0000000185EC7770 0x0000000185ECA9A0-0x0000000185ECAA70
		public Vector3 StampLocation { /* [XID] */ /* 0x0000000189840080-0x00000001898400A0 */ get => default; /* [XID] */ /* 0x0000000189AEBD30-0x0000000189AEBD50 */ set {} } // 0x0000000185EC79B0-0x0000000185EC7A90 0x0000000185ECAC10-0x0000000185ECAD40
		public float StampRotation { /* [XID] */ /* 0x0000000189603240-0x0000000189603260 */ get => default; /* [XID] */ /* 0x0000000189855F50-0x0000000189855F70 */ set {} } // 0x0000000185EC7D30-0x0000000185EC7DE0 0x0000000185ECAFD0-0x0000000185ECB0B0
		public float StampVerticalScale { /* [XID] */ /* 0x00000001898422A0-0x00000001898422C0 */ get => default; /* [XID] */ /* 0x0000000189864C10-0x0000000189864C30 */ set {} } // 0x0000000185EC8140-0x0000000185EC81F0 0x0000000185ECB620-0x0000000185ECB700
		public float StampHorizontalScale { /* [XID] */ /* 0x000000018986C1C0-0x000000018986C1E0 */ get => default; /* [XID] */ /* 0x0000000189AE68C0-0x0000000189AE68E0 */ set {} } // 0x0000000185EC7900-0x0000000185EC79B0 0x0000000185ECAB30-0x0000000185ECAC10
		public Vector3 StampSizeTU { /* [XID] */ /* 0x000000018987B210-0x000000018987B230 */ get => default; /* [XID] */ /* 0x00000001898822C0-0x00000001898822E0 */ set {} } // 0x0000000185EC7FC0-0x0000000185EC80A0 0x0000000185ECB0B0-0x0000000185ECB320
		public Bounds StampBoundsWU { /* [XID] */ /* 0x0000000189984530-0x0000000189984550 */ get => default; } // 0x0000000185EC7810-0x0000000185EC7900 
		public Bounds StampScaledBoundsWU { /* [XID] */ /* 0x0000000189A02750-0x0000000189A02770 */ get => default; } // 0x0000000185EC7DE0-0x0000000185EC7ED0 
		public Bounds StampScaledRotatedBoundsWU { /* [XID] */ /* 0x0000000189898400-0x0000000189898420 */ get => default; } // 0x0000000185EC7ED0-0x0000000185EC7FC0 
		public GaiaConstants.GaiaHeightmapResolution StampResolution { /* [XID] */ /* 0x000000018989F650-0x000000018989F670 */ get => default; /* [XID] */ /* 0x0000000189A3CFB0-0x0000000189A3CFD0 */ set {} } // 0x0000000185EC7C90-0x0000000185EC7D30 0x0000000185ECAE80-0x0000000185ECAFD0
		public int StampResolutionPx { /* [XID] */ /* 0x00000001898AEBD0-0x00000001898AEBF0 */ get => default; /* [XID] */ /* 0x00000001898B5DF0-0x00000001898B5E10 */ set {} } // 0x0000000185EC7BF0-0x0000000185EC7C90 0x0000000185ECAD40-0x0000000185ECAE80
		public GaiaConstants.GaiaResolution HeightmapResolution { /* [XID] */ /* 0x00000001898BD780-0x00000001898BD7A0 */ get => default; /* [XID] */ /* 0x0000000189716360-0x0000000189716380 */ set {} } // 0x0000000185EC6580-0x0000000185EC6620 0x0000000185EC9270-0x0000000185EC95A0
		public GaiaStamperExtension StamperExtension { /* [XID] */ /* 0x00000001898CC4C0-0x00000001898CC4E0 */ get => default; /* [XID] */ /* 0x000000018984A310-0x000000018984A330 */ set {} } // 0x0000000185EC81F0-0x0000000185EC82A0 0x0000000185ECB700-0x0000000185ECB7B0
		public GaiaTexturer GaiaTexturer { /* [XID] */ /* 0x00000001898DB710-0x00000001898DB730 */ get => default; /* [XID] */ /* 0x00000001898E3380-0x00000001898E33A0 */ set {} } // 0x0000000185EC6210-0x0000000185EC62C0 0x0000000185EC8E50-0x0000000185EC8F00
		public float PowerFilter { /* [XID] */ /* 0x00000001898F2700-0x00000001898F2720 */ get => default; /* [XID] */ /* 0x000000018978E520-0x000000018978E540 */ set {} } // 0x0000000185EC7620-0x0000000185EC76D0 0x0000000185ECA8B0-0x0000000185ECA9A0
		public AnimationCurve DistanceFilter { /* [XID] */ /* 0x0000000189901950-0x0000000189901970 */ get => default; /* [XID] */ /* 0x000000018979DF10-0x000000018979DF30 */ set {} } // 0x0000000185EC5D70-0x0000000185EC5E20 0x0000000185EC8820-0x0000000185EC88F0
		public int TerraceFilterCount { /* [XID] */ /* 0x0000000189910560-0x0000000189910580 */ get => default; /* [XID] */ /* 0x0000000189B19DA0-0x0000000189B19DC0 */ set {} } // 0x0000000185EC82A0-0x0000000185EC8340 0x0000000185ECB7B0-0x0000000185ECBAE0
		public List<GaiaTerraceItem> TerraceFilters { /* [XID] */ /* 0x000000018969C770-0x000000018969C790 */ get => default; /* [XID] */ /* 0x0000000189A747C0-0x0000000189A747E0 */ set {} } // 0x0000000185EC8340-0x0000000185EC83F0 0x0000000185ECBAE0-0x0000000185ECBCE0
		public int SmoothFilter { /* [XID] */ /* 0x0000000189B73810-0x0000000189B73830 */ get => default; /* [XID] */ /* 0x0000000189B7AC50-0x0000000189B7AC70 */ set {} } // 0x0000000185EC7770-0x0000000185EC7810 0x0000000185ECAA70-0x0000000185ECAB30
		public float ContrastFilter { /* [XID] */ /* 0x0000000189702E30-0x0000000189702E50 */ get => default; /* [XID] */ /* 0x0000000189944D50-0x0000000189944D70 */ set {} } // 0x0000000185EC5CC0-0x0000000185EC5D70 0x0000000185EC8750-0x0000000185EC8820
		public int ThermalErosionFilterIterations { /* [XID] */ /* 0x000000018994C4A0-0x000000018994C4C0 */ get => default; /* [XID] */ /* 0x0000000189850CC0-0x0000000189850CE0 */ set {} } // 0x0000000185EC84A0-0x0000000185EC8540 0x0000000185ECBDB0-0x0000000185ECBE70
		public float ThermalErosionFilterTalus { /* [XID] */ /* 0x00000001897430C0-0x00000001897430E0 */ get => default; /* [XID] */ /* 0x0000000189751CB0-0x0000000189751CD0 */ set {} } // 0x0000000185EC85F0-0x0000000185EC86A0 0x0000000185ECBF40-0x0000000185ECC010
		public float ThermalErosionFilterGrowthPower { /* [XID] */ /* 0x00000001896A30C0-0x00000001896A30E0 */ get => default; /* [XID] */ /* 0x0000000189971F90-0x0000000189971FB0 */ set {} } // 0x0000000185EC83F0-0x0000000185EC84A0 0x0000000185ECBCE0-0x0000000185ECBDB0
		public float ThermalErosionFilterSinkPower { /* [XID] */ /* 0x0000000189733E90-0x0000000189733EB0 */ get => default; /* [XID] */ /* 0x00000001896B8EB0-0x00000001896B8ED0 */ set {} } // 0x0000000185EC8540-0x0000000185EC85F0 0x0000000185ECBE70-0x0000000185ECBF40
		public int HydralicErosionFilterIterations { /* [XID] */ /* 0x000000018969B9F0-0x000000018969BA10 */ get => default; /* [XID] */ /* 0x000000018998FE70-0x000000018998FE90 */ set {} } // 0x0000000185EC6620-0x0000000185EC66C0 0x0000000185EC95A0-0x0000000185EC9660
		public int HyrdraulicErosionFilterRainFrequency { /* [XID] */ /* 0x0000000189AC6090-0x0000000189AC60B0 */ get => default; /* [XID] */ /* 0x0000000189B82570-0x0000000189B82590 */ set {} } // 0x0000000185EC6770-0x0000000185EC6810 0x0000000185EC9730-0x0000000185EC97F0
		public float HydraulicErosionFilterFilterSedimentDisolveRate { /* [XID] */ /* 0x00000001896D72C0-0x00000001896D72E0 */ get => default; /* [XID] */ /* 0x00000001899AE540-0x00000001899AE560 */ set {} } // 0x0000000185EC66C0-0x0000000185EC6770 0x0000000185EC9660-0x0000000185EC9730
		public Texture2D HeightMapFilterImage { /* [XID] */ /* 0x0000000189B89D50-0x0000000189B89D70 */ get => default; /* [XID] */ /* 0x00000001899BD4B0-0x00000001899BD4D0 */ set {} } // 0x0000000185EC6420-0x0000000185EC64D0 0x0000000185EC90A0-0x0000000185EC91A0
		public float HeightMapFilterImageImageStrength { /* [XID] */ /* 0x00000001899C4ED0-0x00000001899C4EF0 */ get => default; /* [XID] */ /* 0x00000001899CC450-0x00000001899CC470 */ set {} } // 0x0000000185EC6370-0x0000000185EC6420 0x0000000185EC8FD0-0x0000000185EC90A0
		public float HeightMapFilterTiling { /* [XID] */ /* 0x00000001899D3B70-0x00000001899D3B90 */ get => default; /* [XID] */ /* 0x00000001899DB140-0x00000001899DB160 */ set {} } // 0x0000000185EC64D0-0x0000000185EC6580 0x0000000185EC91A0-0x0000000185EC9270
		public float HeightMapFilterDeformationSize { /* [XID] */ /* 0x00000001899E28F0-0x00000001899E2910 */ get => default; /* [XID] */ /* 0x0000000189B985B0-0x0000000189B985D0 */ set {} } // 0x0000000185EC62C0-0x0000000185EC6370 0x0000000185EC8F00-0x0000000185EC8FD0
		public float NoiseSeed { /* [XID] */ /* 0x0000000189737EB0-0x0000000189737ED0 */ get => default; /* [XID] */ /* 0x00000001899F8FF0-0x00000001899F9010 */ set {} } // 0x0000000185EC72D0-0x0000000185EC7380 0x0000000185ECA4D0-0x0000000185ECA5A0
		public int NoiseOctaves { /* [XID] */ /* 0x0000000189A005A0-0x0000000189A005C0 */ get => default; /* [XID] */ /* 0x0000000189A07CF0-0x0000000189A07D10 */ set {} } // 0x0000000185EC6F70-0x0000000185EC7010 0x0000000185ECA0D0-0x0000000185ECA190
		public float NoisePersistance { /* [XID] */ /* 0x00000001899D8AF0-0x00000001899D8B10 */ get => default; /* [XID] */ /* 0x00000001899E0160-0x00000001899E0180 */ set {} } // 0x0000000185EC7170-0x0000000185EC7220 0x0000000185ECA330-0x0000000185ECA400
		public float NoiseFrequency { /* [XID] */ /* 0x0000000189642C80-0x0000000189642CA0 */ get => default; /* [XID] */ /* 0x0000000189A254F0-0x0000000189A25510 */ set {} } // 0x0000000185EC6E10-0x0000000185EC6EC0 0x0000000185EC9F30-0x0000000185ECA000
		public float NoiseLacunarity { /* [XID] */ /* 0x000000018964A2B0-0x000000018964A2D0 */ get => default; /* [XID] */ /* 0x000000018989A6F0-0x000000018989A710 */ set {} } // 0x0000000185EC6EC0-0x0000000185EC6F70 0x0000000185ECA000-0x0000000185ECA0D0
		public float NoiseAmplitude { /* [XID] */ /* 0x000000018982D4E0-0x000000018982D500 */ get => default; /* [XID] */ /* 0x0000000189656370-0x0000000189656390 */ set {} } // 0x0000000185EC6960-0x0000000185EC6A10 0x0000000185EC99A0-0x0000000185EC9A70
		public float NoiseRidgeOffset { /* [XID] */ /* 0x0000000189A4A910-0x0000000189A4A930 */ get => default; /* [XID] */ /* 0x0000000189A51F80-0x0000000189A51FA0 */ set {} } // 0x0000000185EC7220-0x0000000185EC72D0 0x0000000185ECA400-0x0000000185ECA4D0
		public float NoiseWarp0 { /* [XID] */ /* 0x0000000189A59970-0x0000000189A59990 */ get => default; /* [XID] */ /* 0x000000018974AC20-0x000000018974AC40 */ set {} } // 0x0000000185EC7380-0x0000000185EC7430 0x0000000185ECA5A0-0x0000000185ECA670
		public float NoiseWarp { /* [XID] */ /* 0x0000000189A69060-0x0000000189A69080 */ get => default; /* [XID] */ /* 0x0000000189A70370-0x0000000189A70390 */ set {} } // 0x0000000185EC7430-0x0000000185EC74E0 0x0000000185ECA670-0x0000000185ECA740
		public float NoiseDamp0 { /* [XID] */ /* 0x0000000189A77BE0-0x0000000189A77C00 */ get => default; /* [XID] */ /* 0x0000000189A7F140-0x0000000189A7F160 */ set {} } // 0x0000000185EC6B50-0x0000000185EC6C00 0x0000000185EC9BF0-0x0000000185EC9CC0
		public float NoiseDamp { /* [XID] */ /* 0x0000000189A86CC0-0x0000000189A86CE0 */ get => default; /* [XID] */ /* 0x0000000189A0CBE0-0x0000000189A0CC00 */ set {} } // 0x0000000185EC6CB0-0x0000000185EC6D60 0x0000000185EC9D90-0x0000000185EC9E60
		public float NoiseDampScale { /* [XID] */ /* 0x0000000189A95C50-0x0000000189A95C70 */ get => default; /* [XID] */ /* 0x0000000189A9D3E0-0x0000000189A9D400 */ set {} } // 0x0000000185EC6C00-0x0000000185EC6CB0 0x0000000185EC9CC0-0x0000000185EC9D90
		public float NoiseOffsetX { /* [XID] */ /* 0x0000000189BCBDC0-0x0000000189BCBDE0 */ get => default; /* [XID] */ /* 0x0000000189AAC290-0x0000000189AAC2B0 */ set {} } // 0x0000000185EC7010-0x0000000185EC70C0 0x0000000185ECA190-0x0000000185ECA260
		public float NoiseOffsetZ { /* [XID] */ /* 0x0000000189937E70-0x0000000189937E90 */ get => default; /* [XID] */ /* 0x0000000189ABB7F0-0x0000000189ABB810 */ set {} } // 0x0000000185EC70C0-0x0000000185EC7170 0x0000000185ECA260-0x0000000185ECA330
		public float NoiseDisplacement { /* [XID] */ /* 0x0000000189AC2F50-0x0000000189AC2F70 */ get => default; /* [XID] */ /* 0x0000000189ACA6B0-0x0000000189ACA6D0 */ set {} } // 0x0000000185EC6D60-0x0000000185EC6E10 0x0000000185EC9E60-0x0000000185EC9F30
		public int NoiseCellDistanceFunction { /* [XID] */ /* 0x0000000189B9FAA0-0x0000000189B9FAC0 */ get => default; /* [XID] */ /* 0x000000018973FA00-0x000000018973FA20 */ set {} } // 0x0000000185EC6A10-0x0000000185EC6AB0 0x0000000185EC9A70-0x0000000185EC9B30
		public int NoiseCellType { /* [XID] */ /* 0x0000000189AE16C0-0x0000000189AE16E0 */ get => default; /* [XID] */ /* 0x0000000189AE8BB0-0x0000000189AE8BD0 */ set {} } // 0x0000000185EC6AB0-0x0000000185EC6B50 0x0000000185EC9B30-0x0000000185EC9BF0
		public float StampProgress { /* [XID] */ /* 0x00000001895FDC80-0x00000001895FDCA0 */ get => default; } // 0x0000000185EC7A90-0x0000000185EC7BF0 
		public bool UseCompute { /* [XID] */ /* 0x000000018960CE40-0x000000018960CE60 */ get => default; /* [XID] */ /* 0x0000000189AFF5D0-0x0000000189AFF5F0 */ set {} } // 0x0000000185EC86A0-0x0000000185EC8750 0x0000000185ECC010-0x0000000185ECC0C0
		public bool InvertImageMask { /* [XID] */ /* 0x0000000189769090-0x00000001897690B0 */ get => default; /* [XID] */ /* 0x0000000189B58F20-0x0000000189B58F40 */ set {} } // 0x0000000185EC6810-0x0000000185EC68C0 0x0000000185EC97F0-0x0000000185EC98C0
	
		// Constructors
		public GaiaStamper() {} // 0x0000000185EC5720-0x0000000185EC5CC0
	
		// Methods
		// [XID] // 0x0000000189885100-0x0000000189885120
		public bool IsStampLoaded() => default; // 0x0000000185EC2DE0-0x0000000185EC2EA0
		// [XID] // 0x00000001898B2370-0x00000001898B2390
		private void LoadStamp(Texture2D previewImage) {} // 0x0000000185EC2EA0-0x0000000185EC3340
		// [XID] // 0x0000000189B0E5B0-0x0000000189B0E5D0
		private void UpdateStamp() {} // 0x0000000185EC3EA0-0x0000000185EC5720
		// [XID] // 0x00000001899C7050-0x00000001899C7070
		public void InitialiseFromTerrain(ComputeShader stampComputeShader, ComputeShader noiseComputeShader, ComputeShader erosionComputeShader, UnityEngine.Material stamperMaterial) {} // 0x0000000185EC1AF0-0x0000000185EC2110
		// [XID] // 0x0000000189B1D180-0x0000000189B1D1A0
		public void InitiateStampPreview() {} // 0x0000000185EC26E0-0x0000000185EC2B70
		// [XID] // 0x0000000189B24770-0x0000000189B24790
		public void AddToSession(GaiaOperation.OperationType opType, string opName) {} // 0x0000000185EBF950-0x0000000185EBFC70
		// [XID] // 0x0000000189B2BBC0-0x0000000189B2BBE0
		public string SerialiseJson() => default; // 0x0000000185EC3A00-0x0000000185EC3AB0
		// [XID] // 0x0000000189B330B0-0x0000000189B330D0
		public void OnRestamp() {} // 0x0000000185EC3620-0x0000000185EC36C0
		// [XID] // 0x0000000189B3AC50-0x0000000189B3AC70
		public void InitiateStampApply() {} // 0x0000000185EC2110-0x0000000185EC26E0
		// [XID] // 0x0000000189B42390-0x0000000189B423B0
		public void CancelStampApply() {} // 0x0000000185EC0420-0x0000000185EC0570
		// [XID] // 0x0000000189B3F620-0x0000000189B3F640
		public void FitToTerrain() {} // 0x0000000185EC1030-0x0000000185EC13C0
		// [XID] // 0x0000000189777F50-0x0000000189777F70
		public bool CanUndo() => default; // 0x0000000185EC0370-0x0000000185EC0420
		// [XID] // 0x0000000189B67D50-0x0000000189B67D70
		public void CreateUndo() {} // 0x0000000185EC0750-0x0000000185EC0850
		// [XID] // 0x0000000189BBD390-0x0000000189BBD3B0
		public void Undo() {} // 0x0000000185EC3D60-0x0000000185EC3EA0
		// [XID] // 0x0000000189B76720-0x0000000189B76740
		public bool CanRedo() => default; // 0x0000000185EC02C0-0x0000000185EC0370
		// [XID] // 0x0000000189B7DCE0-0x0000000189B7DD00
		public void Redo() {} // 0x0000000185EC36C0-0x0000000185EC37A0
		// [XID] // 0x0000000189B85A00-0x0000000189B85A20
		public void OnApplyStampPre() {} // 0x0000000185EC3410-0x0000000185EC34E0
		// [XID] // 0x0000000189B8C890-0x0000000189B8C8B0
		public void OnApplyStampPost() {} // 0x0000000185EC3340-0x0000000185EC3410
		// [XID] // 0x0000000189772A80-0x0000000189772AA0
		public void FlattenTerrain() {} // 0x0000000185EC13C0-0x0000000185EC14B0
		// [XID] // 0x0000000189B9B840-0x0000000189B9B860
		public void SmoothTerrain() {} // 0x0000000185EC3AB0-0x0000000185EC3BA0
		// [XID] // 0x0000000189A22650-0x0000000189A22670
		public void ClearTrees() {} // 0x0000000185EC0660-0x0000000185EC0750
		// [XID] // 0x0000000189BAA300-0x0000000189BAA320
		public void ClearDetails() {} // 0x0000000185EC0570-0x0000000185EC0660
		// [XID] // 0x0000000189B0D040-0x0000000189B0D060
		public void StitchTiles() {} // 0x0000000185EC3C40-0x0000000185EC3D60
		// [XID] // 0x0000000189BB8BA0-0x0000000189BB8BC0
		private void CalculateStampBounds() {} // 0x0000000185EBFC70-0x0000000185EC02C0
		// [XID] // 0x0000000189BC0560-0x0000000189BC0580
		private void GeneratePreviewMesh() {} // 0x0000000185EC14B0-0x0000000185EC1AF0
		// [XID] // 0x000000018995FAF0-0x000000018995FB10
		private void Start() {} // 0x0000000185EC3BA0-0x0000000185EC3C40
		// [XID] // 0x000000018990A490-0x000000018990A4B0
		private void OnDrawGizmosSelected() {} // 0x0000000185EC34E0-0x0000000185EC3580
		// [XID] // 0x0000000189BD6F70-0x0000000189BD6F90
		private void OnDrawGizmos() {} // 0x0000000185EC3580-0x0000000185EC3620
		// [XID] // 0x00000001899FDBF0-0x00000001899FDC10
		private void DrawGizmos(bool isSelected) {} // 0x0000000185EC0850-0x0000000185EC1030
		// [XID] // 0x00000001895EB6F0-0x00000001895EB710
		private bool IsDifferentCurve(AnimationCurve source, AnimationCurve target) => default; // 0x0000000185EC2B70-0x0000000185EC2DE0
		// [XID] // 0x000000018966BC70-0x000000018966BC90
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, float angle) => default; // 0x0000000185EC37A0-0x0000000185EC3A00
	}
}
