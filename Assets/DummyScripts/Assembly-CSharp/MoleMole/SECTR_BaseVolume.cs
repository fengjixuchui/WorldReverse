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
	[fiInspectorOnly] // 0x0000000189ABD060-0x0000000189ABD070
	public class SECTR_BaseVolume : MonoBehaviour, ISECTR_BaseProxy, ISECTR_BaseVolume // TypeDefIndex: 31871
	{
		// Fields
		private Vector3 _lastCheckPos; // 0x18
		public float updateIntervalDis; // 0x24
		public float radius; // 0x28
	
		// Nested types
		public enum Type // TypeDefIndex: 31872
		{
			Invalid = 0,
			Cave = 1,
			BattleArea = 2,
			Field = 3,
			StreamConfig = 4,
			StreamPortal = 5,
			NPCField = 6,
			Environment = 7
		}
	
		public enum LODType // TypeDefIndex: 31873
		{
			LOD = 0,
			HLOD = 1,
			HLODObject = 2,
			Sector = 3
		}
	
		// Constructors
		public SECTR_BaseVolume() {} // 0x0000000184EE51C0-0x0000000184EE5270
	
		// Methods
		// [XID] // 0x0000000189AC4AE0-0x0000000189AC4B00
		public virtual Type GetVolumeType() => default; // 0x0000000184EE4730-0x0000000184EE47D0
		// [XID] // 0x0000000189ACC120-0x0000000189ACC140
		public virtual bool ValidToUpdate(Vector3 curPos) => default; // 0x0000000184EE5050-0x0000000184EE51C0
		// [XID] // 0x0000000189AD3C00-0x0000000189AD3C20
		public virtual bool IsPosInVolume(Vector3 pos) => default; // 0x0000000184EE4870-0x0000000184EE4930
		// [XID] // 0x0000000189ADB700-0x0000000189ADB720
		public virtual bool InvalidInLoading() => default; // 0x0000000184EE47D0-0x0000000184EE4870
		// [XID] // 0x0000000189AE2F50-0x0000000189AE2F70
		public virtual bool FilterLod(ISECTR_LODLoader lod, LODType type) => default; // 0x0000000184EE4550-0x0000000184EE4620
		// [XID] // 0x0000000189AEA990-0x0000000189AEA9B0
		public virtual bool FilterLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EE44A0-0x0000000184EE4550
		// [XID] // 0x0000000189AF2280-0x0000000189AF22A0
		public virtual bool RemoveLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EE4D40-0x0000000184EE4DF0
		// [XID] // 0x0000000189AF9BA0-0x0000000189AF9BC0
		public virtual void ActiveVolume() {} // 0x0000000184EE4360-0x0000000184EE4400
		// [XID] // 0x0000000189B010B0-0x0000000189B010D0
		public virtual void DeactiveVolume() {} // 0x0000000184EE4400-0x0000000184EE44A0
		// [XID] // 0x0000000189B08680-0x0000000189B086A0
		public virtual bool ShouldFilterStreamPos() => default; // 0x0000000184EE4EA0-0x0000000184EE4F40
		// [XID] // 0x0000000189B0FF60-0x0000000189B0FF80
		public virtual Vector3 FilterStreamPos(Vector3 pos) => default; // 0x0000000184EE4620-0x0000000184EE4730
		// [XID] // 0x0000000189B170A0-0x0000000189B170C0
		public virtual void OnEnable() {} // 0x0000000184EE4C10-0x0000000184EE4D40
		// [XID] // 0x0000000189B1EAA0-0x0000000189B1EAC0
		public virtual void OnDisable() {} // 0x0000000184EE4AE0-0x0000000184EE4C10
		// [XID] // 0x0000000189B26330-0x0000000189B26350
		public virtual void Load() {} // 0x0000000184EE4930-0x0000000184EE4A40
		// [XID] // 0x0000000189B2D5A0-0x0000000189B2D5C0
		public virtual void Unload() {} // 0x0000000184EE4F40-0x0000000184EE5050
		// [XID] // 0x0000000189B34A80-0x0000000189B34AA0
		public string ReportLog() => default; // 0x0000000184EE4DF0-0x0000000184EE4EA0
		// [XID] // 0x0000000189B3C2D0-0x0000000189B3C2F0
		uint MoleMole.ISECTR_BaseProxy.GetRuntimeID() => default; // 0x0000000184EE4A40-0x0000000184EE4AE0
	}
}
