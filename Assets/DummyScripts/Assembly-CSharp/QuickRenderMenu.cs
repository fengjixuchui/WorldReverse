/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class QuickRenderMenu : MonoBehaviour // TypeDefIndex: 31334
{
	// Fields
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Dropdown m_Dropdown; // 0x18
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Toggle m_Toggle; // 0x20
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private ResourceReference m_ResourceReference; // 0x28
	private static bool HAVE_RESET_CAMERA; // 0x00
	private static CameraClearFlags INITIAL_CAMERA_FLAGS; // 0x04
	private static Color INITIAL_CAMERA_BG_COLOR; // 0x08
	private static readonly Dictionary<Vector4, ViewMode> TO_VIEM_MODE_INDEX_DIC; // 0x18
	private static readonly List<string> VIEW_MODES_STRINGS; // 0x20
	private static readonly int VIEW_MODES_COUNT; // 0x28
	private static readonly Vector4[] VIEW_MODES_ARRAY; // 0x30
	private static CommandBuffer _cmdBuffer; // 0x38
	private static bool _haveAdd; // 0x40
	private static Mesh _quadMesh; // 0x48
	private static UnityEngine.Material _mat; // 0x50
	private static GameObject m_MaterialInstance; // 0x58

	// Nested types
	private enum ViewMode // TypeDefIndex: 31335
	{
		Off = 0,
		Albedo = 1,
		Specular = 2,
		Shininess = 3,
		Normal = 4,
		ModelLOD = 5,
		TextureColor = 6,
		TextureSize = 7,
		TextureLOD = 8,
		Shadow = 9,
		AO = 10,
		FinOverDraw = 11,
		FinComplex = 12,
		GeoOverdraw = 13,
		GeoComplex = 14,
		TreeOverdraw = 15,
		GeoStencil = 16,
		LightBuffer = 17,
		LightOverDraw = 18,
		Reflection = 19,
		Ambient = 20,
		InteriorVolume = 21,
		LocalLight = 22,
		ClusterInfo = 23,
		LightingInfo = 24,
		VertexColor = 25,
		VertexColorAlpha = 26,
		MaterialID = 27,
		CustomValue = 28,
		GrassRootColor = 29,
		GrassSurfaceType = 30,
		Emission = 31,
		Metallic = 32
	}

	// Constructors
	static QuickRenderMenu() {} // 0x0000000181B52610-0x0000000181B536C0
	public QuickRenderMenu() {} // 0x0000000181B536C0-0x0000000181B53730

	// Methods
	private void Start() {} // 0x0000000181B52320-0x0000000181B52390
	private void OnDisable() {} // 0x0000000181B51B00-0x0000000181B51C10
	public void OnViewMode(int value) {} // 0x0000000181B51C90-0x0000000181B520C0
	private void OnToggleMaterial(bool isOn) {} // 0x0000000181B51C10-0x0000000181B51C90
	public void InitViewMode(Dropdown widget, Toggle toggle) {} // 0x0000000181B51900-0x0000000181B51B00
	private void AddSteniclOverDrawCommandBuffer() {} // 0x0000000181B511F0-0x0000000181B51900
	private void RemoveSteniclOverDrawCommandBuffer() {} // 0x0000000181B521D0-0x0000000181B52320
	private void AddReferenceMaterial() {} // 0x0000000181B50DC0-0x0000000181B511F0
	private void RemoveReferenceMaterial() {} // 0x0000000181B520C0-0x0000000181B521D0
	private void ToggleLightingUI(bool open) {} // 0x0000000181B52390-0x0000000181B524D0
	private void ToggleTreeOverdrawUI(bool open) {} // 0x0000000181B524D0-0x0000000181B52610
}

