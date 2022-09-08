/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class GeneralLocalDataItem // TypeDefIndex: 19576
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string deviceUUID; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string userLocalDataVersionId; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int deviceLanguageType; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int deviceVoiceLanguageType; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string selectedServerName; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public uint localLevelIndex; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string deviceID; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string targetUID; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string curAccountName; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string uiSaveData; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string inputData; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string graphicsData; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int miniMapConfig; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool enableCameraSlope; // 0x6C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool enableCameraCombatLock; // 0x6D
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool completionPkg; // 0x6E
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool onlyPlayWithPSPlayer; // 0x6F
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool resinNotification; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool exploreNotification; // 0x71
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int volumeGlobal; // 0x74
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int volumeSFX; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int volumeMusic; // 0x7C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int volumeVoice; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int audioAPI; // 0x84
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool _audioSuccessInit; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool motionBlur; // 0x89
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool gyroAiming; // 0x8A
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool firstHDRSetting; // 0x8B
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float maxLuminosity; // 0x8C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float uiPaperWhite; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float scenePaperWhite; // 0x94
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<string> _overrideControllerMapKeyList; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<string> _overrideControllerMapValueList; // 0xA0
		public Dictionary<string, string> overrideControllerMap; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public ulong lastSeenPreDownloadTime; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool mtrCached; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool mtrIsOpen; // 0xB9
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int mtrMaxTTL; // 0xBC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int mtrTimeOut; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int mtrTraceCount; // 0xC4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int mtrAbortTimeOutCount; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int mtrAutoTraceInterval; // 0xCC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int mtrTraceCDEachReason; // 0xD0
	
		// Constructors
		public GeneralLocalDataItem() {} // 0x0000000181F87C60-0x0000000181F87EA0
	
		// Methods
		// [XID] // 0x0000000189871070-0x0000000189871090
		public void OnLoaded() {} // 0x0000000181F87AE0-0x0000000181F87C60
		// [XID] // 0x0000000189878A10-0x0000000189878A30
		public void OnSaving() {} // 0x0000000181F87880-0x0000000181F87AE0
	}
}
