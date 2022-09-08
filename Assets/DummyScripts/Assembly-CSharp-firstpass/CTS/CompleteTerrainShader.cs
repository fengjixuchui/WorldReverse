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

namespace CTS
{
	[Serializable]
	[ExecuteInEditMode] // 0x0000000189AA4BE0-0x0000000189AA4C50
	// [RequireComponent] // 0x0000000189AA4BE0-0x0000000189AA4C50
	public class CompleteTerrainShader : MonoBehaviour // TypeDefIndex: 9114
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public CTSResources m_resources; // 0x18
		public string m_ctsDirectory; // 0x20
		public static List<CompleteTerrainShader> AllTerrainShaders; // 0x00
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CTSProfile m_profileInstance; // 0x28
		private bool m_IsProfileInstantiateFromScript; // 0x30
		private int[,] m_materialPropIDs; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public CTSProfile m_profileSource; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string m_profilePath; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_normalMap; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_bakeNormalMap; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_colorMap; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_bakeColorMap; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_bakeGrassTextures; // 0x69
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_bakeGrassMixStrength; // 0x6C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_bakeGrassDarkenAmount; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_useCutout; // 0x74
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_useMaskmap; // 0x75
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_cutoutMask; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_cutoutHeight; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_splat1; // 0x88
		private bool m_checkedMaterialOnRuntimeAwake; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_splat2; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_splat3; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_splat4; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_DetailTintColorTexture; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_FadeTintColorTexture; // 0xB8
		private float[,,] m_splatBackupArray; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CTSConstants.ShaderType m_activeShaderType; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Terrain m_terrain; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material m_material; // 0xD8
		private bool m_IsMaterialCretedFromScript; // 0xE0
		private List<int> m_ctsToTerrainIndex; // 0xE8
	
		// Properties
		public CTSProfile Profile { /* [XID] */ /* 0x0000000189B67D70-0x0000000189B67D90 */ get => default; /* [XID] */ /* 0x0000000189AA8E30-0x0000000189AA8E50 */ set {} } // 0x000000018643B400-0x000000018643B4A0 0x000000018643CC00-0x000000018643D110
		private bool _fastAccess { /* [XID] */ /* 0x0000000189AE27A0-0x0000000189AE27C0 */ get => default; } // 0x000000018643C0F0-0x000000018643C190 
		public Texture2D NormalMap { /* [XID] */ /* 0x0000000189BB8BC0-0x0000000189BB8BE0 */ get => default; /* [XID] */ /* 0x0000000189AB2390-0x0000000189AB23B0 */ set {} } // 0x000000018643B360-0x000000018643B400 0x000000018643CA00-0x000000018643CC00
		public bool AutoBakeNormalMap { /* [XID] */ /* 0x0000000189A508A0-0x0000000189A508C0 */ get => default; /* [XID] */ /* 0x0000000189BCFAF0-0x0000000189BCFB10 */ set {} } // 0x000000018643AF50-0x000000018643AFF0 0x000000018643C450-0x000000018643C500
		public Texture2D ColorMap { /* [XID] */ /* 0x0000000189A672F0-0x0000000189A67310 */ get => default; /* [XID] */ /* 0x0000000189A6E940-0x0000000189A6E960 */ set {} } // 0x000000018643AFF0-0x000000018643B090 0x000000018643C500-0x000000018643C700
		public bool AutoBakeColorMap { /* [XID] */ /* 0x00000001895EB710-0x00000001895EB730 */ get => default; /* [XID] */ /* 0x00000001895F2B30-0x00000001895F2B50 */ set {} } // 0x000000018643ACB0-0x000000018643AD50 0x000000018643C190-0x000000018643C240
		public bool AutoBakeGrassIntoColorMap { /* [XID] */ /* 0x00000001895FA3E0-0x00000001895FA400 */ get => default; /* [XID] */ /* 0x000000018966D570-0x000000018966D590 */ set {} } // 0x000000018643AE00-0x000000018643AEA0 0x000000018643C2F0-0x000000018643C3A0
		public float AutoBakeGrassMixStrength { /* [XID] */ /* 0x00000001896095A0-0x00000001896095C0 */ get => default; /* [XID] */ /* 0x0000000189A5F9D0-0x0000000189A5F9F0 */ set {} } // 0x000000018643AEA0-0x000000018643AF50 0x000000018643C3A0-0x000000018643C450
		public float AutoBakeGrassDarkenAmount { /* [XID] */ /* 0x0000000189A57DA0-0x0000000189A57DC0 */ get => default; /* [XID] */ /* 0x000000018961FD30-0x000000018961FD50 */ set {} } // 0x000000018643AD50-0x000000018643AE00 0x000000018643C240-0x000000018643C2F0
		public bool UseCutout { /* [XID] */ /* 0x0000000189627050-0x0000000189627070 */ get => default; /* [XID] */ /* 0x0000000189A7DBA0-0x0000000189A7DBC0 */ set {} } // 0x000000018643BFB0-0x000000018643C050 0x000000018643D110-0x000000018643D200
		public bool UseMaskmap { /* [XID] */ /* 0x0000000189636680-0x00000001896366A0 */ get => default; /* [XID] */ /* 0x0000000189745450-0x0000000189745470 */ set {} } // 0x000000018643C050-0x000000018643C0F0 0x000000018643D200-0x000000018643D2F0
		public Texture2D CutoutMask { /* [XID] */ /* 0x000000018974CEF0-0x000000018974CF10 */ get => default; /* [XID] */ /* 0x000000018964CDD0-0x000000018964CDF0 */ set {} } // 0x000000018643B140-0x000000018643B1E0 0x000000018643C800-0x000000018643CA00
		public float CutoutHeight { /* [XID] */ /* 0x0000000189654150-0x0000000189654170 */ get => default; /* [XID] */ /* 0x000000018965BC10-0x000000018965BC30 */ set {} } // 0x000000018643B090-0x000000018643B140 0x000000018643C700-0x000000018643C800
		public Texture2D Splat1 { /* [XID] */ /* 0x0000000189662F00-0x0000000189662F20 */ get => default; } // 0x000000018643B4A0-0x000000018643B7A0 
		public Texture2D Splat2 { /* [XID] */ /* 0x000000018967A000-0x000000018967A020 */ get => default; } // 0x000000018643B7A0-0x000000018643BA50 
		public Texture2D Splat3 { /* [XID] */ /* 0x0000000189B245E0-0x0000000189B24600 */ get => default; } // 0x000000018643BA50-0x000000018643BD00 
		public Texture2D Splat4 { /* [XID] */ /* 0x0000000189A31A50-0x0000000189A31A70 */ get => default; } // 0x000000018643BD00-0x000000018643BFB0 
		public Texture2D DetailTintColorTexture { /* [XID] */ /* 0x0000000189690CA0-0x0000000189690CC0 */ get => default; } // 0x000000018643B1E0-0x000000018643B2A0 
		public Texture2D FadeTintColorTexture { /* [XID] */ /* 0x0000000189698590-0x00000001896985B0 */ get => default; } // 0x000000018643B2A0-0x000000018643B360 
	
		// Constructors
		public CompleteTerrainShader() {} // 0x000000018643ABF0-0x000000018643ACB0
		static CompleteTerrainShader() {} // 0x000000018643AB60-0x000000018643ABF0
	
		// Methods
		// [XID] // 0x0000000189B83EE0-0x0000000189B83F00
		private void OnCTSAwake() {} // 0x00000001864333F0-0x0000000186433540
		// [XID] // 0x0000000189BC7D40-0x0000000189BC7D60
		public void RestInfosWhenBakingEnd() {} // 0x0000000186436FF0-0x00000001864370C0
		// [XID] // 0x0000000189B8C8B0-0x0000000189B8C8D0
		public void CreateProfileTemp() {} // 0x0000000186430D10-0x0000000186430DB0
		// [XID] // 0x0000000189B94170-0x0000000189B94190
		public void ResetCTSToTerrainIndex() {} // 0x0000000186436F50-0x0000000186436FF0
		// [XID] // 0x000000018973E120-0x000000018973E140
		public void ReloadProfileInstanceFromSource() {} // 0x00000001864340B0-0x0000000186434150
		// [XID] // 0x0000000189BC4E00-0x0000000189BC4E20
		public void SaveProfileInstanceToSource() {} // 0x0000000186437210-0x00000001864372B0
		// [XID] // 0x0000000189BAA340-0x0000000189BAA360
		public void OnUpdateTexturesToMultiTerrainWithSameSource() {} // 0x0000000186433900-0x0000000186433A00
		// [XID] // 0x0000000189BB1AA0-0x0000000189BB1AC0
		public void SaveProfileInstanceToAsset(string newProfileName) {} // 0x0000000186437160-0x0000000186437210
		// [XID] // 0x00000001897AE0A0-0x00000001897AE0C0
		private void FetchSplatOnRuntimeAwake() {} // 0x0000000186430EF0-0x0000000186431730
		// [XID] // 0x0000000189672740-0x0000000189672760
		private void FetchTintColorTexture() {} // 0x0000000186431730-0x0000000186431B00
		// [XID] // 0x000000018963DA70-0x000000018963DA90
		private void OnEnable() {} // 0x00000001864337C0-0x0000000186433900
		// [XID] // 0x0000000189645020-0x0000000189645040
		private void OnDisable() {} // 0x0000000186433680-0x00000001864337C0
		// [XID] // 0x000000018990BCC0-0x000000018990BCE0
		private void Awake() {} // 0x000000018642EC00-0x000000018642EE70
		// [XID] // 0x00000001896B58E0-0x00000001896B5900
		private void OnDestroy() {} // 0x0000000186433540-0x0000000186433680
		// [XID] // 0x0000000189B25D60-0x0000000189B25D80
		private void DestroyMaterial() {} // 0x0000000186430DB0-0x0000000186430EF0
		// [XID] // 0x0000000189938BE0-0x0000000189938C00
		private void Start() {} // 0x0000000186437600-0x0000000186437800
		// [XID] // 0x00000001896CB560-0x00000001896CB580
		private void Update() {} // 0x000000018643AAC0-0x000000018643AB60
		// [XID] // 0x00000001896D2AF0-0x00000001896D2B10
		public static UnityEngine.Object GetAsset(string fileNameOrPath, System.Type assetType) => default; // 0x0000000186431BB0-0x0000000186431C60
		// [XID] // 0x00000001896DA510-0x00000001896DA530
		public static string GetAssetPath(string fileName) => default; // 0x0000000186431B00-0x0000000186431BB0
		// [XID] // 0x00000001896E1CF0-0x00000001896E1D10
		public static System.Type GetType(string TypeName) => default; // 0x0000000186431E80-0x0000000186432190
		// [XID] // 0x00000001896E9260-0x00000001896E9280
		private void ApplyUnityShader() {} // 0x000000018642E880-0x000000018642EC00
		// [XID] // 0x0000000189A761F0-0x0000000189A76210
		private void ApplyShaderMaterial() {} // 0x000000018642E2C0-0x000000018642E880
		// [XID] // 0x0000000189A7DBE0-0x0000000189A7DC00
		private bool NeedsMaterialUpdate() => default; // 0x0000000186432F30-0x00000001864333F0
		// [XID] // 0x0000000189A508C0-0x0000000189A508E0
		public void UpdateMaterialAndShader() {} // 0x0000000186437EF0-0x0000000186437FB0
		// [XID] // 0x0000000189706A60-0x0000000189706A80
		private void UpdateShader() {} // 0x00000001864383B0-0x0000000186439A60
		// [XID] // 0x000000018970E3F0-0x000000018970E410
		private void UpdateShaderPerFrame() {} // 0x0000000186438250-0x00000001864383B0
		// [XID] // 0x0000000189715810-0x0000000189715830
		private void InitMaterialPropIDs() {} // 0x0000000186432920-0x0000000186432F30
		// [XID] // 0x000000018971D370-0x000000018971D390
		public void UpdateProfileFromTerrainForced() {} // 0x00000001864380B0-0x0000000186438250
		// [XID] // 0x0000000189A41980-0x0000000189A419A0
		public void UpdateProfileFromTerrainForcedMultiTerrain(List<Terrain> terrainsUseThisProfile) {} // 0x0000000186437FB0-0x00000001864380B0
		// [XID] // 0x000000018972BF70-0x000000018972BF90
		public void UpdateTexturesToMultiTerrain(bool useInstanceProfile) {} // 0x000000018643AA00-0x000000018643AAC0
		// [XID] // 0x0000000189A3A090-0x0000000189A3A0B0
		private bool ProfileNeedsTextureUpdate() => default; // 0x0000000186433A00-0x00000001864340B0
		// [XID] // 0x000000018973AE10-0x000000018973AE30
		private bool TerrainNeedsTextureUpdate() => default; // 0x0000000186437800-0x0000000186437EF0
		// [XID] // 0x0000000189742520-0x0000000189742540
		public void ReplaceAlbedoInTerrain(Texture2D texture, int textureIdx, float tiling) {} // 0x0000000186434610-0x0000000186434930
		// [XID] // 0x000000018974A1F0-0x000000018974A210
		public void ReplaceNormalInTerrain(Texture2D texture, int textureIdx, float tiling) {} // 0x0000000186434C50-0x0000000186434F70
		// [XID] // 0x0000000189751540-0x0000000189751560
		public void ReplaceDetailHeightInTerrain(Texture2D texture, int textureIdx, float tiling) {} // 0x0000000186434930-0x0000000186434C50
		// [XID] // 0x0000000189B12B10-0x0000000189B12B30
		public void BakeTerrainNormals() {} // 0x0000000186430900-0x0000000186430D10
		// [XID] // 0x0000000189760670-0x0000000189760690
		public void BakeTerrainBaseMap() {} // 0x000000018642FE90-0x0000000186430900
		// [XID] // 0x0000000189767A10-0x0000000189767A30
		public void BakeTerrainBaseMapWithGrass() {} // 0x000000018642EE70-0x000000018642FE90
		// [XID] // 0x000000018976F080-0x000000018976F0A0
		private void UpdateTerrainSplatsAtRuntime() {} // 0x0000000186439EB0-0x000000018643AA00
		// [XID] // 0x0000000189773680-0x00000001897736A0
		public void UpdateTerrainSplatPrototypesSetting() {} // 0x0000000186439A60-0x0000000186439EB0
		// [XID] // 0x000000018977E000-0x000000018977E020
		private void ReplaceTerrainTexturesFromInstanceProfile() {} // 0x0000000186434F70-0x0000000186435A40
		// [XID] // 0x00000001897859C0-0x00000001897859E0
		private void ReplaceTerrainTexturesFromSourceProfile() {} // 0x0000000186436520-0x0000000186436F50
		// [XID] // 0x000000018978CF00-0x000000018978CF20
		private int GetRealTerrainTexIndex(int ctsIndex) => default; // 0x0000000186431D00-0x0000000186431E80
		// [ContextMenu] // 0x0000000189794380-0x00000001897943D0
		// [XID] // 0x0000000189794380-0x00000001897943D0
		private void ShowCtsMaterialInfo() {} // 0x0000000186437370-0x0000000186437410
		// [ContextMenu] // 0x00000001897A0CA0-0x00000001897A0CF0
		// [XID] // 0x00000001897A0CA0-0x00000001897A0CF0
		private void SaveCtsMaterial() {} // 0x00000001864370C0-0x0000000186437160
		// [ContextMenu] // 0x00000001897ACC80-0x00000001897ACCD0
		// [XID] // 0x00000001897ACC80-0x00000001897ACCD0
		private void ShowCtsToTerrainIndex() {} // 0x0000000186437410-0x0000000186437600
		// [XID] // 0x00000001897B8EC0-0x00000001897B8EE0
		private void InitCtsToTerrainIndex() {} // 0x0000000186432190-0x0000000186432920
		// [XID] // 0x0000000189A85490-0x0000000189A854B0
		private void ReplaceTerrainTexturesFromProfileMultiTerrain() {} // 0x0000000186435A40-0x0000000186436520
		// [XID] // 0x0000000189AA1720-0x0000000189AA1740
		public static string GetCTSDirectory() => default; // 0x0000000186431C60-0x0000000186431D00
		// [XID] // 0x00000001897D0030-0x00000001897D0050
		public static void SetDirty(UnityEngine.Object obj, bool recordUndo, bool isPlayingAllowed) {} // 0x00000001864372B0-0x0000000186437370
		// [XID] // 0x00000001897D7910-0x00000001897D7930
		public void RemoveWorldSeams() {} // 0x0000000186434150-0x0000000186434610
	}
}
