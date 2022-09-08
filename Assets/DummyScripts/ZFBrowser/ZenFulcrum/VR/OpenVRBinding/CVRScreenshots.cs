/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public class CVRScreenshots // TypeDefIndex: 6479
	{
		// Fields
		private IVRScreenshots FnTable; // 0x10
	
		// Constructors
		public CVRScreenshots() {} // Dummy constructor
		internal CVRScreenshots(IntPtr pInterface) {} // 0x000000018646FDE0-0x000000018646FF10
	
		// Methods
		public EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename) => default; // 0x000000018646FB50-0x000000018646FC00
		public EVRScreenshotError HookScreenshot(EVRScreenshotType[] pSupportedTypes) => default; // 0x000000018646FAB0-0x000000018646FB50
		public EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError) => default; // 0x000000018646FA20-0x000000018646FAB0
		public uint GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError) => default; // 0x000000018646F960-0x000000018646FA20
		public EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle, float flProgress) => default; // 0x000000018646FD50-0x000000018646FDE0
		public EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename) => default; // 0x000000018646FCB0-0x000000018646FD50
		public EVRScreenshotError SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename) => default; // 0x000000018646FC00-0x000000018646FCB0
	}
}
