/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [AddComponentMenu] // 0x00000001897872F0-0x0000000189787340
[DisallowMultipleComponent] // 0x00000001897872F0-0x0000000189787340
public class CriAtomTransceiver : CriMonoBehaviour // TypeDefIndex: 6988
{
	// Fields
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private CriAtomRegion regionOnStart; // 0x58
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool useDedicatedInput; // 0x60
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private GameObject dedicatedInput; // 0x68
	// [Range] // 0x0000000189B51A30-0x0000000189B51A70
	[SerializeField] // 0x0000000189B51A30-0x0000000189B51A70
	private float outputVolume; // 0x70
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private float directAudioRadius; // 0x74
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private float crossFadeDistance; // 0x78
	// [Range] // 0x00000001897EE2B0-0x00000001897EE2F0
	[SerializeField] // 0x00000001897EE2B0-0x00000001897EE2F0
	private float coneInsideAngle; // 0x7C
	// [Range] // 0x00000001897F8CB0-0x00000001897F8CF0
	[SerializeField] // 0x00000001897F8CB0-0x00000001897F8CF0
	private float coneOutsideAngle; // 0x80
	// [Range] // 0x0000000189B51A30-0x0000000189B51A70
	[SerializeField] // 0x0000000189B51A30-0x0000000189B51A70
	private float coneOutsideVolume; // 0x84
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private float transceiverRadius; // 0x88
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private float interiorDistance; // 0x8C
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	public float minAttenuation; // 0x90
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	public float maxAttenuation; // 0x94
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private string globalAisacName; // 0x98
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private float maxAngleAisacDelta; // 0xA0
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private string distanceAisacControlId; // 0xA8
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private string listenerAzimuthAisacControlId; // 0xB0
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private string listenerElevationAisacControlId; // 0xB8
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private string outputAzimuthAisacControlId; // 0xC0
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private string outputElevationAisacControlId; // 0xC8
	[NonSerialized]
	public bool inspectorAisacSettingFoldout; // 0xD0
	private bool isInitialized; // 0xD1
	private bool dedicatedInputNotSetWarned; // 0xD2
	private CriAtomRegion currentRegion; // 0xD8

	// Properties
	public CriAtomEx3dTransceiver transceiverHn { get; protected set; } // 0x00000001877C7480-0x00000001877C74E0 0x00000001877C7840-0x00000001877C79B0
	public Vector3 inputPos { get; private set; } // 0x00000001877C7340-0x00000001877C73B0 0x00000001877C7550-0x00000001877C75C0
	public Vector3 inputFront { get; private set; } // 0x00000001877C72D0-0x00000001877C7340 0x00000001877C74E0-0x00000001877C7550
	public Vector3 inputUp { get; private set; } // 0x00000001877C73B0-0x00000001877C7420 0x00000001877C75C0-0x00000001877C7630
	public CriAtomRegion region3d { get => default; set {} } // 0x00000001877C7420-0x00000001877C7480 0x00000001877C7630-0x00000001877C7840

	// Nested types
	private delegate void SetControlIdMethod(ushort id); // TypeDefIndex: 6989; 0x0000000187A4B960-0x0000000187A4BAF0

	// Constructors
	public CriAtomTransceiver() {} // 0x00000001877C7140-0x00000001877C72D0

	// Methods
	private void Awake() {} // 0x00000001877C69E0-0x00000001877C6A50
	private void Start() {} // 0x00000001877C6F00-0x00000001877C6FB0
	protected override void OnEnable() {} // 0x00000001877C6E80-0x00000001877C6F00
	private void OnDestroy() {} // 0x00000001877C6E10-0x00000001877C6E80
	protected virtual void InternalInitialize() {} // 0x00000001877C6D20-0x00000001877C6E10
	protected virtual void InternalFinalize() {} // 0x00000001877C6BF0-0x00000001877C6D20
	protected virtual void InitializeParameters() {} // 0x00000001877C6B00-0x00000001877C6BF0
	public override void CriInternalUpdate() {} // 0x00000001877C6AB0-0x00000001877C6B00
	public override void CriInternalLateUpdate() {} // 0x00000001877C6A50-0x00000001877C6AB0
	private void ApplyCurrentPosition() {} // 0x00000001877C5B40-0x00000001877C63D0
	private void ApplyParameters() {} // 0x00000001877C63D0-0x00000001877C69E0
	private void TrySetAisacControlId(string strId, SetControlIdMethod callback) {} // 0x00000001877C6FB0-0x00000001877C7140
}

