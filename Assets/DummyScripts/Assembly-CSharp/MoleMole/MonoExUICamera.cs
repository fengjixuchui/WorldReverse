/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoExUICamera : MonoBehaviour // TypeDefIndex: 30762
	{
		// Fields
		public bool Debug_Ignore_range; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Camera _camera; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Canvas _canvas; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _panel_0; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _LockY; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _cameraInitPosition; // 0x3C
		// [Header] // 0x0000000189AA4F20-0x0000000189AA4FB0
		// [Range] // 0x0000000189AA4F20-0x0000000189AA4FB0
		[SerializeField] // 0x0000000189AA4F20-0x0000000189AA4FB0
		// [Tooltip] // 0x0000000189AA4F20-0x0000000189AA4FB0
		private float _referenceMaxSwipeSpeed; // 0x48
		// [Range] // 0x0000000189AB6F70-0x0000000189AB6FE0
		[SerializeField] // 0x0000000189AB6F70-0x0000000189AB6FE0
		// [Tooltip] // 0x0000000189AB6F70-0x0000000189AB6FE0
		private float _touchSwipeRatioMultiplier; // 0x4C
		// [Header] // 0x0000000189AC6520-0x0000000189AC6590
		[SerializeField] // 0x0000000189AC6520-0x0000000189AC6590
		// [Tooltip] // 0x0000000189AC6520-0x0000000189AC6590
		private float _pinch_speed_ratio; // 0x50
		// [Range] // 0x0000000189AD7010-0x0000000189AD7070
		[SerializeField] // 0x0000000189AD7010-0x0000000189AD7070
		// [Tooltip] // 0x0000000189AD7010-0x0000000189AD7070
		private float _maxZoomSpeed; // 0x54
		// [Header] // 0x0000000189AE63D0-0x0000000189AE6420
		[SerializeField] // 0x0000000189AE63D0-0x0000000189AE6420
		private float _zoomMinOuter; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomMinInner; // 0x5C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomMaxInner; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomMaxOuter; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _logMargin; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _canvas_left_margin; // 0x6C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _canvas_right_margin; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _canvas_bottom_margin; // 0x74
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _canvas_top_margin; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _canvas_right_extent; // 0x7C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _damping_ratio; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _damping_in_recover_ratio; // 0x84
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _damping_in_recover_stop_threshold; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoom_damping_ratio; // 0x8C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoom_damping_in_recover_ratio; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoom_damping_in_recover_stop_threshold; // 0x94
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _camera_recover_speed; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _camera_recover_stop_speed; // 0x9C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _camera_zoomin_recover_speed; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _camera_zoomout_recover_speed; // 0xA4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ExUICameraBaseState.State _state; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _camera_zoom_speed_ratio; // 0xAC
		private RectTransform _canvasRect; // 0xB0
		private float _canvas_width_worldspace; // 0xB8
		private float _canvas_height_worldspace; // 0xBC
		private float _canvas_left_outer_worldspace; // 0xC0
		private float _canvas_right_outer_worldspace; // 0xC4
		private float _canvas_bottom_outer_worldspace; // 0xC8
		private float _canvas_top_outer_worldspace; // 0xCC
		private float _canvas_left_drag; // 0xD0
		private float _canvas_right_drag; // 0xD4
		private float _canvas_bottom_drag; // 0xD8
		private float _canvas_top_drag; // 0xDC
		private float _canvas_left_inner_worldspace; // 0xE0
		private float _canvas_right_inner_worldspace; // 0xE4
		private float _canvas_bottom_inner_worldspace; // 0xE8
		private float _canvas_top_inner_worldspace; // 0xEC
		public float canvasOuterLeft; // 0xF0
		public float canvasOuterRight; // 0xF4
		public float canvasOuterUp; // 0xF8
		public float canvasOuterDown; // 0xFC
		private ExUICameraBaseState _currentState; // 0x100
		private ExUICameraIdleState _idleState; // 0x108
		private ExUICameraSwipeState _swipeState; // 0x110
		private ExUICameraDampingState _dampingState; // 0x118
		private ExUICameraRecoverState _recoverState; // 0x120
		private ExUICameraZoomRecoverState _zoomRecoverState; // 0x128
		private ExUICameraZoomDampingState _zoomDampingState; // 0x130
		private ExUICameraFocusState _focusState; // 0x138
		private Dictionary<E_ExUICameraState, ExUICameraBaseState> _stateDict; // 0x140
		private Vector3 _v_camera_pivot; // 0x148
		private float _zSwipeReference; // 0x154
		private float _zoom_z_speed; // 0x158
		private Vector3 _moveSpeed; // 0x15C
		private MonoExUICameraNavigator _gyroMgr; // 0x168
		public bool allowCameraAnimation; // 0x170
		private Action<float, float, float, float> _onViewChange; // 0x178
		public UnityAction<float> OnZoomChanged; // 0x180
		public UnityAction<float> OnTryZoom; // 0x188
		private float _ratio; // 0x190
	
		// Properties
		public Transform Panel0 { /* [XID] */ /* 0x0000000189B8E590-0x0000000189B8E5B0 */ set {} } // 0x00000001856257C0-0x0000000185625870
		public Camera projectiveUICamera { /* [XID] */ /* 0x0000000189B95A50-0x0000000189B95A70 */ get => default; /* [XID] */ /* 0x0000000189B9CFF0-0x0000000189B9D010 */ set {} } // 0x0000000185625720-0x00000001856257C0 0x0000000185625920-0x00000001856259D0
		public Canvas worldSpaceCanvas { /* [XID] */ /* 0x0000000189BA4930-0x0000000189BA4950 */ set {} } // 0x0000000185625B50-0x0000000185625C00
		public Action<float, float, float, float> onViewChange { /* [XID] */ /* 0x0000000189BABC30-0x0000000189BABC50 */ set {} } // 0x0000000185625870-0x0000000185625920
		public float referenceMaxSwipeSpeed { /* [XID] */ /* 0x00000001896F9810-0x00000001896F9830 */ set {} } // 0x00000001856259D0-0x0000000185625A90
		public float touchSwipeRatioMultiplier { /* [XID] */ /* 0x0000000189701050-0x0000000189701070 */ set {} } // 0x0000000185625A90-0x0000000185625B50
	
		// Nested types
		public enum E_ExUICameraState // TypeDefIndex: 30763
		{
			Idle = 0,
			Swipe = 1,
			Damping = 2,
			Recover = 3,
			ZoomRecover = 4,
			ZoomDamping = 5,
			Focus = 6
		}
	
		public enum E_ExUICameraOut // TypeDefIndex: 30764
		{
			None = 0,
			Left = 1,
			Top = 2,
			Right = 4,
			Bottom = 8
		}
	
		public enum E_ExUIZoomRange // TypeDefIndex: 30765
		{
			None = 0,
			Max = 1,
			Min = 2
		}
	
		public struct CameraOutInfo // TypeDefIndex: 30766
		{
			// Fields
			public E_ExUICameraOut horizontal; // 0x00
			public E_ExUICameraOut vertical; // 0x04
			public float horizontalRatio; // 0x08
			public float verticalRatio; // 0x0C
			public float horizontalDelta; // 0x10
			public float verticalDelta; // 0x14
	
			// Methods
			// [XID] // 0x0000000189708740-0x0000000189708760
			public bool InInner() => default; // 0x000000018563A520-0x000000018563A530
			// [XID] // 0x00000001897100B0-0x00000001897100D0
			public void Reset() {} // 0x000000018563A460-0x000000018563A520
		}
	
		// Constructors
		public MonoExUICamera() {} // 0x00000001856254D0-0x0000000185625720
	
		// Methods
		// [XID] // 0x0000000189BB32E0-0x0000000189BB3300
		public void Init() {} // 0x00000001856226A0-0x0000000185622790
		// [XID] // 0x0000000189BBA8C0-0x0000000189BBA8E0
		public void SetCameraAnimationStatus(bool status) {} // 0x0000000185624180-0x0000000185624230
		// [XID] // 0x0000000189BC28E0-0x0000000189BC2900
		public void Refresh(float xratio, float yratio) {} // 0x0000000185623B80-0x0000000185623D90
		// [XID] // 0x0000000189BCA060-0x0000000189BCA080
		private void Update() {} // 0x0000000185624C70-0x0000000185624D40
		// [XID] // 0x0000000189BD1750-0x0000000189BD1770
		private void SetCameraInitPos() {} // 0x0000000185622D70-0x0000000185622EA0
		// [XID] // 0x0000000189BD8D40-0x0000000189BD8D60
		private void UpdateCameraPosition() {} // 0x0000000185620A10-0x0000000185620E80
		// [XID] // 0x00000001895E5920-0x00000001895E5940
		public Vector3 GetCameraPosition() => default; // 0x0000000185622150-0x0000000185622260
		// [XID] // 0x00000001895ED270-0x00000001895ED290
		public Vector3 GetCameraEuler() => default; // 0x0000000185621850-0x0000000185621960
		// [XID] // 0x00000001895F48D0-0x00000001895F48F0
		private void InitStates() {} // 0x0000000185620760-0x0000000185620A10
		// [XID] // 0x00000001895FC080-0x00000001895FC0A0
		public void GotoState(E_ExUICameraState newStateName, object param = null) {} // 0x0000000185622570-0x00000001856226A0
		// [XID] // 0x0000000189603A80-0x0000000189603AA0
		private ExUICameraBaseState GetState(E_ExUICameraState stateName) => default; // 0x0000000185622C40-0x0000000185622D70
		// [XID] // 0x000000018960B3E0-0x000000018960B400
		public ExUICameraBaseState GetCurrentState() => default; // 0x00000001856224C0-0x0000000185622570
		// [XID] // 0x0000000189612790-0x00000001896127B0
		public void ResetCanvasRange(float width, float height) {} // 0x0000000185623D90-0x0000000185624180
		// [XID] // 0x000000018961A0B0-0x000000018961A0D0
		public CameraOutInfo GetCameraOutInfo(Vector3 pos) => default; // 0x0000000185621960-0x0000000185622070
		// [XID] // 0x00000001896215F0-0x0000000189621610
		private bool IsCameraInRange(Vector3 pos) => default; // 0x0000000185622910-0x0000000185622B20
		// [XID] // 0x0000000189628F00-0x0000000189628F20
		private float GetFrustumHeight(Vector3 pos) => default; // 0x0000000185622790-0x0000000185622910
		// [XID] // 0x0000000189630880-0x00000001896308A0
		private float GetFrustumWidth(Vector3 pos) => default; // 0x0000000185622B20-0x0000000185622C40
		// [XID] // 0x0000000189638320-0x0000000189638340
		public E_ExUIZoomRange GetCameraZoomInfo(float z, ref float ratio) => default; // 0x0000000185622340-0x00000001856224C0
		// [XID] // 0x000000018963F700-0x000000018963F720
		public void MoveCamera(Vector3 speed) {} // 0x0000000185622EA0-0x0000000185623030
		// [XID] // 0x0000000189646F00-0x0000000189646F20
		public void SwipeCamera(Vector2 rawDelta) {} // 0x00000001856248F0-0x0000000185624C70
		// [XID] // 0x000000018964E670-0x000000018964E690
		public void SwipeCameraJoypad(Vector2 ratio) {} // 0x0000000185624590-0x00000001856248F0
		// [XID] // 0x0000000189655E60-0x0000000189655E80
		public bool DampingCamera() => default; // 0x0000000185621490-0x0000000185621850
		// [XID] // 0x000000018965D640-0x000000018965D660
		private float SafeFrame() => default; // 0x0000000185623030-0x0000000185623100
		// [XID] // 0x0000000189664D40-0x0000000189664D60
		public bool RecoverCameraHard() => default; // 0x0000000185623480-0x00000001856237F0
		// [XID] // 0x000000018966C360-0x000000018966C380
		public bool RecoverCameraSoft() => default; // 0x00000001856237F0-0x0000000185623B80
		// [XID] // 0x00000001896741E0-0x0000000189674200
		public bool ZoomRecoverCamera() => default; // 0x0000000185625300-0x00000001856254D0
		// [XID] // 0x000000018967BA00-0x000000018967BA20
		private void ZoomCameraBase(float z) {} // 0x00000001856232B0-0x0000000185623480
		// [XID] // 0x0000000189683110-0x0000000189683130
		private void ZoomCameraTo(float z) {} // 0x0000000185623100-0x00000001856232B0
		// [XID] // 0x000000018968ABA0-0x000000018968ABC0
		public void ZoomCamera(float pinch) {} // 0x0000000185624F90-0x0000000185625080
		// [XID] // 0x00000001896928C0-0x00000001896928E0
		public void ZoomCameraRatioToZoom(float ratio) {} // 0x0000000185624E80-0x0000000185624F90
		// [XID] // 0x0000000189699C40-0x0000000189699C60
		private void OnCameraZChanged() {} // 0x00000001856205A0-0x0000000185620680
		// [XID] // 0x00000001896A1360-0x00000001896A1380
		public void ZoomCameraJoypad(float ratio) {} // 0x0000000185624D40-0x0000000185624E80
		// [XID] // 0x00000001896A87D0-0x00000001896A87F0
		public bool ZoomDampingCamera() => default; // 0x0000000185625080-0x0000000185625300
		// [XID] // 0x00000001896AF9A0-0x00000001896AF9C0
		private void ZoomCorrect(Vector3 newPos) {} // 0x0000000185621200-0x0000000185621490
		// [XID] // 0x00000001896B7310-0x00000001896B7330
		private float GetScreenLength() => default; // 0x0000000185620680-0x0000000185620760
		// [XID] // 0x00000001896BE460-0x00000001896BE480
		public Vector3 GetCameraPivot() => default; // 0x0000000185622070-0x0000000185622150
		// [XID] // 0x00000001896C5C90-0x00000001896C5CB0
		public Vector3 GetCameraSpeed() => default; // 0x0000000185622260-0x0000000185622340
		// [XID] // 0x00000001896CD400-0x00000001896CD420
		public void SetCameraSpeed(Vector3 speed) {} // 0x0000000185624300-0x00000001856243D0
		// [XID] // 0x00000001896D4830-0x00000001896D4850
		public void SetCameraZoomSpeed(float speed) {} // 0x00000001856243D0-0x0000000185624480
		// [XID] // 0x00000001896DBED0-0x00000001896DBEF0
		public void SetCameraPivot(Vector3 pos) {} // 0x0000000185624230-0x0000000185624300
		// [XID] // 0x00000001896E3680-0x00000001896E36A0
		public void SetEnableNavigator(bool enable) {} // 0x0000000185624480-0x0000000185624590
		// [XID] // 0x00000001896EAAA0-0x00000001896EAAC0
		public void CenterCameraAt(Vector2 canvasRatio, bool keepZ = false /* Metadata: 0x00B11514 */) {} // 0x0000000185620E80-0x0000000185621150
		// [XID] // 0x00000001896F1E40-0x00000001896F1E60
		public void ClearCallBack() {} // 0x0000000185621150-0x0000000185621200
	}
}
