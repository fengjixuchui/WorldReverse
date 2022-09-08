/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ChillyRoom.UnityEditor.iOS.Xcode;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode.Extensions
{
	public static class PBXProjectExtensions // TypeDefIndex: 10421
	{
		// Fields
		internal static FlagList appExtensionReleaseBuildFlags; // 0x00
		internal static FlagList appExtensionDebugBuildFlags; // 0x08
		internal static FlagList watchExtensionReleaseBuildFlags; // 0x10
		internal static FlagList watchExtensionDebugBuildFlags; // 0x18
		internal static FlagList watchAppReleaseBuildFlags; // 0x20
		internal static FlagList watchAppDebugBuildFlags; // 0x28
	
		// Nested types
		internal class FlagList : List<KeyValuePair<string, string>> // TypeDefIndex: 10422
		{
			// Constructors
			public FlagList() {} // 0x00000001864D9350-0x00000001864D93E0
	
			// Methods
			// [XID] // 0x0000000189727920-0x0000000189727940
			public void Add(string flag, string value) {} // 0x00000001864D9250-0x00000001864D9350
		}
	
		// Constructors
		static PBXProjectExtensions() {} // 0x00000001864E3A20-0x00000001864E4370
	
		// Extension methods
		// [XID] // 0x00000001896BF6C0-0x00000001896BF700
		private static void SetBuildFlagsFromDict(this PBXProject proj, string configGuid, IEnumerable<KeyValuePair<string, string>> data) {} // 0x00000001864E3230-0x00000001864E3480
		// [XID] // 0x00000001896C9C70-0x00000001896C9CB0
		internal static void SetDefaultAppExtensionReleaseBuildFlags(this PBXProject proj, string configGuid) {} // 0x00000001864E3570-0x00000001864E3660
		// [XID] // 0x00000001896D4220-0x00000001896D4260
		internal static void SetDefaultAppExtensionDebugBuildFlags(this PBXProject proj, string configGuid) {} // 0x00000001864E3480-0x00000001864E3570
		// [XID] // 0x00000001896DECF0-0x00000001896DED30
		internal static void SetDefaultWatchExtensionReleaseBuildFlags(this PBXProject proj, string configGuid) {} // 0x00000001864E3930-0x00000001864E3A20
		// [XID] // 0x00000001896E9110-0x00000001896E9150
		internal static void SetDefaultWatchExtensionDebugBuildFlags(this PBXProject proj, string configGuid) {} // 0x00000001864E3840-0x00000001864E3930
		// [XID] // 0x00000001896F3550-0x00000001896F3590
		internal static void SetDefaultWatchAppReleaseBuildFlags(this PBXProject proj, string configGuid) {} // 0x00000001864E3750-0x00000001864E3840
		// [XID] // 0x00000001896FDE10-0x00000001896FDE50
		internal static void SetDefaultWatchAppDebugBuildFlags(this PBXProject proj, string configGuid) {} // 0x00000001864E3660-0x00000001864E3750
		// [XID] // 0x00000001897082B0-0x00000001897082F0
		public static string AddAppExtension(this PBXProject proj, string mainTargetGuid, string name, string bundleId, string infoPlistPath) => default; // 0x00000001864E2720-0x00000001864E2AB0
		// [XID] // 0x0000000189712B10-0x0000000189712B50
		public static string AddWatchApp(this PBXProject proj, string mainTargetGuid, string watchExtensionTargetGuid, string name, string bundleId, string infoPlistPath) => default; // 0x00000001864E2AB0-0x00000001864E2F10
		// [XID] // 0x000000018971D2D0-0x000000018971D310
		public static string AddWatchExtension(this PBXProject proj, string mainTarget, string name, string bundleId, string infoPlistPath) => default; // 0x00000001864E2F10-0x00000001864E3230
	}
}
