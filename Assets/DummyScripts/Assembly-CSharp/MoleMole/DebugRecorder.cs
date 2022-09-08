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
	[DisallowMultipleComponent] // 0x00000001898F1200-0x00000001898F1210
	public class DebugRecorder : MonoBehaviour // TypeDefIndex: 31814
	{
		// Fields
		private static DebugRecorder instance; // 0x00
		private RecordSessionContext curRecordSession; // 0x18
	
		// Nested types
		public class RecordSessionContext // TypeDefIndex: 31815
		{
			// Fields
			public RecordData data; // 0x10
	
			// Constructors
			public RecordSessionContext() {} // 0x0000000184D76AD0-0x0000000184D76B60
	
			// Methods
			// [XID] // 0x0000000189709F50-0x0000000189709F70
			public void NewFrame() {} // 0x0000000184D76940-0x0000000184D76A30
			// [XID] // 0x00000001897119D0-0x00000001897119F0
			public void EndFrame() {} // 0x0000000184D76A30-0x0000000184D76AD0
		}
	
		// Constructors
		public DebugRecorder() {} // 0x0000000184D808E0-0x0000000184D80950
		static DebugRecorder() {} // 0x0000000184D80880-0x0000000184D808E0
	
		// Methods
		// [Conditional] // 0x00000001896A9F20-0x00000001896A9F70
		// [XID] // 0x00000001896A9F20-0x00000001896A9F70
		public static void RecordDebugDrawLine(Vector3 from, Vector3 to, Color color) {} // 0x0000000184D7FF60-0x0000000184D80190
		// [Conditional] // 0x00000001896B4400-0x00000001896B4450
		// [XID] // 0x00000001896B4400-0x00000001896B4450
		public static void RecordDebugDrawSphere(Vector3 center, float radius, Color color) {} // 0x0000000184D80190-0x0000000184D803A0
		// [Conditional] // 0x00000001896BE2E0-0x00000001896BE330
		// [XID] // 0x00000001896BE2E0-0x00000001896BE330
		public static void RecordDrawSkeleton(GameObject root, float radius, Color color) {} // 0x0000000184D80530-0x0000000184D80880
		// [Conditional] // 0x00000001896C87F0-0x00000001896C8840
		// [XID] // 0x00000001896C87F0-0x00000001896C8840
		public static void RecordDebugString(string str) {} // 0x0000000184D803A0-0x0000000184D80530
		// [XID] // 0x00000001896D2C90-0x00000001896D2CB0
		public void BeginRecord() {} // 0x0000000184D7F870-0x0000000184D7F970
		// [XID] // 0x00000001896DA7A0-0x00000001896DA7C0
		public RecordData EndRecord() => default; // 0x0000000184D7FAE0-0x0000000184D7FBF0
		// [XID] // 0x00000001896E1F70-0x00000001896E1F90
		public void BeginRecordFrame() {} // 0x0000000184D7F7C0-0x0000000184D7F870
		// [XID] // 0x00000001896E9440-0x00000001896E9460
		public void EndRecordFrame() {} // 0x0000000184D7FA40-0x0000000184D7FAE0
		// [XID] // 0x00000001896F06E0-0x00000001896F0700
		public void RecordChildTransforms(GameObject root) {} // 0x0000000184D7FD30-0x0000000184D7FF60
		// [Conditional] // 0x00000001896F7EB0-0x00000001896F7F00
		// [XID] // 0x00000001896F7EB0-0x00000001896F7F00
		public static void LateTick() {} // 0x0000000184D7FBF0-0x0000000184D7FD30
		// [XID] // 0x0000000189702720-0x0000000189702740
		public void DoLateTick() {} // 0x0000000184D7F970-0x0000000184D7FA40
	}
}
