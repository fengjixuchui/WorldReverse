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
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCCameraCharacterAmbientSensors : VCBase // TypeDefIndex: 11834
{
	// Fields
	public float MaxRange; // 0x108
	public float ColliderRadiusScaler; // 0x10C
	public float MaxColliderRadiusAugment; // 0x110
	public float MovingThreshold; // 0x114
	public float ShadowSpeed; // 0x118
	public float ShadowSpeedScaleWhileStanding; // 0x11C
	public float ColorBlendWeight; // 0x120
	public int StandingFrameThreshold; // 0x124
	// [Header] // 0x0000000189AD9AF0-0x0000000189AD9B20
	public bool DebugDisplay; // 0x128
	private Light _mainLight; // 0x130
	private Camera _mainCamera; // 0x138
	private Transform _mainCameraTransform; // 0x140
	private CameraEvent _cameraEvent; // 0x148
	private RenderTexture _sensorResultTex; // 0x150
	private RenderTexture[] _resultTexs; // 0x158
	private int _bufferId; // 0x160
	private UnityEngine.Material _material; // 0x168
	private Shader _shader; // 0x170
	private static readonly string COMMAND_BUFFER_NAME; // 0x00
	private CommandBuffer[] _cb; // 0x178
	private bool _isInit; // 0x180
	private MHYRenderResourcesSetting _renderResourcesSetting; // 0x188
	private static readonly int MAX_SIMPLE_CHARACTER_NUM; // 0x08
	private static readonly int MAX_COMPLEX_CHARACTER_NUM; // 0x0C
	private static readonly int MAX_CHARACTER_NUM; // 0x10
	private static readonly int COMPLEX_COLOR_SLOT_START; // 0x14
	private static readonly int COMPLEX_COLOR_SLOT_END; // 0x18
	private static readonly int COMPLEX_SHADOW_SLOT_START; // 0x1C
	private static readonly int COMPLEX_SHADOW_SLOT_END; // 0x20
	private static readonly int SIMPLE_SHADOW_SLOT_START; // 0x24
	private static readonly int SIMPLE_SHADOW_SLOT_END; // 0x28
	private static readonly int MAX_SLOT_NUM; // 0x2C
	private static readonly int MAX_SENSOR_NUM_PER_CHARACTER; // 0x30
	private static readonly int SimpleSensorNumPerCharacter; // 0x34
	private static readonly int ComplexSensorNumPerCharacter; // 0x38
	private Vector4[] _simpleSensors; // 0x190
	private Vector4[] _complexSensors; // 0x198
	private Vector4[] _combinedSensors; // 0x1A0
	private HashSet<int> _usedSimpleSensorIds; // 0x1A8
	private HashSet<int> _usedComplexSensorIds; // 0x1B0
	private HashSet<int> _usedSlotIds; // 0x1B8
	private Dictionary<uint, CharacterData> _characterDataMap; // 0x1C0
	private uint _lastLocalAvatarId; // 0x1C8
	private static readonly int _cleanCharacterDataInterval; // 0x3C
	private bool _isInCutscene; // 0x1CC
	private bool _propertyDirty; // 0x1CD
	private bool _lastIsShadowOn; // 0x1CE
	private bool _lastIsForceShadowOn; // 0x1CF

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001895F4230-0x00000001895F4250 */ get => default; } // 0x0000000183290BF0-0x0000000183290C90 

	// Nested types
	public static class ShaderIDs // TypeDefIndex: 11835
	{
		// Fields
		public static readonly int MainTex; // 0x00
		public static readonly int SensorResultTex; // 0x04
		public static readonly int Sensors; // 0x08
		public static readonly int ColorBlendWeight; // 0x0C
		public static readonly int MainCameraViewProjectionMatrix; // 0x10
		public static readonly int UVTransformSource; // 0x14
		public static readonly int UVTransformTarget; // 0x18
		public static readonly int AmbientSensorShadowOn; // 0x1C
		public static readonly int AmbientSensorForceShadowOn; // 0x20
		public static readonly int AmbientSensorColorOn; // 0x24
		public static readonly int AmbientSensorTex; // 0x28
		public static readonly int AmbientSensorUVs; // 0x2C
		public static readonly int InstAmbientSensorData; // 0x30

		// Constructors
		static ShaderIDs() {} // 0x000000018222AE20-0x000000018222B030
	}

	private enum Mode // TypeDefIndex: 11836
	{
		Simple = 0,
		Complex = 1
	}

	private class CharacterData // TypeDefIndex: 11837
	{
		// Fields
		public uint runtimeID; // 0x10
		public Mode mode; // 0x14
		public int sensorId; // 0x18
		public int shadowSlotId; // 0x1C
		public int colorSlotId; // 0x20
		public Vector3 prevPosition; // 0x24
		public int standingFrameCount; // 0x30
		public int lastTickFrame; // 0x34
		public float colliderRadius; // 0x38

		// Constructors
		public CharacterData() {} // 0x000000018222B030-0x000000018222B090
	}

	private abstract class InstMBPSetter // TypeDefIndex: 11838
	{
		// Fields
		public static bool isShadowOn; // 0x00
		public static bool isForceShadowOn; // 0x01
		public static Vector4 uvs; // 0x04

		// Constructors
		protected InstMBPSetter() {} // 0x000000018222ADC0-0x000000018222AE20

		// Methods
		// [XID] // 0x00000001896DA3E0-0x00000001896DA400
		public static void SetProperties(MeshRenderer render) {} // 0x000000018222AC60-0x000000018222ADC0
	}

	// Constructors
	public VCCameraCharacterAmbientSensors() {} // 0x0000000183290AA0-0x0000000183290BF0
	static VCCameraCharacterAmbientSensors() {} // 0x0000000183290900-0x0000000183290AA0

	// Methods
	// [XID] // 0x00000001895FBA60-0x00000001895FBA80
	private static int FetchUnusedId(HashSet<int> usedIds, int minId, int maxId) => default; // 0x000000018328EA80-0x000000018328EB80
	// [XID] // 0x00000001896031A0-0x00000001896031C0
	private bool InitCharacterData(ref CharacterData data, Mode mode, uint runtimeID, BaseEntity entity = null) => default; // 0x000000018328D600-0x000000018328DA60
	// [XID] // 0x000000018960ABC0-0x000000018960ABE0
	private bool ReuseCharacterData(uint runtimeIdToReuse, BaseEntity entity, Mode mode) => default; // 0x000000018328A830-0x000000018328AA90
	// [XID] // 0x0000000189612190-0x00000001896121B0
	private void DestroyCharacterData(CharacterData data) {} // 0x000000018328AB40-0x000000018328ADD0
	// [XID] // 0x0000000189619B10-0x0000000189619B30
	public override void Init() {} // 0x000000018328CB50-0x000000018328D600
	// [XID] // 0x0000000189764900-0x0000000189764920
	public override void OnEnable() {} // 0x000000018328F1A0-0x000000018328F260
	// [XID] // 0x0000000189628740-0x0000000189628760
	public override void OnDisable() {} // 0x000000018328F0E0-0x000000018328F1A0
	// [XID] // 0x0000000189630030-0x0000000189630050
	public override void Destroy() {} // 0x000000018328B1E0-0x000000018328B2A0
	// [XID] // 0x00000001898D5710-0x00000001898D5730
	private void Release() {} // 0x000000018328DAC0-0x000000018328DD30
	// [XID] // 0x000000018994DC20-0x000000018994DC40
	private void InitDebugDisplay() {} // 0x000000018328A730-0x000000018328A7D0
	// [XID] // 0x0000000189646880-0x00000001896468A0
	private void ReleaseDebugDisplay() {} // 0x000000018328F040-0x000000018328F0E0
	// [XID] // 0x0000000189940630-0x0000000189940650
	private void UpdateDebugDisplay() {} // 0x000000018328E2F0-0x000000018328E390
	// [XID] // 0x00000001896558B0-0x00000001896558D0
	private void ValidateSettings() {} // 0x000000018328E060-0x000000018328E100
	// [XID] // 0x000000018965D0A0-0x000000018965D0C0
	public void UpdateIsInCutscene(bool value) {} // 0x000000018328AA90-0x000000018328AB40
	// [XID] // 0x0000000189664650-0x0000000189664670
	protected override void Tick(float inDeltaTime) {} // 0x000000018328F260-0x0000000183290900
	// [IDTag] // 0x000000018966BC90-0x000000018966BCD0
	// [XID] // 0x000000018966BC90-0x000000018966BCD0
	private void SetSwitchOff(uint runtimeID) {} // 0x000000018328C4E0-0x000000018328C990
	// [IDTag] // 0x0000000189676A10-0x0000000189676A50
	// [XID] // 0x0000000189676A10-0x0000000189676A50
	private void SetSwitchOff() {} // 0x000000018328C990-0x000000018328CB50
	// [XID] // 0x00000001897CCEE0-0x00000001897CCF00
	private void SetModelProperties(VCBaseModel model, bool isShadowOn, bool isColorOn, bool isForceShadowOn, Vector4 uvs) {} // 0x000000018328EB80-0x000000018328EDD0
	// [XID] // 0x000000018975D180-0x000000018975D1A0
	private void SetEntityProperties(BaseEntity entity, CharacterData data, bool isShadowOn, bool isColorOn, bool isForceShadowOn) {} // 0x000000018328A240-0x000000018328A730
	// [XID] // 0x0000000189920FD0-0x0000000189920FF0
	private void SetInstProperties(GPUAnimInstance inst, CharacterData data, bool isShadowOn, bool isForceShadowOn) {} // 0x000000018328BC40-0x000000018328BEB0
	// [XID] // 0x00000001896982E0-0x0000000189698300
	private void TickAnEntity(CharacterData data, uint runtimeID, Vector3 position, bool isShadowOn, bool isColorOn, bool isForceShadowOn, int frame, Vector3 shadowDir, Mode mode, BaseEntity entity = null, GPUAnimInstance inst = null, VCBaseModel model = null) {} // 0x000000018328E390-0x000000018328EA80
	// [XID] // 0x000000018969F580-0x000000018969F5A0
	private static Vector3 ClampByCameraNearPlane(Vector3 wPos, Camera camera) => default; // 0x000000018328B2A0-0x000000018328B550
	// [XID] // 0x00000001896A6940-0x00000001896A6960
	private void ComputeSensor(Vector3 center, CharacterData data, Vector4[] sensors, Vector3 shadowDir) {} // 0x000000018328B630-0x000000018328BC40
	// [XID] // 0x00000001896AE030-0x00000001896AE050
	private void SetSensorsWeight(CharacterData data, float weight, Vector4[] sensors, int sensorNum) {} // 0x000000018328DD30-0x000000018328DEB0
	// [XID] // 0x00000001896B56A0-0x00000001896B56C0
	private void UpdateMaterial() {} // 0x000000018328ADD0-0x000000018328B180
	// [XID] // 0x00000001896BC920-0x00000001896BC940
	private void SwapCommandBuffer() {} // 0x000000018328DEB0-0x000000018328E060
	// [XID] // 0x00000001898F3F20-0x00000001898F3F40
	private void BuildCommandBuffer(int bufferId) {} // 0x000000018328BEB0-0x000000018328C4E0
	// [XID] // 0x0000000189B87050-0x0000000189B87070
	private void CleanCommandBuffer() {} // 0x000000018328E100-0x000000018328E280
	// [XID] // 0x00000001898FB350-0x00000001898FB370
	public static void BlitSubRect(CommandBuffer cmd, Texture source, Texture destination, Vector4 transformSource, Vector4 transformTarget, UnityEngine.Material material, int pass) {} // 0x000000018328EDD0-0x000000018328F040
}

