/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using CriMana;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CriMana.Detail
{
	public static class AutoResisterRendererResourceFactories // TypeDefIndex: 7168
	{
		// Nested types
		// [RendererResourceFactoryPriority] // 0x000000018981B140-0x000000018981B160
		public class RendererResourceFactoryH264Yuv : RendererResourceFactory // TypeDefIndex: 7169
		{
			// Constructors
			public RendererResourceFactoryH264Yuv() {} // 0x0000000187A44FF0-0x0000000187A450B0
	
			// Methods
			// [XID] // 0x0000000189822780-0x00000001898227A0
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x0000000187A44D60-0x0000000187A44EB0
			// [XID] // 0x0000000189829F30-0x0000000189829F50
			protected override void OnDisposeManaged() {} // 0x0000000187A44EB0-0x0000000187A44F50
			// [XID] // 0x0000000189831430-0x0000000189831450
			protected override void OnDisposeUnmanaged() {} // 0x0000000187A44F50-0x0000000187A44FF0
		}
	
		// [RendererResourceFactoryPriority] // 0x0000000189838C60-0x0000000189838C80
		public class RendererResourceFactorySofdecPrimeYuv : RendererResourceFactory // TypeDefIndex: 7170
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuv() {} // 0x0000000187A45720-0x0000000187A457E0
	
			// Methods
			// [XID] // 0x0000000189840100-0x0000000189840120
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x0000000187A45480-0x0000000187A455E0
			// [XID] // 0x0000000189A6EA60-0x0000000189A6EA80
			protected override void OnDisposeManaged() {} // 0x0000000187A455E0-0x0000000187A45680
			// [XID] // 0x000000018984EF90-0x000000018984EFB0
			protected override void OnDisposeUnmanaged() {} // 0x0000000187A45680-0x0000000187A45720
		}
	
		// [RendererResourceFactoryPriority] // 0x0000000189855FB0-0x0000000189855FD0
		public class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory // TypeDefIndex: 7171
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuvRawData() {} // 0x0000000187A453C0-0x0000000187A45480
	
			// Methods
			// [XID] // 0x0000000189A7DC80-0x0000000189A7DCA0
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x0000000187A45120-0x0000000187A45280
			// [XID] // 0x0000000189864CD0-0x0000000189864CF0
			protected override void OnDisposeManaged() {} // 0x0000000187A45280-0x0000000187A45320
			// [XID] // 0x00000001897E65B0-0x00000001897E65D0
			protected override void OnDisposeUnmanaged() {} // 0x0000000187A45320-0x0000000187A453C0
		}
	
		// [RendererResourceFactoryPriority] // 0x0000000189873790-0x00000001898737B0
		public class RendererResourceFactoryySofdecVp9Yuv : RendererResourceFactory // TypeDefIndex: 7172
		{
			// Constructors
			public RendererResourceFactoryySofdecVp9Yuv() {} // 0x0000000187A46450-0x0000000187A46510
	
			// Methods
			// [XID] // 0x000000018982CC50-0x000000018982CC70
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x0000000187A461C0-0x0000000187A46310
			// [XID] // 0x0000000189882360-0x0000000189882380
			protected override void OnDisposeManaged() {} // 0x0000000187A46310-0x0000000187A463B0
			// [XID] // 0x0000000189889A00-0x0000000189889A20
			protected override void OnDisposeUnmanaged() {} // 0x0000000187A463B0-0x0000000187A46450
		}
	
		// Methods
		// [XID] // 0x0000000189813680-0x00000001898136A0
		public static void InvokeAutoRegister() {} // 0x0000000187A29C30-0x0000000187A2A1F0
	}
}
