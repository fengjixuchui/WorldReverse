/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace EffectChecker
{
	[CreateAssetMenu] // 0x000000018996DBB0-0x000000018996DC00
	public class EffectCheckSetting : ScriptableObject // TypeDefIndex: 19789
	{
		// Fields
		public Font labelsFont; // 0x18
		public Color fontColor; // 0x20
		public int fontSize; // 0x30
		public int instanceCount; // 0x34
		public float lineSpacing; // 0x38
		public int countersSpacing; // 0x3C
		public float effectUIScale; // 0x40
		public float defaultBoundsSize; // 0x44
		public bool showBackground; // 0x48
		public Color backgroundColor; // 0x4C
		public GroupAnchor tickTimeAnchor; // 0x5C
		public DataDisplaySetting emitterNormal; // 0x60
		public DataDisplaySetting emitterWarning; // 0x68
		public DataDisplaySetting emitterCritical; // 0x70
		public bool showTickTime; // 0x78
		public bool showEmitter; // 0x79
		public bool showTotal; // 0x7A
		public bool showLoadTime; // 0x7B
		public DataDisplaySetting totalNormal; // 0x80
		public DataDisplaySetting totalWarning; // 0x88
		public DataDisplaySetting totalCritical; // 0x90
		public DataDisplaySetting loadTimeNormal; // 0x98
		public DataDisplaySetting loadTimeWarning; // 0xA0
		public DataDisplaySetting loadTimeCritical; // 0xA8
		public FontStyle totalFontStyle; // 0xB0
		public GroupAnchor overdrawAnchor; // 0xB4
		public DataDisplaySetting pixelCountNormal; // 0xB8
		public DataDisplaySetting pixelCountWarning; // 0xC0
		public DataDisplaySetting pixelCountCritical; // 0xC8
		public bool showOverdraw; // 0xD0
		public bool showPixelCount; // 0xD1
		public bool showScreenRatio; // 0xD2
		public DataDisplaySetting screenRatioNormal; // 0xD8
		public DataDisplaySetting screenRatioWarning; // 0xE0
		public DataDisplaySetting screenRatioCritical; // 0xE8
		public bool heatMapMode; // 0xF0
		public int maxLayerCount; // 0xF4
		public GroupAnchor drawCallsAnchor; // 0xF8
		public bool showDrawCall; // 0xFC
		public bool showTotalDrawCall; // 0xFD
		public bool showDrawCallsRatio; // 0xFE
		public DataDisplaySetting totalDrawCallsNormal; // 0x100
		public DataDisplaySetting totalDrawCallsWarning; // 0x108
		public DataDisplaySetting totalDrawCallsCritical; // 0x110
		public bool showParticlesAndVertexes; // 0x118
		public GroupAnchor particlesAndVertexeAnchor; // 0x11C
		public Color particleFontColor; // 0x120
		public bool showParticleCounts; // 0x130
		public bool showVertexes; // 0x131
		public DataDisplaySetting vertexesNormal; // 0x138
		public DataDisplaySetting vertexesWarning; // 0x140
		public DataDisplaySetting vertexesCritical; // 0x148
		public bool showProgressInfo; // 0x150
		public bool showTextureInfo; // 0x151
		public GroupAnchor progressInfoAnchor; // 0x154
		public float motionRadius; // 0x158
		public float motionSpeed; // 0x15C
		public bool orbitMode; // 0x160
	
		// Nested types
		[Serializable]
		public class DataDisplaySetting // TypeDefIndex: 19790
		{
			// Fields
			public Color color; // 0x10
			public float minLimit; // 0x20
			public float maxLimit; // 0x24
	
			// Constructors
			public DataDisplaySetting() {} // 0x0000000182BC98D0-0x0000000182BC9950
		}
	
		public enum GroupAnchor // TypeDefIndex: 19791
		{
			TopLeft = 0,
			TopRight = 1,
			BottomLeft = 2
		}
	
		// Constructors
		public EffectCheckSetting() {} // 0x0000000182BDB9E0-0x0000000182BDBAE0
	}
}
