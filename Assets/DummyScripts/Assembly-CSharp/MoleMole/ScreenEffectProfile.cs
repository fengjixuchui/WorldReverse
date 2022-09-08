/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x00000001895ED560-0x00000001895ED5A0
	public class ScreenEffectProfile : ScriptableObject // TypeDefIndex: 26514
	{
		// Fields
		public ScreenEffectProfileItem[] profiles; // 0x18
	
		// Nested types
		[Serializable]
		public class ScreenEffectProfileItem // TypeDefIndex: 26515
		{
			// Fields
			public Color _BrightColor; // 0x10
			public Color _DarkColor; // 0x20
			public float _Brightness; // 0x30
			public float _LerpValue; // 0x34
			public bool _Twinkle; // 0x38
			public float _TwinkleRange; // 0x3C
			public float _Speed; // 0x40
			public Texture2D _MaskTex; // 0x48
			public float _MaskScale; // 0x50
			public Texture2D _DetailTex; // 0x58
			public Vector4 _DetailTexTiling; // 0x60
			public float _DetailScale; // 0x70
			public bool _FinalBlendMode; // 0x74
			public bool _MaskBlendMode; // 0x75
			public bool _DissolveMode; // 0x76
			public float _DissolveValue; // 0x78
			public float _NoiseScale; // 0x7C
	
			// Constructors
			public ScreenEffectProfileItem() {} // 0x0000000184EF0060-0x0000000184EF0180
		}
	
		// Constructors
		public ScreenEffectProfile() {} // 0x0000000184EF0180-0x0000000184EF01E0
	}
}
