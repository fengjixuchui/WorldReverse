/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [AddComponentMenu] // 0x00000001896E1BC0-0x00000001896E1C00
[ExecuteInEditMode] // 0x00000001896E1BC0-0x00000001896E1C00
public class AQUAS_Reflection : MonoBehaviour // TypeDefIndex: 10679
{
	// Fields
	public bool m_DisablePixelLights; // 0x18
	public int m_TextureSize; // 0x1C
	public float m_ClipPlaneOffset; // 0x20
	public LayerMask m_ReflectLayers; // 0x24
	private Hashtable m_ReflectionCameras; // 0x28
	private RenderTexture m_ReflectionTexture; // 0x30
	private int m_OldReflectionTextureSize; // 0x38
	private static bool s_InsideRendering; // 0x00
	public bool ignoreOcclusionCulling; // 0x3C

	// Constructors
	public AQUAS_Reflection() {} // 0x00000001864C6E60-0x00000001864C6F20
	static AQUAS_Reflection() {} // 0x00000001864C6E00-0x00000001864C6E60

	// Methods
	public void OnWillRenderObject() {} // 0x00000001864C5DE0-0x00000001864C6B00
	private void OnDisable() {} // 0x00000001864C5B30-0x00000001864C5DE0
	private void UpdateCameraModes(Camera src, Camera dest) {} // 0x00000001864C6B00-0x00000001864C6E00
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera) {
		reflectionCamera = default;
	} // 0x00000001864C5430-0x00000001864C5B30
	private static float sgn(float a) => default; // 0x00000001864C6F20-0x00000001864C6FB0
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) => default; // 0x00000001864C5120-0x00000001864C5430
	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane) {} // 0x00000001864C4BA0-0x00000001864C4E40
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) {} // 0x00000001864C4E40-0x00000001864C5120
}

