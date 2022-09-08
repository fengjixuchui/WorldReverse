/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCharacterSelectScene : MonoBehaviour // TypeDefIndex: 30725
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayableDirector _cutInDirector; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayableDirector _effectCutInDirector; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayableDirector _normalLoopDirector; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayableDirector _selectMaleDirector; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayableDirector _maleLoopDirector; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayableDirector _unselectMaleDirector; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayableDirector _selectFemaleDirector; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayableDirector _femaleLoopDirector; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PlayableDirector _unselectFemaleDirector; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ParticleSystem[] _cutInEffects; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _foregroundObjs; // 0x68
		public EnviroSky enviroSky; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MaterialParamConfig[] _materialParamConifgs; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool oldSelect; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _ground; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Transform sceneCamera; // 0x90
		public Light modelLight; // 0x98
		public string characterSettingPath; // 0xA0
		public Transform maleTrans; // 0xA8
		public Transform femaleTrans; // 0xB0
		public Transform centerTrans; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Camera _sceneCamera; // 0xC0
		public CinemachineVirtualCamera mainViewPoint; // 0xC8
		public CinemachineVirtualCamera maleViewPoint; // 0xD0
		public CinemachineVirtualCamera femaleViewPoint; // 0xD8
		private bool _pauseCutIn; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomScaleMin; // 0xE4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomScaleMax; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomScaleMinAvtar; // 0xEC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zoomDegree; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _minRotAngle; // 0xF4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _usePitch; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _useZoom; // 0xF9
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _upOffset; // 0xFC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _animNameStr; // 0x100
		private float _zoomScaleNow; // 0x108
		private Vector3 defaultCameraTarget; // 0x10C
		private MonoUIManekinCtrl _manekinCtrl; // 0x118
		private Animation _cameraAnimation; // 0x120
		private CinemachineBrain _cameraBrain; // 0x128
		private CameraDataAndFlags data; // 0x130
		private PipelineCameraModuleConfig piplineConfig; // 0x138
		private Vector3 _refAnchorSpherical; // 0x140
		private CameraProfile profile; // 0x150
		private float _xRatio; // 0x158
		private float _yRatio; // 0x15C
		private float _zoomRatio; // 0x160
	
		// Nested types
		[Serializable]
		private class MaterialParamConfig // TypeDefIndex: 30726
		{
			// Fields
			public Renderer targetRender; // 0x10
			public int materialIndex; // 0x18
			public string paramName; // 0x20
			public Color value; // 0x28
			[NonSerialized]
			public UnityEngine.Material[] instMats; // 0x38
	
			// Constructors
			public MaterialParamConfig() {} // 0x0000000184B9B290-0x0000000184B9B320
		}
	
		// Constructors
		public MonoCharacterSelectScene() {} // 0x0000000184819380-0x00000001848194F0
	
		// Methods
		// [XID] // 0x000000018982A3D0-0x000000018982A3F0
		public void Awake() {} // 0x0000000184814CF0-0x0000000184814F70
		// [XID] // 0x00000001898316E0-0x0000000189831700
		private void InitCamera() {} // 0x0000000184814F70-0x00000001848151B0
		// [XID] // 0x0000000189838DE0-0x0000000189838E00
		public void OnEnable() {} // 0x0000000184817680-0x00000001848178F0
		// [XID] // 0x0000000189840420-0x0000000189840440
		public void OnDestroy() {} // 0x00000001848175D0-0x0000000184817680
		// [XID] // 0x0000000189847A10-0x0000000189847A30
		public void Update() {} // 0x0000000184819290-0x0000000184819380
		// [XID] // 0x000000018984F180-0x000000018984F1A0
		public void LateUpdate() {} // 0x00000001848163B0-0x00000001848167D0
		// [XID] // 0x00000001898562C0-0x00000001898562E0
		public void Reset() {} // 0x0000000184817E60-0x00000001848180F0
		// [XID] // 0x000000018985D630-0x000000018985D650
		public void Reset2Default() {} // 0x0000000184817A50-0x0000000184817E60
		// [XID] // 0x0000000189864FD0-0x0000000189864FF0
		private void UpdateAnimation() {} // 0x0000000184816180-0x00000001848163B0
		// [XID] // 0x000000018986C570-0x000000018986C590
		private Transform GetCurrentMoveCamera() => default; // 0x00000001848151B0-0x0000000184815270
		// [XID] // 0x00000001898739C0-0x00000001898739E0
		public bool IsSelectedMale() => default; // 0x0000000184815C60-0x0000000184815DC0
		// [XID] // 0x000000018987B3F0-0x000000018987B410
		public void SelectMale() {} // 0x0000000184818600-0x00000001848187D0
		// [XID] // 0x00000001898825D0-0x00000001898825F0
		public void UnSelectMale() {} // 0x0000000184818EA0-0x0000000184819070
		// [XID] // 0x0000000189889D60-0x0000000189889D80
		public bool IsSelectedFemale() => default; // 0x0000000184815B00-0x0000000184815C60
		// [XID] // 0x0000000189891200-0x0000000189891220
		public void SelectFemale() {} // 0x0000000184818430-0x0000000184818600
		// [XID] // 0x0000000189898810-0x0000000189898830
		public void UnSelectFemale() {} // 0x0000000184818CD0-0x0000000184818EA0
		// [XID] // 0x000000018989FA50-0x000000018989FA70
		public void PauseCutIn() {} // 0x00000001848178F0-0x0000000184817A50
		// [XID] // 0x00000001898A7480-0x00000001898A74A0
		public void ResumeCutIn() {} // 0x00000001848180F0-0x00000001848182A0
		// [XID] // 0x00000001898AEE40-0x00000001898AEE60
		public void SetForegroundObjsShow(bool show) {} // 0x00000001848188B0-0x0000000184818A10
		// [XID] // 0x00000001898B6250-0x00000001898B6270
		private void ClearCamera() {} // 0x0000000184815980-0x0000000184815B00
		// [XID] // 0x00000001898BDB20-0x00000001898BDB40
		private void SetPipelineConfig() {} // 0x0000000184815E90-0x0000000184816180
		// [XID] // 0x00000001898C53C0-0x00000001898C53E0
		private void SetMaterialParams() {} // 0x0000000184815490-0x00000001848156A0
		// [XID] // 0x00000001898CC8B0-0x00000001898CC8D0
		private void ClearMaterialParams() {} // 0x0000000184816E90-0x0000000184817040
		// [XID] // 0x00000001898D4340-0x00000001898D4360
		private bool ComputeRefAnchorDuringRotating() => default; // 0x0000000184815270-0x0000000184815490
		// [XID] // 0x00000001898DBB20-0x00000001898DBB40
		public void TryReduceAnchorAngularVelocity() {} // 0x0000000184818A10-0x0000000184818CD0
		// [XID] // 0x00000001898E3700-0x00000001898E3720
		public void RotateModelByDelta(float xDeltaDegree, float yDeltaDegree) {} // 0x00000001848182A0-0x0000000184818430
		// [XID] // 0x00000001898EB3A0-0x00000001898EB3C0
		private float CheckCameraNearGround() => default; // 0x00000001848173E0-0x00000001848175D0
		// [XID] // 0x00000001898F2AE0-0x00000001898F2B00
		private void UpdateCameraPosAtNow() {} // 0x0000000184816B00-0x0000000184816E90
		// [XID] // 0x00000001898FA230-0x00000001898FA250
		private float GetCurrentHeightAdjust(float distance) => default; // 0x0000000184815DC0-0x0000000184815E90
		// [XID] // 0x0000000189901C00-0x0000000189901C20
		private void ReduceZoomVelocity() {} // 0x00000001848157A0-0x0000000184815980
		// [XID] // 0x0000000189909470-0x0000000189909490
		public void SetCameraZoom(float deltaPinch) {} // 0x00000001848187D0-0x00000001848188B0
		// [XID] // 0x0000000189910880-0x00000001899108A0
		public void UpdateCameraZoom() {} // 0x0000000184819070-0x0000000184819290
		// [XID] // 0x00000001899184A0-0x00000001899184C0
		private void ResetMoveData(Vector3 targetPos) {} // 0x0000000184817040-0x00000001848173E0
		// [XID] // 0x000000018991FCC0-0x000000018991FCE0
		private Vector3 CalcLocalVecterPos(Vector3 worldPos) => default; // 0x00000001848167D0-0x0000000184816B00
		// [XID] // 0x0000000189927560-0x0000000189927580
		private void UpdateCamera() {} // 0x00000001848156A0-0x00000001848157A0
	}
}
