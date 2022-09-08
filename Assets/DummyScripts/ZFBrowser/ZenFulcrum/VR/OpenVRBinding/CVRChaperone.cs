/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public class CVRChaperone // TypeDefIndex: 6468
	{
		// Fields
		private IVRChaperone FnTable; // 0x10
	
		// Constructors
		public CVRChaperone() {} // Dummy constructor
		internal CVRChaperone(IntPtr pInterface) {} // 0x00000001856A58A0-0x00000001856A59D0
	
		// Methods
		public ChaperoneCalibrationState GetCalibrationState() => default; // 0x00000001856A55F0-0x00000001856A5670
		public bool GetPlayAreaSize(ref float pSizeX, ref float pSizeZ) => default; // 0x00000001856A5700-0x00000001856A57A0
		public bool GetPlayAreaRect(ref HmdQuad_t rect) => default; // 0x00000001856A5670-0x00000001856A5700
		public void ReloadInfo() {} // 0x00000001856A57A0-0x00000001856A5810
		public void SetSceneColor(HmdColor_t color) {} // 0x00000001856A5810-0x00000001856A58A0
		public void GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor) {} // 0x00000001856A5530-0x00000001856A55F0
		public bool AreBoundsVisible() => default; // 0x00000001856A5430-0x00000001856A54B0
		public void ForceBoundsVisible(bool bForce) {} // 0x00000001856A54B0-0x00000001856A5530
	}
}
