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
using MoleMole;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CameraManager : GlobalManager // TypeDefIndex: 20678
{
	// Fields
	private CameraInputHelperZoom zoomSmoother; // 0x10
	private Vector2 _currentRotatelValue; // 0x18
	private Vector2 _targetRotateValue; // 0x20
	private const float MIN_ROTATE_VALUE_DISTANCE = 2E-05f; // Metadata: 0x00AFE033
	private const float ROTATE_VALUE_LERP_RATIO = 15f; // Metadata: 0x00AFE037
	private float _poleOffset; // 0x28
	private float time; // 0x2C
	private RenderTexture _cachedRenderTexture; // 0x30
	private UnityAction _onCaptureFinish; // 0x38
	private bool _isCapturing; // 0x40
	private bool _bCaptureFinished; // 0x41
	public bool requireRTRefresh; // 0x42
	private bool _isTextureStreamingCache; // 0x43
	private FixedStack<bool> _isMainCameraVisibleStack; // 0x48
	public static Camera _curCamera; // 0x00
	public static Camera _mainCamera; // 0x08
	public static Camera _mapCamera; // 0x10
	private static Camera _ui3dCamera; // 0x18
	public static string PostEffectAssetPath; // 0x20
	private CameraPostEffectPlayer _skillPostEffect; // 0x50
	private CameraPostEffectPlayer _stagePostEffect; // 0x58
	private CameraPostEffectPlayer _currentActive; // 0x60
	private InLevelShareDialogContext _shareContext; // 0x68
	private bool _hideInfo; // 0x70
	private bool _hasCameraEffect; // 0x71
	private Action _callback; // 0x78
	private string _cameraScreenEffectPath; // 0x80
	private string _cameraUIEffectPath; // 0x88
	private uint _cameraUIEffectHandler; // 0x90
	private GameObject _cameraUIEffectGO; // 0x98
	private string _mainCameraEffectPath; // 0xA0
	private uint _mainCameraEffectHandler; // 0xA8
	private GameObject _mainCameraEffectGO; // 0xB0
	private RenderTexture _savedImageTexture; // 0xB8
	private UnityEngine.Material _blurMat; // 0xC0

	// Properties
	public RenderTexture CachedRenderTexture { /* [XID] */ /* 0x0000000189707540-0x0000000189707560 */ get => default; } // 0x0000000182672E10-0x0000000182672EB0 
	public static Camera curCamera { /* [XID] */ /* 0x000000018974E850-0x000000018974E870 */ get => default; /* [XID] */ /* 0x0000000189781DC0-0x0000000189781DE0 */ set {} } // 0x0000000182671A00-0x0000000182671AD0 0x000000018266F7F0-0x000000018266F980
	public static Camera mainCamera { /* [XID] */ /* 0x00000001897891C0-0x00000001897891E0 */ get => default; /* [XID] */ /* 0x00000001897907F0-0x0000000189790810 */ set {} } // 0x0000000182674090-0x0000000182674200 0x00000001826739E0-0x0000000182673BC0
	public static Camera mapCamera { /* [XID] */ /* 0x00000001897ACC40-0x00000001897ACC60 */ get => default; /* [XID] */ /* 0x000000018979FFB0-0x000000018979FFD0 */ set {} } // 0x00000001826746E0-0x00000001826747B0 0x0000000182671310-0x0000000182671450
	public static Camera ui3dCamera { /* [XID] */ /* 0x00000001898476D0-0x00000001898476F0 */ get => default; /* [XID] */ /* 0x00000001897AEFF0-0x00000001897AF010 */ set {} } // 0x000000018266FF40-0x0000000182670010 0x0000000182670010-0x0000000182670150
	public CameraEntity CameraEntity { /* [XID] */ /* 0x00000001897B6C80-0x00000001897B6CA0 */ get => default; } // 0x0000000182671800-0x00000001826718E0 
	public VCStackCamera stackCamera { /* [XID] */ /* 0x00000001897BECB0-0x00000001897BECD0 */ get => default; } // 0x0000000182673900-0x00000001826739E0 

	// Nested types
	public enum EnableMainCameraType // TypeDefIndex: 20679
	{
		Default = 0,
		Loading = 1,
		UIPage = 2,
		UIScene = 3,
		Map = 4,
		Gacha = 5,
		Cutscene = 6,
		Count = 7
	}

	private class CameraPostEffectPlayer // TypeDefIndex: 20680
	{
		// Fields
		private string _currAssetname; // 0x10
		private uint _assetHandle; // 0x18
		private ActCameraEffectMatConfig _currPostEffectAsset; // 0x20
		private UnityEngine.Material _currPostEffectMaterial; // 0x28
		private AsyncJob? _loadingJob; // 0x30
		private float _currTime; // 0x48
		private float _fadeinTime; // 0x4C
		private float _fadeoutTime; // 0x50
		private float _fadeoutDuration; // 0x54
		private float _duration; // 0x58
		private bool _needTickClear; // 0x5C

		// Constructors
		public CameraPostEffectPlayer() {} // 0x0000000182675C00-0x0000000182675D50

		// Methods
		// [XID] // 0x0000000189845230-0x0000000189845250
		public bool CheckActive() => default; // 0x0000000182675860-0x0000000182675930
		// [XID] // 0x000000018984C720-0x000000018984C740
		public void ApplyToCamera() {} // 0x0000000182675A50-0x0000000182675C00
		// [XID] // 0x00000001898537A0-0x00000001898537C0
		public void SetPostEffect(string assetName, float duration) {} // 0x0000000182675520-0x0000000182675720
		// [XID] // 0x000000018985B250-0x000000018985B270
		private void OnPostEffectLoaded(ulong pathHash, bool loadSucceeded, uint handle, ActCameraEffectMatConfig prefab) {} // 0x0000000182674D70-0x00000001826750F0
		// [XID] // 0x0000000189862790-0x00000001898627B0
		public void ClearPostEffect(string assetName, bool needFadeout) {} // 0x0000000182674C80-0x0000000182674D70
		// [XID] // 0x0000000189869B80-0x0000000189869BA0
		public void ClearCurrentPostEffect(bool needFadeout = false /* Metadata: 0x00AFE05B */) {} // 0x0000000182675720-0x0000000182675860
		// [XID] // 0x0000000189870F20-0x0000000189870F40
		private void DoClearCurrentPostEffect() {} // 0x0000000182675930-0x0000000182675A50
		// [XID] // 0x00000001898788D0-0x00000001898788F0
		private void SetPostEffectMaterial(UnityEngine.Material matInstance) {} // 0x0000000182675400-0x0000000182675520
		// [XID] // 0x000000018987FEA0-0x000000018987FEC0
		public void Tick() {} // 0x00000001826750F0-0x0000000182675400
	}

	// Constructors
	public CameraManager() {} // 0x0000000182674A30-0x0000000182674B50
	static CameraManager() {} // 0x0000000182674980-0x0000000182674A30

	// Methods
	// [XID] // 0x00000001896ABC70-0x00000001896ABC90
	public override void Init() {} // 0x0000000182672B80-0x0000000182672D10
	// [XID] // 0x00000001896B2E10-0x00000001896B2E30
	public void Stop() {} // 0x000000018266F980-0x000000018266FA30
	// [XID] // 0x00000001896BA550-0x00000001896BA570
	public void ZoomCamera(float delta) {} // 0x000000018266FA30-0x000000018266FAF0
	// [XID] // 0x00000001896C1720-0x00000001896C1740
	public void RotateCamera(Vector2 delta, bool needAdjust, bool needScale = true /* Metadata: 0x00AFE02C */) {} // 0x0000000182673590-0x0000000182673900
	// [XID] // 0x00000001896C8E80-0x00000001896C8EA0
	private void KeyboardRotateCamera(Vector2 delta, bool needAdjust, bool needScale) {} // 0x0000000182670750-0x0000000182670A50
	// [XID] // 0x00000001896D0800-0x00000001896D0820
	public void MoveCamera(Vector2 delta) {} // 0x00000001826718E0-0x0000000182671A00
	// [XID] // 0x00000001896D7D10-0x00000001896D7D30
	public void SetRefAnchorPosition(Vector3 pos) {} // 0x0000000182672930-0x0000000182672A80
	// [XID] // 0x00000001896DF600-0x00000001896DF620
	public void SetCameraPosition(Vector3 pos) {} // 0x00000001826724B0-0x0000000182672600
	// [XID] // 0x00000001896E6940-0x00000001896E6960
	public void SetClampRotatePitch(Vector2 clampVal) {} // 0x0000000182671450-0x0000000182671570
	// [XID] // 0x00000001896EDF30-0x00000001896EDF50
	public void SetClampZoomScale(Vector2 clampVal) {} // 0x0000000182670150-0x0000000182670270
	// [XID] // 0x00000001896F5750-0x00000001896F5770
	public void ResetCamera(float poleOffset = 0f /* Metadata: 0x00AFE02D */) {} // 0x0000000182673F20-0x0000000182674090
	[DebuggerHidden] // 0x00000001896FCFB0-0x00000001896FCFF0
	// [XID] // 0x00000001896FCFB0-0x00000001896FCFF0
	public IEnumerator LerpResetCameraToAvatarBackward(float totalTime) => default; // 0x0000000182673E00-0x0000000182673F20
	// [XID] // 0x000000018970EE20-0x000000018970EE40
	public void RequireRenderTexture(UnityAction callback) {} // 0x0000000182674200-0x0000000182674470
	// [XID] // 0x0000000189716260-0x0000000189716280
	private void OnCaptureInternal(PostProcessLayer layer, RenderTexture capture) {} // 0x0000000182672EB0-0x0000000182673140
	// [XID] // 0x000000018971DCA0-0x000000018971DCC0
	private void CheckCacheTextureStreaming(bool enable, EnableMainCameraType type) {} // 0x000000018266FAF0-0x000000018266FC30
	// [XID] // 0x0000000189725180-0x00000001897251A0
	private void InitAyncLoad() {} // 0x0000000182670E10-0x0000000182670F20
	// [XID] // 0x000000018994AC90-0x000000018994ACB0
	public void EnableMainCamera(bool enable, EnableMainCameraType type, bool takeScreenShot = false /* Metadata: 0x00AFE031 */) {} // 0x0000000182672250-0x00000001826724B0
	// [XID] // 0x0000000189733F70-0x0000000189733F90
	private void CheckMainCameraEnable() {} // 0x0000000182671AD0-0x0000000182671D50
	// [XID] // 0x00000001899CAC40-0x00000001899CAC60
	public void EnableMainCameraCinemachine(bool visible) {} // 0x0000000182671FB0-0x0000000182672250
	// [XID] // 0x00000001897431C0-0x00000001897431E0
	public override void Tick() {} // 0x00000001826748B0-0x0000000182674980
	// [XID] // 0x000000018974AD40-0x000000018974AD60
	public override void Destroy() {} // 0x0000000182671030-0x00000001826710D0
	// [XID] // 0x0000000189751DF0-0x0000000189751E10
	public override void InitOnConnect() {} // 0x0000000182672AE0-0x0000000182672B80
	// [XID] // 0x00000001897594A0-0x00000001897594C0
	public override void ClearOnDisconnect() {} // 0x0000000182670A50-0x0000000182670AF0
	// [XID] // 0x0000000189761090-0x00000001897610B0
	public override void ClearOnLevelDestroy() {} // 0x0000000182670AF0-0x0000000182670BF0
	// [XID] // 0x00000001897683E0-0x0000000189768400
	public override void ReloadRes() {} // 0x0000000182674810-0x00000001826748B0
	[Preserve] // 0x000000018976FAD0-0x000000018976FB10
	// [XID] // 0x000000018976FAD0-0x000000018976FB10
	public override string Dump(string tag) => default; // 0x00000001826710D0-0x0000000182671310
	// [XID] // 0x00000001897C6150-0x00000001897C6170
	public void SetPostEffect(string assetName, float duration, bool isStageEffect) {} // 0x0000000182672D10-0x0000000182672E10
	// [XID] // 0x00000001897CDA00-0x00000001897CDA20
	public void ClearPostEffect(string assetName, bool isStageEffect, bool needFadeout) {} // 0x0000000182670F20-0x0000000182671030
	// [XID] // 0x00000001897D4F70-0x00000001897D4F90
	public void ClearSkillPostEffect() {} // 0x0000000182674470-0x0000000182674520
	// [XID] // 0x00000001897DC710-0x00000001897DC730
	private void ClearAllPostEffect() {} // 0x0000000182671570-0x0000000182671640
	// [XID] // 0x00000001897E4110-0x00000001897E4130
	private void TickPostEffect() {} // 0x0000000182673440-0x0000000182673590
	// [XID] // 0x00000001897EBC40-0x00000001897EBC60
	public PostProcessLayer GetPostProcessLayer() => default; // 0x0000000182670BF0-0x0000000182670D50
	// [XID] // 0x00000001897F3590-0x00000001897F35B0
	public void TakePhotograph(bool hideInfo, bool hasCameraEffect = false /* Metadata: 0x00AFE032 */, string cameraUIEffectPath = null, string cameraScreenEffectPath = null, string mainCameraEffectPath = null, Action callback = null) {} // 0x0000000182670340-0x0000000182670750
	// [XID] // 0x00000001897FAF70-0x00000001897FAF90
	private void CheckCustomEffectLoaded() {} // 0x0000000182673BC0-0x0000000182673E00
	// [XID] // 0x00000001898023F0-0x0000000189802410
	private void ScreenCapture() {} // 0x0000000182674520-0x00000001826746E0
	// [XID] // 0x0000000189809820-0x0000000189809840
	private void OnPhotographTaken(PostProcessLayer layer, RenderTexture capture) {} // 0x0000000182673140-0x0000000182673440
	// [XID] // 0x0000000189810FD0-0x0000000189810FF0
	private void AddCameraUIEffect() {} // 0x0000000182672600-0x0000000182672850
	// [XID] // 0x0000000189818B70-0x0000000189818B90
	private void ShowShareDialog() {} // 0x00000001826716A0-0x0000000182671800
	// [XID] // 0x0000000189820390-0x00000001898203B0
	private void SetRenderTexture() {} // 0x0000000182670270-0x0000000182670340
	// [XID] // 0x0000000189827A10-0x0000000189827A30
	private void ReleaseCameraEffect() {} // 0x000000018266FC30-0x000000018266FF40
	// [XID] // 0x000000018982EC70-0x000000018982EC90
	private void OnRelease() {} // 0x0000000182670D50-0x0000000182670E10
	// [XID] // 0x00000001898365D0-0x00000001898365F0
	private bool PointInScreen(Vector2 point) => default; // 0x0000000182672850-0x0000000182672930
	// [XID] // 0x000000018983D9C0-0x000000018983D9E0
	public bool CheckPointInScreen(Vector3 targetPos) => default; // 0x0000000182671D50-0x0000000182671F30
}

