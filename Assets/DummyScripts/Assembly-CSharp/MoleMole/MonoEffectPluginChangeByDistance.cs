/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginChangeByDistance : BaseMonoEffectPlugin // TypeDefIndex: 19702
	{
		// Fields
		public MatChangerByDistance[] matChangers; // 0x28
		public ScaleChangerByDistance[] scaleChangers; // 0x30
		private List<RatioChangerByDistance> _changers; // 0x38
	
		// Constructors
		public MonoEffectPluginChangeByDistance() {} // 0x0000000184E3A140-0x0000000184E3A1C0
	
		// Methods
		// [XID] // 0x00000001899F54B0-0x00000001899F54D0
		public override void Init() {} // 0x0000000184E399C0-0x0000000184E39A60
		// [XID] // 0x00000001899FCB50-0x00000001899FCB70
		public override void Tick(float inDeltaTime) {} // 0x0000000184E39F50-0x0000000184E3A140
		// [XID] // 0x0000000189A04000-0x0000000189A04020
		public override void Disabled() {} // 0x0000000184E39840-0x0000000184E398E0
		// [XID] // 0x0000000189A0B6B0-0x0000000189A0B6D0
		public override void Destroied() {} // 0x0000000184E397A0-0x0000000184E39840
		// [XID] // 0x0000000189A12ED0-0x0000000189A12EF0
		private void InitChangers() {} // 0x0000000184E39BC0-0x0000000184E39E10
		// [XID] // 0x0000000189A1A250-0x0000000189A1A270
		private void TickChangers(float distance) {} // 0x0000000184E39E10-0x0000000184E39F50
		// [XID] // 0x0000000189A21810-0x0000000189A21830
		private void ClearChangers() {} // 0x0000000184E39A60-0x0000000184E39BC0
	}
}
