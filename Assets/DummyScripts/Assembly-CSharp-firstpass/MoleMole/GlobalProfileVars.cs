/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Beebyte.Obfuscator;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	[Skip] // 0x0000000189622900-0x0000000189622910
	public static class GlobalProfileVars // TypeDefIndex: 10544
	{
		// Fields
		public static ConfigVars c; // 0x00
		public static EntityDebugContext entityDebugContext; // 0x08
		public static DebugVars d; // 0x10
	
		// Nested types
		public class ConfigVars // TypeDefIndex: 10545
		{
			// Fields
			public int AVATAR_USE_DYNAMIC_BONE; // 0x10
			public int FRAME_RATE; // 0x14
			public bool USE_SIGNIFICANCEMANAGER; // 0x18
			public float entityDisableTickDistance; // 0x1C
			public bool D_USE_FORCE_AITARGETPOS; // 0x20
			public Vector3 AITARGETPOS; // 0x24
	
			// Constructors
			public ConfigVars() {} // 0x0000000189BE0330-0x0000000189BE03F0
		}
	
		public class EntityDebugContext // TypeDefIndex: 10546
		{
			// Fields
			public int _entityTickBeforeReadyCount; // 0x10
			public int _entityAppearDisappearCount; // 0x14
			public int _effectCreatedByManagerCount; // 0x18
			public int _effectRejectedByTokenCount; // 0x1C
			public int _effectDirectCreateCount; // 0x20
			public int _thisFrameEffectCreatedByManagerCount; // 0x24
			public int _maxOneFrameEffectCreatedByManagerCount; // 0x28
	
			// Constructors
			public EntityDebugContext() {} // 0x0000000189BE0DC0-0x0000000189BE0F00
	
			// Methods
			// [XID] // 0x0000000189A373A0-0x0000000189A373C0
			public void ResetEntityDebugCount() {} // 0x0000000189BE0870-0x0000000189BE0910
			// [XID] // 0x0000000189A3EAB0-0x0000000189A3EAD0
			public void IncreaseEntityTickBeforeReadyCount() {} // 0x0000000189BE0720-0x0000000189BE07C0
			// [XID] // 0x0000000189A46180-0x0000000189A461A0
			public void IncreaseEntityAppearDisappearCount() {} // 0x0000000189BE0680-0x0000000189BE0720
			// [XID] // 0x0000000189A4D8F0-0x0000000189A4D910
			public void ResetEffectDebugCount() {} // 0x0000000189BE07C0-0x0000000189BE0870
			// [XID] // 0x0000000189A55110-0x0000000189A55130
			public void IncreaseEffectCreatedByManagerCount() {} // 0x0000000189BE04A0-0x0000000189BE0540
			// [XID] // 0x0000000189BC3DE0-0x0000000189BC3E00
			public void IncreaseEffectRejectedByTokenCount() {} // 0x0000000189BE05E0-0x0000000189BE0680
			// [XID] // 0x00000001896D7240-0x00000001896D7260
			public void IncreaseEffectDirectCreateCount() {} // 0x0000000189BE0540-0x0000000189BE05E0
			// [XID] // 0x0000000189A6BC40-0x0000000189A6BC60
			public void ResteOneFrameStats() {} // 0x0000000189BE0910-0x0000000189BE0A00
			// [XID] // 0x0000000189A733C0-0x0000000189A733E0
			public override string ToString() => default; // 0x0000000189BE0A00-0x0000000189BE0D50
		}
	
		public class DebugVars // TypeDefIndex: 10547
		{
			// Fields
			public bool statShutdownSliceFrameWatch; // 0x10
			public bool forbidMonsterAppearForStat; // 0x11
			public bool forbidGadgetAppearForStat; // 0x12
			public bool forbidNPCAppearForStat; // 0x13
			public bool forbidCacheOneUI; // 0x14
			public bool forbidPostProcess; // 0x15
			public bool displaySliceFrameInProfiler; // 0x16
			public bool forbidLog; // 0x17
	
			// Constructors
			public DebugVars() {} // 0x0000000189BE03F0-0x0000000189BE04A0
		}
	
		// Constructors
		static GlobalProfileVars() {} // 0x0000000189BE5FF0-0x0000000189BE6190
	}
}
