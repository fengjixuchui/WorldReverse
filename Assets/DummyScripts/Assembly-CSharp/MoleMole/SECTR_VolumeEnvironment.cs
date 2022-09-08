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
	public class SECTR_VolumeEnvironment : SECTR_BaseVolume // TypeDefIndex: 31918
	{
		// Fields
		public List<SECTR_VolumeShape> insideAreas; // 0x30
		public List<Vector3> posOffSets; // 0x38
		public List<Vector3> forwardOffSets; // 0x40
		public string envPathEnter; // 0x48
		public string envPathExit; // 0x50
		public int envEnterPriority; // 0x58
		public int envExitPriority; // 0x5C
		public float transitTimeEnter; // 0x60
		public float transitTimeExit; // 0x64
		public float ratioEnter; // 0x68
		public float ratioExit; // 0x6C
		private bool _isLoaded; // 0x70
		public string entityTickStrategyDRPattern; // 0x78
		private EntityTickStrategyDistRatioConfig _entityTickStrategyDRConfig; // 0x80
		private uint _curEntityTickStrategyDRConfigHandle; // 0x88
	
		// Constructors
		public SECTR_VolumeEnvironment() {} // 0x0000000184EEA100-0x0000000184EEA200
	
		// Methods
		// [XID] // 0x00000001899528B0-0x00000001899528D0
		public override void Load() {} // 0x0000000184EE97F0-0x0000000184EE9E40
		// [XID] // 0x0000000189959E90-0x0000000189959EB0
		public override void Unload() {} // 0x0000000184EEA050-0x0000000184EEA100
		// [XID] // 0x0000000189961860-0x0000000189961880
		public override void ActiveVolume() {} // 0x0000000184EE8F70-0x0000000184EE9120
		// [XID] // 0x0000000189968F70-0x0000000189968F90
		public override void DeactiveVolume() {} // 0x0000000184EE9270-0x0000000184EE9470
		// [XID] // 0x00000001899709D0-0x00000001899709F0
		public override bool IsPosInVolume(Vector3 pos) => default; // 0x0000000184EE9640-0x0000000184EE9790
		// [XID] // 0x0000000189978390-0x00000001899783B0
		public override bool FilterLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EE9470-0x0000000184EE9520
		// [XID] // 0x000000018997F4A0-0x000000018997F4C0
		public override bool RemoveLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EE9F90-0x0000000184EEA050
		// [XID] // 0x0000000189986E40-0x0000000189986E60
		public override Type GetVolumeType() => default; // 0x0000000184EE9520-0x0000000184EE95C0
	}
}
