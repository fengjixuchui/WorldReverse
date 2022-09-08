/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class CameraPostprocessUtils // TypeDefIndex: 31548
{
	// Fields
	private static PostProcessLayer _postFXLayer; // 0x00
	private static Camera _mainCamera; // 0x08
	private static bool _motionBlurState; // 0x10
	private static MotionBlur _motionBlur; // 0x18
	private static MHYBloom _bloom; // 0x20
	private static MHYDepthOfField _mhyDepthOfField; // 0x28
	private static bool _lockExternalMotionBlur; // 0x30
	private static bool _enableTimelineChangeMotionBlur; // 0x31
	private const int SHADOW_QUALITY_HIGHT = 2; // Metadata: 0x00B1293D
	private static int _defaultShadowQuality; // 0x34
	private static readonly Vector3 SHADOW_SPLIT_SCALE; // 0x38
	private static Vector3 _defaultShadowSplit; // 0x44
	private static FrameTransition _frameTransition; // 0x50

	// Properties
	private static PostProcessLayer postFXLayer { /* [XID] */ /* 0x000000018997DB30-0x000000018997DB50 */ get; } // 0x000000018237DEF0-0x000000018237E2E0 
	private static Camera mainCamera { /* [XID] */ /* 0x00000001899854A0-0x00000001899854C0 */ get; } // 0x000000018237D7C0-0x000000018237D930 
	private static PostProcessProfile postFXProfile { /* [XID] */ /* 0x000000018998D210-0x000000018998D230 */ get; } // 0x000000018237E530-0x000000018237E6C0 
	public static MHYDepthOfField mhyDepthOfField { /* [XID] */ /* 0x0000000189994D30-0x0000000189994D50 */ get; } // 0x000000018237D250-0x000000018237D440 
	public static MotionBlur motionBlur { /* [XID] */ /* 0x000000018999C610-0x000000018999C630 */ get; } // 0x000000018237CD10-0x000000018237CF00 
	public static bool isMotionBlurExternalLocked { /* [XID] */ /* 0x00000001899A40A0-0x00000001899A40C0 */ get; } // 0x000000018237D0F0-0x000000018237D1C0 
	public static bool isTimelineChangeMotionBlurEnable { /* [XID] */ /* 0x00000001899B3450-0x00000001899B3470 */ get; } // 0x000000018237CAB0-0x000000018237CB80 
	public static MHYBloom bloom { /* [XID] */ /* 0x00000001899D1050-0x00000001899D1070 */ get; } // 0x000000018237CF00-0x000000018237D0F0 
	public static FrameTransition frameTransition { /* [XID] */ /* 0x0000000189A3EE00-0x0000000189A3EE20 */ get; } // 0x000000018237BB30-0x000000018237BD20 

	// Constructors
	static CameraPostprocessUtils() {} // 0x000000018237E850-0x000000018237EA30

	// Methods
	// [XID] // 0x00000001899ABA70-0x00000001899ABA90
	public static void LockExternalMotionBlur(bool enable) {} // 0x000000018237C9E0-0x000000018237CAB0
	// [XID] // 0x00000001899BA770-0x00000001899BA790
	public static void EnableTimeLineChangeMotionBlur(bool enable) {} // 0x000000018237E2E0-0x000000018237E3B0
	// [XID] // 0x00000001899C20B0-0x00000001899C20D0
	public static void EnableMotionBlur(bool enable, bool softEnable = true /* Metadata: 0x00B1293A */) {} // 0x000000018237D9F0-0x000000018237DCC0
	// [XID] // 0x00000001899C97B0-0x00000001899C97D0
	public static void EnableMotionBlurDelay(bool enable, bool softEnable = true /* Metadata: 0x00B1293B */) {} // 0x000000018237C840-0x000000018237C9E0
	// [XID] // 0x00000001899D8540-0x00000001899D8560
	public static void RequestScreenInnerCapture(Action<RenderTexture> callback) {} // 0x000000018237BD20-0x000000018237BF30
	// [IDTag] // 0x00000001899DFBB0-0x00000001899DFBF0
	// [XID] // 0x00000001899DFBB0-0x00000001899DFBF0
	public static void RequestScreenCapture(GameObject obj, Action<PostProcessLayer, RenderTexture> callback) {} // 0x000000018237C040-0x000000018237C1A0
	// [IDTag] // 0x00000001899EA270-0x00000001899EA2B0
	// [XID] // 0x00000001899EA270-0x00000001899EA2B0
	public static void RequestScreenCapture(PostProcessLayer pfxLayer, GameObject obj, Action<PostProcessLayer, RenderTexture> callback) {} // 0x000000018237BF30-0x000000018237C040
	// [XID] // 0x00000001899F4EE0-0x00000001899F4F00
	public static void ReleaseScreenCapture(PostProcessLayer pfxLayer, GameObject obj, RenderTexture texture) {} // 0x000000018237DCC0-0x000000018237DDD0
	// [XID] // 0x00000001899FC4D0-0x00000001899FC4F0
	public static void EnableCamera(bool enabled, bool enablePostLayer = false /* Metadata: 0x00B1293C */) {} // 0x000000018237D440-0x000000018237D7C0
	// [XID] // 0x0000000189A03AA0-0x0000000189A03AC0
	public static void ClearCameraCache() {} // 0x000000018237DDD0-0x000000018237DEF0
	// [XID] // 0x0000000189A0AFB0-0x0000000189A0AFD0
	public static void EnableUseShadowCache(bool value) {} // 0x000000018237C3A0-0x000000018237C4E0
	// [XID] // 0x0000000189A12920-0x0000000189A12940
	public static void EnableUseHalfShadows(bool value) {} // 0x000000018237B9F0-0x000000018237BB30
	// [XID] // 0x0000000189A19B50-0x0000000189A19B70
	private static void InitDefaultShadowQuality() {} // 0x000000018237CB80-0x000000018237CD10
	// [XID] // 0x0000000189A21150-0x0000000189A21170
	public static void EnableHighQualityShadow(bool value) {} // 0x000000018237C1A0-0x000000018237C3A0
	// [XID] // 0x0000000189A28700-0x0000000189A28720
	public static void EnableGPUCulling(bool value) {} // 0x000000018237C6B0-0x000000018237C840
	// [XID] // 0x0000000189A2FD50-0x0000000189A2FD70
	public static void ShutdownGPUCullingForAWhile() {} // 0x000000018237C4E0-0x000000018237C6B0
	// [XID] // 0x0000000189A376F0-0x0000000189A37710
	private static void ReEnableGPUCulling() {} // 0x000000018237D930-0x000000018237D9F0
	// [XID] // 0x0000000189A46510-0x0000000189A46530
	public static void EnableFrameTransition(bool value) {} // 0x000000018237E6C0-0x000000018237E850
	// [XID] // 0x0000000189A4DD00-0x0000000189A4DD20
	public static void UpdateFrameTransition(float value) {} // 0x000000018237E3B0-0x000000018237E530
	// [XID] // 0x0000000189A55510-0x0000000189A55530
	public static void Get() {} // 0x000000018237D1C0-0x000000018237D250
}

