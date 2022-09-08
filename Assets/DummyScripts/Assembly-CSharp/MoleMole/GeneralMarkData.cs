/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class GeneralMarkData // TypeDefIndex: 20979
	{
		// Fields
		public uint sceneID; // 0x10
		public MarkType markType; // 0x14
		public uint markID; // 0x18
		public Vector3 position; // 0x1C
		public MarkIconType iconType; // 0x28
		public BaseEntity entity; // 0x30
		public bool hideOnMove; // 0x38
		public bool hideIcon; // 0x39
		public MapMarkPoint mapMarkPoint; // 0x40
		public Vector3 positionOffset; // 0x48
		public TrackingGroup groupId; // 0x54
		public bool hideOnMapAndRadar; // 0x64
		public float radius; // 0x68
		public bool tracking; // 0x6C
		public bool deleteStopTrack; // 0x6D
		public uint? worldAreaID; // 0x70
		public bool showWhenAreaLocked; // 0x78
	
		// Properties
		public bool areaCheckPassed { /* [XID] */ /* 0x0000000189768380-0x00000001897683A0 */ get => default; } // 0x0000000181F88190-0x0000000181F882E0 
		public MarkManager.GeneralMarkID generalMarkID { /* [XID] */ /* 0x0000000189777290-0x00000001897772B0 */ get => default; } // 0x0000000181F882E0-0x0000000181F883D0 
		public Vector2 levelMapPos { /* [XID] */ /* 0x000000018977EA00-0x000000018977EA20 */ get => default; } // 0x0000000181F88480-0x0000000181F88570 
		public float height { /* [XID] */ /* 0x0000000189786180-0x00000001897861A0 */ get => default; } // 0x0000000181F883D0-0x0000000181F88480 
	
		// Constructors
		public GeneralMarkData() {} // 0x0000000181F88120-0x0000000181F88190
	
		// Methods
		// [XID] // 0x000000018976FA70-0x000000018976FA90
		public void Init(uint sceneID, MarkType markType, uint markID, Vector3 position, MarkIconType iconType, BaseEntity entity = null, bool _hideOnMove = false /* Metadata: 0x00AFE7EF */, Vector3? positionOffset = default, bool deleteStopTrack = false /* Metadata: 0x00AFE7F0 */, TrackingGroup groupId = default) {} // 0x0000000181F87EA0-0x0000000181F88120
	}
}
