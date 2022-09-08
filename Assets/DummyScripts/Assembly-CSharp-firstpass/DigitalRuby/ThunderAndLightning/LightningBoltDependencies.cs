/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltDependencies // TypeDefIndex: 9635
	{
		// Fields
		public GameObject Parent; // 0x10
		public UnityEngine.Material LightningMaterialMesh; // 0x18
		public UnityEngine.Material LightningMaterialMeshNoGlow; // 0x20
		public ParticleSystem OriginParticleSystem; // 0x28
		public ParticleSystem DestParticleSystem; // 0x30
		public Vector3 CameraPos; // 0x38
		public bool CameraIsOrthographic; // 0x44
		public CameraMode CameraMode; // 0x48
		public bool UseWorldSpace; // 0x4C
		public string SortLayerName; // 0x50
		public int SortOrderInLayer; // 0x58
		public ICollection<LightningBoltParameters> Parameters; // 0x60
		public LightningThreadState ThreadState; // 0x68
		public ILightningBoltThreadContext ThreadContext; // 0x70
		public Func<IEnumerator, Coroutine> StartCoroutine; // 0x78
		public Action<Light> LightAdded; // 0x80
		public Action<Light> LightRemoved; // 0x88
		public Action<LightningBolt> AddActiveBolt; // 0x90
		public Action<LightningBoltDependencies> ReturnToCache; // 0x98
		public Action<LightningBoltParameters, Vector3, Vector3> LightningBoltStarted; // 0xA0
		public Action<LightningBoltParameters, Vector3, Vector3> LightningBoltEnded; // 0xA8
	
		// Constructors
		public LightningBoltDependencies() {} // 0x0000000186037750-0x00000001860377B0
	}
}
