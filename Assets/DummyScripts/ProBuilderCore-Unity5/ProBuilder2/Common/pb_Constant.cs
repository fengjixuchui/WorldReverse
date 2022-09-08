/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public static class pb_Constant // TypeDefIndex: 3369
	{
		// Fields
		public const string PRODUCT_NAME = "ProBuilder"; // Metadata: 0x00AC332E
		public static readonly HideFlags EDITOR_OBJECT_HIDE_FLAGS; // 0x00
		public const float MAX_POINT_DISTANCE_FROM_CONTROL = 20f; // Metadata: 0x00AC333C
		private static UnityEngine.Material _defaultMaterial; // 0x08
		private static UnityEngine.Material _facePickerMaterial; // 0x10
		private static UnityEngine.Material _vertexPickerMaterial; // 0x18
		private static Shader _selectionPickerShader; // 0x20
		private static UnityEngine.Material _UnityDefaultDiffuse; // 0x28
		private static UnityEngine.Material _UnlitVertexColorMaterial; // 0x30
		public const char DEGREE_SYMBOL = '\x00b0'; // Metadata: 0x00AC3340
		public const char CMD_SUPER = '\x2318'; // Metadata: 0x00AC3342
		public const char CMD_SHIFT = '\x21e7'; // Metadata: 0x00AC3344
		public const char CMD_OPTION = '\x2325'; // Metadata: 0x00AC3346
		public const char CMD_ALT = '\x2387'; // Metadata: 0x00AC3348
		public const char CMD_DELETE = '\x232b'; // Metadata: 0x00AC334A
		public const string pbDefaultEditLevel = "pbDefaultEditLevel"; // Metadata: 0x00AC334C
		public const string pbDefaultSelectionMode = "pbDefaultSelectionMode"; // Metadata: 0x00AC3362
		public const string pbHandleAlignment = "pbHandleAlignment"; // Metadata: 0x00AC337C
		public const string pbVertexColorTool = "pbVertexColorTool"; // Metadata: 0x00AC3391
		public const string pbToolbarLocation = "pbToolbarLocation"; // Metadata: 0x00AC33A6
		public const string pbDefaultEntity = "pbDefaultEntity"; // Metadata: 0x00AC33BB
		public const string pbExtrudeMethod = "pbExtrudeMethod"; // Metadata: 0x00AC33CE
		public const string pbDefaultFaceColor = "pbDefaultFaceColor"; // Metadata: 0x00AC33E1
		public const string pbDefaultEdgeColor = "pbDefaultEdgeColor"; // Metadata: 0x00AC33F7
		public const string pbDefaultSelectedVertexColor = "pbDefaultSelectedVertexColor"; // Metadata: 0x00AC340D
		public const string pbDefaultVertexColor = "pbDefaultVertexColor"; // Metadata: 0x00AC342D
		public const string pbDefaultOpenInDockableWindow = "pbDefaultOpenInDockableWindow"; // Metadata: 0x00AC3445
		public const string pbEditorPrefVersion = "pbEditorPrefVersion"; // Metadata: 0x00AC3466
		public const string pbEditorShortcutsVersion = "pbEditorShortcutsVersion"; // Metadata: 0x00AC347D
		public const string pbDefaultCollider = "pbDefaultCollider"; // Metadata: 0x00AC3499
		public const string pbForceConvex = "pbForceConvex"; // Metadata: 0x00AC34AE
		public const string pbVertexColorPrefs = "pbVertexColorPrefs"; // Metadata: 0x00AC34BF
		public const string pbShowEditorNotifications = "pbShowEditorNotifications"; // Metadata: 0x00AC34D5
		public const string pbDragCheckLimit = "pbDragCheckLimit"; // Metadata: 0x00AC34F2
		public const string pbForceVertexPivot = "pbForceVertexPivot"; // Metadata: 0x00AC3506
		public const string pbForceGridPivot = "pbForceGridPivot"; // Metadata: 0x00AC351C
		public const string pbManifoldEdgeExtrusion = "pbManifoldEdgeExtrusion"; // Metadata: 0x00AC3530
		public const string pbPerimeterEdgeBridgeOnly = "pbPerimeterEdgeBridgeOnly"; // Metadata: 0x00AC354B
		public const string pbPBOSelectionOnly = "pbPBOSelectionOnly"; // Metadata: 0x00AC3568
		public const string pbCloseShapeWindow = "pbCloseShapeWindow"; // Metadata: 0x00AC357E
		public const string pbUVEditorFloating = "pbUVEditorFloating"; // Metadata: 0x00AC3594
		public const string pbUVMaterialPreview = "pbUVMaterialPreview"; // Metadata: 0x00AC35AA
		public const string pbShowSceneToolbar = "pbShowSceneToolbar"; // Metadata: 0x00AC35C1
		public const string pbNormalizeUVsOnPlanarProjection = "pbNormalizeUVsOnPlanarProjection"; // Metadata: 0x00AC35D7
		public const string pbStripProBuilderOnBuild = "pbStripProBuilderOnBuild"; // Metadata: 0x00AC35FB
		public const string pbDisableAutoUV2Generation = "pbDisableAutoUV2Generation"; // Metadata: 0x00AC3617
		public const string pbShowSceneInfo = "pbShowSceneInfo"; // Metadata: 0x00AC3635
		public const string pbEnableBackfaceSelection = "pbEnableBackfaceSelection"; // Metadata: 0x00AC3648
		public const string pbVertexPaletteDockable = "pbVertexPaletteDockable"; // Metadata: 0x00AC3665
		public const string pbExtrudeAsGroup = "pbExtrudeAsGroup"; // Metadata: 0x00AC3680
		public const string pbUniqueModeShortcuts = "pbUniqueModeShortcuts"; // Metadata: 0x00AC3694
		public const string pbMaterialEditorFloating = "pbMaterialEditorFloating"; // Metadata: 0x00AC36AD
		public const string pbShapeWindowFloating = "pbShapeWindowFloating"; // Metadata: 0x00AC36C9
		public const string pbIconGUI = "pbIconGUI"; // Metadata: 0x00AC36E2
		public const string pbShiftOnlyTooltips = "pbShiftOnlyTooltips"; // Metadata: 0x00AC36EF
		public const string pbDrawAxisLines = "pbDrawAxisLines"; // Metadata: 0x00AC3706
		public const string pbCollapseVertexToFirst = "pbCollapseVertexToFirst"; // Metadata: 0x00AC3719
		public const string pbMeshesAreAssets = "pbMeshesAreAssets"; // Metadata: 0x00AC3734
		public const string pbElementSelectIsHamFisted = "pbElementSelectIsHamFisted"; // Metadata: 0x00AC3749
		public const string pbFillHoleSelectsEntirePath = "pbFillHoleSelectsEntirePath"; // Metadata: 0x00AC3767
		public const string pbDetachToNewObject = "pbDetachToNewObject"; // Metadata: 0x00AC3786
		[Obsolete] // 0x0000000189B9B940-0x0000000189B9B970
		public const string pbPreserveFaces = "pbPreserveFaces"; // Metadata: 0x00AC379D
		public const string pbDragSelectWholeElement = "pbDragSelectWholeElement"; // Metadata: 0x00AC37B0
		public const string pbDragSelectMode = "pbDragSelectMode"; // Metadata: 0x00AC37CC
		public const string pbShadowCastingMode = "pbShadowCastingMode"; // Metadata: 0x00AC37E0
		public const string pbEnableExperimental = "pbEnableExperimental"; // Metadata: 0x00AC37F7
		public const string pbCheckForProBuilderUpdates = "pbCheckForProBuilderUpdates"; // Metadata: 0x00AC380F
		public const string pbManageLightmappingStaticFlag = "pbManageLightmappingStaticFlag"; // Metadata: 0x00AC382E
		public const string pbVertexHandleSize = "pbVertexHandleSize"; // Metadata: 0x00AC3850
		public const string pbUVGridSnapValue = "pbUVGridSnapValue"; // Metadata: 0x00AC3866
		public const string pbUVWeldDistance = "pbUVWeldDistance"; // Metadata: 0x00AC387B
		public const string pbWeldDistance = "pbWeldDistance"; // Metadata: 0x00AC388F
		public const string pbExtrudeDistance = "pbExtrudeDistance"; // Metadata: 0x00AC38A1
		public const string pbBevelAmount = "pbBevelAmount"; // Metadata: 0x00AC38B6
		public const string pbEdgeSubdivisions = "pbEdgeSubdivisions"; // Metadata: 0x00AC38C7
		public const string pbDefaultShortcuts = "pbDefaultShortcuts"; // Metadata: 0x00AC38DD
		public const string pbDefaultMaterial = "pbDefaultMaterial"; // Metadata: 0x00AC38F3
		public const string pbCurrentMaterialPalette = "pbCurrentMaterialPalette"; // Metadata: 0x00AC3908
		public const string pbGrowSelectionUsingAngle = "pbGrowSelectionUsingAngle"; // Metadata: 0x00AC3924
		public const string pbGrowSelectionAngle = "pbGrowSelectionAngle"; // Metadata: 0x00AC3941
		public const string pbGrowSelectionAngleIterative = "pbGrowSelectionAngleIterative"; // Metadata: 0x00AC3959
		public const string pbShowDetail = "pbShowDetail"; // Metadata: 0x00AC397A
		public const string pbShowOccluder = "pbShowOccluder"; // Metadata: 0x00AC398A
		public const string pbShowMover = "pbShowMover"; // Metadata: 0x00AC399C
		public const string pbShowCollider = "pbShowCollider"; // Metadata: 0x00AC39AB
		public const string pbShowTrigger = "pbShowTrigger"; // Metadata: 0x00AC39BD
		public const string pbShowNoDraw = "pbShowNoDraw"; // Metadata: 0x00AC39CE
		public static readonly Rect RectZero; // 0x38
		public static Color ProBuilderBlue; // 0x48
		public static Color ProBuilderLightGray; // 0x58
		public static Color ProBuilderDarkGray; // 0x68
		public const int MENU_ABOUT = 0; // Metadata: 0x00AC39DE
		public const int MENU_EDITOR = 100; // Metadata: 0x00AC39E2
		public const int MENU_SELECTION = 200; // Metadata: 0x00AC39E6
		public const int MENU_GEOMETRY = 200; // Metadata: 0x00AC39EA
		public const int MENU_ACTIONS = 300; // Metadata: 0x00AC39EE
		public const int MENU_MATERIAL_COLORS = 400; // Metadata: 0x00AC39F2
		public const int MENU_VERTEX_COLORS = 400; // Metadata: 0x00AC39F6
		public const int MENU_REPAIR = 600; // Metadata: 0x00AC39FA
		public const int MENU_MISC = 600; // Metadata: 0x00AC39FE
		public const int MENU_EXPORT = 800; // Metadata: 0x00AC3A02
		public static Vector3[] VERTICES_CUBE; // 0x78
		public static int[] TRIANGLES_CUBE; // 0x80
		public const int MAX_VERTEX_COUNT = 65000; // Metadata: 0x00AC3A06
	
		// Properties
		public static UnityEngine.Material DefaultMaterial { get; } // 0x0000000187727340-0x0000000187727550 
		public static UnityEngine.Material FacePickerMaterial { get; } // 0x0000000187727550-0x00000001877277A0 
		public static UnityEngine.Material VertexPickerMaterial { get; } // 0x0000000187727DF0-0x0000000187728040 
		public static Shader SelectionPickerShader { get; } // 0x0000000187727890-0x00000001877279D0 
		public static UnityEngine.Material TriggerMaterial { get; } // 0x00000001877279D0-0x0000000187727AC0 
		public static UnityEngine.Material ColliderMaterial { get; } // 0x0000000187727250-0x0000000187727340 
		public static UnityEngine.Material NoDrawMaterial { get; } // 0x00000001877277A0-0x0000000187727890 
		public static UnityEngine.Material UnityDefaultDiffuse { get; } // 0x0000000187727AC0-0x0000000187727C60 
		public static UnityEngine.Material UnlitVertexColor { get; } // 0x0000000187727C60-0x0000000187727DF0 
	
		// Constructors
		static pb_Constant() {} // 0x0000000187726D80-0x0000000187727250
	}
}
