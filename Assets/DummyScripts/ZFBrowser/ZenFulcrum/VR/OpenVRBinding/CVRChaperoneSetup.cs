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
	public class CVRChaperoneSetup // TypeDefIndex: 6469
	{
		// Fields
		private IVRChaperoneSetup FnTable; // 0x10
	
		// Constructors
		public CVRChaperoneSetup() {} // Dummy constructor
		internal CVRChaperoneSetup(IntPtr pInterface) {} // 0x0000000186469010-0x0000000186469180
	
		// Methods
		public bool CommitWorkingCopy(EChaperoneConfigFile configFile) => default; // 0x0000000186468310-0x00000001864683A0
		public void RevertWorkingCopy() {} // 0x0000000186468C40-0x0000000186468CB0
		public bool GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ) => default; // 0x0000000186468960-0x0000000186468A00
		public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect) => default; // 0x00000001864688D0-0x0000000186468960
		public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer) {
			pQuadsBuffer = default;
			return default;
		} // 0x00000001864687D0-0x00000001864688D0
		public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer) {
			pQuadsBuffer = default;
			return default;
		} // 0x0000000186468440-0x0000000186468540
		public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose) => default; // 0x0000000186468A00-0x0000000186468A90
		public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose) => default; // 0x0000000186468A90-0x0000000186468B20
		public void SetWorkingPlayAreaSize(float sizeX, float sizeZ) {} // 0x0000000186468E80-0x0000000186468F10
		public void SetWorkingCollisionBoundsInfo(HmdQuad_t[] pQuadsBuffer) {} // 0x0000000186468CB0-0x0000000186468D40
		public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose) {} // 0x0000000186468F10-0x0000000186468F90
		public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose) {} // 0x0000000186468F90-0x0000000186469010
		public void ReloadFromDisk(EChaperoneConfigFile configFile) {} // 0x0000000186468BC0-0x0000000186468C40
		public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose) => default; // 0x0000000186468740-0x00000001864687D0
		public void SetWorkingCollisionBoundsTagsInfo(byte[] pTagsBuffer) {} // 0x0000000186468D40-0x0000000186468DE0
		public bool GetLiveCollisionBoundsTagsInfo(out byte[] pTagsBuffer) {
			pTagsBuffer = default;
			return default;
		} // 0x0000000186468540-0x0000000186468640
		public bool SetWorkingPhysicalBoundsInfo(HmdQuad_t[] pQuadsBuffer) => default; // 0x0000000186468DE0-0x0000000186468E80
		public bool GetLivePhysicalBoundsInfo(out HmdQuad_t[] pQuadsBuffer) {
			pQuadsBuffer = default;
			return default;
		} // 0x0000000186468640-0x0000000186468740
		public bool ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength) => default; // 0x00000001864683A0-0x0000000186468440
		public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags) => default; // 0x0000000186468B20-0x0000000186468BC0
	}
}
