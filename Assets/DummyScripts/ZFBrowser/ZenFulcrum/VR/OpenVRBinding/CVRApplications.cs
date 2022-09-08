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
	public class CVRApplications // TypeDefIndex: 6467
	{
		// Fields
		private IVRApplications FnTable; // 0x10
	
		// Constructors
		public CVRApplications() {} // Dummy constructor
		internal CVRApplications(IntPtr pInterface) {} // 0x00000001856A5290-0x00000001856A5430
	
		// Methods
		public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary) => default; // 0x00000001856A3FE0-0x00000001856A4080
		public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath) => default; // 0x00000001856A50C0-0x00000001856A5150
		public bool IsApplicationInstalled(string pchAppKey) => default; // 0x00000001856A4C10-0x00000001856A4CA0
		public uint GetApplicationCount() => default; // 0x00000001856A41A0-0x00000001856A4220
		public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) => default; // 0x00000001856A4220-0x00000001856A42C0
		public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen) => default; // 0x00000001856A42C0-0x00000001856A4360
		public EVRApplicationError LaunchApplication(string pchAppKey) => default; // 0x00000001856A4DC0-0x00000001856A4E50
		public EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, AppOverrideKeys_t[] pKeys) => default; // 0x00000001856A4F80-0x00000001856A5030
		public EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType, string pchArgs) => default; // 0x00000001856A4D20-0x00000001856A4DC0
		public EVRApplicationError LaunchDashboardOverlay(string pchAppKey) => default; // 0x00000001856A4E50-0x00000001856A4EE0
		public bool CancelApplicationLaunch(string pchAppKey) => default; // 0x00000001856A4080-0x00000001856A4110
		public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey) => default; // 0x00000001856A4B80-0x00000001856A4C10
		public uint GetApplicationProcessId(string pchAppKey) => default; // 0x00000001856A4400-0x00000001856A4490
		public string GetApplicationsErrorNameFromEnum(EVRApplicationError error) => default; // 0x00000001856A4730-0x00000001856A47E0
		public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError) => default; // 0x00000001856A4530-0x00000001856A45F0
		public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError) => default; // 0x00000001856A4490-0x00000001856A4530
		public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError) => default; // 0x00000001856A45F0-0x00000001856A4690
		public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch) => default; // 0x00000001856A5150-0x00000001856A51F0
		public bool GetApplicationAutoLaunch(string pchAppKey) => default; // 0x00000001856A4110-0x00000001856A41A0
		public EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType) => default; // 0x00000001856A51F0-0x00000001856A5290
		public bool GetDefaultApplicationForMimeType(string pchMimeType, string pchAppKeyBuffer, uint unAppKeyBufferLen) => default; // 0x00000001856A49C0-0x00000001856A4A60
		public bool GetApplicationSupportedMimeTypes(string pchAppKey, string pchMimeTypesBuffer, uint unMimeTypesBuffer) => default; // 0x00000001856A4690-0x00000001856A4730
		public uint GetApplicationsThatSupportMimeType(string pchMimeType, string pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer) => default; // 0x00000001856A47E0-0x00000001856A4880
		public uint GetApplicationLaunchArguments(uint unHandle, string pchArgs, uint unArgs) => default; // 0x00000001856A4360-0x00000001856A4400
		public EVRApplicationError GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen) => default; // 0x00000001856A4A60-0x00000001856A4B00
		public EVRApplicationTransitionState GetTransitionState() => default; // 0x00000001856A4B00-0x00000001856A4B80
		public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey) => default; // 0x00000001856A5030-0x00000001856A50C0
		public string GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state) => default; // 0x00000001856A4880-0x00000001856A4940
		public bool IsQuitUserPromptRequested() => default; // 0x00000001856A4CA0-0x00000001856A4D20
		public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory) => default; // 0x00000001856A4EE0-0x00000001856A4F80
		public uint GetCurrentSceneProcessId() => default; // 0x00000001856A4940-0x00000001856A49C0
	}
}
