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
	public struct IVRScreenshots // TypeDefIndex: 6444
	{
		// Fields
		internal _RequestScreenshot RequestScreenshot; // 0x00
		internal _HookScreenshot HookScreenshot; // 0x08
		internal _GetScreenshotPropertyType GetScreenshotPropertyType; // 0x10
		internal _GetScreenshotPropertyFilename GetScreenshotPropertyFilename; // 0x18
		internal _UpdateScreenshotProgress UpdateScreenshotProgress; // 0x20
		internal _TakeStereoScreenshot TakeStereoScreenshot; // 0x28
		internal _SubmitScreenshot SubmitScreenshot; // 0x30
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRScreenshotError _RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename); // TypeDefIndex: 6445; 0x0000000188336770-0x00000001883369C0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRScreenshotError _HookScreenshot([In, Out] EVRScreenshotType[] pSupportedTypes, int numTypes); // TypeDefIndex: 6446; 0x0000000188332290-0x0000000188332540
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRScreenshotType _GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError); // TypeDefIndex: 6447; 0x000000018832E080-0x000000018832E240
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError); // TypeDefIndex: 6448; 0x000000018832DC20-0x000000018832DEA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRScreenshotError _UpdateScreenshotProgress(uint screenshotHandle, float flProgress); // TypeDefIndex: 6449; 0x00000001883395F0-0x00000001883397B0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRScreenshotError _TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename); // TypeDefIndex: 6450; 0x0000000188338E90-0x0000000188339070
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRScreenshotError _SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename); // TypeDefIndex: 6451; 0x00000001883386C0-0x0000000188338900
	}
}
