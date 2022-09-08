/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CTS
{
	[Serializable]
	public class CTSTerrainTextureDetails : ISerializationCallbackReceiver // TypeDefIndex: 9134
	{
		// Fields
		public static readonly float k_smoothnessRange; // 0x00
		public bool m_isOpenInEditor; // 0x10
		public int m_textureIdx; // 0x14
		public string m_name; // 0x18
		public float m_detailPower; // 0x20
		public Color m_tint; // 0x24
		public float m_tintBrightness; // 0x34
		public float m_smoothness; // 0x38
		public int m_albedoIdx; // 0x3C
		public float m_albedoTilingClose; // 0x40
		public float m_albedoTilingFar; // 0x44
		public bool m_enableSnow; // 0x48
		[NonSerialized]
		public bool m_albedoWasChanged; // 0x49
		public Vector4 m_albedoAverage; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_albedoTexture; // 0x60
		public int m_normalIdx; // 0x68
		public float m_normalStrength; // 0x6C
		[NonSerialized]
		public bool m_normalWasChanged; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_normalTexture; // 0x78
		[NonSerialized]
		public bool m_detailHeightWasChanged; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_detailHeight; // 0x88
		public int m_heightIdx; // 0x90
		public float m_heightDepth; // 0x94
		public float m_heightContrast; // 0x98
		public float m_heightBlendClose; // 0x9C
		public float m_heightBlendFar; // 0xA0
		public float m_heightTesselationDepth; // 0xA4
		public float m_heightMin; // 0xA8
		public float m_heightMax; // 0xAC
		[NonSerialized]
		public bool m_heightWasChanged; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_heightTexture; // 0xB8
		public int m_aoIdx; // 0xC0
		public float m_aoPower; // 0xC4
		[NonSerialized]
		public bool m_aoWasChanged; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_aoTexture; // 0xD0
		public int m_emissionIdx; // 0xD8
		public float m_emissionStrength; // 0xDC
		[NonSerialized]
		public bool m_emissionWasChanged; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_emissionTexture; // 0xE8
		public MoleMole.SceneSurfaceMaterial walkRunSurfaceType; // 0xF0
		public MoleMole.SceneSurfaceMaterial climbSurfaceType; // 0xF4
		public float m_RainNormalPowerScale; // 0xF8
		public float m_RainReflectIntensity; // 0xFC
		public bool m_useTint; // 0x100
		public Texture2D m_baseTint; // 0x108
		public Vector2 m_baseTintTiling; // 0x110
		public Vector2 m_baseTintOffset; // 0x118
	
		// Properties
		public Texture2D Albedo { /* [XID] */ /* 0x0000000189AD3630-0x0000000189AD3650 */ get => default; /* [XID] */ /* 0x00000001897E97F0-0x00000001897E9810 */ set {} } // 0x0000000187576E40-0x0000000187576EE0 0x0000000187577240-0x0000000187577360
		public Texture2D Normal { /* [XID] */ /* 0x00000001897ACFC0-0x00000001897ACFE0 */ get => default; /* [XID] */ /* 0x000000018990A1E0-0x000000018990A200 */ set {} } // 0x00000001875771A0-0x0000000187577240 0x00000001875776A0-0x0000000187577760
		public Texture2D DetailHeight { /* [XID] */ /* 0x0000000189AEA2D0-0x0000000189AEA2F0 */ get => default; /* [XID] */ /* 0x0000000189807920-0x0000000189807940 */ set {} } // 0x0000000187576F90-0x0000000187577040 0x0000000187577430-0x0000000187577500
		public Texture2D Height { /* [XID] */ /* 0x000000018960CD60-0x000000018960CD80 */ get => default; /* [XID] */ /* 0x0000000189833660-0x0000000189833680 */ set {} } // 0x00000001875770F0-0x00000001875771A0 0x00000001875775D0-0x00000001875776A0
		public Texture2D AmbientOcclusion { /* [XID] */ /* 0x0000000189AE10C0-0x0000000189AE10E0 */ get => default; /* [XID] */ /* 0x0000000189A53140-0x0000000189A53160 */ set {} } // 0x0000000187576EE0-0x0000000187576F90 0x0000000187577360-0x0000000187577430
		public Texture2D Emission { /* [XID] */ /* 0x0000000189A44490-0x0000000189A444B0 */ get => default; /* [XID] */ /* 0x0000000189612210-0x0000000189612230 */ set {} } // 0x0000000187577040-0x00000001875770F0 0x0000000187577500-0x00000001875775D0
	
		// Constructors
		public CTSTerrainTextureDetails() {} // 0x0000000187576C80-0x0000000187576E40
		public CTSTerrainTextureDetails(CTSTerrainTextureDetails src) {} // 0x0000000187576AA0-0x0000000187576C80
		static CTSTerrainTextureDetails() {} // 0x0000000187576A40-0x0000000187576AA0
	
		// Methods
		// [XID] // 0x0000000189716D70-0x0000000189716D90
		public void OnBeforeSerialize() {} // 0x0000000187576820-0x00000001875768C0
		// [XID] // 0x00000001898432E0-0x0000000189843300
		public void OnAfterDeserialize() {} // 0x0000000187576750-0x0000000187576820
		// [XID] // 0x000000018984A530-0x000000018984A550
		public void Copy(CTSTerrainTextureDetails src) {} // 0x0000000187576190-0x00000001875763F0
		// [XID] // 0x0000000189976250-0x0000000189976270
		public void ResetChangedFlags() {} // 0x00000001875768C0-0x0000000187576970
		// [XID] // 0x000000018997D4C0-0x000000018997D4E0
		public bool TextureHasChanged() => default; // 0x0000000187576970-0x0000000187576A40
		// [XID] // 0x0000000189860470-0x0000000189860490
		public void Lerp(CTSTerrainTextureDetails targetSetting, float ratio) {} // 0x00000001875763F0-0x0000000187576750
	}
}
