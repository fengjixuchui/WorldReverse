/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class GaiaSessionManager : MonoBehaviour // TypeDefIndex: 9304
	{
		// Fields
		public IEnumerator m_updateSessionCoroutine; // 0x18
		public IEnumerator m_updateOperationCoroutine; // 0x20
		private bool m_cancelPlayback; // 0x28
		public GaiaSession m_session; // 0x30
		public bool m_genShowRandomGenerator; // 0x38
		public bool m_genShowTerrainHelper; // 0x39
		public GaiaConstants.GeneratorBorderStyle m_genBorderStyle; // 0x3C
		public int m_genNumStampsToGenerate; // 0x40
		public float m_genScaleWidth; // 0x44
		public float m_genScaleHeight; // 0x48
		public float m_genChanceOfHills; // 0x4C
		public float m_genChanceOfIslands; // 0x50
		public float m_genChanceOfLakes; // 0x54
		public float m_genChanceOfMesas; // 0x58
		public float m_genChanceOfMountains; // 0x5C
		public float m_genChanceOfPlains; // 0x60
		public float m_genChanceOfRivers; // 0x64
		public float m_genChanceOfValleys; // 0x68
		public float m_genChanceOfVillages; // 0x6C
		public float m_genChanceOfWaterfalls; // 0x70
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public Stamper m_currentStamper; // 0x78
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public Spawner m_currentSpawner; // 0x80
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public DateTime m_lastUpdateDateTime; // 0x88
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public ulong m_progress; // 0x98
		private List<string> m_genHillStamps; // 0xA0
		private List<string> m_genIslandStamps; // 0xA8
		private List<string> m_genLakeStamps; // 0xB0
		private List<string> m_genMesaStamps; // 0xB8
		private List<string> m_genMountainStamps; // 0xC0
		private List<string> m_genPlainsStamps; // 0xC8
		private List<string> m_genRiverStamps; // 0xD0
		private List<string> m_genValleyStamps; // 0xD8
		private List<string> m_genVillageStamps; // 0xE0
		private List<string> m_genWaterfallStamps; // 0xE8
		public bool m_autoGenerateLighting; // 0xF0
		public string m_saveAsFileName; // 0xF8
	
		// Constructors
		public GaiaSessionManager() {} // 0x0000000185EBEB40-0x0000000185EBEDC0
	
		// Methods
		// [XID] // 0x000000018992AA80-0x000000018992AAA0
		public static GaiaSessionManager GetSessionManager(bool pickupExistingTerrain = false /* Metadata: 0x00AE574B */) => default; // 0x0000000185EBBBD0-0x0000000185EBBE40
		// [XID] // 0x00000001896B6EB0-0x00000001896B6ED0
		public bool IsLocked() => default; // 0x0000000185EBC300-0x0000000185EBC400
		// [XID] // 0x00000001896BE040-0x00000001896BE060
		public bool LockSession() => default; // 0x0000000185EBC400-0x0000000185EBC510
		// [XID] // 0x00000001896C5910-0x00000001896C5930
		public bool UnLockSession() => default; // 0x0000000185EBEA30-0x0000000185EBEB40
		// [XID] // 0x00000001896CCFA0-0x00000001896CCFC0
		public void AddOperation(GaiaOperation operation) {} // 0x0000000185EB8810-0x0000000185EB8930
		// [XID] // 0x00000001899CAB60-0x00000001899CAB80
		public GaiaOperation GetOperation(int operationIdx) => default; // 0x0000000185EBAE70-0x0000000185EBAFE0
		// [XID] // 0x00000001896DBC40-0x00000001896DBC60
		public void RemoveOperation(int operationIdx) {} // 0x0000000185EBDCD0-0x0000000185EBDE30
		// [XID] // 0x00000001896E3340-0x00000001896E3360
		public void AddResource(GaiaResource resource) {} // 0x0000000185EB8AA0-0x0000000185EB8C50
		// [XID] // 0x00000001896EA860-0x00000001896EA880
		public void AddDefaults(GaiaDefaults defaults) {} // 0x0000000185EB86F0-0x0000000185EB8810
		// [XID] // 0x00000001896F1850-0x00000001896F1870
		public void AddPreviewImage(Texture2D image) {} // 0x0000000185EB8930-0x0000000185EB8AA0
		// [XID] // 0x00000001899F01A0-0x00000001899F01C0
		public bool HasPreviewImage() => default; // 0x0000000185EBC210-0x0000000185EBC300
		// [XID] // 0x0000000189700CC0-0x0000000189700CE0
		public void RemovePreviewImage() {} // 0x0000000185EBDE30-0x0000000185EBDF80
		// [XID] // 0x0000000189A58E20-0x0000000189A58E40
		public Texture2D GetPreviewImage() => default; // 0x0000000185EBAFE0-0x0000000185EBB170
		// [XID] // 0x000000018970FE30-0x000000018970FE50
		public void SaveSession() {} // 0x0000000185EBE240-0x0000000185EBE2E0
		// [XID] // 0x0000000189717020-0x0000000189717040
		public void StartEditorUpdates() {} // 0x0000000185EBE840-0x0000000185EBE8E0
		// [XID] // 0x000000018971E9A0-0x000000018971E9C0
		public void StopEditorUpdates() {} // 0x0000000185EBE8E0-0x0000000185EBE990
		// [XID] // 0x0000000189B13870-0x0000000189B13890
		private void EditorUpdate() {} // 0x0000000185EB9B40-0x0000000185EB9CE0
		// [XID] // 0x000000018972D690-0x000000018972D6B0
		public GaiaSession CreateSession(bool pickupExistingTerrain = false /* Metadata: 0x00AE574C */) => default; // 0x0000000185EB94E0-0x0000000185EB9980
		// [XID] // 0x0000000189734E10-0x0000000189734E30
		public void SetSeaLevel(float seaLevel) {} // 0x0000000185EBE550-0x0000000185EBE610
		// [XID] // 0x0000000189A51730-0x0000000189A51750
		public float GetSeaLevel() => default; // 0x0000000185EBBB10-0x0000000185EBBBD0
		// [XID] // 0x0000000189A07470-0x0000000189A07490
		public void ResetSession() {} // 0x0000000185EBDF80-0x0000000185EBE1A0
		// [XID] // 0x000000018974BB10-0x000000018974BB30
		public void RandomiseStamps() {} // 0x0000000185EBD1F0-0x0000000185EBDB90
		// [XID] // 0x0000000189752E50-0x0000000189752E70
		private void PositionStamp(Bounds bounds, Stamper stamper, GaiaConstants.FeatureType stampType) {} // 0x0000000185EBCD00-0x0000000185EBD1F0
		// [XID] // 0x0000000189969A40-0x0000000189969A60
		private GaiaConstants.FeatureType GetWeightedRandomFeatureType() => default; // 0x0000000185EBBFC0-0x0000000185EBC210
		// [XID] // 0x00000001898E2B40-0x00000001898E2B60
		public string GetRandomStampPath(GaiaConstants.FeatureType featureType) => default; // 0x0000000185EBB3B0-0x0000000185EBBB10
		// [XID] // 0x00000001897692B0-0x00000001897692D0
		public string GetRandomMountainFieldPath() => default; // 0x0000000185EBB170-0x0000000185EBB3B0
		// [XID] // 0x0000000189770A00-0x0000000189770A20
		public GameObject Apply(int operationIdx) => default; // 0x0000000185EB8C50-0x0000000185EB9390
		// [XID] // 0x0000000189778240-0x0000000189778260
		public void PlaySession() {} // 0x0000000185EBCC40-0x0000000185EBCD00
		[DebuggerHidden] // 0x000000018977F740-0x000000018977F780
		// [XID] // 0x000000018977F740-0x000000018977F780
		public IEnumerator PlaySessionCoRoutine(bool forceReset = false /* Metadata: 0x00AE574D */) => default; // 0x0000000185EBCB20-0x0000000185EBCC40
		// [XID] // 0x0000000189B08290-0x0000000189B082B0
		public void PlayOperation(int opIdx) {} // 0x0000000185EBCA50-0x0000000185EBCB20
		[DebuggerHidden] // 0x0000000189791760-0x00000001897917A0
		// [XID] // 0x0000000189791760-0x00000001897917A0
		public IEnumerator PlayOperationCoRoutine(int operationIdx, bool forceReset = false /* Metadata: 0x00AE574E */) => default; // 0x0000000185EBC910-0x0000000185EBCA50
		// [XID] // 0x000000018979C7C0-0x000000018979C7E0
		public void CancelPlayback() {} // 0x0000000185EB9390-0x0000000185EB94E0
		// [XID] // 0x00000001897A3C30-0x00000001897A3C50
		public void ExportSessionResources() {} // 0x0000000185EBA2E0-0x0000000185EBA6D0
		// [XID] // 0x0000000189B1E500-0x0000000189B1E520
		public void ExportSessionDefaults() {} // 0x0000000185EB9CE0-0x0000000185EB9F20
		// [XID] // 0x00000001897B2DC0-0x00000001897B2DE0
		public void ExportSessionResource(string resourcePath) {} // 0x0000000185EB9F20-0x0000000185EBA2E0
		// [XID] // 0x00000001897BA950-0x00000001897BA970
		private void OnDrawGizmosSelected() {} // 0x0000000185EBC510-0x0000000185EBC910
		// [XID] // 0x00000001897C2660-0x00000001897C2680
		private GameObject FindOrCreateObject(GaiaOperation operation) => default; // 0x0000000185EBA6D0-0x0000000185EBAE70
		// [XID] // 0x000000018990CF10-0x000000018990CF30
		private GameObject ShowStamper(string name, string id) => default; // 0x0000000185EBE610-0x0000000185EBE840
		// [XID] // 0x00000001897D14C0-0x00000001897D14E0
		private GameObject CreateSpawner(string name, string id) => default; // 0x0000000185EB9980-0x0000000185EB9B40
		// [XID] // 0x0000000189B2D130-0x0000000189B2D150
		public void RefreshAndPlaySession() {} // 0x0000000185EBDB90-0x0000000185EBDCD0
		// [ContextMenu] // 0x00000001897E0720-0x00000001897E0770
		// [XID] // 0x00000001897E0720-0x00000001897E0770
		private void SaveTerrainData() {} // 0x0000000185EBE2E0-0x0000000185EBE550
		// [ContextMenu] // 0x00000001897ECBA0-0x00000001897ECBF0
		// [XID] // 0x00000001897ECBA0-0x00000001897ECBF0
		private void TestLightWindowSettings() {} // 0x0000000185EBE990-0x0000000185EBEA30
		// [XID] // 0x00000001897F8B60-0x00000001897F8B80
		public void SaveSessionAs() {} // 0x0000000185EBE1A0-0x0000000185EBE240
		// [XID] // 0x0000000189B693D0-0x0000000189B693F0
		private string GetUGCfolderPath(string fileName) => default; // 0x0000000185EBBE40-0x0000000185EBBFC0
	}
}
