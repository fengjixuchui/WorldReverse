/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoTestDvalinS04 : MonoStageScript // TypeDefIndex: 27793
	{
		// Fields
		public GameObject bornObject; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public TestDvalinPlatform[] platforms; // 0x20
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public TestDvalinAchorPoint[] anchors; // 0x28
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public TestDvalinEdgePoint[] edges; // 0x30
		private bool _levelReady; // 0x38
		private int _waitForReady; // 0x3C
		private Dictionary<int, TestDvalinPlatform> _platforms; // 0x40
		private Dictionary<int, TestDvalinAchorPoint> _anchors; // 0x48
		private Dictionary<int, TestDvalinEdgePoint> _edges; // 0x50
		private List<Tuple<int, float>> _tempAnchorAngles; // 0x58
	
		// Constructors
		public MonoTestDvalinS04() {} // 0x0000000183B65BB0-0x0000000183B65CB0
	
		// Methods
		// [XID] // 0x0000000189A0CA70-0x0000000189A0CA90
		private void Start() {} // 0x0000000183B658F0-0x0000000183B659F0
		[DebuggerHidden] // 0x0000000189A143A0-0x0000000189A143E0
		// [XID] // 0x0000000189A143A0-0x0000000189A143E0
		private IEnumerator LevelStart() => default; // 0x0000000183B65080-0x0000000183B65190
		private void InitDict<T>(Dictionary<int, T> dic, T[] list)
			where T : TestDvalinItem {}
		// [XID] // 0x0000000189A1E600-0x0000000189A1E620
		public TestDvalinAchorPoint CalcAnchorPoint(Vector3 targetPos) => default; // 0x0000000183B64550-0x0000000183B64D20
		// [XID] // 0x0000000189A25D40-0x0000000189A25D60
		private void RegistActionPoints(TestDvalinItem[] points) {} // 0x0000000183B65610-0x0000000183B658F0
		// [XID] // 0x0000000189A2D180-0x0000000189A2D1A0
		public override void OnEntityRegisit(BaseEntity entity, string alias) {} // 0x0000000183B65190-0x0000000183B65470
		// [XID] // 0x0000000189A34B40-0x0000000189A34B60
		private TestDvalinPlatform GetPlatformByRuntimeID(uint ruitimeID) => default; // 0x0000000183B64F20-0x0000000183B65080
		// [XID] // 0x0000000189A3BF50-0x0000000189A3BF70
		private TestDvalinPlatform GetPlatformByConfigID(uint configID) => default; // 0x0000000183B64DD0-0x0000000183B64F20
		// [XID] // 0x0000000189A43B80-0x0000000189A43BA0
		public bool CheckReady() => default; // 0x0000000183B64D20-0x0000000183B64DD0
		// [XID] // 0x0000000189A4B030-0x0000000189A4B050
		public override void OnEntitySync(BaseEntity entity, string alias) {} // 0x0000000183B65470-0x0000000183B65610
	}
}
