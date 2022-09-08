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

public class RecordData // TypeDefIndex: 31808
{
	// Fields
	public List<FrameData> frameData; // 0x10

	// Properties
	public FrameData currentFrameData { /* [XID] */ /* 0x0000000189674010-0x0000000189674030 */ get => default; } // 0x00000001832FCAB0-0x00000001832FCBB0 

	// Nested types
	public class FrameDebugData // TypeDefIndex: 31809
	{
		// Fields
		public List<string> debugString; // 0x10
		public List<DebugLine> debugLines; // 0x18
		public List<DebugSphere> debugSphere; // 0x20

		// Nested types
		public struct DebugLine // TypeDefIndex: 31810
		{
			// Fields
			public Vector3 from; // 0x00
			public Vector3 to; // 0x0C
			public Color color; // 0x18
		}

		public struct DebugSphere // TypeDefIndex: 31811
		{
			// Fields
			public Vector3 pos; // 0x00
			public float radius; // 0x0C
			public Color color; // 0x10
		}

		// Constructors
		public FrameDebugData() {} // 0x00000001833150B0-0x0000000183315180

		// Methods
		// [Conditional] // 0x000000018967B8D0-0x000000018967B920
		// [XID] // 0x000000018967B8D0-0x000000018967B920
		public void AddDebugString(string str) {} // 0x0000000183314E60-0x0000000183314F30
		// [Conditional] // 0x0000000189685E10-0x0000000189685E60
		// [XID] // 0x0000000189685E10-0x0000000189685E60
		public void AddDebugLine(Vector3 from, Vector3 to, Color color) {} // 0x0000000183314F30-0x00000001833150B0
		// [Conditional] // 0x0000000189690FE0-0x0000000189691030
		// [XID] // 0x0000000189690FE0-0x0000000189691030
		public void AddDebugSphere(Vector3 pos, float radius, Color color) {} // 0x0000000183314D10-0x0000000183314E60
	}

	public class ObjectFrameData // TypeDefIndex: 31812
	{
		// Fields
		public Vector3 position; // 0x10
		public Quaternion rotation; // 0x1C
		public Vector3 localScale; // 0x2C

		// Constructors
		public ObjectFrameData() {} // 0x00000001832F6ED0-0x00000001832F6F30

		// Methods
		// [XID] // 0x000000018969B370-0x000000018969B390
		public void SetFromTransform(Transform tf) {} // 0x00000001832F6DC0-0x00000001832F6ED0
	}

	public class FrameData // TypeDefIndex: 31813
	{
		// Fields
		public List<ObjectFrameData> objestsData; // 0x10
		public List<Transform> targetTFs; // 0x18
		public FrameDebugData debugData; // 0x20

		// Constructors
		public FrameData() {} // 0x0000000183317870-0x0000000183317940
	}

	// Constructors
	public RecordData() {} // 0x00000001832FCBB0-0x00000001832FCC40
}

