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
	public class SECTR_VolumeStream : SECTR_BaseVolume // TypeDefIndex: 31924
	{
		// Fields
		public List<SECTR_VolumeShape> insideAreas; // 0x30
		public List<Vector3> inPosOffsets; // 0x38
		public List<Vector3> inForwardOffsets; // 0x40
		public List<SECTR_VolumeShape> outsideAreas; // 0x48
		public List<Vector3> outPosOffsets; // 0x50
		public List<Vector3> outForwardOffsets; // 0x58
		public string targetPattern; // 0x60
		private SECTR_StreamingProfileRatioConfig _targetProfile; // 0x68
		private uint _curStreamProfileHandle; // 0x70
		private bool isVolumeActive; // 0x74
		private bool _isLoaded; // 0x75
		public Vector3 volumeCenter; // 0x78
		public float volumeRadius; // 0x84
		public string entityTickStrategyDRPattern; // 0x88
		private EntityTickStrategyDistRatioConfig _entityTickStrategyDRConfig; // 0x90
		private uint _curEntityTickStrategyDRConfigHandle; // 0x98
	
		// Constructors
		public SECTR_VolumeStream() {} // 0x0000000184EEF4D0-0x0000000184EEF660
	
		// Methods
		// [XID] // 0x0000000189A6ED90-0x0000000189A6EDB0
		public override void Load() {} // 0x0000000184EEE710-0x0000000184EEF170
		// [XID] // 0x0000000189A76540-0x0000000189A76560
		public override void Unload() {} // 0x0000000184EEF380-0x0000000184EEF4D0
		// [XID] // 0x0000000189A7DEC0-0x0000000189A7DEE0
		public override void ActiveVolume() {} // 0x0000000184EEDEA0-0x0000000184EEE020
		// [XID] // 0x0000000189A85880-0x0000000189A858A0
		public override void DeactiveVolume() {} // 0x0000000184EEE170-0x0000000184EEE270
		// [XID] // 0x0000000189A8D0D0-0x0000000189A8D0F0
		public override bool IsPosInVolume(Vector3 pos) => default; // 0x0000000184EEE440-0x0000000184EEE6B0
		// [XID] // 0x0000000189A946B0-0x0000000189A946D0
		public override bool FilterLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EEE270-0x0000000184EEE320
		// [XID] // 0x0000000189A9BF60-0x0000000189A9BF80
		public override bool RemoveLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EEF2C0-0x0000000184EEF380
		// [XID] // 0x0000000189AA3600-0x0000000189AA3620
		public override Type GetVolumeType() => default; // 0x0000000184EEE320-0x0000000184EEE3C0
	}
}
