/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct StatFrameData // TypeDefIndex: 27834
{
	// Fields
	public double frameTime; // 0x00
	public double gameTime; // 0x08
	public double physicsTime; // 0x10
	public double animationTime; // 0x18
	public double renderTime; // 0x20
	public double coroutineFixedUpdate; // 0x28
	public double coroutineUpdate; // 0x30
	public double coroutineLateUpdate; // 0x38
	public double particleTime; // 0x40
	public double playerUpdateCanvasTime; // 0x48
	public double canvasManagerEmitOffScreenGeometryTime; // 0x50
	public double updateAllUpdateAllRenderersTime; // 0x58
	public double updateAllSkinnedMeshesTime; // 0x60
	public double aiUpdateTime; // 0x68
	public double renderCommandThreadTime; // 0x70
	public double drawCalls; // 0x78
	public int drawPrims; // 0x80
	public int dynamicObjects; // 0x84
	public double rtLoadStoreBandWidth; // 0x88
	public double totalSystemMemory; // 0x90
	public long reservedTotalMemory; // 0x98
	public long reservedUnityMemory; // 0xA0
	public long reservedMonoMemory; // 0xA8
	public long reservedGfxMemory; // 0xB0
	public long reservedProfilerMemory; // 0xB8
	public long textureMemory; // 0xC0
	public long meshMemory; // 0xC8
	public long clipMemory; // 0xD0
	public string snapShotUrl; // 0xD8
	public double GfxPresentFrame; // 0xE0
	public double GfxWaitForPresent; // 0xE8
	private static bool _enableGPU; // 0x00
	public float totalGPUTime; // 0xF0

	// Properties
	public static bool enableGPU { /* [XID] */ /* 0x0000000189B2EF10-0x0000000189B2EF30 */ get => default; /* [XID] */ /* 0x0000000189B36850-0x0000000189B36870 */ set {} } // 0x0000000183EE3820-0x0000000183EE38D0 0x0000000183EE38D0-0x0000000183EE3D50

	// Constructors
	public StatFrameData(bool bNeedFetchDataFromRuntimProfiler) : this() {
		frameTime = default;
		gameTime = default;
		physicsTime = default;
		animationTime = default;
		renderTime = default;
		coroutineFixedUpdate = default;
		coroutineUpdate = default;
		coroutineLateUpdate = default;
		particleTime = default;
		playerUpdateCanvasTime = default;
		canvasManagerEmitOffScreenGeometryTime = default;
		updateAllUpdateAllRenderersTime = default;
		updateAllSkinnedMeshesTime = default;
		aiUpdateTime = default;
		renderCommandThreadTime = default;
		drawCalls = default;
		drawPrims = default;
		dynamicObjects = default;
		rtLoadStoreBandWidth = default;
		totalSystemMemory = default;
		reservedTotalMemory = default;
		reservedUnityMemory = default;
		reservedMonoMemory = default;
		reservedGfxMemory = default;
		reservedProfilerMemory = default;
		textureMemory = default;
		meshMemory = default;
		clipMemory = default;
		snapShotUrl = default;
		GfxPresentFrame = default;
		GfxWaitForPresent = default;
		totalGPUTime = default;
	} // 0x0000000183EE3D50-0x0000000183EE4090
}

