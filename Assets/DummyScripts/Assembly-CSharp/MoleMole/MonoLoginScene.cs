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
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoLoginScene : MonoBehaviour, IWorldShiftCenter // TypeDefIndex: 30818
	{
		// Fields
		public LoginSceneState curState; // 0x18
		public bool disable24Time; // 0x1C
		public float animatorSpeed; // 0x20
		public Transform sceneNode; // 0x28
		public Transform bridgeNode; // 0x30
		public Transform doorNode; // 0x38
		public Transform cloudNode; // 0x40
		public Transform lightShaftNode; // 0x48
		public float moveSpeed1; // 0x50
		public float moveSpeed2; // 0x54
		public AnimationCurve moveSpeed2Curve; // 0x58
		public float moveSpeed3; // 0x60
		public AnimationCurve moveSpeed3Curve; // 0x68
		public float resetOffsetLen; // 0x70
		public GameObject sceneObj; // 0x78
		public int sceneSize; // 0x80
		public float sceneLength; // 0x84
		public GameObject bridgeObj; // 0x88
		public int bridgeSize; // 0x90
		public float bridgeLength; // 0x94
		public GameObject cloudObj; // 0x98
		public int cloudSize; // 0xA0
		public float cloudLength; // 0xA4
		public GameObject[] cameraEffecs; // 0xA8
		public GameObject doorPrefab; // 0xB0
		public GameObject cameraPrefab; // 0xB8
		public Transform cameraTrans; // 0xC0
		public EnviroSky enviroSky; // 0xC8
		public float showDoorOnBridgeLength; // 0xD0
		public float stopBeforeDoor1; // 0xD4
		public float stopBeforeDoor2; // 0xD8
		public float pressAfterLiftDoorTime; // 0xDC
		public float connectAfterDoor2StageTime; // 0xE0
		public float whiteScreenExpro; // 0xE4
		public float transWeatherTime; // 0xE8
		public float hourOfDayLengthInMinutes; // 0xEC
		public float[] oneDayTimeIntervals; // 0xF0
		public float[] oneDayTargetTimes; // 0xF8
		public GameObject[] oneDayTargetLightShafts; // 0x100
		public GameObject[] oneDayTargetCameraHalo; // 0x108
		public float lightShaftLength; // 0x110
		public float internalHour; // 0x114
		public int curTargetTimeIndex; // 0x118
		public int lastTargetTimeIndex; // 0x11C
		public float showHour; // 0x120
		public float animationLen; // 0x124
		public float showDoorOnLoadProgress; // 0x128
		public float showDoorOnPS4LoadProgress; // 0x12C
		public float focalDistance; // 0x130
		public float focalRange; // 0x134
		public float dofBlur; // 0x138
		public float nearDistance; // 0x13C
		public float nearTrans; // 0x140
		public float curtainDelayTime; // 0x144
		public float curtainDurationTime; // 0x148
		public float blurLerpSpeed; // 0x14C
		public float shadowDistance; // 0x150
		public Vector4 shadowDistanceVec; // 0x154
		public Vector3 shadowSplitVec; // 0x164
		public ShadowResolution shadowQuality; // 0x170
		public float bridgetEmissionAfterTime; // 0x174
		public float lightValue; // 0x178
		public float beginHeight; // 0x17C
		public float lightSpeed1; // 0x180
		public float lightSpeed2; // 0x184
		private const float MAX_ROLLBACK_LEN = 1000f; // Metadata: 0x00B115DE
		private float _stopBeforeDoor0; // 0x188
		private float _curCameraMoveLen; // 0x18C
		private int _curSceneIndex; // 0x190
		private float _curSceneMoveLen; // 0x194
		private int _curCloudIndex; // 0x198
		private float _curCloudMoveLen; // 0x19C
		private int _curBridgeIndex; // 0x1A0
		private float _curBridgeMoveLen; // 0x1A4
		private int _curShaftIndex; // 0x1A8
		private float _curShaftMoveLen; // 0x1AC
		private Vector3 _sceneDir; // 0x1B0
		private Vector3 _cameraDir; // 0x1BC
		private Action _showDoorCallBack; // 0x1C8
		private Action _openDoorCallBack; // 0x1D0
		private MotionBlur _motionBlur; // 0x1D8
		private MHYDepthOfField _mhyDepthOfField; // 0x1E0
		private float _originFocalDistance; // 0x1E8
		private float _originFocalRange; // 0x1EC
		private float _originDofBlur; // 0x1F0
		private float _originNearDistance; // 0x1F4
		private float _originNearTrans; // 0x1F8
		private List<GameObject> _sceneObjs; // 0x200
		private List<GameObject> _bridgeObjs; // 0x208
		private List<GameObject> _cloudObjs; // 0x210
		private List<GameObject> _lightShafts; // 0x218
		private GameObject _doorObj; // 0x220
		private GameObject _doorOpenEff; // 0x228
		private GameObject _cameraObj; // 0x230
		private float _focusTime; // 0x238
		private float _curExpro; // 0x23C
		private Coroutine _callbackCoroutine; // 0x240
		private Coroutine _whiteScreenCoroutine; // 0x248
		private bool hasLift; // 0x250
	
		// Nested types
		public enum LoginSceneState // TypeDefIndex: 30819
		{
			Move = 0,
			TryToStop = 1,
			BeforeOpen = 2,
			AfterOpen = 3,
			Finish = 4
		}
	
		// Constructors
		public MonoLoginScene() {} // 0x0000000184287F50-0x00000001842882C0
	
		// Methods
		// [XID] // 0x0000000189975140-0x0000000189975160
		public float GetOpenDoorProgress() => default; // 0x0000000184284200-0x00000001842842B0
		// [XID] // 0x000000018997C300-0x000000018997C320
		public void Awake() {} // 0x00000001842819F0-0x0000000184282EB0
		// [XID] // 0x0000000189984020-0x0000000189984040
		private void OnDestroy() {} // 0x0000000184287120-0x0000000184287210
		// [XID] // 0x000000018998BBB0-0x000000018998BBD0
		private void InitCamera(Camera camera) {} // 0x0000000184282EB0-0x00000001842830E0
		// [XID] // 0x0000000189993760-0x0000000189993780
		public int InitTime() => default; // 0x0000000184284500-0x0000000184284870
		// [XID] // 0x000000018999B060-0x000000018999B080
		public void Update() {} // 0x0000000184287E30-0x0000000184287F50
		// [XID] // 0x00000001899A28A0-0x00000001899A28C0
		private void OnSceneMove() {} // 0x00000001842830E0-0x0000000184283200
		// [XID] // 0x00000001899AA1C0-0x00000001899AA1E0
		private void UpdateMoveLen(float curMove) {} // 0x0000000184283460-0x0000000184283570
		// [XID] // 0x00000001899B1BB0-0x00000001899B1BD0
		private void OnSceneTryToStop() {} // 0x00000001842842B0-0x00000001842843C0
		// [XID] // 0x00000001899B8F20-0x00000001899B8F40
		private void OnBeforeOpen() {} // 0x0000000184284FC0-0x00000001842851C0
		// [XID] // 0x00000001899C0780-0x00000001899C07A0
		private void CheckLiftDoor() {} // 0x0000000184283200-0x0000000184283460
		// [XID] // 0x00000001899C8040-0x00000001899C8060
		private void UpdateFocus(float value) {} // 0x00000001842837D0-0x0000000184283EF0
		// [XID] // 0x00000001899CF980-0x00000001899CF9A0
		private void OnAfterOpen() {} // 0x0000000184284CC0-0x0000000184284D70
		// [XID] // 0x00000001899D6D50-0x00000001899D6D70
		private void OnCameraAfterOpen() {} // 0x0000000184283F80-0x0000000184284090
		// [XID] // 0x00000001899DE3A0-0x00000001899DE3C0
		private void OnSceneAfterOpen() {} // 0x0000000184283570-0x00000001842837D0
		// [XID] // 0x00000001899E6060-0x00000001899E6080
		private void CheckSceneScroll() {} // 0x00000001842853C0-0x0000000184285CD0
		// [XID] // 0x00000001899ED450-0x00000001899ED470
		private void MoveScene(float curMove, float speed, bool force, bool updateBridget = true /* Metadata: 0x00B115DD */) {} // 0x0000000184286100-0x0000000184286DB0
		// [XID] // 0x00000001899F4F60-0x00000001899F4F80
		private void UpdateBridgeRestart(GameObject bridge) {} // 0x00000001842843C0-0x0000000184284500
		// [XID] // 0x00000001899FC510-0x00000001899FC530
		private void UpdateBridge(GameObject bridge, float speed, bool force) {} // 0x0000000184286EF0-0x0000000184287120
		// [XID] // 0x0000000189A03AE0-0x0000000189A03B00
		private void UpdateBridgeGoal(GameObject bridge, Transform goal, Vector3 offset) {} // 0x0000000184284B10-0x0000000184284CC0
		// [XID] // 0x0000000189A0B010-0x0000000189A0B030
		private void UpdateBridgeEnd(GameObject bridge) {} // 0x0000000184286DB0-0x0000000184286EF0
		// [XID] // 0x0000000189A129A0-0x0000000189A129C0
		private float GetDeltaTime() => default; // 0x0000000184285310-0x00000001842853C0
		// [XID] // 0x0000000189A19BF0-0x0000000189A19C10
		private void UpdateTime() {} // 0x0000000184285CD0-0x0000000184286100
		// [XID] // 0x0000000189A21220-0x0000000189A21240
		private float GetDirZ() => default; // 0x0000000184284940-0x0000000184284B10
		// [XID] // 0x0000000189A28850-0x0000000189A28870
		public void ShowDoor(Action callback) {} // 0x0000000184287B40-0x0000000184287E30
		// [XID] // 0x0000000189A2FE30-0x0000000189A2FE50
		public void OpenDoor(Action callback) {} // 0x0000000184287210-0x0000000184287460
		// [XID] // 0x0000000189A37800-0x0000000189A37820
		public void Restart() {} // 0x00000001842875F0-0x0000000184287880
		// [XID] // 0x0000000189A3EF50-0x0000000189A3EF70
		public Vector3 GetCenterAgentPosition() => default; // 0x0000000184284090-0x0000000184284200
		// [XID] // 0x0000000189A465D0-0x0000000189A465F0
		public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000184287880-0x0000000184287B40
		// [XID] // 0x0000000189A4DDC0-0x0000000189A4DDE0
		public bool IsCenterValid() => default; // 0x0000000184284870-0x0000000184284940
		// [XID] // 0x0000000189A555D0-0x0000000189A555F0
		private void RefreshObjPosition(GameObject obj, Vector3 offset, Vector3 oldOffset) {} // 0x0000000184284D70-0x0000000184284FC0
		// [XID] // 0x0000000189A5CED0-0x0000000189A5CEF0
		private void RefreshObjsPosition(List<GameObject> objs, Vector3 offset, Vector3 oldOffset) {} // 0x0000000184287460-0x00000001842875F0
	}
}
