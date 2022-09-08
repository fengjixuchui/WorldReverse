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
	public class CVRRenderModels // TypeDefIndex: 6474
	{
		// Fields
		private IVRRenderModels FnTable; // 0x10
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetComponentStatePacked(string pchRenderModelName, string pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState); // TypeDefIndex: 6475; 0x000000018647C1F0-0x000000018647C600
	
		private struct GetComponentStateUnion // TypeDefIndex: 6476
		{
			// Fields
			public IVRRenderModels._GetComponentState pGetComponentState; // 0x00
			public _GetComponentStatePacked pGetComponentStatePacked; // 0x00
		}
	
		// Constructors
		public CVRRenderModels() {} // Dummy constructor
		internal CVRRenderModels(IntPtr pInterface) {} // 0x000000018646F590-0x000000018646F6F0
	
		// Methods
		public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel) => default; // 0x000000018646F320-0x000000018646F3C0
		public void FreeRenderModel(IntPtr pRenderModel) {} // 0x000000018646E950-0x000000018646E9D0
		public EVRRenderModelError LoadTexture_Async(int textureId, ref IntPtr ppTexture) => default; // 0x000000018646F460-0x000000018646F4F0
		public void FreeTexture(IntPtr pTexture) {} // 0x000000018646EA50-0x000000018646EAD0
		public EVRRenderModelError LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D) => default; // 0x000000018646F3C0-0x000000018646F460
		public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture) => default; // 0x000000018646F290-0x000000018646F320
		public void FreeTextureD3D11(IntPtr pD3D11Texture2D) {} // 0x000000018646E9D0-0x000000018646EA50
		public uint GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen) => default; // 0x000000018646F090-0x000000018646F130
		public uint GetRenderModelCount() => default; // 0x000000018646EF50-0x000000018646EFD0
		public uint GetComponentCount(string pchRenderModelName) => default; // 0x000000018646EB70-0x000000018646EC00
		public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen) => default; // 0x000000018646EC00-0x000000018646ECB0
		public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName) => default; // 0x000000018646EAD0-0x000000018646EB70
		public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen) => default; // 0x000000018646ECB0-0x000000018646ED60
		public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState) => default; // 0x000000018646ED60-0x000000018646EF50
		public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName) => default; // 0x000000018646F4F0-0x000000018646F590
		public uint GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError) => default; // 0x000000018646F1E0-0x000000018646F290
		public uint GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError) => default; // 0x000000018646F130-0x000000018646F1E0
		public string GetRenderModelErrorNameFromEnum(EVRRenderModelError error) => default; // 0x000000018646EFD0-0x000000018646F090
	}
}
