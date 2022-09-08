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
	public struct IVRChaperoneSetup // TypeDefIndex: 6262
	{
		// Fields
		internal _CommitWorkingCopy CommitWorkingCopy; // 0x00
		internal _RevertWorkingCopy RevertWorkingCopy; // 0x08
		internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize; // 0x10
		internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect; // 0x18
		internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo; // 0x20
		internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo; // 0x28
		internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose; // 0x30
		internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose; // 0x38
		internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize; // 0x40
		internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo; // 0x48
		internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose; // 0x50
		internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose; // 0x58
		internal _ReloadFromDisk ReloadFromDisk; // 0x60
		internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose; // 0x68
		internal _SetWorkingCollisionBoundsTagsInfo SetWorkingCollisionBoundsTagsInfo; // 0x70
		internal _GetLiveCollisionBoundsTagsInfo GetLiveCollisionBoundsTagsInfo; // 0x78
		internal _SetWorkingPhysicalBoundsInfo SetWorkingPhysicalBoundsInfo; // 0x80
		internal _GetLivePhysicalBoundsInfo GetLivePhysicalBoundsInfo; // 0x88
		internal _ExportLiveToBuffer ExportLiveToBuffer; // 0x90
		internal _ImportFromBufferToWorking ImportFromBufferToWorking; // 0x98
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile); // TypeDefIndex: 6263; 0x00000001864765A0-0x0000000186476730
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _RevertWorkingCopy(); // TypeDefIndex: 6264; 0x00000001864844D0-0x0000000186484630
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ); // TypeDefIndex: 6265; 0x000000018647FFF0-0x00000001864801B0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect); // TypeDefIndex: 6266; 0x000000018647FC50-0x000000018647FDE0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount); // TypeDefIndex: 6267; 0x000000018647F7D0-0x000000018647FA80
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetLiveCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount); // TypeDefIndex: 6268; 0x000000018647D840-0x000000018647DAF0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose); // TypeDefIndex: 6269; 0x0000000186480380-0x0000000186480510
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose); // TypeDefIndex: 6270; 0x00000001864806E0-0x0000000186480870
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ); // TypeDefIndex: 6271; 0x0000000186486160-0x0000000186486320
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount); // TypeDefIndex: 6272; 0x0000000186485440-0x00000001864856F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose); // TypeDefIndex: 6273; 0x00000001864864E0-0x0000000186486670
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose); // TypeDefIndex: 6274; 0x0000000186486830-0x00000001864869C0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile); // TypeDefIndex: 6275; 0x0000000186483AD0-0x0000000186483C60
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose); // TypeDefIndex: 6276; 0x000000018647E5C0-0x000000018647E750
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetWorkingCollisionBoundsTagsInfo([In, Out] byte[] pTagsBuffer, uint unTagCount); // TypeDefIndex: 6277; 0x0000000186485890-0x0000000186485B40
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetLiveCollisionBoundsTagsInfo([In, Out] byte[] pTagsBuffer, ref uint punTagCount); // TypeDefIndex: 6278; 0x000000018647DCC0-0x000000018647DF70
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _SetWorkingPhysicalBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount); // TypeDefIndex: 6279; 0x0000000186485D00-0x0000000186485FB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetLivePhysicalBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount); // TypeDefIndex: 6280; 0x000000018647E140-0x000000018647E3F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength); // TypeDefIndex: 6281; 0x0000000186477480-0x0000000186477730
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _ImportFromBufferToWorking(string pBuffer, uint nImportFlags); // TypeDefIndex: 6282; 0x0000000186480DB0-0x0000000186481060
	}
}
