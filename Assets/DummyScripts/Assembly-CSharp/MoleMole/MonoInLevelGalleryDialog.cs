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
	public class MonoInLevelGalleryDialog : MonoBehaviour // TypeDefIndex: 31223
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _tipsTrans; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tips; // 0x20
		private ulong _prevTickTime; // 0x28
		private ulong _deadline; // 0x30
		private bool _useLevelTime; // 0x38
	
		// Properties
		public UnityEngine.UI.Text tips { /* [XID] */ /* 0x0000000189758D70-0x0000000189758D90 */ get => default; } // 0x00000001847103B0-0x0000000184710450 
		public ulong deadline { /* [XID] */ /* 0x0000000189767D30-0x0000000189767D50 */ get => default; /* [XID] */ /* 0x000000018976F2C0-0x000000018976F2E0 */ set {} } // 0x00000001847102B0-0x0000000184710350 0x0000000184710450-0x0000000184710500
		public ulong spanSeconds { /* [XID] */ /* 0x0000000189776D00-0x0000000189776D40 */ get; /* [XID] */ /* 0x0000000189781850-0x0000000189781890 */ private set; } // 0x0000000184710350-0x00000001847103B0 0x000000018470FC50-0x000000018470FCB0
	
		// Constructors
		public MonoInLevelGalleryDialog() {} // 0x0000000184710230-0x00000001847102B0
	
		// Methods
		// [XID] // 0x0000000189760A50-0x0000000189760A70
		public void SetTipsVisible(bool bVis) {} // 0x000000018470FFA0-0x0000000184710080
		// [XID] // 0x000000018978BCA0-0x000000018978BCC0
		public void Tick(bool force = false /* Metadata: 0x00B12081 */) {} // 0x0000000184710080-0x0000000184710230
		// [XID] // 0x0000000189793150-0x0000000189793170
		public void Reset() {} // 0x000000018470FCB0-0x000000018470FDB0
		// [XID] // 0x000000018979B420-0x000000018979B440
		public void SetCountdownText(ulong spanSeconds) {} // 0x000000018470FDB0-0x000000018470FEF0
		// [XID] // 0x00000001897A28C0-0x00000001897A28E0
		public void SetCountdownType(bool useLevelTime) {} // 0x000000018470FEF0-0x000000018470FFA0
	}
}
