/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace VLB
{
	// [HelpURL] // 0x0000000189B52A40-0x0000000189B52A70
	public class Config : ScriptableObject // TypeDefIndex: 10195
	{
		// Fields
		public int geometryLayerID; // 0x18
		public string geometryTag; // 0x20
		// [FormerlySerializedAs] // 0x0000000189B5BE40-0x0000000189B5BE90
		[HighlightNull] // 0x0000000189B5BE40-0x0000000189B5BE90
		public Shader beamShader; // 0x28
		// [Range] // 0x0000000189838A40-0x0000000189838A60
		public float globalNoiseScale; // 0x30
		public Vector3 globalNoiseVelocity; // 0x34
		[HighlightNull] // 0x0000000189B766B0-0x0000000189B766C0
		public TextAsset noise3DData; // 0x40
		public int noise3DSize; // 0x48
		[HighlightNull] // 0x0000000189B766B0-0x0000000189B766C0
		public ParticleSystem dustParticlesPrefab; // 0x50
		private static Config m_Instance; // 0x00
	
		// Properties
		public Vector4 globalNoiseParam { /* [XID] */ /* 0x0000000189B46AC0-0x0000000189B46AE0 */ get => default; } // 0x0000000186E94D40-0x0000000186E94E40 
		public static Config Instance { /* [XID] */ /* 0x0000000189B940E0-0x0000000189B94100 */ get => default; } // 0x0000000186E94AF0-0x0000000186E94D40 
	
		// Constructors
		public Config() {} // 0x0000000186E94A10-0x0000000186E94AF0
		static Config() {} // 0x0000000186E949B0-0x0000000186E94A10
	
		// Methods
		// [XID] // 0x0000000189B85960-0x0000000189B85980
		public void Reset() {} // 0x0000000186E947E0-0x0000000186E949B0
		// [XID] // 0x0000000189B8C7F0-0x0000000189B8C810
		public ParticleSystem NewVolumetricDustParticles() => default; // 0x0000000186E945E0-0x0000000186E947E0
	}
}
