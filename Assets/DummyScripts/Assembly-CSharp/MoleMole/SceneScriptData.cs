/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class SceneScriptData : ScriptableObjectUseFiEdit // TypeDefIndex: 19595
	{
		// Fields
		public string LevelTagName; // 0x18
		public string ScenePath; // 0x20
		public string EnvironmentPath; // 0x28
		public string EnviroDefaultProfile; // 0x30
		public string NavmeshPath; // 0x38
		public string SSSProfilesPath; // 0x40
		public bool autoUnloadColliderMeshRenderData; // 0x48
		public Vector3 PlayBonePos; // 0x4C
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MapScriptData _mapInfoData; // 0x58
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public string LuaPath; // 0x60
		public GlobalVars.WorldType worldType; // 0x68
		public GlobalVars.LevelSubType levelSubType; // 0x6C
		public StageType stageType; // 0x70
		public float lodFadeDuration; // 0x74
		public bool timeProcess; // 0x78
		public float lockedTimeOfDay; // 0x7C
		public bool forceEnableDynamicLight; // 0x80
		public bool forceEnableDynamicShadow; // 0x81
		public int stageAudioId; // 0x84
		public string[] boundaries; // 0x88
		// [Header] // 0x00000001896502E0-0x0000000189650310
		public bool useEffectZTest; // 0x90
	
		// Properties
		public MapScriptData mapInfoData { /* [XID] */ /* 0x0000000189659450-0x0000000189659470 */ get => default; } // 0x0000000184EEFDE0-0x0000000184EEFE80 
	
		// Constructors
		public SceneScriptData() {} // 0x0000000184EEFCF0-0x0000000184EEFDE0
	}
}
