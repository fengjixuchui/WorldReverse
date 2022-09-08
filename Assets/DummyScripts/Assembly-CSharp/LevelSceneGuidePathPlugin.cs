/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneGuidePathPlugin : BaseComponentPlugin // TypeDefIndex: 12083
{
	// Fields
	private static int MAX_VFX_COUNT; // 0x00
	private static float UPDATE_INTERVAL_AUTO_ADJUST; // 0x04
	private static float UPDATE_INTERVAL_EXTERNAL_UPDATE; // 0x08
	private LevelTrafficPlugin _trafficPlugin; // 0x58
	private List<LevelTrafficPlugin.TrafficNode> _rawPath; // 0x60
	private List<Vector3> _completePath; // 0x68
	private List<Vector3> _smoothPath; // 0x70
	private bool _activated; // 0x78
	private bool _hasData; // 0x79
	private Vector3 _curGoal; // 0x7C
	private Vector3 _curStartReqAvatarPos; // 0x88
	private float _nextTickExternalUpdate; // 0x94
	private float _nextTickInternalPathAutoAdjust; // 0x98
	private float? _nextTickInternalPathAutoClose; // 0x9C
	private GuidePathSetting _guidePathSetting; // 0xA4
	private static string POINTS_EFFECT_PATH; // 0x10
	private static string PILLAR_EFFECT_PATH; // 0x18
	private MonoEffectProxy[] _pointsVfx; // 0xC0
	private VFXState _pointsVfxState; // 0xC8
	private float _pointsDestroyTick; // 0xCC
	private int _pointVfxCurrentAmount; // 0xD0
	private MonoEffectProxy _pillarVfx; // 0xD8
	private VFXState _pillarVfxState; // 0xE0
	private float _pillarDestroyTick; // 0xE4

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001895F41F0-0x00000001895F4210 */ get => default; } // 0x00000001818B5FA0-0x00000001818B6040 
	public bool activated { /* [XID] */ /* 0x00000001895FBA20-0x00000001895FBA40 */ get => default; } // 0x00000001818B3CF0-0x00000001818B3D90 
	public bool isPillarVfxActive { /* [XID] */ /* 0x0000000189646860-0x0000000189646880 */ get => default; } // 0x00000001818B4FB0-0x00000001818B5060 

	// Nested types
	private struct GuidePathSetting // TypeDefIndex: 12084
	{
		// Fields
		public float startPathfindingDistance; // 0x00
		public float stopPathfindingDistance; // 0x04
		public float pillarMinDistance; // 0x08
		public float pillarMaxDistance; // 0x0C
		public float navPointSearchDistance; // 0x10
		public float autoCloseTime; // 0x14
	}

	private enum VFXState // TypeDefIndex: 12085
	{
		ON = 0,
		VANISHING = 1,
		OFF = 2
	}

	private static class SmoothingTool // TypeDefIndex: 12086
	{
		// Fields
		private static float segmentLength; // 0x00
		private static Vector3 p0; // 0x04
		private static Vector3 p1; // 0x10
		private static Vector3 p2; // 0x1C
		private static Vector3 p3; // 0x28

		// Constructors
		static SmoothingTool() {} // 0x00000001818CB4D0-0x00000001818CB530

		// Methods
		// [XID] // 0x00000001896A68C0-0x00000001896A68E0
		public static void Smooth(Vector3 cp0, Vector3 cp1, Vector3 cp2, Vector3 cp3, ref List<Vector3> smoothedResult) {} // 0x00000001818CB110-0x00000001818CB320
		// [XID] // 0x00000001896ADFB0-0x00000001896ADFD0
		private static void CatmulRom(ref List<Vector3> smoothedResult) {} // 0x00000001818CA830-0x00000001818CB110
		// [XID] // 0x00000001896B5640-0x00000001896B5660
		private static float GetT(float t, Vector3 p0, Vector3 p1) => default; // 0x00000001818CB320-0x00000001818CB4D0
	}

	// Constructors
	public LevelSceneGuidePathPlugin() {} // 0x00000001818B5E00-0x00000001818B5FA0
	static LevelSceneGuidePathPlugin() {} // 0x00000001818B5D60-0x00000001818B5E00

	// Methods
	// [XID] // 0x0000000189603180-0x00000001896031A0
	public override void Init() {} // 0x00000001818B40E0-0x00000001818B4570
	// [XID] // 0x000000018960ABA0-0x000000018960ABC0
	public override void Tick(float inDeltaTime) {} // 0x00000001818B5820-0x00000001818B5D60
	// [XID] // 0x0000000189612150-0x0000000189612170
	public override void Destroy() {} // 0x00000001818B3460-0x00000001818B3520
	// [XID] // 0x0000000189619AD0-0x0000000189619AF0
	public GuidePathResult StartNavigation(Vector3 goal) => default; // 0x00000001818B3D90-0x00000001818B3F90
	// [XID] // 0x0000000189620F70-0x0000000189620F90
	public GuidePathResult UpdateNavigation(Vector3 goal) => default; // 0x00000001818B5060-0x00000001818B51F0
	// [XID] // 0x0000000189628700-0x0000000189628720
	public void StopNavigation() {} // 0x00000001818B3F90-0x00000001818B40E0
	// [XID] // 0x000000018962FFF0-0x0000000189630010
	private GuidePathResult RefreshPath(Vector3 goal) => default; // 0x00000001818B4AC0-0x00000001818B4E10
	// [XID] // 0x0000000189637CE0-0x0000000189637D00
	private void OnFindPathResult(bool result, List<Vector3> resultPath) {} // 0x00000001818B51F0-0x00000001818B5820
	// [XID] // 0x000000018963EF30-0x000000018963EF50
	private bool CheckShowPillar() => default; // 0x00000001818B2D90-0x00000001818B2FD0
	// [XID] // 0x000000018964DFC0-0x000000018964DFE0
	private void SwitchPillarVfx(bool enable) {} // 0x00000001818B4570-0x00000001818B46F0
	// [XID] // 0x0000000189655870-0x0000000189655890
	private void SwitchPointsVfx(bool enable) {} // 0x00000001818B4750-0x00000001818B4AC0
	// [XID] // 0x000000018965D060-0x000000018965D080
	private void VanishPointsVfx() {} // 0x00000001818B3120-0x00000001818B3290
	// [XID] // 0x00000001896645F0-0x0000000189664610
	private void VanishPillarVfx() {} // 0x00000001818B4E10-0x00000001818B4F40
	// [XID] // 0x000000018966BC10-0x000000018966BC30
	private void RenderPillar() {} // 0x00000001818B2FD0-0x00000001818B3120
	// [XID] // 0x0000000189673A40-0x0000000189673A60
	private void RenderPath() {} // 0x00000001818B3780-0x00000001818B3B80
	// [XID] // 0x000000018967B140-0x000000018967B160
	private void MoveEffectToDefault(MonoEffectProxy effect) {} // 0x00000001818B3610-0x00000001818B3780
	// [XID] // 0x0000000189682A40-0x0000000189682A60
	private void MoveEffectTo(MonoEffectProxy effect, Vector3 to, Vector3 dir) {} // 0x00000001818B3290-0x00000001818B3460
	// [XID] // 0x000000018968A600-0x000000018968A620
	private bool LoadGuidePathSetting(uint sceneID) => default; // 0x00000001818B2AD0-0x00000001818B2D90
}

