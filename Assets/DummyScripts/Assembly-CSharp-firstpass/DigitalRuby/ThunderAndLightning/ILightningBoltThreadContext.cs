/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public interface ILightningBoltThreadContext // TypeDefIndex: 9650
	{
		// Methods
		void ForceClear();
		void StartNotifyBolt(LightningBolt blot, LightningBoltDependencies dependencies, LightningBoltParameters p, Transform transform, Vector3 start, Vector3 end);
		void EnableCurrentLineRendererFromThread(LightningBolt blot);
		void EnableAndGetOrCreateLineRenderer(LightningBolt blot, ThreadCreateRenderState state);
		void RenderParticleSystems(LightningBolt blot, Vector3 start, Vector3 end, float trunkWidth, float lifeTime, float delaySeconds);
		ThreadCreateRenderState CreateThreadRenderState();
		void ReleaseThreadCreateRenderState(ThreadCreateRenderState state);
	}
}
