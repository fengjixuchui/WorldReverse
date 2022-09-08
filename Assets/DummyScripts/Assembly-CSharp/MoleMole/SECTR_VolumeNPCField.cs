/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class SECTR_VolumeNPCField : SECTR_BaseVolume // TypeDefIndex: 31920
	{
		// Fields
		public SECTR_VolumeShape insideArea; // 0x30
		public float appearDist; // 0x38
		public float disappearDist; // 0x3C
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private bool _isLoaded; // 0x40
	
		// Constructors
		public SECTR_VolumeNPCField() {} // 0x0000000184EEB450-0x0000000184EEB530
	
		// Methods
		// [XID] // 0x00000001899B48B0-0x00000001899B48D0
		private void InitAreas() {} // 0x0000000184EEAB40-0x0000000184EEAD20
		// [XID] // 0x00000001899BBF20-0x00000001899BBF40
		public override void Load() {} // 0x0000000184EEB040-0x0000000184EEB1A0
		// [XID] // 0x00000001899C3A50-0x00000001899C3A70
		public override void Unload() {} // 0x0000000184EEB3A0-0x0000000184EEB450
		// [XID] // 0x00000001899CB050-0x00000001899CB070
		public override void ActiveVolume() {} // 0x0000000184EEA840-0x0000000184EEA920
		// [XID] // 0x00000001899D25A0-0x00000001899D25C0
		public override void DeactiveVolume() {} // 0x0000000184EEAA70-0x0000000184EEAB40
		// [XID] // 0x00000001899D9C80-0x00000001899D9CA0
		public override bool IsPosInVolume(Vector3 pos) => default; // 0x0000000184EEAEF0-0x0000000184EEAFE0
		// [XID] // 0x00000001899E1570-0x00000001899E1590
		public override bool FilterLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EEAD20-0x0000000184EEADD0
		// [XID] // 0x00000001899E8C80-0x00000001899E8CA0
		public override bool RemoveLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EEB2F0-0x0000000184EEB3A0
		// [XID] // 0x00000001899F05E0-0x00000001899F0600
		public override Type GetVolumeType() => default; // 0x0000000184EEADD0-0x0000000184EEAE70
	}
}
