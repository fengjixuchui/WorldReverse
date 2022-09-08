/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	// [PostProcess] // 0x0000000189747060-0x00000001897470D0
	public sealed class ElementView : PostProcessEffectSettings // TypeDefIndex: 9482
	{
		// Fields
		public static readonly int ELEMENT_VIEW_ELE_MAX_NUM; // 0x00
		// [Range] // 0x0000000189927470-0x0000000189927490
		public FloatParameter transition; // 0x30
		// [Range] // 0x000000018975BB30-0x000000018975BB50
		public FloatParameter range; // 0x38
		// [Range] // 0x00000001897634E0-0x0000000189763530
		// [Tooltip] // 0x00000001897634E0-0x0000000189763530
		public FloatParameter rangeFadingRatio; // 0x40
		// [Header] // 0x000000018976EFA0-0x000000018976EFF0
		[Space] // 0x000000018976EFA0-0x000000018976EFF0
		public ColorParameter sceneBackgroundColor; // 0x48
		public ColorParameter sceneLightColor; // 0x50
		// [Range] // 0x000000018977B0B0-0x000000018977B0F0
		[Space] // 0x000000018977B0B0-0x000000018977B0F0
		public FloatParameter scenePatternLuminanceScale; // 0x58
		public TextureParameter scenePatternTexture; // 0x60
		// [Range] // 0x0000000189B49D30-0x0000000189B49D50
		public FloatParameter scenePatternUVScale; // 0x68
		// [Range] // 0x000000018978CE90-0x000000018978CED0
		[Space] // 0x000000018978CE90-0x000000018978CED0
		public FloatParameter sceneWaveLuminanceScale; // 0x70
		public TextureParameter sceneWaveTexture; // 0x78
		// [Range] // 0x0000000189797800-0x0000000189797820
		public FloatParameter sceneWaveUVScale; // 0x80
		// [Range] // 0x0000000189B49D30-0x0000000189B49D50
		public FloatParameter sceneWaveTextureScale; // 0x88
		// [Range] // 0x0000000189927470-0x0000000189927490
		public FloatParameter sceneWaveDistanceScale; // 0x90
		// [Range] // 0x0000000189927470-0x0000000189927490
		public FloatParameter sceneWaveWidth; // 0x98
		// [Range] // 0x0000000189927470-0x0000000189927490
		public FloatParameter sceneWaveAnmSpeed; // 0xA0
		// [Range] // 0x00000001897BE240-0x00000001897BE280
		[Space] // 0x00000001897BE240-0x00000001897BE280
		public FloatParameter sceneWaveBandLuminanceScale; // 0xA8
		// [Range] // 0x0000000189927470-0x0000000189927490
		public FloatParameter sceneWaveBandWidth; // 0xB0
		// [Range] // 0x0000000189927470-0x0000000189927490
		public FloatParameter sceneWaveBandAnmSpeed; // 0xB8
		// [Range] // 0x00000001897D7840-0x00000001897D7880
		[Space] // 0x00000001897D7840-0x00000001897D7880
		public FloatParameter sceneBlastWaveBandLuminanceScale; // 0xC0
		// [Range] // 0x0000000189927470-0x0000000189927490
		public FloatParameter sceneBlastWaveBandWidth; // 0xC8
		// [Range] // 0x00000001897E9750-0x00000001897E97A0
		// [Tooltip] // 0x00000001897E9750-0x00000001897E97A0
		public FloatParameter sceneBlastWaveBandDuration; // 0xD0
		// [Header] // 0x00000001897F59A0-0x00000001897F59F0
		[Space] // 0x00000001897F59A0-0x00000001897F59F0
		public ElementViewColorsParameters colors; // 0xD8
		// [Range] // 0x0000000189927470-0x0000000189927490
		public FloatParameter elementLumScale; // 0xE0
		public TextureParameter elementPatternTexture; // 0xE8
		// [Range] // 0x0000000189808F90-0x0000000189808FB0
		public FloatParameter elementPatternUVScale; // 0xF0
		// [Range] // 0x0000000189808F90-0x0000000189808FB0
		public FloatParameter elementPatternAnmSpeed; // 0xF8
		// [Range] // 0x0000000189B49D30-0x0000000189B49D50
		public FloatParameter elementPatternLuminanceScale; // 0x100
		// [Range] // 0x0000000189B49D30-0x0000000189B49D50
		public FloatParameter elementRimLuminanceScale; // 0x108
	
		// Constructors
		public ElementView() {} // 0x000000018605BB10-0x000000018605C820
		static ElementView() {} // 0x000000018605BAB0-0x000000018605BB10
	
		// Methods
		// [XID] // 0x0000000189826EE0-0x0000000189826F00
		public override CameraEvent CommandBufferEvent() => default; // 0x000000018605B9A0-0x000000018605BA40
	}
}
