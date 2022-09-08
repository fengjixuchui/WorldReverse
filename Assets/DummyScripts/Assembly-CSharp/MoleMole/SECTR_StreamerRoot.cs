/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class SECTR_StreamerRoot : MonoBehaviour // TypeDefIndex: 31906
	{
		// Fields
		public string configName; // 0x18
		public string worldName; // 0x20
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		public List<string> SectorNameList; // 0x28
	
		// Constructors
		public SECTR_StreamerRoot() {} // 0x0000000184EE6A30-0x0000000184EE6AC0
	
		// Methods
		// [XID] // 0x00000001896A11D0-0x00000001896A11F0
		public void OnEnable() {} // 0x0000000184EE6780-0x0000000184EE68F0
		// [XID] // 0x00000001896A86C0-0x00000001896A86E0
		public void OnDisable() {} // 0x0000000184EE6670-0x0000000184EE6780
		// [XID] // 0x00000001896AF870-0x00000001896AF890
		private void LoadWhiteBoxs() {} // 0x0000000184EE5D30-0x0000000184EE6330
		// [XID] // 0x00000001896B71B0-0x00000001896B71D0
		public void LoadAllIndex() {} // 0x0000000184EE6330-0x0000000184EE6670
		// [XID] // 0x00000001896BE2C0-0x00000001896BE2E0
		public void CreateAllSectors() {} // 0x0000000184EE58E0-0x0000000184EE5D30
		[DebuggerHidden] // 0x00000001896C5B50-0x00000001896C5B90
		// [XID] // 0x00000001896C5B50-0x00000001896C5B90
		public IEnumerator PreloadAllSectorsAsync(Transform trans, Action<float> progressCB = null) => default; // 0x0000000184EE68F0-0x0000000184EE6A30
	}
}
