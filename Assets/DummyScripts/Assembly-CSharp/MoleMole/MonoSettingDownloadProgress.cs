/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoSettingDownloadProgress : MonoBehaviour // TypeDefIndex: 31037
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textLabel; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textProgressLabel; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _mask; // 0x28
	
		// Properties
		public string contentText { /* [XID] */ /* 0x0000000189A7B1E0-0x0000000189A7B200 */ set {} } // 0x0000000184119170-0x0000000184119240
		public string progressText { /* [XID] */ /* 0x0000000189A828E0-0x0000000189A82900 */ set {} } // 0x0000000184119240-0x0000000184119310
		public float progress { /* [XID] */ /* 0x0000000189A91A70-0x0000000189A91A90 */ get => default; /* [XID] */ /* 0x0000000189A8A2F0-0x0000000189A8A310 */ set {} } // 0x00000001841190B0-0x0000000184119170 0x0000000184119310-0x00000001841193D0
		public Button cancelButton { /* [XID] */ /* 0x0000000189A99510-0x0000000189A99530 */ get => default; } // 0x0000000184118FD0-0x00000001841190B0 
	
		// Constructors
		public MonoSettingDownloadProgress() {} // 0x0000000184118F70-0x0000000184118FD0
	}
}
