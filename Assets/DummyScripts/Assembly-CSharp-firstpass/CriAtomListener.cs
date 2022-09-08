/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [AddComponentMenu] // 0x00000001896380C0-0x00000001896380F0
public class CriAtomListener : CriMonoBehaviour // TypeDefIndex: 6977
{
	// Fields
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private CriAtomRegion regionOnStart; // 0x30
	public bool activateListenerOnEnable; // 0x38
	private static List<CriAtomListener> listenersList; // 0x00
	private static CriAtomEx3dListener dummyNativeListener; // 0x08
	private Vector3 lastPosition; // 0x3C
	private CriAtomRegion currentRegion; // 0x48
	private bool _isActive; // 0x50

	// Properties
	public CriAtomEx3dListener nativeListener { get; protected set; } // 0x00000001877BDCE0-0x00000001877BDD40 0x00000001877BDEE0-0x00000001877BDF40
	public bool isActive { get => default; set {} } // 0x00000001877BDC80-0x00000001877BDCE0 0x00000001877BDDA0-0x00000001877BDEE0
	public CriAtomRegion region3d { get => default; set {} } // 0x00000001877BDD40-0x00000001877BDDA0 0x00000001877BDF40-0x00000001877BE150

	// Constructors
	public CriAtomListener() {} // 0x00000001877BDC10-0x00000001877BDC80
	static CriAtomListener() {} // 0x00000001877BDB80-0x00000001877BDC10

	// Methods
	public static void CreateDummyNativeListener() {} // 0x00000001877BD190-0x00000001877BD270
	public static void DestroyDummyNativeListener() {} // 0x00000001877BD370-0x00000001877BD450
	private void Awake() {} // 0x00000001877BD010-0x00000001877BD190
	private void Start() {} // 0x00000001877BD6D0-0x00000001877BD780
	protected override void OnEnable() {} // 0x00000001877BD660-0x00000001877BD6D0
	protected override void OnDisable() {} // 0x00000001877BD5F0-0x00000001877BD660
	private void OnDestroy() {} // 0x00000001877BD450-0x00000001877BD5F0
	public override void CriInternalUpdate() {} // 0x00000001877BD320-0x00000001877BD370
	public override void CriInternalLateUpdate() {} // 0x00000001877BD270-0x00000001877BD320
	private void UpdatePosition() {} // 0x00000001877BD780-0x00000001877BDB80
	public void ActivateListener(bool exclusive = true /* Metadata: 0x00ADE097 */) {} // 0x00000001877BCE00-0x00000001877BD010
}

