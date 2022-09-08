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
	public class CTSTerrainManager : CTSSingleton<CTS.CTSTerrainManager> // TypeDefIndex: 9132
	{
		// Fields
		private List<CompleteTerrainShader> m_shaderList; // 0x18
		private DateTime m_lastShaderListUpdate; // 0x20
		private List<CTSWeatherController> m_controllerList; // 0x30
		private DateTime m_lastControllerListUpdate; // 0x38
	
		// Constructors
		protected CTSTerrainManager() {} // 0x0000000187575F30-0x0000000187576050
	
		// Methods
		// [XID] // 0x00000001899B8A80-0x00000001899B8AA0
		public void RegisterAllShaders(bool force = false /* Metadata: 0x00AE5474 */) {} // 0x0000000187575650-0x0000000187575990
		// [XID] // 0x00000001897BDBA0-0x00000001897BDBC0
		public void RegisterAllControllers(bool force = false /* Metadata: 0x00AE5475 */) {} // 0x0000000187575390-0x0000000187575650
		// [XID] // 0x0000000189718B90-0x0000000189718BB0
		public void AddCTSToAllTerrains() {} // 0x0000000187572F90-0x0000000187573200
		// [XID] // 0x0000000189720260-0x0000000189720280
		public void AddCTSToTerrain(Terrain terrain) {} // 0x0000000187573200-0x0000000187573400
		// [XID] // 0x00000001896B0810-0x00000001896B0830
		public bool ProfileIsActive(CTSProfile profile) => default; // 0x0000000187575160-0x0000000187575390
		// [IDTag] // 0x000000018972EEF0-0x000000018972EF30
		// [XID] // 0x000000018972EEF0-0x000000018972EF30
		public void BroadcastProfileSelect(CTSProfile profile) {} // 0x0000000187574130-0x0000000187574270
		// [IDTag] // 0x0000000189739560-0x00000001897395A0
		// [XID] // 0x0000000189739560-0x00000001897395A0
		public void BroadcastProfileSelect(CTSProfile profile, Terrain terrain) {} // 0x0000000187573F70-0x0000000187574130
		// [XID] // 0x0000000189718450-0x0000000189718470
		public void BroadcastProfileUpdate(CTSProfile profile) {} // 0x0000000187574270-0x0000000187574560
		// [XID] // 0x000000018974BB30-0x000000018974BB50
		public void BroadcastProfileRuntimeUpdate(CTSProfile profile) {} // 0x0000000187573D20-0x0000000187573F70
		// [XID] // 0x0000000189752E70-0x0000000189752E90
		public void BroadcastShaderSetup(CTSProfile profile) {} // 0x0000000187574990-0x0000000187574D00
		// [XID] // 0x0000000189772A00-0x0000000189772A20
		public void UpdateTexturesToMultiTerrain(CTSProfile profileInstance) {} // 0x0000000187575CD0-0x0000000187575F30
		// [XID] // 0x0000000189761EA0-0x0000000189761EC0
		public void UpdateTexturesToMultiTerrainWithSameSource(CTSProfile profileSource) {} // 0x0000000187575A80-0x0000000187575CD0
		// [XID] // 0x0000000189B245C0-0x0000000189B245E0
		public CTSProfile GetMatchedProfileInstance(CTSProfile srcProfile) => default; // 0x0000000187574E40-0x0000000187575160
		// [XID] // 0x0000000189770A20-0x0000000189770A40
		public void BroadcastShaderSetupMultiTerrains(CTSProfile profile) {} // 0x0000000187574560-0x0000000187574990
		// [XID] // 0x0000000189778290-0x00000001897782B0
		public void BroadcastBakeTerrains() {} // 0x0000000187573680-0x0000000187573820
		// [XID] // 0x000000018977F780-0x000000018977F7A0
		public void BroadcastAlbedoTextureSwitch(CTSProfile profile, Texture2D texture, int textureIdx, float tiling) {} // 0x0000000187573400-0x0000000187573680
		// [XID] // 0x0000000189787150-0x0000000189787170
		public void BroadcastNormalTextureSwitch(CTSProfile profile, Texture2D texture, int textureIdx, float tiling) {} // 0x0000000187573AA0-0x0000000187573D20
		// [XID] // 0x00000001897ADE30-0x00000001897ADE50
		public void BroadcastDetailHeightTextureSwitch(CTSProfile profile, Texture2D texture, int textureIdx, float tiling) {} // 0x0000000187573820-0x0000000187573AA0
		// [XID] // 0x0000000189795E90-0x0000000189795EB0
		public void BroadcastWeatherUpdate(CTSWeatherManager manager) {} // 0x0000000187574D00-0x0000000187574E40
		// [XID] // 0x0000000189614290-0x00000001896142B0
		public void RemoveWorldSeams() {} // 0x0000000187575990-0x0000000187575A80
	}
}
