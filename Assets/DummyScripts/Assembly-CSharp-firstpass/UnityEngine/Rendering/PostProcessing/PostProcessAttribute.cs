/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[AttributeUsage(AttributeTargets.All)] // 0x0000000189B9E360-0x0000000189B9E390
	public sealed class PostProcessAttribute : Attribute // TypeDefIndex: 9469
	{
		// Fields
		public readonly System.Type renderer; // 0x10
		public readonly PostProcessEvent eventType; // 0x18
		public readonly string menuItem; // 0x20
		public readonly bool allowInSceneView; // 0x28
		internal readonly bool builtinEffect; // 0x29
	
		// Constructors
		public PostProcessAttribute() {} // Dummy constructor
		public PostProcessAttribute(System.Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true /* Metadata: 0x00AE596A */) {} // 0x0000000185BFDBD0-0x0000000185BFDC60
		internal PostProcessAttribute(System.Type renderer, string menuItem, bool allowInSceneView = true /* Metadata: 0x00AE596B */) {} // 0x0000000185BFDC60-0x0000000185BFDCF0
	}
}
