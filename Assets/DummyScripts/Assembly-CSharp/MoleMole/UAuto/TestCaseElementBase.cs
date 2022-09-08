/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public sealed class TestCaseElementBase : TestCaseBase // TypeDefIndex: 28210
	{
		// Fields
		public const int checkTimeout = 10; // Metadata: 0x00B0D4B9
		public const int checkTimeoutLong = 20; // Metadata: 0x00B0D4BD
		private List<MonoEffectProxy> _effectProxyListCache; // 0x198
	
		// Constructors
		public TestCaseElementBase() {} // 0x0000000184F92FB0-0x0000000184F93070
	
		// Methods
		~TestCaseElementBase() {} // 0x0000000184F92DC0-0x0000000184F92E30
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckElementContain(string ele, BaseEntity ent = null) => default; // 0x0000000184F92080-0x0000000184F92160
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckElementRemove(string ele, BaseEntity ent = null) => default; // 0x0000000184F92160-0x0000000184F92240
		public void RemoveEntity(BaseEntity entity) {} // 0x0000000184F92E30-0x0000000184F92ED0
		public void ResetText() {} // 0x0000000184F92ED0-0x0000000184F92FB0
		public void CreateGadget(uint gadgetId, uint campId, Vector3 position, uint targetId = 0 /* Metadata: 0x00B0D4B1 */, uint ownerId = 0 /* Metadata: 0x00B0D4B5 */) {} // 0x0000000184F92920-0x0000000184F92BC0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckEntityRemove(uint entityRuntimeId) => default; // 0x0000000184F92240-0x0000000184F92310
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckAnimateOn(string animate, BaseEntity ent = null) => default; // 0x0000000184F91EC0-0x0000000184F91FA0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckWaterReaction(string ele, BaseEntity ent = null) => default; // 0x0000000184F92840-0x0000000184F92920
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckGrassReaction(string ele, BaseEntity ent = null) => default; // 0x0000000184F924D0-0x0000000184F925B0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckElectricReaction(string ele, BaseEntity ent = null) => default; // 0x0000000184F91FA0-0x0000000184F92080
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckFireReaction(string ele, BaseEntity ent = null) => default; // 0x0000000184F92310-0x0000000184F923F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckIceReaction(string ele, BaseEntity ent = null) => default; // 0x0000000184F925B0-0x0000000184F92690
		public bool EntityHasEffect(BaseEntity entity, string effect) => default; // 0x0000000184F92BC0-0x0000000184F92DC0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckWaterEnvReaction(string ele) => default; // 0x0000000184F92760-0x0000000184F92840
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckWaterEnvReactionRemove(string ele) => default; // 0x0000000184F92690-0x0000000184F92760
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckGrassEnvReaction(string ele) => default; // 0x0000000184F923F0-0x0000000184F924D0
	}
}
