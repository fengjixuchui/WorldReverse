/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[Serializable]
	public class GaiaTextureCriteria // TypeDefIndex: 9161
	{
		// Fields
		public int m_textureIdx; // 0x10
		public int m_textureID; // 0x14
		public bool m_isActive; // 0x18
		public bool m_isFoldedOut; // 0x19
		public bool m_checkHeight; // 0x1A
		public float m_minHeight; // 0x1C
		public float m_maxHeight; // 0x20
		public AnimationCurve m_heightCurve; // 0x28
		public bool m_checkSlope; // 0x30
		public float m_minSlope; // 0x34
		public float m_maxSlope; // 0x38
		public AnimationCurve m_slopeCurve; // 0x40
		public GaiaConstants.ImageChannelWithNone m_textureMaskChannel; // 0x48
		public bool m_textureMaskInvert; // 0x4C
		public float m_textureMaskTiling; // 0x50
		public float m_textureMaskPower; // 0x54
	
		// Constructors
		public GaiaTextureCriteria() {} // Dummy constructor
		public GaiaTextureCriteria(int textureNumber, Texture2D texture) {} // 0x0000000185ECCFB0-0x0000000185ECD480
		public GaiaTextureCriteria(GaiaTextureCriteria src) {} // 0x0000000185ECCCA0-0x0000000185ECCFB0
	
		// Methods
		// [XID] // 0x00000001899D0B60-0x00000001899D0B80
		private AnimationCurve CopyCurve(AnimationCurve src) => default; // 0x0000000185ECC3A0-0x0000000185ECC5C0
		// [XID] // 0x000000018962E950-0x000000018962E970
		public void WriteFullStream(BinaryWriter sw) {} // 0x0000000185ECC720-0x0000000185ECCA40
		// [XID] // 0x0000000189636660-0x0000000189636680
		public void WriteMetaStream(BinaryWriter sw) {} // 0x0000000185ECCA40-0x0000000185ECCCA0
		// [XID] // 0x00000001899C9020-0x00000001899C9040
		public void WriteCurvesStream(BinaryWriter sw) {} // 0x0000000185ECC5C0-0x0000000185ECC720
	}
}
