/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct IVRRenderModels // TypeDefIndex: 6409
	{
		// Fields
		internal _LoadRenderModel_Async LoadRenderModel_Async; // 0x00
		internal _FreeRenderModel FreeRenderModel; // 0x08
		internal _LoadTexture_Async LoadTexture_Async; // 0x10
		internal _FreeTexture FreeTexture; // 0x18
		internal _LoadTextureD3D11_Async LoadTextureD3D11_Async; // 0x20
		internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async; // 0x28
		internal _FreeTextureD3D11 FreeTextureD3D11; // 0x30
		internal _GetRenderModelName GetRenderModelName; // 0x38
		internal _GetRenderModelCount GetRenderModelCount; // 0x40
		internal _GetComponentCount GetComponentCount; // 0x48
		internal _GetComponentName GetComponentName; // 0x50
		internal _GetComponentButtonMask GetComponentButtonMask; // 0x58
		internal _GetComponentRenderModelName GetComponentRenderModelName; // 0x60
		internal _GetComponentState GetComponentState; // 0x68
		internal _RenderModelHasComponent RenderModelHasComponent; // 0x70
		internal _GetRenderModelThumbnailURL GetRenderModelThumbnailURL; // 0x78
		internal _GetRenderModelOriginalPath GetRenderModelOriginalPath; // 0x80
		internal _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum; // 0x88
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRRenderModelError _LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel); // TypeDefIndex: 6410; 0x0000000188333400-0x00000001883336B0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _FreeRenderModel(IntPtr pRenderModel); // TypeDefIndex: 6411; 0x0000000187BF2230-0x0000000187BF23C0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRRenderModelError _LoadTexture_Async(int textureId, ref IntPtr ppTexture); // TypeDefIndex: 6412; 0x0000000188334120-0x00000001883342E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _FreeTexture(IntPtr pTexture); // TypeDefIndex: 6413; 0x0000000187BF2870-0x0000000187BF2A00
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRRenderModelError _LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D); // TypeDefIndex: 6414; 0x0000000188333D60-0x0000000188333F40
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRRenderModelError _LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture); // TypeDefIndex: 6415; 0x0000000188333070-0x0000000188333230
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _FreeTextureD3D11(IntPtr pD3D11Texture2D); // TypeDefIndex: 6416; 0x0000000187BF2550-0x0000000187BF26E0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen); // TypeDefIndex: 6417; 0x0000000187BFFBF0-0x0000000187BFFDC0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetRenderModelCount(); // TypeDefIndex: 6418; 0x0000000187BFF560-0x0000000187BFF6D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetComponentCount(string pchRenderModelName); // TypeDefIndex: 6419; 0x0000000187BF3000-0x0000000187BF3260
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen); // TypeDefIndex: 6420; 0x0000000187BF3440-0x0000000187BF3790
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate ulong _GetComponentButtonMask(string pchRenderModelName, string pchComponentName); // TypeDefIndex: 6421; 0x0000000187BF2BA0-0x0000000187BF2E50
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen); // TypeDefIndex: 6422; 0x0000000187BF3960-0x0000000187BF3CB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState); // TypeDefIndex: 6423; 0x0000000187BF3EF0-0x0000000187BF4300
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _RenderModelHasComponent(string pchRenderModelName, string pchComponentName); // TypeDefIndex: 6424; 0x00000001883362B0-0x0000000188336560
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError); // TypeDefIndex: 6425; 0x000000018832D170-0x000000018832D4D0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError); // TypeDefIndex: 6426; 0x000000018832CC20-0x000000018832CF80
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetRenderModelErrorNameFromEnum(EVRRenderModelError error); // TypeDefIndex: 6427; 0x0000000187BFF880-0x0000000187BFFA10
	}
}
