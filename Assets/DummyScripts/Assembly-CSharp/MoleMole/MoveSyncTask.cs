/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public struct MoveSyncTask // TypeDefIndex: 20637
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector3 velocity; // 0x0C
		public Vector3 forward; // 0x18
		public Vector3 up; // 0x24
		public Quaternion rotation; // 0x30
		public MotionState motion; // 0x40
		public int paramNumber; // 0x44
		public Vector3 param0; // 0x48
		public Vector3 param1; // 0x54
		public Vector3 param2; // 0x60
		public Vector3 param3; // 0x6C
		public uint time; // 0x78
		public uint reliableSeq; // 0x7C
		public uint clientSequenceId; // 0x80
		public uint subSequenceId; // 0x84
		public bool reliable; // 0x88
		public bool isFake; // 0x89
		public Vector3 refPosition; // 0x8C
		public uint refEntityId; // 0x98
		public uint refEntityTimestamp; // 0x9C
		public bool hasValue; // 0xA0
		public Vector3 positionRS; // 0xA4
		public Vector3 positionRSLocal; // 0xB0
		private static StringBuilder stb; // 0x00
	
		// Constructors
		static MoveSyncTask() {
			stb = default;
		} // 0x00000001824B0B40-0x00000001824B0E70
	
		// Methods
		// [XID] // 0x0000000189B949B0-0x0000000189B949D0
		public void UpdatePostionRS(VCScenePropAccurateMoveBase referenceSystem) {} // 0x00000001824AFAF0-0x00000001824AFBC0
		// [XID] // 0x0000000189B9C060-0x0000000189B9C080
		public DualClientSequenceId GetClientSequenceId() => default; // 0x00000001824AFBC0-0x00000001824AFDB0
		// [XID] // 0x0000000189BA37F0-0x0000000189BA3810
		public void SetClientSequenceId(DualClientSequenceId dualId) {} // 0x00000001824AFE80-0x00000001824B0380
		// [XID] // 0x0000000189BAAB60-0x0000000189BAAB80
		public bool IsReliable() => default; // 0x00000001824AF5F0-0x00000001824AF780
		// [XID] // 0x0000000189BB2130-0x0000000189BB2150
		public override string ToString() => default; // 0x00000001824B0B30-0x00000001824B0B40
		// [XID] // 0x0000000189BB9520-0x0000000189BB9540
		public string GetLogDetailString() => default; // 0x00000001824AF530-0x00000001824AF5F0
		// [XID] // 0x0000000189BC1360-0x0000000189BC1380
		public bool HasSameComparablePart(MoveSyncTask task) => default; // 0x00000001824B0650-0x00000001824B0B30
		// [XID] // 0x0000000189BC8BE0-0x0000000189BC8C00
		public void CopyComparablePart(MoveSyncTask task) {} // 0x00000001824AF780-0x00000001824AFAF0
		// [Conditional] // 0x0000000189BD0390-0x0000000189BD03E0
		// [XID] // 0x0000000189BD0390-0x0000000189BD03E0
		public void DrawAddTask(MoveSyncTask? from = default) {} // 0x00000001824B0380-0x00000001824B0650
		// [Conditional] // 0x0000000189BDAB90-0x0000000189BDABE0
		// [XID] // 0x0000000189BDAB90-0x0000000189BDABE0
		public void DrawDiscardTask() {} // 0x00000001824AFDB0-0x00000001824AFE80
		// [Conditional] // 0x00000001895EA920-0x00000001895EA970
		// [XID] // 0x00000001895EA920-0x00000001895EA970
		public void DrawHandleTask() {} // 0x00000001824AEBD0-0x00000001824AEE10
		// [Conditional] // 0x00000001895F4E80-0x00000001895F4ED0
		// [XID] // 0x00000001895F4E80-0x00000001895F4ED0
		public void DrawRemainingTask(bool eariliest = false /* Metadata: 0x00AFDF50 */) {} // 0x00000001824AEE10-0x00000001824AF530
	}
}
