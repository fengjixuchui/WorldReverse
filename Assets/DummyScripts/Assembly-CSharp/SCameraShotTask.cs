/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using miHoYoCamera;
using MoleMole;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SCameraShotTask // TypeDefIndex: 32053
{
	// Fields
	private static Dictionary<int, GameObject> _shotInstCache; // 0x00
	private static Dictionary<int, Dictionary<string, List<TrackAsset>>> _shotTrackAssetCahce; // 0x08
	private static Dictionary<string, ScameraCineStatePage> _shotCfgCache; // 0x10
	protected CinemachineBrain _brain; // 0x10
	protected SCameraShotScriptData _shotCfgData; // 0x18
	protected PlayableDirector _director; // 0x20
	private string _cfgPath; // 0x28
	protected List<CinemachineVirtualCameraBase> _vcamList; // 0x30
	private CinemachineVirtualCameraBase _mainVCam; // 0x38
	protected CinemachineTransposer _transposerCache; // 0x40
	protected CinemachineComposer _composerCache; // 0x48
	private bool _isStarted; // 0x50
	private bool _dataInited; // 0x51
	private Action _onStartHandler; // 0x58
	private bool _isExternalFinished; // 0x60
	private bool _isFinished; // 0x61
	private double _duration; // 0x68
	private double _cnt; // 0x70
	private int _priority; // 0x78
	private bool _isPersistent; // 0x7C
	private uint _fromID; // 0x80
	private Vector2 _refAnchorAngularVelocity; // 0x84
	public CameraStateData stateData; // 0x90

	// Properties
	public CinemachineVirtualCameraBase mainVCam { /* [XID] */ /* 0x000000018973CB10-0x000000018973CB30 */ get => default; } // 0x0000000181C17860-0x0000000181C17900 
	public CinemachineTransposer transposer { /* [XID] */ /* 0x000000018969E180-0x000000018969E1A0 */ get => default; } // 0x0000000181C181D0-0x0000000181C18370 
	public CinemachineComposer composer { /* [XID] */ /* 0x000000018974BDB0-0x000000018974BDD0 */ get => default; } // 0x0000000181C1CF30-0x0000000181C1D0D0 
	public bool isStarted { /* [XID] */ /* 0x0000000189753090-0x00000001897530B0 */ get => default; } // 0x0000000181C1D340-0x0000000181C1D3E0 
	public bool isNotStarted { /* [XID] */ /* 0x000000018975A3B0-0x000000018975A3D0 */ get => default; } // 0x0000000181C1CAC0-0x0000000181C1CB70 
	public bool dataInited { /* [XID] */ /* 0x000000018980D540-0x000000018980D560 */ get => default; /* [XID] */ /* 0x00000001897E7D10-0x00000001897E7D30 */ set {} } // 0x0000000181C1CE90-0x0000000181C1CF30 0x0000000181C1CB70-0x0000000181C1CC20
	public bool isExternalFinished { /* [XID] */ /* 0x0000000189778640-0x0000000189778660 */ get => default; } // 0x0000000181C1D650-0x0000000181C1D6F0 
	public bool isFinished { /* [XID] */ /* 0x000000018977FB80-0x000000018977FBA0 */ get => default; } // 0x0000000181C1BB00-0x0000000181C1BBA0 
	public int priority { /* [XID] */ /* 0x0000000189787410-0x0000000189787430 */ get => default; } // 0x0000000181C1B870-0x0000000181C1B910 
	public bool isPersistent { /* [XID] */ /* 0x000000018978EA90-0x000000018978EAB0 */ get => default; } // 0x0000000181C193A0-0x0000000181C19440 
	public CameraStateBlenderConfig blenderConfig { /* [XID] */ /* 0x00000001897A5A90-0x00000001897A5AB0 */ get => default; } // 0x0000000181C18E50-0x0000000181C18F00 
	public CameraStateBlenderConfig exitConfig { /* [XID] */ /* 0x00000001895FA2E0-0x00000001895FA300 */ get => default; } // 0x0000000181C1C340-0x0000000181C1C3F0 

	// Nested types
	public struct AsyncCfgLoadData // TypeDefIndex: 32054
	{
		// Fields
		public string shotName; // 0x00
		public Action finishCallback; // 0x08

		// Constructors
		public AsyncCfgLoadData(string shotName, Action finishCallback) {
			this.shotName = default;
			this.finishCallback = default;
		} // 0x0000000181C10DC0-0x0000000181C10EE0
	}

	public struct AsyncInstData // TypeDefIndex: 32055
	{
		// Fields
		public int instanceID; // 0x00
		public Action finishCallback; // 0x08

		// Constructors
		public AsyncInstData(int instanceID, Action finishCallback) {
			this.instanceID = default;
			this.finishCallback = default;
		} // 0x0000000181C10EE0-0x0000000181C10FA0
	}

	private class ScameraCineStatePage : AssetLoadBase2<SCameraShotScriptData> // TypeDefIndex: 32056
	{
		// Constructors
		public ScameraCineStatePage() {} // Dummy constructor
		public ScameraCineStatePage(string path) {} // 0x0000000181C382F0-0x0000000181C38440

		// Methods
		// [XID] // 0x000000018989E380-0x000000018989E3A0
		public override void Clear() {} // 0x0000000181C37F00-0x0000000181C38060
		// [XID] // 0x00000001898A5E70-0x00000001898A5E90
		public bool ReleaseShot() => default; // 0x0000000181C37E40-0x0000000181C37F00
		// [XID] // 0x00000001898AD490-0x00000001898AD4B0
		public SCameraShotScriptData GetShotCfg(bool addRef = false /* Metadata: 0x00B13BCF */) => default; // 0x0000000181C380C0-0x0000000181C381A0
		// [XID] // 0x00000001898B49B0-0x00000001898B49D0
		public override void BeforeFinish() {} // 0x0000000181C38200-0x0000000181C382F0
	}

	// Constructors
	public SCameraShotTask() {} // 0x0000000181C1D7E0-0x0000000181C1D8F0
	static SCameraShotTask() {} // 0x0000000181C1D6F0-0x0000000181C1D7E0

	// Methods
	// [XID] // 0x00000001896D8ED0-0x00000001896D8EF0
	public static List<TrackAsset> GetTrackListByRoleName(GameObject shotInst, string roleName) => default; // 0x0000000181C1B4B0-0x0000000181C1B700
	// [XID] // 0x00000001896E0790-0x00000001896E07B0
	public static void InitTrackCache(GameObject shotInst) {} // 0x0000000181C18FE0-0x0000000181C192F0
	// [XID] // 0x00000001896E79A0-0x00000001896E79C0
	public static void ClearCache() {} // 0x0000000181C1A490-0x0000000181C1A8A0
	// [XID] // 0x0000000189B6C0F0-0x0000000189B6C110
	public static GameObject PrecacheShot(string shotName, bool addRef = false /* Metadata: 0x00B13BCC */) => default; // 0x0000000181C1CCC0-0x0000000181C1CDE0
	// [XID] // 0x0000000189B73910-0x0000000189B73930
	public static GameObject PrecacheShotByCfgPath(string cfgPath, bool addRef = false /* Metadata: 0x00B13BCD */) => default; // 0x0000000181C1D4F0-0x0000000181C1D650
	// [XID] // 0x00000001896FE2D0-0x00000001896FE2F0
	private static SCameraShotScriptData GetShotCfg(string path, bool addRef = false /* Metadata: 0x00B13BCE */) => default; // 0x0000000181C1B2F0-0x0000000181C1B4B0
	// [XID] // 0x0000000189705520-0x0000000189705540
	private static void ReleaseShotInst(int instanceID) {} // 0x0000000181C1AF10-0x0000000181C1B140
	// [IDTag] // 0x000000018970CF90-0x000000018970CFD0
	// [XID] // 0x000000018970CF90-0x000000018970CFD0
	public static GameObject GetShotInst(UnityEngine.Object shotPref) => default; // 0x0000000181C18430-0x0000000181C18780
	// [XID] // 0x00000001897172A0-0x00000001897172C0
	public static AsyncJob PrecacheShotAsyncWithJob(string shotName, Action finishCallback = null) => default; // 0x0000000181C17B00-0x0000000181C17D80
	// [XID] // 0x000000018971ED50-0x000000018971ED70
	public static void ReleaseShot(string shotName) {} // 0x0000000181C17E60-0x0000000181C180D0
	// [XID] // 0x00000001897262A0-0x00000001897262C0
	public static void ReleaseShotWithPath(string path) {} // 0x0000000181C19640-0x0000000181C19850
	// [XID] // 0x000000018972D8F0-0x000000018972D910
	public static void ClearOnLevelDestroy() {} // 0x0000000181C18370-0x0000000181C18430
	// [XID] // 0x0000000189735070-0x0000000189735090
	public static SCameraShotTask CreateTaskByPath(string path, CinemachineBrain brain) => default; // 0x0000000181C1B700-0x0000000181C1B870
	// [XID] // 0x00000001899495D0-0x00000001899495F0
	public void RegisterOnStartHandler(Action startAction) {} // 0x0000000181C1BA20-0x0000000181C1BB00
	// [XID] // 0x0000000189B79710-0x0000000189B79730
	public void SetParamByEvt(EvtCameraMove evt) {} // 0x0000000181C198F0-0x0000000181C199B0
	// [XID] // 0x000000018979E320-0x000000018979E340
	public void SetRefAnchorAngularVelocity(Vector2 velocity) {} // 0x0000000181C1CDE0-0x0000000181C1CE90
	// [XID] // 0x00000001897B4FA0-0x00000001897B4FC0
	public void UpdateExitPoleType(CameraStateBlenderConfig.PoleType poleType) {} // 0x0000000181C19440-0x0000000181C19500
	// [IDTag] // 0x00000001897BCC20-0x00000001897BCC60
	// [XID] // 0x00000001897BCC20-0x00000001897BCC60
	public GameObject GetShotInst() => default; // 0x0000000181C18780-0x0000000181C18A20
	// [XID] // 0x000000018991CBA0-0x000000018991CBC0
	public void Init(SCameraShotScriptData shotCfgData, CinemachineBrain brain, string cfgPath) {} // 0x0000000181C19500-0x0000000181C19640
	// [XID] // 0x00000001897CE860-0x00000001897CE880
	public void Start() {} // 0x0000000181C192F0-0x0000000181C193A0
	// [XID] // 0x00000001897D6020-0x00000001897D6040
	private void StartInternal() {} // 0x0000000181C1A3D0-0x0000000181C1A490
	// [XID] // 0x00000001897DD900-0x00000001897DD920
	public void CheckActive() {} // 0x0000000181C1B910-0x0000000181C1BA20
	// [XID] // 0x0000000189805D30-0x0000000189805D50
	private void StartCine() {} // 0x0000000181C1D0D0-0x0000000181C1D240
	// [XID] // 0x00000001897ECD80-0x00000001897ECDA0
	protected virtual void PrepareShot(GameObject shotInst) {} // 0x0000000181C180D0-0x0000000181C181D0
	// [XID] // 0x0000000189601C90-0x0000000189601CB0
	protected void PrepareBinding(GameObject shotInst) {} // 0x0000000181C18CB0-0x0000000181C18E50
	// [XID] // 0x000000018968F240-0x000000018968F260
	private Transform GetTransformByCfg(SCameraShotScriptData.TransType transType, string transName) => default; // 0x0000000181C18AC0-0x0000000181C18CB0
	// [XID] // 0x00000001896257F0-0x0000000189625810
	protected void PrepareParent(GameObject shotInst) {} // 0x0000000181C1A1D0-0x0000000181C1A3D0
	// [XID] // 0x00000001896BB460-0x00000001896BB480
	protected void PrepareBody(GameObject shotInst) {} // 0x0000000181C1C3F0-0x0000000181C1C9F0
	// [XID] // 0x00000001898120B0-0x00000001898120D0
	protected void PrepareLookAt(GameObject shotInst) {} // 0x0000000181C1A8A0-0x0000000181C1AAA0
	// [XID] // 0x00000001897C3CD0-0x00000001897C3CF0
	protected void PrepareInitPose(GameObject shotInst) {} // 0x0000000181C17900-0x0000000181C17B00
	// [XID] // 0x000000018977C780-0x000000018977C7A0
	protected void PreparePostprocess() {} // 0x0000000181C17D80-0x0000000181C17E60
	// [XID] // 0x0000000189687380-0x00000001896873A0
	public void Finish() {} // 0x0000000181C1D240-0x0000000181C1D340
	// [XID] // 0x000000018982FEE0-0x000000018982FF00
	protected void FinishInternal() {} // 0x0000000181C18A20-0x0000000181C18AC0
	// [XID] // 0x0000000189837620-0x0000000189837640
	public void FinishExternal() {} // 0x0000000181C1CC20-0x0000000181C1CCC0
	// [XID] // 0x00000001896A52B0-0x00000001896A52D0
	protected void FinishCine() {} // 0x0000000181C1D3E0-0x0000000181C1D4F0
	// [XID] // 0x0000000189846310-0x0000000189846330
	public bool IsPlaying() => default; // 0x0000000181C1BBA0-0x0000000181C1BC50
	// [XID] // 0x000000018984D8C0-0x000000018984D8E0
	public virtual void Tick() {} // 0x0000000181C19850-0x0000000181C198F0
	// [XID] // 0x0000000189854940-0x0000000189854960
	public virtual void LateTick() {} // 0x0000000181C1C9F0-0x0000000181C1CAC0
	// [XID] // 0x00000001897661F0-0x0000000189766210
	private void LateTickLogickInternal() {} // 0x0000000181C1C0A0-0x0000000181C1C340
	// [XID] // 0x0000000189643980-0x00000001896439A0
	private void LateTickTimeline() {} // 0x0000000181C1B140-0x0000000181C1B250
	// [XID] // 0x000000018986ADF0-0x000000018986AE10
	private void LateTickComposer() {} // 0x0000000181C1B250-0x0000000181C1B2F0
	// [XID] // 0x000000018964B020-0x000000018964B040
	private void LateTickTransposer() {} // 0x0000000181C19C50-0x0000000181C1A1D0
	// [XID] // 0x0000000189997690-0x00000001899976B0
	private bool CheckFinished() => default; // 0x0000000181C19A90-0x0000000181C19C50
	// [XID] // 0x0000000189880FA0-0x0000000189880FC0
	private void Clear() {} // 0x0000000181C199B0-0x0000000181C19A90
	// [XID] // 0x0000000189888580-0x00000001898885A0
	private void RecoverPostprocess() {} // 0x0000000181C18F00-0x0000000181C18FE0
	// [XID] // 0x000000018988F9A0-0x000000018988F9C0
	public void LateTickPost(ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181C1BC50-0x0000000181C1C0A0
	// [XID] // 0x0000000189896EA0-0x0000000189896EC0
	public static string Dump() => default; // 0x0000000181C1AAA0-0x0000000181C1AF10
}

