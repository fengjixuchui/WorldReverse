/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StatFrameUnits : SingletonStat<StatFrameUnits> // TypeDefIndex: 27877
{
	// Fields
	public StatAverage frameTime; // 0x38
	public StatAverage gameTime; // 0x48
	public StatAverage emPhysicsTime; // 0x58
	public StatAverage renderTime; // 0x68
	public StatAverage renderCommandThreadTime; // 0x78
	public StatAverage drawCalls; // 0x88
	public StatAverage drawPrims; // 0x98
	public StatAverage entityCount; // 0xA8
	public StatAverage massiveEntityCount; // 0xB8
	public StatAverage dynamicObjectCount; // 0xC8
	private List<SessionData> data; // 0xD8
	private int _discardFrameCount; // 0xE0
	private StatLog.TimestampLogger tsJson; // 0xE8
	private StatLog.TimestampLogger ts; // 0xF0

	// Properties
	private bool bWithJson { /* [XID] */ /* 0x0000000189BA1CB0-0x0000000189BA1CD0 */ get => default; } // 0x00000001826212C0-0x0000000182621370 

	// Nested types
	public struct SessionData // TypeDefIndex: 27878
	{
		// Fields
		public Vector3 CamPosition; // 0x00
		public Quaternion CamRotation; // 0x0C
		public Vector3 PlayerPosition; // 0x1C
		public Quaternion PlayerRotation; // 0x28
		public StatFrameData frameData; // 0x38
		public double entityCount; // 0x130
		public double massiveEntityCount; // 0x138
		public double dynamicObjects; // 0x140

		// Nested types
		[Serializable]
		public class FrameUnitPlainData // TypeDefIndex: 27879
		{
			// Fields
			public int id; // 0x10
			public double frameTime; // 0x18
			public double totalSystemMemory; // 0x20
			public double gameTime; // 0x28
			public double physicsTime; // 0x30
			public double renderTime; // 0x38
			public double renderCommandThreadTime; // 0x40
			public double drawcalls; // 0x48
			public double drawPrims; // 0x50
			public string CamPosition; // 0x58
			public string CamRotation; // 0x60
			public string PlayerPosition; // 0x68
			public string PlayerRotation; // 0x70
			public double entityCount; // 0x78
			public double nonMassiveEntityCount; // 0x80
			public double massiveEntityCount; // 0x88
			public int dynamicObjects; // 0x90
			public int unixTimeStamp; // 0x94
			public float entityBudget; // 0x98
			public string snapShotUrl; // 0xA0
			public List<MonoECPDebugInfo.FrameEntityCatergoryCountPlainData> entityInfo; // 0xA8

			// Constructors
			public FrameUnitPlainData() {} // Dummy constructor
			public FrameUnitPlainData(SessionData inData, int inId) {} // 0x000000018260FB20-0x000000018260FD30

			// Methods
			// [XID] // 0x0000000189600B00-0x0000000189600B20
			public string ToJson() => default; // 0x000000018260FA70-0x000000018260FB20
		}

		// Constructors
		public SessionData(ref StatFrameData sd, double inEntityCount, double inMassiveEntityCount) {
			CamPosition = default;
			CamRotation = default;
			PlayerPosition = default;
			PlayerRotation = default;
			frameData = default;
			entityCount = default;
			massiveEntityCount = default;
			dynamicObjects = default;
		} // 0x0000000182630650-0x00000001826308E0

		// Methods
		// [XID] // 0x00000001895EA630-0x00000001895EA650
		public static string GenCSVFirstLine() => default; // 0x000000018262FBA0-0x0000000182630480
		// [XID] // 0x00000001895F1B10-0x00000001895F1B30
		public string ToCSVString(int id) => default; // 0x0000000182630480-0x0000000182630650
		// [XID] // 0x00000001895F94D0-0x00000001895F94F0
		public FrameUnitPlainData ToJson(int id) => default; // 0x000000018262FB90-0x000000018262FBA0
	}

	[Serializable]
	private class FrameEntityUnitInfo // TypeDefIndex: 27880
	{
		// Fields
		public List<SessionData.FrameUnitPlainData> data; // 0x10

		// Constructors
		public FrameEntityUnitInfo() {} // Dummy constructor
		public FrameEntityUnitInfo(List<SessionData.FrameUnitPlainData> inData) {} // 0x000000018260FA00-0x000000018260FA70
	}

	// Constructors
	public StatFrameUnits() {} // 0x0000000182622180-0x0000000182622230

	// Methods
	// [XID] // 0x00000001897DD5C0-0x00000001897DD5E0
	public void SetWithJson() {} // 0x0000000182621090-0x0000000182621200
	// [XID] // 0x0000000189BB07E0-0x0000000189BB0800
	private void OnAnalyzeFrame(ref StatFrameData inFrameData) {} // 0x00000001826215A0-0x00000001826217A0
	// [XID] // 0x0000000189BB7B00-0x0000000189BB7B20
	public static void Pause() {} // 0x0000000182620FD0-0x0000000182621090
	// [XID] // 0x0000000189791820-0x0000000189791840
	public static void Continue() {} // 0x0000000182621200-0x00000001826212C0
	// [XID] // 0x0000000189BC6E50-0x0000000189BC6E70
	protected override void OnClearAll() {} // 0x0000000182621E80-0x0000000182621FA0
	// [XID] // 0x0000000189BCEAE0-0x0000000189BCEB00
	protected override void OnTakeSnapshot(bool bDetailMode) {} // 0x00000001826217A0-0x0000000182621E80
	// [XID] // 0x0000000189BD5DE0-0x0000000189BD5E00
	protected override void OnStart(string inSessionID) {} // 0x0000000182621370-0x00000001826215A0
	// [XID] // 0x0000000189BDDA70-0x0000000189BDDA90
	protected override void OnStop() {} // 0x0000000182621FA0-0x0000000182622180
}

