/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public static class BenchmarkEntityUtility // TypeDefIndex: 27608
	{
		// Fields
		public const string EC_All = "*"; // Metadata: 0x00B0CA63
		public const string EC_Avatar = "ava"; // Metadata: 0x00B0CA68
		public const string EC_NPC = "npc"; // Metadata: 0x00B0CA6F
		public const string EC_Monster = "mon"; // Metadata: 0x00B0CA76
		public const string EC_ScenePropEntity = "sce"; // Metadata: 0x00B0CA7D
		public const string EC_Gadget = "gad"; // Metadata: 0x00B0CA84
		private static EnviroWeatherTunner _ewt; // 0x00
		private static Dictionary<string, int> itemToggleLevel; // 0x18
		public const string GameplayPerformanceVisualTag = "GPVLOD"; // Metadata: 0x00B0CA8B
		private static IEnumerator powerCameraRotationJob; // 0x20
	
		// Nested types
		private struct EnviroWeatherTunner // TypeDefIndex: 27609
		{
			// Fields
			private EnviroWeather _originalWeather; // 0x00
			private EnviroWeather _currentFakeRainEffectWeather; // 0x08
			private uint handle; // 0x10
	
			// Properties
			private bool isFakingRainEffect { /* [XID] */ /* 0x0000000189661EB0-0x0000000189661ED0 */ get => default; } // 0x0000000181AEBF80-0x0000000181AEC070 
	
			// Methods
			// [XID] // 0x0000000189669A30-0x0000000189669A50
			public void FakeRainEffectWeather(bool enableEffect, EnviroSky inToBackup) {} // 0x0000000181AEBDB0-0x0000000181AEBEC0
			// [XID] // 0x0000000189671660-0x0000000189671680
			public void RecoverEnviroSky(EnviroSky inToBackup) {} // 0x0000000181AEBEC0-0x0000000181AEBF80
		}
	
		// Constructors
		static BenchmarkEntityUtility() {} // 0x0000000181AD3850-0x0000000181AD3910
	
		// Methods
		// [XID] // 0x0000000189A6D870-0x0000000189A6D890
		public static void SetCameraTop(float distance) {} // 0x0000000181AD0710-0x0000000181AD0910
		// [XID] // 0x0000000189A74F70-0x0000000189A74F90
		public static void ResetCameraTop() {} // 0x0000000181AD0590-0x0000000181AD0650
		// [XID] // 0x0000000189A7CBE0-0x0000000189A7CC00
		public static void ForceFreeMoveMode(int level) {} // 0x0000000181ACF370-0x0000000181ACF490
		// [XID] // 0x0000000189A84520-0x0000000189A84540
		public static void RequestSceneTransToPoint(uint sceneId, uint pointId) {} // 0x0000000181AD0490-0x0000000181AD0590
		// [XID] // 0x0000000189A8BE90-0x0000000189A8BEB0
		public static GameObject FindGameObject(string path) => default; // 0x0000000181ACF070-0x0000000181ACF140
		// [XID] // 0x0000000189A933A0-0x0000000189A933C0
		public static void ToggleGameObjectByRegex(bool isOn, string toggleItemName, string rootHierarchyPath, string regexRule, Action<GameObject, bool> onActive = null) {} // 0x0000000181AD35B0-0x0000000181AD3720
		// [XID] // 0x0000000189A9AE10-0x0000000189A9AE30
		public static void ToggleGameObject(string path, bool isActive) {} // 0x0000000181AD3720-0x0000000181AD3850
		// [XID] // 0x0000000189AA2190-0x0000000189AA21B0
		public static void SetGameObjectLevel(int level, string hierarchyPath) {} // 0x0000000181AD0D60-0x0000000181AD0E50
		// [XID] // 0x0000000189AA96B0-0x0000000189AA96D0
		public static void SetGraphicsSettingLevel(int level) {} // 0x0000000181AD1070-0x0000000181AD1130
		public static T CreateDialog<T>(string pannelName)
			where T : BaseDialogContext, new() => default;
		// [XID] // 0x0000000189AB1530-0x0000000189AB1550
		public static void SetPostProcessingLevel(int level) {} // 0x0000000181AD1D40-0x0000000181AD1E40
		// [XID] // 0x0000000189AB87E0-0x0000000189AB8800
		public static void SetParticleSystemRenderingLevel(int level) {} // 0x0000000181AD1AA0-0x0000000181AD1B70
		// [XID] // 0x0000000189AC0490-0x0000000189AC04B0
		public static void SetShadowLevel(int level) {} // 0x0000000181AD1F30-0x0000000181AD1FD0
		// [XID] // 0x0000000189AC7E80-0x0000000189AC7EA0
		public static void SetLocalAvatarSkinnedMeshLevel(int level) {} // 0x0000000181AD17C0-0x0000000181AD19F0
		// [XID] // 0x0000000189ACF4B0-0x0000000189ACF4D0
		public static void SetUILevel(int level) {} // 0x0000000181AD2350-0x0000000181AD2440
		// [XID] // 0x0000000189AD7250-0x0000000189AD7270
		public static void SetEntityTickFunctionLevel(int level) {} // 0x0000000181AD0AF0-0x0000000181AD0BC0
		// [XID] // 0x0000000189ADECB0-0x0000000189ADECD0
		public static void SetLocalAvatarRotation(float x, float y, float z) {} // 0x0000000181AD1610-0x0000000181AD17C0
		// [XID] // 0x0000000189AE6600-0x0000000189AE6620
		public static void SetLocalAvatarAnimatorPlaySpeed(float speed) {} // 0x0000000181AD1330-0x0000000181AD1500
		// [XID] // 0x0000000189AEDEB0-0x0000000189AEDED0
		public static void SetRendererLevel(int level, string hierarchyPath) {} // 0x0000000181AD1E40-0x0000000181AD1F30
		// [XID] // 0x0000000189AF5640-0x0000000189AF5660
		public static void SetStageSceneLevel(int level, string sceneRootHierarchyPath) {} // 0x0000000181AD2080-0x0000000181AD2170
		// [XID] // 0x0000000189AFCBB0-0x0000000189AFCBD0
		public static string GetDrawCallInfo() => default; // 0x0000000181ACF490-0x0000000181ACF5C0
		// [XID] // 0x0000000189B042F0-0x0000000189B04310
		public static void SetSkinnedMeshOutlineThreshold(float range) {} // 0x0000000181AD1FD0-0x0000000181AD2080
		// [XID] // 0x0000000189B0BBB0-0x0000000189B0BBD0
		public static void SetNPCMeshOutlineThreshold(float range) {} // 0x0000000181AD19F0-0x0000000181AD1AA0
		// [XID] // 0x0000000189B13080-0x0000000189B130A0
		public static void SetGameManagerLevel(int level) {} // 0x0000000181AD0BC0-0x0000000181AD0D60
		// [XID] // 0x0000000189B1A810-0x0000000189B1A830
		public static void SetHideShowObject(int objectType, bool show) {} // 0x0000000181AD1130-0x0000000181AD1230
		// [XID] // 0x0000000189B21E20-0x0000000189B21E40
		public static void ShowHideShowObjectDialogPage(bool show) {} // 0x0000000181AD2610-0x0000000181AD2780
		// [XID] // 0x0000000189B29400-0x0000000189B29420
		public static void SetPostProcessLayerResolutionLevel(int level) {} // 0x0000000181AD1B70-0x0000000181AD1D40
		// [XID] // 0x0000000189B308C0-0x0000000189B308E0
		public static void TestSetNANPosition(GameObject go, int mode) {} // 0x0000000181AD3170-0x0000000181AD3310
		// [XID] // 0x0000000189B380D0-0x0000000189B380F0
		public static void TestSetNANPositionByPath(string path, int mode) {} // 0x0000000181AD3030-0x0000000181AD3170
		// [XID] // 0x0000000189B3FAE0-0x0000000189B3FB00
		public static void SetUntoggleablePostProcessLevel(int level) {} // 0x0000000181AD24F0-0x0000000181AD2610
		// [XID] // 0x0000000189B47340-0x0000000189B47360
		public static void StatEntityUnityComponent(string entityCategory, string componentID, bool openExplorer, bool upload) {} // 0x0000000181AD2780-0x0000000181AD28D0
		// [XID] // 0x0000000189B4EBC0-0x0000000189B4EBE0
		public static void ToggleEntityUnityComponent(string entityCategory, string componentID, bool isEnable, bool isLightweightStyle) {} // 0x0000000181AD3460-0x0000000181AD35B0
		// [XID] // 0x0000000189B56420-0x0000000189B56440
		public static void ToggleEntityUnityComponentAttributesByValObject(string entityCategory, string componentID, string attributeID, object value) {} // 0x0000000181AD3310-0x0000000181AD3460
		// [XID] // 0x0000000189B5DBD0-0x0000000189B5DBF0
		public static void SetEntityAnimatorLevel(string entityCategory, int level) {} // 0x0000000181AD0A00-0x0000000181AD0AF0
		// [XID] // 0x0000000189B651E0-0x0000000189B65200
		public static void ForceEnableRainEffect(bool isForce, bool isEnabled) {} // 0x0000000181ACF140-0x0000000181ACF370
		// [XID] // 0x0000000189B6C720-0x0000000189B6C740
		public static void SetItemToggleLevel(string item, int level) {} // 0x0000000181AD1230-0x0000000181AD1330
		// [XID] // 0x0000000189B73EB0-0x0000000189B73ED0
		public static int GetItemToggleLevel(string item, int defaultLevel = 0 /* Metadata: 0x00B0CA5F */) => default; // 0x0000000181ACF5C0-0x0000000181ACF710
		// [XID] // 0x0000000189B7B540-0x0000000189B7B560
		public static bool HasItemBeenSetToggleLOD(string inItemTag) => default; // 0x0000000181ACF840-0x0000000181ACF930
		// [XID] // 0x0000000189B82E80-0x0000000189B82EA0
		public static void OnRefreshGameplayPerformanceVisualLOD() {} // 0x0000000181AD0390-0x0000000181AD0490
		// [XID] // 0x0000000189B8A460-0x0000000189B8A480
		public static void SetGameplayPerformanceVisualLOD(int inLOD) {} // 0x0000000181AD0E50-0x0000000181AD1070
		// [XID] // 0x0000000189B91A80-0x0000000189B91AA0
		public static BaseEntity TestBaseEntityHandle() => default; // 0x0000000181AD2D60-0x0000000181AD3030
		[DebuggerHidden] // 0x0000000189B98E60-0x0000000189B98EA0
		// [XID] // 0x0000000189B98E60-0x0000000189B98EA0
		public static IEnumerator BenchmarkDamageTextIter(float seconds, float rateOfTime) => default; // 0x0000000181ACE7D0-0x0000000181ACE8F0
		// [XID] // 0x0000000189BA3590-0x0000000189BA35B0
		public static void BenchmarkDamageText(float seconds, float rateOfTime) {} // 0x0000000181ACE8F0-0x0000000181ACEA20
		[DebuggerHidden] // 0x0000000189BAA8F0-0x0000000189BAA930
		// [XID] // 0x0000000189BAA8F0-0x0000000189BAA930
		public static IEnumerator BenchmarkDeathRagdollIter(uint entityConfigID, int entityCount, float entityRadius, float deathCount) => default; // 0x0000000181ACEA20-0x0000000181ACEB80
		// [XID] // 0x0000000189BB4E50-0x0000000189BB4E70
		public static void BenchmarkDeathRagdoll(uint entityConfigID, int entityCount, float entityRadius, float deathCount) {} // 0x0000000181ACEB80-0x0000000181ACECF0
		// [XID] // 0x0000000189BBC400-0x0000000189BBC420
		public static void SetUnityTime(double time) {} // 0x0000000181AD2440-0x0000000181AD24F0
		// [XID] // 0x0000000189BC4140-0x0000000189BC4160
		public static void SetLocalAvatarKinematicLevel(int level) {} // 0x0000000181AD1500-0x0000000181AD1610
		// [XID] // 0x0000000189BCBB10-0x0000000189BCBB30
		public static void SetStreamingLevel(int level) {} // 0x0000000181AD2170-0x0000000181AD2240
		// [XID] // 0x0000000189BD3040-0x0000000189BD3060
		public static void BenchmarkCameraRotation(float angle, float deltaSecond) {} // 0x0000000181ACE5D0-0x0000000181ACE7D0
		// [XID] // 0x0000000189BDA860-0x0000000189BDA880
		public static void StopBenchmarkCameraRotation() {} // 0x0000000181AD2A20-0x0000000181AD2B80
		[DebuggerHidden] // 0x00000001895E72B0-0x00000001895E72F0
		// [XID] // 0x00000001895E72B0-0x00000001895E72F0
		public static IEnumerator Goto(Vector3 pos) => default; // 0x0000000181ACF710-0x0000000181ACF840
		[DebuggerHidden] // 0x00000001895F1B30-0x00000001895F1B70
		// [XID] // 0x00000001895F1B30-0x00000001895F1B70
		public static IEnumerator IterTelAndLookAround(Vector3 target, float deltaDegree, float deltaInterval, float seconds, IEnumerator inEnumTel) => default; // 0x0000000181ACFA90-0x0000000181ACFC20
		// [XID] // 0x00000001895FC300-0x00000001895FC320
		public static void TelAndLookAround(Vector3 target, float deltaDegree, float deltaInterval, float seconds) {} // 0x0000000181AD2B80-0x0000000181AD2D60
		[DebuggerHidden] // 0x0000000189603CC0-0x0000000189603D00
		// [XID] // 0x0000000189603CC0-0x0000000189603D00
		public static IEnumerator IterMoveToPositionAndLookAtNextPos(Vector3 telPos, Vector3 lookAtPos, IEnumerator inEnumTel) => default; // 0x0000000181ACF930-0x0000000181ACFA90
		// [XID] // 0x000000018960E430-0x000000018960E450
		public static void MoveToPositionAndLookAtNextPos(Vector3 telPos, Vector3 lookAtPos, IEnumerator inEnumTel) {} // 0x0000000181AD01B0-0x0000000181AD0390
		[DebuggerHidden] // 0x0000000189615A80-0x0000000189615AC0
		// [XID] // 0x0000000189615A80-0x0000000189615AC0
		public static IEnumerator IterWaitAndResetCamera(float lastSeconds) => default; // 0x0000000181ACFC20-0x0000000181ACFD30
		// [XID] // 0x0000000189620370-0x0000000189620390
		public static void SetCleanStreamingTestModeLevel(int level) {} // 0x0000000181AD0910-0x0000000181AD0A00
		// [XID] // 0x00000001896277B0-0x00000001896277D0
		public static void LookAtPosition(Vector3 targetPos, float cameraDistance) {} // 0x0000000181ACFD30-0x0000000181AD01B0
		[DebuggerHidden] // 0x000000018962F270-0x000000018962F2B0
		// [XID] // 0x000000018962F270-0x000000018962F2B0
		private static IEnumerator COBenchmarkCameraRotation(float angle, float deltaSecond) => default; // 0x0000000181ACECF0-0x0000000181ACEE10
		// [XID] // 0x0000000189639AB0-0x0000000189639AD0
		public static void StatLightActivatedBonePos(uint entityConfigID, string socketName, float distance) {} // 0x0000000181AD28D0-0x0000000181AD2A20
		[DebuggerHidden] // 0x0000000189640FC0-0x0000000189641000
		// [XID] // 0x0000000189640FC0-0x0000000189641000
		private static IEnumerator COStatLightActivatedBonePos(uint entityConfigID, string socketName, float distance) => default; // 0x0000000181ACEE10-0x0000000181ACEF50
		// [XID] // 0x000000018964BA30-0x000000018964BA50
		public static void ResetGrassBurningState() {} // 0x0000000181AD0650-0x0000000181AD0710
		// [XID] // 0x00000001896531A0-0x00000001896531C0
		public static void SetTerrainBaseMapDist(float inDistance) {} // 0x0000000181AD2240-0x0000000181AD2350
		// [XID] // 0x000000018965A880-0x000000018965A8A0
		public static void DebugAnimatorCount() {} // 0x0000000181ACEF50-0x0000000181ACF070
	}
}
